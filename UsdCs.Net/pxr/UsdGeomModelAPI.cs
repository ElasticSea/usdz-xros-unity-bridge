using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomModelAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdGeomModelAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomModelAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomModelAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomModelAPI obj)
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
						UsdGeomPINVOKE.delete_UsdGeomModelAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomModelAPI(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomModelAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomModelAPI()
			: this(UsdGeomPINVOKE.new_UsdGeomModelAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomModelAPI(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomModelAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomModelAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomModelAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdGeomModelAPI Get(UsdStage stage, SdfPath path)
		{
			UsdGeomModelAPI result = new UsdGeomModelAPI(UsdGeomPINVOKE.UsdGeomModelAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdGeomPINVOKE.UsdGeomModelAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdGeomPINVOKE.UsdGeomModelAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomModelAPI Apply(UsdPrim prim)
		{
			UsdGeomModelAPI result = new UsdGeomModelAPI(UsdGeomPINVOKE.UsdGeomModelAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetModelDrawModeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelDrawModeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelDrawModeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelDrawModeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelDrawModeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelApplyDrawModeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelApplyDrawModeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelApplyDrawModeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelApplyDrawModeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelApplyDrawModeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelDrawModeColorAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelDrawModeColorAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelDrawModeColorAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelDrawModeColorAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelDrawModeColorAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelCardGeometryAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelCardGeometryAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelCardGeometryAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardGeometryAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardGeometryAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelCardTextureXPosAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelCardTextureXPosAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelCardTextureXPosAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureXPosAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureXPosAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelCardTextureYPosAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelCardTextureYPosAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelCardTextureYPosAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureYPosAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureYPosAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelCardTextureZPosAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelCardTextureZPosAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelCardTextureZPosAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureZPosAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureZPosAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelCardTextureXNegAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelCardTextureXNegAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelCardTextureXNegAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureXNegAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureXNegAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelCardTextureYNegAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelCardTextureYNegAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelCardTextureYNegAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureYNegAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureYNegAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetModelCardTextureZNegAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetModelCardTextureZNegAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateModelCardTextureZNegAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureZNegAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateModelCardTextureZNegAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public bool GetExtentsHint(VtVec3fArray extents, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomModelAPI_GetExtentsHint__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(extents), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetExtentsHint(VtVec3fArray extents)
		{
			return UsdGeomPINVOKE.UsdGeomModelAPI_GetExtentsHint__SWIG_1(swigCPtr, VtVec3fArray.getCPtr(extents));
		}

		public bool SetExtentsHint(VtVec3fArray extents, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomModelAPI_SetExtentsHint__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(extents), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetExtentsHint(VtVec3fArray extents)
		{
			bool result = UsdGeomPINVOKE.UsdGeomModelAPI_SetExtentsHint__SWIG_1(swigCPtr, VtVec3fArray.getCPtr(extents));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetExtentsHintAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomModelAPI_GetExtentsHintAttr(swigCPtr), cMemoryOwn: true);
		}

		public VtVec3fArray ComputeExtentsHint(UsdGeomBBoxCache bboxCache)
		{
			VtVec3fArray result = new VtVec3fArray(UsdGeomPINVOKE.UsdGeomModelAPI_ComputeExtentsHint(swigCPtr, UsdGeomBBoxCache.getCPtr(bboxCache)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomConstraintTarget GetConstraintTarget(string constraintName)
		{
			UsdGeomConstraintTarget result = new UsdGeomConstraintTarget(UsdGeomPINVOKE.UsdGeomModelAPI_GetConstraintTarget(swigCPtr, constraintName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomConstraintTarget CreateConstraintTarget(string constraintName)
		{
			UsdGeomConstraintTarget result = new UsdGeomConstraintTarget(UsdGeomPINVOKE.UsdGeomModelAPI_CreateConstraintTarget(swigCPtr, constraintName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomConstraintTargetVector GetConstraintTargets()
		{
			return new UsdGeomConstraintTargetVector(UsdGeomPINVOKE.UsdGeomModelAPI_GetConstraintTargets(swigCPtr), cMemoryOwn: true);
		}

		public TfToken ComputeModelDrawMode(TfToken parentDrawMode)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomModelAPI_ComputeModelDrawMode__SWIG_0(swigCPtr, TfToken.getCPtr(parentDrawMode)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken ComputeModelDrawMode()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomModelAPI_ComputeModelDrawMode__SWIG_1(swigCPtr), cMemoryOwn: true);
		}
	}
}
