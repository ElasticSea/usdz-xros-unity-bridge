using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeOutput : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdShadeOutput(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeOutput obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeOutput obj)
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

		~UsdShadeOutput()
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
						UsdShadePINVOKE.delete_UsdShadeOutput(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeOutput()
			: this(UsdShadePINVOKE.new_UsdShadeOutput__SWIG_0(), cMemoryOwn: true)
		{
		}

		public TfToken GetFullName()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeOutput_GetFullName(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetBaseName()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeOutput_GetBaseName(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdShadePINVOKE.UsdShadeOutput_GetPrim(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(UsdShadePINVOKE.UsdShadeOutput_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		public bool Set(VtValue value, UsdTimeCode time)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_Set__SWIG_0(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Set(VtValue value)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_Set__SWIG_1(swigCPtr, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetRenderType(TfToken renderType)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_SetRenderType(swigCPtr, TfToken.getCPtr(renderType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetRenderType()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeOutput_GetRenderType(swigCPtr), cMemoryOwn: true);
		}

		public bool HasRenderType()
		{
			return UsdShadePINVOKE.UsdShadeOutput_HasRenderType(swigCPtr);
		}

		public NdrTokenMap GetSdrMetadata()
		{
			return new NdrTokenMap(UsdShadePINVOKE.UsdShadeOutput_GetSdrMetadata(swigCPtr), cMemoryOwn: true);
		}

		public string GetSdrMetadataByKey(TfToken key)
		{
			string result = UsdShadePINVOKE.UsdShadeOutput_GetSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetSdrMetadata(NdrTokenMap sdrMetadata)
		{
			UsdShadePINVOKE.UsdShadeOutput_SetSdrMetadata(swigCPtr, NdrTokenMap.getCPtr(sdrMetadata));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetSdrMetadataByKey(TfToken key, string value)
		{
			UsdShadePINVOKE.UsdShadeOutput_SetSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key), value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasSdrMetadata()
		{
			return UsdShadePINVOKE.UsdShadeOutput_HasSdrMetadata(swigCPtr);
		}

		public bool HasSdrMetadataByKey(TfToken key)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_HasSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearSdrMetadata()
		{
			UsdShadePINVOKE.UsdShadeOutput_ClearSdrMetadata(swigCPtr);
		}

		public void ClearSdrMetadataByKey(TfToken key)
		{
			UsdShadePINVOKE.UsdShadeOutput_ClearSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeOutput(UsdAttribute attr)
			: this(UsdShadePINVOKE.new_UsdShadeOutput__SWIG_1(UsdAttribute.getCPtr(attr)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool IsOutput(UsdAttribute attr)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_IsOutput(UsdAttribute.getCPtr(attr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeOutput_GetAttr(swigCPtr), cMemoryOwn: true);
		}

		public bool IsDefined()
		{
			return UsdShadePINVOKE.UsdShadeOutput_IsDefined(swigCPtr);
		}

		public bool CanConnect(UsdAttribute source)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_CanConnect__SWIG_0(swigCPtr, UsdAttribute.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanConnect(UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_CanConnect__SWIG_1(swigCPtr, UsdShadeInput.getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanConnect(UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_CanConnect__SWIG_2(swigCPtr, getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectionSourceInfo source, UsdShadeConnectionModification mod)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_ConnectToSource__SWIG_0(swigCPtr, UsdShadeConnectionSourceInfo.getCPtr(source), (int)mod);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectionSourceInfo source)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_ConnectToSource__SWIG_1(swigCPtr, UsdShadeConnectionSourceInfo.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_ConnectToSource__SWIG_2(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_ConnectToSource__SWIG_3(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_ConnectToSource__SWIG_4(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(SdfPath sourcePath)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_ConnectToSource__SWIG_5(swigCPtr, SdfPath.getCPtr(sourcePath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_ConnectToSource__SWIG_6(swigCPtr, UsdShadeInput.getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_ConnectToSource__SWIG_7(swigCPtr, getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetConnectedSources(SWIGTYPE_p_std__vectorT_UsdShadeConnectionSourceInfo_t sourceInfos)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_SetConnectedSources(swigCPtr, SWIGTYPE_p_std__vectorT_UsdShadeConnectionSourceInfo_t.getCPtr(sourceInfos));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources(SdfPathVector invalidSourcePaths)
		{
			return new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeOutput_GetConnectedSources__SWIG_0(swigCPtr, SdfPathVector.getCPtr(invalidSourcePaths)), futureUse: true);
		}

		public SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources()
		{
			return new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeOutput_GetConnectedSources__SWIG_1(swigCPtr), futureUse: true);
		}

		public bool GetConnectedSource(UsdShadeConnectableAPI source, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			return UsdShadePINVOKE.UsdShadeOutput_GetConnectedSource(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), out sourceType);
		}

		public bool GetRawConnectedSourcePaths(SdfPathVector sourcePaths)
		{
			return UsdShadePINVOKE.UsdShadeOutput_GetRawConnectedSourcePaths(swigCPtr, SdfPathVector.getCPtr(sourcePaths));
		}

		public bool HasConnectedSource()
		{
			return UsdShadePINVOKE.UsdShadeOutput_HasConnectedSource(swigCPtr);
		}

		public bool IsSourceConnectionFromBaseMaterial()
		{
			return UsdShadePINVOKE.UsdShadeOutput_IsSourceConnectionFromBaseMaterial(swigCPtr);
		}

		public bool DisconnectSource(UsdAttribute sourceAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeOutput_DisconnectSource__SWIG_0(swigCPtr, UsdAttribute.getCPtr(sourceAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool DisconnectSource()
		{
			return UsdShadePINVOKE.UsdShadeOutput_DisconnectSource__SWIG_1(swigCPtr);
		}

		public bool ClearSources()
		{
			return UsdShadePINVOKE.UsdShadeOutput_ClearSources(swigCPtr);
		}

		public bool ClearSource()
		{
			return UsdShadePINVOKE.UsdShadeOutput_ClearSource(swigCPtr);
		}

		public SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t GetValueProducingAttributes(bool shaderOutputsOnly)
		{
			return new SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t(UsdShadePINVOKE.UsdShadeOutput_GetValueProducingAttributes__SWIG_0(swigCPtr, shaderOutputsOnly), futureUse: true);
		}

		public SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t GetValueProducingAttributes()
		{
			return new SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t(UsdShadePINVOKE.UsdShadeOutput_GetValueProducingAttributes__SWIG_1(swigCPtr), futureUse: true);
		}
	}
}
