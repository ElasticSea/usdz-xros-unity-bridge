using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeInput : IDisposable
	{
		public class Hash : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public Hash(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(Hash obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(Hash obj)
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

			~Hash()
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
							UsdShadePINVOKE.delete_UsdShadeInput_Hash(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Hash()
				: this(UsdShadePINVOKE.new_UsdShadeInput_Hash(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdShadeInput(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeInput obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeInput obj)
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

		~UsdShadeInput()
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
						UsdShadePINVOKE.delete_UsdShadeInput(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeInput()
			: this(UsdShadePINVOKE.new_UsdShadeInput__SWIG_0(), cMemoryOwn: true)
		{
		}

		public TfToken GetFullName()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeInput_GetFullName(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetBaseName()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeInput_GetBaseName(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(UsdShadePINVOKE.UsdShadeInput_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdShadePINVOKE.UsdShadeInput_GetPrim(swigCPtr), cMemoryOwn: true);
		}

		public bool Get(VtValue value, UsdTimeCode time)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_Get__SWIG_2(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Get(VtValue value)
		{
			return UsdShadePINVOKE.UsdShadeInput_Get__SWIG_3(swigCPtr, VtValue.getCPtr(value));
		}

		public bool Set(VtValue value, UsdTimeCode time)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_Set__SWIG_0(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Set(VtValue value)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_Set__SWIG_1(swigCPtr, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetRenderType(TfToken renderType)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_SetRenderType(swigCPtr, TfToken.getCPtr(renderType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetRenderType()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeInput_GetRenderType(swigCPtr), cMemoryOwn: true);
		}

		public bool HasRenderType()
		{
			return UsdShadePINVOKE.UsdShadeInput_HasRenderType(swigCPtr);
		}

		public NdrTokenMap GetSdrMetadata()
		{
			return new NdrTokenMap(UsdShadePINVOKE.UsdShadeInput_GetSdrMetadata(swigCPtr), cMemoryOwn: true);
		}

		public string GetSdrMetadataByKey(TfToken key)
		{
			string result = UsdShadePINVOKE.UsdShadeInput_GetSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetSdrMetadata(NdrTokenMap sdrMetadata)
		{
			UsdShadePINVOKE.UsdShadeInput_SetSdrMetadata(swigCPtr, NdrTokenMap.getCPtr(sdrMetadata));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetSdrMetadataByKey(TfToken key, string value)
		{
			UsdShadePINVOKE.UsdShadeInput_SetSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key), value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasSdrMetadata()
		{
			return UsdShadePINVOKE.UsdShadeInput_HasSdrMetadata(swigCPtr);
		}

		public bool HasSdrMetadataByKey(TfToken key)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_HasSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearSdrMetadata()
		{
			UsdShadePINVOKE.UsdShadeInput_ClearSdrMetadata(swigCPtr);
		}

		public void ClearSdrMetadataByKey(TfToken key)
		{
			UsdShadePINVOKE.UsdShadeInput_ClearSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeInput(UsdAttribute attr)
			: this(UsdShadePINVOKE.new_UsdShadeInput__SWIG_1(UsdAttribute.getCPtr(attr)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool IsInput(UsdAttribute attr)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_IsInput(UsdAttribute.getCPtr(attr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsInterfaceInputName(string name)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_IsInterfaceInputName(name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeInput_GetAttr(swigCPtr), cMemoryOwn: false);
		}

		public bool IsDefined()
		{
			return UsdShadePINVOKE.UsdShadeInput_IsDefined(swigCPtr);
		}

		public bool SetDocumentation(string docs)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_SetDocumentation(swigCPtr, docs);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetDocumentation()
		{
			return UsdShadePINVOKE.UsdShadeInput_GetDocumentation(swigCPtr);
		}

		public bool SetDisplayGroup(string displayGroup)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_SetDisplayGroup(swigCPtr, displayGroup);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetDisplayGroup()
		{
			return UsdShadePINVOKE.UsdShadeInput_GetDisplayGroup(swigCPtr);
		}

		public bool CanConnect(UsdAttribute source)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_CanConnect__SWIG_0(swigCPtr, UsdAttribute.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanConnect(UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_CanConnect__SWIG_1(swigCPtr, getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanConnect(UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_CanConnect__SWIG_2(swigCPtr, UsdShadeOutput.getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectionSourceInfo source, UsdShadeConnectionModification mod)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_ConnectToSource__SWIG_0(swigCPtr, UsdShadeConnectionSourceInfo.getCPtr(source), (int)mod);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectionSourceInfo source)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_ConnectToSource__SWIG_1(swigCPtr, UsdShadeConnectionSourceInfo.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_ConnectToSource__SWIG_2(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_ConnectToSource__SWIG_3(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_ConnectToSource__SWIG_4(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(SdfPath sourcePath)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_ConnectToSource__SWIG_5(swigCPtr, SdfPath.getCPtr(sourcePath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_ConnectToSource__SWIG_6(swigCPtr, getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ConnectToSource(UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_ConnectToSource__SWIG_7(swigCPtr, UsdShadeOutput.getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetConnectedSources(SWIGTYPE_p_std__vectorT_UsdShadeConnectionSourceInfo_t sourceInfos)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_SetConnectedSources(swigCPtr, SWIGTYPE_p_std__vectorT_UsdShadeConnectionSourceInfo_t.getCPtr(sourceInfos));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources(SdfPathVector invalidSourcePaths)
		{
			return new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeInput_GetConnectedSources__SWIG_0(swigCPtr, SdfPathVector.getCPtr(invalidSourcePaths)), futureUse: true);
		}

		public SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources()
		{
			return new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeInput_GetConnectedSources__SWIG_1(swigCPtr), futureUse: true);
		}

		public bool GetConnectedSource(UsdShadeConnectableAPI source, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			return UsdShadePINVOKE.UsdShadeInput_GetConnectedSource(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), out sourceType);
		}

		public bool GetRawConnectedSourcePaths(SdfPathVector sourcePaths)
		{
			return UsdShadePINVOKE.UsdShadeInput_GetRawConnectedSourcePaths(swigCPtr, SdfPathVector.getCPtr(sourcePaths));
		}

		public bool HasConnectedSource()
		{
			return UsdShadePINVOKE.UsdShadeInput_HasConnectedSource(swigCPtr);
		}

		public bool IsSourceConnectionFromBaseMaterial()
		{
			return UsdShadePINVOKE.UsdShadeInput_IsSourceConnectionFromBaseMaterial(swigCPtr);
		}

		public bool DisconnectSource(UsdAttribute sourceAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_DisconnectSource__SWIG_0(swigCPtr, UsdAttribute.getCPtr(sourceAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool DisconnectSource()
		{
			return UsdShadePINVOKE.UsdShadeInput_DisconnectSource__SWIG_1(swigCPtr);
		}

		public bool ClearSources()
		{
			return UsdShadePINVOKE.UsdShadeInput_ClearSources(swigCPtr);
		}

		public bool ClearSource()
		{
			return UsdShadePINVOKE.UsdShadeInput_ClearSource(swigCPtr);
		}

		public bool SetConnectability(TfToken connectability)
		{
			bool result = UsdShadePINVOKE.UsdShadeInput_SetConnectability(swigCPtr, TfToken.getCPtr(connectability));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetConnectability()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeInput_GetConnectability(swigCPtr), cMemoryOwn: true);
		}

		public bool ClearConnectability()
		{
			return UsdShadePINVOKE.UsdShadeInput_ClearConnectability(swigCPtr);
		}

		public SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t GetValueProducingAttributes(bool shaderOutputsOnly)
		{
			return new SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t(UsdShadePINVOKE.UsdShadeInput_GetValueProducingAttributes__SWIG_0(swigCPtr, shaderOutputsOnly), futureUse: true);
		}

		public SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t GetValueProducingAttributes()
		{
			return new SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t(UsdShadePINVOKE.UsdShadeInput_GetValueProducingAttributes__SWIG_1(swigCPtr), futureUse: true);
		}

		public UsdAttribute GetValueProducingAttribute(SWIGTYPE_p_UsdShadeAttributeType attrType)
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeInput_GetValueProducingAttribute(swigCPtr, SWIGTYPE_p_UsdShadeAttributeType.getCPtr(attrType)), cMemoryOwn: true);
		}
	}
}
