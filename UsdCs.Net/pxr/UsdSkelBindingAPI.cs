using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelBindingAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdSkelBindingAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdSkelPINVOKE.UsdSkelBindingAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelBindingAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelBindingAPI obj)
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
						UsdSkelPINVOKE.delete_UsdSkelBindingAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdSkelBindingAPI(UsdPrim prim)
			: this(UsdSkelPINVOKE.new_UsdSkelBindingAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelBindingAPI()
			: this(UsdSkelPINVOKE.new_UsdSkelBindingAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdSkelBindingAPI(UsdSchemaBase schemaObj)
			: this(UsdSkelPINVOKE.new_UsdSkelBindingAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelBindingAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelBindingAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdSkelBindingAPI Get(UsdStage stage, SdfPath path)
		{
			UsdSkelBindingAPI result = new UsdSkelBindingAPI(UsdSkelPINVOKE.UsdSkelBindingAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdSkelPINVOKE.UsdSkelBindingAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdSkelPINVOKE.UsdSkelBindingAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdSkelBindingAPI Apply(UsdPrim prim)
		{
			UsdSkelBindingAPI result = new UsdSkelBindingAPI(UsdSkelPINVOKE.UsdSkelBindingAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetSkinningMethodAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_GetSkinningMethodAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateSkinningMethodAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSkinningMethodAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSkinningMethodAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetGeomBindTransformAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_GetGeomBindTransformAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateGeomBindTransformAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateGeomBindTransformAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateGeomBindTransformAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetJointsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_GetJointsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateJointsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetJointIndicesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_GetJointIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateJointIndicesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointIndicesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointIndicesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetJointWeightsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_GetJointWeightsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateJointWeightsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointWeightsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointWeightsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetBlendShapesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_GetBlendShapesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateBlendShapesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBlendShapesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBlendShapesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetAnimationSourceRel()
		{
			return new UsdRelationship(UsdSkelPINVOKE.UsdSkelBindingAPI_GetAnimationSourceRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateAnimationSourceRel()
		{
			return new UsdRelationship(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateAnimationSourceRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetSkeletonRel()
		{
			return new UsdRelationship(UsdSkelPINVOKE.UsdSkelBindingAPI_GetSkeletonRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateSkeletonRel()
		{
			return new UsdRelationship(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateSkeletonRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetBlendShapeTargetsRel()
		{
			return new UsdRelationship(UsdSkelPINVOKE.UsdSkelBindingAPI_GetBlendShapeTargetsRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateBlendShapeTargetsRel()
		{
			return new UsdRelationship(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateBlendShapeTargetsRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvar GetJointIndicesPrimvar()
		{
			return new UsdGeomPrimvar(UsdSkelPINVOKE.UsdSkelBindingAPI_GetJointIndicesPrimvar(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvar CreateJointIndicesPrimvar(bool constant, int elementSize)
		{
			return new UsdGeomPrimvar(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointIndicesPrimvar__SWIG_0(swigCPtr, constant, elementSize), cMemoryOwn: true);
		}

		public UsdGeomPrimvar CreateJointIndicesPrimvar(bool constant)
		{
			return new UsdGeomPrimvar(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointIndicesPrimvar__SWIG_1(swigCPtr, constant), cMemoryOwn: true);
		}

		public UsdGeomPrimvar GetJointWeightsPrimvar()
		{
			return new UsdGeomPrimvar(UsdSkelPINVOKE.UsdSkelBindingAPI_GetJointWeightsPrimvar(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvar CreateJointWeightsPrimvar(bool constant, int elementSize)
		{
			return new UsdGeomPrimvar(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointWeightsPrimvar__SWIG_0(swigCPtr, constant, elementSize), cMemoryOwn: true);
		}

		public UsdGeomPrimvar CreateJointWeightsPrimvar(bool constant)
		{
			return new UsdGeomPrimvar(UsdSkelPINVOKE.UsdSkelBindingAPI_CreateJointWeightsPrimvar__SWIG_1(swigCPtr, constant), cMemoryOwn: true);
		}

		public bool SetRigidJointInfluence(int jointIndex, float weight)
		{
			return UsdSkelPINVOKE.UsdSkelBindingAPI_SetRigidJointInfluence__SWIG_0(swigCPtr, jointIndex, weight);
		}

		public bool SetRigidJointInfluence(int jointIndex)
		{
			return UsdSkelPINVOKE.UsdSkelBindingAPI_SetRigidJointInfluence__SWIG_1(swigCPtr, jointIndex);
		}

		public bool GetSkeleton(UsdSkelSkeleton skel)
		{
			return UsdSkelPINVOKE.UsdSkelBindingAPI_GetSkeleton(swigCPtr, UsdSkelSkeleton.getCPtr(skel));
		}

		public bool GetAnimationSource(UsdPrim prim)
		{
			return UsdSkelPINVOKE.UsdSkelBindingAPI_GetAnimationSource(swigCPtr, UsdPrim.getCPtr(prim));
		}

		public UsdSkelSkeleton GetInheritedSkeleton()
		{
			return new UsdSkelSkeleton(UsdSkelPINVOKE.UsdSkelBindingAPI_GetInheritedSkeleton(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetInheritedAnimationSource()
		{
			return new UsdPrim(UsdSkelPINVOKE.UsdSkelBindingAPI_GetInheritedAnimationSource(swigCPtr), cMemoryOwn: true);
		}

		public static bool ValidateJointIndices(SWIGTYPE_p_TfSpanT_int_const_t indices, uint numJoints, out string reason)
		{
			bool result = UsdSkelPINVOKE.UsdSkelBindingAPI_ValidateJointIndices__SWIG_0(SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(indices), numJoints, out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ValidateJointIndices(SWIGTYPE_p_TfSpanT_int_const_t indices, uint numJoints)
		{
			bool result = UsdSkelPINVOKE.UsdSkelBindingAPI_ValidateJointIndices__SWIG_1(SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(indices), numJoints);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
