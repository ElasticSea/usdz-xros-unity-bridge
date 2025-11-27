using System;
using System.Collections.Generic;
using System.Reflection;
using pxr;

namespace USD.NET
{
	internal class Reflect
	{
		private struct InfoEntry
		{
			public bool isPrimvar;

			public int primvarElementSize;

			public bool isCustomData;

			public bool isMetadata;

			public SdfVariability sdfVariability;

			public bool isNonSerialized;

			public string usdNamespace;

			public bool isFusedDisplayColor;

			public bool isFusedTransform;

			public bool isRelationship;

			public bool isAssetPath;

			public bool forceNoNamespace;
		}

		private struct PrimInfoEntry
		{
			public string usdSchema;
		}

		private static Dictionary<MemberInfo, InfoEntry> infoCache = new Dictionary<MemberInfo, InfoEntry>();

		private static Dictionary<Type, PrimInfoEntry> primInfoCache = new Dictionary<Type, PrimInfoEntry>();

		private static Dictionary<Type, PropertyInfo[]> propertyInfoCache = new Dictionary<Type, PropertyInfo[]>();

		private static Dictionary<Type, FieldInfo[]> fieldInfoCache = new Dictionary<Type, FieldInfo[]>();

		public static PropertyInfo[] GetCachedProperties(Type type)
		{
			PropertyInfo[] value;
			lock (propertyInfoCache)
			{
				if (!propertyInfoCache.TryGetValue(type, out value))
				{
					value = type.GetProperties(GetPublicBindingFlags());
					propertyInfoCache[type] = value;
				}
			}
			return value;
		}

		public static FieldInfo[] GetCachedFields(Type type)
		{
			FieldInfo[] value;
			lock (fieldInfoCache)
			{
				if (!fieldInfoCache.TryGetValue(type, out value))
				{
					value = type.GetFields(GetPublicBindingFlags());
					fieldInfoCache[type] = value;
				}
			}
			return value;
		}

		public static SdfVariability GetVariability(MemberInfo info)
		{
			return GetCacheEntry(info).sdfVariability;
		}

		public static bool IsPrimvar(MemberInfo info)
		{
			return GetCacheEntry(info).isPrimvar;
		}

		public static int GetPrimvarElementSize(MemberInfo info)
		{
			return GetCacheEntry(info).primvarElementSize;
		}

		public static bool IsFusedDisplayColor(MemberInfo info)
		{
			return GetCacheEntry(info).isFusedDisplayColor;
		}

		public static bool IsFusedTransform(MemberInfo info)
		{
			return GetCacheEntry(info).isFusedTransform;
		}

		public static bool IsCustomData(MemberInfo info)
		{
			return GetCacheEntry(info).isCustomData;
		}

		public static bool IsMetadata(MemberInfo info)
		{
			return GetCacheEntry(info).isMetadata;
		}

		public static bool IsRelationship(MemberInfo info)
		{
			return GetCacheEntry(info).isRelationship;
		}

		public static bool IsAssetPath(MemberInfo info)
		{
			return GetCacheEntry(info).isAssetPath;
		}

		public static bool IsNonSerialized(MemberInfo info)
		{
			return GetCacheEntry(info).isNonSerialized;
		}

		public static string GetNamespace(MemberInfo info)
		{
			return GetCacheEntry(info).usdNamespace;
		}

		public static string GetSchema(Type classType)
		{
			return GetPrimCacheEntry(classType).usdSchema;
		}

		public static bool ForceNoNamespace(MemberInfo info)
		{
			return GetCacheEntry(info).forceNoNamespace;
		}

		public static IEnumerable<Array> ExtractArrays<T>(T obj)
		{
			Type type = obj.GetType();
			PropertyInfo[] properties = type.GetProperties(GetPublicBindingFlags());
			PropertyInfo[] array = properties;
			foreach (PropertyInfo csProp in array)
			{
				if (csProp.PropertyType.IsArray)
				{
					Array array2 = (Array)csProp.GetValue(obj, null);
					if (array2 != null)
					{
						yield return array2;
						csProp.SetValue(obj, null, null);
					}
				}
			}
			FieldInfo[] fields = type.GetFields(GetPublicBindingFlags());
			FieldInfo[] array3 = fields;
			foreach (FieldInfo csField in array3)
			{
				if (csField.FieldType.IsArray)
				{
					Array array4 = (Array)csField.GetValue(obj);
					if (array4 != null)
					{
						yield return array4;
						csField.SetValue(obj, null);
					}
				}
				else if (csField.FieldType == typeof(object))
				{
					Array array5 = (Array)csField.GetValue(obj);
					if (array5 != null)
					{
						yield return array5;
						csField.SetValue(obj, null);
					}
				}
			}
		}

		public static BindingFlags GetPublicBindingFlags()
		{
			return BindingFlags.Instance | BindingFlags.Public;
		}

		private static InfoEntry GetCacheEntry(MemberInfo info)
		{
			InfoEntry value = default(InfoEntry);
			lock (infoCache)
			{
				if (infoCache.TryGetValue(info, out value))
				{
					return value;
				}
			}
			UsdVariabilityAttribute[] array = (UsdVariabilityAttribute[])info.GetCustomAttributes(typeof(UsdVariabilityAttribute), inherit: true);
			value.sdfVariability = ((array.Length != 0) ? array[0].SdfVariability : SdfVariability.SdfVariabilityVarying);
			VertexDataAttribute[] array2 = (VertexDataAttribute[])info.GetCustomAttributes(typeof(VertexDataAttribute), inherit: true);
			value.isPrimvar = array2.Length != 0;
			value.primvarElementSize = ((!value.isPrimvar) ? 1 : array2[0].ElementSize);
			FusedDisplayColorAttribute[] array3 = (FusedDisplayColorAttribute[])info.GetCustomAttributes(typeof(FusedDisplayColorAttribute), inherit: true);
			value.isFusedDisplayColor = array3.Length != 0;
			FusedTransformAttribute[] array4 = (FusedTransformAttribute[])info.GetCustomAttributes(typeof(FusedTransformAttribute), inherit: true);
			value.isFusedTransform = array4.Length != 0;
			CustomDataAttribute[] array5 = (CustomDataAttribute[])info.GetCustomAttributes(typeof(CustomDataAttribute), inherit: true);
			value.isCustomData = array5.Length != 0;
			UsdMetadataAttribute[] array6 = (UsdMetadataAttribute[])info.GetCustomAttributes(typeof(UsdMetadataAttribute), inherit: true);
			value.isMetadata = array6.Length != 0;
			NonSerializedAttribute[] array7 = (NonSerializedAttribute[])info.GetCustomAttributes(typeof(NonSerializedAttribute), inherit: true);
			value.isNonSerialized = array7.Length != 0;
			UsdNamespaceAttribute[] array8 = (UsdNamespaceAttribute[])info.GetCustomAttributes(typeof(UsdNamespaceAttribute), inherit: true);
			value.usdNamespace = ((array8.Length == 0) ? "" : array8[0].Name);
			UsdRelationshipAttribute[] array9 = (UsdRelationshipAttribute[])info.GetCustomAttributes(typeof(UsdRelationshipAttribute), inherit: true);
			value.isRelationship = array6.Length != 0;
			UsdAssetPathAttribute[] array10 = (UsdAssetPathAttribute[])info.GetCustomAttributes(typeof(UsdAssetPathAttribute), inherit: true);
			value.isAssetPath = array10.Length != 0;
			ForceNoNamespaceAttribute[] array11 = (ForceNoNamespaceAttribute[])info.GetCustomAttributes(typeof(ForceNoNamespaceAttribute), inherit: true);
			value.forceNoNamespace = array11.Length != 0;
			lock (infoCache)
			{
				infoCache[info] = value;
				return value;
			}
		}

		private static PrimInfoEntry GetPrimCacheEntry(Type type)
		{
			PrimInfoEntry value = default(PrimInfoEntry);
			if (primInfoCache.TryGetValue(type, out value))
			{
				return value;
			}
			UsdSchemaAttribute[] array = (UsdSchemaAttribute[])type.GetCustomAttributes(typeof(UsdSchemaAttribute), inherit: true);
			value.usdSchema = ((array.Length == 0) ? "" : array[0].Name);
			primInfoCache[type] = value;
			return value;
		}
	}
}
