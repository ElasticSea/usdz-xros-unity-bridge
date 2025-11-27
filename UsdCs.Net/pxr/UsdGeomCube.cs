using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomCube : UsdGeomGprim
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomCube(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomCube_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomCube obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomCube obj)
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
						UsdGeomPINVOKE.delete_UsdGeomCube(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomCube(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomCube__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomCube()
			: this(UsdGeomPINVOKE.new_UsdGeomCube__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomCube(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomCube__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomCube_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomCube_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomCube Get(UsdStage stage, SdfPath path)
		{
			UsdGeomCube result = new UsdGeomCube(UsdGeomPINVOKE.UsdGeomCube_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomCube Define(UsdStage stage, SdfPath path)
		{
			UsdGeomCube result = new UsdGeomCube(UsdGeomPINVOKE.UsdGeomCube_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetSizeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCube_GetSizeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateSizeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCube_CreateSizeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSizeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCube_CreateSizeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSizeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCube_CreateSizeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute GetExtentAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCube_GetExtentAttr(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute CreateExtentAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCube_CreateExtentAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateExtentAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCube_CreateExtentAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateExtentAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCube_CreateExtentAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public static bool ComputeExtent(double size, VtVec3fArray extent)
		{
			return UsdGeomPINVOKE.UsdGeomCube_ComputeExtent__SWIG_0(size, VtVec3fArray.getCPtr(extent));
		}

		public static bool ComputeExtent(double size, GfMatrix4d transform, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomCube_ComputeExtent__SWIG_1(size, GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
