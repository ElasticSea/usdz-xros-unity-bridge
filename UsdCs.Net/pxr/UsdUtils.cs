using System;

namespace pxr
{
	public class UsdUtils
	{
		public static SWIGTYPE_p_TfEnvSettingT_bool_t USD_FORCE_DEFAULT_MATERIALS_SCOPE_NAME
		{
			get
			{
				SWIGTYPE_p_TfEnvSettingT_bool_t result = new SWIGTYPE_p_TfEnvSettingT_bool_t(UsdUtilsPINVOKE.USD_FORCE_DEFAULT_MATERIALS_SCOPE_NAME_get(), futureUse: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				UsdUtilsPINVOKE.USD_FORCE_DEFAULT_MATERIALS_SCOPE_NAME_set(SWIGTYPE_p_TfEnvSettingT_bool_t.getCPtr(value));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public static bool UsdUtilsCopyLayerMetadata(SdfLayerHandle source, SdfLayerHandle destination, bool skipSublayers, bool bakeUnauthoredFallbacks)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsCopyLayerMetadata__SWIG_0(SdfLayerHandle.getCPtr(source), SdfLayerHandle.getCPtr(destination), skipSublayers, bakeUnauthoredFallbacks);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsCopyLayerMetadata(SdfLayerHandle source, SdfLayerHandle destination, bool skipSublayers)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsCopyLayerMetadata__SWIG_1(SdfLayerHandle.getCPtr(source), SdfLayerHandle.getCPtr(destination), skipSublayers);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsCopyLayerMetadata(SdfLayerHandle source, SdfLayerHandle destination)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsCopyLayerMetadata__SWIG_2(SdfLayerHandle.getCPtr(source), SdfLayerHandle.getCPtr(destination));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsComputeCollectionIncludesAndExcludes(SdfPathSet includedRootPaths, UsdStage usdStage, SdfPathVector pathsToInclude, SdfPathVector pathsToExclude, double minInclusionRatio, uint maxNumExcludesBelowInclude, uint minIncludeExcludeCollectionSize, SWIGTYPE_p_TfHashSetT_SdfPath_SdfPath__Hash_t pathsToIgnore)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_0(SdfPathSet.getCPtr(includedRootPaths), UsdStage.getCPtr(usdStage), SdfPathVector.getCPtr(pathsToInclude), SdfPathVector.getCPtr(pathsToExclude), minInclusionRatio, maxNumExcludesBelowInclude, minIncludeExcludeCollectionSize, SWIGTYPE_p_TfHashSetT_SdfPath_SdfPath__Hash_t.getCPtr(pathsToIgnore));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsComputeCollectionIncludesAndExcludes(SdfPathSet includedRootPaths, UsdStage usdStage, SdfPathVector pathsToInclude, SdfPathVector pathsToExclude, double minInclusionRatio, uint maxNumExcludesBelowInclude, uint minIncludeExcludeCollectionSize)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_1(SdfPathSet.getCPtr(includedRootPaths), UsdStage.getCPtr(usdStage), SdfPathVector.getCPtr(pathsToInclude), SdfPathVector.getCPtr(pathsToExclude), minInclusionRatio, maxNumExcludesBelowInclude, minIncludeExcludeCollectionSize);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsComputeCollectionIncludesAndExcludes(SdfPathSet includedRootPaths, UsdStage usdStage, SdfPathVector pathsToInclude, SdfPathVector pathsToExclude, double minInclusionRatio, uint maxNumExcludesBelowInclude)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_2(SdfPathSet.getCPtr(includedRootPaths), UsdStage.getCPtr(usdStage), SdfPathVector.getCPtr(pathsToInclude), SdfPathVector.getCPtr(pathsToExclude), minInclusionRatio, maxNumExcludesBelowInclude);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsComputeCollectionIncludesAndExcludes(SdfPathSet includedRootPaths, UsdStage usdStage, SdfPathVector pathsToInclude, SdfPathVector pathsToExclude, double minInclusionRatio)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_3(SdfPathSet.getCPtr(includedRootPaths), UsdStage.getCPtr(usdStage), SdfPathVector.getCPtr(pathsToInclude), SdfPathVector.getCPtr(pathsToExclude), minInclusionRatio);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsComputeCollectionIncludesAndExcludes(SdfPathSet includedRootPaths, UsdStage usdStage, SdfPathVector pathsToInclude, SdfPathVector pathsToExclude)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsComputeCollectionIncludesAndExcludes__SWIG_4(SdfPathSet.getCPtr(includedRootPaths), UsdStage.getCPtr(usdStage), SdfPathVector.getCPtr(pathsToInclude), SdfPathVector.getCPtr(pathsToExclude));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPI UsdUtilsAuthorCollection(TfToken collectionName, UsdPrim usdPrim, SdfPathVector pathsToInclude, SdfPathVector pathsToExclude)
		{
			UsdCollectionAPI result = new UsdCollectionAPI(UsdUtilsPINVOKE.UsdUtilsAuthorCollection__SWIG_0(TfToken.getCPtr(collectionName), UsdPrim.getCPtr(usdPrim), SdfPathVector.getCPtr(pathsToInclude), SdfPathVector.getCPtr(pathsToExclude)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPI UsdUtilsAuthorCollection(TfToken collectionName, UsdPrim usdPrim, SdfPathVector pathsToInclude)
		{
			UsdCollectionAPI result = new UsdCollectionAPI(UsdUtilsPINVOKE.UsdUtilsAuthorCollection__SWIG_1(TfToken.getCPtr(collectionName), UsdPrim.getCPtr(usdPrim), SdfPathVector.getCPtr(pathsToInclude)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPIVector UsdUtilsCreateCollections(SWIGTYPE_p_std__vectorT_std__pairT_TfToken_std__setT_SdfPath_t_t_t assignments, UsdPrim usdPrim, double minInclusionRatio, uint maxNumExcludesBelowInclude, uint minIncludeExcludeCollectionSize)
		{
			UsdCollectionAPIVector result = new UsdCollectionAPIVector(UsdUtilsPINVOKE.UsdUtilsCreateCollections__SWIG_0(SWIGTYPE_p_std__vectorT_std__pairT_TfToken_std__setT_SdfPath_t_t_t.getCPtr(assignments), UsdPrim.getCPtr(usdPrim), minInclusionRatio, maxNumExcludesBelowInclude, minIncludeExcludeCollectionSize), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPIVector UsdUtilsCreateCollections(SWIGTYPE_p_std__vectorT_std__pairT_TfToken_std__setT_SdfPath_t_t_t assignments, UsdPrim usdPrim, double minInclusionRatio, uint maxNumExcludesBelowInclude)
		{
			UsdCollectionAPIVector result = new UsdCollectionAPIVector(UsdUtilsPINVOKE.UsdUtilsCreateCollections__SWIG_1(SWIGTYPE_p_std__vectorT_std__pairT_TfToken_std__setT_SdfPath_t_t_t.getCPtr(assignments), UsdPrim.getCPtr(usdPrim), minInclusionRatio, maxNumExcludesBelowInclude), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPIVector UsdUtilsCreateCollections(SWIGTYPE_p_std__vectorT_std__pairT_TfToken_std__setT_SdfPath_t_t_t assignments, UsdPrim usdPrim, double minInclusionRatio)
		{
			UsdCollectionAPIVector result = new UsdCollectionAPIVector(UsdUtilsPINVOKE.UsdUtilsCreateCollections__SWIG_2(SWIGTYPE_p_std__vectorT_std__pairT_TfToken_std__setT_SdfPath_t_t_t.getCPtr(assignments), UsdPrim.getCPtr(usdPrim), minInclusionRatio), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPIVector UsdUtilsCreateCollections(SWIGTYPE_p_std__vectorT_std__pairT_TfToken_std__setT_SdfPath_t_t_t assignments, UsdPrim usdPrim)
		{
			UsdCollectionAPIVector result = new UsdCollectionAPIVector(UsdUtilsPINVOKE.UsdUtilsCreateCollections__SWIG_3(SWIGTYPE_p_std__vectorT_std__pairT_TfToken_std__setT_SdfPath_t_t_t.getCPtr(assignments), UsdPrim.getCPtr(usdPrim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandleVector UsdUtilsGetDirtyLayers(UsdStage stage, bool includeClipLayers)
		{
			return new SdfLayerHandleVector(UsdUtilsPINVOKE.UsdUtilsGetDirtyLayers__SWIG_0(UsdStage.getCPtr(stage), includeClipLayers), cMemoryOwn: true);
		}

		public static SdfLayerHandleVector UsdUtilsGetDirtyLayers(UsdStage stage)
		{
			return new SdfLayerHandleVector(UsdUtilsPINVOKE.UsdUtilsGetDirtyLayers__SWIG_1(UsdStage.getCPtr(stage)), cMemoryOwn: true);
		}

		public static void UsdUtilsExtractExternalReferences(string filePath, StdStringVector subLayers, StdStringVector references, StdStringVector payloads)
		{
			UsdUtilsPINVOKE.UsdUtilsExtractExternalReferences(filePath, StdStringVector.getCPtr(subLayers), StdStringVector.getCPtr(references), StdStringVector.getCPtr(payloads));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool UsdUtilsCreateNewUsdzPackage(SdfAssetPath assetPath, string usdzFilePath, string firstLayerName)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsCreateNewUsdzPackage__SWIG_0(SdfAssetPath.getCPtr(assetPath), usdzFilePath, firstLayerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsCreateNewUsdzPackage(SdfAssetPath assetPath, string usdzFilePath)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsCreateNewUsdzPackage__SWIG_1(SdfAssetPath.getCPtr(assetPath), usdzFilePath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsCreateNewARKitUsdzPackage(SdfAssetPath assetPath, string usdzFilePath, string firstLayerName)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsCreateNewARKitUsdzPackage__SWIG_0(SdfAssetPath.getCPtr(assetPath), usdzFilePath, firstLayerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsCreateNewARKitUsdzPackage(SdfAssetPath assetPath, string usdzFilePath)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsCreateNewARKitUsdzPackage__SWIG_1(SdfAssetPath.getCPtr(assetPath), usdzFilePath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsComputeAllDependencies(SdfAssetPath assetPath, SdfLayerRefPtrVector layers, StdStringVector assets, StdStringVector unresolvedPaths)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsComputeAllDependencies(SdfAssetPath.getCPtr(assetPath), SdfLayerRefPtrVector.getCPtr(layers), StdStringVector.getCPtr(assets), StdStringVector.getCPtr(unresolvedPaths));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void UsdUtilsModifyAssetPaths(SdfLayerHandle layer, SWIGTYPE_p_std__functionT_std__string_fstd__string_const_RF_t modifyFn)
		{
			UsdUtilsPINVOKE.UsdUtilsModifyAssetPaths(SdfLayerHandle.getCPtr(layer), SWIGTYPE_p_std__functionT_std__string_fstd__string_const_RF_t.getCPtr(modifyFn));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfLayerHandle UsdUtilsFlattenLayerStack(UsdStage stage, string tag)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.UsdUtilsFlattenLayerStack__SWIG_0(UsdStage.getCPtr(stage), tag);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandle UsdUtilsFlattenLayerStack(UsdStage stage)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.UsdUtilsFlattenLayerStack__SWIG_1(UsdStage.getCPtr(stage));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandle UsdUtilsFlattenLayerStack(UsdStage stage, SWIGTYPE_p_std__functionT_std__string_fSdfLayerHandle_const_R_std__string_const_RF_t resolveAssetPathFn, string tag)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.UsdUtilsFlattenLayerStack__SWIG_2(UsdStage.getCPtr(stage), SWIGTYPE_p_std__functionT_std__string_fSdfLayerHandle_const_R_std__string_const_RF_t.getCPtr(resolveAssetPathFn), tag);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandle UsdUtilsFlattenLayerStack(UsdStage stage, SWIGTYPE_p_std__functionT_std__string_fSdfLayerHandle_const_R_std__string_const_RF_t resolveAssetPathFn)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.UsdUtilsFlattenLayerStack__SWIG_3(UsdStage.getCPtr(stage), SWIGTYPE_p_std__functionT_std__string_fSdfLayerHandle_const_R_std__string_const_RF_t.getCPtr(resolveAssetPathFn));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string UsdUtilsFlattenLayerStackResolveAssetPath(SdfLayerHandle sourceLayer, string assetPath)
		{
			string result = UsdUtilsPINVOKE.UsdUtilsFlattenLayerStackResolveAssetPath(SdfLayerHandle.getCPtr(sourceLayer), assetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage UsdUtilsComputeUsdStageStats(string rootLayerPath, VtDictionary stats)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.UsdUtilsComputeUsdStageStats__SWIG_0(rootLayerPath, VtDictionary.getCPtr(stats));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static uint UsdUtilsComputeUsdStageStats(UsdStage stage, VtDictionary stats)
		{
			uint result = UsdUtilsPINVOKE.UsdUtilsComputeUsdStageStats__SWIG_1(UsdStage.getCPtr(stage), VtDictionary.getCPtr(stats));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken UsdUtilsGetAlphaAttributeNameForColor(TfToken colorAttrName)
		{
			TfToken result = new TfToken(UsdUtilsPINVOKE.UsdUtilsGetAlphaAttributeNameForColor(TfToken.getCPtr(colorAttrName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken UsdUtilsGetModelNameFromRootLayer(SdfLayerHandle rootLayer)
		{
			TfToken result = new TfToken(UsdUtilsPINVOKE.UsdUtilsGetModelNameFromRootLayer(SdfLayerHandle.getCPtr(rootLayer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_std__setT_UsdUtilsRegisteredVariantSet_t UsdUtilsGetRegisteredVariantSets()
		{
			return new SWIGTYPE_p_std__setT_UsdUtilsRegisteredVariantSet_t(UsdUtilsPINVOKE.UsdUtilsGetRegisteredVariantSets(), futureUse: false);
		}

		public static void UsdUtilsRegisterVariantSet(string variantSetName, UsdUtilsRegisteredVariantSet.SelectionExportPolicy selectionExportPolicy)
		{
			UsdUtilsPINVOKE.UsdUtilsRegisterVariantSet(variantSetName, (int)selectionExportPolicy);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdPrim UsdUtilsGetPrimAtPathWithForwarding(UsdStage stage, SdfPath path)
		{
			UsdPrim result = new UsdPrim(UsdUtilsPINVOKE.UsdUtilsGetPrimAtPathWithForwarding(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdPrim UsdUtilsUninstancePrimAtPath(UsdStage stage, SdfPath path)
		{
			UsdPrim result = new UsdPrim(UsdUtilsPINVOKE.UsdUtilsUninstancePrimAtPath(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken UsdUtilsGetPrimaryUVSetName()
		{
			return new TfToken(UsdUtilsPINVOKE.UsdUtilsGetPrimaryUVSetName(), cMemoryOwn: false);
		}

		public static TfToken UsdUtilsGetPrefName()
		{
			return new TfToken(UsdUtilsPINVOKE.UsdUtilsGetPrefName(), cMemoryOwn: false);
		}

		public static TfToken UsdUtilsGetMaterialsScopeName(bool forceDefault)
		{
			return new TfToken(UsdUtilsPINVOKE.UsdUtilsGetMaterialsScopeName__SWIG_0(forceDefault), cMemoryOwn: true);
		}

		public static TfToken UsdUtilsGetMaterialsScopeName()
		{
			return new TfToken(UsdUtilsPINVOKE.UsdUtilsGetMaterialsScopeName__SWIG_1(), cMemoryOwn: true);
		}

		public static TfToken UsdUtilsGetPrimaryCameraName(bool forceDefault)
		{
			return new TfToken(UsdUtilsPINVOKE.UsdUtilsGetPrimaryCameraName__SWIG_0(forceDefault), cMemoryOwn: true);
		}

		public static TfToken UsdUtilsGetPrimaryCameraName()
		{
			return new TfToken(UsdUtilsPINVOKE.UsdUtilsGetPrimaryCameraName__SWIG_1(), cMemoryOwn: true);
		}

		public static void UsdUtilsStitchLayers(SdfLayerHandle strongLayer, SdfLayerHandle weakLayer)
		{
			UsdUtilsPINVOKE.UsdUtilsStitchLayers(SdfLayerHandle.getCPtr(strongLayer), SdfLayerHandle.getCPtr(weakLayer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void UsdUtilsStitchInfo(SdfSpecHandle strongObj, SdfSpecHandle weakObj)
		{
			UsdUtilsPINVOKE.UsdUtilsStitchInfo(SdfSpecHandle.getCPtr(strongObj), SdfSpecHandle.getCPtr(weakObj));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool UsdUtilsStitchClips(SdfLayerHandle resultLayer, StdStringVector clipLayerFiles, SdfPath clipPath, double startTimeCode, double endTimeCode, bool interpolateMissingClipValues, TfToken clipSet)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClips__SWIG_0(SdfLayerHandle.getCPtr(resultLayer), StdStringVector.getCPtr(clipLayerFiles), SdfPath.getCPtr(clipPath), startTimeCode, endTimeCode, interpolateMissingClipValues, TfToken.getCPtr(clipSet));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClips(SdfLayerHandle resultLayer, StdStringVector clipLayerFiles, SdfPath clipPath, double startTimeCode, double endTimeCode, bool interpolateMissingClipValues)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClips__SWIG_1(SdfLayerHandle.getCPtr(resultLayer), StdStringVector.getCPtr(clipLayerFiles), SdfPath.getCPtr(clipPath), startTimeCode, endTimeCode, interpolateMissingClipValues);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClips(SdfLayerHandle resultLayer, StdStringVector clipLayerFiles, SdfPath clipPath, double startTimeCode, double endTimeCode)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClips__SWIG_2(SdfLayerHandle.getCPtr(resultLayer), StdStringVector.getCPtr(clipLayerFiles), SdfPath.getCPtr(clipPath), startTimeCode, endTimeCode);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClips(SdfLayerHandle resultLayer, StdStringVector clipLayerFiles, SdfPath clipPath, double startTimeCode)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClips__SWIG_3(SdfLayerHandle.getCPtr(resultLayer), StdStringVector.getCPtr(clipLayerFiles), SdfPath.getCPtr(clipPath), startTimeCode);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClips(SdfLayerHandle resultLayer, StdStringVector clipLayerFiles, SdfPath clipPath)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClips__SWIG_4(SdfLayerHandle.getCPtr(resultLayer), StdStringVector.getCPtr(clipLayerFiles), SdfPath.getCPtr(clipPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClipsTopology(SdfLayerHandle topologyLayer, StdStringVector clipLayerFiles)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClipsTopology(SdfLayerHandle.getCPtr(topologyLayer), StdStringVector.getCPtr(clipLayerFiles));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClipsManifest(SdfLayerHandle manifestLayer, SdfLayerHandle topologyLayer, StdStringVector clipLayerFiles, SdfPath clipPath)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClipsManifest(SdfLayerHandle.getCPtr(manifestLayer), SdfLayerHandle.getCPtr(topologyLayer), StdStringVector.getCPtr(clipLayerFiles), SdfPath.getCPtr(clipPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClipsTemplate(SdfLayerHandle resultLayer, SdfLayerHandle topologyLayer, SdfLayerHandle manifestLayer, SdfPath clipPath, string templatePath, double startTime, double endTime, double stride, double activeOffset, bool interpolateMissingClipValues, TfToken clipSet)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClipsTemplate__SWIG_0(SdfLayerHandle.getCPtr(resultLayer), SdfLayerHandle.getCPtr(topologyLayer), SdfLayerHandle.getCPtr(manifestLayer), SdfPath.getCPtr(clipPath), templatePath, startTime, endTime, stride, activeOffset, interpolateMissingClipValues, TfToken.getCPtr(clipSet));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClipsTemplate(SdfLayerHandle resultLayer, SdfLayerHandle topologyLayer, SdfLayerHandle manifestLayer, SdfPath clipPath, string templatePath, double startTime, double endTime, double stride, double activeOffset, bool interpolateMissingClipValues)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClipsTemplate__SWIG_1(SdfLayerHandle.getCPtr(resultLayer), SdfLayerHandle.getCPtr(topologyLayer), SdfLayerHandle.getCPtr(manifestLayer), SdfPath.getCPtr(clipPath), templatePath, startTime, endTime, stride, activeOffset, interpolateMissingClipValues);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClipsTemplate(SdfLayerHandle resultLayer, SdfLayerHandle topologyLayer, SdfLayerHandle manifestLayer, SdfPath clipPath, string templatePath, double startTime, double endTime, double stride, double activeOffset)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClipsTemplate__SWIG_2(SdfLayerHandle.getCPtr(resultLayer), SdfLayerHandle.getCPtr(topologyLayer), SdfLayerHandle.getCPtr(manifestLayer), SdfPath.getCPtr(clipPath), templatePath, startTime, endTime, stride, activeOffset);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdUtilsStitchClipsTemplate(SdfLayerHandle resultLayer, SdfLayerHandle topologyLayer, SdfLayerHandle manifestLayer, SdfPath clipPath, string templatePath, double startTime, double endTime, double stride)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsStitchClipsTemplate__SWIG_3(SdfLayerHandle.getCPtr(resultLayer), SdfLayerHandle.getCPtr(topologyLayer), SdfLayerHandle.getCPtr(manifestLayer), SdfPath.getCPtr(clipPath), templatePath, startTime, endTime, stride);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string UsdUtilsGenerateClipTopologyName(string rootLayerName)
		{
			string result = UsdUtilsPINVOKE.UsdUtilsGenerateClipTopologyName(rootLayerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string UsdUtilsGenerateClipManifestName(string rootLayerName)
		{
			string result = UsdUtilsPINVOKE.UsdUtilsGenerateClipManifestName(rootLayerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
