namespace pxr
{
	public class Pcp
	{
		public static uint PCP_INVALID_INDEX => PcpPINVOKE.PCP_INVALID_INDEX_get();

		public static bool PcpIsTimeScalingForLayerTimeCodesPerSecondDisabled()
		{
			return PcpPINVOKE.PcpIsTimeScalingForLayerTimeCodesPerSecondDisabled();
		}

		public static PcpNodeRef_ChildrenIterator begin(SWIGTYPE_p_std__pairT_PcpNodeRef_ChildrenIterator_PcpNodeRef_ChildrenIterator_t r)
		{
			PcpNodeRef_ChildrenIterator result = new PcpNodeRef_ChildrenIterator(PcpPINVOKE.begin(SWIGTYPE_p_std__pairT_PcpNodeRef_ChildrenIterator_PcpNodeRef_ChildrenIterator_t.getCPtr(r)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static PcpNodeRef_ChildrenIterator end(SWIGTYPE_p_std__pairT_PcpNodeRef_ChildrenIterator_PcpNodeRef_ChildrenIterator_t r)
		{
			PcpNodeRef_ChildrenIterator result = new PcpNodeRef_ChildrenIterator(PcpPINVOKE.end(SWIGTYPE_p_std__pairT_PcpNodeRef_ChildrenIterator_PcpNodeRef_ChildrenIterator_t.getCPtr(r)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void PcpComputePrimIndex(SdfPath primPath, PcpLayerStack layerStack, SWIGTYPE_p_PcpPrimIndexInputs inputs, SWIGTYPE_p_PcpPrimIndexOutputs outputs, SWIGTYPE_p_ArResolver pathResolver)
		{
			PcpPINVOKE.PcpComputePrimIndex__SWIG_0(SdfPath.getCPtr(primPath), PcpLayerStack.getCPtr(layerStack), SWIGTYPE_p_PcpPrimIndexInputs.getCPtr(inputs), SWIGTYPE_p_PcpPrimIndexOutputs.getCPtr(outputs), SWIGTYPE_p_ArResolver.getCPtr(pathResolver));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void PcpComputePrimIndex(SdfPath primPath, PcpLayerStack layerStack, SWIGTYPE_p_PcpPrimIndexInputs inputs, SWIGTYPE_p_PcpPrimIndexOutputs outputs)
		{
			PcpPINVOKE.PcpComputePrimIndex__SWIG_1(SdfPath.getCPtr(primPath), PcpLayerStack.getCPtr(layerStack), SWIGTYPE_p_PcpPrimIndexInputs.getCPtr(inputs), SWIGTYPE_p_PcpPrimIndexOutputs.getCPtr(outputs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool PcpIsNewDefaultStandinBehaviorEnabled()
		{
			return PcpPINVOKE.PcpIsNewDefaultStandinBehaviorEnabled();
		}

		public static void PcpBuildPropertyIndex(SdfPath propertyPath, PcpCache cache, PcpPropertyIndex propertyIndex, SWIGTYPE_p_PcpErrorVector allErrors)
		{
			PcpPINVOKE.PcpBuildPropertyIndex(SdfPath.getCPtr(propertyPath), PcpCache.getCPtr(cache), PcpPropertyIndex.getCPtr(propertyIndex), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void PcpBuildPrimPropertyIndex(SdfPath propertyPath, PcpCache cache, PcpPrimIndex owningPrimIndex, PcpPropertyIndex propertyIndex, SWIGTYPE_p_PcpErrorVector allErrors)
		{
			PcpPINVOKE.PcpBuildPrimPropertyIndex(SdfPath.getCPtr(propertyPath), PcpCache.getCPtr(cache), PcpPrimIndex.getCPtr(owningPrimIndex), PcpPropertyIndex.getCPtr(propertyIndex), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool PcpIsInheritArc(PcpArcType arcType)
		{
			return PcpPINVOKE.PcpIsInheritArc((int)arcType);
		}

		public static bool PcpIsSpecializeArc(PcpArcType arcType)
		{
			return PcpPINVOKE.PcpIsSpecializeArc((int)arcType);
		}

		public static bool PcpIsClassBasedArc(PcpArcType arcType)
		{
			return PcpPINVOKE.PcpIsClassBasedArc((int)arcType);
		}
	}
}
