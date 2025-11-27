using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_f_p_Vt_ArrayForeignDataSource__void obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
