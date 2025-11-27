using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomPlane : UsdGeomGprim
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomPlane(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomPlane_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomPlane obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomPlane obj)
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
						UsdGeomPINVOKE.delete_UsdGeomPlane(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomPlane(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomPlane__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPlane()
			: this(UsdGeomPINVOKE.new_UsdGeomPlane__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomPlane(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomPlane__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPlane_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPlane_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomPlane Get(UsdStage stage, SdfPath path)
		{
			UsdGeomPlane result = new UsdGeomPlane(UsdGeomPINVOKE.UsdGeomPlane_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomPlane Define(UsdStage stage, SdfPath path)
		{
			UsdGeomPlane result = new UsdGeomPlane(UsdGeomPINVOKE.UsdGeomPlane_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute GetDoubleSidedAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_GetDoubleSidedAttr(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute CreateDoubleSidedAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateDoubleSidedAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateDoubleSidedAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateDoubleSidedAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateDoubleSidedAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateDoubleSidedAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetWidthAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_GetWidthAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateWidthAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateWidthAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateWidthAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateWidthAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateWidthAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateWidthAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetLengthAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_GetLengthAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateLengthAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateLengthAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateLengthAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateLengthAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateLengthAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateLengthAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetAxisAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_GetAxisAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateAxisAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateAxisAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAxisAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateAxisAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAxisAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateAxisAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute GetExtentAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_GetExtentAttr(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute CreateExtentAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateExtentAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateExtentAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateExtentAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateExtentAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPlane_CreateExtentAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public static bool ComputeExtent(double width, double length, TfToken axis, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPlane_ComputeExtent__SWIG_0(width, length, TfToken.getCPtr(axis), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtent(double width, double length, TfToken axis, GfMatrix4d transform, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPlane_ComputeExtent__SWIG_1(width, length, TfToken.getCPtr(axis), GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
