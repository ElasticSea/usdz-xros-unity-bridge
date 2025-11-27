using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdRelationship : UsdProperty
	{
		private HandleRef swigCPtr;

		public UsdRelationship(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdRelationship_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdRelationship obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdRelationship obj)
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
						UsdPINVOKE.delete_UsdRelationship(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdRelationship()
			: this(UsdPINVOKE.new_UsdRelationship(), cMemoryOwn: true)
		{
		}

		public bool AddTarget(SdfPath target, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdRelationship_AddTarget__SWIG_0(swigCPtr, SdfPath.getCPtr(target), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddTarget(SdfPath target)
		{
			bool result = UsdPINVOKE.UsdRelationship_AddTarget__SWIG_1(swigCPtr, SdfPath.getCPtr(target));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveTarget(SdfPath target)
		{
			bool result = UsdPINVOKE.UsdRelationship_RemoveTarget(swigCPtr, SdfPath.getCPtr(target));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetTargets(SdfPathVector targets)
		{
			bool result = UsdPINVOKE.UsdRelationship_SetTargets(swigCPtr, SdfPathVector.getCPtr(targets));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearTargets(bool removeSpec)
		{
			return UsdPINVOKE.UsdRelationship_ClearTargets(swigCPtr, removeSpec);
		}

		public bool HasAuthoredTargets()
		{
			return UsdPINVOKE.UsdRelationship_HasAuthoredTargets(swigCPtr);
		}

		public SdfPathVector GetTargets()
		{
			return new SdfPathVector(UsdPINVOKE.UsdRelationship_GetTargets(swigCPtr), cMemoryOwn: true);
		}

		public SdfPathVector GetForwardedTargets()
		{
			return new SdfPathVector(UsdPINVOKE.UsdRelationship_GetForwardedTargets(swigCPtr), cMemoryOwn: true);
		}
	}
}
