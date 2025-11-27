using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxShapingAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdLuxShapingAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxShapingAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxShapingAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxShapingAPI obj)
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
						UsdLuxPINVOKE.delete_UsdLuxShapingAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxShapingAPI(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxShapingAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxShapingAPI()
			: this(UsdLuxPINVOKE.new_UsdLuxShapingAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxShapingAPI(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxShapingAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxShapingAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxShapingAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdLuxShapingAPI Get(UsdStage stage, SdfPath path)
		{
			UsdLuxShapingAPI result = new UsdLuxShapingAPI(UsdLuxPINVOKE.UsdLuxShapingAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdLuxPINVOKE.UsdLuxShapingAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdLuxPINVOKE.UsdLuxShapingAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxShapingAPI Apply(UsdPrim prim)
		{
			UsdLuxShapingAPI result = new UsdLuxShapingAPI(UsdLuxPINVOKE.UsdLuxShapingAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetShapingFocusAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_GetShapingFocusAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShapingFocusAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingFocusAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingFocusAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShapingFocusTintAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_GetShapingFocusTintAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShapingFocusTintAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingFocusTintAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingFocusTintAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShapingConeAngleAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_GetShapingConeAngleAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShapingConeAngleAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingConeAngleAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingConeAngleAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShapingConeSoftnessAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_GetShapingConeSoftnessAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShapingConeSoftnessAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingConeSoftnessAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingConeSoftnessAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShapingIesFileAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_GetShapingIesFileAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShapingIesFileAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingIesFileAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingIesFileAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShapingIesAngleScaleAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_GetShapingIesAngleScaleAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShapingIesAngleScaleAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingIesAngleScaleAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingIesAngleScaleAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShapingIesNormalizeAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_GetShapingIesNormalizeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShapingIesNormalizeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingIesNormalizeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShapingIesNormalizeAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdLuxShapingAPI(UsdShadeConnectableAPI connectable)
			: this(UsdLuxPINVOKE.new_UsdLuxShapingAPI__SWIG_3(UsdShadeConnectableAPI.getCPtr(connectable)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectableAPI ConnectableAPI()
		{
			return new UsdShadeConnectableAPI(UsdLuxPINVOKE.UsdLuxShapingAPI_ConnectableAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetOutput(TfToken name)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdLuxPINVOKE.UsdLuxShapingAPI_GetOutput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutputVector GetOutputs(bool onlyAuthored)
		{
			return new UsdShadeOutputVector(UsdLuxPINVOKE.UsdLuxShapingAPI_GetOutputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetOutputs()
		{
			return new UsdShadeOutputVector(UsdLuxPINVOKE.UsdLuxShapingAPI_GetOutputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeInput result = new UsdShadeInput(UsdLuxPINVOKE.UsdLuxShapingAPI_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInput GetInput(TfToken name)
		{
			UsdShadeInput result = new UsdShadeInput(UsdLuxPINVOKE.UsdLuxShapingAPI_GetInput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInputVector GetInputs(bool onlyAuthored)
		{
			return new UsdShadeInputVector(UsdLuxPINVOKE.UsdLuxShapingAPI_GetInputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeInputVector GetInputs()
		{
			return new UsdShadeInputVector(UsdLuxPINVOKE.UsdLuxShapingAPI_GetInputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}
	}
}
