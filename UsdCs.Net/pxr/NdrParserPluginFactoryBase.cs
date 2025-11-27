using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrParserPluginFactoryBase : TfType.FactoryBase
	{
		private HandleRef swigCPtr;

		public NdrParserPluginFactoryBase(IntPtr cPtr, bool cMemoryOwn)
			: base(NdrPINVOKE.NdrParserPluginFactoryBase_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrParserPluginFactoryBase obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrParserPluginFactoryBase obj)
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
						NdrPINVOKE.delete_NdrParserPluginFactoryBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public virtual NdrParserPlugin New()
		{
			IntPtr intPtr = NdrPINVOKE.NdrParserPluginFactoryBase_New(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new NdrParserPlugin(intPtr, cMemoryOwn: false);
		}
	}
}
