using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelSkinningQuery : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdSkelSkinningQuery(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelSkinningQuery obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelSkinningQuery obj)
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

		~UsdSkelSkinningQuery()
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
						UsdSkelPINVOKE.delete_UsdSkelSkinningQuery(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelSkinningQuery()
			: this(UsdSkelPINVOKE.new_UsdSkelSkinningQuery__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkelSkinningQuery(UsdPrim prim, VtTokenArray skelJointOrder, VtTokenArray blendShapeOrder, UsdAttribute jointIndices, UsdAttribute jointWeights, UsdAttribute skinningMethod, UsdAttribute geomBindTransform, UsdAttribute joints, UsdAttribute blendShapes, UsdRelationship blendShapeTargets)
			: this(UsdSkelPINVOKE.new_UsdSkelSkinningQuery__SWIG_1(UsdPrim.getCPtr(prim), VtTokenArray.getCPtr(skelJointOrder), VtTokenArray.getCPtr(blendShapeOrder), UsdAttribute.getCPtr(jointIndices), UsdAttribute.getCPtr(jointWeights), UsdAttribute.getCPtr(skinningMethod), UsdAttribute.getCPtr(geomBindTransform), UsdAttribute.getCPtr(joints), UsdAttribute.getCPtr(blendShapes), UsdRelationship.getCPtr(blendShapeTargets)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsValid()
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_IsValid(swigCPtr);
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetPrim(swigCPtr), cMemoryOwn: false);
		}

		public bool HasBlendShapes()
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_HasBlendShapes(swigCPtr);
		}

		public bool HasJointInfluences()
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_HasJointInfluences(swigCPtr);
		}

		public int GetNumInfluencesPerComponent()
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_GetNumInfluencesPerComponent(swigCPtr);
		}

		public TfToken GetInterpolation()
		{
			return new TfToken(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetInterpolation(swigCPtr), cMemoryOwn: false);
		}

		public bool IsRigidlyDeformed()
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_IsRigidlyDeformed(swigCPtr);
		}

		public UsdAttribute GetSkinningMethodAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetSkinningMethodAttr(swigCPtr), cMemoryOwn: false);
		}

		public UsdAttribute GetGeomBindTransformAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetGeomBindTransformAttr(swigCPtr), cMemoryOwn: false);
		}

		public UsdGeomPrimvar GetJointIndicesPrimvar()
		{
			return new UsdGeomPrimvar(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetJointIndicesPrimvar(swigCPtr), cMemoryOwn: false);
		}

		public UsdGeomPrimvar GetJointWeightsPrimvar()
		{
			return new UsdGeomPrimvar(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetJointWeightsPrimvar(swigCPtr), cMemoryOwn: false);
		}

		public UsdAttribute GetBlendShapesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetBlendShapesAttr(swigCPtr), cMemoryOwn: false);
		}

		public UsdRelationship GetBlendShapeTargetsRel()
		{
			return new UsdRelationship(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetBlendShapeTargetsRel(swigCPtr), cMemoryOwn: false);
		}

		public UsdSkelAnimMapper GetJointMapper()
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelSkinningQuery_GetJointMapper(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new UsdSkelAnimMapper(intPtr, cMemoryOwn: true);
		}

		public UsdSkelAnimMapper GetMapper()
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelSkinningQuery_GetMapper(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new UsdSkelAnimMapper(intPtr, cMemoryOwn: true);
		}

		public UsdSkelAnimMapper GetBlendShapeMapper()
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelSkinningQuery_GetBlendShapeMapper(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new UsdSkelAnimMapper(intPtr, cMemoryOwn: true);
		}

		public bool GetJointOrder(VtTokenArray jointOrder)
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_GetJointOrder(swigCPtr, VtTokenArray.getCPtr(jointOrder));
		}

		public bool GetBlendShapeOrder(VtTokenArray blendShapes)
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_GetBlendShapeOrder(swigCPtr, VtTokenArray.getCPtr(blendShapes));
		}

		public bool GetTimeSamples(StdDoubleVector times)
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_GetTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
		}

		public bool ComputeJointInfluences(VtIntArray indices, VtFloatArray weights, UsdTimeCode time)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinningQuery_ComputeJointInfluences__SWIG_0(swigCPtr, VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeJointInfluences(VtIntArray indices, VtFloatArray weights)
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_ComputeJointInfluences__SWIG_1(swigCPtr, VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights));
		}

		public bool ComputeVaryingJointInfluences(uint numPoints, VtIntArray indices, VtFloatArray weights, UsdTimeCode time)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinningQuery_ComputeVaryingJointInfluences__SWIG_0(swigCPtr, numPoints, VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeVaryingJointInfluences(uint numPoints, VtIntArray indices, VtFloatArray weights)
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_ComputeVaryingJointInfluences__SWIG_1(swigCPtr, numPoints, VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights));
		}

		public TfToken GetSkinningMethod()
		{
			return new TfToken(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetSkinningMethod(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix4d GetGeomBindTransform(UsdTimeCode time)
		{
			GfMatrix4d result = new GfMatrix4d(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetGeomBindTransform__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d GetGeomBindTransform()
		{
			return new GfMatrix4d(UsdSkelPINVOKE.UsdSkelSkinningQuery_GetGeomBindTransform__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public string GetDescription()
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQuery_GetDescription(swigCPtr);
		}
	}
}
