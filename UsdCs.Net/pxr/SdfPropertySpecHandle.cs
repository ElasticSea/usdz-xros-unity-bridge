using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPropertySpecHandle : IDisposable
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

		public SdfPropertySpecHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPropertySpecHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPropertySpecHandle obj)
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

		~SdfPropertySpecHandle()
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
						SdfPINVOKE.delete_SdfPropertySpecHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPropertySpecHandle()
			: this(SdfPINVOKE.new_SdfPropertySpecHandle__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPropertySpecHandle(SdfPropertySpec baseType)
			: this(SdfPINVOKE.new_SdfPropertySpecHandle__SWIG_1(SdfPropertySpec.getCPtr(baseType)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPropertySpecHandle(SdfPropertySpecHandle otherHandle)
			: this(SdfPINVOKE.new_SdfPropertySpecHandle__SWIG_2(getCPtr(otherHandle)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPropertySpec __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfPropertySpecHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfPropertySpec(intPtr, cMemoryOwn: false);
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfPropertySpecHandle_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName, bool validate)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_SetName__SWIG_0(swigCPtr, newName, validate);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_SetName__SWIG_1(swigCPtr, newName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsValidName(string name)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_IsValidName(swigCPtr, name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecHandle GetOwner()
		{
			return new SdfSpecHandle(SdfPINVOKE.SdfPropertySpecHandle_GetOwner(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPropertySpecHandle_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPropertySpecHandle_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public void SetCustomData(string name, VtValue value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetCustomData(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAssetInfo(string name, VtValue value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetAssetInfo(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayGroup()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetDisplayGroup(swigCPtr);
		}

		public void SetDisplayGroup(string value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetDisplayGroup(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayName()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetDisplayName(swigCPtr);
		}

		public void SetDisplayName(string value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetDisplayName(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetDocumentation(swigCPtr);
		}

		public void SetDocumentation(string value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetDocumentation(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetHidden(swigCPtr);
		}

		public void SetHidden(bool value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetHidden(swigCPtr, value);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfPropertySpecHandle_GetPermission(swigCPtr);
		}

		public void SetPermission(SdfPermission value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetPermission(swigCPtr, (int)value);
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetPrefix(swigCPtr);
		}

		public void SetPrefix(string value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetPrefix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetSuffix(swigCPtr);
		}

		public void SetSuffix(string value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetSuffix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetSymmetricPeer(swigCPtr);
		}

		public void SetSymmetricPeer(string peerName)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetSymmetricPeer(swigCPtr, peerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPropertySpecHandle_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public void SetSymmetryArgument(string name, VtValue value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetSymmetryArgument(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfPropertySpecHandle_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public void SetSymmetryFunction(TfToken functionName)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetSymmetryFunction(swigCPtr, TfToken.getCPtr(functionName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t GetTimeSampleMap()
		{
			return new SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(SdfPINVOKE.SdfPropertySpecHandle_GetTimeSampleMap(swigCPtr), futureUse: true);
		}

		public TfType GetValueType()
		{
			return new TfType(SdfPINVOKE.SdfPropertySpecHandle_GetValueType(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfPropertySpecHandle_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		private VtValue GetDefaultValue()
		{
			return new VtValue(SdfPINVOKE.SdfPropertySpecHandle_GetDefaultValue(swigCPtr), cMemoryOwn: true);
		}

		private bool SetDefaultValue(VtValue defaultValue)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_SetDefaultValue(swigCPtr, VtValue.getCPtr(defaultValue));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasDefaultValue()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_HasDefaultValue(swigCPtr);
		}

		public void ClearDefaultValue()
		{
			SdfPINVOKE.SdfPropertySpecHandle_ClearDefaultValue(swigCPtr);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_GetComment(swigCPtr);
		}

		public void SetComment(string value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetComment(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsCustom()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_IsCustom(swigCPtr);
		}

		public void SetCustom(bool custom)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetCustom(swigCPtr, custom);
		}

		public SdfVariability GetVariability()
		{
			return (SdfVariability)SdfPINVOKE.SdfPropertySpecHandle_GetVariability(swigCPtr);
		}

		public bool HasOnlyRequiredFields()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_HasOnlyRequiredFields(swigCPtr);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfPropertySpecHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SdfSpecType GetSpecType()
		{
			return (SdfSpecType)SdfPINVOKE.SdfPropertySpecHandle_GetSpecType(swigCPtr);
		}

		public bool IsDormant()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_IsDormant(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfPropertySpecHandle_GetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPropertySpecHandle_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_PermissionToEdit(swigCPtr);
		}

		public TfTokenVector ListInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPropertySpecHandle_ListInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetMetaDataInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPropertySpecHandle_GetMetaDataInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetMetaDataDisplayGroup(TfToken key)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfPropertySpecHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPropertySpecHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetInfo(TfToken key, VtValue value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetInfo(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetInfoDictionaryValue(TfToken dictionaryKey, TfToken entryKey, VtValue value)
		{
			SdfPINVOKE.SdfPropertySpecHandle_SetInfoDictionaryValue(swigCPtr, TfToken.getCPtr(dictionaryKey), TfToken.getCPtr(entryKey), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasInfo(TfToken key)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearInfo(TfToken key)
		{
			SdfPINVOKE.SdfPropertySpecHandle_ClearInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfType GetTypeForInfo(TfToken key)
		{
			TfType result = new TfType(SdfPINVOKE.SdfPropertySpecHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFallbackForInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPropertySpecHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInert(bool ignoreChildren)
		{
			return SdfPINVOKE.SdfPropertySpecHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
		}

		public bool IsInert()
		{
			return SdfPINVOKE.SdfPropertySpecHandle_IsInert__SWIG_1(swigCPtr);
		}

		public TfTokenVector ListFields()
		{
			return new TfTokenVector(SdfPINVOKE.SdfPropertySpecHandle_ListFields(swigCPtr), cMemoryOwn: true);
		}

		public bool HasField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_HasField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(TfToken name)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfPropertySpecHandle_GetField(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetField(TfToken name, VtValue value)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_SetField(swigCPtr, TfToken.getCPtr(name), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfPropertySpecHandle_ClearField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
