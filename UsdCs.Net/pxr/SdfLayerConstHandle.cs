using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerConstHandle : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfLayerConstHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerConstHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerConstHandle obj)
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

		~SdfLayerConstHandle()
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
						SdfPINVOKE.delete_SdfLayerConstHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfLayerConstHandle(SdfLayer layer)
			: this(SdfPINVOKE.new_SdfLayerConstHandle(SdfLayer.getCPtr(layer)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayer __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerConstHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfLayerConstHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t GetFileFormat()
		{
			return new SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t(SdfPINVOKE.SdfLayerConstHandle_GetFileFormat(swigCPtr), futureUse: false);
		}

		public StdStringMap GetFileFormatArguments()
		{
			return new StdStringMap(SdfPINVOKE.SdfLayerConstHandle_GetFileFormatArguments(swigCPtr), cMemoryOwn: false);
		}

		public SdfLayerHints GetHints()
		{
			return new SdfLayerHints(SdfPINVOKE.SdfLayerConstHandle_GetHints(swigCPtr), cMemoryOwn: true);
		}

		public bool IsEmpty()
		{
			return SdfPINVOKE.SdfLayerConstHandle_IsEmpty(swigCPtr);
		}

		public bool StreamsData()
		{
			return SdfPINVOKE.SdfLayerConstHandle_StreamsData(swigCPtr);
		}

		public bool IsDetached()
		{
			return SdfPINVOKE.SdfLayerConstHandle_IsDetached(swigCPtr);
		}

		public bool IsAnonymous()
		{
			return SdfPINVOKE.SdfLayerConstHandle_IsAnonymous(swigCPtr);
		}

		public bool Save(bool force)
		{
			return SdfPINVOKE.SdfLayerConstHandle_Save__SWIG_0(swigCPtr, force);
		}

		public bool Save()
		{
			return SdfPINVOKE.SdfLayerConstHandle_Save__SWIG_1(swigCPtr);
		}

		public bool Export(string filename, string comment, StdStringMap args)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_Export__SWIG_0(swigCPtr, filename, comment, StdStringMap.getCPtr(args));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename, string comment)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_Export__SWIG_1(swigCPtr, filename, comment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_Export__SWIG_2(swigCPtr, filename);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetExternalReferences()
		{
			return new StdStringSet(SdfPINVOKE.SdfLayerConstHandle_GetExternalReferences(swigCPtr), cMemoryOwn: true);
		}

		public StdStringSet GetCompositionAssetDependencies()
		{
			return new StdStringSet(SdfPINVOKE.SdfLayerConstHandle_GetCompositionAssetDependencies(swigCPtr), cMemoryOwn: true);
		}

		public StdStringSet GetExternalAssetDependencies()
		{
			return new StdStringSet(SdfPINVOKE.SdfLayerConstHandle_GetExternalAssetDependencies(swigCPtr), cMemoryOwn: true);
		}

		private string GetIdentifier()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetIdentifier(swigCPtr);
		}

		public string GetDisplayName()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetDisplayName(swigCPtr);
		}

		public SWIGTYPE_p_ArResolvedPath GetResolvedPath()
		{
			return new SWIGTYPE_p_ArResolvedPath(SdfPINVOKE.SdfLayerConstHandle_GetResolvedPath(swigCPtr), futureUse: false);
		}

		public string GetRealPath()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetRealPath(swigCPtr);
		}

		public string GetFileExtension()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetFileExtension(swigCPtr);
		}

		public string GetVersion()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetVersion(swigCPtr);
		}

		public string GetRepositoryPath()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetRepositoryPath(swigCPtr);
		}

		public string GetAssetName()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetAssetName(swigCPtr);
		}

		public VtValue GetAssetInfo()
		{
			return new VtValue(SdfPINVOKE.SdfLayerConstHandle_GetAssetInfo(swigCPtr), cMemoryOwn: false);
		}

		public string ComputeAbsolutePath(string assetPath)
		{
			string result = SdfPINVOKE.SdfLayerConstHandle_ComputeAbsolutePath(swigCPtr, assetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecType GetSpecType(SdfPath path)
		{
			SdfSpecType result = (SdfSpecType)SdfPINVOKE.SdfLayerConstHandle_GetSpecType(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasSpec(SdfPath path)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_HasSpec(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector ListFields(SdfPath path)
		{
			TfTokenVector result = new TfTokenVector(SdfPINVOKE.SdfLayerConstHandle_ListFields(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_HasField__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_HasField__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_HasField__SWIG_2(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_HasFieldDictKey__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_HasFieldDictKey__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_HasFieldDictKey__SWIG_2(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(SdfPath path, TfToken fieldName)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfLayerConstHandle_GetField(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfLayerConstHandle_GetFieldDictValueByKey(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAssetPath GetColorConfiguration()
		{
			return new SdfAssetPath(SdfPINVOKE.SdfLayerConstHandle_GetColorConfiguration(swigCPtr), cMemoryOwn: true);
		}

		public bool HasColorConfiguration()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasColorConfiguration(swigCPtr);
		}

		public TfToken GetColorManagementSystem()
		{
			return new TfToken(SdfPINVOKE.SdfLayerConstHandle_GetColorManagementSystem(swigCPtr), cMemoryOwn: true);
		}

		public bool HasColorManagementSystem()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasColorManagementSystem(swigCPtr);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetComment(swigCPtr);
		}

		public TfToken GetDefaultPrim()
		{
			return new TfToken(SdfPINVOKE.SdfLayerConstHandle_GetDefaultPrim(swigCPtr), cMemoryOwn: true);
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetDocumentation(swigCPtr);
		}

		public double GetStartTimeCode()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetStartTimeCode(swigCPtr);
		}

		public bool HasStartTimeCode()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasStartTimeCode(swigCPtr);
		}

		public double GetEndTimeCode()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetEndTimeCode(swigCPtr);
		}

		public bool HasEndTimeCode()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasEndTimeCode(swigCPtr);
		}

		public double GetTimeCodesPerSecond()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetTimeCodesPerSecond(swigCPtr);
		}

		public bool HasTimeCodesPerSecond()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasTimeCodesPerSecond(swigCPtr);
		}

		public double GetFramesPerSecond()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetFramesPerSecond(swigCPtr);
		}

		public bool HasFramesPerSecond()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasFramesPerSecond(swigCPtr);
		}

		public int GetFramePrecision()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetFramePrecision(swigCPtr);
		}

		public bool HasFramePrecision()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasFramePrecision(swigCPtr);
		}

		public string GetOwner()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetOwner(swigCPtr);
		}

		public bool HasOwner()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasOwner(swigCPtr);
		}

		public string GetSessionOwner()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetSessionOwner(swigCPtr);
		}

		public bool HasSessionOwner()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasSessionOwner(swigCPtr);
		}

		public bool GetHasOwnedSubLayers()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetHasOwnedSubLayers(swigCPtr);
		}

		public VtDictionary GetCustomLayerData()
		{
			return new VtDictionary(SdfPINVOKE.SdfLayerConstHandle_GetCustomLayerData(swigCPtr), cMemoryOwn: true);
		}

		public bool HasCustomLayerData()
		{
			return SdfPINVOKE.SdfLayerConstHandle_HasCustomLayerData(swigCPtr);
		}

		public SWIGTYPE_p_SdfPrimSpecView GetRootPrims()
		{
			return new SWIGTYPE_p_SdfPrimSpecView(SdfPINVOKE.SdfLayerConstHandle_GetRootPrims(swigCPtr), futureUse: true);
		}

		public void ApplyRootPrimOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfLayerConstHandle_ApplyRootPrimOrder(swigCPtr, TfTokenVector.getCPtr(vec));
		}

		public SdfSubLayerProxy GetSubLayerPaths()
		{
			return new SdfSubLayerProxy(SdfPINVOKE.SdfLayerConstHandle_GetSubLayerPaths(swigCPtr), cMemoryOwn: true);
		}

		public uint GetNumSubLayerPaths()
		{
			return SdfPINVOKE.SdfLayerConstHandle_GetNumSubLayerPaths(swigCPtr);
		}

		public SdfLayerOffsetVector GetSubLayerOffsets()
		{
			return new SdfLayerOffsetVector(SdfPINVOKE.SdfLayerConstHandle_GetSubLayerOffsets(swigCPtr), cMemoryOwn: true);
		}

		public SdfLayerOffset GetSubLayerOffset(int index)
		{
			return new SdfLayerOffset(SdfPINVOKE.SdfLayerConstHandle_GetSubLayerOffset(swigCPtr, index), cMemoryOwn: true);
		}

		public bool IsMuted()
		{
			return SdfPINVOKE.SdfLayerConstHandle_IsMuted__SWIG_0(swigCPtr);
		}

		public SdfPrimSpecHandle GetPseudoRoot()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfLayerConstHandle_GetPseudoRoot(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfLayerConstHandle_PermissionToEdit(swigCPtr);
		}

		public bool PermissionToSave()
		{
			return SdfPINVOKE.SdfLayerConstHandle_PermissionToSave(swigCPtr);
		}

		public SdfNamespaceEditDetail.Result CanApply(SdfBatchNamespaceEdit arg0, SdfNamespaceEditDetailVector details)
		{
			SdfNamespaceEditDetail.Result result = (SdfNamespaceEditDetail.Result)SdfPINVOKE.SdfLayerConstHandle_CanApply__SWIG_0(swigCPtr, SdfBatchNamespaceEdit.getCPtr(arg0), SdfNamespaceEditDetailVector.getCPtr(details));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfNamespaceEditDetail.Result CanApply(SdfBatchNamespaceEdit arg0)
		{
			SdfNamespaceEditDetail.Result result = (SdfNamespaceEditDetail.Result)SdfPINVOKE.SdfLayerConstHandle_CanApply__SWIG_1(swigCPtr, SdfBatchNamespaceEdit.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsDirty()
		{
			return SdfPINVOKE.SdfLayerConstHandle_IsDirty(swigCPtr);
		}

		public SWIGTYPE_p_std__setT_double_t ListAllTimeSamples()
		{
			return new SWIGTYPE_p_std__setT_double_t(SdfPINVOKE.SdfLayerConstHandle_ListAllTimeSamples(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_std__setT_double_t ListTimeSamplesForPath(SdfPath path)
		{
			SWIGTYPE_p_std__setT_double_t result = new SWIGTYPE_p_std__setT_double_t(SdfPINVOKE.SdfLayerConstHandle_ListTimeSamplesForPath(swigCPtr, SdfPath.getCPtr(path)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetNumTimeSamplesForPath(SdfPath path)
		{
			uint result = SdfPINVOKE.SdfLayerConstHandle_GetNumTimeSamplesForPath(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_QueryTimeSample__SWIG_0(swigCPtr, SdfPath.getCPtr(path), time, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_QueryTimeSample__SWIG_1(swigCPtr, SdfPath.getCPtr(path), time);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayerConstHandle_QueryTimeSample__SWIG_2(swigCPtr, SdfPath.getCPtr(path), time, SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
