using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomBoundable : UsdGeomXformable
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdGeomBoundable(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomBoundable_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomBoundable obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomBoundable obj)
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
						UsdGeomPINVOKE.delete_UsdGeomBoundable(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomBoundable(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomBoundable__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomBoundable()
			: this(UsdGeomPINVOKE.new_UsdGeomBoundable__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomBoundable(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomBoundable__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomBoundable_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomBoundable_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomBoundable Get(UsdStage stage, SdfPath path)
		{
			UsdGeomBoundable result = new UsdGeomBoundable(UsdGeomPINVOKE.UsdGeomBoundable_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetExtentAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomBoundable_GetExtentAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateExtentAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomBoundable_CreateExtentAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExtentAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomBoundable_CreateExtentAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExtentAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomBoundable_CreateExtentAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public bool ComputeExtent(UsdTimeCode time, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomBoundable_ComputeExtent(swigCPtr, UsdTimeCode.getCPtr(time), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtentFromPlugins(UsdGeomBoundable boundable, UsdTimeCode time, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomBoundable_ComputeExtentFromPlugins__SWIG_0(getCPtr(boundable), UsdTimeCode.getCPtr(time), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtentFromPlugins(UsdGeomBoundable boundable, UsdTimeCode time, GfMatrix4d transform, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomBoundable_ComputeExtentFromPlugins__SWIG_1(getCPtr(boundable), UsdTimeCode.getCPtr(time), GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
