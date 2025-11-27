using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class Usd_PrimFlagsPredicate : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public Usd_PrimFlagsPredicate(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(Usd_PrimFlagsPredicate obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(Usd_PrimFlagsPredicate obj)
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

		~Usd_PrimFlagsPredicate()
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
						UsdPINVOKE.delete_Usd_PrimFlagsPredicate(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public Usd_PrimFlagsPredicate()
			: this(UsdPINVOKE.new_Usd_PrimFlagsPredicate__SWIG_0(), cMemoryOwn: true)
		{
		}

		public Usd_PrimFlagsPredicate(Usd_PrimFlags flag)
			: this(UsdPINVOKE.new_Usd_PrimFlagsPredicate__SWIG_1((int)flag), cMemoryOwn: true)
		{
		}

		public Usd_PrimFlagsPredicate(Usd_Term term)
			: this(UsdPINVOKE.new_Usd_PrimFlagsPredicate__SWIG_2(Usd_Term.getCPtr(term)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static Usd_PrimFlagsPredicate Tautology()
		{
			return new Usd_PrimFlagsPredicate(UsdPINVOKE.Usd_PrimFlagsPredicate_Tautology(), cMemoryOwn: true);
		}

		public static Usd_PrimFlagsPredicate Contradiction()
		{
			return new Usd_PrimFlagsPredicate(UsdPINVOKE.Usd_PrimFlagsPredicate_Contradiction(), cMemoryOwn: true);
		}

		public Usd_PrimFlagsPredicate TraverseInstanceProxies(bool traverse)
		{
			return new Usd_PrimFlagsPredicate(UsdPINVOKE.Usd_PrimFlagsPredicate_TraverseInstanceProxies(swigCPtr, traverse), cMemoryOwn: false);
		}

		public bool IncludeInstanceProxiesInTraversal()
		{
			return UsdPINVOKE.Usd_PrimFlagsPredicate_IncludeInstanceProxiesInTraversal(swigCPtr);
		}
	}
}
