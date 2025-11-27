using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdInherits : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdInherits(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdInherits obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdInherits obj)
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

		~UsdInherits()
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
						UsdPINVOKE.delete_UsdInherits(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool AddInherit(SdfPath primPath, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdInherits_AddInherit__SWIG_0(swigCPtr, SdfPath.getCPtr(primPath), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddInherit(SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdInherits_AddInherit__SWIG_1(swigCPtr, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveInherit(SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdInherits_RemoveInherit(swigCPtr, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearInherits()
		{
			return UsdPINVOKE.UsdInherits_ClearInherits(swigCPtr);
		}

		public bool SetInherits(SdfPathVector items)
		{
			bool result = UsdPINVOKE.UsdInherits_SetInherits(swigCPtr, SdfPathVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathVector GetAllDirectInherits()
		{
			return new SdfPathVector(UsdPINVOKE.UsdInherits_GetAllDirectInherits(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdPINVOKE.UsdInherits_GetPrim__SWIG_0(swigCPtr), cMemoryOwn: false);
		}
	}
}
