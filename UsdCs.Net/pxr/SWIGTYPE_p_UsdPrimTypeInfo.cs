using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_UsdPrimTypeInfo
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_UsdPrimTypeInfo(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_UsdPrimTypeInfo()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_UsdPrimTypeInfo obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_UsdPrimTypeInfo obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
