using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p_SdfVariantSetNamesProxy
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p_SdfVariantSetNamesProxy(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p_SdfVariantSetNamesProxy()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p_SdfVariantSetNamesProxy obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p_SdfVariantSetNamesProxy obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
