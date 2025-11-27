using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdUtilsPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_UsdUtils(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_UsdUtils(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static UsdUtilsPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCopyLayerMetadata__SWIG_0")]
		public static extern bool UsdUtilsCopyLayerMetadata__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCopyLayerMetadata__SWIG_1")]
		public static extern bool UsdUtilsCopyLayerMetadata__SWIG_1(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCopyLayerMetadata__SWIG_2")]
		public static extern bool UsdUtilsCopyLayerMetadata__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_0")]
		public static extern bool UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, double jarg5, uint jarg6, uint jarg7, HandleRef jarg8);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_1")]
		public static extern bool UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, double jarg5, uint jarg6, uint jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_2")]
		public static extern bool UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, double jarg5, uint jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_3")]
		public static extern bool UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_4")]
		public static extern bool UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsAuthorCollection__SWIG_0")]
		public static extern IntPtr UsdUtilsAuthorCollection__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsAuthorCollection__SWIG_1")]
		public static extern IntPtr UsdUtilsAuthorCollection__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCreateCollections__SWIG_0")]
		public static extern IntPtr UsdUtilsCreateCollections__SWIG_0(HandleRef jarg1, HandleRef jarg2, double jarg3, uint jarg4, uint jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCreateCollections__SWIG_1")]
		public static extern IntPtr UsdUtilsCreateCollections__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3, uint jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCreateCollections__SWIG_2")]
		public static extern IntPtr UsdUtilsCreateCollections__SWIG_2(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCreateCollections__SWIG_3")]
		public static extern IntPtr UsdUtilsCreateCollections__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetDirtyLayers__SWIG_0")]
		public static extern IntPtr UsdUtilsGetDirtyLayers__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetDirtyLayers__SWIG_1")]
		public static extern IntPtr UsdUtilsGetDirtyLayers__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsExtractExternalReferences")]
		public static extern void UsdUtilsExtractExternalReferences(string jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCreateNewUsdzPackage__SWIG_0")]
		public static extern bool UsdUtilsCreateNewUsdzPackage__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCreateNewUsdzPackage__SWIG_1")]
		public static extern bool UsdUtilsCreateNewUsdzPackage__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCreateNewARKitUsdzPackage__SWIG_0")]
		public static extern bool UsdUtilsCreateNewARKitUsdzPackage__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsCreateNewARKitUsdzPackage__SWIG_1")]
		public static extern bool UsdUtilsCreateNewARKitUsdzPackage__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsComputeAllDependencies")]
		public static extern bool UsdUtilsComputeAllDependencies(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsModifyAssetPaths")]
		public static extern void UsdUtilsModifyAssetPaths(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsFlattenLayerStack__SWIG_0")]
		public static extern IntPtr UsdUtilsFlattenLayerStack__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsFlattenLayerStack__SWIG_1")]
		public static extern IntPtr UsdUtilsFlattenLayerStack__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsFlattenLayerStack__SWIG_2")]
		public static extern IntPtr UsdUtilsFlattenLayerStack__SWIG_2(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsFlattenLayerStack__SWIG_3")]
		public static extern IntPtr UsdUtilsFlattenLayerStack__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsFlattenLayerStackResolveAssetPath")]
		public static extern string UsdUtilsFlattenLayerStackResolveAssetPath(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsComputeUsdStageStats__SWIG_0")]
		public static extern IntPtr UsdUtilsComputeUsdStageStats__SWIG_0(string jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsComputeUsdStageStats__SWIG_1")]
		public static extern uint UsdUtilsComputeUsdStageStats__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_USD_FORCE_DEFAULT_MATERIALS_SCOPE_NAME_set")]
		public static extern void USD_FORCE_DEFAULT_MATERIALS_SCOPE_NAME_set(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_USD_FORCE_DEFAULT_MATERIALS_SCOPE_NAME_get")]
		public static extern IntPtr USD_FORCE_DEFAULT_MATERIALS_SCOPE_NAME_get();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetAlphaAttributeNameForColor")]
		public static extern IntPtr UsdUtilsGetAlphaAttributeNameForColor(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetModelNameFromRootLayer")]
		public static extern IntPtr UsdUtilsGetModelNameFromRootLayer(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetRegisteredVariantSets")]
		public static extern IntPtr UsdUtilsGetRegisteredVariantSets();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsRegisterVariantSet")]
		public static extern void UsdUtilsRegisterVariantSet(string jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetPrimAtPathWithForwarding")]
		public static extern IntPtr UsdUtilsGetPrimAtPathWithForwarding(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsUninstancePrimAtPath")]
		public static extern IntPtr UsdUtilsUninstancePrimAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetPrimaryUVSetName")]
		public static extern IntPtr UsdUtilsGetPrimaryUVSetName();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetPrefName")]
		public static extern IntPtr UsdUtilsGetPrefName();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetMaterialsScopeName__SWIG_0")]
		public static extern IntPtr UsdUtilsGetMaterialsScopeName__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetMaterialsScopeName__SWIG_1")]
		public static extern IntPtr UsdUtilsGetMaterialsScopeName__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetPrimaryCameraName__SWIG_0")]
		public static extern IntPtr UsdUtilsGetPrimaryCameraName__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGetPrimaryCameraName__SWIG_1")]
		public static extern IntPtr UsdUtilsGetPrimaryCameraName__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsRegisteredVariantSet_name_get")]
		public static extern string UsdUtilsRegisteredVariantSet_name_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsRegisteredVariantSet_selectionExportPolicy_get")]
		public static extern int UsdUtilsRegisteredVariantSet_selectionExportPolicy_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdUtilsRegisteredVariantSet")]
		public static extern IntPtr new_UsdUtilsRegisteredVariantSet(string jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdUtilsRegisteredVariantSet")]
		public static extern void delete_UsdUtilsRegisteredVariantSet(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdUtilsSparseAttrValueWriter__SWIG_0")]
		public static extern IntPtr new_UsdUtilsSparseAttrValueWriter__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdUtilsSparseAttrValueWriter__SWIG_1")]
		public static extern IntPtr new_UsdUtilsSparseAttrValueWriter__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsSparseAttrValueWriter_SetTimeSample__SWIG_0")]
		public static extern bool UsdUtilsSparseAttrValueWriter_SetTimeSample__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsSparseAttrValueWriter_GetAttr")]
		public static extern IntPtr UsdUtilsSparseAttrValueWriter_GetAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdUtilsSparseAttrValueWriter")]
		public static extern void delete_UsdUtilsSparseAttrValueWriter(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsSparseValueWriter_SetAttribute__SWIG_0")]
		public static extern bool UsdUtilsSparseValueWriter_SetAttribute__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsSparseValueWriter_SetAttribute__SWIG_1")]
		public static extern bool UsdUtilsSparseValueWriter_SetAttribute__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsSparseValueWriter_Clear")]
		public static extern void UsdUtilsSparseValueWriter_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsSparseValueWriter_GetSparseAttrValueWriters")]
		public static extern IntPtr UsdUtilsSparseValueWriter_GetSparseAttrValueWriters(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdUtilsSparseValueWriter")]
		public static extern IntPtr new_UsdUtilsSparseValueWriter();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdUtilsSparseValueWriter")]
		public static extern void delete_UsdUtilsSparseValueWriter(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_Clear")]
		public static extern void SdfLayerPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_Add")]
		public static extern void SdfLayerPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_size")]
		public static extern uint SdfLayerPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_capacity")]
		public static extern uint SdfLayerPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_reserve")]
		public static extern void SdfLayerPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfLayerPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfLayerPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfLayerPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfLayerPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfLayerPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfLayerPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_getitemcopy")]
		public static extern IntPtr SdfLayerPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_getitem")]
		public static extern IntPtr SdfLayerPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_setitem")]
		public static extern void SdfLayerPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_AddRange")]
		public static extern void SdfLayerPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_GetRange")]
		public static extern IntPtr SdfLayerPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_Insert")]
		public static extern void SdfLayerPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_InsertRange")]
		public static extern void SdfLayerPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_RemoveAt")]
		public static extern void SdfLayerPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_RemoveRange")]
		public static extern void SdfLayerPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_Repeat")]
		public static extern IntPtr SdfLayerPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_Reverse__SWIG_0")]
		public static extern void SdfLayerPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_Reverse__SWIG_1")]
		public static extern void SdfLayerPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerPtrVector_SetRange")]
		public static extern void SdfLayerPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_SdfLayerPtrVector")]
		public static extern void delete_SdfLayerPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_Clear")]
		public static extern void SdfLayerConstPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_Add")]
		public static extern void SdfLayerConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_size")]
		public static extern uint SdfLayerConstPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_capacity")]
		public static extern uint SdfLayerConstPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_reserve")]
		public static extern void SdfLayerConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfLayerConstPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfLayerConstPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfLayerConstPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfLayerConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfLayerConstPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfLayerConstPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_getitemcopy")]
		public static extern IntPtr SdfLayerConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_getitem")]
		public static extern IntPtr SdfLayerConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_setitem")]
		public static extern void SdfLayerConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_AddRange")]
		public static extern void SdfLayerConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_GetRange")]
		public static extern IntPtr SdfLayerConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_Insert")]
		public static extern void SdfLayerConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_InsertRange")]
		public static extern void SdfLayerConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_RemoveAt")]
		public static extern void SdfLayerConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_RemoveRange")]
		public static extern void SdfLayerConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_Repeat")]
		public static extern IntPtr SdfLayerConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_Reverse__SWIG_0")]
		public static extern void SdfLayerConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_Reverse__SWIG_1")]
		public static extern void SdfLayerConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfLayerConstPtrVector_SetRange")]
		public static extern void SdfLayerConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_SdfLayerConstPtrVector")]
		public static extern void delete_SdfLayerConstPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStageCache_Get")]
		public static extern IntPtr UsdUtilsStageCache_Get();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStageCache_GetSessionLayerForVariantSelections")]
		public static extern IntPtr UsdUtilsStageCache_GetSessionLayerForVariantSelections(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdUtilsStageCache")]
		public static extern IntPtr new_UsdUtilsStageCache();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdUtilsStageCache")]
		public static extern void delete_UsdUtilsStageCache(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchLayers")]
		public static extern void UsdUtilsStitchLayers(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchInfo")]
		public static extern void UsdUtilsStitchInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClips__SWIG_0")]
		public static extern bool UsdUtilsStitchClips__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4, double jarg5, bool jarg6, HandleRef jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClips__SWIG_1")]
		public static extern bool UsdUtilsStitchClips__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4, double jarg5, bool jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClips__SWIG_2")]
		public static extern bool UsdUtilsStitchClips__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClips__SWIG_3")]
		public static extern bool UsdUtilsStitchClips__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClips__SWIG_4")]
		public static extern bool UsdUtilsStitchClips__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClipsTopology")]
		public static extern bool UsdUtilsStitchClipsTopology(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClipsManifest")]
		public static extern bool UsdUtilsStitchClipsManifest(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClipsTemplate__SWIG_0")]
		public static extern bool UsdUtilsStitchClipsTemplate__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, string jarg5, double jarg6, double jarg7, double jarg8, double jarg9, bool jarg10, HandleRef jarg11);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClipsTemplate__SWIG_1")]
		public static extern bool UsdUtilsStitchClipsTemplate__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, string jarg5, double jarg6, double jarg7, double jarg8, double jarg9, bool jarg10);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClipsTemplate__SWIG_2")]
		public static extern bool UsdUtilsStitchClipsTemplate__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, string jarg5, double jarg6, double jarg7, double jarg8, double jarg9);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsStitchClipsTemplate__SWIG_3")]
		public static extern bool UsdUtilsStitchClipsTemplate__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, string jarg5, double jarg6, double jarg7, double jarg8);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGenerateClipTopologyName")]
		public static extern string UsdUtilsGenerateClipTopologyName(string jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdUtilsGenerateClipManifestName")]
		public static extern string UsdUtilsGenerateClipManifestName(string jarg1);
	}
}
