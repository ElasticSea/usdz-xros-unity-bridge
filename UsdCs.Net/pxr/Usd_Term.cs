using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class Usd_Term : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public Usd_PrimFlags flag
		{
			get
			{
				return (Usd_PrimFlags)UsdPINVOKE.Usd_Term_flag_get(swigCPtr);
			}
			set
			{
				UsdPINVOKE.Usd_Term_flag_set(swigCPtr, (int)value);
			}
		}

		public bool negated
		{
			get
			{
				return UsdPINVOKE.Usd_Term_negated_get(swigCPtr);
			}
			set
			{
				UsdPINVOKE.Usd_Term_negated_set(swigCPtr, value);
			}
		}

		public Usd_Term(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(Usd_Term obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(Usd_Term obj)
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

		~Usd_Term()
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
						UsdPINVOKE.delete_Usd_Term(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public Usd_Term(Usd_PrimFlags flag)
			: this(UsdPINVOKE.new_Usd_Term__SWIG_0((int)flag), cMemoryOwn: true)
		{
		}

		public Usd_Term(Usd_PrimFlags flag, bool negated)
			: this(UsdPINVOKE.new_Usd_Term__SWIG_1((int)flag, negated), cMemoryOwn: true)
		{
		}
	}
}
