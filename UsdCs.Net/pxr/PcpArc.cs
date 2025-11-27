using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpArc : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public PcpArcType type
		{
			get
			{
				return (PcpArcType)PcpPINVOKE.PcpArc_type_get(swigCPtr);
			}
			set
			{
				PcpPINVOKE.PcpArc_type_set(swigCPtr, (int)value);
			}
		}

		public PcpNodeRef parent
		{
			get
			{
				IntPtr intPtr = PcpPINVOKE.PcpArc_parent_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new PcpNodeRef(intPtr, cMemoryOwn: false);
			}
			set
			{
				PcpPINVOKE.PcpArc_parent_set(swigCPtr, PcpNodeRef.getCPtr(value));
			}
		}

		public PcpNodeRef origin
		{
			get
			{
				IntPtr intPtr = PcpPINVOKE.PcpArc_origin_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new PcpNodeRef(intPtr, cMemoryOwn: false);
			}
			set
			{
				PcpPINVOKE.PcpArc_origin_set(swigCPtr, PcpNodeRef.getCPtr(value));
			}
		}

		public SWIGTYPE_p_PcpMapExpression mapToParent
		{
			get
			{
				IntPtr intPtr = PcpPINVOKE.PcpArc_mapToParent_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_PcpMapExpression(intPtr, futureUse: false);
			}
			set
			{
				PcpPINVOKE.PcpArc_mapToParent_set(swigCPtr, SWIGTYPE_p_PcpMapExpression.getCPtr(value));
			}
		}

		public int siblingNumAtOrigin
		{
			get
			{
				return PcpPINVOKE.PcpArc_siblingNumAtOrigin_get(swigCPtr);
			}
			set
			{
				PcpPINVOKE.PcpArc_siblingNumAtOrigin_set(swigCPtr, value);
			}
		}

		public int namespaceDepth
		{
			get
			{
				return PcpPINVOKE.PcpArc_namespaceDepth_get(swigCPtr);
			}
			set
			{
				PcpPINVOKE.PcpArc_namespaceDepth_set(swigCPtr, value);
			}
		}

		public PcpArc(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpArc obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpArc obj)
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

		~PcpArc()
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
						PcpPINVOKE.delete_PcpArc(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpArc()
			: this(PcpPINVOKE.new_PcpArc(), cMemoryOwn: true)
		{
		}
	}
}
