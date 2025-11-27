using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfError : TfDiagnosticBase
	{
		private HandleRef swigCPtr;

		public TfError(IntPtr cPtr, bool cMemoryOwn)
			: base(TfPINVOKE.TfError_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfError obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfError obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						TfPINVOKE.delete_TfError(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public TfEnum GetErrorCode()
		{
			return new TfEnum(TfPINVOKE.TfError_GetErrorCode(swigCPtr), cMemoryOwn: true);
		}

		public string GetErrorCodeAsString()
		{
			return TfPINVOKE.TfError_GetErrorCodeAsString(swigCPtr);
		}
	}
}
