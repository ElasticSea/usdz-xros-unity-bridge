using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class Vt_ArrayForeignDataSource : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public Vt_ArrayForeignDataSource(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(Vt_ArrayForeignDataSource obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(Vt_ArrayForeignDataSource obj)
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

		~Vt_ArrayForeignDataSource()
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
						VtPINVOKE.delete_Vt_ArrayForeignDataSource(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public Vt_ArrayForeignDataSource(SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void detachedFn, uint initRefCount)
			: this(VtPINVOKE.new_Vt_ArrayForeignDataSource__SWIG_0(SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void.getCPtr(detachedFn), initRefCount), cMemoryOwn: true)
		{
		}

		public Vt_ArrayForeignDataSource(SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void detachedFn)
			: this(VtPINVOKE.new_Vt_ArrayForeignDataSource__SWIG_1(SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void.getCPtr(detachedFn)), cMemoryOwn: true)
		{
		}

		public Vt_ArrayForeignDataSource()
			: this(VtPINVOKE.new_Vt_ArrayForeignDataSource__SWIG_2(), cMemoryOwn: true)
		{
		}
	}
}
