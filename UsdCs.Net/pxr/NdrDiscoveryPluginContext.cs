using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrDiscoveryPluginContext : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

		internal NdrDiscoveryPluginContext(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(NdrDiscoveryPluginContext obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~NdrDiscoveryPluginContext()
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
					if (swigCMemOwnBase)
					{
						swigCMemOwnBase = false;
						NdrPINVOKE.delete_NdrDiscoveryPluginContext(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public virtual TfToken GetSourceType(TfToken discoveryType)
		{
			TfToken result = new TfToken(NdrPINVOKE.NdrDiscoveryPluginContext_GetSourceType(swigCPtr, TfToken.getCPtr(discoveryType)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
