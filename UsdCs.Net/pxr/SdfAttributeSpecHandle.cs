using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfAttributeSpecHandle : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string @default
		{
			get
			{
				return GetDefaultValue();
			}
			set
			{
				SetDefaultValue(value);
			}
		}

		public SdfAttributeSpecHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfAttributeSpecHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfAttributeSpecHandle obj)
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

		~SdfAttributeSpecHandle()
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
						SdfPINVOKE.delete_SdfAttributeSpecHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfAttributeSpecHandle()
			: this(SdfPINVOKE.new_SdfAttributeSpecHandle__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfAttributeSpecHandle(SdfAttributeSpec baseType)
			: this(SdfPINVOKE.new_SdfAttributeSpecHandle__SWIG_1(SdfAttributeSpec.getCPtr(baseType)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAttributeSpecHandle(SdfAttributeSpecHandle otherHandle)
			: this(SdfPINVOKE.new_SdfAttributeSpecHandle__SWIG_2(getCPtr(otherHandle)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAttributeSpec __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfAttributeSpecHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfAttributeSpec(intPtr, cMemoryOwn: false);
		}

		public SdfAttributeSpecHandle New(SdfPrimSpecHandle owner, string name, SdfValueTypeName typeName, SdfVariability variability, bool custom)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfAttributeSpecHandle_New__SWIG_0(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name, SdfValueTypeName.getCPtr(typeName), (int)variability, custom), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAttributeSpecHandle New(SdfPrimSpecHandle owner, string name, SdfValueTypeName typeName, SdfVariability variability)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfAttributeSpecHandle_New__SWIG_1(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name, SdfValueTypeName.getCPtr(typeName), (int)variability), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAttributeSpecHandle New(SdfPrimSpecHandle owner, string name, SdfValueTypeName typeName)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfAttributeSpecHandle_New__SWIG_2(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name, SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_SdfConnectionsProxy GetConnectionPathList()
		{
			return new SWIGTYPE_p_SdfConnectionsProxy(SdfPINVOKE.SdfAttributeSpecHandle_GetConnectionPathList(swigCPtr), futureUse: true);
		}

		public bool HasConnectionPaths()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_HasConnectionPaths(swigCPtr);
		}

		public void ClearConnectionPaths()
		{
			SdfPINVOKE.SdfAttributeSpecHandle_ClearConnectionPaths(swigCPtr);
		}

		public VtTokenArray GetAllowedTokens()
		{
			return new VtTokenArray(SdfPINVOKE.SdfAttributeSpecHandle_GetAllowedTokens(swigCPtr), cMemoryOwn: true);
		}

		public void SetAllowedTokens(VtTokenArray allowedTokens)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetAllowedTokens(swigCPtr, VtTokenArray.getCPtr(allowedTokens));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasAllowedTokens()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_HasAllowedTokens(swigCPtr);
		}

		public void ClearAllowedTokens()
		{
			SdfPINVOKE.SdfAttributeSpecHandle_ClearAllowedTokens(swigCPtr);
		}

		public TfEnum GetDisplayUnit()
		{
			return new TfEnum(SdfPINVOKE.SdfAttributeSpecHandle_GetDisplayUnit(swigCPtr), cMemoryOwn: true);
		}

		public void SetDisplayUnit(TfEnum displayUnit)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetDisplayUnit(swigCPtr, TfEnum.getCPtr(displayUnit));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasDisplayUnit()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_HasDisplayUnit(swigCPtr);
		}

		public void ClearDisplayUnit()
		{
			SdfPINVOKE.SdfAttributeSpecHandle_ClearDisplayUnit(swigCPtr);
		}

		public TfToken GetColorSpace()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpecHandle_GetColorSpace(swigCPtr), cMemoryOwn: true);
		}

		public void SetColorSpace(TfToken colorSpace)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetColorSpace(swigCPtr, TfToken.getCPtr(colorSpace));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasColorSpace()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_HasColorSpace(swigCPtr);
		}

		public void ClearColorSpace()
		{
			SdfPINVOKE.SdfAttributeSpecHandle_ClearColorSpace(swigCPtr);
		}

		public TfToken GetRoleName()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpecHandle_GetRoleName(swigCPtr), cMemoryOwn: true);
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpecHandle_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName, bool validate)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_SetName__SWIG_0(swigCPtr, newName, validate);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_SetName__SWIG_1(swigCPtr, newName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsValidName(string name)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_IsValidName(swigCPtr, name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecHandle GetOwner()
		{
			return new SdfSpecHandle(SdfPINVOKE.SdfAttributeSpecHandle_GetOwner(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfAttributeSpecHandle_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfAttributeSpecHandle_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public void SetCustomData(string name, VtValue value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetCustomData(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAssetInfo(string name, VtValue value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetAssetInfo(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayGroup()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetDisplayGroup(swigCPtr);
		}

		public void SetDisplayGroup(string value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetDisplayGroup(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayName()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetDisplayName(swigCPtr);
		}

		public void SetDisplayName(string value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetDisplayName(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetDocumentation(swigCPtr);
		}

		public void SetDocumentation(string value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetDocumentation(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetHidden(swigCPtr);
		}

		public void SetHidden(bool value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetHidden(swigCPtr, value);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfAttributeSpecHandle_GetPermission(swigCPtr);
		}

		public void SetPermission(SdfPermission value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetPermission(swigCPtr, (int)value);
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetPrefix(swigCPtr);
		}

		public void SetPrefix(string value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetPrefix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetSuffix(swigCPtr);
		}

		public void SetSuffix(string value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetSuffix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetSymmetricPeer(swigCPtr);
		}

		public void SetSymmetricPeer(string peerName)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetSymmetricPeer(swigCPtr, peerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfAttributeSpecHandle_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public void SetSymmetryArgument(string name, VtValue value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetSymmetryArgument(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpecHandle_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public void SetSymmetryFunction(TfToken functionName)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetSymmetryFunction(swigCPtr, TfToken.getCPtr(functionName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t GetTimeSampleMap()
		{
			return new SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(SdfPINVOKE.SdfAttributeSpecHandle_GetTimeSampleMap(swigCPtr), futureUse: true);
		}

		public TfType GetValueType()
		{
			return new TfType(SdfPINVOKE.SdfAttributeSpecHandle_GetValueType(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfAttributeSpecHandle_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		private VtValue GetDefaultValue()
		{
			return new VtValue(SdfPINVOKE.SdfAttributeSpecHandle_GetDefaultValue(swigCPtr), cMemoryOwn: true);
		}

		private bool SetDefaultValue(VtValue defaultValue)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_SetDefaultValue(swigCPtr, VtValue.getCPtr(defaultValue));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasDefaultValue()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_HasDefaultValue(swigCPtr);
		}

		public void ClearDefaultValue()
		{
			SdfPINVOKE.SdfAttributeSpecHandle_ClearDefaultValue(swigCPtr);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_GetComment(swigCPtr);
		}

		public void SetComment(string value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetComment(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsCustom()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_IsCustom(swigCPtr);
		}

		public void SetCustom(bool custom)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetCustom(swigCPtr, custom);
		}

		public SdfVariability GetVariability()
		{
			return (SdfVariability)SdfPINVOKE.SdfAttributeSpecHandle_GetVariability(swigCPtr);
		}

		public bool HasOnlyRequiredFields()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_HasOnlyRequiredFields(swigCPtr);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfAttributeSpecHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SdfSpecType GetSpecType()
		{
			return (SdfSpecType)SdfPINVOKE.SdfAttributeSpecHandle_GetSpecType(swigCPtr);
		}

		public bool IsDormant()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_IsDormant(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfAttributeSpecHandle_GetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfAttributeSpecHandle_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_PermissionToEdit(swigCPtr);
		}

		public TfTokenVector ListInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfAttributeSpecHandle_ListInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetMetaDataInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfAttributeSpecHandle_GetMetaDataInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetMetaDataDisplayGroup(TfToken key)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfAttributeSpecHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfAttributeSpecHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetInfo(TfToken key, VtValue value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetInfo(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetInfoDictionaryValue(TfToken dictionaryKey, TfToken entryKey, VtValue value)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_SetInfoDictionaryValue(swigCPtr, TfToken.getCPtr(dictionaryKey), TfToken.getCPtr(entryKey), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasInfo(TfToken key)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearInfo(TfToken key)
		{
			SdfPINVOKE.SdfAttributeSpecHandle_ClearInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfType GetTypeForInfo(TfToken key)
		{
			TfType result = new TfType(SdfPINVOKE.SdfAttributeSpecHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFallbackForInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfAttributeSpecHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInert(bool ignoreChildren)
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
		}

		public bool IsInert()
		{
			return SdfPINVOKE.SdfAttributeSpecHandle_IsInert__SWIG_1(swigCPtr);
		}

		public TfTokenVector ListFields()
		{
			return new TfTokenVector(SdfPINVOKE.SdfAttributeSpecHandle_ListFields(swigCPtr), cMemoryOwn: true);
		}

		public bool HasField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_HasField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(TfToken name)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfAttributeSpecHandle_GetField(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetField(TfToken name, VtValue value)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_SetField(swigCPtr, TfToken.getCPtr(name), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecHandle_ClearField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
