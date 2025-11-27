using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomCamera : UsdGeomXformable
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomCamera(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomCamera_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomCamera obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomCamera obj)
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
						UsdGeomPINVOKE.delete_UsdGeomCamera(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomCamera(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomCamera__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomCamera()
			: this(UsdGeomPINVOKE.new_UsdGeomCamera__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomCamera(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomCamera__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomCamera_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomCamera_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomCamera Get(UsdStage stage, SdfPath path)
		{
			UsdGeomCamera result = new UsdGeomCamera(UsdGeomPINVOKE.UsdGeomCamera_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomCamera Define(UsdStage stage, SdfPath path)
		{
			UsdGeomCamera result = new UsdGeomCamera(UsdGeomPINVOKE.UsdGeomCamera_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetProjectionAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetProjectionAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateProjectionAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateProjectionAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateProjectionAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateProjectionAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateProjectionAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateProjectionAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetHorizontalApertureAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetHorizontalApertureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateHorizontalApertureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateHorizontalApertureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateHorizontalApertureAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVerticalApertureAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetVerticalApertureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVerticalApertureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateVerticalApertureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVerticalApertureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateVerticalApertureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVerticalApertureAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateVerticalApertureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetHorizontalApertureOffsetAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetHorizontalApertureOffsetAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateHorizontalApertureOffsetAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateHorizontalApertureOffsetAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateHorizontalApertureOffsetAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVerticalApertureOffsetAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetVerticalApertureOffsetAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVerticalApertureOffsetAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVerticalApertureOffsetAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVerticalApertureOffsetAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFocalLengthAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetFocalLengthAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFocalLengthAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFocalLengthAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFocalLengthAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFocalLengthAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFocalLengthAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFocalLengthAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetClippingRangeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetClippingRangeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateClippingRangeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateClippingRangeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateClippingRangeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateClippingRangeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateClippingRangeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateClippingRangeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetClippingPlanesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetClippingPlanesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateClippingPlanesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateClippingPlanesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateClippingPlanesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateClippingPlanesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateClippingPlanesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateClippingPlanesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFStopAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetFStopAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFStopAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFStopAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFStopAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFStopAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFStopAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFStopAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFocusDistanceAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetFocusDistanceAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFocusDistanceAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFocusDistanceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFocusDistanceAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFocusDistanceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFocusDistanceAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateFocusDistanceAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetStereoRoleAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetStereoRoleAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateStereoRoleAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateStereoRoleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateStereoRoleAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateStereoRoleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateStereoRoleAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateStereoRoleAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShutterOpenAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetShutterOpenAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShutterOpenAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateShutterOpenAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShutterOpenAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateShutterOpenAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShutterOpenAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateShutterOpenAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShutterCloseAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetShutterCloseAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShutterCloseAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateShutterCloseAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShutterCloseAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateShutterCloseAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShutterCloseAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateShutterCloseAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetExposureAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_GetExposureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateExposureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateExposureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExposureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateExposureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExposureAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCamera_CreateExposureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public GfCamera GetCamera(UsdTimeCode time)
		{
			GfCamera result = new GfCamera(UsdGeomPINVOKE.UsdGeomCamera_GetCamera(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetFromCamera(GfCamera camera, UsdTimeCode time)
		{
			UsdGeomPINVOKE.UsdGeomCamera_SetFromCamera(swigCPtr, GfCamera.getCPtr(camera), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
