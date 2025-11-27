using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelBinding : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdSkelBinding(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelBinding obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelBinding obj)
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

		~UsdSkelBinding()
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
						UsdSkelPINVOKE.delete_UsdSkelBinding(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelBinding()
			: this(UsdSkelPINVOKE.new_UsdSkelBinding__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkelBinding(UsdSkelSkeleton skel, SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t skinningQueries)
			: this(UsdSkelPINVOKE.new_UsdSkelBinding__SWIG_1(UsdSkelSkeleton.getCPtr(skel), SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t.getCPtr(skinningQueries)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelSkeleton GetSkeleton()
		{
			return new UsdSkelSkeleton(UsdSkelPINVOKE.UsdSkelBinding_GetSkeleton(swigCPtr), cMemoryOwn: false);
		}

		public SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t GetSkinningTargets()
		{
			return new SWIGTYPE_p_VtArrayT_UsdSkelSkinningQuery_t(UsdSkelPINVOKE.UsdSkelBinding_GetSkinningTargets(swigCPtr), futureUse: false);
		}

		public UsdSkelSkinningQueryVector GetSkinningTargetsAsVector()
		{
			return new UsdSkelSkinningQueryVector(UsdSkelPINVOKE.UsdSkelBinding_GetSkinningTargetsAsVector(swigCPtr), cMemoryOwn: true);
		}
	}
}
