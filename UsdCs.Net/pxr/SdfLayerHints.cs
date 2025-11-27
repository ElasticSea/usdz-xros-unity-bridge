using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerHints : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public bool mightHaveRelocates
		{
			get
			{
				return SdfPINVOKE.SdfLayerHints_mightHaveRelocates_get(swigCPtr);
			}
			set
			{
				SdfPINVOKE.SdfLayerHints_mightHaveRelocates_set(swigCPtr, value);
			}
		}

		public SdfLayerHints(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerHints obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerHints obj)
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

		~SdfLayerHints()
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
						SdfPINVOKE.delete_SdfLayerHints(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfLayerHints()
			: this(SdfPINVOKE.new_SdfLayerHints__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfLayerHints(bool mightHaveRelocates)
			: this(SdfPINVOKE.new_SdfLayerHints__SWIG_1(mightHaveRelocates), cMemoryOwn: true)
		{
		}
	}
}
