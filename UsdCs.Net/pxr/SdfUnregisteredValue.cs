using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfUnregisteredValue : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfUnregisteredValue(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfUnregisteredValue obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfUnregisteredValue obj)
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

		~SdfUnregisteredValue()
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
						SdfPINVOKE.delete_SdfUnregisteredValue(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfUnregisteredValue()
			: this(SdfPINVOKE.new_SdfUnregisteredValue__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfUnregisteredValue(string value)
			: this(SdfPINVOKE.new_SdfUnregisteredValue__SWIG_1(value), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfUnregisteredValue(VtDictionary value)
			: this(SdfPINVOKE.new_SdfUnregisteredValue__SWIG_2(VtDictionary.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfUnregisteredValue(SdfUnregisteredValueListOp value)
			: this(SdfPINVOKE.new_SdfUnregisteredValue__SWIG_3(SdfUnregisteredValueListOp.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtValue GetValue()
		{
			return new VtValue(SdfPINVOKE.SdfUnregisteredValue_GetValue(swigCPtr), cMemoryOwn: false);
		}
	}
}
