using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrParserPlugin : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public NdrParserPlugin(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrParserPlugin obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrParserPlugin obj)
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

		~NdrParserPlugin()
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
						NdrPINVOKE.delete_NdrParserPlugin(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public virtual TfTokenVector GetDiscoveryTypes()
		{
			return new TfTokenVector(NdrPINVOKE.NdrParserPlugin_GetDiscoveryTypes(swigCPtr), cMemoryOwn: false);
		}

		public virtual TfToken GetSourceType()
		{
			return new TfToken(NdrPINVOKE.NdrParserPlugin_GetSourceType(swigCPtr), cMemoryOwn: false);
		}
	}
}
