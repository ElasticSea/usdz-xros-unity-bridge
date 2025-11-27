using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdStageLoadRulesPair : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfPath first
		{
			get
			{
				IntPtr intPtr = UsdPINVOKE.UsdStageLoadRulesPair_first_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfPath(intPtr, cMemoryOwn: false);
			}
			set
			{
				UsdPINVOKE.UsdStageLoadRulesPair_first_set(swigCPtr, SdfPath.getCPtr(value));
			}
		}

		public UsdStageLoadRules.Rule second
		{
			get
			{
				return (UsdStageLoadRules.Rule)UsdPINVOKE.UsdStageLoadRulesPair_second_get(swigCPtr);
			}
			set
			{
				UsdPINVOKE.UsdStageLoadRulesPair_second_set(swigCPtr, (int)value);
			}
		}

		public UsdStageLoadRulesPair(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdStageLoadRulesPair obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdStageLoadRulesPair obj)
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

		~UsdStageLoadRulesPair()
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
						UsdPINVOKE.delete_UsdStageLoadRulesPair(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdStageLoadRulesPair()
			: this(UsdPINVOKE.new_UsdStageLoadRulesPair__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdStageLoadRulesPair(SdfPath first, UsdStageLoadRules.Rule second)
			: this(UsdPINVOKE.new_UsdStageLoadRulesPair__SWIG_1(SdfPath.getCPtr(first), (int)second), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdStageLoadRulesPair(UsdStageLoadRulesPair other)
			: this(UsdPINVOKE.new_UsdStageLoadRulesPair__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
