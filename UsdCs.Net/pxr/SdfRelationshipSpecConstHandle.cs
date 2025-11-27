using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfRelationshipSpecConstHandle : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfRelationshipSpecConstHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfRelationshipSpecConstHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfRelationshipSpecConstHandle obj)
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

		~SdfRelationshipSpecConstHandle()
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
						SdfPINVOKE.delete_SdfRelationshipSpecConstHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfRelationshipSpecConstHandle()
			: this(SdfPINVOKE.new_SdfRelationshipSpecConstHandle__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfRelationshipSpecConstHandle(SdfRelationshipSpec baseType)
			: this(SdfPINVOKE.new_SdfRelationshipSpecConstHandle__SWIG_1(SdfRelationshipSpec.getCPtr(baseType)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfRelationshipSpecConstHandle(SdfRelationshipSpecHandle otherHandle)
			: this(SdfPINVOKE.new_SdfRelationshipSpecConstHandle__SWIG_2(SdfRelationshipSpecHandle.getCPtr(otherHandle)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfRelationshipSpec __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfRelationshipSpecConstHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfRelationshipSpec(intPtr, cMemoryOwn: false);
		}

		public SWIGTYPE_p_SdfTargetsProxy GetTargetPathList()
		{
			return new SWIGTYPE_p_SdfTargetsProxy(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetTargetPathList(swigCPtr), futureUse: true);
		}

		public bool HasTargetPathList()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_HasTargetPathList(swigCPtr);
		}

		public void ClearTargetPathList()
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandle_ClearTargetPathList(swigCPtr);
		}

		public bool GetNoLoadHint()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetNoLoadHint(swigCPtr);
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecConstHandle_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecHandle GetOwner()
		{
			return new SdfSpecHandle(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetOwner(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public string GetDisplayGroup()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetDisplayGroup(swigCPtr);
		}

		public string GetDisplayName()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetDisplayName(swigCPtr);
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetDocumentation(swigCPtr);
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetHidden(swigCPtr);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfRelationshipSpecConstHandle_GetPermission(swigCPtr);
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetPrefix(swigCPtr);
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetSuffix(swigCPtr);
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetSymmetricPeer(swigCPtr);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t GetTimeSampleMap()
		{
			return new SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetTimeSampleMap(swigCPtr), futureUse: true);
		}

		public TfType GetValueType()
		{
			return new TfType(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetValueType(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		private VtValue GetDefaultValue()
		{
			return new VtValue(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetDefaultValue(swigCPtr), cMemoryOwn: true);
		}

		public bool HasDefaultValue()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_HasDefaultValue(swigCPtr);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_GetComment(swigCPtr);
		}

		public bool IsCustom()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_IsCustom(swigCPtr);
		}

		public SdfVariability GetVariability()
		{
			return (SdfVariability)SdfPINVOKE.SdfRelationshipSpecConstHandle_GetVariability(swigCPtr);
		}

		public bool HasOnlyRequiredFields()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_HasOnlyRequiredFields(swigCPtr);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SdfSpecType GetSpecType()
		{
			return (SdfSpecType)SdfPINVOKE.SdfRelationshipSpecConstHandle_GetSpecType(swigCPtr);
		}

		public bool IsDormant()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_IsDormant(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_PermissionToEdit(swigCPtr);
		}

		public TfTokenVector ListInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfRelationshipSpecConstHandle_ListInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetMetaDataInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetMetaDataInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetMetaDataDisplayGroup(TfToken key)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasInfo(TfToken key)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecConstHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfType GetTypeForInfo(TfToken key)
		{
			TfType result = new TfType(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFallbackForInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInert(bool ignoreChildren)
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
		}

		public bool IsInert()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandle_IsInert__SWIG_1(swigCPtr);
		}

		public TfTokenVector ListFields()
		{
			return new TfTokenVector(SdfPINVOKE.SdfRelationshipSpecConstHandle_ListFields(swigCPtr), cMemoryOwn: true);
		}

		public bool HasField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfRelationshipSpecConstHandle_HasField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(TfToken name)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfRelationshipSpecConstHandle_GetField(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
