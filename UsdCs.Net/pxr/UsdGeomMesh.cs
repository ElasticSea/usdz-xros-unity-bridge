using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomMesh : UsdGeomPointBased
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public static float SHARPNESS_INFINITE => UsdGeomPINVOKE.UsdGeomMesh_SHARPNESS_INFINITE_get();

		public UsdGeomMesh(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomMesh_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomMesh obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomMesh obj)
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
						UsdGeomPINVOKE.delete_UsdGeomMesh(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomMesh(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomMesh__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomMesh()
			: this(UsdGeomPINVOKE.new_UsdGeomMesh__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomMesh(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomMesh__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomMesh_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomMesh_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomMesh Get(UsdStage stage, SdfPath path)
		{
			UsdGeomMesh result = new UsdGeomMesh(UsdGeomPINVOKE.UsdGeomMesh_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomMesh Define(UsdStage stage, SdfPath path)
		{
			UsdGeomMesh result = new UsdGeomMesh(UsdGeomPINVOKE.UsdGeomMesh_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetFaceVertexIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetFaceVertexIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFaceVertexIndicesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFaceVertexIndicesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFaceVertexIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFaceVertexCountsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetFaceVertexCountsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFaceVertexCountsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFaceVertexCountsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFaceVertexCountsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetSubdivisionSchemeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetSubdivisionSchemeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateSubdivisionSchemeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSubdivisionSchemeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSubdivisionSchemeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetInterpolateBoundaryAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetInterpolateBoundaryAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateInterpolateBoundaryAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateInterpolateBoundaryAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateInterpolateBoundaryAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFaceVaryingLinearInterpolationAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetFaceVaryingLinearInterpolationAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFaceVaryingLinearInterpolationAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFaceVaryingLinearInterpolationAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFaceVaryingLinearInterpolationAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTriangleSubdivisionRuleAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetTriangleSubdivisionRuleAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTriangleSubdivisionRuleAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTriangleSubdivisionRuleAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTriangleSubdivisionRuleAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetHoleIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetHoleIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateHoleIndicesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateHoleIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateHoleIndicesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateHoleIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateHoleIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateHoleIndicesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetCornerIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetCornerIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateCornerIndicesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCornerIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCornerIndicesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCornerIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCornerIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCornerIndicesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetCornerSharpnessesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetCornerSharpnessesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateCornerSharpnessesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCornerSharpnessesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCornerSharpnessesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetCreaseIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetCreaseIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateCreaseIndicesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCreaseIndicesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCreaseIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetCreaseLengthsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetCreaseLengthsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateCreaseLengthsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCreaseLengthsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCreaseLengthsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetCreaseSharpnessesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_GetCreaseSharpnessesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateCreaseSharpnessesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCreaseSharpnessesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateCreaseSharpnessesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public static bool ValidateTopology(VtIntArray faceVertexIndices, VtIntArray faceVertexCounts, uint numPoints, out string reason)
		{
			bool result = UsdGeomPINVOKE.UsdGeomMesh_ValidateTopology__SWIG_0(VtIntArray.getCPtr(faceVertexIndices), VtIntArray.getCPtr(faceVertexCounts), numPoints, out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ValidateTopology(VtIntArray faceVertexIndices, VtIntArray faceVertexCounts, uint numPoints)
		{
			bool result = UsdGeomPINVOKE.UsdGeomMesh_ValidateTopology__SWIG_1(VtIntArray.getCPtr(faceVertexIndices), VtIntArray.getCPtr(faceVertexCounts), numPoints);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsSharpnessInfinite(float sharpness)
		{
			return UsdGeomPINVOKE.UsdGeomMesh_IsSharpnessInfinite(sharpness);
		}

		public uint GetFaceCount(UsdTimeCode timeCode)
		{
			uint result = UsdGeomPINVOKE.UsdGeomMesh_GetFaceCount__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(timeCode));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetFaceCount()
		{
			return UsdGeomPINVOKE.UsdGeomMesh_GetFaceCount__SWIG_1(swigCPtr);
		}

		public static void Triangulate(VtIntArray faceVertexIndices, VtIntArray faceVertexCounts)
		{
			UsdGeomPINVOKE.UsdGeomMesh_Triangulate(VtIntArray.getCPtr(faceVertexIndices), VtIntArray.getCPtr(faceVertexCounts));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
