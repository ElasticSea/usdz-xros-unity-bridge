using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class SdfPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("__Internal")]
			public static extern void SWIGRegisterStringCallback_Sdf(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Sdf(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static SdfPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAssetPath__SWIG_0")]
		public static extern IntPtr new_SdfAssetPath__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAssetPath__SWIG_1")]
		public static extern IntPtr new_SdfAssetPath__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAssetPath__SWIG_2")]
		public static extern IntPtr new_SdfAssetPath__SWIG_2(string jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAssetPath_GetHash")]
		public static extern uint SdfAssetPath_GetHash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAssetPath_Hash")]
		public static extern IntPtr new_SdfAssetPath_Hash();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAssetPath_Hash")]
		public static extern void delete_SdfAssetPath_Hash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAssetPath_GetAssetPath")]
		public static extern string SdfAssetPath_GetAssetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAssetPath_GetResolvedPath")]
		public static extern string SdfAssetPath_GetResolvedPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAssetPath_Equals")]
		public static extern bool SdfAssetPath_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAssetPath_GetHashCode")]
		public static extern int SdfAssetPath_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAssetPath")]
		public static extern void delete_SdfAssetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfSpec")]
		public static extern void delete_SdfSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetSchema")]
		public static extern IntPtr SdfSpec_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetSpecType")]
		public static extern int SdfSpec_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_IsDormant")]
		public static extern bool SdfSpec_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetLayer")]
		public static extern IntPtr SdfSpec_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetPath")]
		public static extern IntPtr SdfSpec_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_PermissionToEdit")]
		public static extern bool SdfSpec_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_ListInfoKeys")]
		public static extern IntPtr SdfSpec_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfSpec_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfSpec_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetInfo")]
		public static extern IntPtr SdfSpec_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_SetInfo")]
		public static extern void SdfSpec_SetInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_SetInfoDictionaryValue")]
		public static extern void SdfSpec_SetInfoDictionaryValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_HasInfo")]
		public static extern bool SdfSpec_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_ClearInfo")]
		public static extern void SdfSpec_ClearInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetTypeForInfo")]
		public static extern IntPtr SdfSpec_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetFallbackForInfo")]
		public static extern IntPtr SdfSpec_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_IsInert__SWIG_0")]
		public static extern bool SdfSpec_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_IsInert__SWIG_1")]
		public static extern bool SdfSpec_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_ListFields")]
		public static extern IntPtr SdfSpec_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_HasField")]
		public static extern bool SdfSpec_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_GetField")]
		public static extern IntPtr SdfSpec_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_SetField")]
		public static extern bool SdfSpec_SetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpec_ClearField")]
		public static extern bool SdfSpec_ClearField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_New__SWIG_0")]
		public static extern IntPtr SdfPrimSpec_New__SWIG_0(HandleRef jarg1, string jarg2, int jarg3, string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_New__SWIG_1")]
		public static extern IntPtr SdfPrimSpec_New__SWIG_1(HandleRef jarg1, string jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_New__SWIG_2")]
		public static extern IntPtr SdfPrimSpec_New__SWIG_2(HandleRef jarg1, string jarg2, int jarg3, string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_New__SWIG_3")]
		public static extern IntPtr SdfPrimSpec_New__SWIG_3(HandleRef jarg1, string jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetName")]
		public static extern string SdfPrimSpec_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetNameToken")]
		public static extern IntPtr SdfPrimSpec_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_CanSetName")]
		public static extern bool SdfPrimSpec_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetName__SWIG_0")]
		public static extern bool SdfPrimSpec_SetName__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetName__SWIG_1")]
		public static extern bool SdfPrimSpec_SetName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_IsValidName")]
		public static extern bool SdfPrimSpec_IsValidName(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetNameRoot")]
		public static extern IntPtr SdfPrimSpec_GetNameRoot(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetNameParent")]
		public static extern IntPtr SdfPrimSpec_GetNameParent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetRealNameParent")]
		public static extern IntPtr SdfPrimSpec_GetRealNameParent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetNameChildren")]
		public static extern IntPtr SdfPrimSpec_GetNameChildren(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetNameChildren")]
		public static extern void SdfPrimSpec_SetNameChildren(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_InsertNameChild__SWIG_0")]
		public static extern bool SdfPrimSpec_InsertNameChild__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_InsertNameChild__SWIG_1")]
		public static extern bool SdfPrimSpec_InsertNameChild__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_RemoveNameChild")]
		public static extern bool SdfPrimSpec_RemoveNameChild(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasNameChildrenOrder")]
		public static extern bool SdfPrimSpec_HasNameChildrenOrder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetNameChildrenOrder")]
		public static extern void SdfPrimSpec_SetNameChildrenOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_InsertInNameChildrenOrder__SWIG_0")]
		public static extern void SdfPrimSpec_InsertInNameChildrenOrder__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_InsertInNameChildrenOrder__SWIG_1")]
		public static extern void SdfPrimSpec_InsertInNameChildrenOrder__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_RemoveFromNameChildrenOrder")]
		public static extern void SdfPrimSpec_RemoveFromNameChildrenOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_RemoveFromNameChildrenOrderByIndex")]
		public static extern void SdfPrimSpec_RemoveFromNameChildrenOrderByIndex(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ApplyNameChildrenOrder")]
		public static extern void SdfPrimSpec_ApplyNameChildrenOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetProperties")]
		public static extern IntPtr SdfPrimSpec_GetProperties(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetProperties")]
		public static extern void SdfPrimSpec_SetProperties(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_InsertProperty__SWIG_0")]
		public static extern bool SdfPrimSpec_InsertProperty__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_InsertProperty__SWIG_1")]
		public static extern bool SdfPrimSpec_InsertProperty__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_RemoveProperty")]
		public static extern void SdfPrimSpec_RemoveProperty(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetAttributes")]
		public static extern IntPtr SdfPrimSpec_GetAttributes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetRelationships")]
		public static extern IntPtr SdfPrimSpec_GetRelationships(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasPropertyOrder")]
		public static extern bool SdfPrimSpec_HasPropertyOrder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetPropertyOrder")]
		public static extern void SdfPrimSpec_SetPropertyOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_InsertInPropertyOrder__SWIG_0")]
		public static extern void SdfPrimSpec_InsertInPropertyOrder__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_InsertInPropertyOrder__SWIG_1")]
		public static extern void SdfPrimSpec_InsertInPropertyOrder__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_RemoveFromPropertyOrder")]
		public static extern void SdfPrimSpec_RemoveFromPropertyOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_RemoveFromPropertyOrderByIndex")]
		public static extern void SdfPrimSpec_RemoveFromPropertyOrderByIndex(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ApplyPropertyOrder")]
		public static extern void SdfPrimSpec_ApplyPropertyOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetObjectAtPath")]
		public static extern IntPtr SdfPrimSpec_GetObjectAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetPrimAtPath")]
		public static extern IntPtr SdfPrimSpec_GetPrimAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetPropertyAtPath")]
		public static extern IntPtr SdfPrimSpec_GetPropertyAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetAttributeAtPath")]
		public static extern IntPtr SdfPrimSpec_GetAttributeAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetRelationshipAtPath")]
		public static extern IntPtr SdfPrimSpec_GetRelationshipAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetTypeName")]
		public static extern IntPtr SdfPrimSpec_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetTypeName")]
		public static extern void SdfPrimSpec_SetTypeName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetComment")]
		public static extern string SdfPrimSpec_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetComment")]
		public static extern void SdfPrimSpec_SetComment(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetDocumentation")]
		public static extern string SdfPrimSpec_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetDocumentation")]
		public static extern void SdfPrimSpec_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetActive")]
		public static extern bool SdfPrimSpec_GetActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetActive")]
		public static extern void SdfPrimSpec_SetActive(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasActive")]
		public static extern bool SdfPrimSpec_HasActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ClearActive")]
		public static extern void SdfPrimSpec_ClearActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetHidden")]
		public static extern bool SdfPrimSpec_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetHidden")]
		public static extern void SdfPrimSpec_SetHidden(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetKind")]
		public static extern IntPtr SdfPrimSpec_GetKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetKind")]
		public static extern void SdfPrimSpec_SetKind(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasKind")]
		public static extern bool SdfPrimSpec_HasKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ClearKind")]
		public static extern void SdfPrimSpec_ClearKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetSymmetryFunction")]
		public static extern IntPtr SdfPrimSpec_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetSymmetryFunction")]
		public static extern void SdfPrimSpec_SetSymmetryFunction(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetSymmetryArguments")]
		public static extern IntPtr SdfPrimSpec_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetSymmetryArgument")]
		public static extern void SdfPrimSpec_SetSymmetryArgument(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetSymmetricPeer")]
		public static extern string SdfPrimSpec_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetSymmetricPeer")]
		public static extern void SdfPrimSpec_SetSymmetricPeer(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetPrefix")]
		public static extern string SdfPrimSpec_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetPrefix")]
		public static extern void SdfPrimSpec_SetPrefix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetSuffix")]
		public static extern string SdfPrimSpec_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetSuffix")]
		public static extern void SdfPrimSpec_SetSuffix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetCustomData")]
		public static extern IntPtr SdfPrimSpec_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetAssetInfo")]
		public static extern IntPtr SdfPrimSpec_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetCustomData")]
		public static extern void SdfPrimSpec_SetCustomData(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetAssetInfo")]
		public static extern void SdfPrimSpec_SetAssetInfo(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetSpecifier")]
		public static extern int SdfPrimSpec_GetSpecifier(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetSpecifier")]
		public static extern void SdfPrimSpec_SetSpecifier(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetPermission")]
		public static extern int SdfPrimSpec_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetPermission")]
		public static extern void SdfPrimSpec_SetPermission(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetPrefixSubstitutions")]
		public static extern IntPtr SdfPrimSpec_GetPrefixSubstitutions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetPrefixSubstitutions")]
		public static extern void SdfPrimSpec_SetPrefixSubstitutions(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetSuffixSubstitutions")]
		public static extern IntPtr SdfPrimSpec_GetSuffixSubstitutions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetSuffixSubstitutions")]
		public static extern void SdfPrimSpec_SetSuffixSubstitutions(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetInstanceable")]
		public static extern void SdfPrimSpec_SetInstanceable(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetInstanceable")]
		public static extern bool SdfPrimSpec_GetInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasInstanceable")]
		public static extern bool SdfPrimSpec_HasInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ClearInstanceable")]
		public static extern void SdfPrimSpec_ClearInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetPayloadList")]
		public static extern IntPtr SdfPrimSpec_GetPayloadList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasPayloads")]
		public static extern bool SdfPrimSpec_HasPayloads(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ClearPayloadList")]
		public static extern void SdfPrimSpec_ClearPayloadList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetInheritPathList")]
		public static extern IntPtr SdfPrimSpec_GetInheritPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasInheritPaths")]
		public static extern bool SdfPrimSpec_HasInheritPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ClearInheritPathList")]
		public static extern void SdfPrimSpec_ClearInheritPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetSpecializesList")]
		public static extern IntPtr SdfPrimSpec_GetSpecializesList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasSpecializes")]
		public static extern bool SdfPrimSpec_HasSpecializes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ClearSpecializesList")]
		public static extern void SdfPrimSpec_ClearSpecializesList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetReferenceList")]
		public static extern IntPtr SdfPrimSpec_GetReferenceList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasReferences")]
		public static extern bool SdfPrimSpec_HasReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ClearReferenceList")]
		public static extern void SdfPrimSpec_ClearReferenceList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetVariantSetNameList")]
		public static extern IntPtr SdfPrimSpec_GetVariantSetNameList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasVariantSetNames")]
		public static extern bool SdfPrimSpec_HasVariantSetNames(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetVariantNames")]
		public static extern IntPtr SdfPrimSpec_GetVariantNames(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_RemoveVariantSet")]
		public static extern void SdfPrimSpec_RemoveVariantSet(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetVariantSelections")]
		public static extern IntPtr SdfPrimSpec_GetVariantSelections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetVariantSelection")]
		public static extern void SdfPrimSpec_SetVariantSelection(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_BlockVariantSelection")]
		public static extern void SdfPrimSpec_BlockVariantSelection(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_GetRelocates")]
		public static extern IntPtr SdfPrimSpec_GetRelocates(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SetRelocates")]
		public static extern void SdfPrimSpec_SetRelocates(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_HasRelocates")]
		public static extern bool SdfPrimSpec_HasRelocates(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_ClearRelocates")]
		public static extern void SdfPrimSpec_ClearRelocates(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPrimSpec")]
		public static extern void delete_SdfPrimSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfCreatePrimInLayer")]
		public static extern IntPtr SdfCreatePrimInLayer(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfJustCreatePrimInLayer")]
		public static extern bool SdfJustCreatePrimInLayer(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetName")]
		public static extern string SdfPropertySpec_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetNameToken")]
		public static extern IntPtr SdfPropertySpec_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_CanSetName")]
		public static extern bool SdfPropertySpec_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetName__SWIG_0")]
		public static extern bool SdfPropertySpec_SetName__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetName__SWIG_1")]
		public static extern bool SdfPropertySpec_SetName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_IsValidName")]
		public static extern bool SdfPropertySpec_IsValidName(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetOwner")]
		public static extern IntPtr SdfPropertySpec_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetCustomData")]
		public static extern IntPtr SdfPropertySpec_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetAssetInfo")]
		public static extern IntPtr SdfPropertySpec_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetCustomData")]
		public static extern void SdfPropertySpec_SetCustomData(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetAssetInfo")]
		public static extern void SdfPropertySpec_SetAssetInfo(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetDisplayGroup")]
		public static extern string SdfPropertySpec_GetDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetDisplayGroup")]
		public static extern void SdfPropertySpec_SetDisplayGroup(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetDisplayName")]
		public static extern string SdfPropertySpec_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetDisplayName")]
		public static extern void SdfPropertySpec_SetDisplayName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetDocumentation")]
		public static extern string SdfPropertySpec_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetDocumentation")]
		public static extern void SdfPropertySpec_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetHidden")]
		public static extern bool SdfPropertySpec_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetHidden")]
		public static extern void SdfPropertySpec_SetHidden(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetPermission")]
		public static extern int SdfPropertySpec_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetPermission")]
		public static extern void SdfPropertySpec_SetPermission(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetPrefix")]
		public static extern string SdfPropertySpec_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetPrefix")]
		public static extern void SdfPropertySpec_SetPrefix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetSuffix")]
		public static extern string SdfPropertySpec_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetSuffix")]
		public static extern void SdfPropertySpec_SetSuffix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetSymmetricPeer")]
		public static extern string SdfPropertySpec_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetSymmetricPeer")]
		public static extern void SdfPropertySpec_SetSymmetricPeer(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetSymmetryArguments")]
		public static extern IntPtr SdfPropertySpec_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetSymmetryArgument")]
		public static extern void SdfPropertySpec_SetSymmetryArgument(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetSymmetryFunction")]
		public static extern IntPtr SdfPropertySpec_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetSymmetryFunction")]
		public static extern void SdfPropertySpec_SetSymmetryFunction(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetTimeSampleMap")]
		public static extern IntPtr SdfPropertySpec_GetTimeSampleMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetValueType")]
		public static extern IntPtr SdfPropertySpec_GetValueType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetTypeName")]
		public static extern IntPtr SdfPropertySpec_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetDefaultValue")]
		public static extern IntPtr SdfPropertySpec_GetDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetDefaultValue")]
		public static extern bool SdfPropertySpec_SetDefaultValue(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_HasDefaultValue")]
		public static extern bool SdfPropertySpec_HasDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_ClearDefaultValue")]
		public static extern void SdfPropertySpec_ClearDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetComment")]
		public static extern string SdfPropertySpec_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetComment")]
		public static extern void SdfPropertySpec_SetComment(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_IsCustom")]
		public static extern bool SdfPropertySpec_IsCustom(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SetCustom")]
		public static extern void SdfPropertySpec_SetCustom(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_GetVariability")]
		public static extern int SdfPropertySpec_GetVariability(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_HasOnlyRequiredFields")]
		public static extern bool SdfPropertySpec_HasOnlyRequiredFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPropertySpec")]
		public static extern void delete_SdfPropertySpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_New__SWIG_0")]
		public static extern IntPtr SdfAttributeSpec_New__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4, bool jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_New__SWIG_1")]
		public static extern IntPtr SdfAttributeSpec_New__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_New__SWIG_2")]
		public static extern IntPtr SdfAttributeSpec_New__SWIG_2(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_GetConnectionPathList")]
		public static extern IntPtr SdfAttributeSpec_GetConnectionPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_HasConnectionPaths")]
		public static extern bool SdfAttributeSpec_HasConnectionPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_ClearConnectionPaths")]
		public static extern void SdfAttributeSpec_ClearConnectionPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_GetAllowedTokens")]
		public static extern IntPtr SdfAttributeSpec_GetAllowedTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_SetAllowedTokens")]
		public static extern void SdfAttributeSpec_SetAllowedTokens(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_HasAllowedTokens")]
		public static extern bool SdfAttributeSpec_HasAllowedTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_ClearAllowedTokens")]
		public static extern void SdfAttributeSpec_ClearAllowedTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_GetDisplayUnit")]
		public static extern IntPtr SdfAttributeSpec_GetDisplayUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_SetDisplayUnit")]
		public static extern void SdfAttributeSpec_SetDisplayUnit(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_HasDisplayUnit")]
		public static extern bool SdfAttributeSpec_HasDisplayUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_ClearDisplayUnit")]
		public static extern void SdfAttributeSpec_ClearDisplayUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_GetColorSpace")]
		public static extern IntPtr SdfAttributeSpec_GetColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_SetColorSpace")]
		public static extern void SdfAttributeSpec_SetColorSpace(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_HasColorSpace")]
		public static extern bool SdfAttributeSpec_HasColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_ClearColorSpace")]
		public static extern void SdfAttributeSpec_ClearColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_GetRoleName")]
		public static extern IntPtr SdfAttributeSpec_GetRoleName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAttributeSpec")]
		public static extern void delete_SdfAttributeSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfJustCreatePrimAttributeInLayer__SWIG_0")]
		public static extern bool SdfJustCreatePrimAttributeInLayer__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, bool jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfJustCreatePrimAttributeInLayer__SWIG_1")]
		public static extern bool SdfJustCreatePrimAttributeInLayer__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfJustCreatePrimAttributeInLayer__SWIG_2")]
		public static extern bool SdfJustCreatePrimAttributeInLayer__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_New__SWIG_0")]
		public static extern IntPtr SdfRelationshipSpec_New__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_New__SWIG_1")]
		public static extern IntPtr SdfRelationshipSpec_New__SWIG_1(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_New__SWIG_2")]
		public static extern IntPtr SdfRelationshipSpec_New__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_GetTargetPathList")]
		public static extern IntPtr SdfRelationshipSpec_GetTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_HasTargetPathList")]
		public static extern bool SdfRelationshipSpec_HasTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_ClearTargetPathList")]
		public static extern void SdfRelationshipSpec_ClearTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_ReplaceTargetPath")]
		public static extern void SdfRelationshipSpec_ReplaceTargetPath(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_RemoveTargetPath__SWIG_0")]
		public static extern void SdfRelationshipSpec_RemoveTargetPath__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_RemoveTargetPath__SWIG_1")]
		public static extern void SdfRelationshipSpec_RemoveTargetPath__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_GetNoLoadHint")]
		public static extern bool SdfRelationshipSpec_GetNoLoadHint(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_SetNoLoadHint")]
		public static extern void SdfRelationshipSpec_SetNoLoadHint(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfRelationshipSpec")]
		public static extern void delete_SdfRelationshipSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_New__SWIG_0")]
		public static extern IntPtr SdfVariantSetSpec_New__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_New__SWIG_1")]
		public static extern IntPtr SdfVariantSetSpec_New__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_GetName")]
		public static extern string SdfVariantSetSpec_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_GetNameToken")]
		public static extern IntPtr SdfVariantSetSpec_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_GetOwner")]
		public static extern IntPtr SdfVariantSetSpec_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_GetVariants")]
		public static extern IntPtr SdfVariantSetSpec_GetVariants(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_GetVariantList")]
		public static extern IntPtr SdfVariantSetSpec_GetVariantList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_RemoveVariant")]
		public static extern void SdfVariantSetSpec_RemoveVariant(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSetSpec")]
		public static extern void delete_SdfVariantSetSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_Clear")]
		public static extern void SdfLayerHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_Add")]
		public static extern void SdfLayerHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_size")]
		public static extern uint SdfLayerHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_capacity")]
		public static extern uint SdfLayerHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_reserve")]
		public static extern void SdfLayerHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfLayerHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfLayerHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfLayerHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_getitemcopy")]
		public static extern IntPtr SdfLayerHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_getitem")]
		public static extern IntPtr SdfLayerHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_setitem")]
		public static extern void SdfLayerHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_AddRange")]
		public static extern void SdfLayerHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_GetRange")]
		public static extern IntPtr SdfLayerHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_Insert")]
		public static extern void SdfLayerHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_InsertRange")]
		public static extern void SdfLayerHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_RemoveAt")]
		public static extern void SdfLayerHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_RemoveRange")]
		public static extern void SdfLayerHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_Repeat")]
		public static extern IntPtr SdfLayerHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_Reverse__SWIG_0")]
		public static extern void SdfLayerHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_Reverse__SWIG_1")]
		public static extern void SdfLayerHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleVector_SetRange")]
		public static extern void SdfLayerHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerHandleVector")]
		public static extern void delete_SdfLayerHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_Clear")]
		public static extern void SdfLayerConstHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_Add")]
		public static extern void SdfLayerConstHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_size")]
		public static extern uint SdfLayerConstHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_capacity")]
		public static extern uint SdfLayerConstHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_reserve")]
		public static extern void SdfLayerConstHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerConstHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfLayerConstHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerConstHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfLayerConstHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerConstHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfLayerConstHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_getitemcopy")]
		public static extern IntPtr SdfLayerConstHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_getitem")]
		public static extern IntPtr SdfLayerConstHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_setitem")]
		public static extern void SdfLayerConstHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_AddRange")]
		public static extern void SdfLayerConstHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_GetRange")]
		public static extern IntPtr SdfLayerConstHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_Insert")]
		public static extern void SdfLayerConstHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_InsertRange")]
		public static extern void SdfLayerConstHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_RemoveAt")]
		public static extern void SdfLayerConstHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_RemoveRange")]
		public static extern void SdfLayerConstHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_Repeat")]
		public static extern IntPtr SdfLayerConstHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_Reverse__SWIG_0")]
		public static extern void SdfLayerConstHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_Reverse__SWIG_1")]
		public static extern void SdfLayerConstHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandleVector_SetRange")]
		public static extern void SdfLayerConstHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerConstHandleVector")]
		public static extern void delete_SdfLayerConstHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecHandle__SWIG_0")]
		public static extern IntPtr new_SdfPrimSpecHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecHandle__SWIG_1")]
		public static extern IntPtr new_SdfPrimSpecHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecHandle__SWIG_2")]
		public static extern IntPtr new_SdfPrimSpecHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle___deref__")]
		public static extern IntPtr SdfPrimSpecHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPrimSpecHandle")]
		public static extern void delete_SdfPrimSpecHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_New__SWIG_0")]
		public static extern IntPtr SdfPrimSpecHandle_New__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, int jarg4, string jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_New__SWIG_1")]
		public static extern IntPtr SdfPrimSpecHandle_New__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_New__SWIG_2")]
		public static extern IntPtr SdfPrimSpecHandle_New__SWIG_2(HandleRef jarg1, HandleRef jarg2, string jarg3, int jarg4, string jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_New__SWIG_3")]
		public static extern IntPtr SdfPrimSpecHandle_New__SWIG_3(HandleRef jarg1, HandleRef jarg2, string jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetName")]
		public static extern string SdfPrimSpecHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetNameToken")]
		public static extern IntPtr SdfPrimSpecHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_CanSetName")]
		public static extern bool SdfPrimSpecHandle_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetName__SWIG_0")]
		public static extern bool SdfPrimSpecHandle_SetName__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetName__SWIG_1")]
		public static extern bool SdfPrimSpecHandle_SetName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_IsValidName")]
		public static extern bool SdfPrimSpecHandle_IsValidName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetNameRoot")]
		public static extern IntPtr SdfPrimSpecHandle_GetNameRoot(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetNameParent")]
		public static extern IntPtr SdfPrimSpecHandle_GetNameParent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetRealNameParent")]
		public static extern IntPtr SdfPrimSpecHandle_GetRealNameParent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetNameChildren")]
		public static extern IntPtr SdfPrimSpecHandle_GetNameChildren(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetNameChildren")]
		public static extern void SdfPrimSpecHandle_SetNameChildren(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_InsertNameChild__SWIG_0")]
		public static extern bool SdfPrimSpecHandle_InsertNameChild__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_InsertNameChild__SWIG_1")]
		public static extern bool SdfPrimSpecHandle_InsertNameChild__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_RemoveNameChild")]
		public static extern bool SdfPrimSpecHandle_RemoveNameChild(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasNameChildrenOrder")]
		public static extern bool SdfPrimSpecHandle_HasNameChildrenOrder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetNameChildrenOrder")]
		public static extern void SdfPrimSpecHandle_SetNameChildrenOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_InsertInNameChildrenOrder__SWIG_0")]
		public static extern void SdfPrimSpecHandle_InsertInNameChildrenOrder__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_InsertInNameChildrenOrder__SWIG_1")]
		public static extern void SdfPrimSpecHandle_InsertInNameChildrenOrder__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_RemoveFromNameChildrenOrder")]
		public static extern void SdfPrimSpecHandle_RemoveFromNameChildrenOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_RemoveFromNameChildrenOrderByIndex")]
		public static extern void SdfPrimSpecHandle_RemoveFromNameChildrenOrderByIndex(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ApplyNameChildrenOrder")]
		public static extern void SdfPrimSpecHandle_ApplyNameChildrenOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetProperties")]
		public static extern IntPtr SdfPrimSpecHandle_GetProperties(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetProperties")]
		public static extern void SdfPrimSpecHandle_SetProperties(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_InsertProperty__SWIG_0")]
		public static extern bool SdfPrimSpecHandle_InsertProperty__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_InsertProperty__SWIG_1")]
		public static extern bool SdfPrimSpecHandle_InsertProperty__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_RemoveProperty")]
		public static extern void SdfPrimSpecHandle_RemoveProperty(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetAttributes")]
		public static extern IntPtr SdfPrimSpecHandle_GetAttributes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetRelationships")]
		public static extern IntPtr SdfPrimSpecHandle_GetRelationships(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasPropertyOrder")]
		public static extern bool SdfPrimSpecHandle_HasPropertyOrder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetPropertyOrder")]
		public static extern void SdfPrimSpecHandle_SetPropertyOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_InsertInPropertyOrder__SWIG_0")]
		public static extern void SdfPrimSpecHandle_InsertInPropertyOrder__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_InsertInPropertyOrder__SWIG_1")]
		public static extern void SdfPrimSpecHandle_InsertInPropertyOrder__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_RemoveFromPropertyOrder")]
		public static extern void SdfPrimSpecHandle_RemoveFromPropertyOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_RemoveFromPropertyOrderByIndex")]
		public static extern void SdfPrimSpecHandle_RemoveFromPropertyOrderByIndex(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ApplyPropertyOrder")]
		public static extern void SdfPrimSpecHandle_ApplyPropertyOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetObjectAtPath")]
		public static extern IntPtr SdfPrimSpecHandle_GetObjectAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetPrimAtPath")]
		public static extern IntPtr SdfPrimSpecHandle_GetPrimAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetPropertyAtPath")]
		public static extern IntPtr SdfPrimSpecHandle_GetPropertyAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetAttributeAtPath")]
		public static extern IntPtr SdfPrimSpecHandle_GetAttributeAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetRelationshipAtPath")]
		public static extern IntPtr SdfPrimSpecHandle_GetRelationshipAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetTypeName")]
		public static extern IntPtr SdfPrimSpecHandle_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetTypeName")]
		public static extern void SdfPrimSpecHandle_SetTypeName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetComment")]
		public static extern string SdfPrimSpecHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetComment")]
		public static extern void SdfPrimSpecHandle_SetComment(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetDocumentation")]
		public static extern string SdfPrimSpecHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetDocumentation")]
		public static extern void SdfPrimSpecHandle_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetActive")]
		public static extern bool SdfPrimSpecHandle_GetActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetActive")]
		public static extern void SdfPrimSpecHandle_SetActive(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasActive")]
		public static extern bool SdfPrimSpecHandle_HasActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearActive")]
		public static extern void SdfPrimSpecHandle_ClearActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetHidden")]
		public static extern bool SdfPrimSpecHandle_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetHidden")]
		public static extern void SdfPrimSpecHandle_SetHidden(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetKind")]
		public static extern IntPtr SdfPrimSpecHandle_GetKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetKind")]
		public static extern void SdfPrimSpecHandle_SetKind(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasKind")]
		public static extern bool SdfPrimSpecHandle_HasKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearKind")]
		public static extern void SdfPrimSpecHandle_ClearKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSymmetryFunction")]
		public static extern IntPtr SdfPrimSpecHandle_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetSymmetryFunction")]
		public static extern void SdfPrimSpecHandle_SetSymmetryFunction(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSymmetryArguments")]
		public static extern IntPtr SdfPrimSpecHandle_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetSymmetryArgument")]
		public static extern void SdfPrimSpecHandle_SetSymmetryArgument(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSymmetricPeer")]
		public static extern string SdfPrimSpecHandle_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetSymmetricPeer")]
		public static extern void SdfPrimSpecHandle_SetSymmetricPeer(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetPrefix")]
		public static extern string SdfPrimSpecHandle_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetPrefix")]
		public static extern void SdfPrimSpecHandle_SetPrefix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSuffix")]
		public static extern string SdfPrimSpecHandle_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetSuffix")]
		public static extern void SdfPrimSpecHandle_SetSuffix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetCustomData")]
		public static extern IntPtr SdfPrimSpecHandle_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetAssetInfo")]
		public static extern IntPtr SdfPrimSpecHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetCustomData")]
		public static extern void SdfPrimSpecHandle_SetCustomData(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetAssetInfo")]
		public static extern void SdfPrimSpecHandle_SetAssetInfo(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSpecifier")]
		public static extern int SdfPrimSpecHandle_GetSpecifier(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetSpecifier")]
		public static extern void SdfPrimSpecHandle_SetSpecifier(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetPermission")]
		public static extern int SdfPrimSpecHandle_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetPermission")]
		public static extern void SdfPrimSpecHandle_SetPermission(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetPrefixSubstitutions")]
		public static extern IntPtr SdfPrimSpecHandle_GetPrefixSubstitutions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetPrefixSubstitutions")]
		public static extern void SdfPrimSpecHandle_SetPrefixSubstitutions(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSuffixSubstitutions")]
		public static extern IntPtr SdfPrimSpecHandle_GetSuffixSubstitutions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetSuffixSubstitutions")]
		public static extern void SdfPrimSpecHandle_SetSuffixSubstitutions(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetInstanceable")]
		public static extern void SdfPrimSpecHandle_SetInstanceable(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetInstanceable")]
		public static extern bool SdfPrimSpecHandle_GetInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasInstanceable")]
		public static extern bool SdfPrimSpecHandle_HasInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearInstanceable")]
		public static extern void SdfPrimSpecHandle_ClearInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetPayloadList")]
		public static extern IntPtr SdfPrimSpecHandle_GetPayloadList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasPayloads")]
		public static extern bool SdfPrimSpecHandle_HasPayloads(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearPayloadList")]
		public static extern void SdfPrimSpecHandle_ClearPayloadList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetInheritPathList")]
		public static extern IntPtr SdfPrimSpecHandle_GetInheritPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasInheritPaths")]
		public static extern bool SdfPrimSpecHandle_HasInheritPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearInheritPathList")]
		public static extern void SdfPrimSpecHandle_ClearInheritPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSpecializesList")]
		public static extern IntPtr SdfPrimSpecHandle_GetSpecializesList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasSpecializes")]
		public static extern bool SdfPrimSpecHandle_HasSpecializes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearSpecializesList")]
		public static extern void SdfPrimSpecHandle_ClearSpecializesList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetReferenceList")]
		public static extern IntPtr SdfPrimSpecHandle_GetReferenceList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasReferences")]
		public static extern bool SdfPrimSpecHandle_HasReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearReferenceList")]
		public static extern void SdfPrimSpecHandle_ClearReferenceList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetVariantSetNameList")]
		public static extern IntPtr SdfPrimSpecHandle_GetVariantSetNameList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasVariantSetNames")]
		public static extern bool SdfPrimSpecHandle_HasVariantSetNames(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetVariantNames")]
		public static extern IntPtr SdfPrimSpecHandle_GetVariantNames(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_RemoveVariantSet")]
		public static extern void SdfPrimSpecHandle_RemoveVariantSet(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetVariantSelections")]
		public static extern IntPtr SdfPrimSpecHandle_GetVariantSelections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetVariantSelection")]
		public static extern void SdfPrimSpecHandle_SetVariantSelection(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_BlockVariantSelection")]
		public static extern void SdfPrimSpecHandle_BlockVariantSelection(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetRelocates")]
		public static extern IntPtr SdfPrimSpecHandle_GetRelocates(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetRelocates")]
		public static extern void SdfPrimSpecHandle_SetRelocates(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasRelocates")]
		public static extern bool SdfPrimSpecHandle_HasRelocates(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearRelocates")]
		public static extern void SdfPrimSpecHandle_ClearRelocates(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSchema")]
		public static extern IntPtr SdfPrimSpecHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetSpecType")]
		public static extern int SdfPrimSpecHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_IsDormant")]
		public static extern bool SdfPrimSpecHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetLayer")]
		public static extern IntPtr SdfPrimSpecHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetPath")]
		public static extern IntPtr SdfPrimSpecHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_PermissionToEdit")]
		public static extern bool SdfPrimSpecHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ListInfoKeys")]
		public static extern IntPtr SdfPrimSpecHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfPrimSpecHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfPrimSpecHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetInfo")]
		public static extern IntPtr SdfPrimSpecHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetInfo")]
		public static extern void SdfPrimSpecHandle_SetInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetInfoDictionaryValue")]
		public static extern void SdfPrimSpecHandle_SetInfoDictionaryValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasInfo")]
		public static extern bool SdfPrimSpecHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearInfo")]
		public static extern void SdfPrimSpecHandle_ClearInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetTypeForInfo")]
		public static extern IntPtr SdfPrimSpecHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfPrimSpecHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_IsInert__SWIG_0")]
		public static extern bool SdfPrimSpecHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_IsInert__SWIG_1")]
		public static extern bool SdfPrimSpecHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ListFields")]
		public static extern IntPtr SdfPrimSpecHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_HasField")]
		public static extern bool SdfPrimSpecHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_GetField")]
		public static extern IntPtr SdfPrimSpecHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_SetField")]
		public static extern bool SdfPrimSpecHandle_SetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandle_ClearField")]
		public static extern bool SdfPrimSpecHandle_ClearField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecConstHandle__SWIG_0")]
		public static extern IntPtr new_SdfPrimSpecConstHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecConstHandle__SWIG_1")]
		public static extern IntPtr new_SdfPrimSpecConstHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecConstHandle__SWIG_2")]
		public static extern IntPtr new_SdfPrimSpecConstHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle___deref__")]
		public static extern IntPtr SdfPrimSpecConstHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPrimSpecConstHandle")]
		public static extern void delete_SdfPrimSpecConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetName")]
		public static extern string SdfPrimSpecConstHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetNameToken")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_CanSetName")]
		public static extern bool SdfPrimSpecConstHandle_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetNameRoot")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetNameRoot(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetNameParent")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetNameParent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetRealNameParent")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetRealNameParent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetNameChildren")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetNameChildren(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasNameChildrenOrder")]
		public static extern bool SdfPrimSpecConstHandle_HasNameChildrenOrder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_ApplyNameChildrenOrder")]
		public static extern void SdfPrimSpecConstHandle_ApplyNameChildrenOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetProperties")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetProperties(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetAttributes")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetAttributes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetRelationships")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetRelationships(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasPropertyOrder")]
		public static extern bool SdfPrimSpecConstHandle_HasPropertyOrder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_ApplyPropertyOrder")]
		public static extern void SdfPrimSpecConstHandle_ApplyPropertyOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetObjectAtPath")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetObjectAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetPrimAtPath")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetPrimAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetPropertyAtPath")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetPropertyAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetAttributeAtPath")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetAttributeAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetRelationshipAtPath")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetRelationshipAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetTypeName")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetComment")]
		public static extern string SdfPrimSpecConstHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetDocumentation")]
		public static extern string SdfPrimSpecConstHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetActive")]
		public static extern bool SdfPrimSpecConstHandle_GetActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasActive")]
		public static extern bool SdfPrimSpecConstHandle_HasActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetHidden")]
		public static extern bool SdfPrimSpecConstHandle_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetKind")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasKind")]
		public static extern bool SdfPrimSpecConstHandle_HasKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSymmetryFunction")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSymmetryArguments")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSymmetricPeer")]
		public static extern string SdfPrimSpecConstHandle_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetPrefix")]
		public static extern string SdfPrimSpecConstHandle_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSuffix")]
		public static extern string SdfPrimSpecConstHandle_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetCustomData")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetAssetInfo")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSpecifier")]
		public static extern int SdfPrimSpecConstHandle_GetSpecifier(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetPermission")]
		public static extern int SdfPrimSpecConstHandle_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetPrefixSubstitutions")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetPrefixSubstitutions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSuffixSubstitutions")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetSuffixSubstitutions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetInstanceable")]
		public static extern bool SdfPrimSpecConstHandle_GetInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasInstanceable")]
		public static extern bool SdfPrimSpecConstHandle_HasInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetPayloadList")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetPayloadList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasPayloads")]
		public static extern bool SdfPrimSpecConstHandle_HasPayloads(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetInheritPathList")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetInheritPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasInheritPaths")]
		public static extern bool SdfPrimSpecConstHandle_HasInheritPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSpecializesList")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetSpecializesList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasSpecializes")]
		public static extern bool SdfPrimSpecConstHandle_HasSpecializes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetReferenceList")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetReferenceList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasReferences")]
		public static extern bool SdfPrimSpecConstHandle_HasReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetVariantSetNameList")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetVariantSetNameList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasVariantSetNames")]
		public static extern bool SdfPrimSpecConstHandle_HasVariantSetNames(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetVariantNames")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetVariantNames(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetVariantSelections")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetVariantSelections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetRelocates")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetRelocates(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasRelocates")]
		public static extern bool SdfPrimSpecConstHandle_HasRelocates(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSchema")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetSpecType")]
		public static extern int SdfPrimSpecConstHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_IsDormant")]
		public static extern bool SdfPrimSpecConstHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetLayer")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetPath")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_PermissionToEdit")]
		public static extern bool SdfPrimSpecConstHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_ListInfoKeys")]
		public static extern IntPtr SdfPrimSpecConstHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetInfo")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasInfo")]
		public static extern bool SdfPrimSpecConstHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetTypeForInfo")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_IsInert__SWIG_0")]
		public static extern bool SdfPrimSpecConstHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_IsInert__SWIG_1")]
		public static extern bool SdfPrimSpecConstHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_ListFields")]
		public static extern IntPtr SdfPrimSpecConstHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_HasField")]
		public static extern bool SdfPrimSpecConstHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandle_GetField")]
		public static extern IntPtr SdfPrimSpecConstHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_Clear")]
		public static extern void SdfPrimSpecHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_Add")]
		public static extern void SdfPrimSpecHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_size")]
		public static extern uint SdfPrimSpecHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_capacity")]
		public static extern uint SdfPrimSpecHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_reserve")]
		public static extern void SdfPrimSpecHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfPrimSpecHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfPrimSpecHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfPrimSpecHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_getitemcopy")]
		public static extern IntPtr SdfPrimSpecHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_getitem")]
		public static extern IntPtr SdfPrimSpecHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_setitem")]
		public static extern void SdfPrimSpecHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_AddRange")]
		public static extern void SdfPrimSpecHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_GetRange")]
		public static extern IntPtr SdfPrimSpecHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_Insert")]
		public static extern void SdfPrimSpecHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_InsertRange")]
		public static extern void SdfPrimSpecHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_RemoveAt")]
		public static extern void SdfPrimSpecHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_RemoveRange")]
		public static extern void SdfPrimSpecHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_Repeat")]
		public static extern IntPtr SdfPrimSpecHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_Reverse__SWIG_0")]
		public static extern void SdfPrimSpecHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_Reverse__SWIG_1")]
		public static extern void SdfPrimSpecHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecHandleVector_SetRange")]
		public static extern void SdfPrimSpecHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPrimSpecHandleVector")]
		public static extern void delete_SdfPrimSpecHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_Clear")]
		public static extern void SdfPrimSpecConstHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_Add")]
		public static extern void SdfPrimSpecConstHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_size")]
		public static extern uint SdfPrimSpecConstHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_capacity")]
		public static extern uint SdfPrimSpecConstHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_reserve")]
		public static extern void SdfPrimSpecConstHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecConstHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfPrimSpecConstHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecConstHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfPrimSpecConstHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPrimSpecConstHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfPrimSpecConstHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_getitemcopy")]
		public static extern IntPtr SdfPrimSpecConstHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_getitem")]
		public static extern IntPtr SdfPrimSpecConstHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_setitem")]
		public static extern void SdfPrimSpecConstHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_AddRange")]
		public static extern void SdfPrimSpecConstHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_GetRange")]
		public static extern IntPtr SdfPrimSpecConstHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_Insert")]
		public static extern void SdfPrimSpecConstHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_InsertRange")]
		public static extern void SdfPrimSpecConstHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_RemoveAt")]
		public static extern void SdfPrimSpecConstHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_RemoveRange")]
		public static extern void SdfPrimSpecConstHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_Repeat")]
		public static extern IntPtr SdfPrimSpecConstHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_Reverse__SWIG_0")]
		public static extern void SdfPrimSpecConstHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_Reverse__SWIG_1")]
		public static extern void SdfPrimSpecConstHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpecConstHandleVector_SetRange")]
		public static extern void SdfPrimSpecConstHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPrimSpecConstHandleVector")]
		public static extern void delete_SdfPrimSpecConstHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecHandle__SWIG_0")]
		public static extern IntPtr new_SdfVariantSpecHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecHandle__SWIG_1")]
		public static extern IntPtr new_SdfVariantSpecHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecHandle__SWIG_2")]
		public static extern IntPtr new_SdfVariantSpecHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle___deref__")]
		public static extern IntPtr SdfVariantSpecHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSpecHandle")]
		public static extern void delete_SdfVariantSpecHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_New")]
		public static extern IntPtr SdfVariantSpecHandle_New(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetName")]
		public static extern string SdfVariantSpecHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetNameToken")]
		public static extern IntPtr SdfVariantSpecHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetOwner")]
		public static extern IntPtr SdfVariantSpecHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetPrimSpec")]
		public static extern IntPtr SdfVariantSpecHandle_GetPrimSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetVariantNames")]
		public static extern IntPtr SdfVariantSpecHandle_GetVariantNames(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetSchema")]
		public static extern IntPtr SdfVariantSpecHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetSpecType")]
		public static extern int SdfVariantSpecHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_IsDormant")]
		public static extern bool SdfVariantSpecHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetLayer")]
		public static extern IntPtr SdfVariantSpecHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetPath")]
		public static extern IntPtr SdfVariantSpecHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_PermissionToEdit")]
		public static extern bool SdfVariantSpecHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_ListInfoKeys")]
		public static extern IntPtr SdfVariantSpecHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfVariantSpecHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfVariantSpecHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetInfo")]
		public static extern IntPtr SdfVariantSpecHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_SetInfo")]
		public static extern void SdfVariantSpecHandle_SetInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_SetInfoDictionaryValue")]
		public static extern void SdfVariantSpecHandle_SetInfoDictionaryValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_HasInfo")]
		public static extern bool SdfVariantSpecHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_ClearInfo")]
		public static extern void SdfVariantSpecHandle_ClearInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetTypeForInfo")]
		public static extern IntPtr SdfVariantSpecHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfVariantSpecHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_IsInert__SWIG_0")]
		public static extern bool SdfVariantSpecHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_IsInert__SWIG_1")]
		public static extern bool SdfVariantSpecHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_ListFields")]
		public static extern IntPtr SdfVariantSpecHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_HasField")]
		public static extern bool SdfVariantSpecHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_GetField")]
		public static extern IntPtr SdfVariantSpecHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_SetField")]
		public static extern bool SdfVariantSpecHandle_SetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandle_ClearField")]
		public static extern bool SdfVariantSpecHandle_ClearField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecConstHandle__SWIG_0")]
		public static extern IntPtr new_SdfVariantSpecConstHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecConstHandle__SWIG_1")]
		public static extern IntPtr new_SdfVariantSpecConstHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecConstHandle__SWIG_2")]
		public static extern IntPtr new_SdfVariantSpecConstHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle___deref__")]
		public static extern IntPtr SdfVariantSpecConstHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSpecConstHandle")]
		public static extern void delete_SdfVariantSpecConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetName")]
		public static extern string SdfVariantSpecConstHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetNameToken")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetOwner")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetPrimSpec")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetPrimSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetVariantNames")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetVariantNames(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetSchema")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetSpecType")]
		public static extern int SdfVariantSpecConstHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_IsDormant")]
		public static extern bool SdfVariantSpecConstHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetLayer")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetPath")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_PermissionToEdit")]
		public static extern bool SdfVariantSpecConstHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_ListInfoKeys")]
		public static extern IntPtr SdfVariantSpecConstHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetInfo")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_HasInfo")]
		public static extern bool SdfVariantSpecConstHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetTypeForInfo")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_IsInert__SWIG_0")]
		public static extern bool SdfVariantSpecConstHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_IsInert__SWIG_1")]
		public static extern bool SdfVariantSpecConstHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_ListFields")]
		public static extern IntPtr SdfVariantSpecConstHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_HasField")]
		public static extern bool SdfVariantSpecConstHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandle_GetField")]
		public static extern IntPtr SdfVariantSpecConstHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_Clear")]
		public static extern void SdfVariantSpecHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_Add")]
		public static extern void SdfVariantSpecHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_size")]
		public static extern uint SdfVariantSpecHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_capacity")]
		public static extern uint SdfVariantSpecHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_reserve")]
		public static extern void SdfVariantSpecHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfVariantSpecHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfVariantSpecHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfVariantSpecHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_getitemcopy")]
		public static extern IntPtr SdfVariantSpecHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_getitem")]
		public static extern IntPtr SdfVariantSpecHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_setitem")]
		public static extern void SdfVariantSpecHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_AddRange")]
		public static extern void SdfVariantSpecHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_GetRange")]
		public static extern IntPtr SdfVariantSpecHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_Insert")]
		public static extern void SdfVariantSpecHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_InsertRange")]
		public static extern void SdfVariantSpecHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_RemoveAt")]
		public static extern void SdfVariantSpecHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_RemoveRange")]
		public static extern void SdfVariantSpecHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_Repeat")]
		public static extern IntPtr SdfVariantSpecHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_Reverse__SWIG_0")]
		public static extern void SdfVariantSpecHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_Reverse__SWIG_1")]
		public static extern void SdfVariantSpecHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecHandleVector_SetRange")]
		public static extern void SdfVariantSpecHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSpecHandleVector")]
		public static extern void delete_SdfVariantSpecHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_Clear")]
		public static extern void SdfVariantSpecConstHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_Add")]
		public static extern void SdfVariantSpecConstHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_size")]
		public static extern uint SdfVariantSpecConstHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_capacity")]
		public static extern uint SdfVariantSpecConstHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_reserve")]
		public static extern void SdfVariantSpecConstHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecConstHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfVariantSpecConstHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecConstHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfVariantSpecConstHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSpecConstHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfVariantSpecConstHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_getitemcopy")]
		public static extern IntPtr SdfVariantSpecConstHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_getitem")]
		public static extern IntPtr SdfVariantSpecConstHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_setitem")]
		public static extern void SdfVariantSpecConstHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_AddRange")]
		public static extern void SdfVariantSpecConstHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_GetRange")]
		public static extern IntPtr SdfVariantSpecConstHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_Insert")]
		public static extern void SdfVariantSpecConstHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_InsertRange")]
		public static extern void SdfVariantSpecConstHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_RemoveAt")]
		public static extern void SdfVariantSpecConstHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_RemoveRange")]
		public static extern void SdfVariantSpecConstHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_Repeat")]
		public static extern IntPtr SdfVariantSpecConstHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_Reverse__SWIG_0")]
		public static extern void SdfVariantSpecConstHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_Reverse__SWIG_1")]
		public static extern void SdfVariantSpecConstHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpecConstHandleVector_SetRange")]
		public static extern void SdfVariantSpecConstHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSpecConstHandleVector")]
		public static extern void delete_SdfVariantSpecConstHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecHandle__SWIG_0")]
		public static extern IntPtr new_SdfVariantSetSpecHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecHandle__SWIG_1")]
		public static extern IntPtr new_SdfVariantSetSpecHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecHandle__SWIG_2")]
		public static extern IntPtr new_SdfVariantSetSpecHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle___deref__")]
		public static extern IntPtr SdfVariantSetSpecHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSetSpecHandle")]
		public static extern void delete_SdfVariantSetSpecHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_New__SWIG_0")]
		public static extern IntPtr SdfVariantSetSpecHandle_New__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_New__SWIG_1")]
		public static extern IntPtr SdfVariantSetSpecHandle_New__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetName")]
		public static extern string SdfVariantSetSpecHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetNameToken")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetOwner")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetVariants")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetVariants(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetVariantList")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetVariantList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_RemoveVariant")]
		public static extern void SdfVariantSetSpecHandle_RemoveVariant(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetSchema")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetSpecType")]
		public static extern int SdfVariantSetSpecHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_IsDormant")]
		public static extern bool SdfVariantSetSpecHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetLayer")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetPath")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_PermissionToEdit")]
		public static extern bool SdfVariantSetSpecHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_ListInfoKeys")]
		public static extern IntPtr SdfVariantSetSpecHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetInfo")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_SetInfo")]
		public static extern void SdfVariantSetSpecHandle_SetInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_SetInfoDictionaryValue")]
		public static extern void SdfVariantSetSpecHandle_SetInfoDictionaryValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_HasInfo")]
		public static extern bool SdfVariantSetSpecHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_ClearInfo")]
		public static extern void SdfVariantSetSpecHandle_ClearInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetTypeForInfo")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_IsInert__SWIG_0")]
		public static extern bool SdfVariantSetSpecHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_IsInert__SWIG_1")]
		public static extern bool SdfVariantSetSpecHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_ListFields")]
		public static extern IntPtr SdfVariantSetSpecHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_HasField")]
		public static extern bool SdfVariantSetSpecHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_GetField")]
		public static extern IntPtr SdfVariantSetSpecHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_SetField")]
		public static extern bool SdfVariantSetSpecHandle_SetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandle_ClearField")]
		public static extern bool SdfVariantSetSpecHandle_ClearField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecConstHandle__SWIG_0")]
		public static extern IntPtr new_SdfVariantSetSpecConstHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecConstHandle__SWIG_1")]
		public static extern IntPtr new_SdfVariantSetSpecConstHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecConstHandle__SWIG_2")]
		public static extern IntPtr new_SdfVariantSetSpecConstHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle___deref__")]
		public static extern IntPtr SdfVariantSetSpecConstHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSetSpecConstHandle")]
		public static extern void delete_SdfVariantSetSpecConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetName")]
		public static extern string SdfVariantSetSpecConstHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetNameToken")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetOwner")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetVariants")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetVariants(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetVariantList")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetVariantList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetSchema")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetSpecType")]
		public static extern int SdfVariantSetSpecConstHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_IsDormant")]
		public static extern bool SdfVariantSetSpecConstHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetLayer")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetPath")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_PermissionToEdit")]
		public static extern bool SdfVariantSetSpecConstHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_ListInfoKeys")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetInfo")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_HasInfo")]
		public static extern bool SdfVariantSetSpecConstHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetTypeForInfo")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_IsInert__SWIG_0")]
		public static extern bool SdfVariantSetSpecConstHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_IsInert__SWIG_1")]
		public static extern bool SdfVariantSetSpecConstHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_ListFields")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_HasField")]
		public static extern bool SdfVariantSetSpecConstHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandle_GetField")]
		public static extern IntPtr SdfVariantSetSpecConstHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_Clear")]
		public static extern void SdfVariantSetSpecHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_Add")]
		public static extern void SdfVariantSetSpecHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_size")]
		public static extern uint SdfVariantSetSpecHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_capacity")]
		public static extern uint SdfVariantSetSpecHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_reserve")]
		public static extern void SdfVariantSetSpecHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfVariantSetSpecHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfVariantSetSpecHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfVariantSetSpecHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_getitemcopy")]
		public static extern IntPtr SdfVariantSetSpecHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_getitem")]
		public static extern IntPtr SdfVariantSetSpecHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_setitem")]
		public static extern void SdfVariantSetSpecHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_AddRange")]
		public static extern void SdfVariantSetSpecHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_GetRange")]
		public static extern IntPtr SdfVariantSetSpecHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_Insert")]
		public static extern void SdfVariantSetSpecHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_InsertRange")]
		public static extern void SdfVariantSetSpecHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_RemoveAt")]
		public static extern void SdfVariantSetSpecHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_RemoveRange")]
		public static extern void SdfVariantSetSpecHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_Repeat")]
		public static extern IntPtr SdfVariantSetSpecHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_Reverse__SWIG_0")]
		public static extern void SdfVariantSetSpecHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_Reverse__SWIG_1")]
		public static extern void SdfVariantSetSpecHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecHandleVector_SetRange")]
		public static extern void SdfVariantSetSpecHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSetSpecHandleVector")]
		public static extern void delete_SdfVariantSetSpecHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_Clear")]
		public static extern void SdfVariantSetSpecConstHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_Add")]
		public static extern void SdfVariantSetSpecConstHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_size")]
		public static extern uint SdfVariantSetSpecConstHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_capacity")]
		public static extern uint SdfVariantSetSpecConstHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_reserve")]
		public static extern void SdfVariantSetSpecConstHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecConstHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfVariantSetSpecConstHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecConstHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfVariantSetSpecConstHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfVariantSetSpecConstHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfVariantSetSpecConstHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_getitemcopy")]
		public static extern IntPtr SdfVariantSetSpecConstHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_getitem")]
		public static extern IntPtr SdfVariantSetSpecConstHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_setitem")]
		public static extern void SdfVariantSetSpecConstHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_AddRange")]
		public static extern void SdfVariantSetSpecConstHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_GetRange")]
		public static extern IntPtr SdfVariantSetSpecConstHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_Insert")]
		public static extern void SdfVariantSetSpecConstHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_InsertRange")]
		public static extern void SdfVariantSetSpecConstHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_RemoveAt")]
		public static extern void SdfVariantSetSpecConstHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_RemoveRange")]
		public static extern void SdfVariantSetSpecConstHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_Repeat")]
		public static extern IntPtr SdfVariantSetSpecConstHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_Reverse__SWIG_0")]
		public static extern void SdfVariantSetSpecConstHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_Reverse__SWIG_1")]
		public static extern void SdfVariantSetSpecConstHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpecConstHandleVector_SetRange")]
		public static extern void SdfVariantSetSpecConstHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSetSpecConstHandleVector")]
		public static extern void delete_SdfVariantSetSpecConstHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpec_New")]
		public static extern IntPtr SdfVariantSpec_New(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpec_GetName")]
		public static extern string SdfVariantSpec_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpec_GetNameToken")]
		public static extern IntPtr SdfVariantSpec_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpec_GetOwner")]
		public static extern IntPtr SdfVariantSpec_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpec_GetPrimSpec")]
		public static extern IntPtr SdfVariantSpec_GetPrimSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpec_GetVariantNames")]
		public static extern IntPtr SdfVariantSpec_GetVariantNames(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfVariantSpec")]
		public static extern void delete_SdfVariantSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfCreateVariantInLayer")]
		public static extern IntPtr SdfCreateVariantInLayer(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_HandleRefWrapper_handlePtr_set")]
		public static extern void HandleRefWrapper_handlePtr_set(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_HandleRefWrapper_handlePtr_get")]
		public static extern IntPtr HandleRefWrapper_handlePtr_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_HandleRefWrapper_refPtr_set")]
		public static extern void HandleRefWrapper_refPtr_set(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_HandleRefWrapper_refPtr_get")]
		public static extern IntPtr HandleRefWrapper_refPtr_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_HandleRefWrapper")]
		public static extern IntPtr new_HandleRefWrapper();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_HandleRefWrapper")]
		public static extern void delete_HandleRefWrapper(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerHandleSet__SWIG_0")]
		public static extern IntPtr new_SdfLayerHandleSet__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerHandleSet__SWIG_1")]
		public static extern IntPtr new_SdfLayerHandleSet__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_size")]
		public static extern uint SdfLayerHandleSet_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_empty")]
		public static extern bool SdfLayerHandleSet_empty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_Clear")]
		public static extern void SdfLayerHandleSet_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_Add")]
		public static extern bool SdfLayerHandleSet_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_Contains")]
		public static extern bool SdfLayerHandleSet_Contains(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_Remove")]
		public static extern bool SdfLayerHandleSet_Remove(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_getitem")]
		public static extern IntPtr SdfLayerHandleSet_getitem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_create_iterator_begin")]
		public static extern IntPtr SdfLayerHandleSet_create_iterator_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_get_next")]
		public static extern IntPtr SdfLayerHandleSet_get_next(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandleSet_destroy_iterator")]
		public static extern void SdfLayerHandleSet_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerHandleSet")]
		public static extern void delete_SdfLayerHandleSet(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerHandle")]
		public static extern IntPtr new_SdfLayerHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle___deref__")]
		public static extern IntPtr SdfLayerHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Equals")]
		public static extern bool SdfLayerHandle_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetHashCode")]
		public static extern int SdfLayerHandle_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerHandle")]
		public static extern void delete_SdfLayerHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetSchema")]
		public static extern IntPtr SdfLayerHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetFileFormat")]
		public static extern IntPtr SdfLayerHandle_GetFileFormat(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetFileFormatArguments")]
		public static extern IntPtr SdfLayerHandle_GetFileFormatArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateNew__SWIG_0")]
		public static extern IntPtr SdfLayerHandle_CreateNew__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateNew__SWIG_1")]
		public static extern IntPtr SdfLayerHandle_CreateNew__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateNew__SWIG_2")]
		public static extern IntPtr SdfLayerHandle_CreateNew__SWIG_2(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateNew__SWIG_3")]
		public static extern IntPtr SdfLayerHandle_CreateNew__SWIG_3(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_New__SWIG_0")]
		public static extern IntPtr SdfLayerHandle_New__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_New__SWIG_1")]
		public static extern IntPtr SdfLayerHandle_New__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Find__SWIG_0")]
		public static extern IntPtr SdfLayerHandle_Find__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Find__SWIG_1")]
		public static extern IntPtr SdfLayerHandle_Find__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_FindRelativeToLayer__SWIG_0")]
		public static extern IntPtr SdfLayerHandle_FindRelativeToLayer__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_FindRelativeToLayer__SWIG_1")]
		public static extern IntPtr SdfLayerHandle_FindRelativeToLayer__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_FindOrOpen__SWIG_0")]
		public static extern IntPtr SdfLayerHandle_FindOrOpen__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_FindOrOpen__SWIG_1")]
		public static extern IntPtr SdfLayerHandle_FindOrOpen__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_FindOrOpenRelativeToLayer__SWIG_0")]
		public static extern IntPtr SdfLayerHandle_FindOrOpenRelativeToLayer__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_FindOrOpenRelativeToLayer__SWIG_1")]
		public static extern IntPtr SdfLayerHandle_FindOrOpenRelativeToLayer__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_OpenAsAnonymous__SWIG_0")]
		public static extern IntPtr SdfLayerHandle_OpenAsAnonymous__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3, string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_OpenAsAnonymous__SWIG_1")]
		public static extern IntPtr SdfLayerHandle_OpenAsAnonymous__SWIG_1(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_OpenAsAnonymous__SWIG_2")]
		public static extern IntPtr SdfLayerHandle_OpenAsAnonymous__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetHints")]
		public static extern IntPtr SdfLayerHandle_GetHints(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetLoadedLayers")]
		public static extern IntPtr SdfLayerHandle_GetLoadedLayers(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_IsEmpty")]
		public static extern bool SdfLayerHandle_IsEmpty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_StreamsData")]
		public static extern bool SdfLayerHandle_StreamsData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_IsDetached")]
		public static extern bool SdfLayerHandle_IsDetached(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_TransferContent")]
		public static extern void SdfLayerHandle_TransferContent(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateAnonymous__SWIG_0")]
		public static extern IntPtr SdfLayerHandle_CreateAnonymous__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateAnonymous__SWIG_1")]
		public static extern IntPtr SdfLayerHandle_CreateAnonymous__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateAnonymous__SWIG_2")]
		public static extern IntPtr SdfLayerHandle_CreateAnonymous__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateAnonymous__SWIG_3")]
		public static extern IntPtr SdfLayerHandle_CreateAnonymous__SWIG_3(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateAnonymous__SWIG_4")]
		public static extern IntPtr SdfLayerHandle_CreateAnonymous__SWIG_4(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_IsAnonymous")]
		public static extern bool SdfLayerHandle_IsAnonymous(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_IsAnonymousLayerIdentifier")]
		public static extern bool SdfLayerHandle_IsAnonymousLayerIdentifier(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetDisplayNameFromIdentifier")]
		public static extern string SdfLayerHandle_GetDisplayNameFromIdentifier(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Save__SWIG_0")]
		public static extern bool SdfLayerHandle_Save__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Save__SWIG_1")]
		public static extern bool SdfLayerHandle_Save__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Export__SWIG_0")]
		public static extern bool SdfLayerHandle_Export__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Export__SWIG_1")]
		public static extern bool SdfLayerHandle_Export__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Export__SWIG_2")]
		public static extern bool SdfLayerHandle_Export__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ImportFromString")]
		public static extern bool SdfLayerHandle_ImportFromString(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Clear")]
		public static extern void SdfLayerHandle_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Reload__SWIG_0")]
		public static extern bool SdfLayerHandle_Reload__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Reload__SWIG_1")]
		public static extern bool SdfLayerHandle_Reload__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ReloadLayers__SWIG_0")]
		public static extern bool SdfLayerHandle_ReloadLayers__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ReloadLayers__SWIG_1")]
		public static extern bool SdfLayerHandle_ReloadLayers__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Import")]
		public static extern bool SdfLayerHandle_Import(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetExternalReferences")]
		public static extern IntPtr SdfLayerHandle_GetExternalReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_UpdateExternalReference__SWIG_0")]
		public static extern bool SdfLayerHandle_UpdateExternalReference__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_UpdateExternalReference__SWIG_1")]
		public static extern bool SdfLayerHandle_UpdateExternalReference__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetCompositionAssetDependencies")]
		public static extern IntPtr SdfLayerHandle_GetCompositionAssetDependencies(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_UpdateCompositionAssetDependency__SWIG_0")]
		public static extern bool SdfLayerHandle_UpdateCompositionAssetDependency__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_UpdateCompositionAssetDependency__SWIG_1")]
		public static extern bool SdfLayerHandle_UpdateCompositionAssetDependency__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetExternalAssetDependencies")]
		public static extern IntPtr SdfLayerHandle_GetExternalAssetDependencies(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SplitIdentifier")]
		public static extern bool SdfLayerHandle_SplitIdentifier(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CreateIdentifier")]
		public static extern string SdfLayerHandle_CreateIdentifier(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetIdentifier")]
		public static extern string SdfLayerHandle_GetIdentifier(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetIdentifier")]
		public static extern void SdfLayerHandle_SetIdentifier(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_UpdateAssetInfo")]
		public static extern void SdfLayerHandle_UpdateAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetDisplayName")]
		public static extern string SdfLayerHandle_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetResolvedPath")]
		public static extern IntPtr SdfLayerHandle_GetResolvedPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetRealPath")]
		public static extern string SdfLayerHandle_GetRealPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetFileExtension")]
		public static extern string SdfLayerHandle_GetFileExtension(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetVersion")]
		public static extern string SdfLayerHandle_GetVersion(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetRepositoryPath")]
		public static extern string SdfLayerHandle_GetRepositoryPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetAssetName")]
		public static extern string SdfLayerHandle_GetAssetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetAssetInfo")]
		public static extern IntPtr SdfLayerHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ComputeAbsolutePath")]
		public static extern string SdfLayerHandle_ComputeAbsolutePath(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetSpecType")]
		public static extern int SdfLayerHandle_GetSpecType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasSpec")]
		public static extern bool SdfLayerHandle_HasSpec(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ListFields")]
		public static extern IntPtr SdfLayerHandle_ListFields(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasField__SWIG_0")]
		public static extern bool SdfLayerHandle_HasField__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasField__SWIG_1")]
		public static extern bool SdfLayerHandle_HasField__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasField__SWIG_2")]
		public static extern bool SdfLayerHandle_HasField__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasFieldDictKey__SWIG_0")]
		public static extern bool SdfLayerHandle_HasFieldDictKey__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasFieldDictKey__SWIG_1")]
		public static extern bool SdfLayerHandle_HasFieldDictKey__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasFieldDictKey__SWIG_2")]
		public static extern bool SdfLayerHandle_HasFieldDictKey__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetField")]
		public static extern IntPtr SdfLayerHandle_GetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetFieldDictValueByKey")]
		public static extern IntPtr SdfLayerHandle_GetFieldDictValueByKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetField__SWIG_0")]
		public static extern void SdfLayerHandle_SetField__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetField__SWIG_1")]
		public static extern void SdfLayerHandle_SetField__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetFieldDictValueByKey__SWIG_0")]
		public static extern void SdfLayerHandle_SetFieldDictValueByKey__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetFieldDictValueByKey__SWIG_1")]
		public static extern void SdfLayerHandle_SetFieldDictValueByKey__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_EraseField")]
		public static extern void SdfLayerHandle_EraseField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_EraseFieldDictValueByKey")]
		public static extern void SdfLayerHandle_EraseFieldDictValueByKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetColorConfiguration")]
		public static extern IntPtr SdfLayerHandle_GetColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetColorConfiguration")]
		public static extern void SdfLayerHandle_SetColorConfiguration(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasColorConfiguration")]
		public static extern bool SdfLayerHandle_HasColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearColorConfiguration")]
		public static extern void SdfLayerHandle_ClearColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetColorManagementSystem")]
		public static extern IntPtr SdfLayerHandle_GetColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetColorManagementSystem")]
		public static extern void SdfLayerHandle_SetColorManagementSystem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasColorManagementSystem")]
		public static extern bool SdfLayerHandle_HasColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearColorManagementSystem")]
		public static extern void SdfLayerHandle_ClearColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetComment")]
		public static extern string SdfLayerHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetComment")]
		public static extern void SdfLayerHandle_SetComment(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetDefaultPrim")]
		public static extern IntPtr SdfLayerHandle_GetDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetDefaultPrim")]
		public static extern void SdfLayerHandle_SetDefaultPrim(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearDefaultPrim")]
		public static extern void SdfLayerHandle_ClearDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasDefaultPrim")]
		public static extern bool SdfLayerHandle_HasDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetDocumentation")]
		public static extern string SdfLayerHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetDocumentation")]
		public static extern void SdfLayerHandle_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetStartTimeCode")]
		public static extern double SdfLayerHandle_GetStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetStartTimeCode")]
		public static extern void SdfLayerHandle_SetStartTimeCode(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasStartTimeCode")]
		public static extern bool SdfLayerHandle_HasStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearStartTimeCode")]
		public static extern void SdfLayerHandle_ClearStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetEndTimeCode")]
		public static extern double SdfLayerHandle_GetEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetEndTimeCode")]
		public static extern void SdfLayerHandle_SetEndTimeCode(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasEndTimeCode")]
		public static extern bool SdfLayerHandle_HasEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearEndTimeCode")]
		public static extern void SdfLayerHandle_ClearEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetTimeCodesPerSecond")]
		public static extern double SdfLayerHandle_GetTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetTimeCodesPerSecond")]
		public static extern void SdfLayerHandle_SetTimeCodesPerSecond(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasTimeCodesPerSecond")]
		public static extern bool SdfLayerHandle_HasTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearTimeCodesPerSecond")]
		public static extern void SdfLayerHandle_ClearTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetFramesPerSecond")]
		public static extern double SdfLayerHandle_GetFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetFramesPerSecond")]
		public static extern void SdfLayerHandle_SetFramesPerSecond(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasFramesPerSecond")]
		public static extern bool SdfLayerHandle_HasFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearFramesPerSecond")]
		public static extern void SdfLayerHandle_ClearFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetFramePrecision")]
		public static extern int SdfLayerHandle_GetFramePrecision(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetFramePrecision")]
		public static extern void SdfLayerHandle_SetFramePrecision(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasFramePrecision")]
		public static extern bool SdfLayerHandle_HasFramePrecision(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearFramePrecision")]
		public static extern void SdfLayerHandle_ClearFramePrecision(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetOwner")]
		public static extern string SdfLayerHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetOwner")]
		public static extern void SdfLayerHandle_SetOwner(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasOwner")]
		public static extern bool SdfLayerHandle_HasOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearOwner")]
		public static extern void SdfLayerHandle_ClearOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetSessionOwner")]
		public static extern string SdfLayerHandle_GetSessionOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetSessionOwner")]
		public static extern void SdfLayerHandle_SetSessionOwner(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasSessionOwner")]
		public static extern bool SdfLayerHandle_HasSessionOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearSessionOwner")]
		public static extern void SdfLayerHandle_ClearSessionOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetHasOwnedSubLayers")]
		public static extern bool SdfLayerHandle_GetHasOwnedSubLayers(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetHasOwnedSubLayers")]
		public static extern void SdfLayerHandle_SetHasOwnedSubLayers(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetCustomLayerData")]
		public static extern IntPtr SdfLayerHandle_GetCustomLayerData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetCustomLayerData")]
		public static extern void SdfLayerHandle_SetCustomLayerData(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_HasCustomLayerData")]
		public static extern bool SdfLayerHandle_HasCustomLayerData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ClearCustomLayerData")]
		public static extern void SdfLayerHandle_ClearCustomLayerData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetRootPrims")]
		public static extern IntPtr SdfLayerHandle_GetRootPrims(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetRootPrims")]
		public static extern void SdfLayerHandle_SetRootPrims(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_InsertRootPrim__SWIG_0")]
		public static extern bool SdfLayerHandle_InsertRootPrim__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_InsertRootPrim__SWIG_1")]
		public static extern bool SdfLayerHandle_InsertRootPrim__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_RemoveRootPrim")]
		public static extern void SdfLayerHandle_RemoveRootPrim(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ScheduleRemoveIfInert")]
		public static extern void SdfLayerHandle_ScheduleRemoveIfInert(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_RemovePrimIfInert")]
		public static extern void SdfLayerHandle_RemovePrimIfInert(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_RemovePropertyIfHasOnlyRequiredFields")]
		public static extern void SdfLayerHandle_RemovePropertyIfHasOnlyRequiredFields(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_RemoveInertSceneDescription")]
		public static extern void SdfLayerHandle_RemoveInertSceneDescription(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetRootPrimOrder")]
		public static extern void SdfLayerHandle_SetRootPrimOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_InsertInRootPrimOrder__SWIG_0")]
		public static extern void SdfLayerHandle_InsertInRootPrimOrder__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_InsertInRootPrimOrder__SWIG_1")]
		public static extern void SdfLayerHandle_InsertInRootPrimOrder__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_RemoveFromRootPrimOrder")]
		public static extern void SdfLayerHandle_RemoveFromRootPrimOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_RemoveFromRootPrimOrderByIndex")]
		public static extern void SdfLayerHandle_RemoveFromRootPrimOrderByIndex(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ApplyRootPrimOrder")]
		public static extern void SdfLayerHandle_ApplyRootPrimOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetSubLayerPaths")]
		public static extern IntPtr SdfLayerHandle_GetSubLayerPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetSubLayerPaths")]
		public static extern void SdfLayerHandle_SetSubLayerPaths(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetNumSubLayerPaths")]
		public static extern uint SdfLayerHandle_GetNumSubLayerPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_InsertSubLayerPath__SWIG_0")]
		public static extern void SdfLayerHandle_InsertSubLayerPath__SWIG_0(HandleRef jarg1, string jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_InsertSubLayerPath__SWIG_1")]
		public static extern void SdfLayerHandle_InsertSubLayerPath__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_RemoveSubLayerPath")]
		public static extern void SdfLayerHandle_RemoveSubLayerPath(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetSubLayerOffsets")]
		public static extern IntPtr SdfLayerHandle_GetSubLayerOffsets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetSubLayerOffset")]
		public static extern IntPtr SdfLayerHandle_GetSubLayerOffset(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetSubLayerOffset")]
		public static extern void SdfLayerHandle_SetSubLayerOffset(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetDetachedLayerRules")]
		public static extern void SdfLayerHandle_SetDetachedLayerRules(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetDetachedLayerRules")]
		public static extern IntPtr SdfLayerHandle_GetDetachedLayerRules(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_IsIncludedByDetachedLayerRules")]
		public static extern bool SdfLayerHandle_IsIncludedByDetachedLayerRules(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetMutedLayers")]
		public static extern IntPtr SdfLayerHandle_GetMutedLayers(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_IsMuted__SWIG_0")]
		public static extern bool SdfLayerHandle_IsMuted__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_IsMuted__SWIG_1")]
		public static extern bool SdfLayerHandle_IsMuted__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetMuted")]
		public static extern void SdfLayerHandle_SetMuted(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_AddToMutedLayers")]
		public static extern void SdfLayerHandle_AddToMutedLayers(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_RemoveFromMutedLayers")]
		public static extern void SdfLayerHandle_RemoveFromMutedLayers(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetPseudoRoot")]
		public static extern IntPtr SdfLayerHandle_GetPseudoRoot(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetObjectAtPath")]
		public static extern IntPtr SdfLayerHandle_GetObjectAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetPrimAtPath")]
		public static extern IntPtr SdfLayerHandle_GetPrimAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetPropertyAtPath")]
		public static extern IntPtr SdfLayerHandle_GetPropertyAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetAttributeAtPath")]
		public static extern IntPtr SdfLayerHandle_GetAttributeAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetRelationshipAtPath")]
		public static extern IntPtr SdfLayerHandle_GetRelationshipAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_PermissionToEdit")]
		public static extern bool SdfLayerHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_PermissionToSave")]
		public static extern bool SdfLayerHandle_PermissionToSave(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetPermissionToEdit")]
		public static extern void SdfLayerHandle_SetPermissionToEdit(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetPermissionToSave")]
		public static extern void SdfLayerHandle_SetPermissionToSave(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CanApply__SWIG_0")]
		public static extern int SdfLayerHandle_CanApply__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_CanApply__SWIG_1")]
		public static extern int SdfLayerHandle_CanApply__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_Apply")]
		public static extern bool SdfLayerHandle_Apply(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_IsDirty")]
		public static extern bool SdfLayerHandle_IsDirty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ListAllTimeSamples")]
		public static extern IntPtr SdfLayerHandle_ListAllTimeSamples(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ListTimeSamplesForPath")]
		public static extern IntPtr SdfLayerHandle_ListTimeSamplesForPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetBracketingTimeSamples")]
		public static extern bool SdfLayerHandle_GetBracketingTimeSamples(HandleRef jarg1, double jarg2, out double jarg3, out double jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetNumTimeSamplesForPath")]
		public static extern uint SdfLayerHandle_GetNumTimeSamplesForPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_GetBracketingTimeSamplesForPath")]
		public static extern bool SdfLayerHandle_GetBracketingTimeSamplesForPath(HandleRef jarg1, HandleRef jarg2, double jarg3, out double jarg4, out double jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_QueryTimeSample__SWIG_0")]
		public static extern bool SdfLayerHandle_QueryTimeSample__SWIG_0(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_QueryTimeSample__SWIG_1")]
		public static extern bool SdfLayerHandle_QueryTimeSample__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_QueryTimeSample__SWIG_2")]
		public static extern bool SdfLayerHandle_QueryTimeSample__SWIG_2(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetTimeSample__SWIG_0")]
		public static extern void SdfLayerHandle_SetTimeSample__SWIG_0(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_SetTimeSample__SWIG_1")]
		public static extern void SdfLayerHandle_SetTimeSample__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_EraseTimeSample")]
		public static extern void SdfLayerHandle_EraseTimeSample(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_DumpLayerInfo")]
		public static extern void SdfLayerHandle_DumpLayerInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_WriteDataFile")]
		public static extern bool SdfLayerHandle_WriteDataFile(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHandle_ExportToString")]
		public static extern string SdfLayerHandle_ExportToString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerConstHandle")]
		public static extern IntPtr new_SdfLayerConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle___deref__")]
		public static extern IntPtr SdfLayerConstHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerConstHandle")]
		public static extern void delete_SdfLayerConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetSchema")]
		public static extern IntPtr SdfLayerConstHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetFileFormat")]
		public static extern IntPtr SdfLayerConstHandle_GetFileFormat(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetFileFormatArguments")]
		public static extern IntPtr SdfLayerConstHandle_GetFileFormatArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetHints")]
		public static extern IntPtr SdfLayerConstHandle_GetHints(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_IsEmpty")]
		public static extern bool SdfLayerConstHandle_IsEmpty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_StreamsData")]
		public static extern bool SdfLayerConstHandle_StreamsData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_IsDetached")]
		public static extern bool SdfLayerConstHandle_IsDetached(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_IsAnonymous")]
		public static extern bool SdfLayerConstHandle_IsAnonymous(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_Save__SWIG_0")]
		public static extern bool SdfLayerConstHandle_Save__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_Save__SWIG_1")]
		public static extern bool SdfLayerConstHandle_Save__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_Export__SWIG_0")]
		public static extern bool SdfLayerConstHandle_Export__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_Export__SWIG_1")]
		public static extern bool SdfLayerConstHandle_Export__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_Export__SWIG_2")]
		public static extern bool SdfLayerConstHandle_Export__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetExternalReferences")]
		public static extern IntPtr SdfLayerConstHandle_GetExternalReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetCompositionAssetDependencies")]
		public static extern IntPtr SdfLayerConstHandle_GetCompositionAssetDependencies(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetExternalAssetDependencies")]
		public static extern IntPtr SdfLayerConstHandle_GetExternalAssetDependencies(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetIdentifier")]
		public static extern string SdfLayerConstHandle_GetIdentifier(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetDisplayName")]
		public static extern string SdfLayerConstHandle_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetResolvedPath")]
		public static extern IntPtr SdfLayerConstHandle_GetResolvedPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetRealPath")]
		public static extern string SdfLayerConstHandle_GetRealPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetFileExtension")]
		public static extern string SdfLayerConstHandle_GetFileExtension(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetVersion")]
		public static extern string SdfLayerConstHandle_GetVersion(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetRepositoryPath")]
		public static extern string SdfLayerConstHandle_GetRepositoryPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetAssetName")]
		public static extern string SdfLayerConstHandle_GetAssetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetAssetInfo")]
		public static extern IntPtr SdfLayerConstHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_ComputeAbsolutePath")]
		public static extern string SdfLayerConstHandle_ComputeAbsolutePath(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetSpecType")]
		public static extern int SdfLayerConstHandle_GetSpecType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasSpec")]
		public static extern bool SdfLayerConstHandle_HasSpec(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_ListFields")]
		public static extern IntPtr SdfLayerConstHandle_ListFields(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasField__SWIG_0")]
		public static extern bool SdfLayerConstHandle_HasField__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasField__SWIG_1")]
		public static extern bool SdfLayerConstHandle_HasField__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasField__SWIG_2")]
		public static extern bool SdfLayerConstHandle_HasField__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasFieldDictKey__SWIG_0")]
		public static extern bool SdfLayerConstHandle_HasFieldDictKey__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasFieldDictKey__SWIG_1")]
		public static extern bool SdfLayerConstHandle_HasFieldDictKey__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasFieldDictKey__SWIG_2")]
		public static extern bool SdfLayerConstHandle_HasFieldDictKey__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetField")]
		public static extern IntPtr SdfLayerConstHandle_GetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetFieldDictValueByKey")]
		public static extern IntPtr SdfLayerConstHandle_GetFieldDictValueByKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetColorConfiguration")]
		public static extern IntPtr SdfLayerConstHandle_GetColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasColorConfiguration")]
		public static extern bool SdfLayerConstHandle_HasColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetColorManagementSystem")]
		public static extern IntPtr SdfLayerConstHandle_GetColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasColorManagementSystem")]
		public static extern bool SdfLayerConstHandle_HasColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetComment")]
		public static extern string SdfLayerConstHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetDefaultPrim")]
		public static extern IntPtr SdfLayerConstHandle_GetDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetDocumentation")]
		public static extern string SdfLayerConstHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetStartTimeCode")]
		public static extern double SdfLayerConstHandle_GetStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasStartTimeCode")]
		public static extern bool SdfLayerConstHandle_HasStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetEndTimeCode")]
		public static extern double SdfLayerConstHandle_GetEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasEndTimeCode")]
		public static extern bool SdfLayerConstHandle_HasEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetTimeCodesPerSecond")]
		public static extern double SdfLayerConstHandle_GetTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasTimeCodesPerSecond")]
		public static extern bool SdfLayerConstHandle_HasTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetFramesPerSecond")]
		public static extern double SdfLayerConstHandle_GetFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasFramesPerSecond")]
		public static extern bool SdfLayerConstHandle_HasFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetFramePrecision")]
		public static extern int SdfLayerConstHandle_GetFramePrecision(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasFramePrecision")]
		public static extern bool SdfLayerConstHandle_HasFramePrecision(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetOwner")]
		public static extern string SdfLayerConstHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasOwner")]
		public static extern bool SdfLayerConstHandle_HasOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetSessionOwner")]
		public static extern string SdfLayerConstHandle_GetSessionOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasSessionOwner")]
		public static extern bool SdfLayerConstHandle_HasSessionOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetHasOwnedSubLayers")]
		public static extern bool SdfLayerConstHandle_GetHasOwnedSubLayers(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetCustomLayerData")]
		public static extern IntPtr SdfLayerConstHandle_GetCustomLayerData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_HasCustomLayerData")]
		public static extern bool SdfLayerConstHandle_HasCustomLayerData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetRootPrims")]
		public static extern IntPtr SdfLayerConstHandle_GetRootPrims(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_ApplyRootPrimOrder")]
		public static extern void SdfLayerConstHandle_ApplyRootPrimOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetSubLayerPaths")]
		public static extern IntPtr SdfLayerConstHandle_GetSubLayerPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetNumSubLayerPaths")]
		public static extern uint SdfLayerConstHandle_GetNumSubLayerPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetSubLayerOffsets")]
		public static extern IntPtr SdfLayerConstHandle_GetSubLayerOffsets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetSubLayerOffset")]
		public static extern IntPtr SdfLayerConstHandle_GetSubLayerOffset(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_IsMuted__SWIG_0")]
		public static extern bool SdfLayerConstHandle_IsMuted__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetPseudoRoot")]
		public static extern IntPtr SdfLayerConstHandle_GetPseudoRoot(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_PermissionToEdit")]
		public static extern bool SdfLayerConstHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_PermissionToSave")]
		public static extern bool SdfLayerConstHandle_PermissionToSave(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_CanApply__SWIG_0")]
		public static extern int SdfLayerConstHandle_CanApply__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_CanApply__SWIG_1")]
		public static extern int SdfLayerConstHandle_CanApply__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_IsDirty")]
		public static extern bool SdfLayerConstHandle_IsDirty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_ListAllTimeSamples")]
		public static extern IntPtr SdfLayerConstHandle_ListAllTimeSamples(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_ListTimeSamplesForPath")]
		public static extern IntPtr SdfLayerConstHandle_ListTimeSamplesForPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_GetNumTimeSamplesForPath")]
		public static extern uint SdfLayerConstHandle_GetNumTimeSamplesForPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_QueryTimeSample__SWIG_0")]
		public static extern bool SdfLayerConstHandle_QueryTimeSample__SWIG_0(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_QueryTimeSample__SWIG_1")]
		public static extern bool SdfLayerConstHandle_QueryTimeSample__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerConstHandle_QueryTimeSample__SWIG_2")]
		public static extern bool SdfLayerConstHandle_QueryTimeSample__SWIG_2(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_Clear")]
		public static extern void SdfLayerRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_Add")]
		public static extern void SdfLayerRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_size")]
		public static extern uint SdfLayerRefPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_capacity")]
		public static extern uint SdfLayerRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_reserve")]
		public static extern void SdfLayerRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerRefPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfLayerRefPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerRefPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfLayerRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerRefPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfLayerRefPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_getitemcopy")]
		public static extern IntPtr SdfLayerRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_getitem")]
		public static extern IntPtr SdfLayerRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_setitem")]
		public static extern void SdfLayerRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_AddRange")]
		public static extern void SdfLayerRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_GetRange")]
		public static extern IntPtr SdfLayerRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_Insert")]
		public static extern void SdfLayerRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_InsertRange")]
		public static extern void SdfLayerRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_RemoveAt")]
		public static extern void SdfLayerRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_RemoveRange")]
		public static extern void SdfLayerRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_Repeat")]
		public static extern IntPtr SdfLayerRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_Reverse__SWIG_0")]
		public static extern void SdfLayerRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_Reverse__SWIG_1")]
		public static extern void SdfLayerRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrVector_SetRange")]
		public static extern void SdfLayerRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerRefPtrVector")]
		public static extern void delete_SdfLayerRefPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerRefPtrSet__SWIG_0")]
		public static extern IntPtr new_SdfLayerRefPtrSet__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerRefPtrSet__SWIG_1")]
		public static extern IntPtr new_SdfLayerRefPtrSet__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_size")]
		public static extern uint SdfLayerRefPtrSet_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_empty")]
		public static extern bool SdfLayerRefPtrSet_empty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_Clear")]
		public static extern void SdfLayerRefPtrSet_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_Add")]
		public static extern bool SdfLayerRefPtrSet_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_Contains")]
		public static extern bool SdfLayerRefPtrSet_Contains(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_Remove")]
		public static extern bool SdfLayerRefPtrSet_Remove(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_getitem")]
		public static extern IntPtr SdfLayerRefPtrSet_getitem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_create_iterator_begin")]
		public static extern IntPtr SdfLayerRefPtrSet_create_iterator_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_get_next")]
		public static extern IntPtr SdfLayerRefPtrSet_get_next(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerRefPtrSet_destroy_iterator")]
		public static extern void SdfLayerRefPtrSet_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerRefPtrSet")]
		public static extern void delete_SdfLayerRefPtrSet(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_Clear")]
		public static extern void SdfFileFormatPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_Add")]
		public static extern void SdfFileFormatPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_size")]
		public static extern uint SdfFileFormatPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_capacity")]
		public static extern uint SdfFileFormatPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_reserve")]
		public static extern void SdfFileFormatPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfFileFormatPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfFileFormatPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfFileFormatPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_getitemcopy")]
		public static extern IntPtr SdfFileFormatPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_getitem")]
		public static extern IntPtr SdfFileFormatPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_setitem")]
		public static extern void SdfFileFormatPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_AddRange")]
		public static extern void SdfFileFormatPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_GetRange")]
		public static extern IntPtr SdfFileFormatPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_Insert")]
		public static extern void SdfFileFormatPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_InsertRange")]
		public static extern void SdfFileFormatPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_RemoveAt")]
		public static extern void SdfFileFormatPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_RemoveRange")]
		public static extern void SdfFileFormatPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_Repeat")]
		public static extern IntPtr SdfFileFormatPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_Reverse__SWIG_0")]
		public static extern void SdfFileFormatPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_Reverse__SWIG_1")]
		public static extern void SdfFileFormatPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatPtrVector_SetRange")]
		public static extern void SdfFileFormatPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfFileFormatPtrVector")]
		public static extern void delete_SdfFileFormatPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_Clear")]
		public static extern void SdfFileFormatConstPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_Add")]
		public static extern void SdfFileFormatConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_size")]
		public static extern uint SdfFileFormatConstPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_capacity")]
		public static extern uint SdfFileFormatConstPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_reserve")]
		public static extern void SdfFileFormatConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatConstPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfFileFormatConstPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatConstPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfFileFormatConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatConstPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfFileFormatConstPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_getitemcopy")]
		public static extern IntPtr SdfFileFormatConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_getitem")]
		public static extern IntPtr SdfFileFormatConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_setitem")]
		public static extern void SdfFileFormatConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_AddRange")]
		public static extern void SdfFileFormatConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_GetRange")]
		public static extern IntPtr SdfFileFormatConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_Insert")]
		public static extern void SdfFileFormatConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_InsertRange")]
		public static extern void SdfFileFormatConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_RemoveAt")]
		public static extern void SdfFileFormatConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_RemoveRange")]
		public static extern void SdfFileFormatConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_Repeat")]
		public static extern IntPtr SdfFileFormatConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_Reverse__SWIG_0")]
		public static extern void SdfFileFormatConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_Reverse__SWIG_1")]
		public static extern void SdfFileFormatConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstPtrVector_SetRange")]
		public static extern void SdfFileFormatConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfFileFormatConstPtrVector")]
		public static extern void delete_SdfFileFormatConstPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayer")]
		public static extern void delete_SdfLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetSchema")]
		public static extern IntPtr SdfLayer_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetFileFormat")]
		public static extern IntPtr SdfLayer_GetFileFormat(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetFileFormatArguments")]
		public static extern IntPtr SdfLayer_GetFileFormatArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateNew__SWIG_0")]
		public static extern IntPtr SdfLayer_CreateNew__SWIG_0(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateNew__SWIG_1")]
		public static extern IntPtr SdfLayer_CreateNew__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateNew__SWIG_2")]
		public static extern IntPtr SdfLayer_CreateNew__SWIG_2(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateNew__SWIG_3")]
		public static extern IntPtr SdfLayer_CreateNew__SWIG_3(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_New__SWIG_0")]
		public static extern IntPtr SdfLayer_New__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_New__SWIG_1")]
		public static extern IntPtr SdfLayer_New__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Find__SWIG_0")]
		public static extern IntPtr SdfLayer_Find__SWIG_0(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Find__SWIG_1")]
		public static extern IntPtr SdfLayer_Find__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_FindRelativeToLayer__SWIG_0")]
		public static extern IntPtr SdfLayer_FindRelativeToLayer__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_FindRelativeToLayer__SWIG_1")]
		public static extern IntPtr SdfLayer_FindRelativeToLayer__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_FindOrOpen__SWIG_0")]
		public static extern IntPtr SdfLayer_FindOrOpen__SWIG_0(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_FindOrOpen__SWIG_1")]
		public static extern IntPtr SdfLayer_FindOrOpen__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_FindOrOpenRelativeToLayer__SWIG_0")]
		public static extern IntPtr SdfLayer_FindOrOpenRelativeToLayer__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_FindOrOpenRelativeToLayer__SWIG_1")]
		public static extern IntPtr SdfLayer_FindOrOpenRelativeToLayer__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_OpenAsAnonymous__SWIG_0")]
		public static extern IntPtr SdfLayer_OpenAsAnonymous__SWIG_0(string jarg1, bool jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_OpenAsAnonymous__SWIG_1")]
		public static extern IntPtr SdfLayer_OpenAsAnonymous__SWIG_1(string jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_OpenAsAnonymous__SWIG_2")]
		public static extern IntPtr SdfLayer_OpenAsAnonymous__SWIG_2(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetHints")]
		public static extern IntPtr SdfLayer_GetHints(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetLoadedLayers")]
		public static extern IntPtr SdfLayer_GetLoadedLayers();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_IsEmpty")]
		public static extern bool SdfLayer_IsEmpty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_StreamsData")]
		public static extern bool SdfLayer_StreamsData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_IsDetached")]
		public static extern bool SdfLayer_IsDetached(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_TransferContent")]
		public static extern void SdfLayer_TransferContent(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateAnonymous__SWIG_0")]
		public static extern IntPtr SdfLayer_CreateAnonymous__SWIG_0(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateAnonymous__SWIG_1")]
		public static extern IntPtr SdfLayer_CreateAnonymous__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateAnonymous__SWIG_2")]
		public static extern IntPtr SdfLayer_CreateAnonymous__SWIG_2();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateAnonymous__SWIG_3")]
		public static extern IntPtr SdfLayer_CreateAnonymous__SWIG_3(string jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateAnonymous__SWIG_4")]
		public static extern IntPtr SdfLayer_CreateAnonymous__SWIG_4(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_IsAnonymous")]
		public static extern bool SdfLayer_IsAnonymous(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_IsAnonymousLayerIdentifier")]
		public static extern bool SdfLayer_IsAnonymousLayerIdentifier(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetDisplayNameFromIdentifier")]
		public static extern string SdfLayer_GetDisplayNameFromIdentifier(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Save__SWIG_0")]
		public static extern bool SdfLayer_Save__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Save__SWIG_1")]
		public static extern bool SdfLayer_Save__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Export__SWIG_0")]
		public static extern bool SdfLayer_Export__SWIG_0(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Export__SWIG_1")]
		public static extern bool SdfLayer_Export__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Export__SWIG_2")]
		public static extern bool SdfLayer_Export__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ImportFromString")]
		public static extern bool SdfLayer_ImportFromString(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Clear")]
		public static extern void SdfLayer_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Reload__SWIG_0")]
		public static extern bool SdfLayer_Reload__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Reload__SWIG_1")]
		public static extern bool SdfLayer_Reload__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ReloadLayers__SWIG_0")]
		public static extern bool SdfLayer_ReloadLayers__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ReloadLayers__SWIG_1")]
		public static extern bool SdfLayer_ReloadLayers__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Import")]
		public static extern bool SdfLayer_Import(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetExternalReferences")]
		public static extern IntPtr SdfLayer_GetExternalReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_UpdateExternalReference__SWIG_0")]
		public static extern bool SdfLayer_UpdateExternalReference__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_UpdateExternalReference__SWIG_1")]
		public static extern bool SdfLayer_UpdateExternalReference__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetCompositionAssetDependencies")]
		public static extern IntPtr SdfLayer_GetCompositionAssetDependencies(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_UpdateCompositionAssetDependency__SWIG_0")]
		public static extern bool SdfLayer_UpdateCompositionAssetDependency__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_UpdateCompositionAssetDependency__SWIG_1")]
		public static extern bool SdfLayer_UpdateCompositionAssetDependency__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetExternalAssetDependencies")]
		public static extern IntPtr SdfLayer_GetExternalAssetDependencies(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SplitIdentifier")]
		public static extern bool SdfLayer_SplitIdentifier(string jarg1, out string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CreateIdentifier")]
		public static extern string SdfLayer_CreateIdentifier(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetIdentifier")]
		public static extern string SdfLayer_GetIdentifier(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetIdentifier")]
		public static extern void SdfLayer_SetIdentifier(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_UpdateAssetInfo")]
		public static extern void SdfLayer_UpdateAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetDisplayName")]
		public static extern string SdfLayer_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetResolvedPath")]
		public static extern IntPtr SdfLayer_GetResolvedPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetRealPath")]
		public static extern string SdfLayer_GetRealPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetFileExtension")]
		public static extern string SdfLayer_GetFileExtension(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetVersion")]
		public static extern string SdfLayer_GetVersion(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetRepositoryPath")]
		public static extern string SdfLayer_GetRepositoryPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetAssetName")]
		public static extern string SdfLayer_GetAssetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetAssetInfo")]
		public static extern IntPtr SdfLayer_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ComputeAbsolutePath")]
		public static extern string SdfLayer_ComputeAbsolutePath(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetSpecType")]
		public static extern int SdfLayer_GetSpecType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasSpec")]
		public static extern bool SdfLayer_HasSpec(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ListFields")]
		public static extern IntPtr SdfLayer_ListFields(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasField__SWIG_0")]
		public static extern bool SdfLayer_HasField__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasField__SWIG_1")]
		public static extern bool SdfLayer_HasField__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasField__SWIG_2")]
		public static extern bool SdfLayer_HasField__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasFieldDictKey__SWIG_0")]
		public static extern bool SdfLayer_HasFieldDictKey__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasFieldDictKey__SWIG_1")]
		public static extern bool SdfLayer_HasFieldDictKey__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasFieldDictKey__SWIG_2")]
		public static extern bool SdfLayer_HasFieldDictKey__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetField")]
		public static extern IntPtr SdfLayer_GetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetFieldDictValueByKey")]
		public static extern IntPtr SdfLayer_GetFieldDictValueByKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetField__SWIG_0")]
		public static extern void SdfLayer_SetField__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetField__SWIG_1")]
		public static extern void SdfLayer_SetField__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetFieldDictValueByKey__SWIG_0")]
		public static extern void SdfLayer_SetFieldDictValueByKey__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetFieldDictValueByKey__SWIG_1")]
		public static extern void SdfLayer_SetFieldDictValueByKey__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_EraseField")]
		public static extern void SdfLayer_EraseField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_EraseFieldDictValueByKey")]
		public static extern void SdfLayer_EraseFieldDictValueByKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetColorConfiguration")]
		public static extern IntPtr SdfLayer_GetColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetColorConfiguration")]
		public static extern void SdfLayer_SetColorConfiguration(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasColorConfiguration")]
		public static extern bool SdfLayer_HasColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearColorConfiguration")]
		public static extern void SdfLayer_ClearColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetColorManagementSystem")]
		public static extern IntPtr SdfLayer_GetColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetColorManagementSystem")]
		public static extern void SdfLayer_SetColorManagementSystem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasColorManagementSystem")]
		public static extern bool SdfLayer_HasColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearColorManagementSystem")]
		public static extern void SdfLayer_ClearColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetComment")]
		public static extern string SdfLayer_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetComment")]
		public static extern void SdfLayer_SetComment(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetDefaultPrim")]
		public static extern IntPtr SdfLayer_GetDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetDefaultPrim")]
		public static extern void SdfLayer_SetDefaultPrim(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearDefaultPrim")]
		public static extern void SdfLayer_ClearDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasDefaultPrim")]
		public static extern bool SdfLayer_HasDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetDocumentation")]
		public static extern string SdfLayer_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetDocumentation")]
		public static extern void SdfLayer_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetStartTimeCode")]
		public static extern double SdfLayer_GetStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetStartTimeCode")]
		public static extern void SdfLayer_SetStartTimeCode(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasStartTimeCode")]
		public static extern bool SdfLayer_HasStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearStartTimeCode")]
		public static extern void SdfLayer_ClearStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetEndTimeCode")]
		public static extern double SdfLayer_GetEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetEndTimeCode")]
		public static extern void SdfLayer_SetEndTimeCode(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasEndTimeCode")]
		public static extern bool SdfLayer_HasEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearEndTimeCode")]
		public static extern void SdfLayer_ClearEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetTimeCodesPerSecond")]
		public static extern double SdfLayer_GetTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetTimeCodesPerSecond")]
		public static extern void SdfLayer_SetTimeCodesPerSecond(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasTimeCodesPerSecond")]
		public static extern bool SdfLayer_HasTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearTimeCodesPerSecond")]
		public static extern void SdfLayer_ClearTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetFramesPerSecond")]
		public static extern double SdfLayer_GetFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetFramesPerSecond")]
		public static extern void SdfLayer_SetFramesPerSecond(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasFramesPerSecond")]
		public static extern bool SdfLayer_HasFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearFramesPerSecond")]
		public static extern void SdfLayer_ClearFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetFramePrecision")]
		public static extern int SdfLayer_GetFramePrecision(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetFramePrecision")]
		public static extern void SdfLayer_SetFramePrecision(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasFramePrecision")]
		public static extern bool SdfLayer_HasFramePrecision(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearFramePrecision")]
		public static extern void SdfLayer_ClearFramePrecision(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetOwner")]
		public static extern string SdfLayer_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetOwner")]
		public static extern void SdfLayer_SetOwner(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasOwner")]
		public static extern bool SdfLayer_HasOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearOwner")]
		public static extern void SdfLayer_ClearOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetSessionOwner")]
		public static extern string SdfLayer_GetSessionOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetSessionOwner")]
		public static extern void SdfLayer_SetSessionOwner(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasSessionOwner")]
		public static extern bool SdfLayer_HasSessionOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearSessionOwner")]
		public static extern void SdfLayer_ClearSessionOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetHasOwnedSubLayers")]
		public static extern bool SdfLayer_GetHasOwnedSubLayers(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetHasOwnedSubLayers")]
		public static extern void SdfLayer_SetHasOwnedSubLayers(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetCustomLayerData")]
		public static extern IntPtr SdfLayer_GetCustomLayerData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetCustomLayerData")]
		public static extern void SdfLayer_SetCustomLayerData(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_HasCustomLayerData")]
		public static extern bool SdfLayer_HasCustomLayerData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ClearCustomLayerData")]
		public static extern void SdfLayer_ClearCustomLayerData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetRootPrims")]
		public static extern IntPtr SdfLayer_GetRootPrims(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetRootPrims")]
		public static extern void SdfLayer_SetRootPrims(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_InsertRootPrim__SWIG_0")]
		public static extern bool SdfLayer_InsertRootPrim__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_InsertRootPrim__SWIG_1")]
		public static extern bool SdfLayer_InsertRootPrim__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_RemoveRootPrim")]
		public static extern void SdfLayer_RemoveRootPrim(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ScheduleRemoveIfInert")]
		public static extern void SdfLayer_ScheduleRemoveIfInert(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_RemovePrimIfInert")]
		public static extern void SdfLayer_RemovePrimIfInert(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_RemovePropertyIfHasOnlyRequiredFields")]
		public static extern void SdfLayer_RemovePropertyIfHasOnlyRequiredFields(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_RemoveInertSceneDescription")]
		public static extern void SdfLayer_RemoveInertSceneDescription(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetRootPrimOrder")]
		public static extern void SdfLayer_SetRootPrimOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_InsertInRootPrimOrder__SWIG_0")]
		public static extern void SdfLayer_InsertInRootPrimOrder__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_InsertInRootPrimOrder__SWIG_1")]
		public static extern void SdfLayer_InsertInRootPrimOrder__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_RemoveFromRootPrimOrder")]
		public static extern void SdfLayer_RemoveFromRootPrimOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_RemoveFromRootPrimOrderByIndex")]
		public static extern void SdfLayer_RemoveFromRootPrimOrderByIndex(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ApplyRootPrimOrder")]
		public static extern void SdfLayer_ApplyRootPrimOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetSubLayerPaths")]
		public static extern IntPtr SdfLayer_GetSubLayerPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetSubLayerPaths")]
		public static extern void SdfLayer_SetSubLayerPaths(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetNumSubLayerPaths")]
		public static extern uint SdfLayer_GetNumSubLayerPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_InsertSubLayerPath__SWIG_0")]
		public static extern void SdfLayer_InsertSubLayerPath__SWIG_0(HandleRef jarg1, string jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_InsertSubLayerPath__SWIG_1")]
		public static extern void SdfLayer_InsertSubLayerPath__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_RemoveSubLayerPath")]
		public static extern void SdfLayer_RemoveSubLayerPath(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetSubLayerOffsets")]
		public static extern IntPtr SdfLayer_GetSubLayerOffsets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetSubLayerOffset")]
		public static extern IntPtr SdfLayer_GetSubLayerOffset(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetSubLayerOffset")]
		public static extern void SdfLayer_SetSubLayerOffset(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayer_DetachedLayerRules")]
		public static extern IntPtr new_SdfLayer_DetachedLayerRules();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_DetachedLayerRules_IncludeAll")]
		public static extern IntPtr SdfLayer_DetachedLayerRules_IncludeAll(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_DetachedLayerRules_Include")]
		public static extern IntPtr SdfLayer_DetachedLayerRules_Include(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_DetachedLayerRules_Exclude")]
		public static extern IntPtr SdfLayer_DetachedLayerRules_Exclude(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_DetachedLayerRules_IncludedAll")]
		public static extern bool SdfLayer_DetachedLayerRules_IncludedAll(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_DetachedLayerRules_GetIncluded")]
		public static extern IntPtr SdfLayer_DetachedLayerRules_GetIncluded(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_DetachedLayerRules_GetExcluded")]
		public static extern IntPtr SdfLayer_DetachedLayerRules_GetExcluded(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_DetachedLayerRules_IsIncluded")]
		public static extern bool SdfLayer_DetachedLayerRules_IsIncluded(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayer_DetachedLayerRules")]
		public static extern void delete_SdfLayer_DetachedLayerRules(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetDetachedLayerRules")]
		public static extern void SdfLayer_SetDetachedLayerRules(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetDetachedLayerRules")]
		public static extern IntPtr SdfLayer_GetDetachedLayerRules();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_IsIncludedByDetachedLayerRules")]
		public static extern bool SdfLayer_IsIncludedByDetachedLayerRules(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetMutedLayers")]
		public static extern IntPtr SdfLayer_GetMutedLayers();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_IsMuted__SWIG_0")]
		public static extern bool SdfLayer_IsMuted__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_IsMuted__SWIG_1")]
		public static extern bool SdfLayer_IsMuted__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetMuted")]
		public static extern void SdfLayer_SetMuted(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_AddToMutedLayers")]
		public static extern void SdfLayer_AddToMutedLayers(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_RemoveFromMutedLayers")]
		public static extern void SdfLayer_RemoveFromMutedLayers(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetPseudoRoot")]
		public static extern IntPtr SdfLayer_GetPseudoRoot(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetObjectAtPath")]
		public static extern IntPtr SdfLayer_GetObjectAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetPrimAtPath")]
		public static extern IntPtr SdfLayer_GetPrimAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetPropertyAtPath")]
		public static extern IntPtr SdfLayer_GetPropertyAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetAttributeAtPath")]
		public static extern IntPtr SdfLayer_GetAttributeAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetRelationshipAtPath")]
		public static extern IntPtr SdfLayer_GetRelationshipAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_PermissionToEdit")]
		public static extern bool SdfLayer_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_PermissionToSave")]
		public static extern bool SdfLayer_PermissionToSave(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetPermissionToEdit")]
		public static extern void SdfLayer_SetPermissionToEdit(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetPermissionToSave")]
		public static extern void SdfLayer_SetPermissionToSave(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CanApply__SWIG_0")]
		public static extern int SdfLayer_CanApply__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_CanApply__SWIG_1")]
		public static extern int SdfLayer_CanApply__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_Apply")]
		public static extern bool SdfLayer_Apply(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_IsDirty")]
		public static extern bool SdfLayer_IsDirty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ListAllTimeSamples")]
		public static extern IntPtr SdfLayer_ListAllTimeSamples(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ListTimeSamplesForPath")]
		public static extern IntPtr SdfLayer_ListTimeSamplesForPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetBracketingTimeSamples")]
		public static extern bool SdfLayer_GetBracketingTimeSamples(HandleRef jarg1, double jarg2, out double jarg3, out double jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetNumTimeSamplesForPath")]
		public static extern uint SdfLayer_GetNumTimeSamplesForPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetBracketingTimeSamplesForPath")]
		public static extern bool SdfLayer_GetBracketingTimeSamplesForPath(HandleRef jarg1, HandleRef jarg2, double jarg3, out double jarg4, out double jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_QueryTimeSample__SWIG_0")]
		public static extern bool SdfLayer_QueryTimeSample__SWIG_0(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_QueryTimeSample__SWIG_1")]
		public static extern bool SdfLayer_QueryTimeSample__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_QueryTimeSample__SWIG_2")]
		public static extern bool SdfLayer_QueryTimeSample__SWIG_2(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetTimeSample__SWIG_0")]
		public static extern void SdfLayer_SetTimeSample__SWIG_0(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_SetTimeSample__SWIG_1")]
		public static extern void SdfLayer_SetTimeSample__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_EraseTimeSample")]
		public static extern void SdfLayer_EraseTimeSample(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_DumpLayerInfo")]
		public static extern void SdfLayer_DumpLayerInfo();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_WriteDataFile")]
		public static extern bool SdfLayer_WriteDataFile(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_ExportToString")]
		public static extern string SdfLayer_ExportToString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayer_GetHashCode")]
		public static extern int SdfLayer_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecHandle__SWIG_0")]
		public static extern IntPtr new_SdfSpecHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecHandle__SWIG_1")]
		public static extern IntPtr new_SdfSpecHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecHandle__SWIG_2")]
		public static extern IntPtr new_SdfSpecHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle___deref__")]
		public static extern IntPtr SdfSpecHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfSpecHandle")]
		public static extern void delete_SdfSpecHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetSchema")]
		public static extern IntPtr SdfSpecHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetSpecType")]
		public static extern int SdfSpecHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_IsDormant")]
		public static extern bool SdfSpecHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetLayer")]
		public static extern IntPtr SdfSpecHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetPath")]
		public static extern IntPtr SdfSpecHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_PermissionToEdit")]
		public static extern bool SdfSpecHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_ListInfoKeys")]
		public static extern IntPtr SdfSpecHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfSpecHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfSpecHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetInfo")]
		public static extern IntPtr SdfSpecHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_SetInfo")]
		public static extern void SdfSpecHandle_SetInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_SetInfoDictionaryValue")]
		public static extern void SdfSpecHandle_SetInfoDictionaryValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_HasInfo")]
		public static extern bool SdfSpecHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_ClearInfo")]
		public static extern void SdfSpecHandle_ClearInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetTypeForInfo")]
		public static extern IntPtr SdfSpecHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfSpecHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_IsInert__SWIG_0")]
		public static extern bool SdfSpecHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_IsInert__SWIG_1")]
		public static extern bool SdfSpecHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_ListFields")]
		public static extern IntPtr SdfSpecHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_HasField")]
		public static extern bool SdfSpecHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_GetField")]
		public static extern IntPtr SdfSpecHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_SetField")]
		public static extern bool SdfSpecHandle_SetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandle_ClearField")]
		public static extern bool SdfSpecHandle_ClearField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecConstHandle__SWIG_0")]
		public static extern IntPtr new_SdfSpecConstHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecConstHandle__SWIG_1")]
		public static extern IntPtr new_SdfSpecConstHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecConstHandle__SWIG_2")]
		public static extern IntPtr new_SdfSpecConstHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle___deref__")]
		public static extern IntPtr SdfSpecConstHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfSpecConstHandle")]
		public static extern void delete_SdfSpecConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetSchema")]
		public static extern IntPtr SdfSpecConstHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetSpecType")]
		public static extern int SdfSpecConstHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_IsDormant")]
		public static extern bool SdfSpecConstHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetLayer")]
		public static extern IntPtr SdfSpecConstHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetPath")]
		public static extern IntPtr SdfSpecConstHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_PermissionToEdit")]
		public static extern bool SdfSpecConstHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_ListInfoKeys")]
		public static extern IntPtr SdfSpecConstHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfSpecConstHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfSpecConstHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetInfo")]
		public static extern IntPtr SdfSpecConstHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_HasInfo")]
		public static extern bool SdfSpecConstHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetTypeForInfo")]
		public static extern IntPtr SdfSpecConstHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfSpecConstHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_IsInert__SWIG_0")]
		public static extern bool SdfSpecConstHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_IsInert__SWIG_1")]
		public static extern bool SdfSpecConstHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_ListFields")]
		public static extern IntPtr SdfSpecConstHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_HasField")]
		public static extern bool SdfSpecConstHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandle_GetField")]
		public static extern IntPtr SdfSpecConstHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_Clear")]
		public static extern void SdfSpecHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_Add")]
		public static extern void SdfSpecHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_size")]
		public static extern uint SdfSpecHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_capacity")]
		public static extern uint SdfSpecHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_reserve")]
		public static extern void SdfSpecHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfSpecHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfSpecHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfSpecHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_getitemcopy")]
		public static extern IntPtr SdfSpecHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_getitem")]
		public static extern IntPtr SdfSpecHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_setitem")]
		public static extern void SdfSpecHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_AddRange")]
		public static extern void SdfSpecHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_GetRange")]
		public static extern IntPtr SdfSpecHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_Insert")]
		public static extern void SdfSpecHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_InsertRange")]
		public static extern void SdfSpecHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_RemoveAt")]
		public static extern void SdfSpecHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_RemoveRange")]
		public static extern void SdfSpecHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_Repeat")]
		public static extern IntPtr SdfSpecHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_Reverse__SWIG_0")]
		public static extern void SdfSpecHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_Reverse__SWIG_1")]
		public static extern void SdfSpecHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecHandleVector_SetRange")]
		public static extern void SdfSpecHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfSpecHandleVector")]
		public static extern void delete_SdfSpecHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_Clear")]
		public static extern void SdfSpecConstHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_Add")]
		public static extern void SdfSpecConstHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_size")]
		public static extern uint SdfSpecConstHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_capacity")]
		public static extern uint SdfSpecConstHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_reserve")]
		public static extern void SdfSpecConstHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecConstHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfSpecConstHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecConstHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfSpecConstHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfSpecConstHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfSpecConstHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_getitemcopy")]
		public static extern IntPtr SdfSpecConstHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_getitem")]
		public static extern IntPtr SdfSpecConstHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_setitem")]
		public static extern void SdfSpecConstHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_AddRange")]
		public static extern void SdfSpecConstHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_GetRange")]
		public static extern IntPtr SdfSpecConstHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_Insert")]
		public static extern void SdfSpecConstHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_InsertRange")]
		public static extern void SdfSpecConstHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_RemoveAt")]
		public static extern void SdfSpecConstHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_RemoveRange")]
		public static extern void SdfSpecConstHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_Repeat")]
		public static extern IntPtr SdfSpecConstHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_Reverse__SWIG_0")]
		public static extern void SdfSpecConstHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_Reverse__SWIG_1")]
		public static extern void SdfSpecConstHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSpecConstHandleVector_SetRange")]
		public static extern void SdfSpecConstHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfSpecConstHandleVector")]
		public static extern void delete_SdfSpecConstHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_Clear")]
		public static extern void SdfAbstractDataPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_Add")]
		public static extern void SdfAbstractDataPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_size")]
		public static extern uint SdfAbstractDataPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_capacity")]
		public static extern uint SdfAbstractDataPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_reserve")]
		public static extern void SdfAbstractDataPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfAbstractDataPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfAbstractDataPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfAbstractDataPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_getitemcopy")]
		public static extern IntPtr SdfAbstractDataPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_getitem")]
		public static extern IntPtr SdfAbstractDataPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_setitem")]
		public static extern void SdfAbstractDataPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_AddRange")]
		public static extern void SdfAbstractDataPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_GetRange")]
		public static extern IntPtr SdfAbstractDataPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_Insert")]
		public static extern void SdfAbstractDataPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_InsertRange")]
		public static extern void SdfAbstractDataPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_RemoveAt")]
		public static extern void SdfAbstractDataPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_RemoveRange")]
		public static extern void SdfAbstractDataPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_Repeat")]
		public static extern IntPtr SdfAbstractDataPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_Reverse__SWIG_0")]
		public static extern void SdfAbstractDataPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_Reverse__SWIG_1")]
		public static extern void SdfAbstractDataPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataPtrVector_SetRange")]
		public static extern void SdfAbstractDataPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAbstractDataPtrVector")]
		public static extern void delete_SdfAbstractDataPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_Clear")]
		public static extern void SdfAbstractDataConstPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_Add")]
		public static extern void SdfAbstractDataConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_size")]
		public static extern uint SdfAbstractDataConstPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_capacity")]
		public static extern uint SdfAbstractDataConstPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_reserve")]
		public static extern void SdfAbstractDataConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataConstPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfAbstractDataConstPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataConstPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfAbstractDataConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataConstPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfAbstractDataConstPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_getitemcopy")]
		public static extern IntPtr SdfAbstractDataConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_getitem")]
		public static extern IntPtr SdfAbstractDataConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_setitem")]
		public static extern void SdfAbstractDataConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_AddRange")]
		public static extern void SdfAbstractDataConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_GetRange")]
		public static extern IntPtr SdfAbstractDataConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_Insert")]
		public static extern void SdfAbstractDataConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_InsertRange")]
		public static extern void SdfAbstractDataConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_RemoveAt")]
		public static extern void SdfAbstractDataConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_RemoveRange")]
		public static extern void SdfAbstractDataConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_Repeat")]
		public static extern IntPtr SdfAbstractDataConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_Reverse__SWIG_0")]
		public static extern void SdfAbstractDataConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_Reverse__SWIG_1")]
		public static extern void SdfAbstractDataConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstPtrVector_SetRange")]
		public static extern void SdfAbstractDataConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAbstractDataConstPtrVector")]
		public static extern void delete_SdfAbstractDataConstPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_Clear")]
		public static extern void SdfAbstractDataRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_Add")]
		public static extern void SdfAbstractDataRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_size")]
		public static extern uint SdfAbstractDataRefPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_capacity")]
		public static extern uint SdfAbstractDataRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_reserve")]
		public static extern void SdfAbstractDataRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataRefPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfAbstractDataRefPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataRefPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfAbstractDataRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataRefPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfAbstractDataRefPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_getitemcopy")]
		public static extern IntPtr SdfAbstractDataRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_getitem")]
		public static extern IntPtr SdfAbstractDataRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_setitem")]
		public static extern void SdfAbstractDataRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_AddRange")]
		public static extern void SdfAbstractDataRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_GetRange")]
		public static extern IntPtr SdfAbstractDataRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_Insert")]
		public static extern void SdfAbstractDataRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_InsertRange")]
		public static extern void SdfAbstractDataRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_RemoveAt")]
		public static extern void SdfAbstractDataRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_RemoveRange")]
		public static extern void SdfAbstractDataRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_Repeat")]
		public static extern IntPtr SdfAbstractDataRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_Reverse__SWIG_0")]
		public static extern void SdfAbstractDataRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_Reverse__SWIG_1")]
		public static extern void SdfAbstractDataRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataRefPtrVector_SetRange")]
		public static extern void SdfAbstractDataRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAbstractDataRefPtrVector")]
		public static extern void delete_SdfAbstractDataRefPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_Clear")]
		public static extern void SdfAbstractDataConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_Add")]
		public static extern void SdfAbstractDataConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_size")]
		public static extern uint SdfAbstractDataConstRefPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_capacity")]
		public static extern uint SdfAbstractDataConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_reserve")]
		public static extern void SdfAbstractDataConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfAbstractDataConstRefPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfAbstractDataConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAbstractDataConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfAbstractDataConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_getitemcopy")]
		public static extern IntPtr SdfAbstractDataConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_getitem")]
		public static extern IntPtr SdfAbstractDataConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_setitem")]
		public static extern void SdfAbstractDataConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_AddRange")]
		public static extern void SdfAbstractDataConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_GetRange")]
		public static extern IntPtr SdfAbstractDataConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_Insert")]
		public static extern void SdfAbstractDataConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_InsertRange")]
		public static extern void SdfAbstractDataConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_RemoveAt")]
		public static extern void SdfAbstractDataConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_RemoveRange")]
		public static extern void SdfAbstractDataConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_Repeat")]
		public static extern IntPtr SdfAbstractDataConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void SdfAbstractDataConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void SdfAbstractDataConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAbstractDataConstRefPtrVector_SetRange")]
		public static extern void SdfAbstractDataConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAbstractDataConstRefPtrVector")]
		public static extern void delete_SdfAbstractDataConstRefPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_Clear")]
		public static extern void SdfFileFormatRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_Add")]
		public static extern void SdfFileFormatRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_size")]
		public static extern uint SdfFileFormatRefPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_capacity")]
		public static extern uint SdfFileFormatRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_reserve")]
		public static extern void SdfFileFormatRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatRefPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfFileFormatRefPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatRefPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfFileFormatRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatRefPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfFileFormatRefPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_getitemcopy")]
		public static extern IntPtr SdfFileFormatRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_getitem")]
		public static extern IntPtr SdfFileFormatRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_setitem")]
		public static extern void SdfFileFormatRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_AddRange")]
		public static extern void SdfFileFormatRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_GetRange")]
		public static extern IntPtr SdfFileFormatRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_Insert")]
		public static extern void SdfFileFormatRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_InsertRange")]
		public static extern void SdfFileFormatRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_RemoveAt")]
		public static extern void SdfFileFormatRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_RemoveRange")]
		public static extern void SdfFileFormatRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_Repeat")]
		public static extern IntPtr SdfFileFormatRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_Reverse__SWIG_0")]
		public static extern void SdfFileFormatRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_Reverse__SWIG_1")]
		public static extern void SdfFileFormatRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatRefPtrVector_SetRange")]
		public static extern void SdfFileFormatRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfFileFormatRefPtrVector")]
		public static extern void delete_SdfFileFormatRefPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_Clear")]
		public static extern void SdfFileFormatConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_Add")]
		public static extern void SdfFileFormatConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_size")]
		public static extern uint SdfFileFormatConstRefPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_capacity")]
		public static extern uint SdfFileFormatConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_reserve")]
		public static extern void SdfFileFormatConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfFileFormatConstRefPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfFileFormatConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfFileFormatConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfFileFormatConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_getitemcopy")]
		public static extern IntPtr SdfFileFormatConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_getitem")]
		public static extern IntPtr SdfFileFormatConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_setitem")]
		public static extern void SdfFileFormatConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_AddRange")]
		public static extern void SdfFileFormatConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_GetRange")]
		public static extern IntPtr SdfFileFormatConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_Insert")]
		public static extern void SdfFileFormatConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_InsertRange")]
		public static extern void SdfFileFormatConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_RemoveAt")]
		public static extern void SdfFileFormatConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_RemoveRange")]
		public static extern void SdfFileFormatConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_Repeat")]
		public static extern IntPtr SdfFileFormatConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void SdfFileFormatConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void SdfFileFormatConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormatConstRefPtrVector_SetRange")]
		public static extern void SdfFileFormatConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfFileFormatConstRefPtrVector")]
		public static extern void delete_SdfFileFormatConstRefPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetSchema")]
		public static extern IntPtr SdfFileFormat_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetFormatId")]
		public static extern IntPtr SdfFileFormat_GetFormatId(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetTarget")]
		public static extern IntPtr SdfFileFormat_GetTarget(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetFileCookie")]
		public static extern string SdfFileFormat_GetFileCookie(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetVersionString")]
		public static extern IntPtr SdfFileFormat_GetVersionString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_IsPrimaryFormatForExtensions")]
		public static extern bool SdfFileFormat_IsPrimaryFormatForExtensions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetFileExtensions")]
		public static extern IntPtr SdfFileFormat_GetFileExtensions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetPrimaryFileExtension")]
		public static extern string SdfFileFormat_GetPrimaryFileExtension(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_IsSupportedExtension")]
		public static extern bool SdfFileFormat_IsSupportedExtension(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_IsPackage")]
		public static extern bool SdfFileFormat_IsPackage(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetPackageRootLayerPath")]
		public static extern string SdfFileFormat_GetPackageRootLayerPath(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetDefaultFileFormatArguments")]
		public static extern IntPtr SdfFileFormat_GetDefaultFileFormatArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_InitData")]
		public static extern IntPtr SdfFileFormat_InitData(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_InitDetachedData")]
		public static extern IntPtr SdfFileFormat_InitDetachedData(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_NewLayer")]
		public static extern IntPtr SdfFileFormat_NewLayer(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_ShouldSkipAnonymousReload")]
		public static extern bool SdfFileFormat_ShouldSkipAnonymousReload(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_ShouldReadAnonymousLayers")]
		public static extern bool SdfFileFormat_ShouldReadAnonymousLayers(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_CanRead")]
		public static extern bool SdfFileFormat_CanRead(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_Read")]
		public static extern bool SdfFileFormat_Read(HandleRef jarg1, HandleRef jarg2, string jarg3, bool jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_ReadDetached")]
		public static extern bool SdfFileFormat_ReadDetached(HandleRef jarg1, HandleRef jarg2, string jarg3, bool jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_WriteToFile__SWIG_0")]
		public static extern bool SdfFileFormat_WriteToFile__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_WriteToFile__SWIG_1")]
		public static extern bool SdfFileFormat_WriteToFile__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_WriteToFile__SWIG_2")]
		public static extern bool SdfFileFormat_WriteToFile__SWIG_2(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_ReadFromString")]
		public static extern bool SdfFileFormat_ReadFromString(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_WriteToString__SWIG_0")]
		public static extern bool SdfFileFormat_WriteToString__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_WriteToString__SWIG_1")]
		public static extern bool SdfFileFormat_WriteToString__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetExternalAssetDependencies")]
		public static extern IntPtr SdfFileFormat_GetExternalAssetDependencies(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_GetFileExtension")]
		public static extern string SdfFileFormat_GetFileExtension(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_FindAllFileFormatExtensions")]
		public static extern IntPtr SdfFileFormat_FindAllFileFormatExtensions();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_FindById")]
		public static extern IntPtr SdfFileFormat_FindById(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_FindByExtension__SWIG_0")]
		public static extern IntPtr SdfFileFormat_FindByExtension__SWIG_0(string jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_FindByExtension__SWIG_1")]
		public static extern IntPtr SdfFileFormat_FindByExtension__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFileFormat_FindByExtension__SWIG_2")]
		public static extern IntPtr SdfFileFormat_FindByExtension__SWIG_2(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfFileFormat")]
		public static extern void delete_SdfFileFormat(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_Sdf_FileFormatFactoryBase")]
		public static extern void delete_Sdf_FileFormatFactoryBase(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Sdf_FileFormatFactoryBase_New")]
		public static extern IntPtr Sdf_FileFormatFactoryBase_New(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerHints__SWIG_0")]
		public static extern IntPtr new_SdfLayerHints__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerHints__SWIG_1")]
		public static extern IntPtr new_SdfLayerHints__SWIG_1(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHints_mightHaveRelocates_set")]
		public static extern void SdfLayerHints_mightHaveRelocates_set(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerHints_mightHaveRelocates_get")]
		public static extern bool SdfLayerHints_mightHaveRelocates_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerHints")]
		public static extern void delete_SdfLayerHints(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_Clear")]
		public static extern void SdfLayerOffsetVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_Add")]
		public static extern void SdfLayerOffsetVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_size")]
		public static extern uint SdfLayerOffsetVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_capacity")]
		public static extern uint SdfLayerOffsetVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_reserve")]
		public static extern void SdfLayerOffsetVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerOffsetVector__SWIG_0")]
		public static extern IntPtr new_SdfLayerOffsetVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerOffsetVector__SWIG_1")]
		public static extern IntPtr new_SdfLayerOffsetVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerOffsetVector__SWIG_2")]
		public static extern IntPtr new_SdfLayerOffsetVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_getitemcopy")]
		public static extern IntPtr SdfLayerOffsetVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_getitem")]
		public static extern IntPtr SdfLayerOffsetVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_setitem")]
		public static extern void SdfLayerOffsetVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_AddRange")]
		public static extern void SdfLayerOffsetVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_GetRange")]
		public static extern IntPtr SdfLayerOffsetVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_Insert")]
		public static extern void SdfLayerOffsetVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_InsertRange")]
		public static extern void SdfLayerOffsetVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_RemoveAt")]
		public static extern void SdfLayerOffsetVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_RemoveRange")]
		public static extern void SdfLayerOffsetVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_Repeat")]
		public static extern IntPtr SdfLayerOffsetVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_Reverse__SWIG_0")]
		public static extern void SdfLayerOffsetVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_Reverse__SWIG_1")]
		public static extern void SdfLayerOffsetVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffsetVector_SetRange")]
		public static extern void SdfLayerOffsetVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerOffsetVector")]
		public static extern void delete_SdfLayerOffsetVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerOffset__SWIG_0")]
		public static extern IntPtr new_SdfLayerOffset__SWIG_0(double jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerOffset__SWIG_1")]
		public static extern IntPtr new_SdfLayerOffset__SWIG_1(double jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerOffset__SWIG_2")]
		public static extern IntPtr new_SdfLayerOffset__SWIG_2();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffset_GetOffset")]
		public static extern double SdfLayerOffset_GetOffset(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffset_GetScale")]
		public static extern double SdfLayerOffset_GetScale(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffset_SetOffset")]
		public static extern void SdfLayerOffset_SetOffset(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffset_SetScale")]
		public static extern void SdfLayerOffset_SetScale(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffset_IsIdentity")]
		public static extern bool SdfLayerOffset_IsIdentity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffset_IsValid")]
		public static extern bool SdfLayerOffset_IsValid(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffset_GetInverse")]
		public static extern IntPtr SdfLayerOffset_GetInverse(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerOffset_GetHash")]
		public static extern uint SdfLayerOffset_GetHash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerOffset_Hash")]
		public static extern IntPtr new_SdfLayerOffset_Hash();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerOffset_Hash")]
		public static extern void delete_SdfLayerOffset_Hash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerOffset")]
		public static extern void delete_SdfLayerOffset(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_Clear")]
		public static extern void SdfLayerTreeHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_Add")]
		public static extern void SdfLayerTreeHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_size")]
		public static extern uint SdfLayerTreeHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_capacity")]
		public static extern uint SdfLayerTreeHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_reserve")]
		public static extern void SdfLayerTreeHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerTreeHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfLayerTreeHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerTreeHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfLayerTreeHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfLayerTreeHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfLayerTreeHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_getitemcopy")]
		public static extern IntPtr SdfLayerTreeHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_getitem")]
		public static extern IntPtr SdfLayerTreeHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_setitem")]
		public static extern void SdfLayerTreeHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_AddRange")]
		public static extern void SdfLayerTreeHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_GetRange")]
		public static extern IntPtr SdfLayerTreeHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_Insert")]
		public static extern void SdfLayerTreeHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_InsertRange")]
		public static extern void SdfLayerTreeHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_RemoveAt")]
		public static extern void SdfLayerTreeHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_RemoveRange")]
		public static extern void SdfLayerTreeHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_Repeat")]
		public static extern IntPtr SdfLayerTreeHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_Reverse__SWIG_0")]
		public static extern void SdfLayerTreeHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_Reverse__SWIG_1")]
		public static extern void SdfLayerTreeHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTreeHandleVector_SetRange")]
		public static extern void SdfLayerTreeHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerTreeHandleVector")]
		public static extern void delete_SdfLayerTreeHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTree_New__SWIG_0")]
		public static extern IntPtr SdfLayerTree_New__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTree_New__SWIG_1")]
		public static extern IntPtr SdfLayerTree_New__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTree_GetLayer")]
		public static extern IntPtr SdfLayerTree_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTree_GetOffset")]
		public static extern IntPtr SdfLayerTree_GetOffset(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfLayerTree_GetChildTrees")]
		public static extern IntPtr SdfLayerTree_GetChildTrees(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfLayerTree")]
		public static extern void delete_SdfLayerTree(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_Clear")]
		public static extern void StdReferenceVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_Add")]
		public static extern void StdReferenceVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_size")]
		public static extern uint StdReferenceVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_capacity")]
		public static extern uint StdReferenceVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_reserve")]
		public static extern void StdReferenceVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_StdReferenceVector__SWIG_0")]
		public static extern IntPtr new_StdReferenceVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_StdReferenceVector__SWIG_1")]
		public static extern IntPtr new_StdReferenceVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_StdReferenceVector__SWIG_2")]
		public static extern IntPtr new_StdReferenceVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_getitemcopy")]
		public static extern IntPtr StdReferenceVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_getitem")]
		public static extern IntPtr StdReferenceVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_setitem")]
		public static extern void StdReferenceVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_AddRange")]
		public static extern void StdReferenceVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_GetRange")]
		public static extern IntPtr StdReferenceVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_Insert")]
		public static extern void StdReferenceVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_InsertRange")]
		public static extern void StdReferenceVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_RemoveAt")]
		public static extern void StdReferenceVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_RemoveRange")]
		public static extern void StdReferenceVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_Repeat")]
		public static extern IntPtr StdReferenceVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_Reverse__SWIG_0")]
		public static extern void StdReferenceVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_Reverse__SWIG_1")]
		public static extern void StdReferenceVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdReferenceVector_SetRange")]
		public static extern void StdReferenceVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_StdReferenceVector")]
		public static extern void delete_StdReferenceVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReference__SWIG_0")]
		public static extern IntPtr new_SdfReference__SWIG_0(string jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReference__SWIG_1")]
		public static extern IntPtr new_SdfReference__SWIG_1(string jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReference__SWIG_2")]
		public static extern IntPtr new_SdfReference__SWIG_2(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReference__SWIG_3")]
		public static extern IntPtr new_SdfReference__SWIG_3(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReference__SWIG_4")]
		public static extern IntPtr new_SdfReference__SWIG_4();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_GetAssetPath")]
		public static extern string SdfReference_GetAssetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_SetAssetPath")]
		public static extern void SdfReference_SetAssetPath(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_GetPrimPath")]
		public static extern IntPtr SdfReference_GetPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_SetPrimPath")]
		public static extern void SdfReference_SetPrimPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_GetLayerOffset")]
		public static extern IntPtr SdfReference_GetLayerOffset(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_SetLayerOffset")]
		public static extern void SdfReference_SetLayerOffset(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_GetCustomData")]
		public static extern IntPtr SdfReference_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_SetCustomData__SWIG_0")]
		public static extern void SdfReference_SetCustomData__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_SetCustomData__SWIG_1")]
		public static extern void SdfReference_SetCustomData__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_SwapCustomData")]
		public static extern void SdfReference_SwapCustomData(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReference_IsInternal")]
		public static extern bool SdfReference_IsInternal(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReference_IdentityEqual")]
		public static extern IntPtr new_SdfReference_IdentityEqual();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfReference_IdentityEqual")]
		public static extern void delete_SdfReference_IdentityEqual(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReference_IdentityLessThan")]
		public static extern IntPtr new_SdfReference_IdentityLessThan();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfReference_IdentityLessThan")]
		public static extern void delete_SdfReference_IdentityLessThan(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfReference")]
		public static extern void delete_SdfReference(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfFindReferenceByIdentity")]
		public static extern int SdfFindReferenceByIdentity(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelocatesMap__SWIG_0")]
		public static extern IntPtr new_SdfRelocatesMap__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelocatesMap__SWIG_1")]
		public static extern IntPtr new_SdfRelocatesMap__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_size")]
		public static extern uint SdfRelocatesMap_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_empty")]
		public static extern bool SdfRelocatesMap_empty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_Clear")]
		public static extern void SdfRelocatesMap_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_getitem")]
		public static extern IntPtr SdfRelocatesMap_getitem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_setitem")]
		public static extern void SdfRelocatesMap_setitem(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_ContainsKey")]
		public static extern bool SdfRelocatesMap_ContainsKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_Add")]
		public static extern void SdfRelocatesMap_Add(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_Remove")]
		public static extern bool SdfRelocatesMap_Remove(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_create_iterator_begin")]
		public static extern IntPtr SdfRelocatesMap_create_iterator_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_get_next_key")]
		public static extern IntPtr SdfRelocatesMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelocatesMap_destroy_iterator")]
		public static extern void SdfRelocatesMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfRelocatesMap")]
		public static extern void delete_SdfRelocatesMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_Clear")]
		public static extern void StdUnregisteredValueVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_Add")]
		public static extern void StdUnregisteredValueVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_size")]
		public static extern uint StdUnregisteredValueVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_capacity")]
		public static extern uint StdUnregisteredValueVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_reserve")]
		public static extern void StdUnregisteredValueVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_StdUnregisteredValueVector__SWIG_0")]
		public static extern IntPtr new_StdUnregisteredValueVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_StdUnregisteredValueVector__SWIG_1")]
		public static extern IntPtr new_StdUnregisteredValueVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_StdUnregisteredValueVector__SWIG_2")]
		public static extern IntPtr new_StdUnregisteredValueVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_getitemcopy")]
		public static extern IntPtr StdUnregisteredValueVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_getitem")]
		public static extern IntPtr StdUnregisteredValueVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_setitem")]
		public static extern void StdUnregisteredValueVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_AddRange")]
		public static extern void StdUnregisteredValueVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_GetRange")]
		public static extern IntPtr StdUnregisteredValueVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_Insert")]
		public static extern void StdUnregisteredValueVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_InsertRange")]
		public static extern void StdUnregisteredValueVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_RemoveAt")]
		public static extern void StdUnregisteredValueVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_RemoveRange")]
		public static extern void StdUnregisteredValueVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_Repeat")]
		public static extern IntPtr StdUnregisteredValueVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_Reverse__SWIG_0")]
		public static extern void StdUnregisteredValueVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_Reverse__SWIG_1")]
		public static extern void StdUnregisteredValueVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_StdUnregisteredValueVector_SetRange")]
		public static extern void StdUnregisteredValueVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_StdUnregisteredValueVector")]
		public static extern void delete_StdUnregisteredValueVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIsDefiningSpecifier")]
		public static extern bool SdfIsDefiningSpecifier(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfDefaultUnit__SWIG_0")]
		public static extern IntPtr SdfDefaultUnit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfDefaultUnit__SWIG_1")]
		public static extern IntPtr SdfDefaultUnit__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnitCategory")]
		public static extern string SdfUnitCategory(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfConvertUnit")]
		public static extern double SdfConvertUnit(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetNameForUnit")]
		public static extern string SdfGetNameForUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetUnitFromName")]
		public static extern IntPtr SdfGetUnitFromName(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueHasValidType")]
		public static extern bool SdfValueHasValidType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetTypeForValueTypeName")]
		public static extern IntPtr SdfGetTypeForValueTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeNameForValue")]
		public static extern IntPtr SdfGetValueTypeNameForValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetRoleNameForValueTypeName")]
		public static extern IntPtr SdfGetRoleNameForValueTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfConvertToValidMetadataDictionary")]
		public static extern bool SdfConvertToValidMetadataDictionary(HandleRef jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecHandle__SWIG_0")]
		public static extern IntPtr new_SdfAttributeSpecHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecHandle__SWIG_1")]
		public static extern IntPtr new_SdfAttributeSpecHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecHandle__SWIG_2")]
		public static extern IntPtr new_SdfAttributeSpecHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle___deref__")]
		public static extern IntPtr SdfAttributeSpecHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAttributeSpecHandle")]
		public static extern void delete_SdfAttributeSpecHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_New__SWIG_0")]
		public static extern IntPtr SdfAttributeSpecHandle_New__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4, int jarg5, bool jarg6);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_New__SWIG_1")]
		public static extern IntPtr SdfAttributeSpecHandle_New__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4, int jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_New__SWIG_2")]
		public static extern IntPtr SdfAttributeSpecHandle_New__SWIG_2(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetConnectionPathList")]
		public static extern IntPtr SdfAttributeSpecHandle_GetConnectionPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_HasConnectionPaths")]
		public static extern bool SdfAttributeSpecHandle_HasConnectionPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ClearConnectionPaths")]
		public static extern void SdfAttributeSpecHandle_ClearConnectionPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetAllowedTokens")]
		public static extern IntPtr SdfAttributeSpecHandle_GetAllowedTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetAllowedTokens")]
		public static extern void SdfAttributeSpecHandle_SetAllowedTokens(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_HasAllowedTokens")]
		public static extern bool SdfAttributeSpecHandle_HasAllowedTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ClearAllowedTokens")]
		public static extern void SdfAttributeSpecHandle_ClearAllowedTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetDisplayUnit")]
		public static extern IntPtr SdfAttributeSpecHandle_GetDisplayUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetDisplayUnit")]
		public static extern void SdfAttributeSpecHandle_SetDisplayUnit(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_HasDisplayUnit")]
		public static extern bool SdfAttributeSpecHandle_HasDisplayUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ClearDisplayUnit")]
		public static extern void SdfAttributeSpecHandle_ClearDisplayUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetColorSpace")]
		public static extern IntPtr SdfAttributeSpecHandle_GetColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetColorSpace")]
		public static extern void SdfAttributeSpecHandle_SetColorSpace(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_HasColorSpace")]
		public static extern bool SdfAttributeSpecHandle_HasColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ClearColorSpace")]
		public static extern void SdfAttributeSpecHandle_ClearColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetRoleName")]
		public static extern IntPtr SdfAttributeSpecHandle_GetRoleName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetName")]
		public static extern string SdfAttributeSpecHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetNameToken")]
		public static extern IntPtr SdfAttributeSpecHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_CanSetName")]
		public static extern bool SdfAttributeSpecHandle_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetName__SWIG_0")]
		public static extern bool SdfAttributeSpecHandle_SetName__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetName__SWIG_1")]
		public static extern bool SdfAttributeSpecHandle_SetName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_IsValidName")]
		public static extern bool SdfAttributeSpecHandle_IsValidName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetOwner")]
		public static extern IntPtr SdfAttributeSpecHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetCustomData")]
		public static extern IntPtr SdfAttributeSpecHandle_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetAssetInfo")]
		public static extern IntPtr SdfAttributeSpecHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetCustomData")]
		public static extern void SdfAttributeSpecHandle_SetCustomData(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetAssetInfo")]
		public static extern void SdfAttributeSpecHandle_SetAssetInfo(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetDisplayGroup")]
		public static extern string SdfAttributeSpecHandle_GetDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetDisplayGroup")]
		public static extern void SdfAttributeSpecHandle_SetDisplayGroup(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetDisplayName")]
		public static extern string SdfAttributeSpecHandle_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetDisplayName")]
		public static extern void SdfAttributeSpecHandle_SetDisplayName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetDocumentation")]
		public static extern string SdfAttributeSpecHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetDocumentation")]
		public static extern void SdfAttributeSpecHandle_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetHidden")]
		public static extern bool SdfAttributeSpecHandle_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetHidden")]
		public static extern void SdfAttributeSpecHandle_SetHidden(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetPermission")]
		public static extern int SdfAttributeSpecHandle_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetPermission")]
		public static extern void SdfAttributeSpecHandle_SetPermission(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetPrefix")]
		public static extern string SdfAttributeSpecHandle_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetPrefix")]
		public static extern void SdfAttributeSpecHandle_SetPrefix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetSuffix")]
		public static extern string SdfAttributeSpecHandle_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetSuffix")]
		public static extern void SdfAttributeSpecHandle_SetSuffix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetSymmetricPeer")]
		public static extern string SdfAttributeSpecHandle_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetSymmetricPeer")]
		public static extern void SdfAttributeSpecHandle_SetSymmetricPeer(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetSymmetryArguments")]
		public static extern IntPtr SdfAttributeSpecHandle_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetSymmetryArgument")]
		public static extern void SdfAttributeSpecHandle_SetSymmetryArgument(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetSymmetryFunction")]
		public static extern IntPtr SdfAttributeSpecHandle_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetSymmetryFunction")]
		public static extern void SdfAttributeSpecHandle_SetSymmetryFunction(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetTimeSampleMap")]
		public static extern IntPtr SdfAttributeSpecHandle_GetTimeSampleMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetValueType")]
		public static extern IntPtr SdfAttributeSpecHandle_GetValueType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetTypeName")]
		public static extern IntPtr SdfAttributeSpecHandle_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetDefaultValue")]
		public static extern IntPtr SdfAttributeSpecHandle_GetDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetDefaultValue")]
		public static extern bool SdfAttributeSpecHandle_SetDefaultValue(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_HasDefaultValue")]
		public static extern bool SdfAttributeSpecHandle_HasDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ClearDefaultValue")]
		public static extern void SdfAttributeSpecHandle_ClearDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetComment")]
		public static extern string SdfAttributeSpecHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetComment")]
		public static extern void SdfAttributeSpecHandle_SetComment(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_IsCustom")]
		public static extern bool SdfAttributeSpecHandle_IsCustom(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetCustom")]
		public static extern void SdfAttributeSpecHandle_SetCustom(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetVariability")]
		public static extern int SdfAttributeSpecHandle_GetVariability(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_HasOnlyRequiredFields")]
		public static extern bool SdfAttributeSpecHandle_HasOnlyRequiredFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetSchema")]
		public static extern IntPtr SdfAttributeSpecHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetSpecType")]
		public static extern int SdfAttributeSpecHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_IsDormant")]
		public static extern bool SdfAttributeSpecHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetLayer")]
		public static extern IntPtr SdfAttributeSpecHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetPath")]
		public static extern IntPtr SdfAttributeSpecHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_PermissionToEdit")]
		public static extern bool SdfAttributeSpecHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ListInfoKeys")]
		public static extern IntPtr SdfAttributeSpecHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfAttributeSpecHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfAttributeSpecHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetInfo")]
		public static extern IntPtr SdfAttributeSpecHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetInfo")]
		public static extern void SdfAttributeSpecHandle_SetInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetInfoDictionaryValue")]
		public static extern void SdfAttributeSpecHandle_SetInfoDictionaryValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_HasInfo")]
		public static extern bool SdfAttributeSpecHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ClearInfo")]
		public static extern void SdfAttributeSpecHandle_ClearInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetTypeForInfo")]
		public static extern IntPtr SdfAttributeSpecHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfAttributeSpecHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_IsInert__SWIG_0")]
		public static extern bool SdfAttributeSpecHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_IsInert__SWIG_1")]
		public static extern bool SdfAttributeSpecHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ListFields")]
		public static extern IntPtr SdfAttributeSpecHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_HasField")]
		public static extern bool SdfAttributeSpecHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_GetField")]
		public static extern IntPtr SdfAttributeSpecHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_SetField")]
		public static extern bool SdfAttributeSpecHandle_SetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandle_ClearField")]
		public static extern bool SdfAttributeSpecHandle_ClearField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecConstHandle__SWIG_0")]
		public static extern IntPtr new_SdfAttributeSpecConstHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecConstHandle__SWIG_1")]
		public static extern IntPtr new_SdfAttributeSpecConstHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecConstHandle__SWIG_2")]
		public static extern IntPtr new_SdfAttributeSpecConstHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle___deref__")]
		public static extern IntPtr SdfAttributeSpecConstHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAttributeSpecConstHandle")]
		public static extern void delete_SdfAttributeSpecConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetConnectionPathList")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetConnectionPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_HasConnectionPaths")]
		public static extern bool SdfAttributeSpecConstHandle_HasConnectionPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetAllowedTokens")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetAllowedTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_HasAllowedTokens")]
		public static extern bool SdfAttributeSpecConstHandle_HasAllowedTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetDisplayUnit")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetDisplayUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_HasDisplayUnit")]
		public static extern bool SdfAttributeSpecConstHandle_HasDisplayUnit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetColorSpace")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_HasColorSpace")]
		public static extern bool SdfAttributeSpecConstHandle_HasColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetRoleName")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetRoleName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetName")]
		public static extern string SdfAttributeSpecConstHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetNameToken")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_CanSetName")]
		public static extern bool SdfAttributeSpecConstHandle_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetOwner")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetCustomData")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetAssetInfo")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetDisplayGroup")]
		public static extern string SdfAttributeSpecConstHandle_GetDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetDisplayName")]
		public static extern string SdfAttributeSpecConstHandle_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetDocumentation")]
		public static extern string SdfAttributeSpecConstHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetHidden")]
		public static extern bool SdfAttributeSpecConstHandle_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetPermission")]
		public static extern int SdfAttributeSpecConstHandle_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetPrefix")]
		public static extern string SdfAttributeSpecConstHandle_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetSuffix")]
		public static extern string SdfAttributeSpecConstHandle_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetSymmetricPeer")]
		public static extern string SdfAttributeSpecConstHandle_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetSymmetryArguments")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetSymmetryFunction")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetTimeSampleMap")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetTimeSampleMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetValueType")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetValueType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetTypeName")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetDefaultValue")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_HasDefaultValue")]
		public static extern bool SdfAttributeSpecConstHandle_HasDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetComment")]
		public static extern string SdfAttributeSpecConstHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_IsCustom")]
		public static extern bool SdfAttributeSpecConstHandle_IsCustom(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetVariability")]
		public static extern int SdfAttributeSpecConstHandle_GetVariability(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_HasOnlyRequiredFields")]
		public static extern bool SdfAttributeSpecConstHandle_HasOnlyRequiredFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetSchema")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetSpecType")]
		public static extern int SdfAttributeSpecConstHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_IsDormant")]
		public static extern bool SdfAttributeSpecConstHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetLayer")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetPath")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_PermissionToEdit")]
		public static extern bool SdfAttributeSpecConstHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_ListInfoKeys")]
		public static extern IntPtr SdfAttributeSpecConstHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetInfo")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_HasInfo")]
		public static extern bool SdfAttributeSpecConstHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetTypeForInfo")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_IsInert__SWIG_0")]
		public static extern bool SdfAttributeSpecConstHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_IsInert__SWIG_1")]
		public static extern bool SdfAttributeSpecConstHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_ListFields")]
		public static extern IntPtr SdfAttributeSpecConstHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_HasField")]
		public static extern bool SdfAttributeSpecConstHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandle_GetField")]
		public static extern IntPtr SdfAttributeSpecConstHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_Clear")]
		public static extern void SdfAttributeSpecHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_Add")]
		public static extern void SdfAttributeSpecHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_size")]
		public static extern uint SdfAttributeSpecHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_capacity")]
		public static extern uint SdfAttributeSpecHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_reserve")]
		public static extern void SdfAttributeSpecHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfAttributeSpecHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfAttributeSpecHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfAttributeSpecHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_getitemcopy")]
		public static extern IntPtr SdfAttributeSpecHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_getitem")]
		public static extern IntPtr SdfAttributeSpecHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_setitem")]
		public static extern void SdfAttributeSpecHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_AddRange")]
		public static extern void SdfAttributeSpecHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_GetRange")]
		public static extern IntPtr SdfAttributeSpecHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_Insert")]
		public static extern void SdfAttributeSpecHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_InsertRange")]
		public static extern void SdfAttributeSpecHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_RemoveAt")]
		public static extern void SdfAttributeSpecHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_RemoveRange")]
		public static extern void SdfAttributeSpecHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_Repeat")]
		public static extern IntPtr SdfAttributeSpecHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_Reverse__SWIG_0")]
		public static extern void SdfAttributeSpecHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_Reverse__SWIG_1")]
		public static extern void SdfAttributeSpecHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecHandleVector_SetRange")]
		public static extern void SdfAttributeSpecHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAttributeSpecHandleVector")]
		public static extern void delete_SdfAttributeSpecHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_Clear")]
		public static extern void SdfAttributeSpecConstHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_Add")]
		public static extern void SdfAttributeSpecConstHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_size")]
		public static extern uint SdfAttributeSpecConstHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_capacity")]
		public static extern uint SdfAttributeSpecConstHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_reserve")]
		public static extern void SdfAttributeSpecConstHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecConstHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfAttributeSpecConstHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecConstHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfAttributeSpecConstHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfAttributeSpecConstHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfAttributeSpecConstHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_getitemcopy")]
		public static extern IntPtr SdfAttributeSpecConstHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_getitem")]
		public static extern IntPtr SdfAttributeSpecConstHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_setitem")]
		public static extern void SdfAttributeSpecConstHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_AddRange")]
		public static extern void SdfAttributeSpecConstHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_GetRange")]
		public static extern IntPtr SdfAttributeSpecConstHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_Insert")]
		public static extern void SdfAttributeSpecConstHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_InsertRange")]
		public static extern void SdfAttributeSpecConstHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_RemoveAt")]
		public static extern void SdfAttributeSpecConstHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_RemoveRange")]
		public static extern void SdfAttributeSpecConstHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_Repeat")]
		public static extern IntPtr SdfAttributeSpecConstHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_Reverse__SWIG_0")]
		public static extern void SdfAttributeSpecConstHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_Reverse__SWIG_1")]
		public static extern void SdfAttributeSpecConstHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpecConstHandleVector_SetRange")]
		public static extern void SdfAttributeSpecConstHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfAttributeSpecConstHandleVector")]
		public static extern void delete_SdfAttributeSpecConstHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecHandle__SWIG_0")]
		public static extern IntPtr new_SdfPropertySpecHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecHandle__SWIG_1")]
		public static extern IntPtr new_SdfPropertySpecHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecHandle__SWIG_2")]
		public static extern IntPtr new_SdfPropertySpecHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle___deref__")]
		public static extern IntPtr SdfPropertySpecHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPropertySpecHandle")]
		public static extern void delete_SdfPropertySpecHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetName")]
		public static extern string SdfPropertySpecHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetNameToken")]
		public static extern IntPtr SdfPropertySpecHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_CanSetName")]
		public static extern bool SdfPropertySpecHandle_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetName__SWIG_0")]
		public static extern bool SdfPropertySpecHandle_SetName__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetName__SWIG_1")]
		public static extern bool SdfPropertySpecHandle_SetName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_IsValidName")]
		public static extern bool SdfPropertySpecHandle_IsValidName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetOwner")]
		public static extern IntPtr SdfPropertySpecHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetCustomData")]
		public static extern IntPtr SdfPropertySpecHandle_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetAssetInfo")]
		public static extern IntPtr SdfPropertySpecHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetCustomData")]
		public static extern void SdfPropertySpecHandle_SetCustomData(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetAssetInfo")]
		public static extern void SdfPropertySpecHandle_SetAssetInfo(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetDisplayGroup")]
		public static extern string SdfPropertySpecHandle_GetDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetDisplayGroup")]
		public static extern void SdfPropertySpecHandle_SetDisplayGroup(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetDisplayName")]
		public static extern string SdfPropertySpecHandle_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetDisplayName")]
		public static extern void SdfPropertySpecHandle_SetDisplayName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetDocumentation")]
		public static extern string SdfPropertySpecHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetDocumentation")]
		public static extern void SdfPropertySpecHandle_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetHidden")]
		public static extern bool SdfPropertySpecHandle_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetHidden")]
		public static extern void SdfPropertySpecHandle_SetHidden(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetPermission")]
		public static extern int SdfPropertySpecHandle_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetPermission")]
		public static extern void SdfPropertySpecHandle_SetPermission(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetPrefix")]
		public static extern string SdfPropertySpecHandle_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetPrefix")]
		public static extern void SdfPropertySpecHandle_SetPrefix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetSuffix")]
		public static extern string SdfPropertySpecHandle_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetSuffix")]
		public static extern void SdfPropertySpecHandle_SetSuffix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetSymmetricPeer")]
		public static extern string SdfPropertySpecHandle_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetSymmetricPeer")]
		public static extern void SdfPropertySpecHandle_SetSymmetricPeer(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetSymmetryArguments")]
		public static extern IntPtr SdfPropertySpecHandle_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetSymmetryArgument")]
		public static extern void SdfPropertySpecHandle_SetSymmetryArgument(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetSymmetryFunction")]
		public static extern IntPtr SdfPropertySpecHandle_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetSymmetryFunction")]
		public static extern void SdfPropertySpecHandle_SetSymmetryFunction(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetTimeSampleMap")]
		public static extern IntPtr SdfPropertySpecHandle_GetTimeSampleMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetValueType")]
		public static extern IntPtr SdfPropertySpecHandle_GetValueType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetTypeName")]
		public static extern IntPtr SdfPropertySpecHandle_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetDefaultValue")]
		public static extern IntPtr SdfPropertySpecHandle_GetDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetDefaultValue")]
		public static extern bool SdfPropertySpecHandle_SetDefaultValue(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_HasDefaultValue")]
		public static extern bool SdfPropertySpecHandle_HasDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_ClearDefaultValue")]
		public static extern void SdfPropertySpecHandle_ClearDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetComment")]
		public static extern string SdfPropertySpecHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetComment")]
		public static extern void SdfPropertySpecHandle_SetComment(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_IsCustom")]
		public static extern bool SdfPropertySpecHandle_IsCustom(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetCustom")]
		public static extern void SdfPropertySpecHandle_SetCustom(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetVariability")]
		public static extern int SdfPropertySpecHandle_GetVariability(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_HasOnlyRequiredFields")]
		public static extern bool SdfPropertySpecHandle_HasOnlyRequiredFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetSchema")]
		public static extern IntPtr SdfPropertySpecHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetSpecType")]
		public static extern int SdfPropertySpecHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_IsDormant")]
		public static extern bool SdfPropertySpecHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetLayer")]
		public static extern IntPtr SdfPropertySpecHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetPath")]
		public static extern IntPtr SdfPropertySpecHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_PermissionToEdit")]
		public static extern bool SdfPropertySpecHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_ListInfoKeys")]
		public static extern IntPtr SdfPropertySpecHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfPropertySpecHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfPropertySpecHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetInfo")]
		public static extern IntPtr SdfPropertySpecHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetInfo")]
		public static extern void SdfPropertySpecHandle_SetInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetInfoDictionaryValue")]
		public static extern void SdfPropertySpecHandle_SetInfoDictionaryValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_HasInfo")]
		public static extern bool SdfPropertySpecHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_ClearInfo")]
		public static extern void SdfPropertySpecHandle_ClearInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetTypeForInfo")]
		public static extern IntPtr SdfPropertySpecHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfPropertySpecHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_IsInert__SWIG_0")]
		public static extern bool SdfPropertySpecHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_IsInert__SWIG_1")]
		public static extern bool SdfPropertySpecHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_ListFields")]
		public static extern IntPtr SdfPropertySpecHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_HasField")]
		public static extern bool SdfPropertySpecHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_GetField")]
		public static extern IntPtr SdfPropertySpecHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_SetField")]
		public static extern bool SdfPropertySpecHandle_SetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandle_ClearField")]
		public static extern bool SdfPropertySpecHandle_ClearField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecConstHandle__SWIG_0")]
		public static extern IntPtr new_SdfPropertySpecConstHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecConstHandle__SWIG_1")]
		public static extern IntPtr new_SdfPropertySpecConstHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecConstHandle__SWIG_2")]
		public static extern IntPtr new_SdfPropertySpecConstHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle___deref__")]
		public static extern IntPtr SdfPropertySpecConstHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPropertySpecConstHandle")]
		public static extern void delete_SdfPropertySpecConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetName")]
		public static extern string SdfPropertySpecConstHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetNameToken")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_CanSetName")]
		public static extern bool SdfPropertySpecConstHandle_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetOwner")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetCustomData")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetAssetInfo")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetDisplayGroup")]
		public static extern string SdfPropertySpecConstHandle_GetDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetDisplayName")]
		public static extern string SdfPropertySpecConstHandle_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetDocumentation")]
		public static extern string SdfPropertySpecConstHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetHidden")]
		public static extern bool SdfPropertySpecConstHandle_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetPermission")]
		public static extern int SdfPropertySpecConstHandle_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetPrefix")]
		public static extern string SdfPropertySpecConstHandle_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetSuffix")]
		public static extern string SdfPropertySpecConstHandle_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetSymmetricPeer")]
		public static extern string SdfPropertySpecConstHandle_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetSymmetryArguments")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetSymmetryFunction")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetTimeSampleMap")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetTimeSampleMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetValueType")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetValueType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetTypeName")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetDefaultValue")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_HasDefaultValue")]
		public static extern bool SdfPropertySpecConstHandle_HasDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetComment")]
		public static extern string SdfPropertySpecConstHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_IsCustom")]
		public static extern bool SdfPropertySpecConstHandle_IsCustom(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetVariability")]
		public static extern int SdfPropertySpecConstHandle_GetVariability(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_HasOnlyRequiredFields")]
		public static extern bool SdfPropertySpecConstHandle_HasOnlyRequiredFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetSchema")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetSpecType")]
		public static extern int SdfPropertySpecConstHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_IsDormant")]
		public static extern bool SdfPropertySpecConstHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetLayer")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetPath")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_PermissionToEdit")]
		public static extern bool SdfPropertySpecConstHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_ListInfoKeys")]
		public static extern IntPtr SdfPropertySpecConstHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetInfo")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_HasInfo")]
		public static extern bool SdfPropertySpecConstHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetTypeForInfo")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_IsInert__SWIG_0")]
		public static extern bool SdfPropertySpecConstHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_IsInert__SWIG_1")]
		public static extern bool SdfPropertySpecConstHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_ListFields")]
		public static extern IntPtr SdfPropertySpecConstHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_HasField")]
		public static extern bool SdfPropertySpecConstHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandle_GetField")]
		public static extern IntPtr SdfPropertySpecConstHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_Clear")]
		public static extern void SdfPropertySpecHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_Add")]
		public static extern void SdfPropertySpecHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_size")]
		public static extern uint SdfPropertySpecHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_capacity")]
		public static extern uint SdfPropertySpecHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_reserve")]
		public static extern void SdfPropertySpecHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfPropertySpecHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfPropertySpecHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfPropertySpecHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_getitemcopy")]
		public static extern IntPtr SdfPropertySpecHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_getitem")]
		public static extern IntPtr SdfPropertySpecHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_setitem")]
		public static extern void SdfPropertySpecHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_AddRange")]
		public static extern void SdfPropertySpecHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_GetRange")]
		public static extern IntPtr SdfPropertySpecHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_Insert")]
		public static extern void SdfPropertySpecHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_InsertRange")]
		public static extern void SdfPropertySpecHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_RemoveAt")]
		public static extern void SdfPropertySpecHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_RemoveRange")]
		public static extern void SdfPropertySpecHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_Repeat")]
		public static extern IntPtr SdfPropertySpecHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_Reverse__SWIG_0")]
		public static extern void SdfPropertySpecHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_Reverse__SWIG_1")]
		public static extern void SdfPropertySpecHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecHandleVector_SetRange")]
		public static extern void SdfPropertySpecHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPropertySpecHandleVector")]
		public static extern void delete_SdfPropertySpecHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_Clear")]
		public static extern void SdfPropertySpecConstHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_Add")]
		public static extern void SdfPropertySpecConstHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_size")]
		public static extern uint SdfPropertySpecConstHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_capacity")]
		public static extern uint SdfPropertySpecConstHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_reserve")]
		public static extern void SdfPropertySpecConstHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecConstHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfPropertySpecConstHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecConstHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfPropertySpecConstHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPropertySpecConstHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfPropertySpecConstHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_getitemcopy")]
		public static extern IntPtr SdfPropertySpecConstHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_getitem")]
		public static extern IntPtr SdfPropertySpecConstHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_setitem")]
		public static extern void SdfPropertySpecConstHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_AddRange")]
		public static extern void SdfPropertySpecConstHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_GetRange")]
		public static extern IntPtr SdfPropertySpecConstHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_Insert")]
		public static extern void SdfPropertySpecConstHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_InsertRange")]
		public static extern void SdfPropertySpecConstHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_RemoveAt")]
		public static extern void SdfPropertySpecConstHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_RemoveRange")]
		public static extern void SdfPropertySpecConstHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_Repeat")]
		public static extern IntPtr SdfPropertySpecConstHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_Reverse__SWIG_0")]
		public static extern void SdfPropertySpecConstHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_Reverse__SWIG_1")]
		public static extern void SdfPropertySpecConstHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpecConstHandleVector_SetRange")]
		public static extern void SdfPropertySpecConstHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPropertySpecConstHandleVector")]
		public static extern void delete_SdfPropertySpecConstHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecHandle__SWIG_0")]
		public static extern IntPtr new_SdfRelationshipSpecHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecHandle__SWIG_1")]
		public static extern IntPtr new_SdfRelationshipSpecHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecHandle__SWIG_2")]
		public static extern IntPtr new_SdfRelationshipSpecHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle___deref__")]
		public static extern IntPtr SdfRelationshipSpecHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfRelationshipSpecHandle")]
		public static extern void delete_SdfRelationshipSpecHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_New__SWIG_0")]
		public static extern IntPtr SdfRelationshipSpecHandle_New__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, bool jarg4, int jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_New__SWIG_1")]
		public static extern IntPtr SdfRelationshipSpecHandle_New__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3, bool jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_New__SWIG_2")]
		public static extern IntPtr SdfRelationshipSpecHandle_New__SWIG_2(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetTargetPathList")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_HasTargetPathList")]
		public static extern bool SdfRelationshipSpecHandle_HasTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_ClearTargetPathList")]
		public static extern void SdfRelationshipSpecHandle_ClearTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_ReplaceTargetPath")]
		public static extern void SdfRelationshipSpecHandle_ReplaceTargetPath(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_RemoveTargetPath__SWIG_0")]
		public static extern void SdfRelationshipSpecHandle_RemoveTargetPath__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_RemoveTargetPath__SWIG_1")]
		public static extern void SdfRelationshipSpecHandle_RemoveTargetPath__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetNoLoadHint")]
		public static extern bool SdfRelationshipSpecHandle_GetNoLoadHint(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetNoLoadHint")]
		public static extern void SdfRelationshipSpecHandle_SetNoLoadHint(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetName")]
		public static extern string SdfRelationshipSpecHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetNameToken")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_CanSetName")]
		public static extern bool SdfRelationshipSpecHandle_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetName__SWIG_0")]
		public static extern bool SdfRelationshipSpecHandle_SetName__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetName__SWIG_1")]
		public static extern bool SdfRelationshipSpecHandle_SetName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_IsValidName")]
		public static extern bool SdfRelationshipSpecHandle_IsValidName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetOwner")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetCustomData")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetAssetInfo")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetCustomData")]
		public static extern void SdfRelationshipSpecHandle_SetCustomData(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetAssetInfo")]
		public static extern void SdfRelationshipSpecHandle_SetAssetInfo(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetDisplayGroup")]
		public static extern string SdfRelationshipSpecHandle_GetDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetDisplayGroup")]
		public static extern void SdfRelationshipSpecHandle_SetDisplayGroup(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetDisplayName")]
		public static extern string SdfRelationshipSpecHandle_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetDisplayName")]
		public static extern void SdfRelationshipSpecHandle_SetDisplayName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetDocumentation")]
		public static extern string SdfRelationshipSpecHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetDocumentation")]
		public static extern void SdfRelationshipSpecHandle_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetHidden")]
		public static extern bool SdfRelationshipSpecHandle_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetHidden")]
		public static extern void SdfRelationshipSpecHandle_SetHidden(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetPermission")]
		public static extern int SdfRelationshipSpecHandle_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetPermission")]
		public static extern void SdfRelationshipSpecHandle_SetPermission(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetPrefix")]
		public static extern string SdfRelationshipSpecHandle_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetPrefix")]
		public static extern void SdfRelationshipSpecHandle_SetPrefix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetSuffix")]
		public static extern string SdfRelationshipSpecHandle_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetSuffix")]
		public static extern void SdfRelationshipSpecHandle_SetSuffix(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetSymmetricPeer")]
		public static extern string SdfRelationshipSpecHandle_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetSymmetricPeer")]
		public static extern void SdfRelationshipSpecHandle_SetSymmetricPeer(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetSymmetryArguments")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetSymmetryArgument")]
		public static extern void SdfRelationshipSpecHandle_SetSymmetryArgument(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetSymmetryFunction")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetSymmetryFunction")]
		public static extern void SdfRelationshipSpecHandle_SetSymmetryFunction(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetTimeSampleMap")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetTimeSampleMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetValueType")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetValueType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetTypeName")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetDefaultValue")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetDefaultValue")]
		public static extern bool SdfRelationshipSpecHandle_SetDefaultValue(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_HasDefaultValue")]
		public static extern bool SdfRelationshipSpecHandle_HasDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_ClearDefaultValue")]
		public static extern void SdfRelationshipSpecHandle_ClearDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetComment")]
		public static extern string SdfRelationshipSpecHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetComment")]
		public static extern void SdfRelationshipSpecHandle_SetComment(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_IsCustom")]
		public static extern bool SdfRelationshipSpecHandle_IsCustom(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetCustom")]
		public static extern void SdfRelationshipSpecHandle_SetCustom(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetVariability")]
		public static extern int SdfRelationshipSpecHandle_GetVariability(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_HasOnlyRequiredFields")]
		public static extern bool SdfRelationshipSpecHandle_HasOnlyRequiredFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetSchema")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetSpecType")]
		public static extern int SdfRelationshipSpecHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_IsDormant")]
		public static extern bool SdfRelationshipSpecHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetLayer")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetPath")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_PermissionToEdit")]
		public static extern bool SdfRelationshipSpecHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_ListInfoKeys")]
		public static extern IntPtr SdfRelationshipSpecHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetInfo")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetInfo")]
		public static extern void SdfRelationshipSpecHandle_SetInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetInfoDictionaryValue")]
		public static extern void SdfRelationshipSpecHandle_SetInfoDictionaryValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_HasInfo")]
		public static extern bool SdfRelationshipSpecHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_ClearInfo")]
		public static extern void SdfRelationshipSpecHandle_ClearInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetTypeForInfo")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_IsInert__SWIG_0")]
		public static extern bool SdfRelationshipSpecHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_IsInert__SWIG_1")]
		public static extern bool SdfRelationshipSpecHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_ListFields")]
		public static extern IntPtr SdfRelationshipSpecHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_HasField")]
		public static extern bool SdfRelationshipSpecHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_GetField")]
		public static extern IntPtr SdfRelationshipSpecHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_SetField")]
		public static extern bool SdfRelationshipSpecHandle_SetField(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandle_ClearField")]
		public static extern bool SdfRelationshipSpecHandle_ClearField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecConstHandle__SWIG_0")]
		public static extern IntPtr new_SdfRelationshipSpecConstHandle__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecConstHandle__SWIG_1")]
		public static extern IntPtr new_SdfRelationshipSpecConstHandle__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecConstHandle__SWIG_2")]
		public static extern IntPtr new_SdfRelationshipSpecConstHandle__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle___deref__")]
		public static extern IntPtr SdfRelationshipSpecConstHandle___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfRelationshipSpecConstHandle")]
		public static extern void delete_SdfRelationshipSpecConstHandle(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetTargetPathList")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_HasTargetPathList")]
		public static extern bool SdfRelationshipSpecConstHandle_HasTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_ClearTargetPathList")]
		public static extern void SdfRelationshipSpecConstHandle_ClearTargetPathList(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetNoLoadHint")]
		public static extern bool SdfRelationshipSpecConstHandle_GetNoLoadHint(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetName")]
		public static extern string SdfRelationshipSpecConstHandle_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetNameToken")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_CanSetName")]
		public static extern bool SdfRelationshipSpecConstHandle_CanSetName(HandleRef jarg1, string jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetOwner")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetOwner(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetCustomData")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetAssetInfo")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetDisplayGroup")]
		public static extern string SdfRelationshipSpecConstHandle_GetDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetDisplayName")]
		public static extern string SdfRelationshipSpecConstHandle_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetDocumentation")]
		public static extern string SdfRelationshipSpecConstHandle_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetHidden")]
		public static extern bool SdfRelationshipSpecConstHandle_GetHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetPermission")]
		public static extern int SdfRelationshipSpecConstHandle_GetPermission(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetPrefix")]
		public static extern string SdfRelationshipSpecConstHandle_GetPrefix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetSuffix")]
		public static extern string SdfRelationshipSpecConstHandle_GetSuffix(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetSymmetricPeer")]
		public static extern string SdfRelationshipSpecConstHandle_GetSymmetricPeer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetSymmetryArguments")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetSymmetryArguments(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetSymmetryFunction")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetSymmetryFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetTimeSampleMap")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetTimeSampleMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetValueType")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetValueType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetTypeName")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetDefaultValue")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_HasDefaultValue")]
		public static extern bool SdfRelationshipSpecConstHandle_HasDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetComment")]
		public static extern string SdfRelationshipSpecConstHandle_GetComment(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_IsCustom")]
		public static extern bool SdfRelationshipSpecConstHandle_IsCustom(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetVariability")]
		public static extern int SdfRelationshipSpecConstHandle_GetVariability(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_HasOnlyRequiredFields")]
		public static extern bool SdfRelationshipSpecConstHandle_HasOnlyRequiredFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetSchema")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetSchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetSpecType")]
		public static extern int SdfRelationshipSpecConstHandle_GetSpecType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_IsDormant")]
		public static extern bool SdfRelationshipSpecConstHandle_IsDormant(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetLayer")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetPath")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_PermissionToEdit")]
		public static extern bool SdfRelationshipSpecConstHandle_PermissionToEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_ListInfoKeys")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_ListInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetMetaDataInfoKeys")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetMetaDataInfoKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetMetaDataDisplayGroup")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetMetaDataDisplayGroup(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetInfo")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_HasInfo")]
		public static extern bool SdfRelationshipSpecConstHandle_HasInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetTypeForInfo")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetTypeForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetFallbackForInfo")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetFallbackForInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_IsInert__SWIG_0")]
		public static extern bool SdfRelationshipSpecConstHandle_IsInert__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_IsInert__SWIG_1")]
		public static extern bool SdfRelationshipSpecConstHandle_IsInert__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_ListFields")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_ListFields(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_HasField")]
		public static extern bool SdfRelationshipSpecConstHandle_HasField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandle_GetField")]
		public static extern IntPtr SdfRelationshipSpecConstHandle_GetField(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_Clear")]
		public static extern void SdfRelationshipSpecHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_Add")]
		public static extern void SdfRelationshipSpecHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_size")]
		public static extern uint SdfRelationshipSpecHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_capacity")]
		public static extern uint SdfRelationshipSpecHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_reserve")]
		public static extern void SdfRelationshipSpecHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfRelationshipSpecHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfRelationshipSpecHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfRelationshipSpecHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_getitemcopy")]
		public static extern IntPtr SdfRelationshipSpecHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_getitem")]
		public static extern IntPtr SdfRelationshipSpecHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_setitem")]
		public static extern void SdfRelationshipSpecHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_AddRange")]
		public static extern void SdfRelationshipSpecHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_GetRange")]
		public static extern IntPtr SdfRelationshipSpecHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_Insert")]
		public static extern void SdfRelationshipSpecHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_InsertRange")]
		public static extern void SdfRelationshipSpecHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_RemoveAt")]
		public static extern void SdfRelationshipSpecHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_RemoveRange")]
		public static extern void SdfRelationshipSpecHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_Repeat")]
		public static extern IntPtr SdfRelationshipSpecHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_Reverse__SWIG_0")]
		public static extern void SdfRelationshipSpecHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_Reverse__SWIG_1")]
		public static extern void SdfRelationshipSpecHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecHandleVector_SetRange")]
		public static extern void SdfRelationshipSpecHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfRelationshipSpecHandleVector")]
		public static extern void delete_SdfRelationshipSpecHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_Clear")]
		public static extern void SdfRelationshipSpecConstHandleVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_Add")]
		public static extern void SdfRelationshipSpecConstHandleVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_size")]
		public static extern uint SdfRelationshipSpecConstHandleVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_capacity")]
		public static extern uint SdfRelationshipSpecConstHandleVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_reserve")]
		public static extern void SdfRelationshipSpecConstHandleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecConstHandleVector__SWIG_0")]
		public static extern IntPtr new_SdfRelationshipSpecConstHandleVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecConstHandleVector__SWIG_1")]
		public static extern IntPtr new_SdfRelationshipSpecConstHandleVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfRelationshipSpecConstHandleVector__SWIG_2")]
		public static extern IntPtr new_SdfRelationshipSpecConstHandleVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_getitemcopy")]
		public static extern IntPtr SdfRelationshipSpecConstHandleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_getitem")]
		public static extern IntPtr SdfRelationshipSpecConstHandleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_setitem")]
		public static extern void SdfRelationshipSpecConstHandleVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_AddRange")]
		public static extern void SdfRelationshipSpecConstHandleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_GetRange")]
		public static extern IntPtr SdfRelationshipSpecConstHandleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_Insert")]
		public static extern void SdfRelationshipSpecConstHandleVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_InsertRange")]
		public static extern void SdfRelationshipSpecConstHandleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_RemoveAt")]
		public static extern void SdfRelationshipSpecConstHandleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_RemoveRange")]
		public static extern void SdfRelationshipSpecConstHandleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_Repeat")]
		public static extern IntPtr SdfRelationshipSpecConstHandleVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_Reverse__SWIG_0")]
		public static extern void SdfRelationshipSpecConstHandleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_Reverse__SWIG_1")]
		public static extern void SdfRelationshipSpecConstHandleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpecConstHandleVector_SetRange")]
		public static extern void SdfRelationshipSpecConstHandleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfRelationshipSpecConstHandleVector")]
		public static extern void delete_SdfRelationshipSpecConstHandleVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUnregisteredValue__SWIG_0")]
		public static extern IntPtr new_SdfUnregisteredValue__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUnregisteredValue__SWIG_1")]
		public static extern IntPtr new_SdfUnregisteredValue__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUnregisteredValue__SWIG_2")]
		public static extern IntPtr new_SdfUnregisteredValue__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUnregisteredValue__SWIG_3")]
		public static extern IntPtr new_SdfUnregisteredValue__SWIG_3(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValue_GetValue")]
		public static extern IntPtr SdfUnregisteredValue_GetValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfUnregisteredValue")]
		public static extern void delete_SdfUnregisteredValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfValueBlock")]
		public static extern IntPtr new_SdfValueBlock();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfValueBlock")]
		public static extern void delete_SdfValueBlock(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfHumanReadableValue__SWIG_0")]
		public static extern IntPtr new_SdfHumanReadableValue__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfHumanReadableValue__SWIG_1")]
		public static extern IntPtr new_SdfHumanReadableValue__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfHumanReadableValue_GetText")]
		public static extern string SdfHumanReadableValue_GetText(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfHumanReadableValue")]
		public static extern void delete_SdfHumanReadableValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_Clear")]
		public static extern void SdfIntListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_Add")]
		public static extern void SdfIntListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_size")]
		public static extern uint SdfIntListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_capacity")]
		public static extern uint SdfIntListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_reserve")]
		public static extern void SdfIntListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfIntListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfIntListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfIntListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfIntListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfIntListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfIntListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_getitemcopy")]
		public static extern IntPtr SdfIntListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_getitem")]
		public static extern IntPtr SdfIntListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_setitem")]
		public static extern void SdfIntListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_AddRange")]
		public static extern void SdfIntListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_GetRange")]
		public static extern IntPtr SdfIntListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_Insert")]
		public static extern void SdfIntListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_InsertRange")]
		public static extern void SdfIntListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_RemoveAt")]
		public static extern void SdfIntListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_RemoveRange")]
		public static extern void SdfIntListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_Repeat")]
		public static extern IntPtr SdfIntListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_Reverse__SWIG_0")]
		public static extern void SdfIntListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_Reverse__SWIG_1")]
		public static extern void SdfIntListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOpVector_SetRange")]
		public static extern void SdfIntListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfIntListOpVector")]
		public static extern void delete_SdfIntListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfIntListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfIntListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_Create__SWIG_0")]
		public static extern IntPtr SdfIntListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_Create__SWIG_1")]
		public static extern IntPtr SdfIntListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_Create__SWIG_2")]
		public static extern IntPtr SdfIntListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_Create__SWIG_3")]
		public static extern IntPtr SdfIntListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfIntListOp")]
		public static extern IntPtr new_SdfIntListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_Swap")]
		public static extern void SdfIntListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_HasKeys")]
		public static extern bool SdfIntListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_HasItem")]
		public static extern bool SdfIntListOp_HasItem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_IsExplicit")]
		public static extern bool SdfIntListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_GetExplicitItems")]
		public static extern IntPtr SdfIntListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_GetAddedItems")]
		public static extern IntPtr SdfIntListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_GetPrependedItems")]
		public static extern IntPtr SdfIntListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_GetAppendedItems")]
		public static extern IntPtr SdfIntListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_GetDeletedItems")]
		public static extern IntPtr SdfIntListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_GetOrderedItems")]
		public static extern IntPtr SdfIntListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_GetItems")]
		public static extern IntPtr SdfIntListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_SetExplicitItems")]
		public static extern void SdfIntListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_SetAddedItems")]
		public static extern void SdfIntListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_SetPrependedItems")]
		public static extern void SdfIntListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_SetAppendedItems")]
		public static extern void SdfIntListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_SetDeletedItems")]
		public static extern void SdfIntListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_SetOrderedItems")]
		public static extern void SdfIntListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_SetItems")]
		public static extern void SdfIntListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_Clear")]
		public static extern void SdfIntListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_ClearAndMakeExplicit")]
		public static extern void SdfIntListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_ReplaceOperations")]
		public static extern bool SdfIntListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfIntListOp_ComposeOperations")]
		public static extern void SdfIntListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfIntListOp")]
		public static extern void delete_SdfIntListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_Clear")]
		public static extern void SdfUIntListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_Add")]
		public static extern void SdfUIntListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_size")]
		public static extern uint SdfUIntListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_capacity")]
		public static extern uint SdfUIntListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_reserve")]
		public static extern void SdfUIntListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUIntListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfUIntListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUIntListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfUIntListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUIntListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfUIntListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_getitemcopy")]
		public static extern IntPtr SdfUIntListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_getitem")]
		public static extern IntPtr SdfUIntListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_setitem")]
		public static extern void SdfUIntListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_AddRange")]
		public static extern void SdfUIntListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_GetRange")]
		public static extern IntPtr SdfUIntListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_Insert")]
		public static extern void SdfUIntListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_InsertRange")]
		public static extern void SdfUIntListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_RemoveAt")]
		public static extern void SdfUIntListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_RemoveRange")]
		public static extern void SdfUIntListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_Repeat")]
		public static extern IntPtr SdfUIntListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_Reverse__SWIG_0")]
		public static extern void SdfUIntListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_Reverse__SWIG_1")]
		public static extern void SdfUIntListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOpVector_SetRange")]
		public static extern void SdfUIntListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfUIntListOpVector")]
		public static extern void delete_SdfUIntListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfUIntListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfUIntListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_Create__SWIG_0")]
		public static extern IntPtr SdfUIntListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_Create__SWIG_1")]
		public static extern IntPtr SdfUIntListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_Create__SWIG_2")]
		public static extern IntPtr SdfUIntListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_Create__SWIG_3")]
		public static extern IntPtr SdfUIntListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUIntListOp")]
		public static extern IntPtr new_SdfUIntListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_Swap")]
		public static extern void SdfUIntListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_HasKeys")]
		public static extern bool SdfUIntListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_HasItem")]
		public static extern bool SdfUIntListOp_HasItem(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_IsExplicit")]
		public static extern bool SdfUIntListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_GetExplicitItems")]
		public static extern IntPtr SdfUIntListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_GetAddedItems")]
		public static extern IntPtr SdfUIntListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_GetPrependedItems")]
		public static extern IntPtr SdfUIntListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_GetAppendedItems")]
		public static extern IntPtr SdfUIntListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_GetDeletedItems")]
		public static extern IntPtr SdfUIntListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_GetOrderedItems")]
		public static extern IntPtr SdfUIntListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_GetItems")]
		public static extern IntPtr SdfUIntListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_SetExplicitItems")]
		public static extern void SdfUIntListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_SetAddedItems")]
		public static extern void SdfUIntListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_SetPrependedItems")]
		public static extern void SdfUIntListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_SetAppendedItems")]
		public static extern void SdfUIntListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_SetDeletedItems")]
		public static extern void SdfUIntListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_SetOrderedItems")]
		public static extern void SdfUIntListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_SetItems")]
		public static extern void SdfUIntListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_Clear")]
		public static extern void SdfUIntListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_ClearAndMakeExplicit")]
		public static extern void SdfUIntListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_ReplaceOperations")]
		public static extern bool SdfUIntListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUIntListOp_ComposeOperations")]
		public static extern void SdfUIntListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfUIntListOp")]
		public static extern void delete_SdfUIntListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_Clear")]
		public static extern void SdfInt64ListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_Add")]
		public static extern void SdfInt64ListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_size")]
		public static extern uint SdfInt64ListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_capacity")]
		public static extern uint SdfInt64ListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_reserve")]
		public static extern void SdfInt64ListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfInt64ListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfInt64ListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfInt64ListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfInt64ListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfInt64ListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfInt64ListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_getitemcopy")]
		public static extern IntPtr SdfInt64ListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_getitem")]
		public static extern IntPtr SdfInt64ListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_setitem")]
		public static extern void SdfInt64ListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_AddRange")]
		public static extern void SdfInt64ListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_GetRange")]
		public static extern IntPtr SdfInt64ListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_Insert")]
		public static extern void SdfInt64ListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_InsertRange")]
		public static extern void SdfInt64ListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_RemoveAt")]
		public static extern void SdfInt64ListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_RemoveRange")]
		public static extern void SdfInt64ListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_Repeat")]
		public static extern IntPtr SdfInt64ListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_Reverse__SWIG_0")]
		public static extern void SdfInt64ListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_Reverse__SWIG_1")]
		public static extern void SdfInt64ListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOpVector_SetRange")]
		public static extern void SdfInt64ListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfInt64ListOpVector")]
		public static extern void delete_SdfInt64ListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfInt64ListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfInt64ListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_Create__SWIG_0")]
		public static extern IntPtr SdfInt64ListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_Create__SWIG_1")]
		public static extern IntPtr SdfInt64ListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_Create__SWIG_2")]
		public static extern IntPtr SdfInt64ListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_Create__SWIG_3")]
		public static extern IntPtr SdfInt64ListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfInt64ListOp")]
		public static extern IntPtr new_SdfInt64ListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_Swap")]
		public static extern void SdfInt64ListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_HasKeys")]
		public static extern bool SdfInt64ListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_HasItem")]
		public static extern bool SdfInt64ListOp_HasItem(HandleRef jarg1, long jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_IsExplicit")]
		public static extern bool SdfInt64ListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_GetExplicitItems")]
		public static extern IntPtr SdfInt64ListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_GetAddedItems")]
		public static extern IntPtr SdfInt64ListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_GetPrependedItems")]
		public static extern IntPtr SdfInt64ListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_GetAppendedItems")]
		public static extern IntPtr SdfInt64ListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_GetDeletedItems")]
		public static extern IntPtr SdfInt64ListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_GetOrderedItems")]
		public static extern IntPtr SdfInt64ListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_GetItems")]
		public static extern IntPtr SdfInt64ListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_SetExplicitItems")]
		public static extern void SdfInt64ListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_SetAddedItems")]
		public static extern void SdfInt64ListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_SetPrependedItems")]
		public static extern void SdfInt64ListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_SetAppendedItems")]
		public static extern void SdfInt64ListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_SetDeletedItems")]
		public static extern void SdfInt64ListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_SetOrderedItems")]
		public static extern void SdfInt64ListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_SetItems")]
		public static extern void SdfInt64ListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_Clear")]
		public static extern void SdfInt64ListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_ClearAndMakeExplicit")]
		public static extern void SdfInt64ListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_ReplaceOperations")]
		public static extern bool SdfInt64ListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfInt64ListOp_ComposeOperations")]
		public static extern void SdfInt64ListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfInt64ListOp")]
		public static extern void delete_SdfInt64ListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_Clear")]
		public static extern void SdfUInt64ListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_Add")]
		public static extern void SdfUInt64ListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_size")]
		public static extern uint SdfUInt64ListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_capacity")]
		public static extern uint SdfUInt64ListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_reserve")]
		public static extern void SdfUInt64ListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUInt64ListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfUInt64ListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUInt64ListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfUInt64ListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUInt64ListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfUInt64ListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_getitemcopy")]
		public static extern IntPtr SdfUInt64ListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_getitem")]
		public static extern IntPtr SdfUInt64ListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_setitem")]
		public static extern void SdfUInt64ListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_AddRange")]
		public static extern void SdfUInt64ListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_GetRange")]
		public static extern IntPtr SdfUInt64ListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_Insert")]
		public static extern void SdfUInt64ListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_InsertRange")]
		public static extern void SdfUInt64ListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_RemoveAt")]
		public static extern void SdfUInt64ListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_RemoveRange")]
		public static extern void SdfUInt64ListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_Repeat")]
		public static extern IntPtr SdfUInt64ListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_Reverse__SWIG_0")]
		public static extern void SdfUInt64ListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_Reverse__SWIG_1")]
		public static extern void SdfUInt64ListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOpVector_SetRange")]
		public static extern void SdfUInt64ListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfUInt64ListOpVector")]
		public static extern void delete_SdfUInt64ListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfUInt64ListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfUInt64ListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_Create__SWIG_0")]
		public static extern IntPtr SdfUInt64ListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_Create__SWIG_1")]
		public static extern IntPtr SdfUInt64ListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_Create__SWIG_2")]
		public static extern IntPtr SdfUInt64ListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_Create__SWIG_3")]
		public static extern IntPtr SdfUInt64ListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUInt64ListOp")]
		public static extern IntPtr new_SdfUInt64ListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_Swap")]
		public static extern void SdfUInt64ListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_HasKeys")]
		public static extern bool SdfUInt64ListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_HasItem")]
		public static extern bool SdfUInt64ListOp_HasItem(HandleRef jarg1, ulong jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_IsExplicit")]
		public static extern bool SdfUInt64ListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_GetExplicitItems")]
		public static extern IntPtr SdfUInt64ListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_GetAddedItems")]
		public static extern IntPtr SdfUInt64ListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_GetPrependedItems")]
		public static extern IntPtr SdfUInt64ListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_GetAppendedItems")]
		public static extern IntPtr SdfUInt64ListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_GetDeletedItems")]
		public static extern IntPtr SdfUInt64ListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_GetOrderedItems")]
		public static extern IntPtr SdfUInt64ListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_GetItems")]
		public static extern IntPtr SdfUInt64ListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_SetExplicitItems")]
		public static extern void SdfUInt64ListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_SetAddedItems")]
		public static extern void SdfUInt64ListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_SetPrependedItems")]
		public static extern void SdfUInt64ListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_SetAppendedItems")]
		public static extern void SdfUInt64ListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_SetDeletedItems")]
		public static extern void SdfUInt64ListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_SetOrderedItems")]
		public static extern void SdfUInt64ListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_SetItems")]
		public static extern void SdfUInt64ListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_Clear")]
		public static extern void SdfUInt64ListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_ClearAndMakeExplicit")]
		public static extern void SdfUInt64ListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_ReplaceOperations")]
		public static extern bool SdfUInt64ListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUInt64ListOp_ComposeOperations")]
		public static extern void SdfUInt64ListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfUInt64ListOp")]
		public static extern void delete_SdfUInt64ListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_Clear")]
		public static extern void SdfTfTokenListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_Add")]
		public static extern void SdfTfTokenListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_size")]
		public static extern uint SdfTfTokenListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_capacity")]
		public static extern uint SdfTfTokenListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_reserve")]
		public static extern void SdfTfTokenListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTfTokenListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfTfTokenListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTfTokenListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfTfTokenListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTfTokenListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfTfTokenListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_getitemcopy")]
		public static extern IntPtr SdfTfTokenListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_getitem")]
		public static extern IntPtr SdfTfTokenListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_setitem")]
		public static extern void SdfTfTokenListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_AddRange")]
		public static extern void SdfTfTokenListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_GetRange")]
		public static extern IntPtr SdfTfTokenListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_Insert")]
		public static extern void SdfTfTokenListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_InsertRange")]
		public static extern void SdfTfTokenListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_RemoveAt")]
		public static extern void SdfTfTokenListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_RemoveRange")]
		public static extern void SdfTfTokenListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_Repeat")]
		public static extern IntPtr SdfTfTokenListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_Reverse__SWIG_0")]
		public static extern void SdfTfTokenListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_Reverse__SWIG_1")]
		public static extern void SdfTfTokenListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTfTokenListOpVector_SetRange")]
		public static extern void SdfTfTokenListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfTfTokenListOpVector")]
		public static extern void delete_SdfTfTokenListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfTokenListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfTokenListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_Create__SWIG_0")]
		public static extern IntPtr SdfTokenListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_Create__SWIG_1")]
		public static extern IntPtr SdfTokenListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_Create__SWIG_2")]
		public static extern IntPtr SdfTokenListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_Create__SWIG_3")]
		public static extern IntPtr SdfTokenListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTokenListOp")]
		public static extern IntPtr new_SdfTokenListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_Swap")]
		public static extern void SdfTokenListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_HasKeys")]
		public static extern bool SdfTokenListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_HasItem")]
		public static extern bool SdfTokenListOp_HasItem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_IsExplicit")]
		public static extern bool SdfTokenListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_GetExplicitItems")]
		public static extern IntPtr SdfTokenListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_GetAddedItems")]
		public static extern IntPtr SdfTokenListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_GetPrependedItems")]
		public static extern IntPtr SdfTokenListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_GetAppendedItems")]
		public static extern IntPtr SdfTokenListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_GetDeletedItems")]
		public static extern IntPtr SdfTokenListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_GetOrderedItems")]
		public static extern IntPtr SdfTokenListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_GetItems")]
		public static extern IntPtr SdfTokenListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_SetExplicitItems")]
		public static extern void SdfTokenListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_SetAddedItems")]
		public static extern void SdfTokenListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_SetPrependedItems")]
		public static extern void SdfTokenListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_SetAppendedItems")]
		public static extern void SdfTokenListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_SetDeletedItems")]
		public static extern void SdfTokenListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_SetOrderedItems")]
		public static extern void SdfTokenListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_SetItems")]
		public static extern void SdfTokenListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_Clear")]
		public static extern void SdfTokenListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_ClearAndMakeExplicit")]
		public static extern void SdfTokenListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_ReplaceOperations")]
		public static extern bool SdfTokenListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTokenListOp_ComposeOperations")]
		public static extern void SdfTokenListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfTokenListOp")]
		public static extern void delete_SdfTokenListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_Clear")]
		public static extern void SdfStringListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_Add")]
		public static extern void SdfStringListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_size")]
		public static extern uint SdfStringListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_capacity")]
		public static extern uint SdfStringListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_reserve")]
		public static extern void SdfStringListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfStringListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfStringListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfStringListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfStringListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfStringListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfStringListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_getitemcopy")]
		public static extern IntPtr SdfStringListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_getitem")]
		public static extern IntPtr SdfStringListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_setitem")]
		public static extern void SdfStringListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_AddRange")]
		public static extern void SdfStringListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_GetRange")]
		public static extern IntPtr SdfStringListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_Insert")]
		public static extern void SdfStringListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_InsertRange")]
		public static extern void SdfStringListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_RemoveAt")]
		public static extern void SdfStringListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_RemoveRange")]
		public static extern void SdfStringListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_Repeat")]
		public static extern IntPtr SdfStringListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_Reverse__SWIG_0")]
		public static extern void SdfStringListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_Reverse__SWIG_1")]
		public static extern void SdfStringListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOpVector_SetRange")]
		public static extern void SdfStringListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfStringListOpVector")]
		public static extern void delete_SdfStringListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfStringListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfStringListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_Create__SWIG_0")]
		public static extern IntPtr SdfStringListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_Create__SWIG_1")]
		public static extern IntPtr SdfStringListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_Create__SWIG_2")]
		public static extern IntPtr SdfStringListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_Create__SWIG_3")]
		public static extern IntPtr SdfStringListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfStringListOp")]
		public static extern IntPtr new_SdfStringListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_Swap")]
		public static extern void SdfStringListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_HasKeys")]
		public static extern bool SdfStringListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_HasItem")]
		public static extern bool SdfStringListOp_HasItem(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_IsExplicit")]
		public static extern bool SdfStringListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_GetExplicitItems")]
		public static extern IntPtr SdfStringListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_GetAddedItems")]
		public static extern IntPtr SdfStringListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_GetPrependedItems")]
		public static extern IntPtr SdfStringListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_GetAppendedItems")]
		public static extern IntPtr SdfStringListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_GetDeletedItems")]
		public static extern IntPtr SdfStringListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_GetOrderedItems")]
		public static extern IntPtr SdfStringListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_GetItems")]
		public static extern IntPtr SdfStringListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_SetExplicitItems")]
		public static extern void SdfStringListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_SetAddedItems")]
		public static extern void SdfStringListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_SetPrependedItems")]
		public static extern void SdfStringListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_SetAppendedItems")]
		public static extern void SdfStringListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_SetDeletedItems")]
		public static extern void SdfStringListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_SetOrderedItems")]
		public static extern void SdfStringListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_SetItems")]
		public static extern void SdfStringListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_Clear")]
		public static extern void SdfStringListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_ClearAndMakeExplicit")]
		public static extern void SdfStringListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_ReplaceOperations")]
		public static extern bool SdfStringListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfStringListOp_ComposeOperations")]
		public static extern void SdfStringListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfStringListOp")]
		public static extern void delete_SdfStringListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_Clear")]
		public static extern void SdfPathListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_Add")]
		public static extern void SdfPathListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_size")]
		public static extern uint SdfPathListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_capacity")]
		public static extern uint SdfPathListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_reserve")]
		public static extern void SdfPathListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfPathListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfPathListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfPathListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_getitemcopy")]
		public static extern IntPtr SdfPathListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_getitem")]
		public static extern IntPtr SdfPathListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_setitem")]
		public static extern void SdfPathListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_AddRange")]
		public static extern void SdfPathListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_GetRange")]
		public static extern IntPtr SdfPathListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_Insert")]
		public static extern void SdfPathListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_InsertRange")]
		public static extern void SdfPathListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_RemoveAt")]
		public static extern void SdfPathListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_RemoveRange")]
		public static extern void SdfPathListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_Repeat")]
		public static extern IntPtr SdfPathListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_Reverse__SWIG_0")]
		public static extern void SdfPathListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_Reverse__SWIG_1")]
		public static extern void SdfPathListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOpVector_SetRange")]
		public static extern void SdfPathListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPathListOpVector")]
		public static extern void delete_SdfPathListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfPathListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfPathListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_Create__SWIG_0")]
		public static extern IntPtr SdfPathListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_Create__SWIG_1")]
		public static extern IntPtr SdfPathListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_Create__SWIG_2")]
		public static extern IntPtr SdfPathListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_Create__SWIG_3")]
		public static extern IntPtr SdfPathListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathListOp")]
		public static extern IntPtr new_SdfPathListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_Swap")]
		public static extern void SdfPathListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_HasKeys")]
		public static extern bool SdfPathListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_HasItem")]
		public static extern bool SdfPathListOp_HasItem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_IsExplicit")]
		public static extern bool SdfPathListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_GetExplicitItems")]
		public static extern IntPtr SdfPathListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_GetAddedItems")]
		public static extern IntPtr SdfPathListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_GetPrependedItems")]
		public static extern IntPtr SdfPathListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_GetAppendedItems")]
		public static extern IntPtr SdfPathListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_GetDeletedItems")]
		public static extern IntPtr SdfPathListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_GetOrderedItems")]
		public static extern IntPtr SdfPathListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_GetItems")]
		public static extern IntPtr SdfPathListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_SetExplicitItems")]
		public static extern void SdfPathListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_SetAddedItems")]
		public static extern void SdfPathListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_SetPrependedItems")]
		public static extern void SdfPathListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_SetAppendedItems")]
		public static extern void SdfPathListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_SetDeletedItems")]
		public static extern void SdfPathListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_SetOrderedItems")]
		public static extern void SdfPathListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_SetItems")]
		public static extern void SdfPathListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_Clear")]
		public static extern void SdfPathListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_ClearAndMakeExplicit")]
		public static extern void SdfPathListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_ReplaceOperations")]
		public static extern bool SdfPathListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathListOp_ComposeOperations")]
		public static extern void SdfPathListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPathListOp")]
		public static extern void delete_SdfPathListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_Clear")]
		public static extern void SdfReferenceListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_Add")]
		public static extern void SdfReferenceListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_size")]
		public static extern uint SdfReferenceListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_capacity")]
		public static extern uint SdfReferenceListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_reserve")]
		public static extern void SdfReferenceListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReferenceListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfReferenceListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReferenceListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfReferenceListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReferenceListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfReferenceListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_getitemcopy")]
		public static extern IntPtr SdfReferenceListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_getitem")]
		public static extern IntPtr SdfReferenceListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_setitem")]
		public static extern void SdfReferenceListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_AddRange")]
		public static extern void SdfReferenceListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_GetRange")]
		public static extern IntPtr SdfReferenceListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_Insert")]
		public static extern void SdfReferenceListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_InsertRange")]
		public static extern void SdfReferenceListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_RemoveAt")]
		public static extern void SdfReferenceListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_RemoveRange")]
		public static extern void SdfReferenceListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_Repeat")]
		public static extern IntPtr SdfReferenceListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_Reverse__SWIG_0")]
		public static extern void SdfReferenceListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_Reverse__SWIG_1")]
		public static extern void SdfReferenceListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOpVector_SetRange")]
		public static extern void SdfReferenceListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfReferenceListOpVector")]
		public static extern void delete_SdfReferenceListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfReferenceListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfReferenceListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_Create__SWIG_0")]
		public static extern IntPtr SdfReferenceListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_Create__SWIG_1")]
		public static extern IntPtr SdfReferenceListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_Create__SWIG_2")]
		public static extern IntPtr SdfReferenceListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_Create__SWIG_3")]
		public static extern IntPtr SdfReferenceListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfReferenceListOp")]
		public static extern IntPtr new_SdfReferenceListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_Swap")]
		public static extern void SdfReferenceListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_HasKeys")]
		public static extern bool SdfReferenceListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_HasItem")]
		public static extern bool SdfReferenceListOp_HasItem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_IsExplicit")]
		public static extern bool SdfReferenceListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_GetExplicitItems")]
		public static extern IntPtr SdfReferenceListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_GetAddedItems")]
		public static extern IntPtr SdfReferenceListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_GetPrependedItems")]
		public static extern IntPtr SdfReferenceListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_GetAppendedItems")]
		public static extern IntPtr SdfReferenceListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_GetDeletedItems")]
		public static extern IntPtr SdfReferenceListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_GetOrderedItems")]
		public static extern IntPtr SdfReferenceListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_GetItems")]
		public static extern IntPtr SdfReferenceListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_SetExplicitItems")]
		public static extern void SdfReferenceListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_SetAddedItems")]
		public static extern void SdfReferenceListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_SetPrependedItems")]
		public static extern void SdfReferenceListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_SetAppendedItems")]
		public static extern void SdfReferenceListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_SetDeletedItems")]
		public static extern void SdfReferenceListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_SetOrderedItems")]
		public static extern void SdfReferenceListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_SetItems")]
		public static extern void SdfReferenceListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_Clear")]
		public static extern void SdfReferenceListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_ClearAndMakeExplicit")]
		public static extern void SdfReferenceListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_ReplaceOperations")]
		public static extern bool SdfReferenceListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfReferenceListOp_ComposeOperations")]
		public static extern void SdfReferenceListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfReferenceListOp")]
		public static extern void delete_SdfReferenceListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_Clear")]
		public static extern void SdfUnregisteredValueListOpVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_Add")]
		public static extern void SdfUnregisteredValueListOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_size")]
		public static extern uint SdfUnregisteredValueListOpVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_capacity")]
		public static extern uint SdfUnregisteredValueListOpVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_reserve")]
		public static extern void SdfUnregisteredValueListOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUnregisteredValueListOpVector__SWIG_0")]
		public static extern IntPtr new_SdfUnregisteredValueListOpVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUnregisteredValueListOpVector__SWIG_1")]
		public static extern IntPtr new_SdfUnregisteredValueListOpVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUnregisteredValueListOpVector__SWIG_2")]
		public static extern IntPtr new_SdfUnregisteredValueListOpVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_getitemcopy")]
		public static extern IntPtr SdfUnregisteredValueListOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_getitem")]
		public static extern IntPtr SdfUnregisteredValueListOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_setitem")]
		public static extern void SdfUnregisteredValueListOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_AddRange")]
		public static extern void SdfUnregisteredValueListOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_GetRange")]
		public static extern IntPtr SdfUnregisteredValueListOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_Insert")]
		public static extern void SdfUnregisteredValueListOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_InsertRange")]
		public static extern void SdfUnregisteredValueListOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_RemoveAt")]
		public static extern void SdfUnregisteredValueListOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_RemoveRange")]
		public static extern void SdfUnregisteredValueListOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_Repeat")]
		public static extern IntPtr SdfUnregisteredValueListOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_Reverse__SWIG_0")]
		public static extern void SdfUnregisteredValueListOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_Reverse__SWIG_1")]
		public static extern void SdfUnregisteredValueListOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOpVector_SetRange")]
		public static extern void SdfUnregisteredValueListOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfUnregisteredValueListOpVector")]
		public static extern void delete_SdfUnregisteredValueListOpVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_CreateExplicit__SWIG_0")]
		public static extern IntPtr SdfUnregisteredValueListOp_CreateExplicit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_CreateExplicit__SWIG_1")]
		public static extern IntPtr SdfUnregisteredValueListOp_CreateExplicit__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_Create__SWIG_0")]
		public static extern IntPtr SdfUnregisteredValueListOp_Create__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_Create__SWIG_1")]
		public static extern IntPtr SdfUnregisteredValueListOp_Create__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_Create__SWIG_2")]
		public static extern IntPtr SdfUnregisteredValueListOp_Create__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_Create__SWIG_3")]
		public static extern IntPtr SdfUnregisteredValueListOp_Create__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfUnregisteredValueListOp")]
		public static extern IntPtr new_SdfUnregisteredValueListOp();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_Swap")]
		public static extern void SdfUnregisteredValueListOp_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_HasKeys")]
		public static extern bool SdfUnregisteredValueListOp_HasKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_HasItem")]
		public static extern bool SdfUnregisteredValueListOp_HasItem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_IsExplicit")]
		public static extern bool SdfUnregisteredValueListOp_IsExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_GetExplicitItems")]
		public static extern IntPtr SdfUnregisteredValueListOp_GetExplicitItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_GetAddedItems")]
		public static extern IntPtr SdfUnregisteredValueListOp_GetAddedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_GetPrependedItems")]
		public static extern IntPtr SdfUnregisteredValueListOp_GetPrependedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_GetAppendedItems")]
		public static extern IntPtr SdfUnregisteredValueListOp_GetAppendedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_GetDeletedItems")]
		public static extern IntPtr SdfUnregisteredValueListOp_GetDeletedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_GetOrderedItems")]
		public static extern IntPtr SdfUnregisteredValueListOp_GetOrderedItems(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_GetItems")]
		public static extern IntPtr SdfUnregisteredValueListOp_GetItems(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_SetExplicitItems")]
		public static extern void SdfUnregisteredValueListOp_SetExplicitItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_SetAddedItems")]
		public static extern void SdfUnregisteredValueListOp_SetAddedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_SetPrependedItems")]
		public static extern void SdfUnregisteredValueListOp_SetPrependedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_SetAppendedItems")]
		public static extern void SdfUnregisteredValueListOp_SetAppendedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_SetDeletedItems")]
		public static extern void SdfUnregisteredValueListOp_SetDeletedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_SetOrderedItems")]
		public static extern void SdfUnregisteredValueListOp_SetOrderedItems(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_SetItems")]
		public static extern void SdfUnregisteredValueListOp_SetItems(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_Clear")]
		public static extern void SdfUnregisteredValueListOp_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_ClearAndMakeExplicit")]
		public static extern void SdfUnregisteredValueListOp_ClearAndMakeExplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_ReplaceOperations")]
		public static extern bool SdfUnregisteredValueListOp_ReplaceOperations(HandleRef jarg1, int jarg2, uint jarg3, uint jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfUnregisteredValueListOp_ComposeOperations")]
		public static extern void SdfUnregisteredValueListOp_ComposeOperations(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfUnregisteredValueListOp")]
		public static extern void delete_SdfUnregisteredValueListOp(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_push_back")]
		public static extern void SdfSubLayerProxy_push_back(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_size")]
		public static extern uint SdfSubLayerProxy_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_GetPath")]
		public static extern IntPtr SdfSubLayerProxy_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_Count")]
		public static extern uint SdfSubLayerProxy_Count(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_Find")]
		public static extern uint SdfSubLayerProxy_Find(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_Insert")]
		public static extern void SdfSubLayerProxy_Insert(HandleRef jarg1, int jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_Remove")]
		public static extern void SdfSubLayerProxy_Remove(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_Replace")]
		public static extern void SdfSubLayerProxy_Replace(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_Erase")]
		public static extern void SdfSubLayerProxy_Erase(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfSubLayerProxy_IsExpired")]
		public static extern bool SdfSubLayerProxy_IsExpired(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfSubLayerProxy")]
		public static extern void delete_SdfSubLayerProxy(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_Clear")]
		public static extern void SdfNamespaceEditVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_Add")]
		public static extern void SdfNamespaceEditVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_size")]
		public static extern uint SdfNamespaceEditVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_capacity")]
		public static extern uint SdfNamespaceEditVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_reserve")]
		public static extern void SdfNamespaceEditVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEditVector__SWIG_0")]
		public static extern IntPtr new_SdfNamespaceEditVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEditVector__SWIG_1")]
		public static extern IntPtr new_SdfNamespaceEditVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEditVector__SWIG_2")]
		public static extern IntPtr new_SdfNamespaceEditVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_getitemcopy")]
		public static extern IntPtr SdfNamespaceEditVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_getitem")]
		public static extern IntPtr SdfNamespaceEditVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_setitem")]
		public static extern void SdfNamespaceEditVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_AddRange")]
		public static extern void SdfNamespaceEditVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_GetRange")]
		public static extern IntPtr SdfNamespaceEditVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_Insert")]
		public static extern void SdfNamespaceEditVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_InsertRange")]
		public static extern void SdfNamespaceEditVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_RemoveAt")]
		public static extern void SdfNamespaceEditVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_RemoveRange")]
		public static extern void SdfNamespaceEditVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_Repeat")]
		public static extern IntPtr SdfNamespaceEditVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_Reverse__SWIG_0")]
		public static extern void SdfNamespaceEditVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_Reverse__SWIG_1")]
		public static extern void SdfNamespaceEditVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditVector_SetRange")]
		public static extern void SdfNamespaceEditVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfNamespaceEditVector")]
		public static extern void delete_SdfNamespaceEditVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_Clear")]
		public static extern void SdfNamespaceEditDetailVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_Add")]
		public static extern void SdfNamespaceEditDetailVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_size")]
		public static extern uint SdfNamespaceEditDetailVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_capacity")]
		public static extern uint SdfNamespaceEditDetailVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_reserve")]
		public static extern void SdfNamespaceEditDetailVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEditDetailVector__SWIG_0")]
		public static extern IntPtr new_SdfNamespaceEditDetailVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEditDetailVector__SWIG_1")]
		public static extern IntPtr new_SdfNamespaceEditDetailVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEditDetailVector__SWIG_2")]
		public static extern IntPtr new_SdfNamespaceEditDetailVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_getitemcopy")]
		public static extern IntPtr SdfNamespaceEditDetailVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_getitem")]
		public static extern IntPtr SdfNamespaceEditDetailVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_setitem")]
		public static extern void SdfNamespaceEditDetailVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_AddRange")]
		public static extern void SdfNamespaceEditDetailVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_GetRange")]
		public static extern IntPtr SdfNamespaceEditDetailVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_Insert")]
		public static extern void SdfNamespaceEditDetailVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_InsertRange")]
		public static extern void SdfNamespaceEditDetailVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_RemoveAt")]
		public static extern void SdfNamespaceEditDetailVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_RemoveRange")]
		public static extern void SdfNamespaceEditDetailVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_Repeat")]
		public static extern IntPtr SdfNamespaceEditDetailVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_Reverse__SWIG_0")]
		public static extern void SdfNamespaceEditDetailVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_Reverse__SWIG_1")]
		public static extern void SdfNamespaceEditDetailVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetailVector_SetRange")]
		public static extern void SdfNamespaceEditDetailVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfNamespaceEditDetailVector")]
		public static extern void delete_SdfNamespaceEditDetailVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEdit__SWIG_0")]
		public static extern IntPtr new_SdfNamespaceEdit__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEdit__SWIG_1")]
		public static extern IntPtr new_SdfNamespaceEdit__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEdit__SWIG_2")]
		public static extern IntPtr new_SdfNamespaceEdit__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_Remove")]
		public static extern IntPtr SdfNamespaceEdit_Remove(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_Rename")]
		public static extern IntPtr SdfNamespaceEdit_Rename(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_Reorder")]
		public static extern IntPtr SdfNamespaceEdit_Reorder(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_Reparent")]
		public static extern IntPtr SdfNamespaceEdit_Reparent(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_ReparentAndRename")]
		public static extern IntPtr SdfNamespaceEdit_ReparentAndRename(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_currentPath_set")]
		public static extern void SdfNamespaceEdit_currentPath_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_currentPath_get")]
		public static extern IntPtr SdfNamespaceEdit_currentPath_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_newPath_set")]
		public static extern void SdfNamespaceEdit_newPath_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_newPath_get")]
		public static extern IntPtr SdfNamespaceEdit_newPath_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_index_set")]
		public static extern void SdfNamespaceEdit_index_set(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEdit_index_get")]
		public static extern int SdfNamespaceEdit_index_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfNamespaceEdit")]
		public static extern void delete_SdfNamespaceEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEditDetail__SWIG_0")]
		public static extern IntPtr new_SdfNamespaceEditDetail__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfNamespaceEditDetail__SWIG_1")]
		public static extern IntPtr new_SdfNamespaceEditDetail__SWIG_1(int jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetail_result_set")]
		public static extern void SdfNamespaceEditDetail_result_set(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetail_result_get")]
		public static extern int SdfNamespaceEditDetail_result_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetail_edit_set")]
		public static extern void SdfNamespaceEditDetail_edit_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetail_edit_get")]
		public static extern IntPtr SdfNamespaceEditDetail_edit_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetail_reason_set")]
		public static extern void SdfNamespaceEditDetail_reason_set(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfNamespaceEditDetail_reason_get")]
		public static extern string SdfNamespaceEditDetail_reason_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfNamespaceEditDetail")]
		public static extern void delete_SdfNamespaceEditDetail(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_CombineResult")]
		public static extern int CombineResult(int jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_CombineError")]
		public static extern int CombineError(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_CombineUnbatched")]
		public static extern int CombineUnbatched(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfBatchNamespaceEdit__SWIG_0")]
		public static extern IntPtr new_SdfBatchNamespaceEdit__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfBatchNamespaceEdit__SWIG_1")]
		public static extern IntPtr new_SdfBatchNamespaceEdit__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfBatchNamespaceEdit__SWIG_2")]
		public static extern IntPtr new_SdfBatchNamespaceEdit__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfBatchNamespaceEdit")]
		public static extern void delete_SdfBatchNamespaceEdit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfBatchNamespaceEdit_Add__SWIG_0")]
		public static extern void SdfBatchNamespaceEdit_Add__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfBatchNamespaceEdit_Add__SWIG_1")]
		public static extern void SdfBatchNamespaceEdit_Add__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfBatchNamespaceEdit_Add__SWIG_2")]
		public static extern void SdfBatchNamespaceEdit_Add__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfBatchNamespaceEdit_GetEdits")]
		public static extern IntPtr SdfBatchNamespaceEdit_GetEdits(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfOpaqueValue")]
		public static extern IntPtr new_SdfOpaqueValue();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfOpaqueValue")]
		public static extern void delete_SdfOpaqueValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_Clear")]
		public static extern void SdfPathVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_Add")]
		public static extern void SdfPathVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_size")]
		public static extern uint SdfPathVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_capacity")]
		public static extern uint SdfPathVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_reserve")]
		public static extern void SdfPathVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathVector__SWIG_0")]
		public static extern IntPtr new_SdfPathVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathVector__SWIG_1")]
		public static extern IntPtr new_SdfPathVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathVector__SWIG_2")]
		public static extern IntPtr new_SdfPathVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_getitemcopy")]
		public static extern IntPtr SdfPathVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_getitem")]
		public static extern IntPtr SdfPathVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_setitem")]
		public static extern void SdfPathVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_AddRange")]
		public static extern void SdfPathVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_GetRange")]
		public static extern IntPtr SdfPathVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_Insert")]
		public static extern void SdfPathVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_InsertRange")]
		public static extern void SdfPathVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_RemoveAt")]
		public static extern void SdfPathVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_RemoveRange")]
		public static extern void SdfPathVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_Repeat")]
		public static extern IntPtr SdfPathVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_Reverse__SWIG_0")]
		public static extern void SdfPathVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_Reverse__SWIG_1")]
		public static extern void SdfPathVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathVector_SetRange")]
		public static extern void SdfPathVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPathVector")]
		public static extern void delete_SdfPathVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathSet__SWIG_0")]
		public static extern IntPtr new_SdfPathSet__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathSet__SWIG_1")]
		public static extern IntPtr new_SdfPathSet__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_size")]
		public static extern uint SdfPathSet_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_empty")]
		public static extern bool SdfPathSet_empty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_Clear")]
		public static extern void SdfPathSet_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_Add")]
		public static extern bool SdfPathSet_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_Contains")]
		public static extern bool SdfPathSet_Contains(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_Remove")]
		public static extern bool SdfPathSet_Remove(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_getitem")]
		public static extern IntPtr SdfPathSet_getitem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_create_iterator_begin")]
		public static extern IntPtr SdfPathSet_create_iterator_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_get_next")]
		public static extern IntPtr SdfPathSet_get_next(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathSet_destroy_iterator")]
		public static extern void SdfPathSet_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPathSet")]
		public static extern void delete_SdfPathSet(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathPair__SWIG_0")]
		public static extern IntPtr new_SdfPathPair__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathPair__SWIG_1")]
		public static extern IntPtr new_SdfPathPair__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathPair__SWIG_2")]
		public static extern IntPtr new_SdfPathPair__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathPair_first_set")]
		public static extern void SdfPathPair_first_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathPair_first_get")]
		public static extern IntPtr SdfPathPair_first_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathPair_second_set")]
		public static extern void SdfPathPair_second_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathPair_second_get")]
		public static extern IntPtr SdfPathPair_second_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPathPair")]
		public static extern void delete_SdfPathPair(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_GetPathFromVector")]
		public static extern void GetPathFromVector(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_intrusive_ptr_add_ref")]
		public static extern void intrusive_ptr_add_ref(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_intrusive_ptr_release")]
		public static extern void intrusive_ptr_release(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Sdf_SizeofPrimPathNode_get")]
		public static extern uint Sdf_SizeofPrimPathNode_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Sdf_SizeofPropPathNode_get")]
		public static extern uint Sdf_SizeofPropPathNode_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetEmptyPath")]
		public static extern IntPtr SdfPath_GetEmptyPath();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AbsoluteRootPath")]
		public static extern IntPtr SdfPath_AbsoluteRootPath();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_ReflexiveRelativePath")]
		public static extern IntPtr SdfPath_ReflexiveRelativePath();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPath__SWIG_0")]
		public static extern IntPtr new_SdfPath__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPath__SWIG_1")]
		public static extern IntPtr new_SdfPath__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetPathElementCount")]
		public static extern uint SdfPath_GetPathElementCount(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsAbsolutePath")]
		public static extern bool SdfPath_IsAbsolutePath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsAbsoluteRootPath")]
		public static extern bool SdfPath_IsAbsoluteRootPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsPrimPath")]
		public static extern bool SdfPath_IsPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsAbsoluteRootOrPrimPath")]
		public static extern bool SdfPath_IsAbsoluteRootOrPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsRootPrimPath")]
		public static extern bool SdfPath_IsRootPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsPropertyPath")]
		public static extern bool SdfPath_IsPropertyPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsPrimPropertyPath")]
		public static extern bool SdfPath_IsPrimPropertyPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsNamespacedPropertyPath")]
		public static extern bool SdfPath_IsNamespacedPropertyPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsPrimVariantSelectionPath")]
		public static extern bool SdfPath_IsPrimVariantSelectionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsPrimOrPrimVariantSelectionPath")]
		public static extern bool SdfPath_IsPrimOrPrimVariantSelectionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_ContainsPrimVariantSelection")]
		public static extern bool SdfPath_ContainsPrimVariantSelection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_ContainsPropertyElements")]
		public static extern bool SdfPath_ContainsPropertyElements(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_ContainsTargetPath")]
		public static extern bool SdfPath_ContainsTargetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsRelationalAttributePath")]
		public static extern bool SdfPath_IsRelationalAttributePath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsTargetPath")]
		public static extern bool SdfPath_IsTargetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsMapperPath")]
		public static extern bool SdfPath_IsMapperPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsMapperArgPath")]
		public static extern bool SdfPath_IsMapperArgPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsExpressionPath")]
		public static extern bool SdfPath_IsExpressionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsEmpty")]
		public static extern bool SdfPath_IsEmpty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetAsToken")]
		public static extern IntPtr SdfPath_GetAsToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetToken")]
		public static extern IntPtr SdfPath_GetToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetAsString")]
		public static extern string SdfPath_GetAsString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetString")]
		public static extern string SdfPath_GetString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetText")]
		public static extern string SdfPath_GetText(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetPrefixes__SWIG_0")]
		public static extern IntPtr SdfPath_GetPrefixes__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetPrefixes__SWIG_1")]
		public static extern void SdfPath_GetPrefixes__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetAncestorsRange")]
		public static extern IntPtr SdfPath_GetAncestorsRange(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetName")]
		public static extern string SdfPath_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetNameToken")]
		public static extern IntPtr SdfPath_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetElementString")]
		public static extern string SdfPath_GetElementString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetElementToken")]
		public static extern IntPtr SdfPath_GetElementToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_ReplaceName")]
		public static extern IntPtr SdfPath_ReplaceName(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetTargetPath")]
		public static extern IntPtr SdfPath_GetTargetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetAllTargetPathsRecursively")]
		public static extern void SdfPath_GetAllTargetPathsRecursively(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetVariantSelection")]
		public static extern IntPtr SdfPath_GetVariantSelection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_HasPrefix")]
		public static extern bool SdfPath_HasPrefix(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetParentPath")]
		public static extern IntPtr SdfPath_GetParentPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetPrimPath")]
		public static extern IntPtr SdfPath_GetPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetPrimOrPrimVariantSelectionPath")]
		public static extern IntPtr SdfPath_GetPrimOrPrimVariantSelectionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetAbsoluteRootOrPrimPath")]
		public static extern IntPtr SdfPath_GetAbsoluteRootOrPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_StripAllVariantSelections")]
		public static extern IntPtr SdfPath_StripAllVariantSelections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendPath")]
		public static extern IntPtr SdfPath_AppendPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendChild")]
		public static extern IntPtr SdfPath_AppendChild(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendProperty")]
		public static extern IntPtr SdfPath_AppendProperty(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendVariantSelection")]
		public static extern IntPtr SdfPath_AppendVariantSelection(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendTarget")]
		public static extern IntPtr SdfPath_AppendTarget(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendRelationalAttribute")]
		public static extern IntPtr SdfPath_AppendRelationalAttribute(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_ReplaceTargetPath")]
		public static extern IntPtr SdfPath_ReplaceTargetPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendMapper")]
		public static extern IntPtr SdfPath_AppendMapper(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendMapperArg")]
		public static extern IntPtr SdfPath_AppendMapperArg(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendExpression")]
		public static extern IntPtr SdfPath_AppendExpression(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendElementString")]
		public static extern IntPtr SdfPath_AppendElementString(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_AppendElementToken")]
		public static extern IntPtr SdfPath_AppendElementToken(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_ReplacePrefix__SWIG_0")]
		public static extern IntPtr SdfPath_ReplacePrefix__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_ReplacePrefix__SWIG_1")]
		public static extern IntPtr SdfPath_ReplacePrefix__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetCommonPrefix")]
		public static extern IntPtr SdfPath_GetCommonPrefix(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_RemoveCommonSuffix__SWIG_0")]
		public static extern IntPtr SdfPath_RemoveCommonSuffix__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_RemoveCommonSuffix__SWIG_1")]
		public static extern IntPtr SdfPath_RemoveCommonSuffix__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_MakeAbsolutePath")]
		public static extern IntPtr SdfPath_MakeAbsolutePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_MakeRelativePath")]
		public static extern IntPtr SdfPath_MakeRelativePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsValidIdentifier")]
		public static extern bool SdfPath_IsValidIdentifier(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsValidNamespacedIdentifier")]
		public static extern bool SdfPath_IsValidNamespacedIdentifier(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_TokenizeIdentifier")]
		public static extern IntPtr SdfPath_TokenizeIdentifier(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_TokenizeIdentifierAsTokens")]
		public static extern IntPtr SdfPath_TokenizeIdentifierAsTokens(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_JoinIdentifier__SWIG_0")]
		public static extern string SdfPath_JoinIdentifier__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_JoinIdentifier__SWIG_1")]
		public static extern string SdfPath_JoinIdentifier__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_JoinIdentifier__SWIG_2")]
		public static extern string SdfPath_JoinIdentifier__SWIG_2(string jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_JoinIdentifier__SWIG_3")]
		public static extern string SdfPath_JoinIdentifier__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_StripNamespace__SWIG_0")]
		public static extern string SdfPath_StripNamespace__SWIG_0(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_StripNamespace__SWIG_1")]
		public static extern IntPtr SdfPath_StripNamespace__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_StripPrefixNamespace")]
		public static extern IntPtr SdfPath_StripPrefixNamespace(string jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsValidPathString__SWIG_0")]
		public static extern bool SdfPath_IsValidPathString__SWIG_0(string jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_IsValidPathString__SWIG_1")]
		public static extern bool SdfPath_IsValidPathString__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPath_Hash")]
		public static extern IntPtr new_SdfPath_Hash();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPath_Hash")]
		public static extern void delete_SdfPath_Hash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetHash")]
		public static extern uint SdfPath_GetHash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPath_FastLessThan")]
		public static extern IntPtr new_SdfPath_FastLessThan();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPath_FastLessThan")]
		public static extern void delete_SdfPath_FastLessThan(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetConciseRelativePaths")]
		public static extern IntPtr SdfPath_GetConciseRelativePaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_RemoveDescendentPaths")]
		public static extern void SdfPath_RemoveDescendentPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_RemoveAncestorPaths")]
		public static extern void SdfPath_RemoveAncestorPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Sdf_PathGetDebuggerPathText")]
		public static extern string Sdf_PathGetDebuggerPathText(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_Equals")]
		public static extern bool SdfPath_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPath_GetHashCode")]
		public static extern int SdfPath_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPath")]
		public static extern void delete_SdfPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathAncestorsRange")]
		public static extern IntPtr new_SdfPathAncestorsRange(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_GetPath")]
		public static extern IntPtr SdfPathAncestorsRange_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathAncestorsRange_iterator__SWIG_0")]
		public static extern IntPtr new_SdfPathAncestorsRange_iterator__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPathAncestorsRange_iterator__SWIG_1")]
		public static extern IntPtr new_SdfPathAncestorsRange_iterator__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator___ref__")]
		public static extern IntPtr SdfPathAncestorsRange_iterator___ref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator___deref__")]
		public static extern IntPtr SdfPathAncestorsRange_iterator___deref__(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPathAncestorsRange_iterator")]
		public static extern void delete_SdfPathAncestorsRange_iterator(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetPathElementCount")]
		public static extern uint SdfPathAncestorsRange_iterator_GetPathElementCount(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsAbsolutePath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsAbsolutePath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsAbsoluteRootPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsAbsoluteRootPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsPrimPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsAbsoluteRootOrPrimPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsAbsoluteRootOrPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsRootPrimPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsRootPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsPropertyPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsPropertyPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsPrimPropertyPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsPrimPropertyPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsNamespacedPropertyPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsNamespacedPropertyPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsPrimVariantSelectionPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsPrimVariantSelectionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsPrimOrPrimVariantSelectionPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsPrimOrPrimVariantSelectionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_ContainsPrimVariantSelection")]
		public static extern bool SdfPathAncestorsRange_iterator_ContainsPrimVariantSelection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_ContainsPropertyElements")]
		public static extern bool SdfPathAncestorsRange_iterator_ContainsPropertyElements(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_ContainsTargetPath")]
		public static extern bool SdfPathAncestorsRange_iterator_ContainsTargetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsRelationalAttributePath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsRelationalAttributePath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsTargetPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsTargetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsMapperPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsMapperPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsMapperArgPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsMapperArgPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsExpressionPath")]
		public static extern bool SdfPathAncestorsRange_iterator_IsExpressionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_IsEmpty")]
		public static extern bool SdfPathAncestorsRange_iterator_IsEmpty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetAsToken")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetAsToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetToken")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetAsString")]
		public static extern string SdfPathAncestorsRange_iterator_GetAsString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetString")]
		public static extern string SdfPathAncestorsRange_iterator_GetString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetText")]
		public static extern string SdfPathAncestorsRange_iterator_GetText(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetPrefixes__SWIG_0")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetPrefixes__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetPrefixes__SWIG_1")]
		public static extern void SdfPathAncestorsRange_iterator_GetPrefixes__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetAncestorsRange")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetAncestorsRange(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetName")]
		public static extern string SdfPathAncestorsRange_iterator_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetNameToken")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetNameToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetElementString")]
		public static extern string SdfPathAncestorsRange_iterator_GetElementString(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetElementToken")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetElementToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_ReplaceName")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_ReplaceName(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetTargetPath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetTargetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetAllTargetPathsRecursively")]
		public static extern void SdfPathAncestorsRange_iterator_GetAllTargetPathsRecursively(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetVariantSelection")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetVariantSelection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_HasPrefix")]
		public static extern bool SdfPathAncestorsRange_iterator_HasPrefix(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetParentPath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetParentPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetPrimPath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetPrimOrPrimVariantSelectionPath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetPrimOrPrimVariantSelectionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetAbsoluteRootOrPrimPath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetAbsoluteRootOrPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_StripAllVariantSelections")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_StripAllVariantSelections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendPath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendChild")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendChild(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendProperty")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendProperty(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendVariantSelection")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendVariantSelection(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendTarget")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendTarget(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendRelationalAttribute")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendRelationalAttribute(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_ReplaceTargetPath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_ReplaceTargetPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendMapper")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendMapper(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendMapperArg")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendMapperArg(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendExpression")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendExpression(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendElementString")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendElementString(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_AppendElementToken")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_AppendElementToken(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_ReplacePrefix__SWIG_0")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_ReplacePrefix__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_ReplacePrefix__SWIG_1")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_ReplacePrefix__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetCommonPrefix")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_GetCommonPrefix(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_RemoveCommonSuffix__SWIG_0")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_RemoveCommonSuffix__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_RemoveCommonSuffix__SWIG_1")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_RemoveCommonSuffix__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_MakeAbsolutePath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_MakeAbsolutePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_MakeRelativePath")]
		public static extern IntPtr SdfPathAncestorsRange_iterator_MakeRelativePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_iterator_GetHash")]
		public static extern uint SdfPathAncestorsRange_iterator_GetHash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_begin")]
		public static extern IntPtr SdfPathAncestorsRange_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathAncestorsRange_end")]
		public static extern IntPtr SdfPathAncestorsRange_end(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPathAncestorsRange")]
		public static extern void delete_SdfPathAncestorsRange(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Sdf_PathIdentity")]
		public static extern IntPtr new_Sdf_PathIdentity();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_Sdf_PathIdentity")]
		public static extern void delete_Sdf_PathIdentity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathFindLongestPrefix")]
		public static extern IntPtr SdfPathFindLongestPrefix(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPathFindLongestStrictPrefix")]
		public static extern IntPtr SdfPathFindLongestStrictPrefix(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPayload__SWIG_0")]
		public static extern IntPtr new_SdfPayload__SWIG_0(string jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPayload__SWIG_1")]
		public static extern IntPtr new_SdfPayload__SWIG_1(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPayload__SWIG_2")]
		public static extern IntPtr new_SdfPayload__SWIG_2(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPayload__SWIG_3")]
		public static extern IntPtr new_SdfPayload__SWIG_3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayload_GetAssetPath")]
		public static extern string SdfPayload_GetAssetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayload_SetAssetPath")]
		public static extern void SdfPayload_SetAssetPath(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayload_GetPrimPath")]
		public static extern IntPtr SdfPayload_GetPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayload_SetPrimPath")]
		public static extern void SdfPayload_SetPrimPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayload_GetLayerOffset")]
		public static extern IntPtr SdfPayload_GetLayerOffset(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayload_SetLayerOffset")]
		public static extern void SdfPayload_SetLayerOffset(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPayload")]
		public static extern void delete_SdfPayload(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_Clear")]
		public static extern void SdfTimeCodeVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_Add")]
		public static extern void SdfTimeCodeVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_size")]
		public static extern uint SdfTimeCodeVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_capacity")]
		public static extern uint SdfTimeCodeVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_reserve")]
		public static extern void SdfTimeCodeVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTimeCodeVector__SWIG_0")]
		public static extern IntPtr new_SdfTimeCodeVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTimeCodeVector__SWIG_1")]
		public static extern IntPtr new_SdfTimeCodeVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTimeCodeVector__SWIG_2")]
		public static extern IntPtr new_SdfTimeCodeVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_getitemcopy")]
		public static extern IntPtr SdfTimeCodeVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_getitem")]
		public static extern IntPtr SdfTimeCodeVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_setitem")]
		public static extern void SdfTimeCodeVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_AddRange")]
		public static extern void SdfTimeCodeVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_GetRange")]
		public static extern IntPtr SdfTimeCodeVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_Insert")]
		public static extern void SdfTimeCodeVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_InsertRange")]
		public static extern void SdfTimeCodeVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_RemoveAt")]
		public static extern void SdfTimeCodeVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_RemoveRange")]
		public static extern void SdfTimeCodeVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_Repeat")]
		public static extern IntPtr SdfTimeCodeVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_Reverse__SWIG_0")]
		public static extern void SdfTimeCodeVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_Reverse__SWIG_1")]
		public static extern void SdfTimeCodeVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCodeVector_SetRange")]
		public static extern void SdfTimeCodeVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfTimeCodeVector")]
		public static extern void delete_SdfTimeCodeVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTimeCode__SWIG_0")]
		public static extern IntPtr new_SdfTimeCode__SWIG_0(double jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTimeCode__SWIG_1")]
		public static extern IntPtr new_SdfTimeCode__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCode_GetHash")]
		public static extern uint SdfTimeCode_GetHash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTimeCode_Hash")]
		public static extern IntPtr new_SdfTimeCode_Hash();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfTimeCode_Hash")]
		public static extern void delete_SdfTimeCode_Hash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTimeCode_GetValue")]
		public static extern double SdfTimeCode_GetValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfTimeCode")]
		public static extern void delete_SdfTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTupleDimensions__SWIG_0")]
		public static extern IntPtr new_SdfTupleDimensions__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTupleDimensions__SWIG_1")]
		public static extern IntPtr new_SdfTupleDimensions__SWIG_1(uint jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTupleDimensions__SWIG_2")]
		public static extern IntPtr new_SdfTupleDimensions__SWIG_2(uint jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfTupleDimensions__SWIG_3")]
		public static extern IntPtr new_SdfTupleDimensions__SWIG_3(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTupleDimensions_d_set")]
		public static extern void SdfTupleDimensions_d_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTupleDimensions_d_get")]
		public static extern IntPtr SdfTupleDimensions_d_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTupleDimensions_size_set")]
		public static extern void SdfTupleDimensions_size_set(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfTupleDimensions_size_get")]
		public static extern uint SdfTupleDimensions_size_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfTupleDimensions")]
		public static extern void delete_SdfTupleDimensions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfValueTypeName")]
		public static extern IntPtr new_SdfValueTypeName();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetAsToken")]
		public static extern IntPtr SdfValueTypeName_GetAsToken(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetTfType")]
		public static extern IntPtr SdfValueTypeName_GetTfType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetCPPTypeName")]
		public static extern string SdfValueTypeName_GetCPPTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetRole")]
		public static extern IntPtr SdfValueTypeName_GetRole(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetDefaultValue")]
		public static extern IntPtr SdfValueTypeName_GetDefaultValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetScalarType")]
		public static extern IntPtr SdfValueTypeName_GetScalarType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetArrayType")]
		public static extern IntPtr SdfValueTypeName_GetArrayType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_IsScalar")]
		public static extern bool SdfValueTypeName_IsScalar(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_IsArray")]
		public static extern bool SdfValueTypeName_IsArray(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetDimensions")]
		public static extern IntPtr SdfValueTypeName_GetDimensions(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetHash")]
		public static extern uint SdfValueTypeName_GetHash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetAliasesAsTokens")]
		public static extern IntPtr SdfValueTypeName_GetAliasesAsTokens(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_Equals")]
		public static extern bool SdfValueTypeName_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfValueTypeName_GetHashCode")]
		public static extern int SdfValueTypeName_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfValueTypeName")]
		public static extern void delete_SdfValueTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfValueTypeNameHash")]
		public static extern IntPtr new_SdfValueTypeNameHash();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfValueTypeNameHash")]
		public static extern void delete_SdfValueTypeNameHash(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeBool")]
		public static extern IntPtr SdfGetValueTypeBool();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeUChar")]
		public static extern IntPtr SdfGetValueTypeUChar();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt")]
		public static extern IntPtr SdfGetValueTypeInt();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeUInt")]
		public static extern IntPtr SdfGetValueTypeUInt();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt64")]
		public static extern IntPtr SdfGetValueTypeInt64();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeUInt64")]
		public static extern IntPtr SdfGetValueTypeUInt64();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeHalf")]
		public static extern IntPtr SdfGetValueTypeHalf();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFloat")]
		public static extern IntPtr SdfGetValueTypeFloat();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeDouble")]
		public static extern IntPtr SdfGetValueTypeDouble();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTimeCode")]
		public static extern IntPtr SdfGetValueTypeTimeCode();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeString")]
		public static extern IntPtr SdfGetValueTypeString();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeToken")]
		public static extern IntPtr SdfGetValueTypeToken();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeAsset")]
		public static extern IntPtr SdfGetValueTypeAsset();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeOpaque")]
		public static extern IntPtr SdfGetValueTypeOpaque();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeGroup")]
		public static extern IntPtr SdfGetValueTypeGroup();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt2")]
		public static extern IntPtr SdfGetValueTypeInt2();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt3")]
		public static extern IntPtr SdfGetValueTypeInt3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt4")]
		public static extern IntPtr SdfGetValueTypeInt4();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeHalf2")]
		public static extern IntPtr SdfGetValueTypeHalf2();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeHalf3")]
		public static extern IntPtr SdfGetValueTypeHalf3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeHalf4")]
		public static extern IntPtr SdfGetValueTypeHalf4();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFloat2")]
		public static extern IntPtr SdfGetValueTypeFloat2();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFloat3")]
		public static extern IntPtr SdfGetValueTypeFloat3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFloat4")]
		public static extern IntPtr SdfGetValueTypeFloat4();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeDouble2")]
		public static extern IntPtr SdfGetValueTypeDouble2();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeDouble3")]
		public static extern IntPtr SdfGetValueTypeDouble3();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeDouble4")]
		public static extern IntPtr SdfGetValueTypeDouble4();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypePoint3h")]
		public static extern IntPtr SdfGetValueTypePoint3h();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypePoint3f")]
		public static extern IntPtr SdfGetValueTypePoint3f();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypePoint3d")]
		public static extern IntPtr SdfGetValueTypePoint3d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeVector3h")]
		public static extern IntPtr SdfGetValueTypeVector3h();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeVector3f")]
		public static extern IntPtr SdfGetValueTypeVector3f();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeVector3d")]
		public static extern IntPtr SdfGetValueTypeVector3d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeNormal3h")]
		public static extern IntPtr SdfGetValueTypeNormal3h();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeNormal3f")]
		public static extern IntPtr SdfGetValueTypeNormal3f();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeNormal3d")]
		public static extern IntPtr SdfGetValueTypeNormal3d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor3h")]
		public static extern IntPtr SdfGetValueTypeColor3h();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor3f")]
		public static extern IntPtr SdfGetValueTypeColor3f();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor3d")]
		public static extern IntPtr SdfGetValueTypeColor3d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor4h")]
		public static extern IntPtr SdfGetValueTypeColor4h();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor4f")]
		public static extern IntPtr SdfGetValueTypeColor4f();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor4d")]
		public static extern IntPtr SdfGetValueTypeColor4d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeQuath")]
		public static extern IntPtr SdfGetValueTypeQuath();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeQuatf")]
		public static extern IntPtr SdfGetValueTypeQuatf();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeQuatd")]
		public static extern IntPtr SdfGetValueTypeQuatd();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeMatrix2d")]
		public static extern IntPtr SdfGetValueTypeMatrix2d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeMatrix3d")]
		public static extern IntPtr SdfGetValueTypeMatrix3d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeMatrix4d")]
		public static extern IntPtr SdfGetValueTypeMatrix4d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFrame4d")]
		public static extern IntPtr SdfGetValueTypeFrame4d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord2h")]
		public static extern IntPtr SdfGetValueTypeTexCoord2h();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord2f")]
		public static extern IntPtr SdfGetValueTypeTexCoord2f();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord2d")]
		public static extern IntPtr SdfGetValueTypeTexCoord2d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord3h")]
		public static extern IntPtr SdfGetValueTypeTexCoord3h();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord3f")]
		public static extern IntPtr SdfGetValueTypeTexCoord3f();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord3d")]
		public static extern IntPtr SdfGetValueTypeTexCoord3d();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeBoolArray")]
		public static extern IntPtr SdfGetValueTypeBoolArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeUCharArray")]
		public static extern IntPtr SdfGetValueTypeUCharArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeIntArray")]
		public static extern IntPtr SdfGetValueTypeIntArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeUIntArray")]
		public static extern IntPtr SdfGetValueTypeUIntArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt64Array")]
		public static extern IntPtr SdfGetValueTypeInt64Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeUInt64Array")]
		public static extern IntPtr SdfGetValueTypeUInt64Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeHalfArray")]
		public static extern IntPtr SdfGetValueTypeHalfArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFloatArray")]
		public static extern IntPtr SdfGetValueTypeFloatArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeDoubleArray")]
		public static extern IntPtr SdfGetValueTypeDoubleArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTimeCodeArray")]
		public static extern IntPtr SdfGetValueTypeTimeCodeArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeStringArray")]
		public static extern IntPtr SdfGetValueTypeStringArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTokenArray")]
		public static extern IntPtr SdfGetValueTypeTokenArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeAssetArray")]
		public static extern IntPtr SdfGetValueTypeAssetArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt2Array")]
		public static extern IntPtr SdfGetValueTypeInt2Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt3Array")]
		public static extern IntPtr SdfGetValueTypeInt3Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeInt4Array")]
		public static extern IntPtr SdfGetValueTypeInt4Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeHalf2Array")]
		public static extern IntPtr SdfGetValueTypeHalf2Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeHalf3Array")]
		public static extern IntPtr SdfGetValueTypeHalf3Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeHalf4Array")]
		public static extern IntPtr SdfGetValueTypeHalf4Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFloat2Array")]
		public static extern IntPtr SdfGetValueTypeFloat2Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFloat3Array")]
		public static extern IntPtr SdfGetValueTypeFloat3Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFloat4Array")]
		public static extern IntPtr SdfGetValueTypeFloat4Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeDouble2Array")]
		public static extern IntPtr SdfGetValueTypeDouble2Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeDouble3Array")]
		public static extern IntPtr SdfGetValueTypeDouble3Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeDouble4Array")]
		public static extern IntPtr SdfGetValueTypeDouble4Array();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypePoint3hArray")]
		public static extern IntPtr SdfGetValueTypePoint3hArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypePoint3fArray")]
		public static extern IntPtr SdfGetValueTypePoint3fArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypePoint3dArray")]
		public static extern IntPtr SdfGetValueTypePoint3dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeVector3hArray")]
		public static extern IntPtr SdfGetValueTypeVector3hArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeVector3fArray")]
		public static extern IntPtr SdfGetValueTypeVector3fArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeVector3dArray")]
		public static extern IntPtr SdfGetValueTypeVector3dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeNormal3hArray")]
		public static extern IntPtr SdfGetValueTypeNormal3hArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeNormal3fArray")]
		public static extern IntPtr SdfGetValueTypeNormal3fArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeNormal3dArray")]
		public static extern IntPtr SdfGetValueTypeNormal3dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor3hArray")]
		public static extern IntPtr SdfGetValueTypeColor3hArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor3fArray")]
		public static extern IntPtr SdfGetValueTypeColor3fArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor3dArray")]
		public static extern IntPtr SdfGetValueTypeColor3dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor4hArray")]
		public static extern IntPtr SdfGetValueTypeColor4hArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor4fArray")]
		public static extern IntPtr SdfGetValueTypeColor4fArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeColor4dArray")]
		public static extern IntPtr SdfGetValueTypeColor4dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeQuathArray")]
		public static extern IntPtr SdfGetValueTypeQuathArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeQuatfArray")]
		public static extern IntPtr SdfGetValueTypeQuatfArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeQuatdArray")]
		public static extern IntPtr SdfGetValueTypeQuatdArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeMatrix2dArray")]
		public static extern IntPtr SdfGetValueTypeMatrix2dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeMatrix3dArray")]
		public static extern IntPtr SdfGetValueTypeMatrix3dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeMatrix4dArray")]
		public static extern IntPtr SdfGetValueTypeMatrix4dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeFrame4dArray")]
		public static extern IntPtr SdfGetValueTypeFrame4dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord2hArray")]
		public static extern IntPtr SdfGetValueTypeTexCoord2hArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord2fArray")]
		public static extern IntPtr SdfGetValueTypeTexCoord2fArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord2dArray")]
		public static extern IntPtr SdfGetValueTypeTexCoord2dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord3hArray")]
		public static extern IntPtr SdfGetValueTypeTexCoord3hArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord3fArray")]
		public static extern IntPtr SdfGetValueTypeTexCoord3fArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfGetValueTypeTexCoord3dArray")]
		public static extern IntPtr SdfGetValueTypeTexCoord3dArray();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPrimSpec_SWIGUpcast")]
		public static extern IntPtr SdfPrimSpec_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPropertySpec_SWIGUpcast")]
		public static extern IntPtr SdfPropertySpec_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfAttributeSpec_SWIGUpcast")]
		public static extern IntPtr SdfAttributeSpec_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfRelationshipSpec_SWIGUpcast")]
		public static extern IntPtr SdfRelationshipSpec_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSetSpec_SWIGUpcast")]
		public static extern IntPtr SdfVariantSetSpec_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfVariantSpec_SWIGSmartPtrUpcast")]
		public static extern IntPtr SdfVariantSpec_SWIGSmartPtrUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Sdf_FileFormatFactoryBase_SWIGUpcast")]
		public static extern IntPtr Sdf_FileFormatFactoryBase_SWIGUpcast(IntPtr jarg1);
	}
}
