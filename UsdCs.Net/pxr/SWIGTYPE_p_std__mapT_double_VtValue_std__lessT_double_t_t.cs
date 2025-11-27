using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
