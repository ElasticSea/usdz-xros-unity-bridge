using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_pxr_tsl__robin_setT_TfToken_TfToken__HashFunctor_t
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_pxr_tsl__robin_setT_TfToken_TfToken__HashFunctor_t(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_pxr_tsl__robin_setT_TfToken_TfToken__HashFunctor_t()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_pxr_tsl__robin_setT_TfToken_TfToken__HashFunctor_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_pxr_tsl__robin_setT_TfToken_TfToken__HashFunctor_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
