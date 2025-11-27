using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpCache : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public PcpCache(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpCache obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpCache obj)
		{
			if (obj != null)
			{
				if (!obj.swigCMemOwn)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef result = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				return result;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		~PcpCache()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						PcpPINVOKE.delete_PcpCache(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpCache(PcpLayerStackIdentifier layerStackIdentifier, string fileFormatTarget, bool usd)
			: this(PcpPINVOKE.new_PcpCache__SWIG_0(PcpLayerStackIdentifier.getCPtr(layerStackIdentifier), fileFormatTarget, usd), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpCache(PcpLayerStackIdentifier layerStackIdentifier, string fileFormatTarget)
			: this(PcpPINVOKE.new_PcpCache__SWIG_1(PcpLayerStackIdentifier.getCPtr(layerStackIdentifier), fileFormatTarget), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpCache(PcpLayerStackIdentifier layerStackIdentifier)
			: this(PcpPINVOKE.new_PcpCache__SWIG_2(PcpLayerStackIdentifier.getCPtr(layerStackIdentifier)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackIdentifier GetLayerStackIdentifier()
		{
			return new PcpLayerStackIdentifier(PcpPINVOKE.PcpCache_GetLayerStackIdentifier(swigCPtr), cMemoryOwn: false);
		}

		public PcpLayerStack GetLayerStack()
		{
			IntPtr intPtr = PcpPINVOKE.PcpCache_GetLayerStack(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new PcpLayerStack(intPtr, cMemoryOwn: true);
		}

		public bool HasRootLayerStack(PcpLayerStack layerStack)
		{
			bool result = PcpPINVOKE.PcpCache_HasRootLayerStack(swigCPtr, PcpLayerStack.getCPtr(layerStack));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsUsd()
		{
			return PcpPINVOKE.PcpCache_IsUsd(swigCPtr);
		}

		public string GetFileFormatTarget()
		{
			return PcpPINVOKE.PcpCache_GetFileFormatTarget(swigCPtr);
		}

		public PcpVariantFallbackMap GetVariantFallbacks()
		{
			return new PcpVariantFallbackMap(PcpPINVOKE.PcpCache_GetVariantFallbacks(swigCPtr), cMemoryOwn: true);
		}

		public void SetVariantFallbacks(PcpVariantFallbackMap map, SWIGTYPE_p_PcpChanges changes)
		{
			PcpPINVOKE.PcpCache_SetVariantFallbacks__SWIG_0(swigCPtr, PcpVariantFallbackMap.getCPtr(map), SWIGTYPE_p_PcpChanges.getCPtr(changes));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetVariantFallbacks(PcpVariantFallbackMap map)
		{
			PcpPINVOKE.PcpCache_SetVariantFallbacks__SWIG_1(swigCPtr, PcpVariantFallbackMap.getCPtr(map));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsPayloadIncluded(SdfPath path)
		{
			bool result = PcpPINVOKE.PcpCache_IsPayloadIncluded(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__unordered_setT_SdfPath_SdfPath__Hash_t GetIncludedPayloads()
		{
			return new SWIGTYPE_p_std__unordered_setT_SdfPath_SdfPath__Hash_t(PcpPINVOKE.PcpCache_GetIncludedPayloads(swigCPtr), futureUse: false);
		}

		public void RequestPayloads(SdfPathSet pathsToInclude, SdfPathSet pathsToExclude, SWIGTYPE_p_PcpChanges changes)
		{
			PcpPINVOKE.PcpCache_RequestPayloads__SWIG_0(swigCPtr, SdfPathSet.getCPtr(pathsToInclude), SdfPathSet.getCPtr(pathsToExclude), SWIGTYPE_p_PcpChanges.getCPtr(changes));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RequestPayloads(SdfPathSet pathsToInclude, SdfPathSet pathsToExclude)
		{
			PcpPINVOKE.PcpCache_RequestPayloads__SWIG_1(swigCPtr, SdfPathSet.getCPtr(pathsToInclude), SdfPathSet.getCPtr(pathsToExclude));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RequestLayerMuting(StdStringVector layersToMute, StdStringVector layersToUnmute, SWIGTYPE_p_PcpChanges changes, StdStringVector newLayersMuted, StdStringVector newLayersUnmuted)
		{
			PcpPINVOKE.PcpCache_RequestLayerMuting__SWIG_0(swigCPtr, StdStringVector.getCPtr(layersToMute), StdStringVector.getCPtr(layersToUnmute), SWIGTYPE_p_PcpChanges.getCPtr(changes), StdStringVector.getCPtr(newLayersMuted), StdStringVector.getCPtr(newLayersUnmuted));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RequestLayerMuting(StdStringVector layersToMute, StdStringVector layersToUnmute, SWIGTYPE_p_PcpChanges changes, StdStringVector newLayersMuted)
		{
			PcpPINVOKE.PcpCache_RequestLayerMuting__SWIG_1(swigCPtr, StdStringVector.getCPtr(layersToMute), StdStringVector.getCPtr(layersToUnmute), SWIGTYPE_p_PcpChanges.getCPtr(changes), StdStringVector.getCPtr(newLayersMuted));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RequestLayerMuting(StdStringVector layersToMute, StdStringVector layersToUnmute, SWIGTYPE_p_PcpChanges changes)
		{
			PcpPINVOKE.PcpCache_RequestLayerMuting__SWIG_2(swigCPtr, StdStringVector.getCPtr(layersToMute), StdStringVector.getCPtr(layersToUnmute), SWIGTYPE_p_PcpChanges.getCPtr(changes));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RequestLayerMuting(StdStringVector layersToMute, StdStringVector layersToUnmute)
		{
			PcpPINVOKE.PcpCache_RequestLayerMuting__SWIG_3(swigCPtr, StdStringVector.getCPtr(layersToMute), StdStringVector.getCPtr(layersToUnmute));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdStringVector GetMutedLayers()
		{
			return new StdStringVector(PcpPINVOKE.PcpCache_GetMutedLayers(swigCPtr), cMemoryOwn: false);
		}

		public bool IsLayerMuted(string layerIdentifier)
		{
			bool result = PcpPINVOKE.PcpCache_IsLayerMuted__SWIG_0(swigCPtr, layerIdentifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsLayerMuted(SdfLayerHandle anchorLayer, string layerIdentifier, out string canonicalMutedLayerIdentifier)
		{
			bool result = PcpPINVOKE.PcpCache_IsLayerMuted__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(anchorLayer), layerIdentifier, out canonicalMutedLayerIdentifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsLayerMuted(SdfLayerHandle anchorLayer, string layerIdentifier)
		{
			bool result = PcpPINVOKE.PcpCache_IsLayerMuted__SWIG_2(swigCPtr, SdfLayerHandle.getCPtr(anchorLayer), layerIdentifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PcpPrimIndexInputs GetPrimIndexInputs()
		{
			return new SWIGTYPE_p_PcpPrimIndexInputs(PcpPINVOKE.PcpCache_GetPrimIndexInputs(swigCPtr), futureUse: true);
		}

		public PcpLayerStack ComputeLayerStack(PcpLayerStackIdentifier identifier, SWIGTYPE_p_PcpErrorVector allErrors)
		{
			IntPtr intPtr = PcpPINVOKE.PcpCache_ComputeLayerStack(swigCPtr, PcpLayerStackIdentifier.getCPtr(identifier), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors));
			PcpLayerStack result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStack(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpLayerStack FindLayerStack(PcpLayerStackIdentifier identifier)
		{
			IntPtr intPtr = PcpPINVOKE.PcpCache_FindLayerStack(swigCPtr, PcpLayerStackIdentifier.getCPtr(identifier));
			PcpLayerStack result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStack(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UsesLayerStack(PcpLayerStack layerStack)
		{
			bool result = PcpPINVOKE.PcpCache_UsesLayerStack(swigCPtr, PcpLayerStack.getCPtr(layerStack));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpPrimIndex ComputePrimIndex(SdfPath primPath, SWIGTYPE_p_PcpErrorVector allErrors)
		{
			PcpPrimIndex result = new PcpPrimIndex(PcpPINVOKE.PcpCache_ComputePrimIndex(swigCPtr, SdfPath.getCPtr(primPath), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpPrimIndex FindPrimIndex(SdfPath primPath)
		{
			IntPtr intPtr = PcpPINVOKE.PcpCache_FindPrimIndex(swigCPtr, SdfPath.getCPtr(primPath));
			PcpPrimIndex result = ((intPtr == IntPtr.Zero) ? null : new PcpPrimIndex(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpPropertyIndex ComputePropertyIndex(SdfPath propPath, SWIGTYPE_p_PcpErrorVector allErrors)
		{
			PcpPropertyIndex result = new PcpPropertyIndex(PcpPINVOKE.PcpCache_ComputePropertyIndex(swigCPtr, SdfPath.getCPtr(propPath), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpPropertyIndex FindPropertyIndex(SdfPath propPath)
		{
			IntPtr intPtr = PcpPINVOKE.PcpCache_FindPropertyIndex(swigCPtr, SdfPath.getCPtr(propPath));
			PcpPropertyIndex result = ((intPtr == IntPtr.Zero) ? null : new PcpPropertyIndex(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComputeRelationshipTargetPaths(SdfPath relationshipPath, SdfPathVector paths, bool localOnly, SdfSpecHandle stopProperty, bool includeStopProperty, SdfPathVector deletedPaths, SWIGTYPE_p_PcpErrorVector allErrors)
		{
			PcpPINVOKE.PcpCache_ComputeRelationshipTargetPaths(swigCPtr, SdfPath.getCPtr(relationshipPath), SdfPathVector.getCPtr(paths), localOnly, SdfSpecHandle.getCPtr(stopProperty), includeStopProperty, SdfPathVector.getCPtr(deletedPaths), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ComputeAttributeConnectionPaths(SdfPath attributePath, SdfPathVector paths, bool localOnly, SdfSpecHandle stopProperty, bool includeStopProperty, SdfPathVector deletedPaths, SWIGTYPE_p_PcpErrorVector allErrors)
		{
			PcpPINVOKE.PcpCache_ComputeAttributeConnectionPaths(swigCPtr, SdfPath.getCPtr(attributePath), SdfPathVector.getCPtr(paths), localOnly, SdfSpecHandle.getCPtr(stopProperty), includeStopProperty, SdfPathVector.getCPtr(deletedPaths), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerHandleSet GetUsedLayers()
		{
			return new SdfLayerHandleSet(PcpPINVOKE.PcpCache_GetUsedLayers(swigCPtr), cMemoryOwn: true);
		}

		public uint GetUsedLayersRevision()
		{
			return PcpPINVOKE.PcpCache_GetUsedLayersRevision(swigCPtr);
		}

		public SdfLayerHandleSet GetUsedRootLayers()
		{
			return new SdfLayerHandleSet(PcpPINVOKE.PcpCache_GetUsedRootLayers(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_PcpLayerStackPtrVector FindAllLayerStacksUsingLayer(SdfLayerHandle layer)
		{
			SWIGTYPE_p_PcpLayerStackPtrVector result = new SWIGTYPE_p_PcpLayerStackPtrVector(PcpPINVOKE.PcpCache_FindAllLayerStacksUsingLayer(swigCPtr, SdfLayerHandle.getCPtr(layer)), futureUse: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PcpDependencyVector FindSiteDependencies(PcpLayerStack siteLayerStack, SdfPath sitePath, SWIGTYPE_p_PcpDependencyFlags depMask, bool recurseOnSite, bool recurseOnIndex, bool filterForExistingCachesOnly)
		{
			SWIGTYPE_p_PcpDependencyVector result = new SWIGTYPE_p_PcpDependencyVector(PcpPINVOKE.PcpCache_FindSiteDependencies__SWIG_0(swigCPtr, PcpLayerStack.getCPtr(siteLayerStack), SdfPath.getCPtr(sitePath), SWIGTYPE_p_PcpDependencyFlags.getCPtr(depMask), recurseOnSite, recurseOnIndex, filterForExistingCachesOnly), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PcpDependencyVector FindSiteDependencies(SdfLayerHandle siteLayer, SdfPath sitePath, SWIGTYPE_p_PcpDependencyFlags depMask, bool recurseOnSite, bool recurseOnIndex, bool filterForExistingCachesOnly)
		{
			SWIGTYPE_p_PcpDependencyVector result = new SWIGTYPE_p_PcpDependencyVector(PcpPINVOKE.PcpCache_FindSiteDependencies__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(siteLayer), SdfPath.getCPtr(sitePath), SWIGTYPE_p_PcpDependencyFlags.getCPtr(depMask), recurseOnSite, recurseOnIndex, filterForExistingCachesOnly), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanHaveOpinionForSite(SdfPath localPcpSitePath, SdfLayerHandle layer, SdfPath allowedPathInLayer)
		{
			bool result = PcpPINVOKE.PcpCache_CanHaveOpinionForSite(swigCPtr, SdfPath.getCPtr(localPcpSitePath), SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(allowedPathInLayer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringVector GetInvalidSublayerIdentifiers()
		{
			return new StdStringVector(PcpPINVOKE.PcpCache_GetInvalidSublayerIdentifiers(swigCPtr), cMemoryOwn: true);
		}

		public bool IsInvalidSublayerIdentifier(string identifier)
		{
			bool result = PcpPINVOKE.PcpCache_IsInvalidSublayerIdentifier(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__mapT_SdfPath_std__vectorT_std__string_t_SdfPath__FastLessThan_t GetInvalidAssetPaths()
		{
			return new SWIGTYPE_p_std__mapT_SdfPath_std__vectorT_std__string_t_SdfPath__FastLessThan_t(PcpPINVOKE.PcpCache_GetInvalidAssetPaths(swigCPtr), futureUse: true);
		}

		public bool IsInvalidAssetPath(string resolvedAssetPath)
		{
			bool result = PcpPINVOKE.PcpCache_IsInvalidAssetPath(swigCPtr, resolvedAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAnyDynamicFileFormatArgumentDependencies()
		{
			return PcpPINVOKE.PcpCache_HasAnyDynamicFileFormatArgumentDependencies(swigCPtr);
		}

		public bool IsPossibleDynamicFileFormatArgumentField(TfToken field)
		{
			bool result = PcpPINVOKE.PcpCache_IsPossibleDynamicFileFormatArgumentField(swigCPtr, TfToken.getCPtr(field));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PcpDynamicFileFormatDependencyData GetDynamicFileFormatArgumentDependencyData(SdfPath primIndexPath)
		{
			SWIGTYPE_p_PcpDynamicFileFormatDependencyData result = new SWIGTYPE_p_PcpDynamicFileFormatDependencyData(PcpPINVOKE.PcpCache_GetDynamicFileFormatArgumentDependencyData(swigCPtr, SdfPath.getCPtr(primIndexPath)), futureUse: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Apply(SWIGTYPE_p_PcpCacheChanges changes, SWIGTYPE_p_PcpLifeboat lifeboat)
		{
			PcpPINVOKE.PcpCache_Apply(swigCPtr, SWIGTYPE_p_PcpCacheChanges.getCPtr(changes), SWIGTYPE_p_PcpLifeboat.getCPtr(lifeboat));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Reload(SWIGTYPE_p_PcpChanges changes)
		{
			PcpPINVOKE.PcpCache_Reload(swigCPtr, SWIGTYPE_p_PcpChanges.getCPtr(changes));
		}

		public void ReloadReferences(SWIGTYPE_p_PcpChanges changes, SdfPath primPath)
		{
			PcpPINVOKE.PcpCache_ReloadReferences(swigCPtr, SWIGTYPE_p_PcpChanges.getCPtr(changes), SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void PrintStatistics()
		{
			PcpPINVOKE.PcpCache_PrintStatistics(swigCPtr);
		}
	}
}
