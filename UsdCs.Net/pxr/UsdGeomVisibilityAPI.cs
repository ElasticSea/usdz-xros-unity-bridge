using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomVisibilityAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdGeomVisibilityAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomVisibilityAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomVisibilityAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomVisibilityAPI obj)
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
						UsdGeomPINVOKE.delete_UsdGeomVisibilityAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomVisibilityAPI(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomVisibilityAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomVisibilityAPI()
			: this(UsdGeomPINVOKE.new_UsdGeomVisibilityAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomVisibilityAPI(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomVisibilityAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomVisibilityAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomVisibilityAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdGeomVisibilityAPI Get(UsdStage stage, SdfPath path)
		{
			UsdGeomVisibilityAPI result = new UsdGeomVisibilityAPI(UsdGeomPINVOKE.UsdGeomVisibilityAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdGeomPINVOKE.UsdGeomVisibilityAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdGeomPINVOKE.UsdGeomVisibilityAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomVisibilityAPI Apply(UsdPrim prim)
		{
			UsdGeomVisibilityAPI result = new UsdGeomVisibilityAPI(UsdGeomPINVOKE.UsdGeomVisibilityAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetGuideVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_GetGuideVisibilityAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateGuideVisibilityAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateGuideVisibilityAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateGuideVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetProxyVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_GetProxyVisibilityAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateProxyVisibilityAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateProxyVisibilityAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateProxyVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetRenderVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_GetRenderVisibilityAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateRenderVisibilityAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRenderVisibilityAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRenderVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetPurposeVisibilityAttr(TfToken purpose)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomVisibilityAPI_GetPurposeVisibilityAttr(swigCPtr, TfToken.getCPtr(purpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
