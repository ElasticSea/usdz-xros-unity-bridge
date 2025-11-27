using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class KindTokens : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static TfToken assembly = new TfToken("assembly");

		public static TfToken component = new TfToken("component");

		public static TfToken group = new TfToken("group");

		public static TfToken model = new TfToken("model");

		public static TfToken subcomponent = new TfToken("subcomponent");

		public KindTokens(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(KindTokens obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(KindTokens obj)
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

		~KindTokens()
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
