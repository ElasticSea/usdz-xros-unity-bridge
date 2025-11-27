using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxDomeLight : UsdLuxNonboundableLightBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdLuxDomeLight(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxDomeLight_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxDomeLight obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxDomeLight obj)
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
						UsdLuxPINVOKE.delete_UsdLuxDomeLight(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxDomeLight(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxDomeLight__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxDomeLight()
			: this(UsdLuxPINVOKE.new_UsdLuxDomeLight__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxDomeLight(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxDomeLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxDomeLight_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxDomeLight_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdLuxDomeLight Get(UsdStage stage, SdfPath path)
		{
			UsdLuxDomeLight result = new UsdLuxDomeLight(UsdLuxPINVOKE.UsdLuxDomeLight_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxDomeLight Define(UsdStage stage, SdfPath path)
		{
			UsdLuxDomeLight result = new UsdLuxDomeLight(UsdLuxPINVOKE.UsdLuxDomeLight_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetTextureFileAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_GetTextureFileAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTextureFileAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateTextureFileAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTextureFileAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateTextureFileAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTextureFileAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateTextureFileAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTextureFormatAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_GetTextureFormatAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTextureFormatAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTextureFormatAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTextureFormatAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetGuideRadiusAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_GetGuideRadiusAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateGuideRadiusAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateGuideRadiusAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateGuideRadiusAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetPortalsRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxDomeLight_GetPortalsRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreatePortalsRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxDomeLight_CreatePortalsRel(swigCPtr), cMemoryOwn: true);
		}

		public void OrientToStageUpAxis()
		{
			UsdLuxPINVOKE.UsdLuxDomeLight_OrientToStageUpAxis(swigCPtr);
		}
	}
}
