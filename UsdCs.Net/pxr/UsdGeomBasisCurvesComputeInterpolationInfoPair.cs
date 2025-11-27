using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomBasisCurvesComputeInterpolationInfoPair : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfToken first
		{
			get
			{
				IntPtr intPtr = UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfoPair_first_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfoPair_first_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public uint second
		{
			get
			{
				return UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfoPair_second_get(swigCPtr);
			}
			set
			{
				UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfoPair_second_set(swigCPtr, value);
			}
		}

		public UsdGeomBasisCurvesComputeInterpolationInfoPair(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomBasisCurvesComputeInterpolationInfoPair obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomBasisCurvesComputeInterpolationInfoPair obj)
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

		~UsdGeomBasisCurvesComputeInterpolationInfoPair()
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
						UsdGeomPINVOKE.delete_UsdGeomBasisCurvesComputeInterpolationInfoPair(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomBasisCurvesComputeInterpolationInfoPair()
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdGeomBasisCurvesComputeInterpolationInfoPair(TfToken first, uint second)
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_1(TfToken.getCPtr(first), second), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomBasisCurvesComputeInterpolationInfoPair(UsdGeomBasisCurvesComputeInterpolationInfoPair other)
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
