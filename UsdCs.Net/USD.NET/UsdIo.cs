using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using pxr;

namespace USD.NET
{
	public class UsdIo
	{
		private static readonly UsdTimeCode kDefaultUsdTime = UsdTimeCode.Default();

		public static ArrayPool ArrayAllocator = new ArrayUnpool();

		private static TokenCache sm_tokenCache = new TokenCache();

		private static TypeBinder sm_bindings = new TypeBinder();

		private object m_stageLock;

		private UsdUtilsSparseValueWriter m_sparseValueWriter;

		public static TypeBinder Bindings => sm_bindings;

		public UsdIo(object stageLock)
		{
			m_stageLock = stageLock;
			m_sparseValueWriter = new UsdUtilsSparseValueWriter();
		}

		public void Serialize<T>(T t, UsdPrim prim, UsdTimeCode usdTime, string usdNamespace = null)
		{
			PropertyInfo[] cachedProperties = Reflect.GetCachedProperties(t.GetType());
			FieldInfo[] cachedFields = Reflect.GetCachedFields(t.GetType());
			UsdGeomImageable imgble = new UsdGeomImageable(prim);
			foreach (PropertyInfo propertyInfo in cachedProperties)
			{
				Type type = propertyInfo.PropertyType;
				if (type == typeof(object))
				{
					if (Reflect.IsCustomData(propertyInfo) || Reflect.IsMetadata(propertyInfo))
					{
						throw new ArgumentException("Writing metadata/customdata with type of object is not currently allowed");
					}
					object value = propertyInfo.GetValue(t, null);
					if (value != null)
					{
						type = value.GetType();
					}
				}
				WriteAttr(propertyInfo.Name, type, propertyInfo.GetValue(t, null), usdTime, prim, imgble, propertyInfo, usdNamespace);
			}
			foreach (FieldInfo fieldInfo in cachedFields)
			{
				Type type2 = fieldInfo.FieldType;
				if (type2 == typeof(object))
				{
					if (Reflect.IsCustomData(fieldInfo) || Reflect.IsMetadata(fieldInfo))
					{
						throw new ArgumentException("Writing metadata/customdata with type of object is not currently allowed");
					}
					object value2 = fieldInfo.GetValue(t);
					if (value2 != null)
					{
						type2 = value2.GetType();
					}
				}
				WriteAttr(fieldInfo.Name, type2, fieldInfo.GetValue(t), usdTime, prim, imgble, fieldInfo, usdNamespace);
			}
		}

		public void Deserialize(ref object fieldValue, UsdPrim prim, UsdTimeCode usdTime, FieldInfo field, HashSet<MemberInfo> accessMap, ref bool? mayVary, string usdNamespace = null)
		{
			if (!Reflect.IsNonSerialized(field))
			{
				ReadAttr(field.Name, field.FieldType, ref fieldValue, usdTime, prim, field, accessMap, ref mayVary, usdNamespace);
			}
		}

		public void Deserialize(ref object propValue, UsdPrim prim, UsdTimeCode usdTime, PropertyInfo field, HashSet<MemberInfo> accessMap, ref bool? mayVary, string usdNamespace = null)
		{
			if (!Reflect.IsNonSerialized(field))
			{
				ReadAttr(field.Name, field.PropertyType, ref propValue, usdTime, prim, field, accessMap, ref mayVary, usdNamespace);
			}
		}

		public void Deserialize<T>(T t, UsdPrim prim, UsdTimeCode usdTime, HashSet<MemberInfo> accessMap, ref bool? mayVary, string usdNamespace = null) where T : SampleBase
		{
			if (t == null)
			{
				return;
			}
			PropertyInfo[] cachedProperties = Reflect.GetCachedProperties(t.GetType());
			FieldInfo[] cachedFields = Reflect.GetCachedFields(t.GetType());
			HashSet<MemberInfo> accessMap2 = accessMap;
			bool flag = !mayVary.HasValue;
			if (!mayVary.HasValue)
			{
				accessMap2 = null;
			}
			foreach (PropertyInfo propertyInfo in cachedProperties)
			{
				if (!Reflect.IsNonSerialized(propertyInfo) && (accessMap == null || mayVary.HasValue || accessMap.Contains(propertyInfo)))
				{
					object propValue = propertyInfo.GetValue(t, null);
					Deserialize(ref propValue, prim, usdTime, propertyInfo, accessMap2, ref mayVary, usdNamespace);
					propertyInfo.SetValue(t, propValue, null);
					if (!mayVary.HasValue != flag)
					{
						throw new ApplicationException("Deserialize modified mayVary to be non-null");
					}
				}
			}
			foreach (FieldInfo fieldInfo in cachedFields)
			{
				if (!Reflect.IsNonSerialized(fieldInfo) && (accessMap == null || mayVary.HasValue || accessMap.Contains(fieldInfo)))
				{
					object fieldValue = fieldInfo.GetValue(t);
					Deserialize(ref fieldValue, prim, usdTime, fieldInfo, accessMap2, ref mayVary, usdNamespace);
					fieldInfo.SetValue(t, fieldValue);
					if (!mayVary.HasValue != flag)
					{
						throw new ApplicationException("Deserialize modified mayVary to be non-null");
					}
				}
			}
		}

		private bool WriteAttr(string attrName, Type csType, object csValue, UsdTimeCode usdTime, UsdPrim prim, UsdGeomImageable imgble, MemberInfo memberInfo, string usdNamespace, string srcObject = null)
		{
			if (Reflect.IsNonSerialized(memberInfo))
			{
				Console.WriteLine("Non serialized");
				return true;
			}
			PrimvarBase primvarBase = null;
			if (csType.IsGenericType && csType.GetGenericTypeDefinition() == typeof(Primvar<>))
			{
				if (csValue == null)
				{
					return true;
				}
				primvarBase = (PrimvarBase)csValue;
				csValue = (csValue as ValueAccessor).GetValue();
				if (csValue == null)
				{
					return true;
				}
				csType = csValue.GetType();
			}
			bool flag = Reflect.IsCustomData(memberInfo);
			bool flag2 = Reflect.IsMetadata(memberInfo);
			bool flag3 = Reflect.IsPrimvar(memberInfo);
			bool flag4 = primvarBase != null;
			int primvarElementSize = Reflect.GetPrimvarElementSize(memberInfo);
			string text = IntrinsicTypeConverter.JoinNamespace(usdNamespace, Reflect.GetNamespace(memberInfo));
			if (csValue != null && csType.IsGenericType && csType.GetGenericTypeDefinition() == typeof(Dictionary<, >) && csType.GetGenericArguments()[0] == typeof(string))
			{
				flag4 = csType.GetGenericArguments()[1].IsGenericType && csType.GetGenericArguments()[1].GetGenericTypeDefinition() == typeof(Primvar<>);
				if (!Reflect.ForceNoNamespace(memberInfo) && string.IsNullOrEmpty(Reflect.GetNamespace(memberInfo)))
				{
					usdNamespace = IntrinsicTypeConverter.JoinNamespace(usdNamespace, attrName);
				}
				IDictionary dictionary = csValue as IDictionary;
				foreach (DictionaryEntry item in dictionary)
				{
					object value = item.Value;
					WriteAttr((string)item.Key, value.GetType(), value, usdTime, prim, imgble, memberInfo, usdNamespace, attrName);
				}
				return true;
			}
			TfToken tfToken = sm_tokenCache[attrName];
			if (csType == typeof(Relationship) && csValue != null)
			{
				string[] targetPaths = ((Relationship)csValue).targetPaths;
				if (targetPaths != null)
				{
					string[] array = IntrinsicTypeConverter.JoinNamespace(text, tfToken).Split(':');
					StdStringVector stdStringVector = new StdStringVector(array.Length);
					string[] array2 = array;
					foreach (string x in array2)
					{
						stdStringVector.Add(x);
					}
					UsdRelationship usdRelationship = null;
					lock (m_stageLock)
					{
						usdRelationship = prim.CreateRelationship(stdStringVector, custom: false);
					}
					if (!usdRelationship.IsValid())
					{
						throw new ApplicationException("Failed to create relationship <" + prim.GetPath().AppendProperty(new TfToken(IntrinsicTypeConverter.JoinNamespace(text, tfToken))).ToString() + ">");
					}
					SdfPathVector sdfPathVector = new SdfPathVector();
					string[] targetPaths2 = ((Relationship)csValue).targetPaths;
					foreach (string path in targetPaths2)
					{
						sdfPathVector.Add(new SdfPath(path));
					}
					lock (m_stageLock)
					{
						usdRelationship.SetTargets(sdfPathVector);
					}
				}
				return true;
			}
			Connectable connectable = csValue as Connectable;
			if (connectable != null)
			{
				csType = connectable.GetValueType();
				csValue = connectable.GetValue();
			}
			if (!sm_bindings.GetBinding(csType, out var binding) && !csType.IsEnum)
			{
				if (csValue == null)
				{
					return true;
				}
				if (string.IsNullOrEmpty(text))
				{
					return false;
				}
				SampleBase sampleBase = csValue as SampleBase;
				if (sampleBase == null && csValue != null)
				{
					throw new ArgumentException("Type does not inherit from SampleBase: " + attrName);
				}
				Serialize(csValue, prim, usdTime, text);
				return true;
			}
			SdfVariability variability = Reflect.GetVariability(memberInfo);
			SdfValueTypeName sdfTypeName = binding.sdfTypeName;
			UsdTimeCode time = ((variability == SdfVariability.SdfVariabilityUniform) ? UsdTimeCode.Default() : usdTime);
			bool custom = false;
			UsdAttribute usdAttribute;
			if (flag || flag2)
			{
				usdAttribute = null;
			}
			else if (!flag3 && !flag4)
			{
				if (string.IsNullOrEmpty(text))
				{
					lock (m_stageLock)
					{
						usdAttribute = prim.CreateAttribute(tfToken, csType.IsEnum ? SdfValueTypeNames.Token : sdfTypeName, custom, variability);
					}
				}
				else
				{
					string[] array3 = IntrinsicTypeConverter.JoinNamespace(text, tfToken).Split(':');
					StdStringVector stdStringVector2 = new StdStringVector(array3.Length);
					string[] array4 = array3;
					foreach (string x2 in array4)
					{
						stdStringVector2.Add(x2);
					}
					lock (m_stageLock)
					{
						usdAttribute = prim.CreateAttribute(stdStringVector2, sdfTypeName, custom, variability);
					}
				}
			}
			else
			{
				lock (m_stageLock)
				{
					string s = IntrinsicTypeConverter.JoinNamespace(text, tfToken);
					UsdGeomPrimvarsAPI usdGeomPrimvarsAPI = new UsdGeomPrimvarsAPI(imgble);
					UsdGeomPrimvar usdGeomPrimvar = usdGeomPrimvarsAPI.CreatePrimvar(new TfToken(s), sdfTypeName, VertexDataAttribute.Interpolation);
					if (flag4)
					{
						usdGeomPrimvar.SetElementSize(primvarBase.elementSize);
						if (primvarBase.indices != null)
						{
							VtIntArray indices = IntrinsicTypeConverter.ToVtArray(primvarBase.indices);
							usdGeomPrimvar.SetIndices(indices, time);
						}
						usdGeomPrimvar.SetInterpolation(primvarBase.GetInterpolationToken());
					}
					else
					{
						usdGeomPrimvar.SetElementSize(primvarElementSize);
					}
					usdAttribute = usdGeomPrimvar.GetAttr();
				}
			}
			if (usdAttribute != null && connectable != null && connectable.GetConnectedPath() != null)
			{
				SdfPathVector sdfPathVector2 = new SdfPathVector();
				string connectedPath = connectable.GetConnectedPath();
				if (connectedPath != string.Empty)
				{
					sdfPathVector2.Add(new SdfPath(connectable.GetConnectedPath()));
				}
				usdAttribute.SetConnections(sdfPathVector2);
			}
			if (csValue == null)
			{
				return true;
			}
			VtValue vtValue = binding.toVtValue(csValue);
			lock (m_stageLock)
			{
				if (flag2)
				{
					prim.SetMetadata(tfToken, vtValue);
				}
				else if (flag)
				{
					prim.SetCustomDataByKey(tfToken, vtValue);
				}
				else if (Reflect.IsFusedDisplayColor(memberInfo))
				{
					UsdCs.SetFusedDisplayColor(prim, vtValue, time);
				}
				else
				{
					m_sparseValueWriter.SetAttribute(usdAttribute, vtValue, time);
				}
			}
			if (!flag && srcObject != null)
			{
				lock (m_stageLock)
				{
					usdAttribute.SetCustomDataByKey(sm_tokenCache["sourceMember"], srcObject);
				}
			}
			return true;
		}

		private bool ReadAttr(string attrName, Type csType, ref object csValue, UsdTimeCode usdTime, UsdPrim prim, MemberInfo memberInfo, HashSet<MemberInfo> accessMap, ref bool? mayVary, string usdNamespace)
		{
			bool flag = csValue != null && csType.IsGenericType && csType.GetGenericTypeDefinition() == typeof(Primvar<>);
			bool flag2 = Reflect.IsPrimvar(memberInfo) || flag;
			string text = IntrinsicTypeConverter.JoinNamespace(usdNamespace, Reflect.GetNamespace(memberInfo));
			if (csValue != null && csType.IsGenericType && csType.GetGenericTypeDefinition() == typeof(Dictionary<, >) && csType.GetGenericArguments()[0] == typeof(string))
			{
				Type type = (csType.GetGenericArguments()[1].IsGenericType ? csType.GetGenericArguments()[1].GetGenericTypeDefinition() : null);
				flag = type == typeof(Primvar<>);
				bool flag3 = csType.GetGenericArguments()[1] == typeof(Relationship);
				bool flag4 = type == typeof(Connectable<>);
				if (!Reflect.ForceNoNamespace(memberInfo) && string.IsNullOrEmpty(Reflect.GetNamespace(memberInfo)))
				{
					text = IntrinsicTypeConverter.JoinNamespace(text, attrName);
					usdNamespace = IntrinsicTypeConverter.JoinNamespace(usdNamespace, attrName);
				}
				if (flag2 || flag)
				{
					text = IntrinsicTypeConverter.JoinNamespace("primvars", text);
				}
				IDictionary dictionary = csValue as IDictionary;
				ConstructorInfo constructorInfo = ((flag || flag4 || flag3) ? csType.GetGenericArguments()[1].GetConstructor(new Type[0]) : null);
				dictionary.Clear();
				foreach (UsdProperty item in prim.GetAuthoredPropertiesInNamespace(text))
				{
					object csValue2 = null;
					if (constructorInfo != null)
					{
						csValue2 = constructorInfo.Invoke(new object[0]);
					}
					if (ReadAttr(item.GetBaseName(), csType.GetGenericArguments()[1], ref csValue2, usdTime, prim, memberInfo, accessMap, ref mayVary, usdNamespace) && csValue2 != null)
					{
						string text2 = item.GetName().ToString();
						dictionary.Add(text2.Substring(text.Length + 1), csValue2);
					}
				}
				return true;
			}
			TfToken tfToken = sm_tokenCache[text, attrName];
			if (csType == typeof(Relationship))
			{
				UsdRelationship usdRelationship = null;
				lock (m_stageLock)
				{
					usdRelationship = prim.GetRelationship(sm_tokenCache[tfToken]);
				}
				Relationship relationship = (Relationship)(csValue = new Relationship());
				if (usdRelationship == null || !usdRelationship.IsValid())
				{
					return true;
				}
				SdfPathVector targets = usdRelationship.GetTargets();
				string[] array = new string[targets.Count];
				for (int i = 0; i < targets.Count; i++)
				{
					array[i] = targets[i].ToString();
				}
				relationship.targetPaths = array;
				return true;
			}
			Connectable connectable = null;
			if (csValue != null && csType.IsGenericType && csType.GetGenericTypeDefinition() == typeof(Connectable<>))
			{
				connectable = csValue as Connectable;
				if (connectable != null)
				{
					csValue = connectable.GetValue();
					csType = connectable.GetValueType();
				}
			}
			ValueAccessor valueAccessor = null;
			PrimvarBase primvarBase = null;
			if (flag)
			{
				valueAccessor = csValue as ValueAccessor;
				primvarBase = (PrimvarBase)csValue;
				csValue = valueAccessor.GetValue();
				csType = valueAccessor.GetValueType();
			}
			if (!sm_bindings.GetBinding(csType, out var binding) && !csType.IsEnum && csType != typeof(object))
			{
				if (string.IsNullOrEmpty(text))
				{
					return false;
				}
				SampleBase sampleBase = csValue as SampleBase;
				if (csValue == null)
				{
					return false;
				}
				if (sampleBase == null)
				{
					throw new ArgumentException("Type does not inherit from SampleBase: " + attrName);
				}
				Deserialize((SampleBase)csValue, prim, usdTime, accessMap, ref mayVary, text);
				return true;
			}
			if (connectable != null)
			{
				csValue = connectable;
			}
			else if (valueAccessor != null)
			{
				csValue = valueAccessor;
			}
			if (flag2)
			{
				string token = IntrinsicTypeConverter.JoinNamespace(text, attrName);
				tfToken = sm_tokenCache["primvars", token];
			}
			SdfVariability variability = Reflect.GetVariability(memberInfo);
			UsdTimeCode time = ((variability == SdfVariability.SdfVariabilityUniform) ? kDefaultUsdTime : usdTime);
			VtValue vtValue = (VtValue)ArrayAllocator.MallocHandle(typeof(VtValue));
			try
			{
				if (connectable != null)
				{
					SdfPathVector sdfPathVector = new SdfPathVector();
					if (prim.GetAttribute(tfToken).GetConnections(sdfPathVector) && sdfPathVector.Count > 0)
					{
						connectable.SetConnectedPath(sdfPathVector[0].ToString());
					}
				}
				if (primvarBase != null)
				{
					UsdAttribute usdAttribute = null;
					if (Reflect.IsFusedDisplayColor(memberInfo))
					{
						UsdGeomGprim usdGeomGprim = new UsdGeomGprim(prim);
						if ((bool)usdGeomGprim)
						{
							usdAttribute = usdGeomGprim.GetDisplayColorAttr();
						}
					}
					else
					{
						usdAttribute = prim.GetAttribute(tfToken);
					}
					if ((bool)usdAttribute)
					{
						UsdGeomPrimvar usdGeomPrimvar = new UsdGeomPrimvar(usdAttribute);
						primvarBase.elementSize = usdGeomPrimvar.GetElementSize();
						primvarBase.SetInterpolationToken(usdGeomPrimvar.GetInterpolation());
						UsdAttribute indicesAttr = usdGeomPrimvar.GetIndicesAttr();
						if ((bool)indicesAttr)
						{
							if (accessMap != null && indicesAttr.GetVariability() == SdfVariability.SdfVariabilityVarying && indicesAttr.ValueMightBeTimeVarying())
							{
								accessMap.Add(memberInfo);
								bool? flag5 = mayVary;
								mayVary = true | flag5;
							}
							indicesAttr.Get(vtValue, time);
							if (!vtValue.IsEmpty())
							{
								VtIntArray input = Vt.VtValueToVtIntArray(vtValue);
								primvarBase.indices = IntrinsicTypeConverter.FromVtArray(input);
							}
						}
					}
				}
				if (Reflect.IsMetadata(memberInfo))
				{
					vtValue = prim.GetMetadata(tfToken);
				}
				else if (Reflect.IsCustomData(memberInfo))
				{
					vtValue = prim.GetCustomDataByKey(tfToken);
				}
				else if (Reflect.IsFusedDisplayColor(memberInfo))
				{
					vtValue = UsdCs.GetFusedDisplayColor(prim, time);
					if (accessMap != null)
					{
						UsdGeomGprim usdGeomGprim2 = new UsdGeomGprim(prim);
						if ((bool)usdGeomGprim2 && usdGeomGprim2.GetDisplayColorAttr().ValueMightBeTimeVarying())
						{
							accessMap.Add(memberInfo);
							bool? flag5 = mayVary;
							mayVary = true | flag5;
						}
					}
				}
				else if (Reflect.IsFusedTransform(memberInfo))
				{
					vtValue = UsdCs.GetFusedTransform(prim, time);
					if (accessMap != null)
					{
						UsdGeomXformable usdGeomXformable = new UsdGeomXformable(prim);
						if ((bool)usdGeomXformable)
						{
							UsdAttribute xformOpOrderAttr = usdGeomXformable.GetXformOpOrderAttr();
							if ((bool)xformOpOrderAttr)
							{
								if (xformOpOrderAttr.GetVariability() == SdfVariability.SdfVariabilityVarying && xformOpOrderAttr.ValueMightBeTimeVarying())
								{
									bool? flag5 = mayVary;
									mayVary = true | flag5;
									accessMap.Add(memberInfo);
								}
								else
								{
									bool resetsXformStack;
									foreach (UsdGeomXformOp orderedXformOp in usdGeomXformable.GetOrderedXformOps(out resetsXformStack))
									{
										UsdAttribute attr = orderedXformOp.GetAttr();
										if ((bool)attr && attr.GetVariability() == SdfVariability.SdfVariabilityVarying && attr.ValueMightBeTimeVarying())
										{
											bool? flag5 = mayVary;
											mayVary = true | flag5;
											accessMap.Add(memberInfo);
											break;
										}
									}
								}
							}
						}
					}
				}
				else
				{
					if (accessMap != null)
					{
						UsdAttribute attribute = prim.GetAttribute(tfToken);
						if (attribute.GetVariability() == SdfVariability.SdfVariabilityVarying && attribute.ValueMightBeTimeVarying())
						{
							accessMap.Add(memberInfo);
							bool? flag5 = mayVary;
							mayVary = true | flag5;
						}
					}
					if (!prim.GetAttributeValue(tfToken, vtValue, time))
					{
						return true;
					}
				}
				if (vtValue.IsEmpty())
				{
					return true;
				}
				if (csType == typeof(object))
				{
					UsdAttribute attribute2 = prim.GetAttribute(tfToken);
					if (!(attribute2 != null) || !attribute2.IsValid())
					{
						return false;
					}
					if (!sm_bindings.GetReverseBinding(attribute2.GetTypeName(), out binding))
					{
						string.IsNullOrEmpty(text);
						return false;
					}
				}
				csValue = binding.toCsObject(vtValue);
				if (connectable != null && csValue != null)
				{
					if (connectable.GetValueType() == typeof(string) && vtValue.GetTypeName() == "TfToken")
					{
						csValue = (string)VtValue.CastToTypeOf(vtValue, new VtValue(""));
					}
					connectable.SetValue(csValue);
					csValue = connectable;
				}
				if (valueAccessor != null)
				{
					valueAccessor.SetValue(csValue);
					csValue = valueAccessor;
				}
			}
			finally
			{
				ArrayAllocator.FreeHandle(vtValue);
			}
			return true;
		}
	}
}
