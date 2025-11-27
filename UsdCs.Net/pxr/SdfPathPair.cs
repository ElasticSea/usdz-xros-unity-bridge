using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPathPair : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfPath first
		{
			get
			{
				IntPtr intPtr = SdfPINVOKE.SdfPathPair_first_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfPath(intPtr, cMemoryOwn: false);
			}
			set
			{
				SdfPINVOKE.SdfPathPair_first_set(swigCPtr, SdfPath.getCPtr(value));
			}
		}

		public SdfPath second
		{
			get
			{
				IntPtr intPtr = SdfPINVOKE.SdfPathPair_second_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfPath(intPtr, cMemoryOwn: false);
			}
			set
			{
				SdfPINVOKE.SdfPathPair_second_set(swigCPtr, SdfPath.getCPtr(value));
			}
		}

		public SdfPathPair(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPathPair obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPathPair obj)
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

		~SdfPathPair()
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
						SdfPINVOKE.delete_SdfPathPair(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPathPair()
			: this(SdfPINVOKE.new_SdfPathPair__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPathPair(SdfPath first, SdfPath second)
			: this(SdfPINVOKE.new_SdfPathPair__SWIG_1(SdfPath.getCPtr(first), SdfPath.getCPtr(second)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPathPair(SdfPathPair other)
			: this(SdfPINVOKE.new_SdfPathPair__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
