using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrDiscoveryPlugin : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

		internal NdrDiscoveryPlugin(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(NdrDiscoveryPlugin obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~NdrDiscoveryPlugin()
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
						NdrPINVOKE.delete_NdrDiscoveryPlugin(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public virtual NdrNodeDiscoveryResultVector DiscoverNodes(NdrDiscoveryPluginContext arg0)
		{
			NdrNodeDiscoveryResultVector result = new NdrNodeDiscoveryResultVector(NdrPINVOKE.NdrDiscoveryPlugin_DiscoverNodes(swigCPtr, NdrDiscoveryPluginContext.getCPtr(arg0)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual StdStringVector GetSearchURIs()
		{
			StdStringVector result = new StdStringVector(NdrPINVOKE.NdrDiscoveryPlugin_GetSearchURIs(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
