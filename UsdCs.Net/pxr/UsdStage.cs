using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdStage : IDisposable
	{
		public enum InitialLoadSet
		{
			LoadAll,
			LoadNone
		}

		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

		internal UsdStage(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(UsdStage obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~UsdStage()
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
						UsdPINVOKE.delete_UsdStage(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static UsdStage CreateNew(string identifier, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateNew__SWIG_0(identifier, (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateNew(string identifier)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateNew__SWIG_1(identifier);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateNew(string identifier, SdfLayerHandle sessionLayer, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateNew__SWIG_2(identifier, SdfLayerHandle.getCPtr(sessionLayer), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateNew(string identifier, SdfLayerHandle sessionLayer)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateNew__SWIG_3(identifier, SdfLayerHandle.getCPtr(sessionLayer));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateNew(string identifier, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateNew__SWIG_4(identifier, SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateNew(string identifier, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateNew__SWIG_5(identifier, SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateNew(string identifier, ArResolverContext pathResolverContext, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateNew__SWIG_6(identifier, ArResolverContext.getCPtr(pathResolverContext), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateNew(string identifier, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateNew__SWIG_7(identifier, ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateInMemory(InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_0((int)load);
			return (intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true);
		}

		public static UsdStage CreateInMemory()
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_1();
			return (intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true);
		}

		public static UsdStage CreateInMemory(string identifier, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_2(identifier, (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateInMemory(string identifier)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_3(identifier);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateInMemory(string identifier, ArResolverContext pathResolverContext, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_4(identifier, ArResolverContext.getCPtr(pathResolverContext), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateInMemory(string identifier, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_5(identifier, ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateInMemory(string identifier, SdfLayerHandle sessionLayer, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_6(identifier, SdfLayerHandle.getCPtr(sessionLayer), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateInMemory(string identifier, SdfLayerHandle sessionLayer)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_7(identifier, SdfLayerHandle.getCPtr(sessionLayer));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateInMemory(string identifier, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_8(identifier, SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage CreateInMemory(string identifier, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_CreateInMemory__SWIG_9(identifier, SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(string filePath, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_0(filePath, (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(string filePath)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_1(filePath);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(string filePath, ArResolverContext pathResolverContext, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_2(filePath, ArResolverContext.getCPtr(pathResolverContext), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(string filePath, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_3(filePath, ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(string filePath, UsdStagePopulationMask mask, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_0(filePath, UsdStagePopulationMask.getCPtr(mask), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(string filePath, UsdStagePopulationMask mask)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_1(filePath, UsdStagePopulationMask.getCPtr(mask));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(string filePath, ArResolverContext pathResolverContext, UsdStagePopulationMask mask, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_2(filePath, ArResolverContext.getCPtr(pathResolverContext), UsdStagePopulationMask.getCPtr(mask), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(string filePath, ArResolverContext pathResolverContext, UsdStagePopulationMask mask)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_3(filePath, ArResolverContext.getCPtr(pathResolverContext), UsdStagePopulationMask.getCPtr(mask));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(SdfLayerHandle rootLayer, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_4(SdfLayerHandle.getCPtr(rootLayer), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(SdfLayerHandle rootLayer)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_5(SdfLayerHandle.getCPtr(rootLayer));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_6(SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_7(SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(SdfLayerHandle rootLayer, ArResolverContext pathResolverContext, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_8(SdfLayerHandle.getCPtr(rootLayer), ArResolverContext.getCPtr(pathResolverContext), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(SdfLayerHandle rootLayer, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_9(SdfLayerHandle.getCPtr(rootLayer), ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_10(SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage Open(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Open__SWIG_11(SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(SdfLayerHandle rootLayer, UsdStagePopulationMask mask, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_4(SdfLayerHandle.getCPtr(rootLayer), UsdStagePopulationMask.getCPtr(mask), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(SdfLayerHandle rootLayer, UsdStagePopulationMask mask)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_5(SdfLayerHandle.getCPtr(rootLayer), UsdStagePopulationMask.getCPtr(mask));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, UsdStagePopulationMask mask, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_6(SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), UsdStagePopulationMask.getCPtr(mask), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, UsdStagePopulationMask mask)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_7(SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), UsdStagePopulationMask.getCPtr(mask));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(SdfLayerHandle rootLayer, ArResolverContext pathResolverContext, UsdStagePopulationMask mask, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_8(SdfLayerHandle.getCPtr(rootLayer), ArResolverContext.getCPtr(pathResolverContext), UsdStagePopulationMask.getCPtr(mask), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(SdfLayerHandle rootLayer, ArResolverContext pathResolverContext, UsdStagePopulationMask mask)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_9(SdfLayerHandle.getCPtr(rootLayer), ArResolverContext.getCPtr(pathResolverContext), UsdStagePopulationMask.getCPtr(mask));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext, UsdStagePopulationMask mask, InitialLoadSet load)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_10(SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext), UsdStagePopulationMask.getCPtr(mask), (int)load);
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStage OpenMasked(SdfLayerHandle rootLayer, SdfLayerHandle sessionLayer, ArResolverContext pathResolverContext, UsdStagePopulationMask mask)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_OpenMasked__SWIG_11(SdfLayerHandle.getCPtr(rootLayer), SdfLayerHandle.getCPtr(sessionLayer), ArResolverContext.getCPtr(pathResolverContext), UsdStagePopulationMask.getCPtr(mask));
			UsdStage result = ((intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reload()
		{
			UsdPINVOKE.UsdStage_Reload(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool IsSupportedFile(string filePath)
		{
			bool result = UsdPINVOKE.UsdStage_IsSupportedFile(filePath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Save()
		{
			UsdPINVOKE.UsdStage_Save(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SaveSessionLayers()
		{
			UsdPINVOKE.UsdStage_SaveSessionLayers(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static PcpVariantFallbackMap GetGlobalVariantFallbacks()
		{
			return new PcpVariantFallbackMap(UsdPINVOKE.UsdStage_GetGlobalVariantFallbacks(), cMemoryOwn: true);
		}

		public static void SetGlobalVariantFallbacks(PcpVariantFallbackMap fallbacks)
		{
			UsdPINVOKE.UsdStage_SetGlobalVariantFallbacks(PcpVariantFallbackMap.getCPtr(fallbacks));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPrim Load(SdfPath path, UsdLoadPolicy policy)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_Load__SWIG_0(swigCPtr, SdfPath.getCPtr(path), (int)policy), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim Load(SdfPath path)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_Load__SWIG_1(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim Load()
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_Load__SWIG_2(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Unload(SdfPath path)
		{
			UsdPINVOKE.UsdStage_Unload__SWIG_0(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Unload()
		{
			UsdPINVOKE.UsdStage_Unload__SWIG_1(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void LoadAndUnload(SdfPathSet loadSet, SdfPathSet unloadSet, UsdLoadPolicy policy)
		{
			UsdPINVOKE.UsdStage_LoadAndUnload__SWIG_0(swigCPtr, SdfPathSet.getCPtr(loadSet), SdfPathSet.getCPtr(unloadSet), (int)policy);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void LoadAndUnload(SdfPathSet loadSet, SdfPathSet unloadSet)
		{
			UsdPINVOKE.UsdStage_LoadAndUnload__SWIG_1(swigCPtr, SdfPathSet.getCPtr(loadSet), SdfPathSet.getCPtr(unloadSet));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPathSet GetLoadSet()
		{
			SdfPathSet result = new SdfPathSet(UsdPINVOKE.UsdStage_GetLoadSet(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathSet FindLoadable(SdfPath rootPath)
		{
			SdfPathSet result = new SdfPathSet(UsdPINVOKE.UsdStage_FindLoadable__SWIG_0(swigCPtr, SdfPath.getCPtr(rootPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathSet FindLoadable()
		{
			SdfPathSet result = new SdfPathSet(UsdPINVOKE.UsdStage_FindLoadable__SWIG_1(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStageLoadRules GetLoadRules()
		{
			UsdStageLoadRules result = new UsdStageLoadRules(UsdPINVOKE.UsdStage_GetLoadRules(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetLoadRules(UsdStageLoadRules rules)
		{
			UsdPINVOKE.UsdStage_SetLoadRules(swigCPtr, UsdStageLoadRules.getCPtr(rules));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdStagePopulationMask GetPopulationMask()
		{
			UsdStagePopulationMask result = new UsdStagePopulationMask(UsdPINVOKE.UsdStage_GetPopulationMask(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetPopulationMask(UsdStagePopulationMask mask)
		{
			UsdPINVOKE.UsdStage_SetPopulationMask(swigCPtr, UsdStagePopulationMask.getCPtr(mask));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPrim GetPseudoRoot()
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_GetPseudoRoot(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim GetDefaultPrim()
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_GetDefaultPrim(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetDefaultPrim(UsdPrim prim)
		{
			UsdPINVOKE.UsdStage_SetDefaultPrim(swigCPtr, UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ClearDefaultPrim()
		{
			UsdPINVOKE.UsdStage_ClearDefaultPrim(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasDefaultPrim()
		{
			bool result = UsdPINVOKE.UsdStage_HasDefaultPrim(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim GetPrimAtPath(SdfPath path)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_GetPrimAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdObject GetObjectAtPath(SdfPath path)
		{
			UsdObject result = new UsdObject(UsdPINVOKE.UsdStage_GetObjectAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdProperty GetPropertyAtPath(SdfPath path)
		{
			UsdProperty result = new UsdProperty(UsdPINVOKE.UsdStage_GetPropertyAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAttributeAtPath(SdfPath path)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdStage_GetAttributeAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship GetRelationshipAtPath(SdfPath path)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdStage_GetRelationshipAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimRange Traverse()
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdStage_Traverse__SWIG_0(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimRange Traverse(Usd_PrimFlagsPredicate predicate)
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdStage_Traverse__SWIG_1(swigCPtr, Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimRange TraverseAll()
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdStage_TraverseAll(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim OverridePrim(SdfPath path)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_OverridePrim(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim DefinePrim(SdfPath path, TfToken typeName)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_DefinePrim__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim DefinePrim(SdfPath path)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_DefinePrim__SWIG_1(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim CreateClassPrim(SdfPath rootPrimPath)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdStage_CreateClassPrim(swigCPtr, SdfPath.getCPtr(rootPrimPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemovePrim(SdfPath path)
		{
			bool result = UsdPINVOKE.UsdStage_RemovePrim(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle GetSessionLayer()
		{
			SdfLayerHandle result = new SdfLayerHandle(UsdPINVOKE.UsdStage_GetSessionLayer(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle GetRootLayer()
		{
			SdfLayerHandle result = new SdfLayerHandle(UsdPINVOKE.UsdStage_GetRootLayer(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public ArResolverContext GetPathResolverContext()
		{
			ArResolverContext result = new ArResolverContext(UsdPINVOKE.UsdStage_GetPathResolverContext(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string ResolveIdentifierToEditTarget(string identifier)
		{
			string result = UsdPINVOKE.UsdStage_ResolveIdentifierToEditTarget(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandleVector GetLayerStack(bool includeSessionLayers)
		{
			SdfLayerHandleVector result = new SdfLayerHandleVector(UsdPINVOKE.UsdStage_GetLayerStack__SWIG_0(swigCPtr, includeSessionLayers), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandleVector GetLayerStack()
		{
			SdfLayerHandleVector result = new SdfLayerHandleVector(UsdPINVOKE.UsdStage_GetLayerStack__SWIG_1(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandleVector GetUsedLayers(bool includeClipLayers)
		{
			SdfLayerHandleVector result = new SdfLayerHandleVector(UsdPINVOKE.UsdStage_GetUsedLayers__SWIG_0(swigCPtr, includeClipLayers), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandleVector GetUsedLayers()
		{
			SdfLayerHandleVector result = new SdfLayerHandleVector(UsdPINVOKE.UsdStage_GetUsedLayers__SWIG_1(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasLocalLayer(SdfLayerHandle layer)
		{
			bool result = UsdPINVOKE.UsdStage_HasLocalLayer(swigCPtr, SdfLayerHandle.getCPtr(layer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdEditTarget GetEditTarget()
		{
			UsdEditTarget result = new UsdEditTarget(UsdPINVOKE.UsdStage_GetEditTarget(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdEditTarget GetEditTargetForLocalLayer(uint i)
		{
			UsdEditTarget result = new UsdEditTarget(UsdPINVOKE.UsdStage_GetEditTargetForLocalLayer__SWIG_0(swigCPtr, i), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdEditTarget GetEditTargetForLocalLayer(SdfLayerHandle layer)
		{
			UsdEditTarget result = new UsdEditTarget(UsdPINVOKE.UsdStage_GetEditTargetForLocalLayer__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(layer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetEditTarget(UsdEditTarget editTarget)
		{
			UsdPINVOKE.UsdStage_SetEditTarget(swigCPtr, UsdEditTarget.getCPtr(editTarget));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void MuteLayer(string layerIdentifier)
		{
			UsdPINVOKE.UsdStage_MuteLayer(swigCPtr, layerIdentifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void UnmuteLayer(string layerIdentifier)
		{
			UsdPINVOKE.UsdStage_UnmuteLayer(swigCPtr, layerIdentifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void MuteAndUnmuteLayers(StdStringVector muteLayers, StdStringVector unmuteLayers)
		{
			UsdPINVOKE.UsdStage_MuteAndUnmuteLayers(swigCPtr, StdStringVector.getCPtr(muteLayers), StdStringVector.getCPtr(unmuteLayers));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdStringVector GetMutedLayers()
		{
			StdStringVector result = new StdStringVector(UsdPINVOKE.UsdStage_GetMutedLayers(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsLayerMuted(string layerIdentifier)
		{
			bool result = UsdPINVOKE.UsdStage_IsLayerMuted(swigCPtr, layerIdentifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename, bool addSourceFileComment, StdStringMap args)
		{
			bool result = UsdPINVOKE.UsdStage_Export__SWIG_0(swigCPtr, filename, addSourceFileComment, StdStringMap.getCPtr(args));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename, bool addSourceFileComment)
		{
			bool result = UsdPINVOKE.UsdStage_Export__SWIG_1(swigCPtr, filename, addSourceFileComment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename)
		{
			bool result = UsdPINVOKE.UsdStage_Export__SWIG_2(swigCPtr, filename);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ExportToString(out string result, bool addSourceFileComment)
		{
			bool result2 = UsdPINVOKE.UsdStage_ExportToString__SWIG_0(swigCPtr, out result, addSourceFileComment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result2;
		}

		public bool ExportToString(out string result)
		{
			bool result2 = UsdPINVOKE.UsdStage_ExportToString__SWIG_1(swigCPtr, out result);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result2;
		}

		public SdfLayerHandle Flatten(bool addSourceFileComment)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Flatten__SWIG_0(swigCPtr, addSourceFileComment);
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

		public SdfLayerHandle Flatten()
		{
			IntPtr intPtr = UsdPINVOKE.UsdStage_Flatten__SWIG_1(swigCPtr);
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

		public bool GetMetadata(TfToken key, VtValue value)
		{
			bool result = UsdPINVOKE.UsdStage_GetMetadata(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasMetadata(TfToken key)
		{
			bool result = UsdPINVOKE.UsdStage_HasMetadata(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAuthoredMetadata(TfToken key)
		{
			bool result = UsdPINVOKE.UsdStage_HasAuthoredMetadata(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetMetadata(TfToken key, VtValue value)
		{
			bool result = UsdPINVOKE.UsdStage_SetMetadata(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearMetadata(TfToken key)
		{
			bool result = UsdPINVOKE.UsdStage_ClearMetadata(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetMetadataByDictKey(TfToken key, TfToken keyPath, VtValue value)
		{
			bool result = UsdPINVOKE.UsdStage_GetMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasMetadataDictKey(TfToken key, TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdStage_HasMetadataDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAuthoredMetadataDictKey(TfToken key, TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdStage_HasAuthoredMetadataDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetMetadataByDictKey(TfToken key, TfToken keyPath, VtValue value)
		{
			bool result = UsdPINVOKE.UsdStage_SetMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearMetadataByDictKey(TfToken key, TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdStage_ClearMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void WriteFallbackPrimTypes()
		{
			UsdPINVOKE.UsdStage_WriteFallbackPrimTypes(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetStartTimeCode()
		{
			double result = UsdPINVOKE.UsdStage_GetStartTimeCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetStartTimeCode(double arg0)
		{
			UsdPINVOKE.UsdStage_SetStartTimeCode(swigCPtr, arg0);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetEndTimeCode()
		{
			double result = UsdPINVOKE.UsdStage_GetEndTimeCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetEndTimeCode(double arg0)
		{
			UsdPINVOKE.UsdStage_SetEndTimeCode(swigCPtr, arg0);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasAuthoredTimeCodeRange()
		{
			bool result = UsdPINVOKE.UsdStage_HasAuthoredTimeCodeRange(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetTimeCodesPerSecond()
		{
			double result = UsdPINVOKE.UsdStage_GetTimeCodesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetTimeCodesPerSecond(double timeCodesPerSecond)
		{
			UsdPINVOKE.UsdStage_SetTimeCodesPerSecond(swigCPtr, timeCodesPerSecond);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetFramesPerSecond()
		{
			double result = UsdPINVOKE.UsdStage_GetFramesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetFramesPerSecond(double framesPerSecond)
		{
			UsdPINVOKE.UsdStage_SetFramesPerSecond(swigCPtr, framesPerSecond);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetColorConfiguration(SdfAssetPath colorConfig)
		{
			UsdPINVOKE.UsdStage_SetColorConfiguration(swigCPtr, SdfAssetPath.getCPtr(colorConfig));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAssetPath GetColorConfiguration()
		{
			SdfAssetPath result = new SdfAssetPath(UsdPINVOKE.UsdStage_GetColorConfiguration(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetColorManagementSystem(TfToken cms)
		{
			UsdPINVOKE.UsdStage_SetColorManagementSystem(swigCPtr, TfToken.getCPtr(cms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetColorManagementSystem()
		{
			TfToken result = new TfToken(UsdPINVOKE.UsdStage_GetColorManagementSystem(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void GetColorConfigFallbacks(SdfAssetPath colorConfiguration, TfToken colorManagementSystem)
		{
			UsdPINVOKE.UsdStage_GetColorConfigFallbacks(SdfAssetPath.getCPtr(colorConfiguration), TfToken.getCPtr(colorManagementSystem));
		}

		public static void SetColorConfigFallbacks(SdfAssetPath colorConfiguration, TfToken colorManagementSystem)
		{
			UsdPINVOKE.UsdStage_SetColorConfigFallbacks(SdfAssetPath.getCPtr(colorConfiguration), TfToken.getCPtr(colorManagementSystem));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetInterpolationType(UsdInterpolationType interpolationType)
		{
			UsdPINVOKE.UsdStage_SetInterpolationType(swigCPtr, (int)interpolationType);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdInterpolationType GetInterpolationType()
		{
			UsdInterpolationType result = (UsdInterpolationType)UsdPINVOKE.UsdStage_GetInterpolationType(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimVector GetPrototypes()
		{
			UsdPrimVector result = new UsdPrimVector(UsdPINVOKE.UsdStage_GetPrototypes(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimVector GetAllPrims()
		{
			UsdPrimVector result = new UsdPrimVector(UsdPINVOKE.UsdStage_GetAllPrims(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimVector GetAllPrimsByType(string typeName)
		{
			UsdPrimVector result = new UsdPrimVector(UsdPINVOKE.UsdStage_GetAllPrimsByType(swigCPtr, typeName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathVector GetAllPaths()
		{
			SdfPathVector result = new SdfPathVector(UsdPINVOKE.UsdStage_GetAllPaths(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathVector GetAllPathsByType(string typeName, SdfPath rootPath)
		{
			SdfPathVector result = new SdfPathVector(UsdPINVOKE.UsdStage_GetAllPathsByType(swigCPtr, typeName, SdfPath.getCPtr(rootPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
