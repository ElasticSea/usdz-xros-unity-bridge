using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelSkeletonQuery : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdSkelSkeletonQuery(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelSkeletonQuery obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelSkeletonQuery obj)
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

		~UsdSkelSkeletonQuery()
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
						UsdSkelPINVOKE.delete_UsdSkelSkeletonQuery(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelSkeletonQuery()
			: this(UsdSkelPINVOKE.new_UsdSkelSkeletonQuery(), cMemoryOwn: true)
		{
		}

		public bool IsValid()
		{
			return UsdSkelPINVOKE.UsdSkelSkeletonQuery_IsValid(swigCPtr);
		}

		public bool HasBindPose()
		{
			return UsdSkelPINVOKE.UsdSkelSkeletonQuery_HasBindPose(swigCPtr);
		}

		public bool HasRestPose()
		{
			return UsdSkelPINVOKE.UsdSkelSkeletonQuery_HasRestPose(swigCPtr);
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdSkelPINVOKE.UsdSkelSkeletonQuery_GetPrim(swigCPtr), cMemoryOwn: true);
		}

		public UsdSkelSkeleton GetSkeleton()
		{
			return new UsdSkelSkeleton(UsdSkelPINVOKE.UsdSkelSkeletonQuery_GetSkeleton(swigCPtr), cMemoryOwn: false);
		}

		public UsdSkelAnimQuery GetAnimQuery()
		{
			return new UsdSkelAnimQuery(UsdSkelPINVOKE.UsdSkelSkeletonQuery_GetAnimQuery(swigCPtr), cMemoryOwn: false);
		}

		public UsdSkelTopology GetTopology()
		{
			return new UsdSkelTopology(UsdSkelPINVOKE.UsdSkelSkeletonQuery_GetTopology(swigCPtr), cMemoryOwn: false);
		}

		public UsdSkelAnimMapper GetMapper()
		{
			return new UsdSkelAnimMapper(UsdSkelPINVOKE.UsdSkelSkeletonQuery_GetMapper(swigCPtr), cMemoryOwn: true);
		}

		public VtTokenArray GetJointOrder()
		{
			return new VtTokenArray(UsdSkelPINVOKE.UsdSkelSkeletonQuery_GetJointOrder(swigCPtr), cMemoryOwn: true);
		}

		public string GetDescription()
		{
			return UsdSkelPINVOKE.UsdSkelSkeletonQuery_GetDescription(swigCPtr);
		}

		public bool ComputeJointLocalTransforms(VtMatrix4dArray xforms, UsdTimeCode time, bool atRest)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_2(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), atRest);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeJointLocalTransforms(VtMatrix4dArray xforms, UsdTimeCode time)
		{
			bool result = UsdSkelPINVOKE.UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_3(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetJointWorldBindTransforms(VtMatrix4dArray xforms)
		{
			return UsdSkelPINVOKE.UsdSkelSkeletonQuery_GetJointWorldBindTransforms(swigCPtr, VtMatrix4dArray.getCPtr(xforms));
		}
	}
}
