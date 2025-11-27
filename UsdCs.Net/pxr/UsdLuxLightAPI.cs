using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxLightAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdLuxLightAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxLightAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxLightAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxLightAPI obj)
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
						UsdLuxPINVOKE.delete_UsdLuxLightAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxLightAPI(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxLightAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxLightAPI()
			: this(UsdLuxPINVOKE.new_UsdLuxLightAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxLightAPI(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxLightAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxLightAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxLightAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdLuxLightAPI Get(UsdStage stage, SdfPath path)
		{
			UsdLuxLightAPI result = new UsdLuxLightAPI(UsdLuxPINVOKE.UsdLuxLightAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdLuxPINVOKE.UsdLuxLightAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdLuxPINVOKE.UsdLuxLightAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxLightAPI Apply(UsdPrim prim)
		{
			UsdLuxLightAPI result = new UsdLuxLightAPI(UsdLuxPINVOKE.UsdLuxLightAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetShaderIdAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetShaderIdAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShaderIdAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateShaderIdAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateShaderIdAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateShaderIdAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetMaterialSyncModeAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetMaterialSyncModeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateMaterialSyncModeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateMaterialSyncModeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateMaterialSyncModeAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetIntensityAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetIntensityAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIntensityAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateIntensityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIntensityAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateIntensityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIntensityAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateIntensityAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetExposureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetExposureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateExposureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateExposureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExposureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateExposureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExposureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateExposureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetDiffuseAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetDiffuseAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateDiffuseAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateDiffuseAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDiffuseAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateDiffuseAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDiffuseAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateDiffuseAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetSpecularAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetSpecularAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateSpecularAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateSpecularAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSpecularAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateSpecularAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSpecularAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateSpecularAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetNormalizeAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetNormalizeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateNormalizeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateNormalizeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalizeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateNormalizeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalizeAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateNormalizeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetColorAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetColorAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateColorAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateColorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateColorAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateColorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateColorAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateColorAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetEnableColorTemperatureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetEnableColorTemperatureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateEnableColorTemperatureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateEnableColorTemperatureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateEnableColorTemperatureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetColorTemperatureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetColorTemperatureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateColorTemperatureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateColorTemperatureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateColorTemperatureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetFiltersRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxLightAPI_GetFiltersRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateFiltersRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxLightAPI_CreateFiltersRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdLuxLightAPI(UsdShadeConnectableAPI connectable)
			: this(UsdLuxPINVOKE.new_UsdLuxLightAPI__SWIG_3(UsdShadeConnectableAPI.getCPtr(connectable)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectableAPI ConnectableAPI()
		{
			return new UsdShadeConnectableAPI(UsdLuxPINVOKE.UsdLuxLightAPI_ConnectableAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdLuxPINVOKE.UsdLuxLightAPI_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetOutput(TfToken name)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdLuxPINVOKE.UsdLuxLightAPI_GetOutput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutputVector GetOutputs(bool onlyAuthored)
		{
			return new UsdShadeOutputVector(UsdLuxPINVOKE.UsdLuxLightAPI_GetOutputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetOutputs()
		{
			return new UsdShadeOutputVector(UsdLuxPINVOKE.UsdLuxLightAPI_GetOutputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeInput result = new UsdShadeInput(UsdLuxPINVOKE.UsdLuxLightAPI_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInput GetInput(TfToken name)
		{
			UsdShadeInput result = new UsdShadeInput(UsdLuxPINVOKE.UsdLuxLightAPI_GetInput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInputVector GetInputs(bool onlyAuthored)
		{
			return new UsdShadeInputVector(UsdLuxPINVOKE.UsdLuxLightAPI_GetInputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeInputVector GetInputs()
		{
			return new UsdShadeInputVector(UsdLuxPINVOKE.UsdLuxLightAPI_GetInputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdCollectionAPI GetLightLinkCollectionAPI()
		{
			return new UsdCollectionAPI(UsdLuxPINVOKE.UsdLuxLightAPI_GetLightLinkCollectionAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdCollectionAPI GetShadowLinkCollectionAPI()
		{
			return new UsdCollectionAPI(UsdLuxPINVOKE.UsdLuxLightAPI_GetShadowLinkCollectionAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShaderIdAttrForRenderContext(TfToken renderContext)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_GetShaderIdAttrForRenderContext(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttrForRenderContext(TfToken renderContext, VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext), VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttrForRenderContext(TfToken renderContext, VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_1(swigCPtr, TfToken.getCPtr(renderContext), VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttrForRenderContext(TfToken renderContext)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_2(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetShaderId(TfTokenVector renderContexts)
		{
			TfToken result = new TfToken(UsdLuxPINVOKE.UsdLuxLightAPI_GetShaderId(swigCPtr, TfTokenVector.getCPtr(renderContexts)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
