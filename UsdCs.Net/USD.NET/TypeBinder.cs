using System;
using System.Collections.Generic;
using System.Reflection;
using pxr;

namespace USD.NET
{
	public class TypeBinder
	{
		public static bool EnableCodeGeneration = true;

		private static Dictionary<Type, UsdTypeBinding> bindings = new Dictionary<Type, UsdTypeBinding>();

		private Dictionary<string, string> typeNameMapping = new Dictionary<string, string>();

		private Dictionary<Type, Dictionary<TfToken, Enum>> enumMaps = new Dictionary<Type, Dictionary<TfToken, Enum>>();

		private Dictionary<string, string> typeAliases = new Dictionary<string, string>();

		public TypeBinder()
		{
			typeNameMapping.Add("Boolean", "bool");
			typeNameMapping.Add("Byte", "byte");
			typeNameMapping.Add("Int32", "int");
			typeNameMapping.Add("UInt32", "uint");
			typeNameMapping.Add("Int64", "long");
			typeNameMapping.Add("UInt64", "ulong");
			typeNameMapping.Add("String", "string");
			typeNameMapping.Add("Single", "float");
			typeNameMapping.Add("Double", "double");
			RegisterIntrinsicTypes();
		}

		private bool IsCodeGenEnabled()
		{
			return false;
		}

		public bool GetReverseBinding(SdfValueTypeName key, out UsdTypeBinding binding)
		{
			if (!typeAliases.TryGetValue(key.GetAsToken(), out var value))
			{
				value = key.GetAsToken();
			}
			foreach (KeyValuePair<Type, UsdTypeBinding> binding2 in bindings)
			{
				if (binding2.Value.sdfTypeName.GetAsToken() == value)
				{
					binding = binding2.Value;
					return true;
				}
			}
			binding = default(UsdTypeBinding);
			return false;
		}

		public bool GetReverseBinding(Type key, out UsdTypeBinding binding)
		{
			foreach (KeyValuePair<Type, UsdTypeBinding> binding2 in bindings)
			{
				if (binding2.Value.toCsObject.Method.GetParameters()[0].ParameterType == key)
				{
					binding = binding2.Value;
					return true;
				}
			}
			binding = default(UsdTypeBinding);
			return false;
		}

		public bool GetBinding(Type key, out UsdTypeBinding binding)
		{
			lock (UsdIo.Bindings)
			{
				if (bindings.TryGetValue(key, out binding))
				{
					return true;
				}
				if (key.IsGenericType && key.GetGenericTypeDefinition() == typeof(Nullable<>) && bindings.TryGetValue(key.GetGenericArguments()[0], out binding))
				{
					return true;
				}
				if (!key.IsEnum)
				{
					return false;
				}
				binding = BindEnum(key);
				bindings.Add(key, binding);
			}
			return true;
		}

		public void BindType(Type csType, UsdTypeBinding binding)
		{
			bindings[csType] = binding;
		}

		public void BindArrayType<ConverterT>(Type csType, Type vtArrayType, SdfValueTypeName sdfName, string methodNamePrefix = "")
		{
			MethodInfo method = typeof(ConverterT).GetMethod(methodNamePrefix + "ToVtArray", new Type[1] { csType });
			if (method == null)
			{
				throw new ArgumentException($"No ToVtArray overload found for type {csType.ToString()}");
			}
			MethodInfo vtToCsArray = typeof(ConverterT).GetMethod(methodNamePrefix + "FromVtArray", new Type[1] { vtArrayType });
			if (vtToCsArray == null)
			{
				throw new ArgumentException($"No FromVtArray overload found for type {vtArrayType.ToString()}");
			}
			MethodInfo valToVtArray = typeof(Vt).GetMethod("VtValueTo" + vtArrayType.Name, new Type[2]
			{
				typeof(VtValue),
				vtArrayType.MakeByRefType()
			});
			if (valToVtArray == null)
			{
				throw new ArgumentException($"No VtValueTo... converter found for type {vtArrayType.ToString()}");
			}
			ToCsConverter toCsConverter = null;
			ToVtConverter toVtConverter = null;
			if (!IsCodeGenEnabled())
			{
				toCsConverter = (VtValue vtValue) => ToCsDynamicConvertHelper(vtValue, vtArrayType, valToVtArray, vtToCsArray);
				toVtConverter = CsArrayToVtValue(method, csType, vtArrayType);
			}
			bindings[csType] = new UsdTypeBinding(toVtConverter, toCsConverter, sdfName);
		}

		private ToVtConverter CsArrayToVtValue(MethodInfo csToVtArray, Type csType, Type vtArrayType)
		{
			ConstructorInfo ctor = typeof(VtValue).GetConstructor(new Type[1] { vtArrayType });
			return (object csArray) => (VtValue)ctor.Invoke(new object[1] { Convert.ChangeType(csToVtArray.Invoke(null, new object[1] { Convert.ChangeType(csArray, csType) }), vtArrayType) });
		}

		private object ToCsDynamicConvertHelper(VtValue vtValue, Type vtArrayType, MethodInfo valToVtArray, MethodInfo vtToCsArray)
		{
			object[] array = new object[2] { vtValue, null };
			valToVtArray.Invoke(null, array);
			return vtToCsArray.Invoke(null, new object[1] { array[1] });
		}

		private object ToCsConvertHelper(VtValue val, Type vtArrayType, ToCsCopyConverter toCs)
		{
			object obj = UsdIo.ArrayAllocator.MallocHandle(vtArrayType);
			object result = toCs(val, obj);
			UsdIo.ArrayAllocator.FreeHandle(vtArrayType, obj);
			return result;
		}

		public void BindNativeType(Type csType, SdfValueTypeName sdfName)
		{
			if (!typeNameMapping.TryGetValue(csType.Name, out var value))
			{
				value = csType.Name;
			}
			MethodInfo converter = typeof(Vt).GetMethod("VtValueTo" + value, new Type[1] { typeof(VtValue) });
			if (converter == null)
			{
				throw new ArgumentException($"No VtValueTo... converter found for type {csType.ToString()}, VtValueTo{value}");
			}
			bindings[csType] = new UsdTypeBinding(DefaultConversions.ToVtValue, (VtValue x) => converter.Invoke(null, new object[1] { x }), sdfName);
		}

		private UsdTypeBinding BindEnum(Type enumType)
		{
			if (!enumType.IsEnum)
			{
				throw new ArgumentException("BindEnum is only applicable to enum types");
			}
			return new UsdTypeBinding((object x) => new VtValue(new TfToken(x.ToString()[0].ToString().ToLower() + x.ToString().Substring(1))), (VtValue x) => UsdEnumToCs(x, enumType), SdfValueTypeNames.Token);
		}

		private object UsdEnumToCs(VtValue vtValue, Type enumType)
		{
			TfToken output = (TfToken)UsdIo.ArrayAllocator.MallocHandle(typeof(TfToken));
			try
			{
				Vt.VtValueToTfToken(vtValue, out output);
				Enum value2;
				lock (UsdIo.Bindings)
				{
					if (!enumMaps.TryGetValue(enumType, out var value))
					{
						value = new Dictionary<TfToken, Enum>();
						enumMaps.Add(enumType, value);
					}
					if (!value.TryGetValue(output, out value2))
					{
						string text = output.ToString();
						value2 = (Enum)Enum.Parse(enumType, char.ToUpper(text[0]) + text.Substring(1));
						value.Add(output, value2);
					}
				}
				return value2;
			}
			finally
			{
				UsdIo.ArrayAllocator.FreeHandle(output);
			}
		}

		private VtValue GuidToVt_Bytes(object guid)
		{
			byte[] input = ((Guid)guid).ToByteArray();
			return new VtValue(IntrinsicTypeConverter.ToVtArray(input));
		}

		private object GuidToCs_Bytes(VtValue vtValue)
		{
			VtUCharArray output = (VtUCharArray)UsdIo.ArrayAllocator.MallocHandle(typeof(VtUCharArray));
			Vt.VtValueToVtUCharArray(vtValue, out output);
			byte[] array = IntrinsicTypeConverter.FromVtArray(output);
			Guid guid = new Guid(array);
			UsdIo.ArrayAllocator.FreeHandle(output.GetType(), output);
			UsdIo.ArrayAllocator.Free(array.GetType(), (uint)array.Length, array);
			return guid;
		}

		public void AddTypeAlias(SdfValueTypeName alias, SdfValueTypeName target)
		{
			typeAliases.Add(alias.GetAsToken(), target.GetAsToken());
		}

		public bool RemoveTypeAlias(SdfValueTypeName alias)
		{
			return typeAliases.Remove(alias.GetAsToken());
		}

		private void RegisterIntrinsicTypes()
		{
			BindNativeType(typeof(bool), SdfValueTypeNames.Bool);
			BindNativeType(typeof(VtBoolArray), SdfValueTypeNames.BoolArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(bool[]), typeof(VtBoolArray), SdfValueTypeNames.BoolArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<bool>), typeof(VtBoolArray), SdfValueTypeNames.BoolArray, "List");
			BindNativeType(typeof(byte), SdfValueTypeNames.UChar);
			BindNativeType(typeof(VtUCharArray), SdfValueTypeNames.UCharArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(byte[]), typeof(VtUCharArray), SdfValueTypeNames.UCharArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<byte>), typeof(VtUCharArray), SdfValueTypeNames.UCharArray, "List");
			BindNativeType(typeof(string), SdfValueTypeNames.String);
			BindNativeType(typeof(TfToken), SdfValueTypeNames.Token);
			BindNativeType(typeof(VtStringArray), SdfValueTypeNames.StringArray);
			BindNativeType(typeof(VtTokenArray), SdfValueTypeNames.TokenArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(string[]), typeof(VtTokenArray), SdfValueTypeNames.TokenArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<string>), typeof(VtTokenArray), SdfValueTypeNames.TokenArray, "List");
			BindNativeType(typeof(SdfAssetPath), SdfValueTypeNames.Asset);
			BindArrayType<IntrinsicTypeConverter>(typeof(SdfAssetPath[]), typeof(SdfAssetPathArray), SdfValueTypeNames.AssetArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<SdfAssetPath>), typeof(SdfAssetPathArray), SdfValueTypeNames.AssetArray, "List");
			BindNativeType(typeof(int), SdfValueTypeNames.Int);
			BindNativeType(typeof(VtIntArray), SdfValueTypeNames.IntArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(int[]), typeof(VtIntArray), SdfValueTypeNames.IntArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<int>), typeof(VtIntArray), SdfValueTypeNames.IntArray, "List");
			BindNativeType(typeof(uint), SdfValueTypeNames.UInt);
			BindNativeType(typeof(VtUIntArray), SdfValueTypeNames.UIntArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(uint[]), typeof(VtUIntArray), SdfValueTypeNames.UIntArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<uint>), typeof(VtUIntArray), SdfValueTypeNames.UIntArray, "List");
			BindNativeType(typeof(long), SdfValueTypeNames.Int64);
			BindNativeType(typeof(VtInt64Array), SdfValueTypeNames.Int64Array);
			BindArrayType<IntrinsicTypeConverter>(typeof(long[]), typeof(VtInt64Array), SdfValueTypeNames.Int64Array);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<long>), typeof(VtInt64Array), SdfValueTypeNames.Int64Array, "List");
			BindNativeType(typeof(ulong), SdfValueTypeNames.UInt64);
			BindNativeType(typeof(VtUInt64Array), SdfValueTypeNames.UInt64Array);
			BindArrayType<IntrinsicTypeConverter>(typeof(ulong[]), typeof(VtUInt64Array), SdfValueTypeNames.UInt64Array);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<ulong>), typeof(VtUInt64Array), SdfValueTypeNames.UInt64Array, "List");
			BindNativeType(typeof(GfHalf), SdfValueTypeNames.Half);
			BindNativeType(typeof(VtHalfArray), SdfValueTypeNames.HalfArray);
			BindNativeType(typeof(VtVec2hArray), SdfValueTypeNames.Half2Array);
			BindNativeType(typeof(VtVec3hArray), SdfValueTypeNames.Half3Array);
			BindNativeType(typeof(VtVec4hArray), SdfValueTypeNames.Half4Array);
			BindNativeType(typeof(float), SdfValueTypeNames.Float);
			BindNativeType(typeof(VtFloatArray), SdfValueTypeNames.FloatArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(float[]), typeof(VtFloatArray), SdfValueTypeNames.FloatArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<float>), typeof(VtFloatArray), SdfValueTypeNames.FloatArray, "List");
			BindNativeType(typeof(double), SdfValueTypeNames.Double);
			BindNativeType(typeof(VtDoubleArray), SdfValueTypeNames.DoubleArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(double[]), typeof(VtDoubleArray), SdfValueTypeNames.DoubleArray);
			BindArrayType<IntrinsicTypeConverter>(typeof(List<double>), typeof(VtDoubleArray), SdfValueTypeNames.DoubleArray, "List");
			BindNativeType(typeof(GfQuath), SdfValueTypeNames.Quath);
			BindNativeType(typeof(VtQuathArray), SdfValueTypeNames.QuathArray);
			BindNativeType(typeof(GfQuatf), SdfValueTypeNames.Quatf);
			BindNativeType(typeof(VtQuatfArray), SdfValueTypeNames.QuatfArray);
			BindNativeType(typeof(GfQuatd), SdfValueTypeNames.Quatd);
			BindNativeType(typeof(VtQuatdArray), SdfValueTypeNames.QuatdArray);
			BindNativeType(typeof(GfVec2i), SdfValueTypeNames.Int2);
			BindNativeType(typeof(GfVec2h), SdfValueTypeNames.Half2);
			BindNativeType(typeof(GfVec2f), SdfValueTypeNames.Float2);
			BindNativeType(typeof(GfVec3i), SdfValueTypeNames.Int3);
			BindNativeType(typeof(GfVec3h), SdfValueTypeNames.Half3);
			BindNativeType(typeof(GfVec3f), SdfValueTypeNames.Float3);
			BindNativeType(typeof(GfVec3d), SdfValueTypeNames.Double3);
			BindNativeType(typeof(GfVec4i), SdfValueTypeNames.Int4);
			BindNativeType(typeof(GfVec4h), SdfValueTypeNames.Half4);
			BindNativeType(typeof(GfVec4f), SdfValueTypeNames.Float4);
		}
	}
}
