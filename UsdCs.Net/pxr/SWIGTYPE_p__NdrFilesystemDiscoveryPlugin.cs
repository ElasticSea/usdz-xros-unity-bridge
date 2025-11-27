using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SWIGTYPE_p__NdrFilesystemDiscoveryPlugin
	{
		private HandleRef swigCPtr;

		public SWIGTYPE_p__NdrFilesystemDiscoveryPlugin(IntPtr cPtr, bool futureUse)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public SWIGTYPE_p__NdrFilesystemDiscoveryPlugin()
		{
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef getCPtr(SWIGTYPE_p__NdrFilesystemDiscoveryPlugin obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SWIGTYPE_p__NdrFilesystemDiscoveryPlugin obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}
	}
}
