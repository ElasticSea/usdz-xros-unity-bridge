using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdStagePopulationMask : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdStagePopulationMask(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdStagePopulationMask obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdStagePopulationMask obj)
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

		~UsdStagePopulationMask()
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
						UsdPINVOKE.delete_UsdStagePopulationMask(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static UsdStagePopulationMask All()
		{
			return new UsdStagePopulationMask(UsdPINVOKE.UsdStagePopulationMask_All(), cMemoryOwn: true);
		}

		public UsdStagePopulationMask()
			: this(UsdPINVOKE.new_UsdStagePopulationMask__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdStagePopulationMask(UsdStagePopulationMask arg0)
			: this(UsdPINVOKE.new_UsdStagePopulationMask__SWIG_1(getCPtr(arg0)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdStagePopulationMask(SdfPathVector paths)
			: this(UsdPINVOKE.new_UsdStagePopulationMask__SWIG_4(SdfPathVector.getCPtr(paths)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdStagePopulationMask Union(UsdStagePopulationMask l, UsdStagePopulationMask r)
		{
			UsdStagePopulationMask result = new UsdStagePopulationMask(UsdPINVOKE.UsdStagePopulationMask_Union(getCPtr(l), getCPtr(r)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStagePopulationMask GetUnion(UsdStagePopulationMask other)
		{
			UsdStagePopulationMask result = new UsdStagePopulationMask(UsdPINVOKE.UsdStagePopulationMask_GetUnion__SWIG_0(swigCPtr, getCPtr(other)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStagePopulationMask GetUnion(SdfPath path)
		{
			UsdStagePopulationMask result = new UsdStagePopulationMask(UsdPINVOKE.UsdStagePopulationMask_GetUnion__SWIG_1(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdStagePopulationMask Intersection(UsdStagePopulationMask l, UsdStagePopulationMask r)
		{
			UsdStagePopulationMask result = new UsdStagePopulationMask(UsdPINVOKE.UsdStagePopulationMask_Intersection(getCPtr(l), getCPtr(r)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStagePopulationMask GetIntersection(UsdStagePopulationMask other)
		{
			UsdStagePopulationMask result = new UsdStagePopulationMask(UsdPINVOKE.UsdStagePopulationMask_GetIntersection(swigCPtr, getCPtr(other)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Includes(UsdStagePopulationMask other)
		{
			bool result = UsdPINVOKE.UsdStagePopulationMask_Includes__SWIG_0(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Includes(SdfPath path)
		{
			bool result = UsdPINVOKE.UsdStagePopulationMask_Includes__SWIG_1(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IncludesSubtree(SdfPath path)
		{
			bool result = UsdPINVOKE.UsdStagePopulationMask_IncludesSubtree(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsEmpty()
		{
			return UsdPINVOKE.UsdStagePopulationMask_IsEmpty(swigCPtr);
		}

		public bool GetIncludedChildNames(SdfPath path, TfTokenVector childNames)
		{
			bool result = UsdPINVOKE.UsdStagePopulationMask_GetIncludedChildNames(swigCPtr, SdfPath.getCPtr(path), TfTokenVector.getCPtr(childNames));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathVector GetPaths()
		{
			return new SdfPathVector(UsdPINVOKE.UsdStagePopulationMask_GetPaths(swigCPtr), cMemoryOwn: true);
		}

		public UsdStagePopulationMask Add(UsdStagePopulationMask other)
		{
			UsdStagePopulationMask result = new UsdStagePopulationMask(UsdPINVOKE.UsdStagePopulationMask_Add__SWIG_0(swigCPtr, getCPtr(other)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStagePopulationMask Add(SdfPath path)
		{
			UsdStagePopulationMask result = new UsdStagePopulationMask(UsdPINVOKE.UsdStagePopulationMask_Add__SWIG_1(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void swap(UsdStagePopulationMask other)
		{
			UsdPINVOKE.UsdStagePopulationMask_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
