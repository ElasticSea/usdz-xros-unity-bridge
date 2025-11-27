using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomMotionAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdGeomMotionAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomMotionAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomMotionAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomMotionAPI obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						UsdGeomPINVOKE.delete_UsdGeomMotionAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomMotionAPI(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomMotionAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomMotionAPI()
			: this(UsdGeomPINVOKE.new_UsdGeomMotionAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomMotionAPI(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomMotionAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomMotionAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomMotionAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdGeomMotionAPI Get(UsdStage stage, SdfPath path)
		{
			UsdGeomMotionAPI result = new UsdGeomMotionAPI(UsdGeomPINVOKE.UsdGeomMotionAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdGeomPINVOKE.UsdGeomMotionAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdGeomPINVOKE.UsdGeomMotionAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomMotionAPI Apply(UsdPrim prim)
		{
			UsdGeomMotionAPI result = new UsdGeomMotionAPI(UsdGeomPINVOKE.UsdGeomMotionAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetMotionBlurScaleAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_GetMotionBlurScaleAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateMotionBlurScaleAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateMotionBlurScaleAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateMotionBlurScaleAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVelocityScaleAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_GetVelocityScaleAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVelocityScaleAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVelocityScaleAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVelocityScaleAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetNonlinearSampleCountAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_GetNonlinearSampleCountAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateNonlinearSampleCountAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNonlinearSampleCountAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNonlinearSampleCountAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public float ComputeVelocityScale(UsdTimeCode time)
		{
			float result = UsdGeomPINVOKE.UsdGeomMotionAPI_ComputeVelocityScale__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public float ComputeVelocityScale()
		{
			return UsdGeomPINVOKE.UsdGeomMotionAPI_ComputeVelocityScale__SWIG_1(swigCPtr);
		}

		public int ComputeNonlinearSampleCount(UsdTimeCode time)
		{
			int result = UsdGeomPINVOKE.UsdGeomMotionAPI_ComputeNonlinearSampleCount__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public int ComputeNonlinearSampleCount()
		{
			return UsdGeomPINVOKE.UsdGeomMotionAPI_ComputeNonlinearSampleCount__SWIG_1(swigCPtr);
		}

		public float ComputeMotionBlurScale(UsdTimeCode time)
		{
			float result = UsdGeomPINVOKE.UsdGeomMotionAPI_ComputeMotionBlurScale__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public float ComputeMotionBlurScale()
		{
			return UsdGeomPINVOKE.UsdGeomMotionAPI_ComputeMotionBlurScale__SWIG_1(swigCPtr);
		}
	}
}
