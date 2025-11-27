using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdRiMaterialAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdRiMaterialAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdRiPINVOKE.UsdRiMaterialAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdRiMaterialAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdRiMaterialAPI obj)
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
						UsdRiPINVOKE.delete_UsdRiMaterialAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdRiMaterialAPI(UsdPrim prim)
			: this(UsdRiPINVOKE.new_UsdRiMaterialAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdRiMaterialAPI()
			: this(UsdRiPINVOKE.new_UsdRiMaterialAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdRiMaterialAPI(UsdSchemaBase schemaObj)
			: this(UsdRiPINVOKE.new_UsdRiMaterialAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdRiPINVOKE.UsdRiMaterialAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdRiPINVOKE.UsdRiMaterialAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdRiMaterialAPI Get(UsdStage stage, SdfPath path)
		{
			UsdRiMaterialAPI result = new UsdRiMaterialAPI(UsdRiPINVOKE.UsdRiMaterialAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdRiPINVOKE.UsdRiMaterialAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdRiPINVOKE.UsdRiMaterialAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdRiMaterialAPI Apply(UsdPrim prim)
		{
			UsdRiMaterialAPI result = new UsdRiMaterialAPI(UsdRiPINVOKE.UsdRiMaterialAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetSurfaceAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_GetSurfaceAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateSurfaceAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSurfaceAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSurfaceAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetDisplacementAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_GetDisplacementAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateDisplacementAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDisplacementAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDisplacementAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVolumeAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_GetVolumeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVolumeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateVolumeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVolumeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateVolumeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVolumeAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiMaterialAPI_CreateVolumeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRiMaterialAPI(UsdShadeMaterial material)
			: this(UsdRiPINVOKE.new_UsdRiMaterialAPI__SWIG_3(UsdShadeMaterial.getCPtr(material)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeOutput GetSurfaceOutput()
		{
			return new UsdShadeOutput(UsdRiPINVOKE.UsdRiMaterialAPI_GetSurfaceOutput(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput GetDisplacementOutput()
		{
			return new UsdShadeOutput(UsdRiPINVOKE.UsdRiMaterialAPI_GetDisplacementOutput(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput GetVolumeOutput()
		{
			return new UsdShadeOutput(UsdRiPINVOKE.UsdRiMaterialAPI_GetVolumeOutput(swigCPtr), cMemoryOwn: true);
		}

		public bool SetSurfaceSource(SdfPath surfacePath)
		{
			bool result = UsdRiPINVOKE.UsdRiMaterialAPI_SetSurfaceSource(swigCPtr, SdfPath.getCPtr(surfacePath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetDisplacementSource(SdfPath displacementPath)
		{
			bool result = UsdRiPINVOKE.UsdRiMaterialAPI_SetDisplacementSource(swigCPtr, SdfPath.getCPtr(displacementPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetVolumeSource(SdfPath volumePath)
		{
			bool result = UsdRiPINVOKE.UsdRiMaterialAPI_SetVolumeSource(swigCPtr, SdfPath.getCPtr(volumePath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader GetSurface(bool ignoreBaseMaterial)
		{
			return new UsdShadeShader(UsdRiPINVOKE.UsdRiMaterialAPI_GetSurface__SWIG_0(swigCPtr, ignoreBaseMaterial), cMemoryOwn: true);
		}

		public UsdShadeShader GetSurface()
		{
			return new UsdShadeShader(UsdRiPINVOKE.UsdRiMaterialAPI_GetSurface__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeShader GetDisplacement(bool ignoreBaseMaterial)
		{
			return new UsdShadeShader(UsdRiPINVOKE.UsdRiMaterialAPI_GetDisplacement__SWIG_0(swigCPtr, ignoreBaseMaterial), cMemoryOwn: true);
		}

		public UsdShadeShader GetDisplacement()
		{
			return new UsdShadeShader(UsdRiPINVOKE.UsdRiMaterialAPI_GetDisplacement__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeShader GetVolume(bool ignoreBaseMaterial)
		{
			return new UsdShadeShader(UsdRiPINVOKE.UsdRiMaterialAPI_GetVolume__SWIG_0(swigCPtr, ignoreBaseMaterial), cMemoryOwn: true);
		}

		public UsdShadeShader GetVolume()
		{
			return new UsdShadeShader(UsdRiPINVOKE.UsdRiMaterialAPI_GetVolume__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public InterfaceInputConsumersMap ComputeInterfaceInputConsumersMap(bool computeTransitiveConsumers)
		{
			return new InterfaceInputConsumersMap(UsdRiPINVOKE.UsdRiMaterialAPI_ComputeInterfaceInputConsumersMap__SWIG_0(swigCPtr, computeTransitiveConsumers), cMemoryOwn: true);
		}

		public InterfaceInputConsumersMap ComputeInterfaceInputConsumersMap()
		{
			return new InterfaceInputConsumersMap(UsdRiPINVOKE.UsdRiMaterialAPI_ComputeInterfaceInputConsumersMap__SWIG_1(swigCPtr), cMemoryOwn: true);
		}
	}
}
