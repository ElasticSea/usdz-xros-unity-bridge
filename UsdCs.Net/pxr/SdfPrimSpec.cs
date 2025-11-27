using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPrimSpec : SdfSpec
	{
		private HandleRef swigCPtr;

		public SdfPrimSpec(IntPtr cPtr, bool cMemoryOwn)
			: base(SdfPINVOKE.SdfPrimSpec_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPrimSpec obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPrimSpec obj)
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
						SdfPINVOKE.delete_SdfPrimSpec(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public static SdfPrimSpecHandle New(SdfLayerHandle parentLayer, string name, SdfSpecifier spec, string typeName)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpec_New__SWIG_0(SdfLayerHandle.getCPtr(parentLayer), name, (int)spec, typeName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPrimSpecHandle New(SdfLayerHandle parentLayer, string name, SdfSpecifier spec)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpec_New__SWIG_1(SdfLayerHandle.getCPtr(parentLayer), name, (int)spec), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPrimSpecHandle New(SdfPrimSpecHandle parentPrim, string name, SdfSpecifier spec, string typeName)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpec_New__SWIG_2(SdfPrimSpecHandle.getCPtr(parentPrim), name, (int)spec, typeName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPrimSpecHandle New(SdfPrimSpecHandle parentPrim, string name, SdfSpecifier spec)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpec_New__SWIG_3(SdfPrimSpecHandle.getCPtr(parentPrim), name, (int)spec), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfPrimSpec_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpec_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName, bool validate)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_SetName__SWIG_0(swigCPtr, newName, validate);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_SetName__SWIG_1(swigCPtr, newName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsValidName(string name)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_IsValidName(name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetNameRoot()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpec_GetNameRoot(swigCPtr), cMemoryOwn: true);
		}

		public SdfPrimSpecHandle GetNameParent()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpec_GetNameParent(swigCPtr), cMemoryOwn: true);
		}

		public SdfPrimSpecHandle GetRealNameParent()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpec_GetRealNameParent(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfPrimSpecView GetNameChildren()
		{
			return new SWIGTYPE_p_SdfPrimSpecView(SdfPINVOKE.SdfPrimSpec_GetNameChildren(swigCPtr), futureUse: true);
		}

		public void SetNameChildren(SdfPrimSpecHandleVector arg0)
		{
			SdfPINVOKE.SdfPrimSpec_SetNameChildren(swigCPtr, SdfPrimSpecHandleVector.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool InsertNameChild(SdfPrimSpecHandle child, int index)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_InsertNameChild__SWIG_0(swigCPtr, SdfPrimSpecHandle.getCPtr(child), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool InsertNameChild(SdfPrimSpecHandle child)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_InsertNameChild__SWIG_1(swigCPtr, SdfPrimSpecHandle.getCPtr(child));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveNameChild(SdfPrimSpecHandle child)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_RemoveNameChild(swigCPtr, SdfPrimSpecHandle.getCPtr(child));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasNameChildrenOrder()
		{
			return SdfPINVOKE.SdfPrimSpec_HasNameChildrenOrder(swigCPtr);
		}

		public void SetNameChildrenOrder(TfTokenVector names)
		{
			SdfPINVOKE.SdfPrimSpec_SetNameChildrenOrder(swigCPtr, TfTokenVector.getCPtr(names));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInNameChildrenOrder(TfToken name, int index)
		{
			SdfPINVOKE.SdfPrimSpec_InsertInNameChildrenOrder__SWIG_0(swigCPtr, TfToken.getCPtr(name), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInNameChildrenOrder(TfToken name)
		{
			SdfPINVOKE.SdfPrimSpec_InsertInNameChildrenOrder__SWIG_1(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromNameChildrenOrder(TfToken name)
		{
			SdfPINVOKE.SdfPrimSpec_RemoveFromNameChildrenOrder(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromNameChildrenOrderByIndex(int index)
		{
			SdfPINVOKE.SdfPrimSpec_RemoveFromNameChildrenOrderByIndex(swigCPtr, index);
		}

		public void ApplyNameChildrenOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfPrimSpec_ApplyNameChildrenOrder(swigCPtr, TfTokenVector.getCPtr(vec));
		}

		public SWIGTYPE_p_SdfPropertySpecView GetProperties()
		{
			return new SWIGTYPE_p_SdfPropertySpecView(SdfPINVOKE.SdfPrimSpec_GetProperties(swigCPtr), futureUse: true);
		}

		public void SetProperties(SdfPropertySpecHandleVector arg0)
		{
			SdfPINVOKE.SdfPrimSpec_SetProperties(swigCPtr, SdfPropertySpecHandleVector.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool InsertProperty(SdfPropertySpecHandle property, int index)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_InsertProperty__SWIG_0(swigCPtr, SdfPropertySpecHandle.getCPtr(property), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool InsertProperty(SdfPropertySpecHandle property)
		{
			bool result = SdfPINVOKE.SdfPrimSpec_InsertProperty__SWIG_1(swigCPtr, SdfPropertySpecHandle.getCPtr(property));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void RemoveProperty(SdfPropertySpecHandle property)
		{
			SdfPINVOKE.SdfPrimSpec_RemoveProperty(swigCPtr, SdfPropertySpecHandle.getCPtr(property));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfAttributeSpecView GetAttributes()
		{
			return new SWIGTYPE_p_SdfAttributeSpecView(SdfPINVOKE.SdfPrimSpec_GetAttributes(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfRelationshipSpecView GetRelationships()
		{
			return new SWIGTYPE_p_SdfRelationshipSpecView(SdfPINVOKE.SdfPrimSpec_GetRelationships(swigCPtr), futureUse: true);
		}

		public bool HasPropertyOrder()
		{
			return SdfPINVOKE.SdfPrimSpec_HasPropertyOrder(swigCPtr);
		}

		public void SetPropertyOrder(TfTokenVector names)
		{
			SdfPINVOKE.SdfPrimSpec_SetPropertyOrder(swigCPtr, TfTokenVector.getCPtr(names));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInPropertyOrder(TfToken name, int index)
		{
			SdfPINVOKE.SdfPrimSpec_InsertInPropertyOrder__SWIG_0(swigCPtr, TfToken.getCPtr(name), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInPropertyOrder(TfToken name)
		{
			SdfPINVOKE.SdfPrimSpec_InsertInPropertyOrder__SWIG_1(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromPropertyOrder(TfToken name)
		{
			SdfPINVOKE.SdfPrimSpec_RemoveFromPropertyOrder(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromPropertyOrderByIndex(int index)
		{
			SdfPINVOKE.SdfPrimSpec_RemoveFromPropertyOrderByIndex(swigCPtr, index);
		}

		public void ApplyPropertyOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfPrimSpec_ApplyPropertyOrder(swigCPtr, TfTokenVector.getCPtr(vec));
		}

		public SdfSpecHandle GetObjectAtPath(SdfPath path)
		{
			SdfSpecHandle result = new SdfSpecHandle(SdfPINVOKE.SdfPrimSpec_GetObjectAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetPrimAtPath(SdfPath path)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpec_GetPrimAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPropertySpecHandle GetPropertyAtPath(SdfPath path)
		{
			SdfPropertySpecHandle result = new SdfPropertySpecHandle(SdfPINVOKE.SdfPrimSpec_GetPropertyAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAttributeSpecHandle GetAttributeAtPath(SdfPath path)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfPrimSpec_GetAttributeAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelationshipSpecHandle GetRelationshipAtPath(SdfPath path)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfPrimSpec_GetRelationshipAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetTypeName()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpec_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		public void SetTypeName(string value)
		{
			SdfPINVOKE.SdfPrimSpec_SetTypeName(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfPrimSpec_GetComment(swigCPtr);
		}

		public void SetComment(string value)
		{
			SdfPINVOKE.SdfPrimSpec_SetComment(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfPrimSpec_GetDocumentation(swigCPtr);
		}

		public void SetDocumentation(string value)
		{
			SdfPINVOKE.SdfPrimSpec_SetDocumentation(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetActive()
		{
			return SdfPINVOKE.SdfPrimSpec_GetActive(swigCPtr);
		}

		public void SetActive(bool value)
		{
			SdfPINVOKE.SdfPrimSpec_SetActive(swigCPtr, value);
		}

		public bool HasActive()
		{
			return SdfPINVOKE.SdfPrimSpec_HasActive(swigCPtr);
		}

		public void ClearActive()
		{
			SdfPINVOKE.SdfPrimSpec_ClearActive(swigCPtr);
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfPrimSpec_GetHidden(swigCPtr);
		}

		public void SetHidden(bool value)
		{
			SdfPINVOKE.SdfPrimSpec_SetHidden(swigCPtr, value);
		}

		public TfToken GetKind()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpec_GetKind(swigCPtr), cMemoryOwn: true);
		}

		public void SetKind(TfToken value)
		{
			SdfPINVOKE.SdfPrimSpec_SetKind(swigCPtr, TfToken.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKind()
		{
			return SdfPINVOKE.SdfPrimSpec_HasKind(swigCPtr);
		}

		public void ClearKind()
		{
			SdfPINVOKE.SdfPrimSpec_ClearKind(swigCPtr);
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpec_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public void SetSymmetryFunction(TfToken functionName)
		{
			SdfPINVOKE.SdfPrimSpec_SetSymmetryFunction(swigCPtr, TfToken.getCPtr(functionName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpec_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public void SetSymmetryArgument(string name, VtValue value)
		{
			SdfPINVOKE.SdfPrimSpec_SetSymmetryArgument(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfPrimSpec_GetSymmetricPeer(swigCPtr);
		}

		public void SetSymmetricPeer(string peerName)
		{
			SdfPINVOKE.SdfPrimSpec_SetSymmetricPeer(swigCPtr, peerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfPrimSpec_GetPrefix(swigCPtr);
		}

		public void SetPrefix(string value)
		{
			SdfPINVOKE.SdfPrimSpec_SetPrefix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfPrimSpec_GetSuffix(swigCPtr);
		}

		public void SetSuffix(string value)
		{
			SdfPINVOKE.SdfPrimSpec_SetSuffix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpec_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpec_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public void SetCustomData(string name, VtValue value)
		{
			SdfPINVOKE.SdfPrimSpec_SetCustomData(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAssetInfo(string name, VtValue value)
		{
			SdfPINVOKE.SdfPrimSpec_SetAssetInfo(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfSpecifier GetSpecifier()
		{
			return (SdfSpecifier)SdfPINVOKE.SdfPrimSpec_GetSpecifier(swigCPtr);
		}

		public void SetSpecifier(SdfSpecifier value)
		{
			SdfPINVOKE.SdfPrimSpec_SetSpecifier(swigCPtr, (int)value);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfPrimSpec_GetPermission(swigCPtr);
		}

		public void SetPermission(SdfPermission value)
		{
			SdfPINVOKE.SdfPrimSpec_SetPermission(swigCPtr, (int)value);
		}

		public VtDictionary GetPrefixSubstitutions()
		{
			return new VtDictionary(SdfPINVOKE.SdfPrimSpec_GetPrefixSubstitutions(swigCPtr), cMemoryOwn: true);
		}

		public void SetPrefixSubstitutions(VtDictionary prefixSubstitutions)
		{
			SdfPINVOKE.SdfPrimSpec_SetPrefixSubstitutions(swigCPtr, VtDictionary.getCPtr(prefixSubstitutions));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDictionary GetSuffixSubstitutions()
		{
			return new VtDictionary(SdfPINVOKE.SdfPrimSpec_GetSuffixSubstitutions(swigCPtr), cMemoryOwn: true);
		}

		public void SetSuffixSubstitutions(VtDictionary suffixSubstitutions)
		{
			SdfPINVOKE.SdfPrimSpec_SetSuffixSubstitutions(swigCPtr, VtDictionary.getCPtr(suffixSubstitutions));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetInstanceable(bool instanceable)
		{
			SdfPINVOKE.SdfPrimSpec_SetInstanceable(swigCPtr, instanceable);
		}

		public bool GetInstanceable()
		{
			return SdfPINVOKE.SdfPrimSpec_GetInstanceable(swigCPtr);
		}

		public bool HasInstanceable()
		{
			return SdfPINVOKE.SdfPrimSpec_HasInstanceable(swigCPtr);
		}

		public void ClearInstanceable()
		{
			SdfPINVOKE.SdfPrimSpec_ClearInstanceable(swigCPtr);
		}

		public SWIGTYPE_p_SdfPayloadsProxy GetPayloadList()
		{
			return new SWIGTYPE_p_SdfPayloadsProxy(SdfPINVOKE.SdfPrimSpec_GetPayloadList(swigCPtr), futureUse: true);
		}

		public bool HasPayloads()
		{
			return SdfPINVOKE.SdfPrimSpec_HasPayloads(swigCPtr);
		}

		public void ClearPayloadList()
		{
			SdfPINVOKE.SdfPrimSpec_ClearPayloadList(swigCPtr);
		}

		public SWIGTYPE_p_SdfInheritsProxy GetInheritPathList()
		{
			return new SWIGTYPE_p_SdfInheritsProxy(SdfPINVOKE.SdfPrimSpec_GetInheritPathList(swigCPtr), futureUse: true);
		}

		public bool HasInheritPaths()
		{
			return SdfPINVOKE.SdfPrimSpec_HasInheritPaths(swigCPtr);
		}

		public void ClearInheritPathList()
		{
			SdfPINVOKE.SdfPrimSpec_ClearInheritPathList(swigCPtr);
		}

		public SWIGTYPE_p_SdfSpecializesProxy GetSpecializesList()
		{
			return new SWIGTYPE_p_SdfSpecializesProxy(SdfPINVOKE.SdfPrimSpec_GetSpecializesList(swigCPtr), futureUse: true);
		}

		public bool HasSpecializes()
		{
			return SdfPINVOKE.SdfPrimSpec_HasSpecializes(swigCPtr);
		}

		public void ClearSpecializesList()
		{
			SdfPINVOKE.SdfPrimSpec_ClearSpecializesList(swigCPtr);
		}

		public SWIGTYPE_p_SdfReferencesProxy GetReferenceList()
		{
			return new SWIGTYPE_p_SdfReferencesProxy(SdfPINVOKE.SdfPrimSpec_GetReferenceList(swigCPtr), futureUse: true);
		}

		public bool HasReferences()
		{
			return SdfPINVOKE.SdfPrimSpec_HasReferences(swigCPtr);
		}

		public void ClearReferenceList()
		{
			SdfPINVOKE.SdfPrimSpec_ClearReferenceList(swigCPtr);
		}

		public SWIGTYPE_p_SdfVariantSetNamesProxy GetVariantSetNameList()
		{
			return new SWIGTYPE_p_SdfVariantSetNamesProxy(SdfPINVOKE.SdfPrimSpec_GetVariantSetNameList(swigCPtr), futureUse: true);
		}

		public bool HasVariantSetNames()
		{
			return SdfPINVOKE.SdfPrimSpec_HasVariantSetNames(swigCPtr);
		}

		public StdStringVector GetVariantNames(string name)
		{
			StdStringVector result = new StdStringVector(SdfPINVOKE.SdfPrimSpec_GetVariantNames(swigCPtr, name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void RemoveVariantSet(string name)
		{
			SdfPINVOKE.SdfPrimSpec_RemoveVariantSet(swigCPtr, name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfVariantSelectionProxy GetVariantSelections()
		{
			return new SWIGTYPE_p_SdfVariantSelectionProxy(SdfPINVOKE.SdfPrimSpec_GetVariantSelections(swigCPtr), futureUse: true);
		}

		public void SetVariantSelection(string variantSetName, string variantName)
		{
			SdfPINVOKE.SdfPrimSpec_SetVariantSelection(swigCPtr, variantSetName, variantName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void BlockVariantSelection(string variantSetName)
		{
			SdfPINVOKE.SdfPrimSpec_BlockVariantSelection(swigCPtr, variantSetName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfRelocatesMapProxy GetRelocates()
		{
			return new SWIGTYPE_p_SdfRelocatesMapProxy(SdfPINVOKE.SdfPrimSpec_GetRelocates(swigCPtr), futureUse: true);
		}

		public void SetRelocates(SdfRelocatesMap newMap)
		{
			SdfPINVOKE.SdfPrimSpec_SetRelocates(swigCPtr, SdfRelocatesMap.getCPtr(newMap));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasRelocates()
		{
			return SdfPINVOKE.SdfPrimSpec_HasRelocates(swigCPtr);
		}

		public void ClearRelocates()
		{
			SdfPINVOKE.SdfPrimSpec_ClearRelocates(swigCPtr);
		}
	}
}
