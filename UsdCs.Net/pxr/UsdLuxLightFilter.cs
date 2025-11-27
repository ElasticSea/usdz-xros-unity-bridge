using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxLightFilter : UsdGeomXformable
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdLuxLightFilter(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxLightFilter_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxLightFilter obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxLightFilter obj)
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
						UsdLuxPINVOKE.delete_UsdLuxLightFilter(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxLightFilter(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxLightFilter__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxLightFilter()
			: this(UsdLuxPINVOKE.new_UsdLuxLightFilter__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxLightFilter(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxLightFilter__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxLightFilter_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxLightFilter_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdLuxLightFilter Get(UsdStage stage, SdfPath path)
		{
			UsdLuxLightFilter result = new UsdLuxLightFilter(UsdLuxPINVOKE.UsdLuxLightFilter_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxLightFilter Define(UsdStage stage, SdfPath path)
		{
			UsdLuxLightFilter result = new UsdLuxLightFilter(UsdLuxPINVOKE.UsdLuxLightFilter_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetShaderIdAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightFilter_GetShaderIdAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateShaderIdAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightFilter_CreateShaderIdAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightFilter_CreateShaderIdAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightFilter_CreateShaderIdAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdLuxLightFilter(UsdShadeConnectableAPI connectable)
			: this(UsdLuxPINVOKE.new_UsdLuxLightFilter__SWIG_3(UsdShadeConnectableAPI.getCPtr(connectable)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectableAPI ConnectableAPI()
		{
			return new UsdShadeConnectableAPI(UsdLuxPINVOKE.UsdLuxLightFilter_ConnectableAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdLuxPINVOKE.UsdLuxLightFilter_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetOutput(TfToken name)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdLuxPINVOKE.UsdLuxLightFilter_GetOutput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutputVector GetOutputs(bool onlyAuthored)
		{
			return new UsdShadeOutputVector(UsdLuxPINVOKE.UsdLuxLightFilter_GetOutputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetOutputs()
		{
			return new UsdShadeOutputVector(UsdLuxPINVOKE.UsdLuxLightFilter_GetOutputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeInput result = new UsdShadeInput(UsdLuxPINVOKE.UsdLuxLightFilter_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInput GetInput(TfToken name)
		{
			UsdShadeInput result = new UsdShadeInput(UsdLuxPINVOKE.UsdLuxLightFilter_GetInput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInputVector GetInputs(bool onlyAuthored)
		{
			return new UsdShadeInputVector(UsdLuxPINVOKE.UsdLuxLightFilter_GetInputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeInputVector GetInputs()
		{
			return new UsdShadeInputVector(UsdLuxPINVOKE.UsdLuxLightFilter_GetInputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdCollectionAPI GetFilterLinkCollectionAPI()
		{
			return new UsdCollectionAPI(UsdLuxPINVOKE.UsdLuxLightFilter_GetFilterLinkCollectionAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetShaderIdAttrForRenderContext(TfToken renderContext)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightFilter_GetShaderIdAttrForRenderContext(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttrForRenderContext(TfToken renderContext, VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext), VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttrForRenderContext(TfToken renderContext, VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_1(swigCPtr, TfToken.getCPtr(renderContext), VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateShaderIdAttrForRenderContext(TfToken renderContext)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_2(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetShaderId(TfTokenVector renderContexts)
		{
			TfToken result = new TfToken(UsdLuxPINVOKE.UsdLuxLightFilter_GetShaderId(swigCPtr, TfTokenVector.getCPtr(renderContexts)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
