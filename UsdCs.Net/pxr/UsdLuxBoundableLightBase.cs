using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxBoundableLightBase : UsdGeomBoundable
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdLuxBoundableLightBase(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxBoundableLightBase_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxBoundableLightBase obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxBoundableLightBase obj)
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
						UsdLuxPINVOKE.delete_UsdLuxBoundableLightBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxBoundableLightBase(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxBoundableLightBase__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxBoundableLightBase()
			: this(UsdLuxPINVOKE.new_UsdLuxBoundableLightBase__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxBoundableLightBase(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxBoundableLightBase__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdLuxBoundableLightBase Get(UsdStage stage, SdfPath path)
		{
			UsdLuxBoundableLightBase result = new UsdLuxBoundableLightBase(UsdLuxPINVOKE.UsdLuxBoundableLightBase_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdLuxLightAPI LightAPI()
		{
			return new UsdLuxLightAPI(UsdLuxPINVOKE.UsdLuxBoundableLightBase_LightAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetIntensityAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetIntensityAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIntensityAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIntensityAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIntensityAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetExposureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetExposureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateExposureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExposureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExposureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetDiffuseAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetDiffuseAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateDiffuseAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDiffuseAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDiffuseAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetSpecularAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetSpecularAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateSpecularAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSpecularAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSpecularAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetNormalizeAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetNormalizeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateNormalizeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalizeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalizeAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetColorAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetColorAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateColorAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateColorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateColorAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateColorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateColorAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateColorAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetEnableColorTemperatureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetEnableColorTemperatureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateEnableColorTemperatureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateEnableColorTemperatureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateEnableColorTemperatureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetColorTemperatureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetColorTemperatureAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateColorTemperatureAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateColorTemperatureAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateColorTemperatureAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetFiltersRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxBoundableLightBase_GetFiltersRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateFiltersRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxBoundableLightBase_CreateFiltersRel(swigCPtr), cMemoryOwn: true);
		}
	}
}
