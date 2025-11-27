using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdResolveTarget : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdResolveTarget(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdResolveTarget obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdResolveTarget obj)
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

		~UsdResolveTarget()
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
						UsdPINVOKE.delete_UsdResolveTarget(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdResolveTarget()
			: this(UsdPINVOKE.new_UsdResolveTarget(), cMemoryOwn: true)
		{
		}

		public PcpPrimIndex GetPrimIndex()
		{
			IntPtr intPtr = UsdPINVOKE.UsdResolveTarget_GetPrimIndex(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new PcpPrimIndex(intPtr, cMemoryOwn: false);
		}

		public PcpNodeRef GetStartNode()
		{
			return new PcpNodeRef(UsdPINVOKE.UsdResolveTarget_GetStartNode(swigCPtr), cMemoryOwn: true);
		}

		public SdfLayerHandle GetStartLayer()
		{
			return new SdfLayerHandle(UsdPINVOKE.UsdResolveTarget_GetStartLayer(swigCPtr), cMemoryOwn: true);
		}

		public PcpNodeRef GetStopNode()
		{
			return new PcpNodeRef(UsdPINVOKE.UsdResolveTarget_GetStopNode(swigCPtr), cMemoryOwn: true);
		}

		public SdfLayerHandle GetStopLayer()
		{
			return new SdfLayerHandle(UsdPINVOKE.UsdResolveTarget_GetStopLayer(swigCPtr), cMemoryOwn: true);
		}

		public bool IsNull()
		{
			return UsdPINVOKE.UsdResolveTarget_IsNull(swigCPtr);
		}
	}
}
