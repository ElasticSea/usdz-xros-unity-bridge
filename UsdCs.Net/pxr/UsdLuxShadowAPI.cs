using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxShadowAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdLuxShadowAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxShadowAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxShadowAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxShadowAPI obj)
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
						UsdLuxPINVOKE.delete_UsdLuxShadowAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxShadowAPI(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxShadowAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxShadowAPI()
			: this(UsdLuxPINVOKE.new_UsdLuxShadowAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxShadowAPI(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxShadowAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxShadowAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxShadowAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdLuxShadowAPI Get(UsdStage stage, SdfPath path)
		{
			UsdLuxShadowAPI result = new UsdLuxShadowAPI(UsdLuxPINVOKE.UsdLuxShadowAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdLuxPINVOKE.UsdLuxShadowAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdLuxPINVOKE.UsdLuxShadowAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxShadowAPI Apply(UsdPrim prim)
		{
			UsdLuxShadowAPI result = new UsdLuxShadowAPI(UsdLuxPINVOKE.UsdLuxShadowAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetShadowEnableAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_GetShadowEnableAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShadowEnableAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowEnableAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowEnableAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShadowColorAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_GetShadowColorAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShadowColorAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowColorAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowColorAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShadowDistanceAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_GetShadowDistanceAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShadowDistanceAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowDistanceAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowDistanceAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShadowFalloffAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_GetShadowFalloffAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShadowFalloffAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowFalloffAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowFalloffAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShadowFalloffGammaAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_GetShadowFalloffGammaAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShadowFalloffGammaAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowFalloffGammaAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShadowFalloffGammaAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdLuxShadowAPI(UsdShadeConnectableAPI connectable)
			: this(UsdLuxPINVOKE.new_UsdLuxShadowAPI__SWIG_3(UsdShadeConnectableAPI.getCPtr(connectable)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectableAPI ConnectableAPI()
		{
			return new UsdShadeConnectableAPI(UsdLuxPINVOKE.UsdLuxShadowAPI_ConnectableAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetOutput(TfToken name)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdLuxPINVOKE.UsdLuxShadowAPI_GetOutput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutputVector GetOutputs(bool onlyAuthored)
		{
			return new UsdShadeOutputVector(UsdLuxPINVOKE.UsdLuxShadowAPI_GetOutputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetOutputs()
		{
			return new UsdShadeOutputVector(UsdLuxPINVOKE.UsdLuxShadowAPI_GetOutputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeInput result = new UsdShadeInput(UsdLuxPINVOKE.UsdLuxShadowAPI_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInput GetInput(TfToken name)
		{
			UsdShadeInput result = new UsdShadeInput(UsdLuxPINVOKE.UsdLuxShadowAPI_GetInput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInputVector GetInputs(bool onlyAuthored)
		{
			return new UsdShadeInputVector(UsdLuxPINVOKE.UsdLuxShadowAPI_GetInputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeInputVector GetInputs()
		{
			return new UsdShadeInputVector(UsdLuxPINVOKE.UsdLuxShadowAPI_GetInputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}
	}
}
