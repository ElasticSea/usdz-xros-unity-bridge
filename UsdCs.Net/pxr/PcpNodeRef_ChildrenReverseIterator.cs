using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpNodeRef_ChildrenReverseIterator : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public PcpNodeRef_ChildrenReverseIterator(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpNodeRef_ChildrenReverseIterator obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpNodeRef_ChildrenReverseIterator obj)
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

		~PcpNodeRef_ChildrenReverseIterator()
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
						PcpPINVOKE.delete_PcpNodeRef_ChildrenReverseIterator(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpNodeRef_ChildrenReverseIterator()
			: this(PcpPINVOKE.new_PcpNodeRef_ChildrenReverseIterator__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PcpNodeRef_ChildrenReverseIterator(PcpNodeRef_ChildrenIterator arg0)
			: this(PcpPINVOKE.new_PcpNodeRef_ChildrenReverseIterator__SWIG_1(PcpNodeRef_ChildrenIterator.getCPtr(arg0)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpNodeRef_ChildrenReverseIterator(PcpNodeRef node, bool end)
			: this(PcpPINVOKE.new_PcpNodeRef_ChildrenReverseIterator__SWIG_2(PcpNodeRef.getCPtr(node), end), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpNodeRef_ChildrenReverseIterator(PcpNodeRef node)
			: this(PcpPINVOKE.new_PcpNodeRef_ChildrenReverseIterator__SWIG_3(PcpNodeRef.getCPtr(node)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
