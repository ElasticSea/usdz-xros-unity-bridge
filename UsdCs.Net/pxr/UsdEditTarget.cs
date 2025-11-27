using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdEditTarget : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdEditTarget(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdEditTarget obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdEditTarget obj)
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

		~UsdEditTarget()
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
						UsdPINVOKE.delete_UsdEditTarget(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdEditTarget()
			: this(UsdPINVOKE.new_UsdEditTarget__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdEditTarget(SdfLayerHandle layer, SdfLayerOffset offset)
			: this(UsdPINVOKE.new_UsdEditTarget__SWIG_1(SdfLayerHandle.getCPtr(layer), SdfLayerOffset.getCPtr(offset)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdEditTarget(SdfLayerHandle layer)
			: this(UsdPINVOKE.new_UsdEditTarget__SWIG_2(SdfLayerHandle.getCPtr(layer)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdEditTarget(SdfLayer layer, SdfLayerOffset offset)
			: this(UsdPINVOKE.new_UsdEditTarget__SWIG_3(SdfLayer.getCPtr(layer), SdfLayerOffset.getCPtr(offset)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdEditTarget(SdfLayer layer)
			: this(UsdPINVOKE.new_UsdEditTarget__SWIG_4(SdfLayer.getCPtr(layer)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdEditTarget(SdfLayerHandle layer, PcpNodeRef node)
			: this(UsdPINVOKE.new_UsdEditTarget__SWIG_5(SdfLayerHandle.getCPtr(layer), PcpNodeRef.getCPtr(node)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdEditTarget(SdfLayer layer, PcpNodeRef node)
			: this(UsdPINVOKE.new_UsdEditTarget__SWIG_6(SdfLayer.getCPtr(layer), PcpNodeRef.getCPtr(node)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdEditTarget ForLocalDirectVariant(SdfLayerHandle layer, SdfPath varSelPath)
		{
			UsdEditTarget result = new UsdEditTarget(UsdPINVOKE.UsdEditTarget_ForLocalDirectVariant(SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(varSelPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsNull()
		{
			return UsdPINVOKE.UsdEditTarget_IsNull(swigCPtr);
		}

		public bool IsValid()
		{
			return UsdPINVOKE.UsdEditTarget_IsValid(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(UsdPINVOKE.UsdEditTarget_GetLayer(swigCPtr), cMemoryOwn: false);
		}

		public SdfPath MapToSpecPath(SdfPath scenePath)
		{
			SdfPath result = new SdfPath(UsdPINVOKE.UsdEditTarget_MapToSpecPath(swigCPtr, SdfPath.getCPtr(scenePath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetPrimSpecForScenePath(SdfPath scenePath)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(UsdPINVOKE.UsdEditTarget_GetPrimSpecForScenePath(swigCPtr, SdfPath.getCPtr(scenePath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPropertySpecHandle GetPropertySpecForScenePath(SdfPath scenePath)
		{
			SdfPropertySpecHandle result = new SdfPropertySpecHandle(UsdPINVOKE.UsdEditTarget_GetPropertySpecForScenePath(swigCPtr, SdfPath.getCPtr(scenePath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecHandle GetSpecForScenePath(SdfPath scenePath)
		{
			SdfSpecHandle result = new SdfSpecHandle(UsdPINVOKE.UsdEditTarget_GetSpecForScenePath(swigCPtr, SdfPath.getCPtr(scenePath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PcpMapFunction GetMapFunction()
		{
			return new SWIGTYPE_p_PcpMapFunction(UsdPINVOKE.UsdEditTarget_GetMapFunction(swigCPtr), futureUse: false);
		}

		public UsdEditTarget ComposeOver(UsdEditTarget weaker)
		{
			UsdEditTarget result = new UsdEditTarget(UsdPINVOKE.UsdEditTarget_ComposeOver(swigCPtr, getCPtr(weaker)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
