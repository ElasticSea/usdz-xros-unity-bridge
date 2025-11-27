using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomCone : UsdGeomGprim
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomCone(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomCone_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomCone obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomCone obj)
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
						UsdGeomPINVOKE.delete_UsdGeomCone(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomCone(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomCone__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomCone()
			: this(UsdGeomPINVOKE.new_UsdGeomCone__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomCone(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomCone__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomCone_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomCone_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomCone Get(UsdStage stage, SdfPath path)
		{
			UsdGeomCone result = new UsdGeomCone(UsdGeomPINVOKE.UsdGeomCone_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomCone Define(UsdStage stage, SdfPath path)
		{
			UsdGeomCone result = new UsdGeomCone(UsdGeomPINVOKE.UsdGeomCone_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetHeightAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_GetHeightAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateHeightAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateHeightAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateHeightAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateHeightAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateHeightAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateHeightAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetRadiusAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_GetRadiusAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateRadiusAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateRadiusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRadiusAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateRadiusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRadiusAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateRadiusAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetAxisAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_GetAxisAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateAxisAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateAxisAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAxisAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateAxisAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAxisAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateAxisAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute GetExtentAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_GetExtentAttr(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute CreateExtentAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateExtentAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateExtentAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateExtentAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateExtentAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCone_CreateExtentAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public static bool ComputeExtent(double height, double radius, TfToken axis, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomCone_ComputeExtent__SWIG_0(height, radius, TfToken.getCPtr(axis), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtent(double height, double radius, TfToken axis, GfMatrix4d transform, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomCone_ComputeExtent__SWIG_1(height, radius, TfToken.getCPtr(axis), GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
