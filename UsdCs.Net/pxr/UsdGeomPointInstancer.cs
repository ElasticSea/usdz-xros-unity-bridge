using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomPointInstancer : UsdGeomBoundable
	{
		public enum ProtoXformInclusion
		{
			IncludeProtoXform,
			ExcludeProtoXform
		}

		public enum MaskApplication
		{
			ApplyMask,
			IgnoreMask
		}

		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomPointInstancer(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomPointInstancer_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomPointInstancer obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomPointInstancer obj)
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
						UsdGeomPINVOKE.delete_UsdGeomPointInstancer(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomPointInstancer(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomPointInstancer__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPointInstancer()
			: this(UsdGeomPINVOKE.new_UsdGeomPointInstancer__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomPointInstancer(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomPointInstancer__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPointInstancer_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPointInstancer_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomPointInstancer Get(UsdStage stage, SdfPath path)
		{
			UsdGeomPointInstancer result = new UsdGeomPointInstancer(UsdGeomPINVOKE.UsdGeomPointInstancer_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomPointInstancer Define(UsdStage stage, SdfPath path)
		{
			UsdGeomPointInstancer result = new UsdGeomPointInstancer(UsdGeomPINVOKE.UsdGeomPointInstancer_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetProtoIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetProtoIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateProtoIndicesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateProtoIndicesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateProtoIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetIdsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetIdsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIdsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateIdsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIdsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateIdsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIdsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateIdsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetPositionsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetPositionsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreatePositionsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreatePositionsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePositionsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreatePositionsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePositionsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreatePositionsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetOrientationsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetOrientationsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateOrientationsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateOrientationsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateOrientationsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetScalesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetScalesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateScalesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateScalesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateScalesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateScalesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateScalesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateScalesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVelocitiesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetVelocitiesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVelocitiesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVelocitiesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVelocitiesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetAccelerationsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetAccelerationsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateAccelerationsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAccelerationsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAccelerationsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetAngularVelocitiesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetAngularVelocitiesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateAngularVelocitiesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAngularVelocitiesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAngularVelocitiesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetInvisibleIdsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_GetInvisibleIdsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateInvisibleIdsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateInvisibleIdsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateInvisibleIdsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetPrototypesRel()
		{
			return new UsdRelationship(UsdGeomPINVOKE.UsdGeomPointInstancer_GetPrototypesRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreatePrototypesRel()
		{
			return new UsdRelationship(UsdGeomPINVOKE.UsdGeomPointInstancer_CreatePrototypesRel(swigCPtr), cMemoryOwn: true);
		}

		public bool ActivateId(long id)
		{
			return UsdGeomPINVOKE.UsdGeomPointInstancer_ActivateId(swigCPtr, id);
		}

		public bool ActivateIds(VtInt64Array ids)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ActivateIds(swigCPtr, VtInt64Array.getCPtr(ids));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ActivateAllIds()
		{
			return UsdGeomPINVOKE.UsdGeomPointInstancer_ActivateAllIds(swigCPtr);
		}

		public bool DeactivateId(long id)
		{
			return UsdGeomPINVOKE.UsdGeomPointInstancer_DeactivateId(swigCPtr, id);
		}

		public bool DeactivateIds(VtInt64Array ids)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_DeactivateIds(swigCPtr, VtInt64Array.getCPtr(ids));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool VisId(long id, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_VisId(swigCPtr, id, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool VisIds(VtInt64Array ids, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_VisIds(swigCPtr, VtInt64Array.getCPtr(ids), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool VisAllIds(UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_VisAllIds(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool InvisId(long id, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_InvisId(swigCPtr, id, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool InvisIds(VtInt64Array ids, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_InvisIds(swigCPtr, VtInt64Array.getCPtr(ids), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdBoolVector ComputeMaskAtTime(UsdTimeCode time, VtInt64Array ids)
		{
			StdBoolVector result = new StdBoolVector(UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeMaskAtTime__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), VtInt64Array.getCPtr(ids)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdBoolVector ComputeMaskAtTime(UsdTimeCode time)
		{
			StdBoolVector result = new StdBoolVector(UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeMaskAtTime__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdTimeCode time, UsdTimeCode baseTime, ProtoXformInclusion doProtoXforms, MaskApplication applyMask)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime), (int)doProtoXforms, (int)applyMask);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdTimeCode time, UsdTimeCode baseTime, ProtoXformInclusion doProtoXforms)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime), (int)doProtoXforms);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdTimeCode time, UsdTimeCode baseTime)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_2(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeInstanceTransformsAtTimes(VtMatrix4dArrayVector xformsArray, UsdTimeCodeVector times, UsdTimeCode baseTime, ProtoXformInclusion doProtoXforms, MaskApplication applyMask)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_0(swigCPtr, VtMatrix4dArrayVector.getCPtr(xformsArray), UsdTimeCodeVector.getCPtr(times), UsdTimeCode.getCPtr(baseTime), (int)doProtoXforms, (int)applyMask);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeInstanceTransformsAtTimes(VtMatrix4dArrayVector xformsArray, UsdTimeCodeVector times, UsdTimeCode baseTime, ProtoXformInclusion doProtoXforms)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_1(swigCPtr, VtMatrix4dArrayVector.getCPtr(xformsArray), UsdTimeCodeVector.getCPtr(times), UsdTimeCode.getCPtr(baseTime), (int)doProtoXforms);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeInstanceTransformsAtTimes(VtMatrix4dArrayVector xformsArray, UsdTimeCodeVector times, UsdTimeCode baseTime)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_2(swigCPtr, VtMatrix4dArrayVector.getCPtr(xformsArray), UsdTimeCodeVector.getCPtr(times), UsdTimeCode.getCPtr(baseTime));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdStage stage, UsdTimeCode time, VtIntArray protoIndices, VtVec3fArray positions, VtVec3fArray velocities, UsdTimeCode velocitiesSampleTime, VtVec3fArray accelerations, VtVec3fArray scales, VtQuathArray orientations, VtVec3fArray angularVelocities, UsdTimeCode angularVelocitiesSampleTime, SdfPathVector protoPaths, StdBoolVector mask, float velocityScale)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_3(VtMatrix4dArray.getCPtr(xforms), UsdStage.getCPtr(stage), UsdTimeCode.getCPtr(time), VtIntArray.getCPtr(protoIndices), VtVec3fArray.getCPtr(positions), VtVec3fArray.getCPtr(velocities), UsdTimeCode.getCPtr(velocitiesSampleTime), VtVec3fArray.getCPtr(accelerations), VtVec3fArray.getCPtr(scales), VtQuathArray.getCPtr(orientations), VtVec3fArray.getCPtr(angularVelocities), UsdTimeCode.getCPtr(angularVelocitiesSampleTime), SdfPathVector.getCPtr(protoPaths), StdBoolVector.getCPtr(mask), velocityScale);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdStage stage, UsdTimeCode time, VtIntArray protoIndices, VtVec3fArray positions, VtVec3fArray velocities, UsdTimeCode velocitiesSampleTime, VtVec3fArray accelerations, VtVec3fArray scales, VtQuathArray orientations, VtVec3fArray angularVelocities, UsdTimeCode angularVelocitiesSampleTime, SdfPathVector protoPaths, StdBoolVector mask)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_4(VtMatrix4dArray.getCPtr(xforms), UsdStage.getCPtr(stage), UsdTimeCode.getCPtr(time), VtIntArray.getCPtr(protoIndices), VtVec3fArray.getCPtr(positions), VtVec3fArray.getCPtr(velocities), UsdTimeCode.getCPtr(velocitiesSampleTime), VtVec3fArray.getCPtr(accelerations), VtVec3fArray.getCPtr(scales), VtQuathArray.getCPtr(orientations), VtVec3fArray.getCPtr(angularVelocities), UsdTimeCode.getCPtr(angularVelocitiesSampleTime), SdfPathVector.getCPtr(protoPaths), StdBoolVector.getCPtr(mask));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeExtentAtTime(VtVec3fArray extent, UsdTimeCode time, UsdTimeCode baseTime)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeExtentAtTime__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(extent), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeExtentAtTime(VtVec3fArray extent, UsdTimeCode time, UsdTimeCode baseTime, GfMatrix4d transform)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeExtentAtTime__SWIG_1(swigCPtr, VtVec3fArray.getCPtr(extent), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime), GfMatrix4d.getCPtr(transform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeExtentAtTimes(VtVec3fArrayVector extents, UsdTimeCodeVector times, UsdTimeCode baseTime)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeExtentAtTimes__SWIG_0(swigCPtr, VtVec3fArrayVector.getCPtr(extents), UsdTimeCodeVector.getCPtr(times), UsdTimeCode.getCPtr(baseTime));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeExtentAtTimes(VtVec3fArrayVector extents, UsdTimeCodeVector times, UsdTimeCode baseTime, GfMatrix4d transform)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancer_ComputeExtentAtTimes__SWIG_1(swigCPtr, VtVec3fArrayVector.getCPtr(extents), UsdTimeCodeVector.getCPtr(times), UsdTimeCode.getCPtr(baseTime), GfMatrix4d.getCPtr(transform));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetInstanceCount(UsdTimeCode timeCode)
		{
			uint result = UsdGeomPINVOKE.UsdGeomPointInstancer_GetInstanceCount__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(timeCode));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetInstanceCount()
		{
			return UsdGeomPINVOKE.UsdGeomPointInstancer_GetInstanceCount__SWIG_1(swigCPtr);
		}
	}
}
