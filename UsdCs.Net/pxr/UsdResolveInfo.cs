using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdResolveInfo : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdResolveInfo(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdResolveInfo obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdResolveInfo obj)
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

		~UsdResolveInfo()
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
						UsdPINVOKE.delete_UsdResolveInfo(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdResolveInfo()
			: this(UsdPINVOKE.new_UsdResolveInfo(), cMemoryOwn: true)
		{
		}

		public UsdResolveInfoSource GetSource()
		{
			return (UsdResolveInfoSource)UsdPINVOKE.UsdResolveInfo_GetSource(swigCPtr);
		}

		public bool HasAuthoredValueOpinion()
		{
			return UsdPINVOKE.UsdResolveInfo_HasAuthoredValueOpinion(swigCPtr);
		}

		public bool HasAuthoredValue()
		{
			return UsdPINVOKE.UsdResolveInfo_HasAuthoredValue(swigCPtr);
		}

		public PcpNodeRef GetNode()
		{
			return new PcpNodeRef(UsdPINVOKE.UsdResolveInfo_GetNode(swigCPtr), cMemoryOwn: true);
		}

		public bool ValueIsBlocked()
		{
			return UsdPINVOKE.UsdResolveInfo_ValueIsBlocked(swigCPtr);
		}
	}
}
