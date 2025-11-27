using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfTupleDimensions : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SWIGTYPE_p_size_t d
		{
			get
			{
				IntPtr intPtr = SdfPINVOKE.SdfTupleDimensions_d_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_size_t(intPtr, futureUse: false);
			}
			set
			{
				SdfPINVOKE.SdfTupleDimensions_d_set(swigCPtr, SWIGTYPE_p_size_t.getCPtr(value));
			}
		}

		public uint size
		{
			get
			{
				return SdfPINVOKE.SdfTupleDimensions_size_get(swigCPtr);
			}
			set
			{
				SdfPINVOKE.SdfTupleDimensions_size_set(swigCPtr, value);
			}
		}

		public SdfTupleDimensions(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfTupleDimensions obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfTupleDimensions obj)
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

		~SdfTupleDimensions()
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
						SdfPINVOKE.delete_SdfTupleDimensions(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfTupleDimensions()
			: this(SdfPINVOKE.new_SdfTupleDimensions__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfTupleDimensions(uint m)
			: this(SdfPINVOKE.new_SdfTupleDimensions__SWIG_1(m), cMemoryOwn: true)
		{
		}

		public SdfTupleDimensions(uint m, uint n)
			: this(SdfPINVOKE.new_SdfTupleDimensions__SWIG_2(m, n), cMemoryOwn: true)
		{
		}

		public SdfTupleDimensions(SWIGTYPE_p_a_2__size_t s)
			: this(SdfPINVOKE.new_SdfTupleDimensions__SWIG_3(SWIGTYPE_p_a_2__size_t.getCPtr(s)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
