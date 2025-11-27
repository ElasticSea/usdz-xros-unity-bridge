using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelAnimQuery : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdSkelAnimQuery(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelAnimQuery obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelAnimQuery obj)
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

		~UsdSkelAnimQuery()
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
						UsdSkelPINVOKE.delete_UsdSkelAnimQuery(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelAnimQuery()
			: this(UsdSkelPINVOKE.new_UsdSkelAnimQuery(), cMemoryOwn: true)
		{
		}

		public bool IsValid()
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_IsValid(swigCPtr);
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdSkelPINVOKE.UsdSkelAnimQuery_GetPrim(swigCPtr), cMemoryOwn: true);
		}

		public bool ComputeJointLocalTransformComponents(VtVec3fArray translations, VtQuatfArray rotations, VtVec3hArray scales, UsdTimeCode time)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimQuery_ComputeJointLocalTransformComponents__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(translations), VtQuatfArray.getCPtr(rotations), VtVec3hArray.getCPtr(scales), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeJointLocalTransformComponents(VtVec3fArray translations, VtQuatfArray rotations, VtVec3hArray scales)
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_ComputeJointLocalTransformComponents__SWIG_1(swigCPtr, VtVec3fArray.getCPtr(translations), VtQuatfArray.getCPtr(rotations), VtVec3hArray.getCPtr(scales));
		}

		public bool ComputeBlendShapeWeights(VtFloatArray weights, UsdTimeCode time)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimQuery_ComputeBlendShapeWeights__SWIG_0(swigCPtr, VtFloatArray.getCPtr(weights), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeBlendShapeWeights(VtFloatArray weights)
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_ComputeBlendShapeWeights__SWIG_1(swigCPtr, VtFloatArray.getCPtr(weights));
		}

		public bool GetJointTransformTimeSamples(StdDoubleVector times)
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_GetJointTransformTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
		}

		public bool GetJointTransformTimeSamplesInInterval(GfInterval interval, StdDoubleVector times)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimQuery_GetJointTransformTimeSamplesInInterval(swigCPtr, GfInterval.getCPtr(interval), StdDoubleVector.getCPtr(times));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetJointTransformAttributes(UsdAttributeVector attrs)
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_GetJointTransformAttributes(swigCPtr, UsdAttributeVector.getCPtr(attrs));
		}

		public bool JointTransformsMightBeTimeVarying()
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_JointTransformsMightBeTimeVarying(swigCPtr);
		}

		public bool GetBlendShapeWeightTimeSamples(StdDoubleVector attrs)
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_GetBlendShapeWeightTimeSamples(swigCPtr, StdDoubleVector.getCPtr(attrs));
		}

		public bool GetBlendShapeWeightTimeSamplesInInterval(GfInterval interval, StdDoubleVector times)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimQuery_GetBlendShapeWeightTimeSamplesInInterval(swigCPtr, GfInterval.getCPtr(interval), StdDoubleVector.getCPtr(times));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetBlendShapeWeightAttributes(UsdAttributeVector attrs)
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_GetBlendShapeWeightAttributes(swigCPtr, UsdAttributeVector.getCPtr(attrs));
		}

		public bool BlendShapeWeightsMightBeTimeVarying()
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_BlendShapeWeightsMightBeTimeVarying(swigCPtr);
		}

		public VtTokenArray GetJointOrder()
		{
			return new VtTokenArray(UsdSkelPINVOKE.UsdSkelAnimQuery_GetJointOrder(swigCPtr), cMemoryOwn: true);
		}

		public VtTokenArray GetBlendShapeOrder()
		{
			return new VtTokenArray(UsdSkelPINVOKE.UsdSkelAnimQuery_GetBlendShapeOrder(swigCPtr), cMemoryOwn: true);
		}

		public string GetDescription()
		{
			return UsdSkelPINVOKE.UsdSkelAnimQuery_GetDescription(swigCPtr);
		}
	}
}
