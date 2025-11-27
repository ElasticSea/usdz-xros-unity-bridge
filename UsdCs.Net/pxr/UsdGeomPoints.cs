using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomPoints : UsdGeomPointBased
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomPoints(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomPoints_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomPoints obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomPoints obj)
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
						UsdGeomPINVOKE.delete_UsdGeomPoints(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomPoints(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomPoints__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPoints()
			: this(UsdGeomPINVOKE.new_UsdGeomPoints__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomPoints(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomPoints__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPoints_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPoints_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomPoints Get(UsdStage stage, SdfPath path)
		{
			UsdGeomPoints result = new UsdGeomPoints(UsdGeomPINVOKE.UsdGeomPoints_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomPoints Define(UsdStage stage, SdfPath path)
		{
			UsdGeomPoints result = new UsdGeomPoints(UsdGeomPINVOKE.UsdGeomPoints_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetWidthsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPoints_GetWidthsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateWidthsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPoints_CreateWidthsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateWidthsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPoints_CreateWidthsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateWidthsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPoints_CreateWidthsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetIdsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPoints_GetIdsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIdsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPoints_CreateIdsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIdsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPoints_CreateIdsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIdsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPoints_CreateIdsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetWidthsInterpolation()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomPoints_GetWidthsInterpolation(swigCPtr), cMemoryOwn: true);
		}

		public bool SetWidthsInterpolation(TfToken interpolation)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPoints_SetWidthsInterpolation(swigCPtr, TfToken.getCPtr(interpolation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtent(VtVec3fArray points, VtFloatArray widths, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPoints_ComputeExtent__SWIG_0(VtVec3fArray.getCPtr(points), VtFloatArray.getCPtr(widths), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtent(VtVec3fArray points, VtFloatArray widths, GfMatrix4d transform, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPoints_ComputeExtent__SWIG_1(VtVec3fArray.getCPtr(points), VtFloatArray.getCPtr(widths), GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetPointCount(UsdTimeCode timeCode)
		{
			uint result = UsdGeomPINVOKE.UsdGeomPoints_GetPointCount__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(timeCode));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetPointCount()
		{
			return UsdGeomPINVOKE.UsdGeomPoints_GetPointCount__SWIG_1(swigCPtr);
		}
	}
}
