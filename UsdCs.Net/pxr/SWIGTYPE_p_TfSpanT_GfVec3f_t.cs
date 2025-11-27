using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_TfSpanT_GfVec3f_t
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_TfSpanT_GfVec3f_t(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_TfSpanT_GfVec3f_t()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_TfSpanT_GfVec3f_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_TfSpanT_GfVec3f_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
