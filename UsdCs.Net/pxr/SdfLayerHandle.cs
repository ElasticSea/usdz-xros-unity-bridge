using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerHandle : IDisposable
	{
		private HandleRef swigCPtr;

		private HandleRef swigCPtrRef;

		private bool swigCMemOwn;

		public string identifier
		{
			get
			{
				return GetIdentifier();
			}
			set
			{
				SetIdentifier(value);
			}
		}

		internal SdfLayerHandle(IntPtr cPtrHandle, IntPtr cPtrRef, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtrHandle);
			swigCPtrRef = new HandleRef(this, cPtrRef);
		}

		internal SdfLayerHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
			swigCPtrRef = new HandleRef(null, IntPtr.Zero);
		}

		internal static HandleRef getCPtr(SdfLayerHandle obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		~SdfLayerHandle()
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
				if (!(swigCPtr.Handle != IntPtr.Zero))
				{
					return;
				}
				if (swigCMemOwn)
				{
					swigCMemOwn = false;
					SdfPINVOKE.delete_SdfLayerHandle(swigCPtr);
					if (swigCPtrRef.Handle != IntPtr.Zero)
					{
						SdfPINVOKE.delete_SdfLayer(swigCPtrRef);
					}
				}
				swigCPtr = new HandleRef(null, IntPtr.Zero);
				swigCPtrRef = new HandleRef(null, IntPtr.Zero);
			}
		}

		public SdfLayerHandle(SdfLayer layer)
			: this(SdfPINVOKE.new_SdfLayerHandle(SdfLayer.getCPtr(layer)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayer __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true);
		}

		public static bool Equals(SdfLayerHandle lhs, SdfLayerHandle rhs)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(SdfLayerHandle lhs, SdfLayerHandle rhs)
		{
			bool flag = (object)lhs == null;
			bool flag2 = (object)rhs == null;
			if (flag == flag2)
			{
				if (!(flag && flag2))
				{
					return Equals(lhs, rhs);
				}
				return true;
			}
			return false;
		}

		public static bool operator !=(SdfLayerHandle lhs, SdfLayerHandle rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as SdfLayerHandle);
		}

		public override int GetHashCode()
		{
			return SdfPINVOKE.SdfLayerHandle_GetHashCode(swigCPtr);
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfLayerHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t GetFileFormat()
		{
			return new SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t(SdfPINVOKE.SdfLayerHandle_GetFileFormat(swigCPtr), futureUse: false);
		}

		public StdStringMap GetFileFormatArguments()
		{
			return new StdStringMap(SdfPINVOKE.SdfLayerHandle_GetFileFormatArguments(swigCPtr), cMemoryOwn: false);
		}

		public SdfLayerHandle CreateNew(string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateNew__SWIG_0(swigCPtr, identifier, StdStringMap.getCPtr(args));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle CreateNew(string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateNew__SWIG_1(swigCPtr, identifier);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle CreateNew(SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t fileFormat, string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateNew__SWIG_2(swigCPtr, SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t.getCPtr(fileFormat), identifier, StdStringMap.getCPtr(args));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle CreateNew(SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t fileFormat, string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateNew__SWIG_3(swigCPtr, SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t.getCPtr(fileFormat), identifier);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle New(SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t fileFormat, string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_New__SWIG_0(swigCPtr, SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t.getCPtr(fileFormat), identifier, StdStringMap.getCPtr(args));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle New(SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t fileFormat, string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_New__SWIG_1(swigCPtr, SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t.getCPtr(fileFormat), identifier);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle Find(string identifier, StdStringMap args)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayerHandle_Find__SWIG_0(swigCPtr, identifier, StdStringMap.getCPtr(args)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle Find(string identifier)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayerHandle_Find__SWIG_1(swigCPtr, identifier), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle FindRelativeToLayer(SdfLayerHandle anchor, string identifier, StdStringMap args)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayerHandle_FindRelativeToLayer__SWIG_0(swigCPtr, getCPtr(anchor), identifier, StdStringMap.getCPtr(args)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle FindRelativeToLayer(SdfLayerHandle anchor, string identifier)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayerHandle_FindRelativeToLayer__SWIG_1(swigCPtr, getCPtr(anchor), identifier), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle FindOrOpen(string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_FindOrOpen__SWIG_0(swigCPtr, identifier, StdStringMap.getCPtr(args));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle FindOrOpen(string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_FindOrOpen__SWIG_1(swigCPtr, identifier);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle FindOrOpenRelativeToLayer(SdfLayerHandle anchor, string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_FindOrOpenRelativeToLayer__SWIG_0(swigCPtr, getCPtr(anchor), identifier, StdStringMap.getCPtr(args));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle FindOrOpenRelativeToLayer(SdfLayerHandle anchor, string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_FindOrOpenRelativeToLayer__SWIG_1(swigCPtr, getCPtr(anchor), identifier);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle OpenAsAnonymous(string layerPath, bool metadataOnly, string tag)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_OpenAsAnonymous__SWIG_0(swigCPtr, layerPath, metadataOnly, tag);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle OpenAsAnonymous(string layerPath, bool metadataOnly)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_OpenAsAnonymous__SWIG_1(swigCPtr, layerPath, metadataOnly);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle OpenAsAnonymous(string layerPath)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_OpenAsAnonymous__SWIG_2(swigCPtr, layerPath);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHints GetHints()
		{
			return new SdfLayerHints(SdfPINVOKE.SdfLayerHandle_GetHints(swigCPtr), cMemoryOwn: true);
		}

		public SdfLayerHandleSet GetLoadedLayers()
		{
			return new SdfLayerHandleSet(SdfPINVOKE.SdfLayerHandle_GetLoadedLayers(swigCPtr), cMemoryOwn: true);
		}

		public bool IsEmpty()
		{
			return SdfPINVOKE.SdfLayerHandle_IsEmpty(swigCPtr);
		}

		public bool StreamsData()
		{
			return SdfPINVOKE.SdfLayerHandle_StreamsData(swigCPtr);
		}

		public bool IsDetached()
		{
			return SdfPINVOKE.SdfLayerHandle_IsDetached(swigCPtr);
		}

		public void TransferContent(SdfLayerHandle layer)
		{
			SdfPINVOKE.SdfLayerHandle_TransferContent(swigCPtr, getCPtr(layer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerHandle CreateAnonymous(string tag, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateAnonymous__SWIG_0(swigCPtr, tag, StdStringMap.getCPtr(args));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle CreateAnonymous(string tag)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateAnonymous__SWIG_1(swigCPtr, tag);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle CreateAnonymous()
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateAnonymous__SWIG_2(swigCPtr);
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			return (intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true);
		}

		public SdfLayerHandle CreateAnonymous(string tag, SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t format, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateAnonymous__SWIG_3(swigCPtr, tag, SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t.getCPtr(format), StdStringMap.getCPtr(args));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle CreateAnonymous(string tag, SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t format)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerHandle_CreateAnonymous__SWIG_4(swigCPtr, tag, SWIGTYPE_p_TfWeakPtrT_SdfFileFormat_const_t.getCPtr(format));
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			SdfLayerHandle result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsAnonymous()
		{
			return SdfPINVOKE.SdfLayerHandle_IsAnonymous(swigCPtr);
		}

		public bool IsAnonymousLayerIdentifier(string identifier)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_IsAnonymousLayerIdentifier(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetDisplayNameFromIdentifier(string identifier)
		{
			string result = SdfPINVOKE.SdfLayerHandle_GetDisplayNameFromIdentifier(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Save(bool force)
		{
			return SdfPINVOKE.SdfLayerHandle_Save__SWIG_0(swigCPtr, force);
		}

		public bool Save()
		{
			return SdfPINVOKE.SdfLayerHandle_Save__SWIG_1(swigCPtr);
		}

		public bool Export(string filename, string comment, StdStringMap args)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_Export__SWIG_0(swigCPtr, filename, comment, StdStringMap.getCPtr(args));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename, string comment)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_Export__SWIG_1(swigCPtr, filename, comment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_Export__SWIG_2(swigCPtr, filename);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ImportFromString(string string_)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_ImportFromString(swigCPtr, string_);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Clear()
		{
			SdfPINVOKE.SdfLayerHandle_Clear(swigCPtr);
		}

		public bool Reload(bool force)
		{
			return SdfPINVOKE.SdfLayerHandle_Reload__SWIG_0(swigCPtr, force);
		}

		public bool Reload()
		{
			return SdfPINVOKE.SdfLayerHandle_Reload__SWIG_1(swigCPtr);
		}

		public bool ReloadLayers(SdfLayerHandleSet layers, bool force)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_ReloadLayers__SWIG_0(swigCPtr, SdfLayerHandleSet.getCPtr(layers), force);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ReloadLayers(SdfLayerHandleSet layers)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_ReloadLayers__SWIG_1(swigCPtr, SdfLayerHandleSet.getCPtr(layers));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Import(string layerPath)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_Import(swigCPtr, layerPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetExternalReferences()
		{
			return new StdStringSet(SdfPINVOKE.SdfLayerHandle_GetExternalReferences(swigCPtr), cMemoryOwn: true);
		}

		public bool UpdateExternalReference(string oldAssetPath, string newAssetPath)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_UpdateExternalReference__SWIG_0(swigCPtr, oldAssetPath, newAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UpdateExternalReference(string oldAssetPath)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_UpdateExternalReference__SWIG_1(swigCPtr, oldAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetCompositionAssetDependencies()
		{
			return new StdStringSet(SdfPINVOKE.SdfLayerHandle_GetCompositionAssetDependencies(swigCPtr), cMemoryOwn: true);
		}

		public bool UpdateCompositionAssetDependency(string oldAssetPath, string newAssetPath)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_UpdateCompositionAssetDependency__SWIG_0(swigCPtr, oldAssetPath, newAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UpdateCompositionAssetDependency(string oldAssetPath)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_UpdateCompositionAssetDependency__SWIG_1(swigCPtr, oldAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetExternalAssetDependencies()
		{
			return new StdStringSet(SdfPINVOKE.SdfLayerHandle_GetExternalAssetDependencies(swigCPtr), cMemoryOwn: true);
		}

		public bool SplitIdentifier(string identifier, SWIGTYPE_p_std__string layerPath, StdStringMap arguments)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_SplitIdentifier(swigCPtr, identifier, SWIGTYPE_p_std__string.getCPtr(layerPath), StdStringMap.getCPtr(arguments));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string CreateIdentifier(string layerPath, StdStringMap arguments)
		{
			string result = SdfPINVOKE.SdfLayerHandle_CreateIdentifier(swigCPtr, layerPath, StdStringMap.getCPtr(arguments));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private string GetIdentifier()
		{
			return SdfPINVOKE.SdfLayerHandle_GetIdentifier(swigCPtr);
		}

		private void SetIdentifier(string identifier)
		{
			SdfPINVOKE.SdfLayerHandle_SetIdentifier(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void UpdateAssetInfo()
		{
			SdfPINVOKE.SdfLayerHandle_UpdateAssetInfo(swigCPtr);
		}

		public string GetDisplayName()
		{
			return SdfPINVOKE.SdfLayerHandle_GetDisplayName(swigCPtr);
		}

		public SWIGTYPE_p_ArResolvedPath GetResolvedPath()
		{
			return new SWIGTYPE_p_ArResolvedPath(SdfPINVOKE.SdfLayerHandle_GetResolvedPath(swigCPtr), futureUse: false);
		}

		public string GetRealPath()
		{
			return SdfPINVOKE.SdfLayerHandle_GetRealPath(swigCPtr);
		}

		public string GetFileExtension()
		{
			return SdfPINVOKE.SdfLayerHandle_GetFileExtension(swigCPtr);
		}

		public string GetVersion()
		{
			return SdfPINVOKE.SdfLayerHandle_GetVersion(swigCPtr);
		}

		public string GetRepositoryPath()
		{
			return SdfPINVOKE.SdfLayerHandle_GetRepositoryPath(swigCPtr);
		}

		public string GetAssetName()
		{
			return SdfPINVOKE.SdfLayerHandle_GetAssetName(swigCPtr);
		}

		public VtValue GetAssetInfo()
		{
			return new VtValue(SdfPINVOKE.SdfLayerHandle_GetAssetInfo(swigCPtr), cMemoryOwn: false);
		}

		public string ComputeAbsolutePath(string assetPath)
		{
			string result = SdfPINVOKE.SdfLayerHandle_ComputeAbsolutePath(swigCPtr, assetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecType GetSpecType(SdfPath path)
		{
			SdfSpecType result = (SdfSpecType)SdfPINVOKE.SdfLayerHandle_GetSpecType(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasSpec(SdfPath path)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_HasSpec(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector ListFields(SdfPath path)
		{
			TfTokenVector result = new TfTokenVector(SdfPINVOKE.SdfLayerHandle_ListFields(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_HasField__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_HasField__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_HasField__SWIG_2(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_HasFieldDictKey__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_HasFieldDictKey__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_HasFieldDictKey__SWIG_2(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(SdfPath path, TfToken fieldName)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfLayerHandle_GetField(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfLayerHandle_GetFieldDictValueByKey(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetField(SdfPath path, TfToken fieldName, VtValue value)
		{
			SdfPINVOKE.SdfLayerHandle_SetField__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetField(SdfPath path, TfToken fieldName, SWIGTYPE_p_SdfAbstractDataConstValue value)
		{
			SdfPINVOKE.SdfLayerHandle_SetField__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), SWIGTYPE_p_SdfAbstractDataConstValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath, VtValue value)
		{
			SdfPINVOKE.SdfLayerHandle_SetFieldDictValueByKey__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath, SWIGTYPE_p_SdfAbstractDataConstValue value)
		{
			SdfPINVOKE.SdfLayerHandle_SetFieldDictValueByKey__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), SWIGTYPE_p_SdfAbstractDataConstValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseField(SdfPath path, TfToken fieldName)
		{
			SdfPINVOKE.SdfLayerHandle_EraseField(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath)
		{
			SdfPINVOKE.SdfLayerHandle_EraseFieldDictValueByKey(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAssetPath GetColorConfiguration()
		{
			return new SdfAssetPath(SdfPINVOKE.SdfLayerHandle_GetColorConfiguration(swigCPtr), cMemoryOwn: true);
		}

		public void SetColorConfiguration(SdfAssetPath colorConfiguration)
		{
			SdfPINVOKE.SdfLayerHandle_SetColorConfiguration(swigCPtr, SdfAssetPath.getCPtr(colorConfiguration));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasColorConfiguration()
		{
			return SdfPINVOKE.SdfLayerHandle_HasColorConfiguration(swigCPtr);
		}

		public void ClearColorConfiguration()
		{
			SdfPINVOKE.SdfLayerHandle_ClearColorConfiguration(swigCPtr);
		}

		public TfToken GetColorManagementSystem()
		{
			return new TfToken(SdfPINVOKE.SdfLayerHandle_GetColorManagementSystem(swigCPtr), cMemoryOwn: true);
		}

		public void SetColorManagementSystem(TfToken cms)
		{
			SdfPINVOKE.SdfLayerHandle_SetColorManagementSystem(swigCPtr, TfToken.getCPtr(cms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasColorManagementSystem()
		{
			return SdfPINVOKE.SdfLayerHandle_HasColorManagementSystem(swigCPtr);
		}

		public void ClearColorManagementSystem()
		{
			SdfPINVOKE.SdfLayerHandle_ClearColorManagementSystem(swigCPtr);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfLayerHandle_GetComment(swigCPtr);
		}

		public void SetComment(string comment)
		{
			SdfPINVOKE.SdfLayerHandle_SetComment(swigCPtr, comment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetDefaultPrim()
		{
			return new TfToken(SdfPINVOKE.SdfLayerHandle_GetDefaultPrim(swigCPtr), cMemoryOwn: true);
		}

		public void SetDefaultPrim(TfToken name)
		{
			SdfPINVOKE.SdfLayerHandle_SetDefaultPrim(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ClearDefaultPrim()
		{
			SdfPINVOKE.SdfLayerHandle_ClearDefaultPrim(swigCPtr);
		}

		public bool HasDefaultPrim()
		{
			return SdfPINVOKE.SdfLayerHandle_HasDefaultPrim(swigCPtr);
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfLayerHandle_GetDocumentation(swigCPtr);
		}

		public void SetDocumentation(string documentation)
		{
			SdfPINVOKE.SdfLayerHandle_SetDocumentation(swigCPtr, documentation);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetStartTimeCode()
		{
			return SdfPINVOKE.SdfLayerHandle_GetStartTimeCode(swigCPtr);
		}

		public void SetStartTimeCode(double startTimecode)
		{
			SdfPINVOKE.SdfLayerHandle_SetStartTimeCode(swigCPtr, startTimecode);
		}

		public bool HasStartTimeCode()
		{
			return SdfPINVOKE.SdfLayerHandle_HasStartTimeCode(swigCPtr);
		}

		public void ClearStartTimeCode()
		{
			SdfPINVOKE.SdfLayerHandle_ClearStartTimeCode(swigCPtr);
		}

		public double GetEndTimeCode()
		{
			return SdfPINVOKE.SdfLayerHandle_GetEndTimeCode(swigCPtr);
		}

		public void SetEndTimeCode(double endTimeCode)
		{
			SdfPINVOKE.SdfLayerHandle_SetEndTimeCode(swigCPtr, endTimeCode);
		}

		public bool HasEndTimeCode()
		{
			return SdfPINVOKE.SdfLayerHandle_HasEndTimeCode(swigCPtr);
		}

		public void ClearEndTimeCode()
		{
			SdfPINVOKE.SdfLayerHandle_ClearEndTimeCode(swigCPtr);
		}

		public double GetTimeCodesPerSecond()
		{
			return SdfPINVOKE.SdfLayerHandle_GetTimeCodesPerSecond(swigCPtr);
		}

		public void SetTimeCodesPerSecond(double timeCodesPerSecond)
		{
			SdfPINVOKE.SdfLayerHandle_SetTimeCodesPerSecond(swigCPtr, timeCodesPerSecond);
		}

		public bool HasTimeCodesPerSecond()
		{
			return SdfPINVOKE.SdfLayerHandle_HasTimeCodesPerSecond(swigCPtr);
		}

		public void ClearTimeCodesPerSecond()
		{
			SdfPINVOKE.SdfLayerHandle_ClearTimeCodesPerSecond(swigCPtr);
		}

		public double GetFramesPerSecond()
		{
			return SdfPINVOKE.SdfLayerHandle_GetFramesPerSecond(swigCPtr);
		}

		public void SetFramesPerSecond(double framesPerSecond)
		{
			SdfPINVOKE.SdfLayerHandle_SetFramesPerSecond(swigCPtr, framesPerSecond);
		}

		public bool HasFramesPerSecond()
		{
			return SdfPINVOKE.SdfLayerHandle_HasFramesPerSecond(swigCPtr);
		}

		public void ClearFramesPerSecond()
		{
			SdfPINVOKE.SdfLayerHandle_ClearFramesPerSecond(swigCPtr);
		}

		public int GetFramePrecision()
		{
			return SdfPINVOKE.SdfLayerHandle_GetFramePrecision(swigCPtr);
		}

		public void SetFramePrecision(int framePrecision)
		{
			SdfPINVOKE.SdfLayerHandle_SetFramePrecision(swigCPtr, framePrecision);
		}

		public bool HasFramePrecision()
		{
			return SdfPINVOKE.SdfLayerHandle_HasFramePrecision(swigCPtr);
		}

		public void ClearFramePrecision()
		{
			SdfPINVOKE.SdfLayerHandle_ClearFramePrecision(swigCPtr);
		}

		public string GetOwner()
		{
			return SdfPINVOKE.SdfLayerHandle_GetOwner(swigCPtr);
		}

		public void SetOwner(string owner)
		{
			SdfPINVOKE.SdfLayerHandle_SetOwner(swigCPtr, owner);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasOwner()
		{
			return SdfPINVOKE.SdfLayerHandle_HasOwner(swigCPtr);
		}

		public void ClearOwner()
		{
			SdfPINVOKE.SdfLayerHandle_ClearOwner(swigCPtr);
		}

		public string GetSessionOwner()
		{
			return SdfPINVOKE.SdfLayerHandle_GetSessionOwner(swigCPtr);
		}

		public void SetSessionOwner(string owner)
		{
			SdfPINVOKE.SdfLayerHandle_SetSessionOwner(swigCPtr, owner);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasSessionOwner()
		{
			return SdfPINVOKE.SdfLayerHandle_HasSessionOwner(swigCPtr);
		}

		public void ClearSessionOwner()
		{
			SdfPINVOKE.SdfLayerHandle_ClearSessionOwner(swigCPtr);
		}

		public bool GetHasOwnedSubLayers()
		{
			return SdfPINVOKE.SdfLayerHandle_GetHasOwnedSubLayers(swigCPtr);
		}

		public void SetHasOwnedSubLayers(bool arg0)
		{
			SdfPINVOKE.SdfLayerHandle_SetHasOwnedSubLayers(swigCPtr, arg0);
		}

		public VtDictionary GetCustomLayerData()
		{
			return new VtDictionary(SdfPINVOKE.SdfLayerHandle_GetCustomLayerData(swigCPtr), cMemoryOwn: true);
		}

		public void SetCustomLayerData(VtDictionary value)
		{
			SdfPINVOKE.SdfLayerHandle_SetCustomLayerData(swigCPtr, VtDictionary.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasCustomLayerData()
		{
			return SdfPINVOKE.SdfLayerHandle_HasCustomLayerData(swigCPtr);
		}

		public void ClearCustomLayerData()
		{
			SdfPINVOKE.SdfLayerHandle_ClearCustomLayerData(swigCPtr);
		}

		public SWIGTYPE_p_SdfPrimSpecView GetRootPrims()
		{
			return new SWIGTYPE_p_SdfPrimSpecView(SdfPINVOKE.SdfLayerHandle_GetRootPrims(swigCPtr), futureUse: true);
		}

		public void SetRootPrims(SdfPrimSpecHandleVector rootPrims)
		{
			SdfPINVOKE.SdfLayerHandle_SetRootPrims(swigCPtr, SdfPrimSpecHandleVector.getCPtr(rootPrims));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool InsertRootPrim(SdfPrimSpecHandle prim, int index)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_InsertRootPrim__SWIG_0(swigCPtr, SdfPrimSpecHandle.getCPtr(prim), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool InsertRootPrim(SdfPrimSpecHandle prim)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_InsertRootPrim__SWIG_1(swigCPtr, SdfPrimSpecHandle.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void RemoveRootPrim(SdfPrimSpecHandle prim)
		{
			SdfPINVOKE.SdfLayerHandle_RemoveRootPrim(swigCPtr, SdfPrimSpecHandle.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ScheduleRemoveIfInert(SdfSpec spec)
		{
			SdfPINVOKE.SdfLayerHandle_ScheduleRemoveIfInert(swigCPtr, SdfSpec.getCPtr(spec));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemovePrimIfInert(SdfPrimSpecHandle prim)
		{
			SdfPINVOKE.SdfLayerHandle_RemovePrimIfInert(swigCPtr, SdfPrimSpecHandle.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemovePropertyIfHasOnlyRequiredFields(SdfPropertySpecHandle prop)
		{
			SdfPINVOKE.SdfLayerHandle_RemovePropertyIfHasOnlyRequiredFields(swigCPtr, SdfPropertySpecHandle.getCPtr(prop));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveInertSceneDescription()
		{
			SdfPINVOKE.SdfLayerHandle_RemoveInertSceneDescription(swigCPtr);
		}

		public void SetRootPrimOrder(TfTokenVector names)
		{
			SdfPINVOKE.SdfLayerHandle_SetRootPrimOrder(swigCPtr, TfTokenVector.getCPtr(names));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInRootPrimOrder(TfToken name, int index)
		{
			SdfPINVOKE.SdfLayerHandle_InsertInRootPrimOrder__SWIG_0(swigCPtr, TfToken.getCPtr(name), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInRootPrimOrder(TfToken name)
		{
			SdfPINVOKE.SdfLayerHandle_InsertInRootPrimOrder__SWIG_1(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromRootPrimOrder(TfToken name)
		{
			SdfPINVOKE.SdfLayerHandle_RemoveFromRootPrimOrder(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromRootPrimOrderByIndex(int index)
		{
			SdfPINVOKE.SdfLayerHandle_RemoveFromRootPrimOrderByIndex(swigCPtr, index);
		}

		public void ApplyRootPrimOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfLayerHandle_ApplyRootPrimOrder(swigCPtr, TfTokenVector.getCPtr(vec));
		}

		public SdfSubLayerProxy GetSubLayerPaths()
		{
			return new SdfSubLayerProxy(SdfPINVOKE.SdfLayerHandle_GetSubLayerPaths(swigCPtr), cMemoryOwn: true);
		}

		public void SetSubLayerPaths(StdStringVector newPaths)
		{
			SdfPINVOKE.SdfLayerHandle_SetSubLayerPaths(swigCPtr, StdStringVector.getCPtr(newPaths));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public uint GetNumSubLayerPaths()
		{
			return SdfPINVOKE.SdfLayerHandle_GetNumSubLayerPaths(swigCPtr);
		}

		public void InsertSubLayerPath(string path, int index)
		{
			SdfPINVOKE.SdfLayerHandle_InsertSubLayerPath__SWIG_0(swigCPtr, path, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertSubLayerPath(string path)
		{
			SdfPINVOKE.SdfLayerHandle_InsertSubLayerPath__SWIG_1(swigCPtr, path);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveSubLayerPath(int index)
		{
			SdfPINVOKE.SdfLayerHandle_RemoveSubLayerPath(swigCPtr, index);
		}

		public SdfLayerOffsetVector GetSubLayerOffsets()
		{
			return new SdfLayerOffsetVector(SdfPINVOKE.SdfLayerHandle_GetSubLayerOffsets(swigCPtr), cMemoryOwn: true);
		}

		public SdfLayerOffset GetSubLayerOffset(int index)
		{
			return new SdfLayerOffset(SdfPINVOKE.SdfLayerHandle_GetSubLayerOffset(swigCPtr, index), cMemoryOwn: true);
		}

		public void SetSubLayerOffset(SdfLayerOffset offset, int index)
		{
			SdfPINVOKE.SdfLayerHandle_SetSubLayerOffset(swigCPtr, SdfLayerOffset.getCPtr(offset), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDetachedLayerRules(SdfLayer.DetachedLayerRules mask)
		{
			SdfPINVOKE.SdfLayerHandle_SetDetachedLayerRules(swigCPtr, SdfLayer.DetachedLayerRules.getCPtr(mask));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayer.DetachedLayerRules GetDetachedLayerRules()
		{
			return new SdfLayer.DetachedLayerRules(SdfPINVOKE.SdfLayerHandle_GetDetachedLayerRules(swigCPtr), cMemoryOwn: false);
		}

		public bool IsIncludedByDetachedLayerRules(string identifier)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_IsIncludedByDetachedLayerRules(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetMutedLayers()
		{
			return new StdStringSet(SdfPINVOKE.SdfLayerHandle_GetMutedLayers(swigCPtr), cMemoryOwn: true);
		}

		public bool IsMuted()
		{
			return SdfPINVOKE.SdfLayerHandle_IsMuted__SWIG_0(swigCPtr);
		}

		public bool IsMuted(string path)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_IsMuted__SWIG_1(swigCPtr, path);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetMuted(bool muted)
		{
			SdfPINVOKE.SdfLayerHandle_SetMuted(swigCPtr, muted);
		}

		public void AddToMutedLayers(string mutedPath)
		{
			SdfPINVOKE.SdfLayerHandle_AddToMutedLayers(swigCPtr, mutedPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromMutedLayers(string mutedPath)
		{
			SdfPINVOKE.SdfLayerHandle_RemoveFromMutedLayers(swigCPtr, mutedPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPrimSpecHandle GetPseudoRoot()
		{
			return new SdfPrimSpecHandle(SdfPINVOKE.SdfLayerHandle_GetPseudoRoot(swigCPtr), cMemoryOwn: true);
		}

		public SdfSpecHandle GetObjectAtPath(SdfPath path)
		{
			SdfSpecHandle result = new SdfSpecHandle(SdfPINVOKE.SdfLayerHandle_GetObjectAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetPrimAtPath(SdfPath path)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfLayerHandle_GetPrimAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPropertySpecHandle GetPropertyAtPath(SdfPath path)
		{
			SdfPropertySpecHandle result = new SdfPropertySpecHandle(SdfPINVOKE.SdfLayerHandle_GetPropertyAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAttributeSpecHandle GetAttributeAtPath(SdfPath path)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfLayerHandle_GetAttributeAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelationshipSpecHandle GetRelationshipAtPath(SdfPath path)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfLayerHandle_GetRelationshipAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfLayerHandle_PermissionToEdit(swigCPtr);
		}

		public bool PermissionToSave()
		{
			return SdfPINVOKE.SdfLayerHandle_PermissionToSave(swigCPtr);
		}

		public void SetPermissionToEdit(bool allow)
		{
			SdfPINVOKE.SdfLayerHandle_SetPermissionToEdit(swigCPtr, allow);
		}

		public void SetPermissionToSave(bool allow)
		{
			SdfPINVOKE.SdfLayerHandle_SetPermissionToSave(swigCPtr, allow);
		}

		public SdfNamespaceEditDetail.Result CanApply(SdfBatchNamespaceEdit arg0, SdfNamespaceEditDetailVector details)
		{
			SdfNamespaceEditDetail.Result result = (SdfNamespaceEditDetail.Result)SdfPINVOKE.SdfLayerHandle_CanApply__SWIG_0(swigCPtr, SdfBatchNamespaceEdit.getCPtr(arg0), SdfNamespaceEditDetailVector.getCPtr(details));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfNamespaceEditDetail.Result CanApply(SdfBatchNamespaceEdit arg0)
		{
			SdfNamespaceEditDetail.Result result = (SdfNamespaceEditDetail.Result)SdfPINVOKE.SdfLayerHandle_CanApply__SWIG_1(swigCPtr, SdfBatchNamespaceEdit.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Apply(SdfBatchNamespaceEdit arg0)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_Apply(swigCPtr, SdfBatchNamespaceEdit.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsDirty()
		{
			return SdfPINVOKE.SdfLayerHandle_IsDirty(swigCPtr);
		}

		public SWIGTYPE_p_std__setT_double_t ListAllTimeSamples()
		{
			return new SWIGTYPE_p_std__setT_double_t(SdfPINVOKE.SdfLayerHandle_ListAllTimeSamples(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_std__setT_double_t ListTimeSamplesForPath(SdfPath path)
		{
			SWIGTYPE_p_std__setT_double_t result = new SWIGTYPE_p_std__setT_double_t(SdfPINVOKE.SdfLayerHandle_ListTimeSamplesForPath(swigCPtr, SdfPath.getCPtr(path)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetBracketingTimeSamples(double time, out double tLower, out double tUpper)
		{
			return SdfPINVOKE.SdfLayerHandle_GetBracketingTimeSamples(swigCPtr, time, out tLower, out tUpper);
		}

		public uint GetNumTimeSamplesForPath(SdfPath path)
		{
			uint result = SdfPINVOKE.SdfLayerHandle_GetNumTimeSamplesForPath(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetBracketingTimeSamplesForPath(SdfPath path, double time, out double tLower, out double tUpper)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_GetBracketingTimeSamplesForPath(swigCPtr, SdfPath.getCPtr(path), time, out tLower, out tUpper);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_QueryTimeSample__SWIG_0(swigCPtr, SdfPath.getCPtr(path), time, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_QueryTimeSample__SWIG_1(swigCPtr, SdfPath.getCPtr(path), time);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_QueryTimeSample__SWIG_2(swigCPtr, SdfPath.getCPtr(path), time, SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetTimeSample(SdfPath path, double time, VtValue value)
		{
			SdfPINVOKE.SdfLayerHandle_SetTimeSample__SWIG_0(swigCPtr, SdfPath.getCPtr(path), time, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetTimeSample(SdfPath path, double time, SWIGTYPE_p_SdfAbstractDataConstValue value)
		{
			SdfPINVOKE.SdfLayerHandle_SetTimeSample__SWIG_1(swigCPtr, SdfPath.getCPtr(path), time, SWIGTYPE_p_SdfAbstractDataConstValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseTimeSample(SdfPath path, double time)
		{
			SdfPINVOKE.SdfLayerHandle_EraseTimeSample(swigCPtr, SdfPath.getCPtr(path), time);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void DumpLayerInfo()
		{
			SdfPINVOKE.SdfLayerHandle_DumpLayerInfo(swigCPtr);
		}

		public bool WriteDataFile(string filename)
		{
			bool result = SdfPINVOKE.SdfLayerHandle_WriteDataFile(swigCPtr, filename);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string ExportToString()
		{
			return SdfPINVOKE.SdfLayerHandle_ExportToString(swigCPtr);
		}
	}
}
