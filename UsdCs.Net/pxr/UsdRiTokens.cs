using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdRiTokens : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static TfToken bspline = new TfToken("bspline");

		public static TfToken catmullRom = new TfToken("catmull-rom");

		public static TfToken constant = new TfToken("constant");

		public static TfToken interpolation = new TfToken("interpolation");

		public static TfToken linear = new TfToken("linear");

		public static TfToken outputsRiDisplacement = new TfToken("outputs:ri:displacement");

		public static TfToken outputsRiSurface = new TfToken("outputs:ri:surface");

		public static TfToken outputsRiVolume = new TfToken("outputs:ri:volume");

		public static TfToken positions = new TfToken("positions");

		public static TfToken renderContext = new TfToken("ri");

		public static TfToken spline = new TfToken("spline");

		public static TfToken values = new TfToken("values");

		public UsdRiTokens(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdRiTokens obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdRiTokens obj)
		{
			if (obj != null)
			{
				if (!obj.swigCMemOwn)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef result = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				return result;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		~UsdRiTokens()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						throw new MethodAccessException("C++ destructor does not have public access");
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}
	}
}
