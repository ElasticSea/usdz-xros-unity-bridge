using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPrimSpecConstHandle : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfPrimSpecConstHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPrimSpecConstHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPrimSpecConstHandle obj)
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

		~SdfPrimSpecConstHandle()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						SdfPINVOKE.delete_SdfPrimSpecConstHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPrimSpecConstHandle()
			: this(SdfPINVOKE.new_SdfPrimSpecConstHandle__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPrimSpecConstHandle(SdfPrimSpec baseType)
			: this(SdfPINVOKE.new_SdfPrimSpecConstHandle__SWIG_1(SdfPrimSpec.getCPtr(baseType)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPrimSpecConstHandle(SdfPrimSpecHandle otherHandle)
			: this(SdfPINVOKE.new_SdfPrimSpecConstHandle__SWIG_2(SdfPrimSpecHandle.getCPtr(otherHandle)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPrimSpec __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfPrimSpecConstHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfPrimSpec(intPtr, cMemoryOwn: false);
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpecConstHandle_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfPrimSpecConstHandle_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetNameRoot()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetNameRoot(swigCPtr), cMemoryOwn: true);
		}

		public SdfPrimSpecHandle GetNameParent()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetNameParent(swigCPtr), cMemoryOwn: true);
		}

		public SdfPrimSpecHandle GetRealNameParent()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetRealNameParent(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfPrimSpecView GetNameChildren()
		{
			return new SWIGTYPE_p_SdfPrimSpecView(SdfPINVOKE.SdfPrimSpecConstHandle_GetNameChildren(swigCPtr), futureUse: true);
		}

		public bool HasNameChildrenOrder()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasNameChildrenOrder(swigCPtr);
		}

		public void ApplyNameChildrenOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfPrimSpecConstHandle_ApplyNameChildrenOrder(swigCPtr, TfTokenVector.getCPtr(vec));
		}

		public SWIGTYPE_p_SdfPropertySpecView GetProperties()
		{
			return new SWIGTYPE_p_SdfPropertySpecView(SdfPINVOKE.SdfPrimSpecConstHandle_GetProperties(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfAttributeSpecView GetAttributes()
		{
			return new SWIGTYPE_p_SdfAttributeSpecView(SdfPINVOKE.SdfPrimSpecConstHandle_GetAttributes(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfRelationshipSpecView GetRelationships()
		{
			return new SWIGTYPE_p_SdfRelationshipSpecView(SdfPINVOKE.SdfPrimSpecConstHandle_GetRelationships(swigCPtr), futureUse: true);
		}

		public bool HasPropertyOrder()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasPropertyOrder(swigCPtr);
		}

		public void ApplyPropertyOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfPrimSpecConstHandle_ApplyPropertyOrder(swigCPtr, TfTokenVector.getCPtr(vec));
		}

		public SdfSpecHandle GetObjectAtPath(SdfPath path)
		{
			SdfSpecHandle result = new SdfSpecHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetObjectAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetPrimAtPath(SdfPath path)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetPrimAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPropertySpecHandle GetPropertyAtPath(SdfPath path)
		{
			SdfPropertySpecHandle result = new SdfPropertySpecHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetPropertyAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAttributeSpecHandle GetAttributeAtPath(SdfPath path)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetAttributeAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelationshipSpecHandle GetRelationshipAtPath(SdfPath path)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetRelationshipAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetTypeName()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpecConstHandle_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetComment(swigCPtr);
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetDocumentation(swigCPtr);
		}

		public bool GetActive()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetActive(swigCPtr);
		}

		public bool HasActive()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasActive(swigCPtr);
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetHidden(swigCPtr);
		}

		public TfToken GetKind()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpecConstHandle_GetKind(swigCPtr), cMemoryOwn: true);
		}

		public bool HasKind()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasKind(swigCPtr);
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpecConstHandle_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetSymmetricPeer(swigCPtr);
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetPrefix(swigCPtr);
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetSuffix(swigCPtr);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public SdfSpecifier GetSpecifier()
		{
			return (SdfSpecifier)SdfPINVOKE.SdfPrimSpecConstHandle_GetSpecifier(swigCPtr);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfPrimSpecConstHandle_GetPermission(swigCPtr);
		}

		public VtDictionary GetPrefixSubstitutions()
		{
			return new VtDictionary(SdfPINVOKE.SdfPrimSpecConstHandle_GetPrefixSubstitutions(swigCPtr), cMemoryOwn: true);
		}

		public VtDictionary GetSuffixSubstitutions()
		{
			return new VtDictionary(SdfPINVOKE.SdfPrimSpecConstHandle_GetSuffixSubstitutions(swigCPtr), cMemoryOwn: true);
		}

		public bool GetInstanceable()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_GetInstanceable(swigCPtr);
		}

		public bool HasInstanceable()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasInstanceable(swigCPtr);
		}

		public SWIGTYPE_p_SdfPayloadsProxy GetPayloadList()
		{
			return new SWIGTYPE_p_SdfPayloadsProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetPayloadList(swigCPtr), futureUse: true);
		}

		public bool HasPayloads()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasPayloads(swigCPtr);
		}

		public SWIGTYPE_p_SdfInheritsProxy GetInheritPathList()
		{
			return new SWIGTYPE_p_SdfInheritsProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetInheritPathList(swigCPtr), futureUse: true);
		}

		public bool HasInheritPaths()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasInheritPaths(swigCPtr);
		}

		public SWIGTYPE_p_SdfSpecializesProxy GetSpecializesList()
		{
			return new SWIGTYPE_p_SdfSpecializesProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetSpecializesList(swigCPtr), futureUse: true);
		}

		public bool HasSpecializes()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasSpecializes(swigCPtr);
		}

		public SWIGTYPE_p_SdfReferencesProxy GetReferenceList()
		{
			return new SWIGTYPE_p_SdfReferencesProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetReferenceList(swigCPtr), futureUse: true);
		}

		public bool HasReferences()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasReferences(swigCPtr);
		}

		public SWIGTYPE_p_SdfVariantSetNamesProxy GetVariantSetNameList()
		{
			return new SWIGTYPE_p_SdfVariantSetNamesProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetVariantSetNameList(swigCPtr), futureUse: true);
		}

		public bool HasVariantSetNames()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasVariantSetNames(swigCPtr);
		}

		public StdStringVector GetVariantNames(string name)
		{
			StdStringVector result = new StdStringVector(SdfPINVOKE.SdfPrimSpecConstHandle_GetVariantNames(swigCPtr, name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_SdfVariantSelectionProxy GetVariantSelections()
		{
			return new SWIGTYPE_p_SdfVariantSelectionProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetVariantSelections(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfRelocatesMapProxy GetRelocates()
		{
			return new SWIGTYPE_p_SdfRelocatesMapProxy(SdfPINVOKE.SdfPrimSpecConstHandle_GetRelocates(swigCPtr), futureUse: true);
		}

		public bool HasRelocates()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_HasRelocates(swigCPtr);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfPrimSpecConstHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SdfSpecType GetSpecType()
		{
			return (SdfSpecType)SdfPINVOKE.SdfPrimSpecConstHandle_GetSpecType(swigCPtr);
		}

		public bool IsDormant()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_IsDormant(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfPrimSpecConstHandle_GetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPrimSpecConstHandle_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_PermissionToEdit(swigCPtr);
		}

		public TfTokenVector ListInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPrimSpecConstHandle_ListInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetMetaDataInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPrimSpecConstHandle_GetMetaDataInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetMetaDataDisplayGroup(TfToken key)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfPrimSpecConstHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPrimSpecConstHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasInfo(TfToken key)
		{
			bool result = SdfPINVOKE.SdfPrimSpecConstHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfType GetTypeForInfo(TfToken key)
		{
			TfType result = new TfType(SdfPINVOKE.SdfPrimSpecConstHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFallbackForInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPrimSpecConstHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInert(bool ignoreChildren)
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
		}

		public bool IsInert()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandle_IsInert__SWIG_1(swigCPtr);
		}

		public TfTokenVector ListFields()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPrimSpecConstHandle_ListFields(swigCPtr), cMemoryOwn: true);
		}

		public bool HasField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfPrimSpecConstHandle_HasField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(TfToken name)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPrimSpecConstHandle_GetField(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
