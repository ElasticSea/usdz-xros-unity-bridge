using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpNodeRef_ChildrenIterator : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public PcpNodeRef_ChildrenIterator(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpNodeRef_ChildrenIterator obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpNodeRef_ChildrenIterator obj)
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

		~PcpNodeRef_ChildrenIterator()
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
						PcpPINVOKE.delete_PcpNodeRef_ChildrenIterator(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpNodeRef_ChildrenIterator()
			: this(PcpPINVOKE.new_PcpNodeRef_ChildrenIterator__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PcpNodeRef_ChildrenIterator(PcpNodeRef node, bool end)
			: this(PcpPINVOKE.new_PcpNodeRef_ChildrenIterator__SWIG_1(PcpNodeRef.getCPtr(node), end), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpNodeRef_ChildrenIterator(PcpNodeRef node)
			: this(PcpPINVOKE.new_PcpNodeRef_ChildrenIterator__SWIG_2(PcpNodeRef.getCPtr(node)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
