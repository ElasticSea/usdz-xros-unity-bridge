using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomXformCache : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdGeomXformCache(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomXformCache obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomXformCache obj)
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

		~UsdGeomXformCache()
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
						UsdGeomPINVOKE.delete_UsdGeomXformCache(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomXformCache(UsdTimeCode time)
			: this(UsdGeomPINVOKE.new_UsdGeomXformCache__SWIG_0(UsdTimeCode.getCPtr(time)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomXformCache()
			: this(UsdGeomPINVOKE.new_UsdGeomXformCache__SWIG_1(), cMemoryOwn: true)
		{
		}

		public GfMatrix4d GetLocalToWorldTransform(UsdPrim prim)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomXformCache_GetLocalToWorldTransform(swigCPtr, UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d GetParentToWorldTransform(UsdPrim prim)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomXformCache_GetParentToWorldTransform(swigCPtr, UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d GetLocalTransformation(UsdPrim prim, out bool resetsXformStack)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomXformCache_GetLocalTransformation(swigCPtr, UsdPrim.getCPtr(prim), out resetsXformStack), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d ComputeRelativeTransform(UsdPrim prim, UsdPrim ancestor, out bool resetXformStack)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomXformCache_ComputeRelativeTransform(swigCPtr, UsdPrim.getCPtr(prim), UsdPrim.getCPtr(ancestor), out resetXformStack), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsAttributeIncludedInLocalTransform(UsdPrim prim, TfToken attrName)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCache_IsAttributeIncludedInLocalTransform(swigCPtr, UsdPrim.getCPtr(prim), TfToken.getCPtr(attrName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool TransformMightBeTimeVarying(UsdPrim prim)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCache_TransformMightBeTimeVarying(swigCPtr, UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetResetXformStack(UsdPrim prim)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCache_GetResetXformStack(swigCPtr, UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Clear()
		{
			UsdGeomPINVOKE.UsdGeomXformCache_Clear(swigCPtr);
		}

		public void SetTime(UsdTimeCode time)
		{
			UsdGeomPINVOKE.UsdGeomXformCache_SetTime(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdTimeCode GetTime()
		{
			return new UsdTimeCode(UsdGeomPINVOKE.UsdGeomXformCache_GetTime(swigCPtr), cMemoryOwn: true);
		}

		public void Swap(UsdGeomXformCache other)
		{
			UsdGeomPINVOKE.UsdGeomXformCache_Swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
