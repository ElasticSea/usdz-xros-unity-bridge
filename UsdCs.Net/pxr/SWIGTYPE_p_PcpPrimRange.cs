using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_PcpPrimRange
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_PcpPrimRange(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_PcpPrimRange()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_PcpPrimRange obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_PcpPrimRange obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
