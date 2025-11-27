using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpNodeRef : IDisposable
	{
		public class Hash : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public Hash(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(Hash obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(Hash obj)
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

			~Hash()
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
							PcpPINVOKE.delete_PcpNodeRef_Hash(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Hash()
				: this(PcpPINVOKE.new_PcpNodeRef_Hash(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public PcpNodeRef(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpNodeRef obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpNodeRef obj)
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

		~PcpNodeRef()
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
						PcpPINVOKE.delete_PcpNodeRef(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpNodeRef()
			: this(PcpPINVOKE.new_PcpNodeRef(), cMemoryOwn: true)
		{
		}

		public PcpArcType GetArcType()
		{
			return (PcpArcType)PcpPINVOKE.PcpNodeRef_GetArcType(swigCPtr);
		}

		public PcpNodeRef GetParentNode()
		{
			return new PcpNodeRef(PcpPINVOKE.PcpNodeRef_GetParentNode(swigCPtr), cMemoryOwn: true);
		}

		public PcpNodeRef InsertChild(SWIGTYPE_p_PcpLayerStackSite site, PcpArc arc, SWIGTYPE_p_std__shared_ptrT_PcpErrorBase_t error)
		{
			PcpNodeRef result = new PcpNodeRef(PcpPINVOKE.PcpNodeRef_InsertChild(swigCPtr, SWIGTYPE_p_PcpLayerStackSite.getCPtr(site), PcpArc.getCPtr(arc), SWIGTYPE_p_std__shared_ptrT_PcpErrorBase_t.getCPtr(error)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpNodeRef InsertChildSubgraph(SWIGTYPE_p_PcpPrimIndex_Graph subgraph, PcpArc arc, SWIGTYPE_p_std__shared_ptrT_PcpErrorBase_t error)
		{
			PcpNodeRef result = new PcpNodeRef(PcpPINVOKE.PcpNodeRef_InsertChildSubgraph(swigCPtr, SWIGTYPE_p_PcpPrimIndex_Graph.getCPtr(subgraph), PcpArc.getCPtr(arc), SWIGTYPE_p_std__shared_ptrT_PcpErrorBase_t.getCPtr(error)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpNodeRef GetOriginNode()
		{
			return new PcpNodeRef(PcpPINVOKE.PcpNodeRef_GetOriginNode(swigCPtr), cMemoryOwn: true);
		}

		public PcpNodeRef GetOriginRootNode()
		{
			return new PcpNodeRef(PcpPINVOKE.PcpNodeRef_GetOriginRootNode(swigCPtr), cMemoryOwn: true);
		}

		public PcpNodeRef GetRootNode()
		{
			return new PcpNodeRef(PcpPINVOKE.PcpNodeRef_GetRootNode(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_PcpMapExpression GetMapToParent()
		{
			return new SWIGTYPE_p_PcpMapExpression(PcpPINVOKE.PcpNodeRef_GetMapToParent(swigCPtr), futureUse: false);
		}

		public SWIGTYPE_p_PcpMapExpression GetMapToRoot()
		{
			return new SWIGTYPE_p_PcpMapExpression(PcpPINVOKE.PcpNodeRef_GetMapToRoot(swigCPtr), futureUse: false);
		}

		public int GetSiblingNumAtOrigin()
		{
			return PcpPINVOKE.PcpNodeRef_GetSiblingNumAtOrigin(swigCPtr);
		}

		public int GetNamespaceDepth()
		{
			return PcpPINVOKE.PcpNodeRef_GetNamespaceDepth(swigCPtr);
		}

		public int GetDepthBelowIntroduction()
		{
			return PcpPINVOKE.PcpNodeRef_GetDepthBelowIntroduction(swigCPtr);
		}

		public SdfPath GetPathAtIntroduction()
		{
			return new SdfPath(PcpPINVOKE.PcpNodeRef_GetPathAtIntroduction(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetIntroPath()
		{
			return new SdfPath(PcpPINVOKE.PcpNodeRef_GetIntroPath(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_PcpLayerStackSite GetSite()
		{
			return new SWIGTYPE_p_PcpLayerStackSite(PcpPINVOKE.PcpNodeRef_GetSite(swigCPtr), futureUse: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(PcpPINVOKE.PcpNodeRef_GetPath(swigCPtr), cMemoryOwn: false);
		}

		public PcpLayerStack GetLayerStack()
		{
			IntPtr intPtr = PcpPINVOKE.PcpNodeRef_GetLayerStack(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new PcpLayerStack(intPtr, cMemoryOwn: true);
		}

		public bool IsRootNode()
		{
			return PcpPINVOKE.PcpNodeRef_IsRootNode(swigCPtr);
		}

		public void SetIsDueToAncestor(bool isDueToAncestor)
		{
			PcpPINVOKE.PcpNodeRef_SetIsDueToAncestor(swigCPtr, isDueToAncestor);
		}

		public bool IsDueToAncestor()
		{
			return PcpPINVOKE.PcpNodeRef_IsDueToAncestor(swigCPtr);
		}

		public void SetHasSymmetry(bool hasSymmetry)
		{
			PcpPINVOKE.PcpNodeRef_SetHasSymmetry(swigCPtr, hasSymmetry);
		}

		public bool HasSymmetry()
		{
			return PcpPINVOKE.PcpNodeRef_HasSymmetry(swigCPtr);
		}

		public void SetPermission(SdfPermission perm)
		{
			PcpPINVOKE.PcpNodeRef_SetPermission(swigCPtr, (int)perm);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)PcpPINVOKE.PcpNodeRef_GetPermission(swigCPtr);
		}

		public void SetInert(bool inert)
		{
			PcpPINVOKE.PcpNodeRef_SetInert(swigCPtr, inert);
		}

		public bool IsInert()
		{
			return PcpPINVOKE.PcpNodeRef_IsInert(swigCPtr);
		}

		public void SetCulled(bool culled)
		{
			PcpPINVOKE.PcpNodeRef_SetCulled(swigCPtr, culled);
		}

		public bool IsCulled()
		{
			return PcpPINVOKE.PcpNodeRef_IsCulled(swigCPtr);
		}

		public void SetRestricted(bool restricted)
		{
			PcpPINVOKE.PcpNodeRef_SetRestricted(swigCPtr, restricted);
		}

		public bool IsRestricted()
		{
			return PcpPINVOKE.PcpNodeRef_IsRestricted(swigCPtr);
		}

		public bool CanContributeSpecs()
		{
			return PcpPINVOKE.PcpNodeRef_CanContributeSpecs(swigCPtr);
		}

		public void SetHasSpecs(bool hasSpecs)
		{
			PcpPINVOKE.PcpNodeRef_SetHasSpecs(swigCPtr, hasSpecs);
		}

		public bool HasSpecs()
		{
			return PcpPINVOKE.PcpNodeRef_HasSpecs(swigCPtr);
		}

		public SWIGTYPE_p_Pcp_CompressedSdSite GetCompressedSdSite(uint layerIndex)
		{
			return new SWIGTYPE_p_Pcp_CompressedSdSite(PcpPINVOKE.PcpNodeRef_GetCompressedSdSite(swigCPtr, layerIndex), futureUse: true);
		}

		public PcpNodeRefVector GetChildren()
		{
			return new PcpNodeRefVector(PcpPINVOKE.PcpNodeRef_GetChildren(swigCPtr), cMemoryOwn: true);
		}
	}
}
