using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfRelationshipSpecHandle : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfRelationshipSpecHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfRelationshipSpecHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfRelationshipSpecHandle obj)
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

		~SdfRelationshipSpecHandle()
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
						SdfPINVOKE.delete_SdfRelationshipSpecHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfRelationshipSpecHandle()
			: this(SdfPINVOKE.new_SdfRelationshipSpecHandle__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfRelationshipSpecHandle(SdfRelationshipSpec baseType)
			: this(SdfPINVOKE.new_SdfRelationshipSpecHandle__SWIG_1(SdfRelationshipSpec.getCPtr(baseType)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfRelationshipSpecHandle(SdfRelationshipSpecHandle otherHandle)
			: this(SdfPINVOKE.new_SdfRelationshipSpecHandle__SWIG_2(getCPtr(otherHandle)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfRelationshipSpec __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfRelationshipSpecHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfRelationshipSpec(intPtr, cMemoryOwn: false);
		}

		public SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name, bool custom, SdfVariability variability)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfRelationshipSpecHandle_New__SWIG_0(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name, custom, (int)variability), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name, bool custom)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfRelationshipSpecHandle_New__SWIG_1(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name, custom), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfRelationshipSpecHandle_New__SWIG_2(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_SdfTargetsProxy GetTargetPathList()
		{
			return new SWIGTYPE_p_SdfTargetsProxy(SdfPINVOKE.SdfRelationshipSpecHandle_GetTargetPathList(swigCPtr), futureUse: true);
		}

		public bool HasTargetPathList()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_HasTargetPathList(swigCPtr);
		}

		public void ClearTargetPathList()
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_ClearTargetPathList(swigCPtr);
		}

		public void ReplaceTargetPath(SdfPath oldPath, SdfPath newPath)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_ReplaceTargetPath(swigCPtr, SdfPath.getCPtr(oldPath), SdfPath.getCPtr(newPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveTargetPath(SdfPath path, bool preserveTargetOrder)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_RemoveTargetPath__SWIG_0(swigCPtr, SdfPath.getCPtr(path), preserveTargetOrder);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveTargetPath(SdfPath path)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_RemoveTargetPath__SWIG_1(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetNoLoadHint()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetNoLoadHint(swigCPtr);
		}

		public void SetNoLoadHint(bool noload)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetNoLoadHint(swigCPtr, noload);
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfRelationshipSpecHandle_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName, bool validate)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_SetName__SWIG_0(swigCPtr, newName, validate);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_SetName__SWIG_1(swigCPtr, newName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsValidName(string name)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_IsValidName(swigCPtr, name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecHandle GetOwner()
		{
			return new SdfSpecHandle(SdfPINVOKE.SdfRelationshipSpecHandle_GetOwner(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfRelationshipSpecHandle_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfRelationshipSpecHandle_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public void SetCustomData(string name, VtValue value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetCustomData(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAssetInfo(string name, VtValue value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetAssetInfo(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayGroup()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetDisplayGroup(swigCPtr);
		}

		public void SetDisplayGroup(string value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetDisplayGroup(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayName()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetDisplayName(swigCPtr);
		}

		public void SetDisplayName(string value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetDisplayName(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetDocumentation(swigCPtr);
		}

		public void SetDocumentation(string value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetDocumentation(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetHidden(swigCPtr);
		}

		public void SetHidden(bool value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetHidden(swigCPtr, value);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfRelationshipSpecHandle_GetPermission(swigCPtr);
		}

		public void SetPermission(SdfPermission value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetPermission(swigCPtr, (int)value);
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetPrefix(swigCPtr);
		}

		public void SetPrefix(string value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetPrefix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetSuffix(swigCPtr);
		}

		public void SetSuffix(string value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetSuffix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetSymmetricPeer(swigCPtr);
		}

		public void SetSymmetricPeer(string peerName)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetSymmetricPeer(swigCPtr, peerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfRelationshipSpecHandle_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public void SetSymmetryArgument(string name, VtValue value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetSymmetryArgument(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfRelationshipSpecHandle_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public void SetSymmetryFunction(TfToken functionName)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetSymmetryFunction(swigCPtr, TfToken.getCPtr(functionName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t GetTimeSampleMap()
		{
			return new SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(SdfPINVOKE.SdfRelationshipSpecHandle_GetTimeSampleMap(swigCPtr), futureUse: true);
		}

		public TfType GetValueType()
		{
			return new TfType(SdfPINVOKE.SdfRelationshipSpecHandle_GetValueType(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfRelationshipSpecHandle_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		private VtValue GetDefaultValue()
		{
			return new VtValue(SdfPINVOKE.SdfRelationshipSpecHandle_GetDefaultValue(swigCPtr), cMemoryOwn: true);
		}

		private bool SetDefaultValue(VtValue defaultValue)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_SetDefaultValue(swigCPtr, VtValue.getCPtr(defaultValue));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasDefaultValue()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_HasDefaultValue(swigCPtr);
		}

		public void ClearDefaultValue()
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_ClearDefaultValue(swigCPtr);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_GetComment(swigCPtr);
		}

		public void SetComment(string value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetComment(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsCustom()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_IsCustom(swigCPtr);
		}

		public void SetCustom(bool custom)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetCustom(swigCPtr, custom);
		}

		public SdfVariability GetVariability()
		{
			return (SdfVariability)SdfPINVOKE.SdfRelationshipSpecHandle_GetVariability(swigCPtr);
		}

		public bool HasOnlyRequiredFields()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_HasOnlyRequiredFields(swigCPtr);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfRelationshipSpecHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SdfSpecType GetSpecType()
		{
			return (SdfSpecType)SdfPINVOKE.SdfRelationshipSpecHandle_GetSpecType(swigCPtr);
		}

		public bool IsDormant()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_IsDormant(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfRelationshipSpecHandle_GetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfRelationshipSpecHandle_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_PermissionToEdit(swigCPtr);
		}

		public TfTokenVector ListInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfRelationshipSpecHandle_ListInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetMetaDataInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfRelationshipSpecHandle_GetMetaDataInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetMetaDataDisplayGroup(TfToken key)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfRelationshipSpecHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfRelationshipSpecHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetInfo(TfToken key, VtValue value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetInfo(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetInfoDictionaryValue(TfToken dictionaryKey, TfToken entryKey, VtValue value)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_SetInfoDictionaryValue(swigCPtr, TfToken.getCPtr(dictionaryKey), TfToken.getCPtr(entryKey), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasInfo(TfToken key)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearInfo(TfToken key)
		{
			SdfPINVOKE.SdfRelationshipSpecHandle_ClearInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfType GetTypeForInfo(TfToken key)
		{
			TfType result = new TfType(SdfPINVOKE.SdfRelationshipSpecHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFallbackForInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfRelationshipSpecHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInert(bool ignoreChildren)
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
		}

		public bool IsInert()
		{
			return SdfPINVOKE.SdfRelationshipSpecHandle_IsInert__SWIG_1(swigCPtr);
		}

		public TfTokenVector ListFields()
		{
			return new TfTokenVector(SdfPINVOKE.SdfRelationshipSpecHandle_ListFields(swigCPtr), cMemoryOwn: true);
		}

		public bool HasField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_HasField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(TfToken name)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfRelationshipSpecHandle_GetField(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetField(TfToken name, VtValue value)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_SetField(swigCPtr, TfToken.getCPtr(name), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecHandle_ClearField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
