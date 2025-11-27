using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxCylinderLight : UsdLuxBoundableLightBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdLuxCylinderLight(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxCylinderLight_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxCylinderLight obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxCylinderLight obj)
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
						UsdLuxPINVOKE.delete_UsdLuxCylinderLight(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxCylinderLight(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxCylinderLight__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxCylinderLight()
			: this(UsdLuxPINVOKE.new_UsdLuxCylinderLight__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxCylinderLight(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxCylinderLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxCylinderLight_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxCylinderLight_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdLuxCylinderLight Get(UsdStage stage, SdfPath path)
		{
			UsdLuxCylinderLight result = new UsdLuxCylinderLight(UsdLuxPINVOKE.UsdLuxCylinderLight_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxCylinderLight Define(UsdStage stage, SdfPath path)
		{
			UsdLuxCylinderLight result = new UsdLuxCylinderLight(UsdLuxPINVOKE.UsdLuxCylinderLight_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetLengthAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_GetLengthAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateLengthAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateLengthAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateLengthAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateLengthAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateLengthAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateLengthAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetRadiusAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_GetRadiusAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateRadiusAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateRadiusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRadiusAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateRadiusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRadiusAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateRadiusAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTreatAsLineAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_GetTreatAsLineAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTreatAsLineAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTreatAsLineAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTreatAsLineAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
