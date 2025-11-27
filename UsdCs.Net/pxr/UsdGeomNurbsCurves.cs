using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomNurbsCurves : UsdGeomCurves
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomNurbsCurves(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomNurbsCurves_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomNurbsCurves obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomNurbsCurves obj)
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
						UsdGeomPINVOKE.delete_UsdGeomNurbsCurves(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomNurbsCurves(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomNurbsCurves__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomNurbsCurves()
			: this(UsdGeomPINVOKE.new_UsdGeomNurbsCurves__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomNurbsCurves(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomNurbsCurves__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomNurbsCurves_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomNurbsCurves_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomNurbsCurves Get(UsdStage stage, SdfPath path)
		{
			UsdGeomNurbsCurves result = new UsdGeomNurbsCurves(UsdGeomPINVOKE.UsdGeomNurbsCurves_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomNurbsCurves Define(UsdStage stage, SdfPath path)
		{
			UsdGeomNurbsCurves result = new UsdGeomNurbsCurves(UsdGeomPINVOKE.UsdGeomNurbsCurves_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetOrderAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_GetOrderAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateOrderAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateOrderAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateOrderAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateOrderAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateOrderAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateOrderAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetKnotsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_GetKnotsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateKnotsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateKnotsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateKnotsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetRangesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_GetRangesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateRangesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateRangesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRangesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateRangesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRangesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsCurves_CreateRangesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
