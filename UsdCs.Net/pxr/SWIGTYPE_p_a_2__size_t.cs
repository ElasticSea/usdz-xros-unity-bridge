using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_a_2__size_t
	{
		private HandleRef swigCPtr;

		internal SWIGTYPE_p_a_2__size_t(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		protected SWIGTYPE_p_a_2__size_t()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		internal static HandleRef getCPtr(SWIGTYPE_p_a_2__size_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		internal static HandleRef swigRelease(SWIGTYPE_p_a_2__size_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
