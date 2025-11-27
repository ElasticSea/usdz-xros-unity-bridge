using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfTokenFastArbitraryLessThan : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfTokenFastArbitraryLessThan(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfTokenFastArbitraryLessThan obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfTokenFastArbitraryLessThan obj)
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

		~TfTokenFastArbitraryLessThan()
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
						TfPINVOKE.delete_TfTokenFastArbitraryLessThan(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfTokenFastArbitraryLessThan()
			: this(TfPINVOKE.new_TfTokenFastArbitraryLessThan(), cMemoryOwn: true)
		{
		}
	}
}
