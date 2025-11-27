using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSpecializes : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdSpecializes(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSpecializes obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSpecializes obj)
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

		~UsdSpecializes()
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
						UsdPINVOKE.delete_UsdSpecializes(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool AddSpecialize(SdfPath primPath, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdSpecializes_AddSpecialize__SWIG_0(swigCPtr, SdfPath.getCPtr(primPath), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddSpecialize(SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdSpecializes_AddSpecialize__SWIG_1(swigCPtr, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveSpecialize(SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdSpecializes_RemoveSpecialize(swigCPtr, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearSpecializes()
		{
			return UsdPINVOKE.UsdSpecializes_ClearSpecializes(swigCPtr);
		}

		public bool SetSpecializes(SdfPathVector items)
		{
			bool result = UsdPINVOKE.UsdSpecializes_SetSpecializes(swigCPtr, SdfPathVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdPINVOKE.UsdSpecializes_GetPrim__SWIG_0(swigCPtr), cMemoryOwn: false);
		}
	}
}
