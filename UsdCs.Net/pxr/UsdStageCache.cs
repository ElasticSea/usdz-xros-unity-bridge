using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdStageCache : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdStageCache(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdStageCache obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdStageCache obj)
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

		~UsdStageCache()
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
						UsdPINVOKE.delete_UsdStageCache(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdStageCache()
			: this(UsdPINVOKE.new_UsdStageCache__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdStageCache(UsdStageCache other)
			: this(UsdPINVOKE.new_UsdStageCache__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(UsdStageCache other)
		{
			UsdPINVOKE.UsdStageCache_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdStageRefPtrVector GetAllStages()
		{
			return new UsdStageRefPtrVector(UsdPINVOKE.UsdStageCache_GetAllStages(swigCPtr), cMemoryOwn: true);
		}

		public uint Size()
		{
			return UsdPINVOKE.UsdStageCache_Size(swigCPtr);
		}

		public bool IsEmpty()
		{
			return UsdPINVOKE.UsdStageCache_IsEmpty(swigCPtr);
		}

		public UsdStageCacheResultPair RequestStage(UsdStageCacheRequest request)
		{
			UsdStageCacheResultPair result = new UsdStageCacheResultPair(UsdPINVOKE.UsdStageCache_RequestStage(swigCPtr, UsdStageCacheRequest.swigRelease(request)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStage Find(long id)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStageCache_Find(swigCPtr, id);
			return (intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true);
		}

		public UsdStage FindOneMatching(SdfLayerHandle rootLayer)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStageCache_FindOneMatching__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(rootLayer));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStage FindOneMatching(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStageCache_FindOneMatching__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStage FindOneMatching(SdfLayerHandle rootLayer, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStageCache_FindOneMatching__SWIG_2(swigCPtr, SdfLayerHandle.getCPtr(rootLayer), ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStage FindOneMatching(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStageCache_FindOneMatching__SWIG_3(swigCPtr, SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStageRefPtrVector FindAllMatching(SdfLayerHandle rootLayer)
		{
			UsdStageRefPtrVector result = new UsdStageRefPtrVector(UsdPINVOKE.UsdStageCache_FindAllMatching__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(rootLayer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStageRefPtrVector FindAllMatching(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer)
		{
			UsdStageRefPtrVector result = new UsdStageRefPtrVector(UsdPINVOKE.UsdStageCache_FindAllMatching__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStageRefPtrVector FindAllMatching(SdfLayerHandle rootLayer, ArResolverContext pathResolverContext)
		{
			UsdStageRefPtrVector result = new UsdStageRefPtrVector(UsdPINVOKE.UsdStageCache_FindAllMatching__SWIG_2(swigCPtr, SdfLayerHandle.getCPtr(rootLayer), ArResolverContext.getCPtr(pathResolverContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStageRefPtrVector FindAllMatching(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext)
		{
			UsdStageRefPtrVector result = new UsdStageRefPtrVector(UsdPINVOKE.UsdStageCache_FindAllMatching__SWIG_3(swigCPtr, SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public long GetId(UsdStage stage)
		{
			long result = UsdPINVOKE.UsdStageCache_GetId(swigCPtr, UsdStage.getCPtr(stage));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(UsdStage stage)
		{
			bool result = UsdPINVOKE.UsdStageCache_Contains__SWIG_0(swigCPtr, UsdStage.getCPtr(stage));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(long id)
		{
			return UsdPINVOKE.UsdStageCache_Contains__SWIG_1(swigCPtr, id);
		}

		public long Insert(UsdStage stage)
		{
			long result = UsdPINVOKE.UsdStageCache_Insert(swigCPtr, UsdStage.getCPtr(stage));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Erase(long id)
		{
			return UsdPINVOKE.UsdStageCache_Erase__SWIG_0(swigCPtr, id);
		}

		public bool Erase(UsdStage stage)
		{
			bool result = UsdPINVOKE.UsdStageCache_Erase__SWIG_1(swigCPtr, UsdStage.getCPtr(stage));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint EraseAll(SdfLayerHandle rootLayer)
		{
			uint result = UsdPINVOKE.UsdStageCache_EraseAll__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(rootLayer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint EraseAll(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer)
		{
			uint result = UsdPINVOKE.UsdStageCache_EraseAll__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint EraseAll(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext)
		{
			uint result = UsdPINVOKE.UsdStageCache_EraseAll__SWIG_2(swigCPtr, SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Clear()
		{
			UsdPINVOKE.UsdStageCache_Clear(swigCPtr);
		}

		public void SetDebugName(string debugName)
		{
			UsdPINVOKE.UsdStageCache_SetDebugName(swigCPtr, debugName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDebugName()
		{
			return UsdPINVOKE.UsdStageCache_GetDebugName(swigCPtr);
		}
	}
}
