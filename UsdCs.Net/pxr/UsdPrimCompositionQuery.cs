using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdPrimCompositionQuery : IDisposable
	{
		public class Filter : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public ArcTypeFilter arcTypeFilter
			{
				get
				{
					return (ArcTypeFilter)UsdPINVOKE.UsdPrimCompositionQuery_Filter_arcTypeFilter_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdPrimCompositionQuery_Filter_arcTypeFilter_set(swigCPtr, (int)value);
				}
			}

			public DependencyTypeFilter dependencyTypeFilter
			{
				get
				{
					return (DependencyTypeFilter)UsdPINVOKE.UsdPrimCompositionQuery_Filter_dependencyTypeFilter_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdPrimCompositionQuery_Filter_dependencyTypeFilter_set(swigCPtr, (int)value);
				}
			}

			public ArcIntroducedFilter arcIntroducedFilter
			{
				get
				{
					return (ArcIntroducedFilter)UsdPINVOKE.UsdPrimCompositionQuery_Filter_arcIntroducedFilter_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdPrimCompositionQuery_Filter_arcIntroducedFilter_set(swigCPtr, (int)value);
				}
			}

			public HasSpecsFilter hasSpecsFilter
			{
				get
				{
					return (HasSpecsFilter)UsdPINVOKE.UsdPrimCompositionQuery_Filter_hasSpecsFilter_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdPrimCompositionQuery_Filter_hasSpecsFilter_set(swigCPtr, (int)value);
				}
			}

			public Filter(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(Filter obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(Filter obj)
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

			~Filter()
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
							UsdPINVOKE.delete_UsdPrimCompositionQuery_Filter(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Filter()
				: this(UsdPINVOKE.new_UsdPrimCompositionQuery_Filter(), cMemoryOwn: true)
			{
			}
		}

		public enum ArcTypeFilter
		{
			All,
			Reference,
			Payload,
			Inherit,
			Specialize,
			Variant,
			ReferenceOrPayload,
			InheritOrSpecialize,
			NotReferenceOrPayload,
			NotInheritOrSpecialize,
			NotVariant
		}

		public enum DependencyTypeFilter
		{
			All,
			Direct,
			Ancestral
		}

		public enum ArcIntroducedFilter
		{
			All,
			IntroducedInRootLayerStack,
			IntroducedInRootLayerPrimSpec
		}

		public enum HasSpecsFilter
		{
			All,
			HasSpecs,
			HasNoSpecs
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdPrimCompositionQuery(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrimCompositionQuery obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrimCompositionQuery obj)
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

		~UsdPrimCompositionQuery()
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
						UsdPINVOKE.delete_UsdPrimCompositionQuery(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static UsdPrimCompositionQuery GetDirectReferences(UsdPrim prim)
		{
			UsdPrimCompositionQuery result = new UsdPrimCompositionQuery(UsdPINVOKE.UsdPrimCompositionQuery_GetDirectReferences(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdPrimCompositionQuery GetDirectInherits(UsdPrim prim)
		{
			UsdPrimCompositionQuery result = new UsdPrimCompositionQuery(UsdPINVOKE.UsdPrimCompositionQuery_GetDirectInherits(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdPrimCompositionQuery GetDirectRootLayerArcs(UsdPrim prim)
		{
			UsdPrimCompositionQuery result = new UsdPrimCompositionQuery(UsdPINVOKE.UsdPrimCompositionQuery_GetDirectRootLayerArcs(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimCompositionQuery(UsdPrim prim, Filter filter)
			: this(UsdPINVOKE.new_UsdPrimCompositionQuery__SWIG_0(UsdPrim.getCPtr(prim), Filter.getCPtr(filter)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPrimCompositionQuery(UsdPrim prim)
			: this(UsdPINVOKE.new_UsdPrimCompositionQuery__SWIG_1(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetFilter(Filter filter)
		{
			UsdPINVOKE.UsdPrimCompositionQuery_SetFilter(swigCPtr, Filter.getCPtr(filter));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public Filter GetFilter()
		{
			return new Filter(UsdPINVOKE.UsdPrimCompositionQuery_GetFilter(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimCompositionQueryArcVector GetCompositionArcs()
		{
			return new UsdPrimCompositionQueryArcVector(UsdPINVOKE.UsdPrimCompositionQuery_GetCompositionArcs(swigCPtr), cMemoryOwn: true);
		}
	}
}
