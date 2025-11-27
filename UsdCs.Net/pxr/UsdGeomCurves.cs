using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomCurves : UsdGeomPointBased
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdGeomCurves(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomCurves_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomCurves obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomCurves obj)
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
						UsdGeomPINVOKE.delete_UsdGeomCurves(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomCurves(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomCurves__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomCurves()
			: this(UsdGeomPINVOKE.new_UsdGeomCurves__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomCurves(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomCurves__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomCurves_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomCurves_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomCurves Get(UsdStage stage, SdfPath path)
		{
			UsdGeomCurves result = new UsdGeomCurves(UsdGeomPINVOKE.UsdGeomCurves_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetCurveVertexCountsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCurves_GetCurveVertexCountsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateCurveVertexCountsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCurveVertexCountsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCurveVertexCountsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetWidthsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCurves_GetWidthsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateWidthsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCurves_CreateWidthsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateWidthsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomCurves_CreateWidthsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateWidthsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomCurves_CreateWidthsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetWidthsInterpolation()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomCurves_GetWidthsInterpolation(swigCPtr), cMemoryOwn: true);
		}

		public bool SetWidthsInterpolation(TfToken interpolation)
		{
			bool result = UsdGeomPINVOKE.UsdGeomCurves_SetWidthsInterpolation(swigCPtr, TfToken.getCPtr(interpolation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtent(VtVec3fArray points, VtFloatArray widths, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomCurves_ComputeExtent__SWIG_0(VtVec3fArray.getCPtr(points), VtFloatArray.getCPtr(widths), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtent(VtVec3fArray points, VtFloatArray widths, GfMatrix4d transform, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomCurves_ComputeExtent__SWIG_1(VtVec3fArray.getCPtr(points), VtFloatArray.getCPtr(widths), GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetCurveCount(UsdTimeCode timeCode)
		{
			uint result = UsdGeomPINVOKE.UsdGeomCurves_GetCurveCount__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(timeCode));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetCurveCount()
		{
			return UsdGeomPINVOKE.UsdGeomCurves_GetCurveCount__SWIG_1(swigCPtr);
		}
	}
}
