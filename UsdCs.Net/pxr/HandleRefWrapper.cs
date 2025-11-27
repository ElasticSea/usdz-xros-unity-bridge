using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class HandleRefWrapper : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public IntPtr handlePtr
		{
			get
			{
				return SdfPINVOKE.HandleRefWrapper_handlePtr_get(swigCPtr);
			}
			set
			{
				SdfPINVOKE.HandleRefWrapper_handlePtr_set(swigCPtr, value);
			}
		}

		public IntPtr refPtr
		{
			get
			{
				return SdfPINVOKE.HandleRefWrapper_refPtr_get(swigCPtr);
			}
			set
			{
				SdfPINVOKE.HandleRefWrapper_refPtr_set(swigCPtr, value);
			}
		}

		public HandleRefWrapper(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(HandleRefWrapper obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(HandleRefWrapper obj)
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

		~HandleRefWrapper()
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
						SdfPINVOKE.delete_HandleRefWrapper(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public HandleRefWrapper()
			: this(SdfPINVOKE.new_HandleRefWrapper(), cMemoryOwn: true)
		{
		}
	}
}
