using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpSiteTrackerSegment : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SWIGTYPE_p_PcpSiteStr site
		{
			get
			{
				SWIGTYPE_p_PcpSiteStr result = new SWIGTYPE_p_PcpSiteStr(PcpPINVOKE.PcpSiteTrackerSegment_site_get(swigCPtr), futureUse: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				PcpPINVOKE.PcpSiteTrackerSegment_site_set(swigCPtr, SWIGTYPE_p_PcpSiteStr.getCPtr(value));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public PcpArcType arcType
		{
			get
			{
				return (PcpArcType)PcpPINVOKE.PcpSiteTrackerSegment_arcType_get(swigCPtr);
			}
			set
			{
				PcpPINVOKE.PcpSiteTrackerSegment_arcType_set(swigCPtr, (int)value);
			}
		}

		public PcpSiteTrackerSegment(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpSiteTrackerSegment obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpSiteTrackerSegment obj)
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

		~PcpSiteTrackerSegment()
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
						PcpPINVOKE.delete_PcpSiteTrackerSegment(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpSiteTrackerSegment()
			: this(PcpPINVOKE.new_PcpSiteTrackerSegment(), cMemoryOwn: true)
		{
		}
	}
}
