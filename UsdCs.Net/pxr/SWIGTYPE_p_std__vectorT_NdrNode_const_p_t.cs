using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_std__vectorT_NdrNode_const_p_t
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_std__vectorT_NdrNode_const_p_t(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_std__vectorT_NdrNode_const_p_t()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_std__vectorT_NdrNode_const_p_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_std__vectorT_NdrNode_const_p_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
