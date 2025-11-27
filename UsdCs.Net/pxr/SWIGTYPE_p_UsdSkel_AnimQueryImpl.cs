using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_UsdSkel_AnimQueryImpl
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_UsdSkel_AnimQueryImpl(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_UsdSkel_AnimQueryImpl()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_UsdSkel_AnimQueryImpl obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_UsdSkel_AnimQueryImpl obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
