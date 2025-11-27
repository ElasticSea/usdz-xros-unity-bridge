using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VariantEditContext : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdStage first
		{
			get
			{
				IntPtr intPtr = UsdPINVOKE.VariantEditContext_first_get(swigCPtr);
				UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				UsdPINVOKE.VariantEditContext_first_set(swigCPtr, UsdStage.getCPtr(value));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public UsdEditTarget second
		{
			get
			{
				IntPtr intPtr = UsdPINVOKE.VariantEditContext_second_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new UsdEditTarget(intPtr, cMemoryOwn: false);
			}
			set
			{
				UsdPINVOKE.VariantEditContext_second_set(swigCPtr, UsdEditTarget.getCPtr(value));
			}
		}

		public VariantEditContext(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VariantEditContext obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VariantEditContext obj)
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

		~VariantEditContext()
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
						UsdPINVOKE.delete_VariantEditContext(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public VariantEditContext()
			: this(UsdPINVOKE.new_VariantEditContext__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VariantEditContext(UsdStage first, UsdEditTarget second)
			: this(UsdPINVOKE.new_VariantEditContext__SWIG_1(UsdStage.getCPtr(first), UsdEditTarget.getCPtr(second)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VariantEditContext(VariantEditContext other)
			: this(UsdPINVOKE.new_VariantEditContext__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
