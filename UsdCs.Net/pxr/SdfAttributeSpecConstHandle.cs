using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfAttributeSpecConstHandle : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfAttributeSpecConstHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfAttributeSpecConstHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfAttributeSpecConstHandle obj)
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

		~SdfAttributeSpecConstHandle()
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
						SdfPINVOKE.delete_SdfAttributeSpecConstHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfAttributeSpecConstHandle()
			: this(SdfPINVOKE.new_SdfAttributeSpecConstHandle__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfAttributeSpecConstHandle(SdfAttributeSpec baseType)
			: this(SdfPINVOKE.new_SdfAttributeSpecConstHandle__SWIG_1(SdfAttributeSpec.getCPtr(baseType)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAttributeSpecConstHandle(SdfAttributeSpecHandle otherHandle)
			: this(SdfPINVOKE.new_SdfAttributeSpecConstHandle__SWIG_2(SdfAttributeSpecHandle.getCPtr(otherHandle)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAttributeSpec __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfAttributeSpecConstHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfAttributeSpec(intPtr, cMemoryOwn: false);
		}

		public SWIGTYPE_p_SdfConnectionsProxy GetConnectionPathList()
		{
			return new SWIGTYPE_p_SdfConnectionsProxy(SdfPINVOKE.SdfAttributeSpecConstHandle_GetConnectionPathList(swigCPtr), futureUse: true);
		}

		public bool HasConnectionPaths()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_HasConnectionPaths(swigCPtr);
		}

		public VtTokenArray GetAllowedTokens()
		{
			return new VtTokenArray(SdfPINVOKE.SdfAttributeSpecConstHandle_GetAllowedTokens(swigCPtr), cMemoryOwn: true);
		}

		public bool HasAllowedTokens()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_HasAllowedTokens(swigCPtr);
		}

		public TfEnum GetDisplayUnit()
		{
			return new TfEnum(SdfPINVOKE.SdfAttributeSpecConstHandle_GetDisplayUnit(swigCPtr), cMemoryOwn: true);
		}

		public bool HasDisplayUnit()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_HasDisplayUnit(swigCPtr);
		}

		public TfToken GetColorSpace()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpecConstHandle_GetColorSpace(swigCPtr), cMemoryOwn: true);
		}

		public bool HasColorSpace()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_HasColorSpace(swigCPtr);
		}

		public TfToken GetRoleName()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpecConstHandle_GetRoleName(swigCPtr), cMemoryOwn: true);
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpecConstHandle_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecConstHandle_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecHandle GetOwner()
		{
			return new SdfSpecHandle(SdfPINVOKE.SdfAttributeSpecConstHandle_GetOwner(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfAttributeSpecConstHandle_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfAttributeSpecConstHandle_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public string GetDisplayGroup()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetDisplayGroup(swigCPtr);
		}

		public string GetDisplayName()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetDisplayName(swigCPtr);
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetDocumentation(swigCPtr);
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetHidden(swigCPtr);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfAttributeSpecConstHandle_GetPermission(swigCPtr);
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetPrefix(swigCPtr);
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetSuffix(swigCPtr);
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetSymmetricPeer(swigCPtr);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfAttributeSpecConstHandle_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpecConstHandle_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t GetTimeSampleMap()
		{
			return new SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(SdfPINVOKE.SdfAttributeSpecConstHandle_GetTimeSampleMap(swigCPtr), futureUse: true);
		}

		public TfType GetValueType()
		{
			return new TfType(SdfPINVOKE.SdfAttributeSpecConstHandle_GetValueType(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfAttributeSpecConstHandle_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		private VtValue GetDefaultValue()
		{
			return new VtValue(SdfPINVOKE.SdfAttributeSpecConstHandle_GetDefaultValue(swigCPtr), cMemoryOwn: true);
		}

		public bool HasDefaultValue()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_HasDefaultValue(swigCPtr);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_GetComment(swigCPtr);
		}

		public bool IsCustom()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_IsCustom(swigCPtr);
		}

		public SdfVariability GetVariability()
		{
			return (SdfVariability)SdfPINVOKE.SdfAttributeSpecConstHandle_GetVariability(swigCPtr);
		}

		public bool HasOnlyRequiredFields()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_HasOnlyRequiredFields(swigCPtr);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfAttributeSpecConstHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SdfSpecType GetSpecType()
		{
			return (SdfSpecType)SdfPINVOKE.SdfAttributeSpecConstHandle_GetSpecType(swigCPtr);
		}

		public bool IsDormant()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_IsDormant(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfAttributeSpecConstHandle_GetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfAttributeSpecConstHandle_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_PermissionToEdit(swigCPtr);
		}

		public TfTokenVector ListInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfAttributeSpecConstHandle_ListInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetMetaDataInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfAttributeSpecConstHandle_GetMetaDataInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetMetaDataDisplayGroup(TfToken key)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfAttributeSpecConstHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfAttributeSpecConstHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasInfo(TfToken key)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecConstHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfType GetTypeForInfo(TfToken key)
		{
			TfType result = new TfType(SdfPINVOKE.SdfAttributeSpecConstHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFallbackForInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfAttributeSpecConstHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInert(bool ignoreChildren)
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
		}

		public bool IsInert()
		{
			return SdfPINVOKE.SdfAttributeSpecConstHandle_IsInert__SWIG_1(swigCPtr);
		}

		public TfTokenVector ListFields()
		{
			return new TfTokenVector(SdfPINVOKE.SdfAttributeSpecConstHandle_ListFields(swigCPtr), cMemoryOwn: true);
		}

		public bool HasField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfAttributeSpecConstHandle_HasField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(TfToken name)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfAttributeSpecConstHandle_GetField(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
