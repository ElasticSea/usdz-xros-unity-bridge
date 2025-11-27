using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomBasisCurves : UsdGeomCurves
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomBasisCurves(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomBasisCurves_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomBasisCurves obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomBasisCurves obj)
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
						UsdGeomPINVOKE.delete_UsdGeomBasisCurves(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomBasisCurves(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurves__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomBasisCurves()
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurves__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomBasisCurves(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurves__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomBasisCurves_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomBasisCurves_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomBasisCurves Get(UsdStage stage, SdfPath path)
		{
			UsdGeomBasisCurves result = new UsdGeomBasisCurves(UsdGeomPINVOKE.UsdGeomBasisCurves_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomBasisCurves Define(UsdStage stage, SdfPath path)
		{
			UsdGeomBasisCurves result = new UsdGeomBasisCurves(UsdGeomPINVOKE.UsdGeomBasisCurves_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetTypeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_GetTypeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTypeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateTypeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTypeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateTypeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTypeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateTypeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetBasisAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_GetBasisAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateBasisAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateBasisAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBasisAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateBasisAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBasisAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateBasisAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetWrapAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_GetWrapAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateWrapAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateWrapAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateWrapAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateWrapAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateWrapAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomBasisCurves_CreateWrapAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public TfToken ComputeInterpolationForSize(uint n, UsdTimeCode timeCode, UsdGeomBasisCurvesComputeInterpolationInfo info)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomBasisCurves_ComputeInterpolationForSize__SWIG_0(swigCPtr, n, UsdTimeCode.getCPtr(timeCode), UsdGeomBasisCurvesComputeInterpolationInfo.getCPtr(info)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken ComputeInterpolationForSize(uint n, UsdTimeCode timeCode)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomBasisCurves_ComputeInterpolationForSize__SWIG_1(swigCPtr, n, UsdTimeCode.getCPtr(timeCode)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint ComputeUniformDataSize(UsdTimeCode timeCode)
		{
			uint result = UsdGeomPINVOKE.UsdGeomBasisCurves_ComputeUniformDataSize(swigCPtr, UsdTimeCode.getCPtr(timeCode));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint ComputeVaryingDataSize(UsdTimeCode timeCode)
		{
			uint result = UsdGeomPINVOKE.UsdGeomBasisCurves_ComputeVaryingDataSize(swigCPtr, UsdTimeCode.getCPtr(timeCode));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint ComputeVertexDataSize(UsdTimeCode timeCode)
		{
			uint result = UsdGeomPINVOKE.UsdGeomBasisCurves_ComputeVertexDataSize(swigCPtr, UsdTimeCode.getCPtr(timeCode));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
