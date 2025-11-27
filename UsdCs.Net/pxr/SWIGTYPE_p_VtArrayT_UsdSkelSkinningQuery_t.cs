using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
