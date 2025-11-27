using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfDiagnosticBase : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfDiagnosticBase(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfDiagnosticBase obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfDiagnosticBase obj)
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

		~TfDiagnosticBase()
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
						TfPINVOKE.delete_TfDiagnosticBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfCallContext GetContext()
		{
			return new TfCallContext(TfPINVOKE.TfDiagnosticBase_GetContext(swigCPtr), cMemoryOwn: false);
		}

		public string GetSourceFileName()
		{
			return TfPINVOKE.TfDiagnosticBase_GetSourceFileName(swigCPtr);
		}

		public uint GetSourceLineNumber()
		{
			return TfPINVOKE.TfDiagnosticBase_GetSourceLineNumber(swigCPtr);
		}

		public string GetCommentary()
		{
			return TfPINVOKE.TfDiagnosticBase_GetCommentary(swigCPtr);
		}

		public string GetSourceFunction()
		{
			return TfPINVOKE.TfDiagnosticBase_GetSourceFunction(swigCPtr);
		}

		public void AugmentCommentary(string s)
		{
			TfPINVOKE.TfDiagnosticBase_AugmentCommentary(swigCPtr, s);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfEnum GetDiagnosticCode()
		{
			return new TfEnum(TfPINVOKE.TfDiagnosticBase_GetDiagnosticCode(swigCPtr), cMemoryOwn: true);
		}

		public string GetDiagnosticCodeAsString()
		{
			return TfPINVOKE.TfDiagnosticBase_GetDiagnosticCodeAsString(swigCPtr);
		}

		public bool GetQuiet()
		{
			return TfPINVOKE.TfDiagnosticBase_GetQuiet(swigCPtr);
		}

		public bool IsFatal()
		{
			return TfPINVOKE.TfDiagnosticBase_IsFatal(swigCPtr);
		}

		public bool IsCodingError()
		{
			return TfPINVOKE.TfDiagnosticBase_IsCodingError(swigCPtr);
		}
	}
}
