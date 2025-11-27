using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPrimSpecHandle : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfPrimSpecHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPrimSpecHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPrimSpecHandle obj)
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

		~SdfPrimSpecHandle()
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
						SdfPINVOKE.delete_SdfPrimSpecHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPrimSpecHandle()
			: this(SdfPINVOKE.new_SdfPrimSpecHandle__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPrimSpecHandle(SdfPrimSpec baseType)
			: this(SdfPINVOKE.new_SdfPrimSpecHandle__SWIG_1(SdfPrimSpec.getCPtr(baseType)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPrimSpecHandle(SdfPrimSpecHandle otherHandle)
			: this(SdfPINVOKE.new_SdfPrimSpecHandle__SWIG_2(getCPtr(otherHandle)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPrimSpec __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfPrimSpecHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfPrimSpec(intPtr, cMemoryOwn: false);
		}

		public SdfPrimSpecHandle New(SdfLayerHandle parentLayer, string name, SdfSpecifier spec, string typeName)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_New__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(parentLayer), name, (int)spec, typeName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle New(SdfLayerHandle parentLayer, string name, SdfSpecifier spec)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_New__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(parentLayer), name, (int)spec), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle New(SdfPrimSpecHandle parentPrim, string name, SdfSpecifier spec, string typeName)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_New__SWIG_2(swigCPtr, getCPtr(parentPrim), name, (int)spec, typeName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle New(SdfPrimSpecHandle parentPrim, string name, SdfSpecifier spec)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_New__SWIG_3(swigCPtr, getCPtr(parentPrim), name, (int)spec), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpecHandle_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName, bool validate)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_SetName__SWIG_0(swigCPtr, newName, validate);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_SetName__SWIG_1(swigCPtr, newName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsValidName(string name)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_IsValidName(swigCPtr, name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetNameRoot()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_GetNameRoot(swigCPtr), cMemoryOwn: true);
		}

		public SdfPrimSpecHandle GetNameParent()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_GetNameParent(swigCPtr), cMemoryOwn: true);
		}

		public SdfPrimSpecHandle GetRealNameParent()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_GetRealNameParent(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfPrimSpecView GetNameChildren()
		{
			return new SWIGTYPE_p_SdfPrimSpecView(SdfPINVOKE.SdfPrimSpecHandle_GetNameChildren(swigCPtr), futureUse: true);
		}

		public void SetNameChildren(SdfPrimSpecHandleVector arg0)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetNameChildren(swigCPtr, SdfPrimSpecHandleVector.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool InsertNameChild(SdfPrimSpecHandle child, int index)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_InsertNameChild__SWIG_0(swigCPtr, getCPtr(child), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool InsertNameChild(SdfPrimSpecHandle child)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_InsertNameChild__SWIG_1(swigCPtr, getCPtr(child));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveNameChild(SdfPrimSpecHandle child)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_RemoveNameChild(swigCPtr, getCPtr(child));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasNameChildrenOrder()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasNameChildrenOrder(swigCPtr);
		}

		public void SetNameChildrenOrder(TfTokenVector names)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetNameChildrenOrder(swigCPtr, TfTokenVector.getCPtr(names));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInNameChildrenOrder(TfToken name, int index)
		{
			SdfPINVOKE.SdfPrimSpecHandle_InsertInNameChildrenOrder__SWIG_0(swigCPtr, TfToken.getCPtr(name), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInNameChildrenOrder(TfToken name)
		{
			SdfPINVOKE.SdfPrimSpecHandle_InsertInNameChildrenOrder__SWIG_1(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromNameChildrenOrder(TfToken name)
		{
			SdfPINVOKE.SdfPrimSpecHandle_RemoveFromNameChildrenOrder(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromNameChildrenOrderByIndex(int index)
		{
			SdfPINVOKE.SdfPrimSpecHandle_RemoveFromNameChildrenOrderByIndex(swigCPtr, index);
		}

		public void ApplyNameChildrenOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfPrimSpecHandle_ApplyNameChildrenOrder(swigCPtr, TfTokenVector.getCPtr(vec));
		}

		public SWIGTYPE_p_SdfPropertySpecView GetProperties()
		{
			return new SWIGTYPE_p_SdfPropertySpecView(SdfPINVOKE.SdfPrimSpecHandle_GetProperties(swigCPtr), futureUse: true);
		}

		public void SetProperties(SdfPropertySpecHandleVector arg0)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetProperties(swigCPtr, SdfPropertySpecHandleVector.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool InsertProperty(SdfPropertySpecHandle property, int index)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_InsertProperty__SWIG_0(swigCPtr, SdfPropertySpecHandle.getCPtr(property), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool InsertProperty(SdfPropertySpecHandle property)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_InsertProperty__SWIG_1(swigCPtr, SdfPropertySpecHandle.getCPtr(property));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void RemoveProperty(SdfPropertySpecHandle property)
		{
			SdfPINVOKE.SdfPrimSpecHandle_RemoveProperty(swigCPtr, SdfPropertySpecHandle.getCPtr(property));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfAttributeSpecView GetAttributes()
		{
			return new SWIGTYPE_p_SdfAttributeSpecView(SdfPINVOKE.SdfPrimSpecHandle_GetAttributes(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfRelationshipSpecView GetRelationships()
		{
			return new SWIGTYPE_p_SdfRelationshipSpecView(SdfPINVOKE.SdfPrimSpecHandle_GetRelationships(swigCPtr), futureUse: true);
		}

		public bool HasPropertyOrder()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasPropertyOrder(swigCPtr);
		}

		public void SetPropertyOrder(TfTokenVector names)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetPropertyOrder(swigCPtr, TfTokenVector.getCPtr(names));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInPropertyOrder(TfToken name, int index)
		{
			SdfPINVOKE.SdfPrimSpecHandle_InsertInPropertyOrder__SWIG_0(swigCPtr, TfToken.getCPtr(name), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInPropertyOrder(TfToken name)
		{
			SdfPINVOKE.SdfPrimSpecHandle_InsertInPropertyOrder__SWIG_1(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromPropertyOrder(TfToken name)
		{
			SdfPINVOKE.SdfPrimSpecHandle_RemoveFromPropertyOrder(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromPropertyOrderByIndex(int index)
		{
			SdfPINVOKE.SdfPrimSpecHandle_RemoveFromPropertyOrderByIndex(swigCPtr, index);
		}

		public void ApplyPropertyOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfPrimSpecHandle_ApplyPropertyOrder(swigCPtr, TfTokenVector.getCPtr(vec));
		}

		public SdfSpecHandle GetObjectAtPath(SdfPath path)
		{
			SdfSpecHandle result = new SdfSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_GetObjectAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetPrimAtPath(SdfPath path)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_GetPrimAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPropertySpecHandle GetPropertyAtPath(SdfPath path)
		{
			SdfPropertySpecHandle result = new SdfPropertySpecHandle(SdfPINVOKE.SdfPrimSpecHandle_GetPropertyAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAttributeSpecHandle GetAttributeAtPath(SdfPath path)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_GetAttributeAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelationshipSpecHandle GetRelationshipAtPath(SdfPath path)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfPrimSpecHandle_GetRelationshipAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetTypeName()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpecHandle_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		public void SetTypeName(string value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetTypeName(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetComment(swigCPtr);
		}

		public void SetComment(string value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetComment(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetDocumentation(swigCPtr);
		}

		public void SetDocumentation(string value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetDocumentation(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetActive()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetActive(swigCPtr);
		}

		public void SetActive(bool value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetActive(swigCPtr, value);
		}

		public bool HasActive()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasActive(swigCPtr);
		}

		public void ClearActive()
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearActive(swigCPtr);
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetHidden(swigCPtr);
		}

		public void SetHidden(bool value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetHidden(swigCPtr, value);
		}

		public TfToken GetKind()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpecHandle_GetKind(swigCPtr), cMemoryOwn: true);
		}

		public void SetKind(TfToken value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetKind(swigCPtr, TfToken.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKind()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasKind(swigCPtr);
		}

		public void ClearKind()
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearKind(swigCPtr);
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfPrimSpecHandle_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public void SetSymmetryFunction(TfToken functionName)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetSymmetryFunction(swigCPtr, TfToken.getCPtr(functionName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpecHandle_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public void SetSymmetryArgument(string name, VtValue value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetSymmetryArgument(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetSymmetricPeer(swigCPtr);
		}

		public void SetSymmetricPeer(string peerName)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetSymmetricPeer(swigCPtr, peerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetPrefix(swigCPtr);
		}

		public void SetPrefix(string value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetPrefix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetSuffix(swigCPtr);
		}

		public void SetSuffix(string value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetSuffix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpecHandle_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPrimSpecHandle_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public void SetCustomData(string name, VtValue value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetCustomData(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAssetInfo(string name, VtValue value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetAssetInfo(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfSpecifier GetSpecifier()
		{
			return (SdfSpecifier)SdfPINVOKE.SdfPrimSpecHandle_GetSpecifier(swigCPtr);
		}

		public void SetSpecifier(SdfSpecifier value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetSpecifier(swigCPtr, (int)value);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfPrimSpecHandle_GetPermission(swigCPtr);
		}

		public void SetPermission(SdfPermission value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetPermission(swigCPtr, (int)value);
		}

		public VtDictionary GetPrefixSubstitutions()
		{
			return new VtDictionary(SdfPINVOKE.SdfPrimSpecHandle_GetPrefixSubstitutions(swigCPtr), cMemoryOwn: true);
		}

		public void SetPrefixSubstitutions(VtDictionary prefixSubstitutions)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetPrefixSubstitutions(swigCPtr, VtDictionary.getCPtr(prefixSubstitutions));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDictionary GetSuffixSubstitutions()
		{
			return new VtDictionary(SdfPINVOKE.SdfPrimSpecHandle_GetSuffixSubstitutions(swigCPtr), cMemoryOwn: true);
		}

		public void SetSuffixSubstitutions(VtDictionary suffixSubstitutions)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetSuffixSubstitutions(swigCPtr, VtDictionary.getCPtr(suffixSubstitutions));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetInstanceable(bool instanceable)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetInstanceable(swigCPtr, instanceable);
		}

		public bool GetInstanceable()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_GetInstanceable(swigCPtr);
		}

		public bool HasInstanceable()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasInstanceable(swigCPtr);
		}

		public void ClearInstanceable()
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearInstanceable(swigCPtr);
		}

		public SWIGTYPE_p_SdfPayloadsProxy GetPayloadList()
		{
			return new SWIGTYPE_p_SdfPayloadsProxy(SdfPINVOKE.SdfPrimSpecHandle_GetPayloadList(swigCPtr), futureUse: true);
		}

		public bool HasPayloads()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasPayloads(swigCPtr);
		}

		public void ClearPayloadList()
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearPayloadList(swigCPtr);
		}

		public SWIGTYPE_p_SdfInheritsProxy GetInheritPathList()
		{
			return new SWIGTYPE_p_SdfInheritsProxy(SdfPINVOKE.SdfPrimSpecHandle_GetInheritPathList(swigCPtr), futureUse: true);
		}

		public bool HasInheritPaths()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasInheritPaths(swigCPtr);
		}

		public void ClearInheritPathList()
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearInheritPathList(swigCPtr);
		}

		public SWIGTYPE_p_SdfSpecializesProxy GetSpecializesList()
		{
			return new SWIGTYPE_p_SdfSpecializesProxy(SdfPINVOKE.SdfPrimSpecHandle_GetSpecializesList(swigCPtr), futureUse: true);
		}

		public bool HasSpecializes()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasSpecializes(swigCPtr);
		}

		public void ClearSpecializesList()
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearSpecializesList(swigCPtr);
		}

		public SWIGTYPE_p_SdfReferencesProxy GetReferenceList()
		{
			return new SWIGTYPE_p_SdfReferencesProxy(SdfPINVOKE.SdfPrimSpecHandle_GetReferenceList(swigCPtr), futureUse: true);
		}

		public bool HasReferences()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasReferences(swigCPtr);
		}

		public void ClearReferenceList()
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearReferenceList(swigCPtr);
		}

		public SWIGTYPE_p_SdfVariantSetNamesProxy GetVariantSetNameList()
		{
			return new SWIGTYPE_p_SdfVariantSetNamesProxy(SdfPINVOKE.SdfPrimSpecHandle_GetVariantSetNameList(swigCPtr), futureUse: true);
		}

		public bool HasVariantSetNames()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasVariantSetNames(swigCPtr);
		}

		public StdStringVector GetVariantNames(string name)
		{
			StdStringVector result = new StdStringVector(SdfPINVOKE.SdfPrimSpecHandle_GetVariantNames(swigCPtr, name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void RemoveVariantSet(string name)
		{
			SdfPINVOKE.SdfPrimSpecHandle_RemoveVariantSet(swigCPtr, name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfVariantSelectionProxy GetVariantSelections()
		{
			return new SWIGTYPE_p_SdfVariantSelectionProxy(SdfPINVOKE.SdfPrimSpecHandle_GetVariantSelections(swigCPtr), futureUse: true);
		}

		public void SetVariantSelection(string variantSetName, string variantName)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetVariantSelection(swigCPtr, variantSetName, variantName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void BlockVariantSelection(string variantSetName)
		{
			SdfPINVOKE.SdfPrimSpecHandle_BlockVariantSelection(swigCPtr, variantSetName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfRelocatesMapProxy GetRelocates()
		{
			return new SWIGTYPE_p_SdfRelocatesMapProxy(SdfPINVOKE.SdfPrimSpecHandle_GetRelocates(swigCPtr), futureUse: true);
		}

		public void SetRelocates(SdfRelocatesMap newMap)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetRelocates(swigCPtr, SdfRelocatesMap.getCPtr(newMap));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasRelocates()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_HasRelocates(swigCPtr);
		}

		public void ClearRelocates()
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearRelocates(swigCPtr);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfPrimSpecHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SdfSpecType GetSpecType()
		{
			return (SdfSpecType)SdfPINVOKE.SdfPrimSpecHandle_GetSpecType(swigCPtr);
		}

		public bool IsDormant()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_IsDormant(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfPrimSpecHandle_GetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPrimSpecHandle_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_PermissionToEdit(swigCPtr);
		}

		public TfTokenVector ListInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPrimSpecHandle_ListInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetMetaDataInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPrimSpecHandle_GetMetaDataInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetMetaDataDisplayGroup(TfToken key)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfPrimSpecHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPrimSpecHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetInfo(TfToken key, VtValue value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetInfo(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetInfoDictionaryValue(TfToken dictionaryKey, TfToken entryKey, VtValue value)
		{
			SdfPINVOKE.SdfPrimSpecHandle_SetInfoDictionaryValue(swigCPtr, TfToken.getCPtr(dictionaryKey), TfToken.getCPtr(entryKey), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasInfo(TfToken key)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearInfo(TfToken key)
		{
			SdfPINVOKE.SdfPrimSpecHandle_ClearInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfType GetTypeForInfo(TfToken key)
		{
			TfType result = new TfType(SdfPINVOKE.SdfPrimSpecHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFallbackForInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPrimSpecHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInert(bool ignoreChildren)
		{
			return SdfPINVOKE.SdfPrimSpecHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
		}

		public bool IsInert()
		{
			return SdfPINVOKE.SdfPrimSpecHandle_IsInert__SWIG_1(swigCPtr);
		}

		public TfTokenVector ListFields()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPrimSpecHandle_ListFields(swigCPtr), cMemoryOwn: true);
		}

		public bool HasField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_HasField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(TfToken name)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPrimSpecHandle_GetField(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetField(TfToken name, VtValue value)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_SetField(swigCPtr, TfToken.getCPtr(name), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfPrimSpecHandle_ClearField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
