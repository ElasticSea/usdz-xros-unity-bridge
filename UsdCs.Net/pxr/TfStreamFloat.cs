using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfStreamFloat : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public float value
		{
			get
			{
				return TfPINVOKE.TfStreamFloat_value_get(swigCPtr);
			}
			set
			{
				TfPINVOKE.TfStreamFloat_value_set(swigCPtr, value);
			}
		}

		public TfStreamFloat(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfStreamFloat obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfStreamFloat obj)
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

		~TfStreamFloat()
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
						TfPINVOKE.delete_TfStreamFloat(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfStreamFloat(float f)
			: this(TfPINVOKE.new_TfStreamFloat(f), cMemoryOwn: true)
		{
		}
	}
}
