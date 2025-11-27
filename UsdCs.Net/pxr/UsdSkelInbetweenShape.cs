using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelInbetweenShape : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdSkelInbetweenShape(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelInbetweenShape obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelInbetweenShape obj)
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

		~UsdSkelInbetweenShape()
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
						UsdSkelPINVOKE.delete_UsdSkelInbetweenShape(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelInbetweenShape()
			: this(UsdSkelPINVOKE.new_UsdSkelInbetweenShape__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkelInbetweenShape(UsdAttribute attr)
			: this(UsdSkelPINVOKE.new_UsdSkelInbetweenShape__SWIG_1(UsdAttribute.getCPtr(attr)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetWeight(out float weight)
		{
			return UsdSkelPINVOKE.UsdSkelInbetweenShape_GetWeight(swigCPtr, out weight);
		}

		public bool SetWeight(float weight)
		{
			return UsdSkelPINVOKE.UsdSkelInbetweenShape_SetWeight(swigCPtr, weight);
		}

		public bool HasAuthoredWeight()
		{
			return UsdSkelPINVOKE.UsdSkelInbetweenShape_HasAuthoredWeight(swigCPtr);
		}

		public bool GetOffsets(VtVec3fArray offsets)
		{
			return UsdSkelPINVOKE.UsdSkelInbetweenShape_GetOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
		}

		public bool SetOffsets(VtVec3fArray offsets)
		{
			bool result = UsdSkelPINVOKE.UsdSkelInbetweenShape_SetOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetNormalOffsetsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelInbetweenShape_GetNormalOffsetsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateNormalOffsetsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelInbetweenShape_CreateNormalOffsetsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalOffsetsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelInbetweenShape_CreateNormalOffsetsAttr__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public bool GetNormalOffsets(VtVec3fArray offsets)
		{
			return UsdSkelPINVOKE.UsdSkelInbetweenShape_GetNormalOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
		}

		public bool SetNormalOffsets(VtVec3fArray offsets)
		{
			bool result = UsdSkelPINVOKE.UsdSkelInbetweenShape_SetNormalOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsInbetween(UsdAttribute attr)
		{
			bool result = UsdSkelPINVOKE.UsdSkelInbetweenShape_IsInbetween(UsdAttribute.getCPtr(attr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelInbetweenShape_GetAttr(swigCPtr), cMemoryOwn: false);
		}

		public bool IsDefined()
		{
			return UsdSkelPINVOKE.UsdSkelInbetweenShape_IsDefined(swigCPtr);
		}
	}
}
