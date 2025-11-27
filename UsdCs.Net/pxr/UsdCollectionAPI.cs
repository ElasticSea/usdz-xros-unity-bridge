using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdCollectionAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.MultipleApplyAPI;

		public UsdCollectionAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdCollectionAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdCollectionAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdCollectionAPI obj)
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
						UsdPINVOKE.delete_UsdCollectionAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdCollectionAPI(UsdPrim prim, TfToken name)
			: this(UsdPINVOKE.new_UsdCollectionAPI__SWIG_0(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdCollectionAPI(UsdPrim prim)
			: this(UsdPINVOKE.new_UsdCollectionAPI__SWIG_1(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdCollectionAPI()
			: this(UsdPINVOKE.new_UsdCollectionAPI__SWIG_2(), cMemoryOwn: true)
		{
		}

		public UsdCollectionAPI(UsdSchemaBase schemaObj, TfToken name)
			: this(UsdPINVOKE.new_UsdCollectionAPI__SWIG_3(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(name)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdPINVOKE.UsdCollectionAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdCollectionAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static TfTokenVector GetSchemaAttributeNames(bool includeInherited, TfToken instanceName)
		{
			TfTokenVector result = new TfTokenVector(UsdPINVOKE.UsdCollectionAPI_GetSchemaAttributeNames__SWIG_2(includeInherited, TfToken.getCPtr(instanceName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetName()
		{
			return new TfToken(UsdPINVOKE.UsdCollectionAPI_GetName(swigCPtr), cMemoryOwn: true);
		}

		public static UsdCollectionAPI Get(UsdStage stage, SdfPath path)
		{
			UsdCollectionAPI result = new UsdCollectionAPI(UsdPINVOKE.UsdCollectionAPI_Get__SWIG_0(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPI Get(UsdPrim prim, TfToken name)
		{
			UsdCollectionAPI result = new UsdCollectionAPI(UsdPINVOKE.UsdCollectionAPI_Get__SWIG_1(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPIVector GetAll(UsdPrim prim)
		{
			UsdCollectionAPIVector result = new UsdCollectionAPIVector(UsdPINVOKE.UsdCollectionAPI_GetAll(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsSchemaPropertyBaseName(TfToken baseName)
		{
			bool result = UsdPINVOKE.UsdCollectionAPI_IsSchemaPropertyBaseName(TfToken.getCPtr(baseName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsCollectionAPIPath(SdfPath path, TfToken name)
		{
			bool result = UsdPINVOKE.UsdCollectionAPI_IsCollectionAPIPath(SdfPath.getCPtr(path), TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, TfToken name, out string whyNot)
		{
			bool result = UsdPINVOKE.UsdCollectionAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), TfToken.getCPtr(name), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, TfToken name)
		{
			bool result = UsdPINVOKE.UsdCollectionAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim), TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPI Apply(UsdPrim prim, TfToken name)
		{
			UsdCollectionAPI result = new UsdCollectionAPI(UsdPINVOKE.UsdCollectionAPI_Apply(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetExpansionRuleAttr()
		{
			return new UsdAttribute(UsdPINVOKE.UsdCollectionAPI_GetExpansionRuleAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateExpansionRuleAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExpansionRuleAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateExpansionRuleAttr()
		{
			return new UsdAttribute(UsdPINVOKE.UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetIncludeRootAttr()
		{
			return new UsdAttribute(UsdPINVOKE.UsdCollectionAPI_GetIncludeRootAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIncludeRootAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdCollectionAPI_CreateIncludeRootAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIncludeRootAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdCollectionAPI_CreateIncludeRootAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIncludeRootAttr()
		{
			return new UsdAttribute(UsdPINVOKE.UsdCollectionAPI_CreateIncludeRootAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetIncludesRel()
		{
			return new UsdRelationship(UsdPINVOKE.UsdCollectionAPI_GetIncludesRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateIncludesRel()
		{
			return new UsdRelationship(UsdPINVOKE.UsdCollectionAPI_CreateIncludesRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetExcludesRel()
		{
			return new UsdRelationship(UsdPINVOKE.UsdCollectionAPI_GetExcludesRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateExcludesRel()
		{
			return new UsdRelationship(UsdPINVOKE.UsdCollectionAPI_CreateExcludesRel(swigCPtr), cMemoryOwn: true);
		}

		public static UsdCollectionAPI GetCollection(UsdStage stage, SdfPath collectionPath)
		{
			UsdCollectionAPI result = new UsdCollectionAPI(UsdPINVOKE.UsdCollectionAPI_GetCollection__SWIG_0(UsdStage.getCPtr(stage), SdfPath.getCPtr(collectionPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPI GetCollection(UsdPrim prim, TfToken name)
		{
			UsdCollectionAPI result = new UsdCollectionAPI(UsdPINVOKE.UsdCollectionAPI_GetCollection__SWIG_1(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdCollectionAPIVector GetAllCollections(UsdPrim prim)
		{
			UsdCollectionAPIVector result = new UsdCollectionAPIVector(UsdPINVOKE.UsdCollectionAPI_GetAllCollections(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath GetCollectionPath()
		{
			return new SdfPath(UsdPINVOKE.UsdCollectionAPI_GetCollectionPath(swigCPtr), cMemoryOwn: true);
		}

		public static SdfPath GetNamedCollectionPath(UsdPrim prim, TfToken collectionName)
		{
			SdfPath result = new SdfPath(UsdPINVOKE.UsdCollectionAPI_GetNamedCollectionPath(UsdPrim.getCPtr(prim), TfToken.getCPtr(collectionName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_UsdCollectionMembershipQuery ComputeMembershipQuery()
		{
			return new SWIGTYPE_p_UsdCollectionMembershipQuery(UsdPINVOKE.UsdCollectionAPI_ComputeMembershipQuery__SWIG_0(swigCPtr), futureUse: true);
		}

		public void ComputeMembershipQuery(SWIGTYPE_p_UsdCollectionMembershipQuery query)
		{
			UsdPINVOKE.UsdCollectionAPI_ComputeMembershipQuery__SWIG_1(swigCPtr, SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query));
		}

		public bool HasNoIncludedPaths()
		{
			return UsdPINVOKE.UsdCollectionAPI_HasNoIncludedPaths(swigCPtr);
		}

		public static UsdObjectSet ComputeIncludedObjects(SWIGTYPE_p_UsdCollectionMembershipQuery query, UsdStage stage, Usd_PrimFlagsPredicate pred)
		{
			UsdObjectSet result = new UsdObjectSet(UsdPINVOKE.UsdCollectionAPI_ComputeIncludedObjects__SWIG_0(SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query), UsdStage.getCPtr(stage), Usd_PrimFlagsPredicate.getCPtr(pred)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdObjectSet ComputeIncludedObjects(SWIGTYPE_p_UsdCollectionMembershipQuery query, UsdStage stage)
		{
			UsdObjectSet result = new UsdObjectSet(UsdPINVOKE.UsdCollectionAPI_ComputeIncludedObjects__SWIG_1(SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query), UsdStage.getCPtr(stage)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPathSet ComputeIncludedPaths(SWIGTYPE_p_UsdCollectionMembershipQuery query, UsdStage stage, Usd_PrimFlagsPredicate pred)
		{
			SdfPathSet result = new SdfPathSet(UsdPINVOKE.UsdCollectionAPI_ComputeIncludedPaths__SWIG_0(SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query), UsdStage.getCPtr(stage), Usd_PrimFlagsPredicate.getCPtr(pred)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPathSet ComputeIncludedPaths(SWIGTYPE_p_UsdCollectionMembershipQuery query, UsdStage stage)
		{
			SdfPathSet result = new SdfPathSet(UsdPINVOKE.UsdCollectionAPI_ComputeIncludedPaths__SWIG_1(SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query), UsdStage.getCPtr(stage)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IncludePath(SdfPath pathToInclude)
		{
			bool result = UsdPINVOKE.UsdCollectionAPI_IncludePath(swigCPtr, SdfPath.getCPtr(pathToInclude));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ExcludePath(SdfPath pathToExclude)
		{
			bool result = UsdPINVOKE.UsdCollectionAPI_ExcludePath(swigCPtr, SdfPath.getCPtr(pathToExclude));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Validate(out string reason)
		{
			bool result = UsdPINVOKE.UsdCollectionAPI_Validate(swigCPtr, out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ResetCollection()
		{
			return UsdPINVOKE.UsdCollectionAPI_ResetCollection(swigCPtr);
		}

		public bool BlockCollection()
		{
			return UsdPINVOKE.UsdCollectionAPI_BlockCollection(swigCPtr);
		}

		public static bool CanContainPropertyName(TfToken name)
		{
			bool result = UsdPINVOKE.UsdCollectionAPI_CanContainPropertyName(TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
