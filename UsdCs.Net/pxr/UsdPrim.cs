using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdPrim : UsdObject
	{
		private HandleRef swigCPtr;

		public UsdPrim(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdPrim_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrim obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrim obj)
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
						UsdPINVOKE.delete_UsdPrim(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdPrim()
			: this(UsdPINVOKE.new_UsdPrim(), cMemoryOwn: true)
		{
		}

		public SWIGTYPE_p_UsdPrimTypeInfo GetPrimTypeInfo()
		{
			return new SWIGTYPE_p_UsdPrimTypeInfo(UsdPINVOKE.UsdPrim_GetPrimTypeInfo(swigCPtr), futureUse: false);
		}

		public SWIGTYPE_p_UsdPrimDefinition GetPrimDefinition()
		{
			return new SWIGTYPE_p_UsdPrimDefinition(UsdPINVOKE.UsdPrim_GetPrimDefinition(swigCPtr), futureUse: false);
		}

		public SdfSpecifier GetSpecifier()
		{
			return (SdfSpecifier)UsdPINVOKE.UsdPrim_GetSpecifier(swigCPtr);
		}

		public SdfPrimSpecHandleVector GetPrimStack()
		{
			return new SdfPrimSpecHandleVector(UsdPINVOKE.UsdPrim_GetPrimStack(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__vectorT_std__pairT_SdfPrimSpecHandle_SdfLayerOffset_t_t GetPrimStackWithLayerOffsets()
		{
			return new SWIGTYPE_p_std__vectorT_std__pairT_SdfPrimSpecHandle_SdfLayerOffset_t_t(UsdPINVOKE.UsdPrim_GetPrimStackWithLayerOffsets(swigCPtr), futureUse: true);
		}

		public bool SetSpecifier(SdfSpecifier specifier)
		{
			return UsdPINVOKE.UsdPrim_SetSpecifier(swigCPtr, (int)specifier);
		}

		public TfToken GetTypeName()
		{
			return new TfToken(UsdPINVOKE.UsdPrim_GetTypeName(swigCPtr), cMemoryOwn: false);
		}

		public bool SetTypeName(TfToken typeName)
		{
			bool result = UsdPINVOKE.UsdPrim_SetTypeName(swigCPtr, TfToken.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearTypeName()
		{
			return UsdPINVOKE.UsdPrim_ClearTypeName(swigCPtr);
		}

		public bool HasAuthoredTypeName()
		{
			return UsdPINVOKE.UsdPrim_HasAuthoredTypeName(swigCPtr);
		}

		public bool IsActive()
		{
			return UsdPINVOKE.UsdPrim_IsActive(swigCPtr);
		}

		public bool SetActive(bool active)
		{
			return UsdPINVOKE.UsdPrim_SetActive(swigCPtr, active);
		}

		public bool ClearActive()
		{
			return UsdPINVOKE.UsdPrim_ClearActive(swigCPtr);
		}

		public bool HasAuthoredActive()
		{
			return UsdPINVOKE.UsdPrim_HasAuthoredActive(swigCPtr);
		}

		public bool IsLoaded()
		{
			return UsdPINVOKE.UsdPrim_IsLoaded(swigCPtr);
		}

		public bool IsModel()
		{
			return UsdPINVOKE.UsdPrim_IsModel(swigCPtr);
		}

		public bool IsGroup()
		{
			return UsdPINVOKE.UsdPrim_IsGroup(swigCPtr);
		}

		public bool IsAbstract()
		{
			return UsdPINVOKE.UsdPrim_IsAbstract(swigCPtr);
		}

		public bool IsDefined()
		{
			return UsdPINVOKE.UsdPrim_IsDefined(swigCPtr);
		}

		public bool HasDefiningSpecifier()
		{
			return UsdPINVOKE.UsdPrim_HasDefiningSpecifier(swigCPtr);
		}

		public TfTokenVector GetAppliedSchemas()
		{
			return new TfTokenVector(UsdPINVOKE.UsdPrim_GetAppliedSchemas(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetPropertyNames(SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t predicate)
		{
			TfTokenVector result = new TfTokenVector(UsdPINVOKE.UsdPrim_GetPropertyNames__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetPropertyNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdPrim_GetPropertyNames__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetAuthoredPropertyNames(SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t predicate)
		{
			TfTokenVector result = new TfTokenVector(UsdPINVOKE.UsdPrim_GetAuthoredPropertyNames__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetAuthoredPropertyNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdPrim_GetAuthoredPropertyNames__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdPropertyVector GetProperties(SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t predicate)
		{
			UsdPropertyVector result = new UsdPropertyVector(UsdPINVOKE.UsdPrim_GetProperties__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPropertyVector GetProperties()
		{
			return new UsdPropertyVector(UsdPINVOKE.UsdPrim_GetProperties__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdPropertyVector GetAuthoredProperties(SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t predicate)
		{
			UsdPropertyVector result = new UsdPropertyVector(UsdPINVOKE.UsdPrim_GetAuthoredProperties__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPropertyVector GetAuthoredProperties()
		{
			return new UsdPropertyVector(UsdPINVOKE.UsdPrim_GetAuthoredProperties__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdPropertyVector GetPropertiesInNamespace(StdStringVector namespaces)
		{
			UsdPropertyVector result = new UsdPropertyVector(UsdPINVOKE.UsdPrim_GetPropertiesInNamespace__SWIG_0(swigCPtr, StdStringVector.getCPtr(namespaces)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPropertyVector GetPropertiesInNamespace(string namespaces)
		{
			UsdPropertyVector result = new UsdPropertyVector(UsdPINVOKE.UsdPrim_GetPropertiesInNamespace__SWIG_1(swigCPtr, namespaces), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPropertyVector GetAuthoredPropertiesInNamespace(StdStringVector namespaces)
		{
			UsdPropertyVector result = new UsdPropertyVector(UsdPINVOKE.UsdPrim_GetAuthoredPropertiesInNamespace__SWIG_0(swigCPtr, StdStringVector.getCPtr(namespaces)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPropertyVector GetAuthoredPropertiesInNamespace(string namespaces)
		{
			UsdPropertyVector result = new UsdPropertyVector(UsdPINVOKE.UsdPrim_GetAuthoredPropertiesInNamespace__SWIG_1(swigCPtr, namespaces), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetPropertyOrder()
		{
			return new TfTokenVector(UsdPINVOKE.UsdPrim_GetPropertyOrder(swigCPtr), cMemoryOwn: true);
		}

		public void SetPropertyOrder(TfTokenVector order)
		{
			UsdPINVOKE.UsdPrim_SetPropertyOrder(swigCPtr, TfTokenVector.getCPtr(order));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ClearPropertyOrder()
		{
			UsdPINVOKE.UsdPrim_ClearPropertyOrder(swigCPtr);
		}

		public bool RemoveProperty(TfToken propName)
		{
			bool result = UsdPINVOKE.UsdPrim_RemoveProperty(swigCPtr, TfToken.getCPtr(propName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdProperty GetProperty(TfToken propName)
		{
			UsdProperty result = new UsdProperty(UsdPINVOKE.UsdPrim_GetProperty(swigCPtr, TfToken.getCPtr(propName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasProperty(TfToken propName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasProperty(swigCPtr, TfToken.getCPtr(propName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsA(TfType schemaType)
		{
			bool result = UsdPINVOKE.UsdPrim_IsA__SWIG_1(swigCPtr, TfType.getCPtr(schemaType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsA(TfToken schemaIdentifier)
		{
			bool result = UsdPINVOKE.UsdPrim_IsA__SWIG_2(swigCPtr, TfToken.getCPtr(schemaIdentifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsA(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion)
		{
			bool result = UsdPINVOKE.UsdPrim_IsA__SWIG_3(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInFamily(TfToken schemaFamily)
		{
			bool result = UsdPINVOKE.UsdPrim_IsInFamily__SWIG_0(swigCPtr, TfToken.getCPtr(schemaFamily));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInFamily(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy)
		{
			bool result = UsdPINVOKE.UsdPrim_IsInFamily__SWIG_1(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInFamily(TfType schemaType, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy)
		{
			bool result = UsdPINVOKE.UsdPrim_IsInFamily__SWIG_3(swigCPtr, TfType.getCPtr(schemaType), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInFamily(TfToken schemaIdentifier, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy)
		{
			bool result = UsdPINVOKE.UsdPrim_IsInFamily__SWIG_4(swigCPtr, TfToken.getCPtr(schemaIdentifier), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetVersionIfIsInFamily(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion)
		{
			bool result = UsdPINVOKE.UsdPrim_GetVersionIfIsInFamily(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPI(TfType schemaType)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPI__SWIG_2(swigCPtr, TfType.getCPtr(schemaType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPI(TfType schemaType, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPI__SWIG_3(swigCPtr, TfType.getCPtr(schemaType), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPI(TfToken schemaIdentifier)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPI__SWIG_4(swigCPtr, TfToken.getCPtr(schemaIdentifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPI(TfToken schemaIdentifier, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPI__SWIG_5(swigCPtr, TfToken.getCPtr(schemaIdentifier), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPI__SWIG_6(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPI__SWIG_7(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPIInFamily(TfToken schemaFamily)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPIInFamily__SWIG_0(swigCPtr, TfToken.getCPtr(schemaFamily));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPIInFamily(TfToken schemaFamily, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPIInFamily__SWIG_1(swigCPtr, TfToken.getCPtr(schemaFamily), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPIInFamily(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPIInFamily__SWIG_2(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPIInFamily(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPIInFamily__SWIG_3(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPIInFamily(TfType schemaType, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPIInFamily__SWIG_6(swigCPtr, TfType.getCPtr(schemaType), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPIInFamily(TfType schemaType, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPIInFamily__SWIG_7(swigCPtr, TfType.getCPtr(schemaType), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPIInFamily(TfToken schemaIdentifier, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPIInFamily__SWIG_8(swigCPtr, TfToken.getCPtr(schemaIdentifier), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAPIInFamily(TfToken schemaIdentifier, SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy versionPolicy, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAPIInFamily__SWIG_9(swigCPtr, TfToken.getCPtr(schemaIdentifier), SWIGTYPE_p_UsdSchemaRegistry__VersionPolicy.getCPtr(versionPolicy), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetVersionIfHasAPIInFamily(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion)
		{
			bool result = UsdPINVOKE.UsdPrim_GetVersionIfHasAPIInFamily__SWIG_0(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetVersionIfHasAPIInFamily(TfToken schemaFamily, TfToken instanceName, SWIGTYPE_p_UsdSchemaVersion schemaVersion)
		{
			bool result = UsdPINVOKE.UsdPrim_GetVersionIfHasAPIInFamily__SWIG_1(swigCPtr, TfToken.getCPtr(schemaFamily), TfToken.getCPtr(instanceName), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfType schemaType, out string whyNot)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_4(swigCPtr, TfType.getCPtr(schemaType), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfType schemaType)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_5(swigCPtr, TfType.getCPtr(schemaType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfType schemaType, TfToken instanceName, out string whyNot)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_6(swigCPtr, TfType.getCPtr(schemaType), TfToken.getCPtr(instanceName), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfType schemaType, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_7(swigCPtr, TfType.getCPtr(schemaType), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfToken schemaIdentifier, out string whyNot)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_8(swigCPtr, TfToken.getCPtr(schemaIdentifier), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfToken schemaIdentifier)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_9(swigCPtr, TfToken.getCPtr(schemaIdentifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfToken schemaIdentifier, TfToken instanceName, out string whyNot)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_10(swigCPtr, TfToken.getCPtr(schemaIdentifier), TfToken.getCPtr(instanceName), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfToken schemaIdentifier, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_11(swigCPtr, TfToken.getCPtr(schemaIdentifier), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, out string whyNot)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_12(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_13(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, TfToken instanceName, out string whyNot)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_14(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), TfToken.getCPtr(instanceName), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanApplyAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_CanApplyAPI__SWIG_15(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ApplyAPI(TfType schemaType)
		{
			bool result = UsdPINVOKE.UsdPrim_ApplyAPI__SWIG_2(swigCPtr, TfType.getCPtr(schemaType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ApplyAPI(TfType schemaType, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_ApplyAPI__SWIG_3(swigCPtr, TfType.getCPtr(schemaType), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ApplyAPI(TfToken schemaIdentifier)
		{
			bool result = UsdPINVOKE.UsdPrim_ApplyAPI__SWIG_4(swigCPtr, TfToken.getCPtr(schemaIdentifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ApplyAPI(TfToken schemaIdentifier, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_ApplyAPI__SWIG_5(swigCPtr, TfToken.getCPtr(schemaIdentifier), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ApplyAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion)
		{
			bool result = UsdPINVOKE.UsdPrim_ApplyAPI__SWIG_6(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ApplyAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_ApplyAPI__SWIG_7(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveAPI(TfType schemaType)
		{
			bool result = UsdPINVOKE.UsdPrim_RemoveAPI__SWIG_2(swigCPtr, TfType.getCPtr(schemaType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveAPI(TfType schemaType, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_RemoveAPI__SWIG_3(swigCPtr, TfType.getCPtr(schemaType), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveAPI(TfToken schemaIdentifier)
		{
			bool result = UsdPINVOKE.UsdPrim_RemoveAPI__SWIG_4(swigCPtr, TfToken.getCPtr(schemaIdentifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveAPI(TfToken schemaIdentifier, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_RemoveAPI__SWIG_5(swigCPtr, TfToken.getCPtr(schemaIdentifier), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion)
		{
			bool result = UsdPINVOKE.UsdPrim_RemoveAPI__SWIG_6(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveAPI(TfToken schemaFamily, SWIGTYPE_p_UsdSchemaVersion schemaVersion, TfToken instanceName)
		{
			bool result = UsdPINVOKE.UsdPrim_RemoveAPI__SWIG_7(swigCPtr, TfToken.getCPtr(schemaFamily), SWIGTYPE_p_UsdSchemaVersion.getCPtr(schemaVersion), TfToken.getCPtr(instanceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddAppliedSchema(TfToken appliedSchemaName)
		{
			bool result = UsdPINVOKE.UsdPrim_AddAppliedSchema(swigCPtr, TfToken.getCPtr(appliedSchemaName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveAppliedSchema(TfToken appliedSchemaName)
		{
			bool result = UsdPINVOKE.UsdPrim_RemoveAppliedSchema(swigCPtr, TfToken.getCPtr(appliedSchemaName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim GetChild(TfToken name)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdPrim_GetChild(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimSiblingRange GetChildren()
		{
			return new UsdPrimSiblingRange(UsdPINVOKE.UsdPrim_GetChildren(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSiblingRange GetAllChildren()
		{
			return new UsdPrimSiblingRange(UsdPINVOKE.UsdPrim_GetAllChildren(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSiblingRange GetFilteredChildren(Usd_PrimFlagsPredicate predicate)
		{
			UsdPrimSiblingRange result = new UsdPrimSiblingRange(UsdPINVOKE.UsdPrim_GetFilteredChildren(swigCPtr, Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetChildrenNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdPrim_GetChildrenNames(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetAllChildrenNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdPrim_GetAllChildrenNames(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetFilteredChildrenNames(Usd_PrimFlagsPredicate predicate)
		{
			TfTokenVector result = new TfTokenVector(UsdPINVOKE.UsdPrim_GetFilteredChildrenNames(swigCPtr, Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrimSubtreeRange GetDescendants()
		{
			return new UsdPrimSubtreeRange(UsdPINVOKE.UsdPrim_GetDescendants(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSubtreeRange GetAllDescendants()
		{
			return new UsdPrimSubtreeRange(UsdPINVOKE.UsdPrim_GetAllDescendants(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSubtreeRange GetFilteredDescendants(Usd_PrimFlagsPredicate predicate)
		{
			UsdPrimSubtreeRange result = new UsdPrimSubtreeRange(UsdPINVOKE.UsdPrim_GetFilteredDescendants(swigCPtr, Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetChildrenReorder()
		{
			return new TfTokenVector(UsdPINVOKE.UsdPrim_GetChildrenReorder(swigCPtr), cMemoryOwn: true);
		}

		public void SetChildrenReorder(TfTokenVector order)
		{
			UsdPINVOKE.UsdPrim_SetChildrenReorder(swigCPtr, TfTokenVector.getCPtr(order));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ClearChildrenReorder()
		{
			UsdPINVOKE.UsdPrim_ClearChildrenReorder(swigCPtr);
		}

		public UsdPrim GetParent()
		{
			return new UsdPrim(UsdPINVOKE.UsdPrim_GetParent(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetNextSibling()
		{
			return new UsdPrim(UsdPINVOKE.UsdPrim_GetNextSibling(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetFilteredNextSibling(Usd_PrimFlagsPredicate predicate)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdPrim_GetFilteredNextSibling(swigCPtr, Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsPseudoRoot()
		{
			return UsdPINVOKE.UsdPrim_IsPseudoRoot(swigCPtr);
		}

		public UsdPrim GetPrimAtPath(SdfPath path)
		{
			UsdPrim result = new UsdPrim(UsdPINVOKE.UsdPrim_GetPrimAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdObject GetObjectAtPath(SdfPath path)
		{
			UsdObject result = new UsdObject(UsdPINVOKE.UsdPrim_GetObjectAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdProperty GetPropertyAtPath(SdfPath path)
		{
			UsdProperty result = new UsdProperty(UsdPINVOKE.UsdPrim_GetPropertyAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAttributeAtPath(SdfPath path)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_GetAttributeAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship GetRelationshipAtPath(SdfPath path)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdPrim_GetRelationshipAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdVariantSets GetVariantSets()
		{
			return new UsdVariantSets(UsdPINVOKE.UsdPrim_GetVariantSets(swigCPtr), cMemoryOwn: true);
		}

		public UsdVariantSet GetVariantSet(string variantSetName)
		{
			UsdVariantSet result = new UsdVariantSet(UsdPINVOKE.UsdPrim_GetVariantSet(swigCPtr, variantSetName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasVariantSets()
		{
			return UsdPINVOKE.UsdPrim_HasVariantSets(swigCPtr);
		}

		public UsdAttribute CreateAttribute(TfToken name, SdfValueTypeName typeName, bool custom, SdfVariability variability)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_CreateAttribute__SWIG_0(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), custom, (int)variability), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAttribute(TfToken name, SdfValueTypeName typeName, bool custom)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_CreateAttribute__SWIG_1(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), custom), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAttribute(TfToken name, SdfValueTypeName typeName, SdfVariability variability)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_CreateAttribute__SWIG_2(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), (int)variability), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAttribute(TfToken name, SdfValueTypeName typeName)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_CreateAttribute__SWIG_3(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAttribute(StdStringVector nameElts, SdfValueTypeName typeName, bool custom, SdfVariability variability)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_CreateAttribute__SWIG_4(swigCPtr, StdStringVector.getCPtr(nameElts), SdfValueTypeName.getCPtr(typeName), custom, (int)variability), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAttribute(StdStringVector nameElts, SdfValueTypeName typeName, bool custom)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_CreateAttribute__SWIG_5(swigCPtr, StdStringVector.getCPtr(nameElts), SdfValueTypeName.getCPtr(typeName), custom), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAttribute(StdStringVector nameElts, SdfValueTypeName typeName, SdfVariability variability)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_CreateAttribute__SWIG_6(swigCPtr, StdStringVector.getCPtr(nameElts), SdfValueTypeName.getCPtr(typeName), (int)variability), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAttribute(StdStringVector nameElts, SdfValueTypeName typeName)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_CreateAttribute__SWIG_7(swigCPtr, StdStringVector.getCPtr(nameElts), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttributeVector GetAttributes()
		{
			return new UsdAttributeVector(UsdPINVOKE.UsdPrim_GetAttributes(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttributeVector GetAuthoredAttributes()
		{
			return new UsdAttributeVector(UsdPINVOKE.UsdPrim_GetAuthoredAttributes(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetAttribute(TfToken attrName)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdPrim_GetAttribute(swigCPtr, TfToken.getCPtr(attrName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAttribute(TfToken attrName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasAttribute(swigCPtr, TfToken.getCPtr(attrName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship CreateRelationship(TfToken relName, bool custom)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdPrim_CreateRelationship__SWIG_0(swigCPtr, TfToken.getCPtr(relName), custom), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship CreateRelationship(TfToken relName)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdPrim_CreateRelationship__SWIG_1(swigCPtr, TfToken.getCPtr(relName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship CreateRelationship(StdStringVector nameElts, bool custom)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdPrim_CreateRelationship__SWIG_2(swigCPtr, StdStringVector.getCPtr(nameElts), custom), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship CreateRelationship(StdStringVector nameElts)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdPrim_CreateRelationship__SWIG_3(swigCPtr, StdStringVector.getCPtr(nameElts)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationshipVector GetRelationships()
		{
			return new UsdRelationshipVector(UsdPINVOKE.UsdPrim_GetRelationships(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationshipVector GetAuthoredRelationships()
		{
			return new UsdRelationshipVector(UsdPINVOKE.UsdPrim_GetAuthoredRelationships(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetRelationship(TfToken relName)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdPrim_GetRelationship(swigCPtr, TfToken.getCPtr(relName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasRelationship(TfToken relName)
		{
			bool result = UsdPINVOKE.UsdPrim_HasRelationship(swigCPtr, TfToken.getCPtr(relName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearPayload()
		{
			return UsdPINVOKE.UsdPrim_ClearPayload(swigCPtr);
		}

		public bool HasPayload()
		{
			return UsdPINVOKE.UsdPrim_HasPayload(swigCPtr);
		}

		public bool SetPayload(SdfPayload payload)
		{
			bool result = UsdPINVOKE.UsdPrim_SetPayload__SWIG_0(swigCPtr, SdfPayload.getCPtr(payload));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetPayload(string assetPath, SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdPrim_SetPayload__SWIG_1(swigCPtr, assetPath, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetPayload(SdfLayerHandle layer, SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdPrim_SetPayload__SWIG_2(swigCPtr, SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPayloads GetPayloads()
		{
			return new UsdPayloads(UsdPINVOKE.UsdPrim_GetPayloads(swigCPtr), cMemoryOwn: true);
		}

		public bool HasAuthoredPayloads()
		{
			return UsdPINVOKE.UsdPrim_HasAuthoredPayloads(swigCPtr);
		}

		public void Load(UsdLoadPolicy policy)
		{
			UsdPINVOKE.UsdPrim_Load__SWIG_0(swigCPtr, (int)policy);
		}

		public void Load()
		{
			UsdPINVOKE.UsdPrim_Load__SWIG_1(swigCPtr);
		}

		public void Unload()
		{
			UsdPINVOKE.UsdPrim_Unload(swigCPtr);
		}

		public UsdReferences GetReferences()
		{
			return new UsdReferences(UsdPINVOKE.UsdPrim_GetReferences(swigCPtr), cMemoryOwn: true);
		}

		public bool HasAuthoredReferences()
		{
			return UsdPINVOKE.UsdPrim_HasAuthoredReferences(swigCPtr);
		}

		public UsdInherits GetInherits()
		{
			return new UsdInherits(UsdPINVOKE.UsdPrim_GetInherits(swigCPtr), cMemoryOwn: true);
		}

		public bool HasAuthoredInherits()
		{
			return UsdPINVOKE.UsdPrim_HasAuthoredInherits(swigCPtr);
		}

		public UsdSpecializes GetSpecializes()
		{
			return new UsdSpecializes(UsdPINVOKE.UsdPrim_GetSpecializes(swigCPtr), cMemoryOwn: true);
		}

		public bool HasAuthoredSpecializes()
		{
			return UsdPINVOKE.UsdPrim_HasAuthoredSpecializes(swigCPtr);
		}

		public bool IsInstanceable()
		{
			return UsdPINVOKE.UsdPrim_IsInstanceable(swigCPtr);
		}

		public bool SetInstanceable(bool instanceable)
		{
			return UsdPINVOKE.UsdPrim_SetInstanceable(swigCPtr, instanceable);
		}

		public bool ClearInstanceable()
		{
			return UsdPINVOKE.UsdPrim_ClearInstanceable(swigCPtr);
		}

		public bool HasAuthoredInstanceable()
		{
			return UsdPINVOKE.UsdPrim_HasAuthoredInstanceable(swigCPtr);
		}

		public bool IsInstance()
		{
			return UsdPINVOKE.UsdPrim_IsInstance(swigCPtr);
		}

		public bool IsInstanceProxy()
		{
			return UsdPINVOKE.UsdPrim_IsInstanceProxy(swigCPtr);
		}

		public static bool IsPrototypePath(SdfPath path)
		{
			bool result = UsdPINVOKE.UsdPrim_IsPrototypePath(SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsPathInPrototype(SdfPath path)
		{
			bool result = UsdPINVOKE.UsdPrim_IsPathInPrototype(SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsPrototype()
		{
			return UsdPINVOKE.UsdPrim_IsPrototype(swigCPtr);
		}

		public bool IsInPrototype()
		{
			return UsdPINVOKE.UsdPrim_IsInPrototype(swigCPtr);
		}

		public UsdPrim GetPrototype()
		{
			return new UsdPrim(UsdPINVOKE.UsdPrim_GetPrototype(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetPrimInPrototype()
		{
			return new UsdPrim(UsdPINVOKE.UsdPrim_GetPrimInPrototype(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimVector GetInstances()
		{
			return new UsdPrimVector(UsdPINVOKE.UsdPrim_GetInstances(swigCPtr), cMemoryOwn: true);
		}

		public PcpPrimIndex GetPrimIndex()
		{
			return new PcpPrimIndex(UsdPINVOKE.UsdPrim_GetPrimIndex(swigCPtr), cMemoryOwn: false);
		}

		public PcpPrimIndex ComputeExpandedPrimIndex()
		{
			return new PcpPrimIndex(UsdPINVOKE.UsdPrim_ComputeExpandedPrimIndex(swigCPtr), cMemoryOwn: true);
		}

		public UsdResolveTarget MakeResolveTargetUpToEditTarget(UsdEditTarget editTarget)
		{
			UsdResolveTarget result = new UsdResolveTarget(UsdPINVOKE.UsdPrim_MakeResolveTargetUpToEditTarget(swigCPtr, UsdEditTarget.getCPtr(editTarget)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdResolveTarget MakeResolveTargetStrongerThanEditTarget(UsdEditTarget editTarget)
		{
			UsdResolveTarget result = new UsdResolveTarget(UsdPINVOKE.UsdPrim_MakeResolveTargetStrongerThanEditTarget(swigCPtr, UsdEditTarget.getCPtr(editTarget)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetAttributeValue(TfToken attrName, VtValue valueOut, UsdTimeCode time)
		{
			bool result = UsdPINVOKE.UsdPrim_GetAttributeValue(swigCPtr, TfToken.getCPtr(attrName), VtValue.getCPtr(valueOut), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
