using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class Usd_PrimFlagsConjunction : Usd_PrimFlagsPredicate
	{
		private HandleRef swigCPtr;

		public Usd_PrimFlagsConjunction(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.Usd_PrimFlagsConjunction_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(Usd_PrimFlagsConjunction obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(Usd_PrimFlagsConjunction obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						UsdPINVOKE.delete_Usd_PrimFlagsConjunction(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public Usd_PrimFlagsConjunction()
			: this(UsdPINVOKE.new_Usd_PrimFlagsConjunction__SWIG_0(), cMemoryOwn: true)
		{
		}

		public Usd_PrimFlagsConjunction(Usd_Term term)
			: this(UsdPINVOKE.new_Usd_PrimFlagsConjunction__SWIG_1(Usd_Term.getCPtr(term)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
