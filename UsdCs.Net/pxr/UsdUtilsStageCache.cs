using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdUtilsStageCache : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdUtilsStageCache(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdUtilsStageCache obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdUtilsStageCache obj)
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

		~UsdUtilsStageCache()
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
						UsdUtilsPINVOKE.delete_UsdUtilsStageCache(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static UsdStageCache Get()
		{
			return new UsdStageCache(UsdUtilsPINVOKE.UsdUtilsStageCache_Get(), cMemoryOwn: false);
		}

		public static SdfLayerHandle GetSessionLayerForVariantSelections(TfToken modelName, SWIGTYPE_p_std__vectorT_std__pairT_std__string_std__string_t_t variantSelections)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.UsdUtilsStageCache_GetSessionLayerForVariantSelections(TfToken.getCPtr(modelName), SWIGTYPE_p_std__vectorT_std__pairT_std__string_std__string_t_t.getCPtr(variantSelections));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdUtilsStageCache()
			: this(UsdUtilsPINVOKE.new_UsdUtilsStageCache(), cMemoryOwn: true)
		{
		}
	}
}
