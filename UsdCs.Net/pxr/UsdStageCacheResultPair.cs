using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdStageCacheResultPair : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdStage first
		{
			get
			{
				IntPtr intPtr = UsdPINVOKE.UsdStageCacheResultPair_first_get(swigCPtr);
				UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				UsdPINVOKE.UsdStageCacheResultPair_first_set(swigCPtr, UsdStage.getCPtr(value));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public bool second
		{
			get
			{
				return UsdPINVOKE.UsdStageCacheResultPair_second_get(swigCPtr);
			}
			set
			{
				UsdPINVOKE.UsdStageCacheResultPair_second_set(swigCPtr, value);
			}
		}

		public UsdStageCacheResultPair(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdStageCacheResultPair obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdStageCacheResultPair obj)
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

		~UsdStageCacheResultPair()
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
						UsdPINVOKE.delete_UsdStageCacheResultPair(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdStageCacheResultPair()
			: this(UsdPINVOKE.new_UsdStageCacheResultPair__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdStageCacheResultPair(UsdStage first, bool second)
			: this(UsdPINVOKE.new_UsdStageCacheResultPair__SWIG_1(UsdStage.getCPtr(first), second), cMemoryOwn: true)
		{
		}

		public UsdStageCacheResultPair(UsdStageCacheResultPair other)
			: this(UsdPINVOKE.new_UsdStageCacheResultPair__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
