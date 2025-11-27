using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelCache : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdSkelCache(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelCache obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelCache obj)
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

		~UsdSkelCache()
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
						UsdSkelPINVOKE.delete_UsdSkelCache(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelCache()
			: this(UsdSkelPINVOKE.new_UsdSkelCache(), cMemoryOwn: true)
		{
		}

		public void Clear()
		{
			UsdSkelPINVOKE.UsdSkelCache_Clear(swigCPtr);
		}

		public bool Populate(UsdSkelRoot root, Usd_PrimFlagsPredicate predicate)
		{
			bool result = UsdSkelPINVOKE.UsdSkelCache_Populate(swigCPtr, UsdSkelRoot.getCPtr(root), Usd_PrimFlagsPredicate.getCPtr(predicate));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdSkelSkeletonQuery GetSkelQuery(UsdSkelSkeleton skel)
		{
			UsdSkelSkeletonQuery result = new UsdSkelSkeletonQuery(UsdSkelPINVOKE.UsdSkelCache_GetSkelQuery(swigCPtr, UsdSkelSkeleton.getCPtr(skel)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdSkelAnimQuery GetAnimQuery(UsdSkelAnimation anim)
		{
			UsdSkelAnimQuery result = new UsdSkelAnimQuery(UsdSkelPINVOKE.UsdSkelCache_GetAnimQuery__SWIG_0(swigCPtr, UsdSkelAnimation.getCPtr(anim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdSkelAnimQuery GetAnimQuery(UsdPrim prim)
		{
			UsdSkelAnimQuery result = new UsdSkelAnimQuery(UsdSkelPINVOKE.UsdSkelCache_GetAnimQuery__SWIG_1(swigCPtr, UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdSkelSkinningQuery GetSkinningQuery(UsdPrim prim)
		{
			UsdSkelSkinningQuery result = new UsdSkelSkinningQuery(UsdSkelPINVOKE.UsdSkelCache_GetSkinningQuery(swigCPtr, UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeSkelBindings(UsdSkelRoot skelRoot, UsdSkelBindingVector bindings, Usd_PrimFlagsPredicate predicate)
		{
			bool result = UsdSkelPINVOKE.UsdSkelCache_ComputeSkelBindings(swigCPtr, UsdSkelRoot.getCPtr(skelRoot), UsdSkelBindingVector.getCPtr(bindings), Usd_PrimFlagsPredicate.getCPtr(predicate));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeSkelBinding(UsdSkelRoot skelRoot, UsdSkelSkeleton skel, UsdSkelBinding binding, Usd_PrimFlagsPredicate predicate)
		{
			bool result = UsdSkelPINVOKE.UsdSkelCache_ComputeSkelBinding(swigCPtr, UsdSkelRoot.getCPtr(skelRoot), UsdSkelSkeleton.getCPtr(skel), UsdSkelBinding.getCPtr(binding), Usd_PrimFlagsPredicate.getCPtr(predicate));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
