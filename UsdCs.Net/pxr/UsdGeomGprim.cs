using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomGprim : UsdGeomBoundable
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdGeomGprim(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomGprim_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomGprim obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomGprim obj)
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
						UsdGeomPINVOKE.delete_UsdGeomGprim(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomGprim(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomGprim__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomGprim()
			: this(UsdGeomPINVOKE.new_UsdGeomGprim__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomGprim(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomGprim__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomGprim_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomGprim_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomGprim Get(UsdStage stage, SdfPath path)
		{
			UsdGeomGprim result = new UsdGeomGprim(UsdGeomPINVOKE.UsdGeomGprim_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetDisplayColorAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_GetDisplayColorAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateDisplayColorAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayColorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDisplayColorAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayColorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDisplayColorAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayColorAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetDisplayOpacityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_GetDisplayOpacityAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateDisplayOpacityAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDisplayOpacityAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDisplayOpacityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetDoubleSidedAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_GetDoubleSidedAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateDoubleSidedAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDoubleSidedAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDoubleSidedAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDoubleSidedAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDoubleSidedAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateDoubleSidedAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetOrientationAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_GetOrientationAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateOrientationAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateOrientationAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateOrientationAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateOrientationAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateOrientationAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomGprim_CreateOrientationAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvar GetDisplayColorPrimvar()
		{
			return new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomGprim_GetDisplayColorPrimvar(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvar CreateDisplayColorPrimvar(TfToken interpolation, int elementSize)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_0(swigCPtr, TfToken.getCPtr(interpolation), elementSize), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar CreateDisplayColorPrimvar(TfToken interpolation)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_1(swigCPtr, TfToken.getCPtr(interpolation)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar CreateDisplayColorPrimvar()
		{
			return new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvar GetDisplayOpacityPrimvar()
		{
			return new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomGprim_GetDisplayOpacityPrimvar(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvar CreateDisplayOpacityPrimvar(TfToken interpolation, int elementSize)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_0(swigCPtr, TfToken.getCPtr(interpolation), elementSize), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar CreateDisplayOpacityPrimvar(TfToken interpolation)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_1(swigCPtr, TfToken.getCPtr(interpolation)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar CreateDisplayOpacityPrimvar()
		{
			return new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
