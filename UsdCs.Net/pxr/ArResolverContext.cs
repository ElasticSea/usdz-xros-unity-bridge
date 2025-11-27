using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class ArResolverContext : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public ArResolverContext(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(ArResolverContext obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(ArResolverContext obj)
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

		~ArResolverContext()
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
						ArPINVOKE.delete_ArResolverContext(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public ArResolverContext()
			: this(ArPINVOKE.new_ArResolverContext__SWIG_0(), cMemoryOwn: true)
		{
		}

		public ArResolverContext(SWIGTYPE_p_std__vectorT_ArResolverContext_t ctxs)
			: this(ArPINVOKE.new_ArResolverContext__SWIG_1(SWIGTYPE_p_std__vectorT_ArResolverContext_t.getCPtr(ctxs)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsEmpty()
		{
			return ArPINVOKE.ArResolverContext_IsEmpty(swigCPtr);
		}

		public string GetDebugString()
		{
			return ArPINVOKE.ArResolverContext_GetDebugString(swigCPtr);
		}
	}
}
