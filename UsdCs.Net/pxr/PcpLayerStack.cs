using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpLayerStack : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

		internal PcpLayerStack(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(PcpLayerStack obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~PcpLayerStack()
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
					if (swigCMemOwnBase)
					{
						swigCMemOwnBase = false;
						PcpPINVOKE.delete_PcpLayerStack(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpLayerStackIdentifier GetIdentifier()
		{
			PcpLayerStackIdentifier result = new PcpLayerStackIdentifier(PcpPINVOKE.PcpLayerStack_GetIdentifier(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerRefPtrVector GetLayers()
		{
			SdfLayerRefPtrVector result = new SdfLayerRefPtrVector(PcpPINVOKE.PcpLayerStack_GetLayers(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandleVector GetSessionLayers()
		{
			SdfLayerHandleVector result = new SdfLayerHandleVector(PcpPINVOKE.PcpLayerStack_GetSessionLayers(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerTree GetLayerTree()
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStack_GetLayerTree(swigCPtr);
			SdfLayerTree result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerTree(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerOffset GetLayerOffsetForLayer(SdfLayerHandle arg0)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStack_GetLayerOffsetForLayer__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(arg0));
			SdfLayerOffset result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerOffset(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerOffset GetLayerOffsetForLayer(SdfLayer arg0)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStack_GetLayerOffsetForLayer__SWIG_1(swigCPtr, SdfLayer.getCPtr(arg0));
			SdfLayerOffset result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerOffset(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerOffset GetLayerOffsetForLayer(uint layerIdx)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStack_GetLayerOffsetForLayer__SWIG_2(swigCPtr, layerIdx);
			SdfLayerOffset result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerOffset(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetMutedLayers()
		{
			StdStringSet result = new StdStringSet(PcpPINVOKE.PcpLayerStack_GetMutedLayers(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PcpErrorVector GetLocalErrors()
		{
			SWIGTYPE_p_PcpErrorVector result = new SWIGTYPE_p_PcpErrorVector(PcpPINVOKE.PcpLayerStack_GetLocalErrors(swigCPtr), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasLayer(SdfLayerHandle layer)
		{
			bool result = PcpPINVOKE.PcpLayerStack_HasLayer__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(layer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasLayer(SdfLayer layer)
		{
			bool result = PcpPINVOKE.PcpLayerStack_HasLayer__SWIG_1(swigCPtr, SdfLayer.getCPtr(layer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetTimeCodesPerSecond()
		{
			double result = PcpPINVOKE.PcpLayerStack_GetTimeCodesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelocatesMap GetRelocatesSourceToTarget()
		{
			SdfRelocatesMap result = new SdfRelocatesMap(PcpPINVOKE.PcpLayerStack_GetRelocatesSourceToTarget(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelocatesMap GetRelocatesTargetToSource()
		{
			SdfRelocatesMap result = new SdfRelocatesMap(PcpPINVOKE.PcpLayerStack_GetRelocatesTargetToSource(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelocatesMap GetIncrementalRelocatesSourceToTarget()
		{
			SdfRelocatesMap result = new SdfRelocatesMap(PcpPINVOKE.PcpLayerStack_GetIncrementalRelocatesSourceToTarget(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelocatesMap GetIncrementalRelocatesTargetToSource()
		{
			SdfRelocatesMap result = new SdfRelocatesMap(PcpPINVOKE.PcpLayerStack_GetIncrementalRelocatesTargetToSource(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathVector GetPathsToPrimsWithRelocates()
		{
			SdfPathVector result = new SdfPathVector(PcpPINVOKE.PcpLayerStack_GetPathsToPrimsWithRelocates(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Apply(SWIGTYPE_p_PcpLayerStackChanges changes, SWIGTYPE_p_PcpLifeboat lifeboat)
		{
			PcpPINVOKE.PcpLayerStack_Apply(swigCPtr, SWIGTYPE_p_PcpLayerStackChanges.getCPtr(changes), SWIGTYPE_p_PcpLifeboat.getCPtr(lifeboat));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_PcpMapExpression GetExpressionForRelocatesAtPath(SdfPath path)
		{
			SWIGTYPE_p_PcpMapExpression result = new SWIGTYPE_p_PcpMapExpression(PcpPINVOKE.PcpLayerStack_GetExpressionForRelocatesAtPath(swigCPtr, SdfPath.getCPtr(path)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
