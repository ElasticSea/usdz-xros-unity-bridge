using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_PcpSiteStr
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_PcpSiteStr(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_PcpSiteStr()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_PcpSiteStr obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_PcpSiteStr obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
