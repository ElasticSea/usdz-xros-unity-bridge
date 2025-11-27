using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrDiscoveryPluginFactoryBase : TfType.FactoryBase
	{
		private HandleRef swigCPtr;

		public NdrDiscoveryPluginFactoryBase(IntPtr cPtr, bool cMemoryOwn)
			: base(NdrPINVOKE.NdrDiscoveryPluginFactoryBase_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrDiscoveryPluginFactoryBase obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrDiscoveryPluginFactoryBase obj)
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
						NdrPINVOKE.delete_NdrDiscoveryPluginFactoryBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public virtual NdrDiscoveryPlugin New()
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginFactoryBase_New(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPlugin(intPtr, cMemoryOwn: true);
		}
	}
}
