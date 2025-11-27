using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpPropertyIndex : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public PcpPropertyIndex(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpPropertyIndex obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpPropertyIndex obj)
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

		~PcpPropertyIndex()
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
						PcpPINVOKE.delete_PcpPropertyIndex(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpPropertyIndex()
			: this(PcpPINVOKE.new_PcpPropertyIndex__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PcpPropertyIndex(PcpPropertyIndex rhs)
			: this(PcpPINVOKE.new_PcpPropertyIndex__SWIG_1(getCPtr(rhs)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Swap(PcpPropertyIndex index)
		{
			PcpPINVOKE.PcpPropertyIndex_Swap(swigCPtr, getCPtr(index));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsEmpty()
		{
			return PcpPINVOKE.PcpPropertyIndex_IsEmpty(swigCPtr);
		}

		public SWIGTYPE_p_PcpPropertyRange GetPropertyRange(bool localOnly)
		{
			return new SWIGTYPE_p_PcpPropertyRange(PcpPINVOKE.PcpPropertyIndex_GetPropertyRange__SWIG_0(swigCPtr, localOnly), futureUse: true);
		}

		public SWIGTYPE_p_PcpPropertyRange GetPropertyRange()
		{
			return new SWIGTYPE_p_PcpPropertyRange(PcpPINVOKE.PcpPropertyIndex_GetPropertyRange__SWIG_1(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_PcpErrorVector GetLocalErrors()
		{
			return new SWIGTYPE_p_PcpErrorVector(PcpPINVOKE.PcpPropertyIndex_GetLocalErrors(swigCPtr), futureUse: true);
		}

		public uint GetNumLocalSpecs()
		{
			return PcpPINVOKE.PcpPropertyIndex_GetNumLocalSpecs(swigCPtr);
		}
	}
}
