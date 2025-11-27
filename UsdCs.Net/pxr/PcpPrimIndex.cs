using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpPrimIndex : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public PcpPrimIndex(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpPrimIndex obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpPrimIndex obj)
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

		~PcpPrimIndex()
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
						PcpPINVOKE.delete_PcpPrimIndex(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpPrimIndex()
			: this(PcpPINVOKE.new_PcpPrimIndex__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PcpPrimIndex(PcpPrimIndex rhs)
			: this(PcpPINVOKE.new_PcpPrimIndex__SWIG_1(getCPtr(rhs)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Swap(PcpPrimIndex rhs)
		{
			PcpPINVOKE.PcpPrimIndex_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(PcpPrimIndex rhs)
		{
			PcpPINVOKE.PcpPrimIndex_swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsValid()
		{
			return PcpPINVOKE.PcpPrimIndex_IsValid(swigCPtr);
		}

		public void SetGraph(SWIGTYPE_p_PcpPrimIndex_Graph graph)
		{
			PcpPINVOKE.PcpPrimIndex_SetGraph(swigCPtr, SWIGTYPE_p_PcpPrimIndex_Graph.getCPtr(graph));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_PcpPrimIndex_Graph GetGraph()
		{
			IntPtr intPtr = PcpPINVOKE.PcpPrimIndex_GetGraph(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_PcpPrimIndex_Graph(intPtr, futureUse: true);
		}

		public PcpNodeRef GetRootNode()
		{
			return new PcpNodeRef(PcpPINVOKE.PcpPrimIndex_GetRootNode(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(PcpPINVOKE.PcpPrimIndex_GetPath(swigCPtr), cMemoryOwn: false);
		}

		public bool HasSpecs()
		{
			return PcpPINVOKE.PcpPrimIndex_HasSpecs(swigCPtr);
		}

		public bool HasAnyPayloads()
		{
			return PcpPINVOKE.PcpPrimIndex_HasAnyPayloads(swigCPtr);
		}

		public bool IsUsd()
		{
			return PcpPINVOKE.PcpPrimIndex_IsUsd(swigCPtr);
		}

		public bool IsInstanceable()
		{
			return PcpPINVOKE.PcpPrimIndex_IsInstanceable(swigCPtr);
		}

		public SWIGTYPE_p_PcpNodeRange GetNodeRange(PcpRangeType rangeType)
		{
			return new SWIGTYPE_p_PcpNodeRange(PcpPINVOKE.PcpPrimIndex_GetNodeRange__SWIG_0(swigCPtr, (int)rangeType), futureUse: true);
		}

		public SWIGTYPE_p_PcpNodeRange GetNodeRange()
		{
			return new SWIGTYPE_p_PcpNodeRange(PcpPINVOKE.PcpPrimIndex_GetNodeRange__SWIG_1(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_PcpNodeIterator GetNodeIteratorAtNode(PcpNodeRef node)
		{
			SWIGTYPE_p_PcpNodeIterator result = new SWIGTYPE_p_PcpNodeIterator(PcpPINVOKE.PcpPrimIndex_GetNodeIteratorAtNode(swigCPtr, PcpNodeRef.getCPtr(node)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PcpPrimRange GetPrimRange(PcpRangeType rangeType)
		{
			return new SWIGTYPE_p_PcpPrimRange(PcpPINVOKE.PcpPrimIndex_GetPrimRange__SWIG_0(swigCPtr, (int)rangeType), futureUse: true);
		}

		public SWIGTYPE_p_PcpPrimRange GetPrimRange()
		{
			return new SWIGTYPE_p_PcpPrimRange(PcpPINVOKE.PcpPrimIndex_GetPrimRange__SWIG_1(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_PcpPrimRange GetPrimRangeForNode(PcpNodeRef node)
		{
			SWIGTYPE_p_PcpPrimRange result = new SWIGTYPE_p_PcpPrimRange(PcpPINVOKE.PcpPrimIndex_GetPrimRangeForNode(swigCPtr, PcpNodeRef.getCPtr(node)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpNodeRef GetNodeProvidingSpec(SdfPrimSpecHandle primSpec)
		{
			PcpNodeRef result = new PcpNodeRef(PcpPINVOKE.PcpPrimIndex_GetNodeProvidingSpec__SWIG_0(swigCPtr, SdfPrimSpecHandle.getCPtr(primSpec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpNodeRef GetNodeProvidingSpec(SdfLayerHandle layer, SdfPath path)
		{
			PcpNodeRef result = new PcpNodeRef(PcpPINVOKE.PcpPrimIndex_GetNodeProvidingSpec__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PcpErrorVector GetLocalErrors()
		{
			return new SWIGTYPE_p_PcpErrorVector(PcpPINVOKE.PcpPrimIndex_GetLocalErrors(swigCPtr), futureUse: true);
		}

		public void PrintStatistics()
		{
			PcpPINVOKE.PcpPrimIndex_PrintStatistics(swigCPtr);
		}

		public string DumpToString(bool includeInheritOriginInfo, bool includeMaps)
		{
			return PcpPINVOKE.PcpPrimIndex_DumpToString__SWIG_0(swigCPtr, includeInheritOriginInfo, includeMaps);
		}

		public string DumpToString(bool includeInheritOriginInfo)
		{
			return PcpPINVOKE.PcpPrimIndex_DumpToString__SWIG_1(swigCPtr, includeInheritOriginInfo);
		}

		public string DumpToString()
		{
			return PcpPINVOKE.PcpPrimIndex_DumpToString__SWIG_2(swigCPtr);
		}

		public void DumpToDotGraph(string filename, bool includeInheritOriginInfo, bool includeMaps)
		{
			PcpPINVOKE.PcpPrimIndex_DumpToDotGraph__SWIG_0(swigCPtr, filename, includeInheritOriginInfo, includeMaps);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void DumpToDotGraph(string filename, bool includeInheritOriginInfo)
		{
			PcpPINVOKE.PcpPrimIndex_DumpToDotGraph__SWIG_1(swigCPtr, filename, includeInheritOriginInfo);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void DumpToDotGraph(string filename)
		{
			PcpPINVOKE.PcpPrimIndex_DumpToDotGraph__SWIG_2(swigCPtr, filename);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ComputePrimChildNames(TfTokenVector nameOrder, SWIGTYPE_p_pxr_tsl__robin_setT_TfToken_TfToken__HashFunctor_t prohibitedNameSet)
		{
			PcpPINVOKE.PcpPrimIndex_ComputePrimChildNames(swigCPtr, TfTokenVector.getCPtr(nameOrder), SWIGTYPE_p_pxr_tsl__robin_setT_TfToken_TfToken__HashFunctor_t.getCPtr(prohibitedNameSet));
		}

		public void ComputePrimPropertyNames(TfTokenVector nameOrder)
		{
			PcpPINVOKE.PcpPrimIndex_ComputePrimPropertyNames(swigCPtr, TfTokenVector.getCPtr(nameOrder));
		}

		public StdStringMap ComposeAuthoredVariantSelections()
		{
			return new StdStringMap(PcpPINVOKE.PcpPrimIndex_ComposeAuthoredVariantSelections(swigCPtr), cMemoryOwn: true);
		}

		public string GetSelectionAppliedForVariantSet(string variantSet)
		{
			string result = PcpPINVOKE.PcpPrimIndex_GetSelectionAppliedForVariantSet(swigCPtr, variantSet);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
