using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdClipsAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.NonAppliedAPI;

		public UsdClipsAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdClipsAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdClipsAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdClipsAPI obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						UsdPINVOKE.delete_UsdClipsAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdClipsAPI(UsdPrim prim)
			: this(UsdPINVOKE.new_UsdClipsAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdClipsAPI()
			: this(UsdPINVOKE.new_UsdClipsAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdClipsAPI(UsdSchemaBase schemaObj)
			: this(UsdPINVOKE.new_UsdClipsAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdPINVOKE.UsdClipsAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdClipsAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdClipsAPI Get(UsdStage stage, SdfPath path)
		{
			UsdClipsAPI result = new UsdClipsAPI(UsdPINVOKE.UsdClipsAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClips(VtDictionary clips)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClips(swigCPtr, VtDictionary.getCPtr(clips));
		}

		public bool SetClips(VtDictionary clips)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClips(swigCPtr, VtDictionary.getCPtr(clips));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipSets(SdfStringListOp clipSets)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipSets(swigCPtr, SdfStringListOp.getCPtr(clipSets));
		}

		public bool SetClipSets(SdfStringListOp clipSets)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipSets(swigCPtr, SdfStringListOp.getCPtr(clipSets));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAssetPathArray ComputeClipAssetPaths(string clipSet)
		{
			SdfAssetPathArray result = new SdfAssetPathArray(UsdPINVOKE.UsdClipsAPI_ComputeClipAssetPaths__SWIG_0(swigCPtr, clipSet), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAssetPathArray ComputeClipAssetPaths()
		{
			return new SdfAssetPathArray(UsdPINVOKE.UsdClipsAPI_ComputeClipAssetPaths__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public bool GetClipAssetPaths(SdfAssetPathArray assetPaths, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipAssetPaths__SWIG_0(swigCPtr, SdfAssetPathArray.getCPtr(assetPaths), clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipAssetPaths(SdfAssetPathArray assetPaths)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipAssetPaths__SWIG_1(swigCPtr, SdfAssetPathArray.getCPtr(assetPaths));
		}

		public bool SetClipAssetPaths(SdfAssetPathArray assetPaths, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipAssetPaths__SWIG_0(swigCPtr, SdfAssetPathArray.getCPtr(assetPaths), clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipAssetPaths(SdfAssetPathArray assetPaths)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipAssetPaths__SWIG_1(swigCPtr, SdfAssetPathArray.getCPtr(assetPaths));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipPrimPath(out string primPath, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipPrimPath__SWIG_0(swigCPtr, out primPath, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipPrimPath(out string primPath)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipPrimPath__SWIG_1(swigCPtr, out primPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipPrimPath(string primPath, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipPrimPath__SWIG_0(swigCPtr, primPath, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipPrimPath(string primPath)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipPrimPath__SWIG_1(swigCPtr, primPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipActive(VtVec2dArray activeClips, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipActive__SWIG_0(swigCPtr, VtVec2dArray.getCPtr(activeClips), clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipActive(VtVec2dArray activeClips)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipActive__SWIG_1(swigCPtr, VtVec2dArray.getCPtr(activeClips));
		}

		public bool SetClipActive(VtVec2dArray activeClips, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipActive__SWIG_0(swigCPtr, VtVec2dArray.getCPtr(activeClips), clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipActive(VtVec2dArray activeClips)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipActive__SWIG_1(swigCPtr, VtVec2dArray.getCPtr(activeClips));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipTimes(VtVec2dArray clipTimes, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipTimes__SWIG_0(swigCPtr, VtVec2dArray.getCPtr(clipTimes), clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipTimes(VtVec2dArray clipTimes)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipTimes__SWIG_1(swigCPtr, VtVec2dArray.getCPtr(clipTimes));
		}

		public bool SetClipTimes(VtVec2dArray clipTimes, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipTimes__SWIG_0(swigCPtr, VtVec2dArray.getCPtr(clipTimes), clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipTimes(VtVec2dArray clipTimes)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipTimes__SWIG_1(swigCPtr, VtVec2dArray.getCPtr(clipTimes));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipManifestAssetPath(SdfAssetPath manifestAssetPath, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipManifestAssetPath__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(manifestAssetPath), clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipManifestAssetPath(SdfAssetPath manifestAssetPath)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipManifestAssetPath__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(manifestAssetPath));
		}

		public bool SetClipManifestAssetPath(SdfAssetPath manifestAssetPath, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipManifestAssetPath__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(manifestAssetPath), clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipManifestAssetPath(SdfAssetPath manifestAssetPath)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipManifestAssetPath__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(manifestAssetPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle GenerateClipManifest(string clipSet, bool writeBlocksForClipsWithMissingValues)
		{
			IntPtr intPtr = UsdPINVOKE.UsdClipsAPI_GenerateClipManifest__SWIG_0(swigCPtr, clipSet, writeBlocksForClipsWithMissingValues);
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

		public SdfLayerHandle GenerateClipManifest(string clipSet)
		{
			IntPtr intPtr = UsdPINVOKE.UsdClipsAPI_GenerateClipManifest__SWIG_1(swigCPtr, clipSet);
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

		public SdfLayerHandle GenerateClipManifest(bool writeBlocksForClipsWithMissingValues)
		{
			IntPtr intPtr = UsdPINVOKE.UsdClipsAPI_GenerateClipManifest__SWIG_2(swigCPtr, writeBlocksForClipsWithMissingValues);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			return (intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true);
		}

		public SdfLayerHandle GenerateClipManifest()
		{
			IntPtr intPtr = UsdPINVOKE.UsdClipsAPI_GenerateClipManifest__SWIG_3(swigCPtr);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			return (intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true);
		}

		public static SdfLayerHandle GenerateClipManifestFromLayers(SdfLayerHandleVector clipLayers, SdfPath clipPrimPath)
		{
			IntPtr intPtr = UsdPINVOKE.UsdClipsAPI_GenerateClipManifestFromLayers(SdfLayerHandleVector.getCPtr(clipLayers), SdfPath.getCPtr(clipPrimPath));
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

		public bool GetInterpolateMissingClipValues(out bool interpolate, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetInterpolateMissingClipValues__SWIG_0(swigCPtr, out interpolate, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetInterpolateMissingClipValues(out bool interpolate)
		{
			return UsdPINVOKE.UsdClipsAPI_GetInterpolateMissingClipValues__SWIG_1(swigCPtr, out interpolate);
		}

		public bool SetInterpolateMissingClipValues(bool interpolate, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetInterpolateMissingClipValues__SWIG_0(swigCPtr, interpolate, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetInterpolateMissingClipValues(bool interpolate)
		{
			return UsdPINVOKE.UsdClipsAPI_SetInterpolateMissingClipValues__SWIG_1(swigCPtr, interpolate);
		}

		public bool GetClipTemplateAssetPath(out string clipTemplateAssetPath, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipTemplateAssetPath__SWIG_0(swigCPtr, out clipTemplateAssetPath, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipTemplateAssetPath(out string clipTemplateAssetPath)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipTemplateAssetPath__SWIG_1(swigCPtr, out clipTemplateAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipTemplateAssetPath(string clipTemplateAssetPath, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipTemplateAssetPath__SWIG_0(swigCPtr, clipTemplateAssetPath, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipTemplateAssetPath(string clipTemplateAssetPath)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipTemplateAssetPath__SWIG_1(swigCPtr, clipTemplateAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipTemplateStride(out double clipTemplateStride, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipTemplateStride__SWIG_0(swigCPtr, out clipTemplateStride, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipTemplateStride(out double clipTemplateStride)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipTemplateStride__SWIG_1(swigCPtr, out clipTemplateStride);
		}

		public bool SetClipTemplateActiveOffset(double clipTemplateActiveOffset, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipTemplateActiveOffset__SWIG_0(swigCPtr, clipTemplateActiveOffset, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipTemplateActiveOffset(double clipTemplateActiveOffset)
		{
			return UsdPINVOKE.UsdClipsAPI_SetClipTemplateActiveOffset__SWIG_1(swigCPtr, clipTemplateActiveOffset);
		}

		public bool GetClipTemplateActiveOffset(out double clipTemplateActiveOffset, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipTemplateActiveOffset__SWIG_0(swigCPtr, out clipTemplateActiveOffset, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipTemplateActiveOffset(out double clipTemplateActiveOffset)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipTemplateActiveOffset__SWIG_1(swigCPtr, out clipTemplateActiveOffset);
		}

		public bool SetClipTemplateStride(double clipTemplateStride, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipTemplateStride__SWIG_0(swigCPtr, clipTemplateStride, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipTemplateStride(double clipTemplateStride)
		{
			return UsdPINVOKE.UsdClipsAPI_SetClipTemplateStride__SWIG_1(swigCPtr, clipTemplateStride);
		}

		public bool GetClipTemplateStartTime(out double clipTemplateStartTime, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipTemplateStartTime__SWIG_0(swigCPtr, out clipTemplateStartTime, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipTemplateStartTime(out double clipTemplateStartTime)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipTemplateStartTime__SWIG_1(swigCPtr, out clipTemplateStartTime);
		}

		public bool SetClipTemplateStartTime(double clipTemplateStartTime, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipTemplateStartTime__SWIG_0(swigCPtr, clipTemplateStartTime, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipTemplateStartTime(double clipTemplateStartTime)
		{
			return UsdPINVOKE.UsdClipsAPI_SetClipTemplateStartTime__SWIG_1(swigCPtr, clipTemplateStartTime);
		}

		public bool GetClipTemplateEndTime(out double clipTemplateEndTime, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_GetClipTemplateEndTime__SWIG_0(swigCPtr, out clipTemplateEndTime, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetClipTemplateEndTime(out double clipTemplateEndTime)
		{
			return UsdPINVOKE.UsdClipsAPI_GetClipTemplateEndTime__SWIG_1(swigCPtr, out clipTemplateEndTime);
		}

		public bool SetClipTemplateEndTime(double clipTemplateEndTime, string clipSet)
		{
			bool result = UsdPINVOKE.UsdClipsAPI_SetClipTemplateEndTime__SWIG_0(swigCPtr, clipTemplateEndTime, clipSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetClipTemplateEndTime(double clipTemplateEndTime)
		{
			return UsdPINVOKE.UsdClipsAPI_SetClipTemplateEndTime__SWIG_1(swigCPtr, clipTemplateEndTime);
		}
	}
}
