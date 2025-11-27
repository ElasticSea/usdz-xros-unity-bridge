using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_UsdShadeAttributeType
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_UsdShadeAttributeType(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_UsdShadeAttributeType()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_UsdShadeAttributeType obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_UsdShadeAttributeType obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
