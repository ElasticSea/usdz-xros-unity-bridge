using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdStageCacheRequest : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdStageCacheRequest(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdStageCacheRequest obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdStageCacheRequest obj)
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

		~UsdStageCacheRequest()
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
						UsdPINVOKE.delete_UsdStageCacheRequest(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public virtual bool IsSatisfiedBy(UsdStage stage)
		{
			bool result = UsdPINVOKE.UsdStageCacheRequest_IsSatisfiedBy__SWIG_0(swigCPtr, UsdStage.getCPtr(stage));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool IsSatisfiedBy(UsdStageCacheRequest pending)
		{
			bool result = UsdPINVOKE.UsdStageCacheRequest_IsSatisfiedBy__SWIG_1(swigCPtr, getCPtr(pending));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual UsdStage Manufacture()
		{
			IntPtr intPtr = UsdPINVOKE.UsdStageCacheRequest_Manufacture(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true);
		}
	}
}
