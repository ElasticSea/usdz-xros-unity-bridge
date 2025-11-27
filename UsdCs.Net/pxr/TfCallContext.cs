using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfCallContext : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfCallContext(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfCallContext obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfCallContext obj)
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

		~TfCallContext()
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
						TfPINVOKE.delete_TfCallContext(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfCallContext()
			: this(TfPINVOKE.new_TfCallContext__SWIG_0(), cMemoryOwn: true)
		{
		}

		public TfCallContext(string file, string function, uint line, string prettyFunction)
			: this(TfPINVOKE.new_TfCallContext__SWIG_1(file, function, line, prettyFunction), cMemoryOwn: true)
		{
		}

		public string GetFile()
		{
			return TfPINVOKE.TfCallContext_GetFile(swigCPtr);
		}

		public string GetFunction()
		{
			return TfPINVOKE.TfCallContext_GetFunction(swigCPtr);
		}

		public uint GetLine()
		{
			return TfPINVOKE.TfCallContext_GetLine(swigCPtr);
		}

		public string GetPrettyFunction()
		{
			return TfPINVOKE.TfCallContext_GetPrettyFunction(swigCPtr);
		}

		public TfCallContext Hide()
		{
			return new TfCallContext(TfPINVOKE.TfCallContext_Hide(swigCPtr), cMemoryOwn: false);
		}

		public bool IsHidden()
		{
			return TfPINVOKE.TfCallContext_IsHidden(swigCPtr);
		}
	}
}
