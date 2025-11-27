using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxDistantLight : UsdLuxNonboundableLightBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdLuxDistantLight(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxDistantLight_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxDistantLight obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxDistantLight obj)
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
						UsdLuxPINVOKE.delete_UsdLuxDistantLight(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxDistantLight(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxDistantLight__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxDistantLight()
			: this(UsdLuxPINVOKE.new_UsdLuxDistantLight__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxDistantLight(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxDistantLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxDistantLight_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxDistantLight_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdLuxDistantLight Get(UsdStage stage, SdfPath path)
		{
			UsdLuxDistantLight result = new UsdLuxDistantLight(UsdLuxPINVOKE.UsdLuxDistantLight_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxDistantLight Define(UsdStage stage, SdfPath path)
		{
			UsdLuxDistantLight result = new UsdLuxDistantLight(UsdLuxPINVOKE.UsdLuxDistantLight_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAngleAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxDistantLight_GetAngleAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateAngleAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxDistantLight_CreateAngleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAngleAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxDistantLight_CreateAngleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAngleAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxDistantLight_CreateAngleAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
