using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_TfSpanT_GfQuatf_t
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_TfSpanT_GfQuatf_t(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_TfSpanT_GfQuatf_t()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_TfSpanT_GfQuatf_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_TfSpanT_GfQuatf_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
