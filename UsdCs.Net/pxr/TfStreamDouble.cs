using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfStreamDouble : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public double value
		{
			get
			{
				return TfPINVOKE.TfStreamDouble_value_get(swigCPtr);
			}
			set
			{
				TfPINVOKE.TfStreamDouble_value_set(swigCPtr, value);
			}
		}

		public TfStreamDouble(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfStreamDouble obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfStreamDouble obj)
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

		~TfStreamDouble()
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
						TfPINVOKE.delete_TfStreamDouble(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfStreamDouble(double d)
			: this(TfPINVOKE.new_TfStreamDouble(d), cMemoryOwn: true)
		{
		}
	}
}
