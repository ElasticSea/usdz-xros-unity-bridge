using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomSubset : UsdTyped
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomSubset(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomSubset_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomSubset obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomSubset obj)
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
						UsdGeomPINVOKE.delete_UsdGeomSubset(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomSubset(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomSubset__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomSubset()
			: this(UsdGeomPINVOKE.new_UsdGeomSubset__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomSubset(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomSubset__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomSubset_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomSubset_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomSubset Get(UsdStage stage, SdfPath path)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubset_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubset Define(UsdStage stage, SdfPath path)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubset_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetElementTypeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_GetElementTypeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateElementTypeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateElementTypeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateElementTypeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateElementTypeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateElementTypeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateElementTypeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_GetIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIndicesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIndicesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateIndicesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFamilyNameAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_GetFamilyNameAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFamilyNameAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateFamilyNameAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFamilyNameAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateFamilyNameAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFamilyNameAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomSubset_CreateFamilyNameAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public static UsdGeomSubset CreateGeomSubset(UsdGeomImageable geom, TfToken subsetName, TfToken elementType, VtIntArray indices, TfToken familyName, TfToken familyType)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubset_CreateGeomSubset__SWIG_0(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(subsetName), TfToken.getCPtr(elementType), VtIntArray.getCPtr(indices), TfToken.getCPtr(familyName), TfToken.getCPtr(familyType)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubset CreateGeomSubset(UsdGeomImageable geom, TfToken subsetName, TfToken elementType, VtIntArray indices, TfToken familyName)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubset_CreateGeomSubset__SWIG_1(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(subsetName), TfToken.getCPtr(elementType), VtIntArray.getCPtr(indices), TfToken.getCPtr(familyName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubset CreateGeomSubset(UsdGeomImageable geom, TfToken subsetName, TfToken elementType, VtIntArray indices)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubset_CreateGeomSubset__SWIG_2(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(subsetName), TfToken.getCPtr(elementType), VtIntArray.getCPtr(indices)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubset CreateUniqueGeomSubset(UsdGeomImageable geom, TfToken subsetName, TfToken elementType, VtIntArray indices, TfToken familyName, TfToken familyType)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubset_CreateUniqueGeomSubset__SWIG_0(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(subsetName), TfToken.getCPtr(elementType), VtIntArray.getCPtr(indices), TfToken.getCPtr(familyName), TfToken.getCPtr(familyType)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubset CreateUniqueGeomSubset(UsdGeomImageable geom, TfToken subsetName, TfToken elementType, VtIntArray indices, TfToken familyName)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubset_CreateUniqueGeomSubset__SWIG_1(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(subsetName), TfToken.getCPtr(elementType), VtIntArray.getCPtr(indices), TfToken.getCPtr(familyName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubset CreateUniqueGeomSubset(UsdGeomImageable geom, TfToken subsetName, TfToken elementType, VtIntArray indices)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubset_CreateUniqueGeomSubset__SWIG_2(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(subsetName), TfToken.getCPtr(elementType), VtIntArray.getCPtr(indices)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubsetVector GetAllGeomSubsets(UsdGeomImageable geom)
		{
			UsdGeomSubsetVector result = new UsdGeomSubsetVector(UsdGeomPINVOKE.UsdGeomSubset_GetAllGeomSubsets(UsdGeomImageable.getCPtr(geom)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubsetVector GetGeomSubsets(UsdGeomImageable geom, TfToken elementType, TfToken familyName)
		{
			UsdGeomSubsetVector result = new UsdGeomSubsetVector(UsdGeomPINVOKE.UsdGeomSubset_GetGeomSubsets__SWIG_0(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(elementType), TfToken.getCPtr(familyName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubsetVector GetGeomSubsets(UsdGeomImageable geom, TfToken elementType)
		{
			UsdGeomSubsetVector result = new UsdGeomSubsetVector(UsdGeomPINVOKE.UsdGeomSubset_GetGeomSubsets__SWIG_1(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(elementType)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomSubsetVector GetGeomSubsets(UsdGeomImageable geom)
		{
			UsdGeomSubsetVector result = new UsdGeomSubsetVector(UsdGeomPINVOKE.UsdGeomSubset_GetGeomSubsets__SWIG_2(UsdGeomImageable.getCPtr(geom)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_std__setT_TfToken_TfTokenFastArbitraryLessThan_t GetAllGeomSubsetFamilyNames(UsdGeomImageable geom)
		{
			SWIGTYPE_p_std__setT_TfToken_TfTokenFastArbitraryLessThan_t result = new SWIGTYPE_p_std__setT_TfToken_TfTokenFastArbitraryLessThan_t(UsdGeomPINVOKE.UsdGeomSubset_GetAllGeomSubsetFamilyNames(UsdGeomImageable.getCPtr(geom)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SetFamilyType(UsdGeomImageable geom, TfToken familyName, TfToken familyType)
		{
			bool result = UsdGeomPINVOKE.UsdGeomSubset_SetFamilyType(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(familyName), TfToken.getCPtr(familyType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken GetFamilyType(UsdGeomImageable geom, TfToken familyName)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomSubset_GetFamilyType(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(familyName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static VtIntArray GetUnassignedIndices(UsdGeomSubsetVector subsets, uint elementCount, UsdTimeCode time)
		{
			VtIntArray result = new VtIntArray(UsdGeomPINVOKE.UsdGeomSubset_GetUnassignedIndices__SWIG_0(UsdGeomSubsetVector.getCPtr(subsets), elementCount, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static VtIntArray GetUnassignedIndices(UsdGeomSubsetVector subsets, uint elementCount)
		{
			VtIntArray result = new VtIntArray(UsdGeomPINVOKE.UsdGeomSubset_GetUnassignedIndices__SWIG_1(UsdGeomSubsetVector.getCPtr(subsets), elementCount), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ValidateSubsets(UsdGeomSubsetVector subsets, uint elementCount, TfToken familyType, out string reason)
		{
			bool result = UsdGeomPINVOKE.UsdGeomSubset_ValidateSubsets(UsdGeomSubsetVector.getCPtr(subsets), elementCount, TfToken.getCPtr(familyType), out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ValidateFamily(UsdGeomImageable geom, TfToken elementType, TfToken familyName, out string reason)
		{
			bool result = UsdGeomPINVOKE.UsdGeomSubset_ValidateFamily(UsdGeomImageable.getCPtr(geom), TfToken.getCPtr(elementType), TfToken.getCPtr(familyName), out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
