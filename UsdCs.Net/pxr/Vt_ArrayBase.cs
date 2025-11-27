using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class Vt_ArrayBase : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public Vt_ArrayBase(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(Vt_ArrayBase obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(Vt_ArrayBase obj)
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

		~Vt_ArrayBase()
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
						VtPINVOKE.delete_Vt_ArrayBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public Vt_ArrayBase()
			: this(VtPINVOKE.new_Vt_ArrayBase__SWIG_0(), cMemoryOwn: true)
		{
		}

		public Vt_ArrayBase(Vt_ArrayForeignDataSource foreignSrc)
			: this(VtPINVOKE.new_Vt_ArrayBase__SWIG_1(Vt_ArrayForeignDataSource.getCPtr(foreignSrc)), cMemoryOwn: true)
		{
		}

		public Vt_ArrayBase(Vt_ArrayBase other)
			: this(VtPINVOKE.new_Vt_ArrayBase__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
