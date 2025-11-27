using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxSphereLight : UsdLuxBoundableLightBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdLuxSphereLight(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxSphereLight_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxSphereLight obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxSphereLight obj)
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
						UsdLuxPINVOKE.delete_UsdLuxSphereLight(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxSphereLight(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxSphereLight__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxSphereLight()
			: this(UsdLuxPINVOKE.new_UsdLuxSphereLight__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxSphereLight(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxSphereLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxSphereLight_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxSphereLight_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdLuxSphereLight Get(UsdStage stage, SdfPath path)
		{
			UsdLuxSphereLight result = new UsdLuxSphereLight(UsdLuxPINVOKE.UsdLuxSphereLight_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxSphereLight Define(UsdStage stage, SdfPath path)
		{
			UsdLuxSphereLight result = new UsdLuxSphereLight(UsdLuxPINVOKE.UsdLuxSphereLight_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetRadiusAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxSphereLight_GetRadiusAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateRadiusAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxSphereLight_CreateRadiusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRadiusAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxSphereLight_CreateRadiusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRadiusAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxSphereLight_CreateRadiusAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTreatAsPointAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxSphereLight_GetTreatAsPointAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTreatAsPointAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTreatAsPointAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTreatAsPointAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
