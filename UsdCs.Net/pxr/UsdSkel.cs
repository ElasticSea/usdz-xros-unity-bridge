namespace pxr
{
	public class UsdSkel
	{
		public static bool UsdSkelIsSkelAnimationPrim(UsdPrim prim)
		{
			bool result = UsdSkelPINVOKE.UsdSkelIsSkelAnimationPrim(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelIsSkinnablePrim(UsdPrim prim)
		{
			bool result = UsdSkelPINVOKE.UsdSkelIsSkinnablePrim(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t xforms, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t inverseXforms, SWIGTYPE_p_TfSpanT_GfMatrix4d_t jointLocalXforms, GfMatrix4d rootInverseXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_0(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(inverseXforms), SWIGTYPE_p_TfSpanT_GfMatrix4d_t.getCPtr(jointLocalXforms), GfMatrix4d.getCPtr(rootInverseXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t xforms, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t inverseXforms, SWIGTYPE_p_TfSpanT_GfMatrix4d_t jointLocalXforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_1(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(inverseXforms), SWIGTYPE_p_TfSpanT_GfMatrix4d_t.getCPtr(jointLocalXforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t xforms, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t inverseXforms, SWIGTYPE_p_TfSpanT_GfMatrix4f_t jointLocalXforms, GfMatrix4f rootInverseXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_2(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(inverseXforms), SWIGTYPE_p_TfSpanT_GfMatrix4f_t.getCPtr(jointLocalXforms), GfMatrix4f.getCPtr(rootInverseXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t xforms, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t inverseXforms, SWIGTYPE_p_TfSpanT_GfMatrix4f_t jointLocalXforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_3(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(inverseXforms), SWIGTYPE_p_TfSpanT_GfMatrix4f_t.getCPtr(jointLocalXforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t xforms, SWIGTYPE_p_TfSpanT_GfMatrix4d_t jointLocalXforms, GfMatrix4d rootInverseXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_4(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfMatrix4d_t.getCPtr(jointLocalXforms), GfMatrix4d.getCPtr(rootInverseXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t xforms, SWIGTYPE_p_TfSpanT_GfMatrix4d_t jointLocalXforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_5(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfMatrix4d_t.getCPtr(jointLocalXforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t xforms, SWIGTYPE_p_TfSpanT_GfMatrix4f_t jointLocalXforms, GfMatrix4f rootInverseXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_6(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfMatrix4f_t.getCPtr(jointLocalXforms), GfMatrix4f.getCPtr(rootInverseXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t xforms, SWIGTYPE_p_TfSpanT_GfMatrix4f_t jointLocalXforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_7(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfMatrix4f_t.getCPtr(jointLocalXforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, VtMatrix4dArray xforms, VtMatrix4dArray inverseXforms, VtMatrix4dArray jointLocalXforms, GfMatrix4d rootInverseXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_8(UsdSkelTopology.getCPtr(topology), VtMatrix4dArray.getCPtr(xforms), VtMatrix4dArray.getCPtr(inverseXforms), VtMatrix4dArray.getCPtr(jointLocalXforms), GfMatrix4d.getCPtr(rootInverseXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, VtMatrix4dArray xforms, VtMatrix4dArray inverseXforms, VtMatrix4dArray jointLocalXforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_9(UsdSkelTopology.getCPtr(topology), VtMatrix4dArray.getCPtr(xforms), VtMatrix4dArray.getCPtr(inverseXforms), VtMatrix4dArray.getCPtr(jointLocalXforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, VtMatrix4dArray xforms, VtMatrix4dArray jointLocalXforms, GfMatrix4d rootInverseXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_10(UsdSkelTopology.getCPtr(topology), VtMatrix4dArray.getCPtr(xforms), VtMatrix4dArray.getCPtr(jointLocalXforms), GfMatrix4d.getCPtr(rootInverseXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, VtMatrix4dArray xforms, VtMatrix4dArray jointLocalXforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_11(UsdSkelTopology.getCPtr(topology), VtMatrix4dArray.getCPtr(xforms), VtMatrix4dArray.getCPtr(jointLocalXforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, GfMatrix4d xforms, GfMatrix4d inverseXforms, GfMatrix4d jointLocalXforms, GfMatrix4d rootInverseXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_12(UsdSkelTopology.getCPtr(topology), GfMatrix4d.getCPtr(xforms), GfMatrix4d.getCPtr(inverseXforms), GfMatrix4d.getCPtr(jointLocalXforms), GfMatrix4d.getCPtr(rootInverseXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointLocalTransforms(UsdSkelTopology topology, GfMatrix4d xforms, GfMatrix4d inverseXforms, GfMatrix4d jointLocalXforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointLocalTransforms__SWIG_13(UsdSkelTopology.getCPtr(topology), GfMatrix4d.getCPtr(xforms), GfMatrix4d.getCPtr(inverseXforms), GfMatrix4d.getCPtr(jointLocalXforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelConcatJointTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointLocalXforms, SWIGTYPE_p_TfSpanT_GfMatrix4d_t xforms, GfMatrix4d rootXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelConcatJointTransforms__SWIG_0(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointLocalXforms), SWIGTYPE_p_TfSpanT_GfMatrix4d_t.getCPtr(xforms), GfMatrix4d.getCPtr(rootXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelConcatJointTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointLocalXforms, SWIGTYPE_p_TfSpanT_GfMatrix4d_t xforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelConcatJointTransforms__SWIG_1(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointLocalXforms), SWIGTYPE_p_TfSpanT_GfMatrix4d_t.getCPtr(xforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelConcatJointTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointLocalXforms, SWIGTYPE_p_TfSpanT_GfMatrix4f_t xforms, GfMatrix4f rootXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelConcatJointTransforms__SWIG_2(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointLocalXforms), SWIGTYPE_p_TfSpanT_GfMatrix4f_t.getCPtr(xforms), GfMatrix4f.getCPtr(rootXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelConcatJointTransforms(UsdSkelTopology topology, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointLocalXforms, SWIGTYPE_p_TfSpanT_GfMatrix4f_t xforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelConcatJointTransforms__SWIG_3(UsdSkelTopology.getCPtr(topology), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointLocalXforms), SWIGTYPE_p_TfSpanT_GfMatrix4f_t.getCPtr(xforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelConcatJointTransforms(UsdSkelTopology topology, VtMatrix4dArray jointLocalXforms, VtMatrix4dArray xforms, GfMatrix4d rootXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelConcatJointTransforms__SWIG_4(UsdSkelTopology.getCPtr(topology), VtMatrix4dArray.getCPtr(jointLocalXforms), VtMatrix4dArray.getCPtr(xforms), GfMatrix4d.getCPtr(rootXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelConcatJointTransforms(UsdSkelTopology topology, VtMatrix4dArray jointLocalXforms, VtMatrix4dArray xforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelConcatJointTransforms__SWIG_5(UsdSkelTopology.getCPtr(topology), VtMatrix4dArray.getCPtr(jointLocalXforms), VtMatrix4dArray.getCPtr(xforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelConcatJointTransforms(UsdSkelTopology topology, GfMatrix4d jointLocalXforms, GfMatrix4d xforms, GfMatrix4d rootXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelConcatJointTransforms__SWIG_6(UsdSkelTopology.getCPtr(topology), GfMatrix4d.getCPtr(jointLocalXforms), GfMatrix4d.getCPtr(xforms), GfMatrix4d.getCPtr(rootXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelConcatJointTransforms(UsdSkelTopology topology, GfMatrix4d jointLocalXforms, GfMatrix4d xforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelConcatJointTransforms__SWIG_7(UsdSkelTopology.getCPtr(topology), GfMatrix4d.getCPtr(jointLocalXforms), GfMatrix4d.getCPtr(xforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointsExtent(VtMatrix4dArray joints, VtVec3fArray extent, float pad, GfMatrix4d rootXform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointsExtent__SWIG_3(VtMatrix4dArray.getCPtr(joints), VtVec3fArray.getCPtr(extent), pad, GfMatrix4d.getCPtr(rootXform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointsExtent(VtMatrix4dArray joints, VtVec3fArray extent, float pad)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointsExtent__SWIG_4(VtMatrix4dArray.getCPtr(joints), VtVec3fArray.getCPtr(extent), pad);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointsExtent(VtMatrix4dArray joints, VtVec3fArray extent)
		{
			bool result = UsdSkelPINVOKE.UsdSkelComputeJointsExtent__SWIG_5(VtMatrix4dArray.getCPtr(joints), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelComputeJointsExtent(GfMatrix4d xforms, uint numXforms, VtVec3fArray extent, float pad, GfMatrix4d rootXform)
		{
			return UsdSkelPINVOKE.UsdSkelComputeJointsExtent__SWIG_6(GfMatrix4d.getCPtr(xforms), numXforms, VtVec3fArray.getCPtr(extent), pad, GfMatrix4d.getCPtr(rootXform));
		}

		public static bool UsdSkelComputeJointsExtent(GfMatrix4d xforms, uint numXforms, VtVec3fArray extent, float pad)
		{
			return UsdSkelPINVOKE.UsdSkelComputeJointsExtent__SWIG_7(GfMatrix4d.getCPtr(xforms), numXforms, VtVec3fArray.getCPtr(extent), pad);
		}

		public static bool UsdSkelComputeJointsExtent(GfMatrix4d xforms, uint numXforms, VtVec3fArray extent)
		{
			return UsdSkelPINVOKE.UsdSkelComputeJointsExtent__SWIG_8(GfMatrix4d.getCPtr(xforms), numXforms, VtVec3fArray.getCPtr(extent));
		}

		public static bool UsdSkelDecomposeTransforms(SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t xforms, SWIGTYPE_p_TfSpanT_GfVec3f_t translations, SWIGTYPE_p_TfSpanT_GfQuatf_t rotations, SWIGTYPE_p_TfSpanT_GfVec3h_t scales)
		{
			bool result = UsdSkelPINVOKE.UsdSkelDecomposeTransforms__SWIG_0(SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(translations), SWIGTYPE_p_TfSpanT_GfQuatf_t.getCPtr(rotations), SWIGTYPE_p_TfSpanT_GfVec3h_t.getCPtr(scales));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelDecomposeTransforms(SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t xforms, SWIGTYPE_p_TfSpanT_GfVec3f_t translations, SWIGTYPE_p_TfSpanT_GfQuatf_t rotations, SWIGTYPE_p_TfSpanT_GfVec3h_t scales)
		{
			bool result = UsdSkelPINVOKE.UsdSkelDecomposeTransforms__SWIG_1(SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(xforms), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(translations), SWIGTYPE_p_TfSpanT_GfQuatf_t.getCPtr(rotations), SWIGTYPE_p_TfSpanT_GfVec3h_t.getCPtr(scales));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelDecomposeTransforms(VtMatrix4dArray xforms, VtVec3fArray translations, VtQuatfArray rotations, VtVec3hArray scales)
		{
			bool result = UsdSkelPINVOKE.UsdSkelDecomposeTransforms__SWIG_2(VtMatrix4dArray.getCPtr(xforms), VtVec3fArray.getCPtr(translations), VtQuatfArray.getCPtr(rotations), VtVec3hArray.getCPtr(scales));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelDecomposeTransforms(GfMatrix4d xforms, GfVec3f translations, GfQuatf rotations, GfVec3h scales, uint count)
		{
			return UsdSkelPINVOKE.UsdSkelDecomposeTransforms__SWIG_3(GfMatrix4d.getCPtr(xforms), GfVec3f.getCPtr(translations), GfQuatf.getCPtr(rotations), GfVec3h.getCPtr(scales), count);
		}

		public static bool UsdSkelMakeTransforms(SWIGTYPE_p_TfSpanT_GfVec3f_const_t translations, SWIGTYPE_p_TfSpanT_GfQuatf_const_t rotations, SWIGTYPE_p_TfSpanT_GfVec3h_const_t scales, SWIGTYPE_p_TfSpanT_GfMatrix4d_t xforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelMakeTransforms__SWIG_0(SWIGTYPE_p_TfSpanT_GfVec3f_const_t.getCPtr(translations), SWIGTYPE_p_TfSpanT_GfQuatf_const_t.getCPtr(rotations), SWIGTYPE_p_TfSpanT_GfVec3h_const_t.getCPtr(scales), SWIGTYPE_p_TfSpanT_GfMatrix4d_t.getCPtr(xforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelMakeTransforms(SWIGTYPE_p_TfSpanT_GfVec3f_const_t translations, SWIGTYPE_p_TfSpanT_GfQuatf_const_t rotations, SWIGTYPE_p_TfSpanT_GfVec3h_const_t scales, SWIGTYPE_p_TfSpanT_GfMatrix4f_t xforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelMakeTransforms__SWIG_1(SWIGTYPE_p_TfSpanT_GfVec3f_const_t.getCPtr(translations), SWIGTYPE_p_TfSpanT_GfQuatf_const_t.getCPtr(rotations), SWIGTYPE_p_TfSpanT_GfVec3h_const_t.getCPtr(scales), SWIGTYPE_p_TfSpanT_GfMatrix4f_t.getCPtr(xforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelMakeTransforms(VtVec3fArray translations, VtQuatfArray rotations, VtVec3hArray scales, VtMatrix4dArray xforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelMakeTransforms__SWIG_2(VtVec3fArray.getCPtr(translations), VtQuatfArray.getCPtr(rotations), VtVec3hArray.getCPtr(scales), VtMatrix4dArray.getCPtr(xforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelMakeTransforms(GfVec3f translations, GfQuatf rotations, GfVec3h scales, GfMatrix4d xforms, uint count)
		{
			return UsdSkelPINVOKE.UsdSkelMakeTransforms__SWIG_3(GfVec3f.getCPtr(translations), GfQuatf.getCPtr(rotations), GfVec3h.getCPtr(scales), GfMatrix4d.getCPtr(xforms), count);
		}

		public static bool UsdSkelNormalizeWeights(SWIGTYPE_p_TfSpanT_float_t weights, int numInfluencesPerComponent, float eps)
		{
			bool result = UsdSkelPINVOKE.UsdSkelNormalizeWeights__SWIG_0(SWIGTYPE_p_TfSpanT_float_t.getCPtr(weights), numInfluencesPerComponent, eps);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelNormalizeWeights(SWIGTYPE_p_TfSpanT_float_t weights, int numInfluencesPerComponent)
		{
			bool result = UsdSkelPINVOKE.UsdSkelNormalizeWeights__SWIG_1(SWIGTYPE_p_TfSpanT_float_t.getCPtr(weights), numInfluencesPerComponent);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelNormalizeWeights(VtFloatArray weights, int numInfluencesPerComponent)
		{
			return UsdSkelPINVOKE.UsdSkelNormalizeWeights__SWIG_2(VtFloatArray.getCPtr(weights), numInfluencesPerComponent);
		}

		public static bool UsdSkelSortInfluences(SWIGTYPE_p_TfSpanT_int_t indices, SWIGTYPE_p_TfSpanT_float_t weights, int numInfluencesPerComponent)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSortInfluences__SWIG_0(SWIGTYPE_p_TfSpanT_int_t.getCPtr(indices), SWIGTYPE_p_TfSpanT_float_t.getCPtr(weights), numInfluencesPerComponent);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSortInfluences(VtIntArray indices, VtFloatArray weights, int numInfluencesPerComponent)
		{
			return UsdSkelPINVOKE.UsdSkelSortInfluences__SWIG_1(VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights), numInfluencesPerComponent);
		}

		public static bool UsdSkelExpandConstantInfluencesToVarying(VtIntArray indices, uint size)
		{
			return UsdSkelPINVOKE.UsdSkelExpandConstantInfluencesToVarying__SWIG_0(VtIntArray.getCPtr(indices), size);
		}

		public static bool UsdSkelExpandConstantInfluencesToVarying(VtFloatArray weights, uint size)
		{
			return UsdSkelPINVOKE.UsdSkelExpandConstantInfluencesToVarying__SWIG_1(VtFloatArray.getCPtr(weights), size);
		}

		public static bool UsdSkelResizeInfluences(VtIntArray indices, int srcNumInfluencesPerComponent, int newNumInfluencesPerComponent)
		{
			return UsdSkelPINVOKE.UsdSkelResizeInfluences__SWIG_0(VtIntArray.getCPtr(indices), srcNumInfluencesPerComponent, newNumInfluencesPerComponent);
		}

		public static bool UsdSkelResizeInfluences(VtFloatArray weights, int srcNumInfluencesPerComponent, int newNumInfluencesPerComponent)
		{
			return UsdSkelPINVOKE.UsdSkelResizeInfluences__SWIG_1(VtFloatArray.getCPtr(weights), srcNumInfluencesPerComponent, newNumInfluencesPerComponent);
		}

		public static bool UsdSkelInterleaveInfluences(SWIGTYPE_p_TfSpanT_int_const_t indices, SWIGTYPE_p_TfSpanT_float_const_t weights, SWIGTYPE_p_TfSpanT_GfVec2f_t interleavedInfluences)
		{
			bool result = UsdSkelPINVOKE.UsdSkelInterleaveInfluences(SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(indices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(weights), SWIGTYPE_p_TfSpanT_GfVec2f_t.getCPtr(interleavedInfluences));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_0(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_1(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_2(TfToken.getCPtr(skinningMethod), GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_3(TfToken.getCPtr(skinningMethod), GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_4(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_5(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_6(TfToken.getCPtr(skinningMethod), GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_7(TfToken.getCPtr(skinningMethod), GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4d geomBindTransform, VtMatrix4dArray jointXforms, VtIntArray jointIndices, VtFloatArray jointWeights, int numInfluencesPerPoint, VtVec3fArray points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_8(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), VtMatrix4dArray.getCPtr(jointXforms), VtIntArray.getCPtr(jointIndices), VtFloatArray.getCPtr(jointWeights), numInfluencesPerPoint, VtVec3fArray.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4d geomBindTransform, GfMatrix4d jointXforms, uint numJoints, SWIGTYPE_p_int jointIndices, SWIGTYPE_p_float jointWeights, uint numInfluences, int numInfluencesPerPoint, GfVec3f points, uint numPoints, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_9(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), GfMatrix4d.getCPtr(jointXforms), numJoints, SWIGTYPE_p_int.getCPtr(jointIndices), SWIGTYPE_p_float.getCPtr(jointWeights), numInfluences, numInfluencesPerPoint, GfVec3f.getCPtr(points), numPoints, inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPoints(TfToken skinningMethod, GfMatrix4d geomBindTransform, GfMatrix4d jointXforms, uint numJoints, SWIGTYPE_p_int jointIndices, SWIGTYPE_p_float jointWeights, uint numInfluences, int numInfluencesPerPoint, GfVec3f points, uint numPoints)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPoints__SWIG_10(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), GfMatrix4d.getCPtr(jointXforms), numJoints, SWIGTYPE_p_int.getCPtr(jointIndices), SWIGTYPE_p_float.getCPtr(jointWeights), numInfluences, numInfluencesPerPoint, GfVec3f.getCPtr(points), numPoints);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_0(GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_1(GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_2(GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_3(GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_4(GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_5(GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_6(GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_7(GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4d geomBindTransform, VtMatrix4dArray jointXforms, VtIntArray jointIndices, VtFloatArray jointWeights, int numInfluencesPerPoint, VtVec3fArray points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_8(GfMatrix4d.getCPtr(geomBindTransform), VtMatrix4dArray.getCPtr(jointXforms), VtIntArray.getCPtr(jointIndices), VtFloatArray.getCPtr(jointWeights), numInfluencesPerPoint, VtVec3fArray.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4d geomBindTransform, GfMatrix4d jointXforms, uint numJoints, SWIGTYPE_p_int jointIndices, SWIGTYPE_p_float jointWeights, uint numInfluences, int numInfluencesPerPoint, GfVec3f points, uint numPoints, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_9(GfMatrix4d.getCPtr(geomBindTransform), GfMatrix4d.getCPtr(jointXforms), numJoints, SWIGTYPE_p_int.getCPtr(jointIndices), SWIGTYPE_p_float.getCPtr(jointWeights), numInfluences, numInfluencesPerPoint, GfVec3f.getCPtr(points), numPoints, inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinPointsLBS(GfMatrix4d geomBindTransform, GfMatrix4d jointXforms, uint numJoints, SWIGTYPE_p_int jointIndices, SWIGTYPE_p_float jointWeights, uint numInfluences, int numInfluencesPerPoint, GfVec3f points, uint numPoints)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinPointsLBS__SWIG_10(GfMatrix4d.getCPtr(geomBindTransform), GfMatrix4d.getCPtr(jointXforms), numJoints, SWIGTYPE_p_int.getCPtr(jointIndices), SWIGTYPE_p_float.getCPtr(jointWeights), numInfluences, numInfluencesPerPoint, GfVec3f.getCPtr(points), numPoints);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormals(TfToken skinningMethod, GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormals__SWIG_0(TfToken.getCPtr(skinningMethod), GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormals(TfToken skinningMethod, GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormals__SWIG_1(TfToken.getCPtr(skinningMethod), GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormals(TfToken skinningMethod, GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormals__SWIG_2(TfToken.getCPtr(skinningMethod), GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormals(TfToken skinningMethod, GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormals__SWIG_3(TfToken.getCPtr(skinningMethod), GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormals(TfToken skinningMethod, GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormals__SWIG_4(TfToken.getCPtr(skinningMethod), GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormals(TfToken skinningMethod, GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormals__SWIG_5(TfToken.getCPtr(skinningMethod), GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormals(TfToken skinningMethod, GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormals__SWIG_6(TfToken.getCPtr(skinningMethod), GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormals(TfToken skinningMethod, GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormals__SWIG_7(TfToken.getCPtr(skinningMethod), GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinFaceVaryingNormals(TfToken skinningMethod, GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t faceVertexIndices, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinFaceVaryingNormals__SWIG_0(TfToken.getCPtr(skinningMethod), GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(faceVertexIndices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinFaceVaryingNormals(TfToken skinningMethod, GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t faceVertexIndices, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinFaceVaryingNormals__SWIG_1(TfToken.getCPtr(skinningMethod), GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(faceVertexIndices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinFaceVaryingNormals(TfToken skinningMethod, GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t faceVertexIndices, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinFaceVaryingNormals__SWIG_2(TfToken.getCPtr(skinningMethod), GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(faceVertexIndices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinFaceVaryingNormals(TfToken skinningMethod, GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t faceVertexIndices, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinFaceVaryingNormals__SWIG_3(TfToken.getCPtr(skinningMethod), GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(faceVertexIndices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormalsLBS(GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormalsLBS__SWIG_0(GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormalsLBS(GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormalsLBS__SWIG_1(GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormalsLBS(GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormalsLBS__SWIG_2(GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormalsLBS(GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormalsLBS__SWIG_3(GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormalsLBS(GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormalsLBS__SWIG_4(GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormalsLBS(GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormalsLBS__SWIG_5(GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormalsLBS(GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormalsLBS__SWIG_6(GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinNormalsLBS(GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinNormalsLBS__SWIG_7(GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinFaceVaryingNormalsLBS(GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t faceVertexIndices, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinFaceVaryingNormalsLBS__SWIG_0(GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(faceVertexIndices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinFaceVaryingNormalsLBS(GfMatrix3d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t faceVertexIndices, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinFaceVaryingNormalsLBS__SWIG_1(GfMatrix3d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(faceVertexIndices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinFaceVaryingNormalsLBS(GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t faceVertexIndices, SWIGTYPE_p_TfSpanT_GfVec3f_t normals, bool inSerial)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinFaceVaryingNormalsLBS__SWIG_2(GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(faceVertexIndices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals), inSerial);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinFaceVaryingNormalsLBS(GfMatrix3f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, int numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t faceVertexIndices, SWIGTYPE_p_TfSpanT_GfVec3f_t normals)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinFaceVaryingNormalsLBS__SWIG_3(GfMatrix3f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix3f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), numInfluencesPerPoint, SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(faceVertexIndices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(normals));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransform(TfToken skinningMethod, GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, GfMatrix4d xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransform__SWIG_0(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), GfMatrix4d.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransform(TfToken skinningMethod, GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, GfMatrix4f xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransform__SWIG_1(TfToken.getCPtr(skinningMethod), GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), GfMatrix4f.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransform(TfToken skinningMethod, GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, GfMatrix4d xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransform__SWIG_2(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), GfMatrix4d.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransform(TfToken skinningMethod, GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, GfMatrix4f xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransform__SWIG_3(TfToken.getCPtr(skinningMethod), GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), GfMatrix4f.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransform(TfToken skinningMethod, GfMatrix4d geomBindTransform, GfMatrix4d jointXforms, uint numJoints, SWIGTYPE_p_int jointIndices, SWIGTYPE_p_float jointWeights, uint numInfluences, GfMatrix4d xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransform__SWIG_4(TfToken.getCPtr(skinningMethod), GfMatrix4d.getCPtr(geomBindTransform), GfMatrix4d.getCPtr(jointXforms), numJoints, SWIGTYPE_p_int.getCPtr(jointIndices), SWIGTYPE_p_float.getCPtr(jointWeights), numInfluences, GfMatrix4d.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransformLBS(GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, GfMatrix4d xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransformLBS__SWIG_0(GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), GfMatrix4d.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransformLBS(GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_int_const_t jointIndices, SWIGTYPE_p_TfSpanT_float_const_t jointWeights, GfMatrix4f xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransformLBS__SWIG_1(GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(jointIndices), SWIGTYPE_p_TfSpanT_float_const_t.getCPtr(jointWeights), GfMatrix4f.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransformLBS(GfMatrix4d geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, GfMatrix4d xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransformLBS__SWIG_2(GfMatrix4d.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4d_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), GfMatrix4d.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransformLBS(GfMatrix4f geomBindTransform, SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t jointXforms, SWIGTYPE_p_TfSpanT_GfVec2f_const_t influences, GfMatrix4f xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransformLBS__SWIG_3(GfMatrix4f.getCPtr(geomBindTransform), SWIGTYPE_p_TfSpanT_GfMatrix4f_const_t.getCPtr(jointXforms), SWIGTYPE_p_TfSpanT_GfVec2f_const_t.getCPtr(influences), GfMatrix4f.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelSkinTransformLBS(GfMatrix4d geomBindTransform, GfMatrix4d jointXforms, uint numJoints, SWIGTYPE_p_int jointIndices, SWIGTYPE_p_float jointWeights, uint numInfluences, GfMatrix4d xform)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkinTransformLBS__SWIG_4(GfMatrix4d.getCPtr(geomBindTransform), GfMatrix4d.getCPtr(jointXforms), numJoints, SWIGTYPE_p_int.getCPtr(jointIndices), SWIGTYPE_p_float.getCPtr(jointWeights), numInfluences, GfMatrix4d.getCPtr(xform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdSkelApplyBlendShape(float weight, SWIGTYPE_p_TfSpanT_GfVec3f_const_t offsets, SWIGTYPE_p_TfSpanT_int_const_t indices, SWIGTYPE_p_TfSpanT_GfVec3f_t points)
		{
			bool result = UsdSkelPINVOKE.UsdSkelApplyBlendShape(weight, SWIGTYPE_p_TfSpanT_GfVec3f_const_t.getCPtr(offsets), SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(indices), SWIGTYPE_p_TfSpanT_GfVec3f_t.getCPtr(points));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
