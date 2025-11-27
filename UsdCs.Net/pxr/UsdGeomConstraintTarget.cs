using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomConstraintTarget : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdGeomConstraintTarget(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomConstraintTarget obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomConstraintTarget obj)
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

		~UsdGeomConstraintTarget()
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
						UsdGeomPINVOKE.delete_UsdGeomConstraintTarget(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomConstraintTarget()
			: this(UsdGeomPINVOKE.new_UsdGeomConstraintTarget__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdGeomConstraintTarget(UsdAttribute attr)
			: this(UsdGeomPINVOKE.new_UsdGeomConstraintTarget__SWIG_1(UsdAttribute.getCPtr(attr)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool IsValid(UsdAttribute attr)
		{
			bool result = UsdGeomPINVOKE.UsdGeomConstraintTarget_IsValid(UsdAttribute.getCPtr(attr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomConstraintTarget_GetAttr(swigCPtr), cMemoryOwn: false);
		}

		public bool IsDefined()
		{
			return UsdGeomPINVOKE.UsdGeomConstraintTarget_IsDefined(swigCPtr);
		}

		public bool Get(GfMatrix4d value, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomConstraintTarget_Get__SWIG_0(swigCPtr, GfMatrix4d.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Get(GfMatrix4d value)
		{
			return UsdGeomPINVOKE.UsdGeomConstraintTarget_Get__SWIG_1(swigCPtr, GfMatrix4d.getCPtr(value));
		}

		public bool Set(GfMatrix4d value, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomConstraintTarget_Set__SWIG_0(swigCPtr, GfMatrix4d.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Set(GfMatrix4d value)
		{
			bool result = UsdGeomPINVOKE.UsdGeomConstraintTarget_Set__SWIG_1(swigCPtr, GfMatrix4d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetIdentifier()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomConstraintTarget_GetIdentifier(swigCPtr), cMemoryOwn: true);
		}

		public void SetIdentifier(TfToken identifier)
		{
			UsdGeomPINVOKE.UsdGeomConstraintTarget_SetIdentifier(swigCPtr, TfToken.getCPtr(identifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static TfToken GetConstraintAttrName(string constraintName)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomConstraintTarget_GetConstraintAttrName(constraintName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d ComputeInWorldSpace(UsdTimeCode time, UsdGeomXformCache xfCache)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), UsdGeomXformCache.getCPtr(xfCache)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d ComputeInWorldSpace(UsdTimeCode time)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d ComputeInWorldSpace()
		{
			return new GfMatrix4d(UsdGeomPINVOKE.UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
