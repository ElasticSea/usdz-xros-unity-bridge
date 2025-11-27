using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomBBoxCache : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdGeomBBoxCache(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomBBoxCache obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomBBoxCache obj)
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

		~UsdGeomBBoxCache()
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
						UsdGeomPINVOKE.delete_UsdGeomBBoxCache(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomBBoxCache(UsdTimeCode time, TfTokenVector includedPurposes, bool useExtentsHint, bool ignoreVisibility)
			: this(UsdGeomPINVOKE.new_UsdGeomBBoxCache__SWIG_0(UsdTimeCode.getCPtr(time), TfTokenVector.getCPtr(includedPurposes), useExtentsHint, ignoreVisibility), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomBBoxCache(UsdTimeCode time, TfTokenVector includedPurposes, bool useExtentsHint)
			: this(UsdGeomPINVOKE.new_UsdGeomBBoxCache__SWIG_1(UsdTimeCode.getCPtr(time), TfTokenVector.getCPtr(includedPurposes), useExtentsHint), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomBBoxCache(UsdTimeCode time, TfTokenVector includedPurposes)
			: this(UsdGeomPINVOKE.new_UsdGeomBBoxCache__SWIG_2(UsdTimeCode.getCPtr(time), TfTokenVector.getCPtr(includedPurposes)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomBBoxCache(UsdGeomBBoxCache other)
			: this(UsdGeomPINVOKE.new_UsdGeomBBoxCache__SWIG_3(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfBBox3d ComputeWorldBound(UsdPrim prim)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputeWorldBound(swigCPtr, UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeWorldBoundWithOverrides(UsdPrim prim, SdfPathSet pathsToSkip, GfMatrix4d primOverride, SWIGTYPE_p_TfHashMapT_SdfPath_GfMatrix4d_SdfPath__Hash_t ctmOverrides)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputeWorldBoundWithOverrides(swigCPtr, UsdPrim.getCPtr(prim), SdfPathSet.getCPtr(pathsToSkip), GfMatrix4d.getCPtr(primOverride), SWIGTYPE_p_TfHashMapT_SdfPath_GfMatrix4d_SdfPath__Hash_t.getCPtr(ctmOverrides)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeRelativeBound(UsdPrim prim, UsdPrim relativeToAncestorPrim)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputeRelativeBound(swigCPtr, UsdPrim.getCPtr(prim), UsdPrim.getCPtr(relativeToAncestorPrim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeLocalBound(UsdPrim prim)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputeLocalBound(swigCPtr, UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeUntransformedBound(UsdPrim prim)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputeUntransformedBound__SWIG_0(swigCPtr, UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeUntransformedBound(UsdPrim prim, SdfPathSet pathsToSkip, SWIGTYPE_p_TfHashMapT_SdfPath_GfMatrix4d_SdfPath__Hash_t ctmOverrides)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputeUntransformedBound__SWIG_1(swigCPtr, UsdPrim.getCPtr(prim), SdfPathSet.getCPtr(pathsToSkip), SWIGTYPE_p_TfHashMapT_SdfPath_GfMatrix4d_SdfPath__Hash_t.getCPtr(ctmOverrides)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputePointInstanceWorldBounds(UsdGeomPointInstancer instancer, long[] instanceIdBegin, uint numIds, GfBBox3d result)
		{
			bool result2 = UsdGeomPINVOKE.UsdGeomBBoxCache_ComputePointInstanceWorldBounds(swigCPtr, UsdGeomPointInstancer.getCPtr(instancer), instanceIdBegin, numIds, GfBBox3d.getCPtr(result));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result2;
		}

		public GfBBox3d ComputePointInstanceWorldBound(UsdGeomPointInstancer instancer, long instanceId)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputePointInstanceWorldBound(swigCPtr, UsdGeomPointInstancer.getCPtr(instancer), instanceId), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputePointInstanceRelativeBounds(UsdGeomPointInstancer instancer, long[] instanceIdBegin, uint numIds, UsdPrim relativeToAncestorPrim, GfBBox3d result)
		{
			bool result2 = UsdGeomPINVOKE.UsdGeomBBoxCache_ComputePointInstanceRelativeBounds(swigCPtr, UsdGeomPointInstancer.getCPtr(instancer), instanceIdBegin, numIds, UsdPrim.getCPtr(relativeToAncestorPrim), GfBBox3d.getCPtr(result));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result2;
		}

		public GfBBox3d ComputePointInstanceRelativeBound(UsdGeomPointInstancer instancer, long instanceId, UsdPrim relativeToAncestorPrim)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputePointInstanceRelativeBound(swigCPtr, UsdGeomPointInstancer.getCPtr(instancer), instanceId, UsdPrim.getCPtr(relativeToAncestorPrim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputePointInstanceLocalBounds(UsdGeomPointInstancer instancer, long[] instanceIdBegin, uint numIds, GfBBox3d result)
		{
			bool result2 = UsdGeomPINVOKE.UsdGeomBBoxCache_ComputePointInstanceLocalBounds(swigCPtr, UsdGeomPointInstancer.getCPtr(instancer), instanceIdBegin, numIds, GfBBox3d.getCPtr(result));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result2;
		}

		public GfBBox3d ComputePointInstanceLocalBound(UsdGeomPointInstancer instancer, long instanceId)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputePointInstanceLocalBound(swigCPtr, UsdGeomPointInstancer.getCPtr(instancer), instanceId), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputePointInstanceUntransformedBounds(UsdGeomPointInstancer instancer, long[] instanceIdBegin, uint numIds, GfBBox3d result)
		{
			bool result2 = UsdGeomPINVOKE.UsdGeomBBoxCache_ComputePointInstanceUntransformedBounds(swigCPtr, UsdGeomPointInstancer.getCPtr(instancer), instanceIdBegin, numIds, GfBBox3d.getCPtr(result));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result2;
		}

		public GfBBox3d ComputePointInstanceUntransformedBound(UsdGeomPointInstancer instancer, long instanceId)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomBBoxCache_ComputePointInstanceUntransformedBound(swigCPtr, UsdGeomPointInstancer.getCPtr(instancer), instanceId), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Clear()
		{
			UsdGeomPINVOKE.UsdGeomBBoxCache_Clear(swigCPtr);
		}

		public void SetIncludedPurposes(TfTokenVector includedPurposes)
		{
			UsdGeomPINVOKE.UsdGeomBBoxCache_SetIncludedPurposes(swigCPtr, TfTokenVector.getCPtr(includedPurposes));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfTokenVector GetIncludedPurposes()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomBBoxCache_GetIncludedPurposes(swigCPtr), cMemoryOwn: false);
		}

		public bool GetUseExtentsHint()
		{
			return UsdGeomPINVOKE.UsdGeomBBoxCache_GetUseExtentsHint(swigCPtr);
		}

		public bool GetIgnoreVisibility()
		{
			return UsdGeomPINVOKE.UsdGeomBBoxCache_GetIgnoreVisibility(swigCPtr);
		}

		public void SetTime(UsdTimeCode time)
		{
			UsdGeomPINVOKE.UsdGeomBBoxCache_SetTime(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdTimeCode GetTime()
		{
			return new UsdTimeCode(UsdGeomPINVOKE.UsdGeomBBoxCache_GetTime(swigCPtr), cMemoryOwn: true);
		}

		public void SetBaseTime(UsdTimeCode baseTime)
		{
			UsdGeomPINVOKE.UsdGeomBBoxCache_SetBaseTime(swigCPtr, UsdTimeCode.getCPtr(baseTime));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdTimeCode GetBaseTime()
		{
			return new UsdTimeCode(UsdGeomPINVOKE.UsdGeomBBoxCache_GetBaseTime(swigCPtr), cMemoryOwn: true);
		}

		public void ClearBaseTime()
		{
			UsdGeomPINVOKE.UsdGeomBBoxCache_ClearBaseTime(swigCPtr);
		}

		public bool HasBaseTime()
		{
			return UsdGeomPINVOKE.UsdGeomBBoxCache_HasBaseTime(swigCPtr);
		}
	}
}
