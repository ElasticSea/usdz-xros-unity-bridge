using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerTree : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

		internal SdfLayerTree(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(SdfLayerTree obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~SdfLayerTree()
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
						SdfPINVOKE.delete_SdfLayerTree(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfLayerTree New(SdfLayerHandle layer, SdfLayerTreeHandleVector childTrees, SdfLayerOffset cumulativeOffset)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerTree_New__SWIG_0(SdfLayerHandle.getCPtr(layer), SdfLayerTreeHandleVector.getCPtr(childTrees), SdfLayerOffset.getCPtr(cumulativeOffset));
			SdfLayerTree result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerTree(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerTree New(SdfLayerHandle layer, SdfLayerTreeHandleVector childTrees)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerTree_New__SWIG_1(SdfLayerHandle.getCPtr(layer), SdfLayerTreeHandleVector.getCPtr(childTrees));
			SdfLayerTree result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerTree(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle GetLayer()
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayerTree_GetLayer(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerOffset GetOffset()
		{
			SdfLayerOffset result = new SdfLayerOffset(SdfPINVOKE.SdfLayerTree_GetOffset(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerTreeHandleVector GetChildTrees()
		{
			SdfLayerTreeHandleVector result = new SdfLayerTreeHandleVector(SdfPINVOKE.SdfLayerTree_GetChildTrees(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
