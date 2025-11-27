using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdPrimCompositionQueryArc : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdPrimCompositionQueryArc(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrimCompositionQueryArc obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrimCompositionQueryArc obj)
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

		~UsdPrimCompositionQueryArc()
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
						UsdPINVOKE.delete_UsdPrimCompositionQueryArc(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpNodeRef GetTargetNode()
		{
			return new PcpNodeRef(UsdPINVOKE.UsdPrimCompositionQueryArc_GetTargetNode(swigCPtr), cMemoryOwn: true);
		}

		public PcpNodeRef GetIntroducingNode()
		{
			return new PcpNodeRef(UsdPINVOKE.UsdPrimCompositionQueryArc_GetIntroducingNode(swigCPtr), cMemoryOwn: true);
		}

		public SdfLayerHandle GetTargetLayer()
		{
			return new SdfLayerHandle(UsdPINVOKE.UsdPrimCompositionQueryArc_GetTargetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetTargetPrimPath()
		{
			return new SdfPath(UsdPINVOKE.UsdPrimCompositionQueryArc_GetTargetPrimPath(swigCPtr), cMemoryOwn: true);
		}

		public UsdResolveTarget MakeResolveTargetUpTo(SdfLayerHandle subLayer)
		{
			UsdResolveTarget result = new UsdResolveTarget(UsdPINVOKE.UsdPrimCompositionQueryArc_MakeResolveTargetUpTo__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(subLayer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdResolveTarget MakeResolveTargetUpTo()
		{
			return new UsdResolveTarget(UsdPINVOKE.UsdPrimCompositionQueryArc_MakeResolveTargetUpTo__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdResolveTarget MakeResolveTargetStrongerThan(SdfLayerHandle subLayer)
		{
			UsdResolveTarget result = new UsdResolveTarget(UsdPINVOKE.UsdPrimCompositionQueryArc_MakeResolveTargetStrongerThan__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(subLayer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdResolveTarget MakeResolveTargetStrongerThan()
		{
			return new UsdResolveTarget(UsdPINVOKE.UsdPrimCompositionQueryArc_MakeResolveTargetStrongerThan__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public SdfLayerHandle GetIntroducingLayer()
		{
			return new SdfLayerHandle(UsdPINVOKE.UsdPrimCompositionQueryArc_GetIntroducingLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetIntroducingPrimPath()
		{
			return new SdfPath(UsdPINVOKE.UsdPrimCompositionQueryArc_GetIntroducingPrimPath(swigCPtr), cMemoryOwn: true);
		}

		public bool GetIntroducingListEditor(SWIGTYPE_p_SdfReferenceEditorProxy editor, SdfReference ref_)
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_0(swigCPtr, SWIGTYPE_p_SdfReferenceEditorProxy.getCPtr(editor), SdfReference.getCPtr(ref_));
		}

		public bool GetIntroducingListEditor(SWIGTYPE_p_SdfPayloadEditorProxy editor, SdfPayload payload)
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_1(swigCPtr, SWIGTYPE_p_SdfPayloadEditorProxy.getCPtr(editor), SdfPayload.getCPtr(payload));
		}

		public bool GetIntroducingListEditor(SWIGTYPE_p_SdfPathEditorProxy editor, SdfPath path)
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_2(swigCPtr, SWIGTYPE_p_SdfPathEditorProxy.getCPtr(editor), SdfPath.getCPtr(path));
		}

		public bool GetIntroducingListEditor(SWIGTYPE_p_SdfNameEditorProxy editor, out string name)
		{
			bool result = UsdPINVOKE.UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_3(swigCPtr, SWIGTYPE_p_SdfNameEditorProxy.getCPtr(editor), out name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public PcpArcType GetArcType()
		{
			return (PcpArcType)UsdPINVOKE.UsdPrimCompositionQueryArc_GetArcType(swigCPtr);
		}

		public bool IsImplicit()
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArc_IsImplicit(swigCPtr);
		}

		public bool IsAncestral()
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArc_IsAncestral(swigCPtr);
		}

		public bool HasSpecs()
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArc_HasSpecs(swigCPtr);
		}

		public bool IsIntroducedInRootLayerStack()
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArc_IsIntroducedInRootLayerStack(swigCPtr);
		}

		public bool IsIntroducedInRootLayerPrimSpec()
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArc_IsIntroducedInRootLayerPrimSpec(swigCPtr);
		}
	}
}
