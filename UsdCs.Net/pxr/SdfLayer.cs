using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayer : IDisposable
	{
		public class DetachedLayerRules : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public DetachedLayerRules(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(DetachedLayerRules obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(DetachedLayerRules obj)
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

			~DetachedLayerRules()
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
							SdfPINVOKE.delete_SdfLayer_DetachedLayerRules(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public DetachedLayerRules()
				: this(SdfPINVOKE.new_SdfLayer_DetachedLayerRules(), cMemoryOwn: true)
			{
			}

			public DetachedLayerRules IncludeAll()
			{
				return new DetachedLayerRules(SdfPINVOKE.SdfLayer_DetachedLayerRules_IncludeAll(swigCPtr), cMemoryOwn: false);
			}

			public DetachedLayerRules Include(StdStringVector patterns)
			{
				DetachedLayerRules result = new DetachedLayerRules(SdfPINVOKE.SdfLayer_DetachedLayerRules_Include(swigCPtr, StdStringVector.getCPtr(patterns)), cMemoryOwn: false);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public DetachedLayerRules Exclude(StdStringVector patterns)
			{
				DetachedLayerRules result = new DetachedLayerRules(SdfPINVOKE.SdfLayer_DetachedLayerRules_Exclude(swigCPtr, StdStringVector.getCPtr(patterns)), cMemoryOwn: false);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public bool IncludedAll()
			{
				return SdfPINVOKE.SdfLayer_DetachedLayerRules_IncludedAll(swigCPtr);
			}

			public StdStringVector GetIncluded()
			{
				return new StdStringVector(SdfPINVOKE.SdfLayer_DetachedLayerRules_GetIncluded(swigCPtr), cMemoryOwn: false);
			}

			public StdStringVector GetExcluded()
			{
				return new StdStringVector(SdfPINVOKE.SdfLayer_DetachedLayerRules_GetExcluded(swigCPtr), cMemoryOwn: false);
			}

			public bool IsIncluded(string identifier)
			{
				bool result = SdfPINVOKE.SdfLayer_DetachedLayerRules_IsIncluded(swigCPtr, identifier);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

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

		internal SdfLayer(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(SdfLayer obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~SdfLayer()
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
					if (swigCMemOwnBase)
					{
						swigCMemOwnBase = false;
						SdfPINVOKE.delete_SdfLayer(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			SWIGTYPE_p_SdfSchemaBase result = new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfLayer_GetSchema(swigCPtr), futureUse: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfFileFormat GetFileFormat()
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_GetFileFormat(swigCPtr);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringMap GetFileFormatArguments()
		{
			StdStringMap result = new StdStringMap(SdfPINVOKE.SdfLayer_GetFileFormatArguments(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandle CreateNew(string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateNew__SWIG_0(identifier, StdStringMap.getCPtr(args));
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

		public static SdfLayerHandle CreateNew(string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateNew__SWIG_1(identifier);
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

		public static SdfLayerHandle CreateNew(SdfFileFormat fileFormat, string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateNew__SWIG_2(SdfFileFormat.getCPtr(fileFormat), identifier, StdStringMap.getCPtr(args));
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

		public static SdfLayerHandle CreateNew(SdfFileFormat fileFormat, string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateNew__SWIG_3(SdfFileFormat.getCPtr(fileFormat), identifier);
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

		public static SdfLayerHandle New(SdfFileFormat fileFormat, string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_New__SWIG_0(SdfFileFormat.getCPtr(fileFormat), identifier, StdStringMap.getCPtr(args));
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

		public static SdfLayerHandle New(SdfFileFormat fileFormat, string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_New__SWIG_1(SdfFileFormat.getCPtr(fileFormat), identifier);
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

		public static SdfLayerHandle Find(string identifier, StdStringMap args)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayer_Find__SWIG_0(identifier, StdStringMap.getCPtr(args)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandle Find(string identifier)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayer_Find__SWIG_1(identifier), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandle FindRelativeToLayer(SdfLayerHandle anchor, string identifier, StdStringMap args)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayer_FindRelativeToLayer__SWIG_0(SdfLayerHandle.getCPtr(anchor), identifier, StdStringMap.getCPtr(args)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandle FindRelativeToLayer(SdfLayerHandle anchor, string identifier)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayer_FindRelativeToLayer__SWIG_1(SdfLayerHandle.getCPtr(anchor), identifier), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandle FindOrOpen(string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_FindOrOpen__SWIG_0(identifier, StdStringMap.getCPtr(args));
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

		public static SdfLayerHandle FindOrOpen(string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_FindOrOpen__SWIG_1(identifier);
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

		public static SdfLayerHandle FindOrOpenRelativeToLayer(SdfLayerHandle anchor, string identifier, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_FindOrOpenRelativeToLayer__SWIG_0(SdfLayerHandle.getCPtr(anchor), identifier, StdStringMap.getCPtr(args));
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

		public static SdfLayerHandle FindOrOpenRelativeToLayer(SdfLayerHandle anchor, string identifier)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_FindOrOpenRelativeToLayer__SWIG_1(SdfLayerHandle.getCPtr(anchor), identifier);
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

		public static SdfLayerHandle OpenAsAnonymous(string layerPath, bool metadataOnly, string tag)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_OpenAsAnonymous__SWIG_0(layerPath, metadataOnly, tag);
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

		public static SdfLayerHandle OpenAsAnonymous(string layerPath, bool metadataOnly)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_OpenAsAnonymous__SWIG_1(layerPath, metadataOnly);
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

		public static SdfLayerHandle OpenAsAnonymous(string layerPath)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_OpenAsAnonymous__SWIG_2(layerPath);
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
			SdfLayerHints result = new SdfLayerHints(SdfPINVOKE.SdfLayer_GetHints(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfLayerHandleSet GetLoadedLayers()
		{
			return new SdfLayerHandleSet(SdfPINVOKE.SdfLayer_GetLoadedLayers(), cMemoryOwn: true);
		}

		public bool IsEmpty()
		{
			bool result = SdfPINVOKE.SdfLayer_IsEmpty(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool StreamsData()
		{
			bool result = SdfPINVOKE.SdfLayer_StreamsData(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsDetached()
		{
			bool result = SdfPINVOKE.SdfLayer_IsDetached(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void TransferContent(SdfLayerHandle layer)
		{
			SdfPINVOKE.SdfLayer_TransferContent(swigCPtr, SdfLayerHandle.getCPtr(layer));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfLayerHandle CreateAnonymous(string tag, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateAnonymous__SWIG_0(tag, StdStringMap.getCPtr(args));
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

		public static SdfLayerHandle CreateAnonymous(string tag)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateAnonymous__SWIG_1(tag);
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

		public static SdfLayerHandle CreateAnonymous()
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateAnonymous__SWIG_2();
			HandleRefWrapper handleRefWrapper = new HandleRefWrapper(intPtr, cMemoryOwn: false);
			IntPtr handlePtr = handleRefWrapper.handlePtr;
			IntPtr refPtr = handleRefWrapper.refPtr;
			return (intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(handlePtr, refPtr, cMemoryOwn: true);
		}

		public static SdfLayerHandle CreateAnonymous(string tag, SdfFileFormat format, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateAnonymous__SWIG_3(tag, SdfFileFormat.getCPtr(format), StdStringMap.getCPtr(args));
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

		public static SdfLayerHandle CreateAnonymous(string tag, SdfFileFormat format)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayer_CreateAnonymous__SWIG_4(tag, SdfFileFormat.getCPtr(format));
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
			bool result = SdfPINVOKE.SdfLayer_IsAnonymous(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsAnonymousLayerIdentifier(string identifier)
		{
			bool result = SdfPINVOKE.SdfLayer_IsAnonymousLayerIdentifier(identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string GetDisplayNameFromIdentifier(string identifier)
		{
			string result = SdfPINVOKE.SdfLayer_GetDisplayNameFromIdentifier(identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Save(bool force)
		{
			bool result = SdfPINVOKE.SdfLayer_Save__SWIG_0(swigCPtr, force);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Save()
		{
			bool result = SdfPINVOKE.SdfLayer_Save__SWIG_1(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename, string comment, StdStringMap args)
		{
			bool result = SdfPINVOKE.SdfLayer_Export__SWIG_0(swigCPtr, filename, comment, StdStringMap.getCPtr(args));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename, string comment)
		{
			bool result = SdfPINVOKE.SdfLayer_Export__SWIG_1(swigCPtr, filename, comment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Export(string filename)
		{
			bool result = SdfPINVOKE.SdfLayer_Export__SWIG_2(swigCPtr, filename);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ImportFromString(string string_)
		{
			bool result = SdfPINVOKE.SdfLayer_ImportFromString(swigCPtr, string_);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Clear()
		{
			SdfPINVOKE.SdfLayer_Clear(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Reload(bool force)
		{
			bool result = SdfPINVOKE.SdfLayer_Reload__SWIG_0(swigCPtr, force);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Reload()
		{
			bool result = SdfPINVOKE.SdfLayer_Reload__SWIG_1(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ReloadLayers(SdfLayerHandleSet layers, bool force)
		{
			bool result = SdfPINVOKE.SdfLayer_ReloadLayers__SWIG_0(SdfLayerHandleSet.getCPtr(layers), force);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ReloadLayers(SdfLayerHandleSet layers)
		{
			bool result = SdfPINVOKE.SdfLayer_ReloadLayers__SWIG_1(SdfLayerHandleSet.getCPtr(layers));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Import(string layerPath)
		{
			bool result = SdfPINVOKE.SdfLayer_Import(swigCPtr, layerPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetExternalReferences()
		{
			StdStringSet result = new StdStringSet(SdfPINVOKE.SdfLayer_GetExternalReferences(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UpdateExternalReference(string oldAssetPath, string newAssetPath)
		{
			bool result = SdfPINVOKE.SdfLayer_UpdateExternalReference__SWIG_0(swigCPtr, oldAssetPath, newAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UpdateExternalReference(string oldAssetPath)
		{
			bool result = SdfPINVOKE.SdfLayer_UpdateExternalReference__SWIG_1(swigCPtr, oldAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetCompositionAssetDependencies()
		{
			StdStringSet result = new StdStringSet(SdfPINVOKE.SdfLayer_GetCompositionAssetDependencies(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UpdateCompositionAssetDependency(string oldAssetPath, string newAssetPath)
		{
			bool result = SdfPINVOKE.SdfLayer_UpdateCompositionAssetDependency__SWIG_0(swigCPtr, oldAssetPath, newAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UpdateCompositionAssetDependency(string oldAssetPath)
		{
			bool result = SdfPINVOKE.SdfLayer_UpdateCompositionAssetDependency__SWIG_1(swigCPtr, oldAssetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringSet GetExternalAssetDependencies()
		{
			StdStringSet result = new StdStringSet(SdfPINVOKE.SdfLayer_GetExternalAssetDependencies(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SplitIdentifier(string identifier, out string layerPath, StdStringMap arguments)
		{
			bool result = SdfPINVOKE.SdfLayer_SplitIdentifier(identifier, out layerPath, StdStringMap.getCPtr(arguments));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string CreateIdentifier(string layerPath, StdStringMap arguments)
		{
			string result = SdfPINVOKE.SdfLayer_CreateIdentifier(layerPath, StdStringMap.getCPtr(arguments));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private string GetIdentifier()
		{
			string result = SdfPINVOKE.SdfLayer_GetIdentifier(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void SetIdentifier(string identifier)
		{
			SdfPINVOKE.SdfLayer_SetIdentifier(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void UpdateAssetInfo()
		{
			SdfPINVOKE.SdfLayer_UpdateAssetInfo(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayName()
		{
			string result = SdfPINVOKE.SdfLayer_GetDisplayName(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_ArResolvedPath GetResolvedPath()
		{
			SWIGTYPE_p_ArResolvedPath result = new SWIGTYPE_p_ArResolvedPath(SdfPINVOKE.SdfLayer_GetResolvedPath(swigCPtr), futureUse: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetRealPath()
		{
			string result = SdfPINVOKE.SdfLayer_GetRealPath(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetFileExtension()
		{
			string result = SdfPINVOKE.SdfLayer_GetFileExtension(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetVersion()
		{
			string result = SdfPINVOKE.SdfLayer_GetVersion(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetRepositoryPath()
		{
			string result = SdfPINVOKE.SdfLayer_GetRepositoryPath(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetAssetName()
		{
			string result = SdfPINVOKE.SdfLayer_GetAssetName(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetAssetInfo()
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfLayer_GetAssetInfo(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string ComputeAbsolutePath(string assetPath)
		{
			string result = SdfPINVOKE.SdfLayer_ComputeAbsolutePath(swigCPtr, assetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecType GetSpecType(SdfPath path)
		{
			SdfSpecType result = (SdfSpecType)SdfPINVOKE.SdfLayer_GetSpecType(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasSpec(SdfPath path)
		{
			bool result = SdfPINVOKE.SdfLayer_HasSpec(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector ListFields(SdfPath path)
		{
			TfTokenVector result = new TfTokenVector(SdfPINVOKE.SdfLayer_ListFields(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayer_HasField__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName)
		{
			bool result = SdfPINVOKE.SdfLayer_HasField__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasField(SdfPath path, TfToken fieldName, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayer_HasField__SWIG_2(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayer_HasFieldDictKey__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath)
		{
			bool result = SdfPINVOKE.SdfLayer_HasFieldDictKey__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasFieldDictKey(SdfPath path, TfToken fieldName, TfToken keyPath, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayer_HasFieldDictKey__SWIG_2(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(SdfPath path, TfToken fieldName)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfLayer_GetField(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfLayer_GetFieldDictValueByKey(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetField(SdfPath path, TfToken fieldName, VtValue value)
		{
			SdfPINVOKE.SdfLayer_SetField__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetField(SdfPath path, TfToken fieldName, SWIGTYPE_p_SdfAbstractDataConstValue value)
		{
			SdfPINVOKE.SdfLayer_SetField__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), SWIGTYPE_p_SdfAbstractDataConstValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath, VtValue value)
		{
			SdfPINVOKE.SdfLayer_SetFieldDictValueByKey__SWIG_0(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath, SWIGTYPE_p_SdfAbstractDataConstValue value)
		{
			SdfPINVOKE.SdfLayer_SetFieldDictValueByKey__SWIG_1(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath), SWIGTYPE_p_SdfAbstractDataConstValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseField(SdfPath path, TfToken fieldName)
		{
			SdfPINVOKE.SdfLayer_EraseField(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseFieldDictValueByKey(SdfPath path, TfToken fieldName, TfToken keyPath)
		{
			SdfPINVOKE.SdfLayer_EraseFieldDictValueByKey(swigCPtr, SdfPath.getCPtr(path), TfToken.getCPtr(fieldName), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAssetPath GetColorConfiguration()
		{
			SdfAssetPath result = new SdfAssetPath(SdfPINVOKE.SdfLayer_GetColorConfiguration(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetColorConfiguration(SdfAssetPath colorConfiguration)
		{
			SdfPINVOKE.SdfLayer_SetColorConfiguration(swigCPtr, SdfAssetPath.getCPtr(colorConfiguration));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasColorConfiguration()
		{
			bool result = SdfPINVOKE.SdfLayer_HasColorConfiguration(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearColorConfiguration()
		{
			SdfPINVOKE.SdfLayer_ClearColorConfiguration(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetColorManagementSystem()
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfLayer_GetColorManagementSystem(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetColorManagementSystem(TfToken cms)
		{
			SdfPINVOKE.SdfLayer_SetColorManagementSystem(swigCPtr, TfToken.getCPtr(cms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasColorManagementSystem()
		{
			bool result = SdfPINVOKE.SdfLayer_HasColorManagementSystem(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearColorManagementSystem()
		{
			SdfPINVOKE.SdfLayer_ClearColorManagementSystem(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetComment()
		{
			string result = SdfPINVOKE.SdfLayer_GetComment(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetComment(string comment)
		{
			SdfPINVOKE.SdfLayer_SetComment(swigCPtr, comment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetDefaultPrim()
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfLayer_GetDefaultPrim(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetDefaultPrim(TfToken name)
		{
			SdfPINVOKE.SdfLayer_SetDefaultPrim(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ClearDefaultPrim()
		{
			SdfPINVOKE.SdfLayer_ClearDefaultPrim(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasDefaultPrim()
		{
			bool result = SdfPINVOKE.SdfLayer_HasDefaultPrim(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetDocumentation()
		{
			string result = SdfPINVOKE.SdfLayer_GetDocumentation(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetDocumentation(string documentation)
		{
			SdfPINVOKE.SdfLayer_SetDocumentation(swigCPtr, documentation);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetStartTimeCode()
		{
			double result = SdfPINVOKE.SdfLayer_GetStartTimeCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetStartTimeCode(double startTimecode)
		{
			SdfPINVOKE.SdfLayer_SetStartTimeCode(swigCPtr, startTimecode);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasStartTimeCode()
		{
			bool result = SdfPINVOKE.SdfLayer_HasStartTimeCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearStartTimeCode()
		{
			SdfPINVOKE.SdfLayer_ClearStartTimeCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetEndTimeCode()
		{
			double result = SdfPINVOKE.SdfLayer_GetEndTimeCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetEndTimeCode(double endTimeCode)
		{
			SdfPINVOKE.SdfLayer_SetEndTimeCode(swigCPtr, endTimeCode);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasEndTimeCode()
		{
			bool result = SdfPINVOKE.SdfLayer_HasEndTimeCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearEndTimeCode()
		{
			SdfPINVOKE.SdfLayer_ClearEndTimeCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetTimeCodesPerSecond()
		{
			double result = SdfPINVOKE.SdfLayer_GetTimeCodesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetTimeCodesPerSecond(double timeCodesPerSecond)
		{
			SdfPINVOKE.SdfLayer_SetTimeCodesPerSecond(swigCPtr, timeCodesPerSecond);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasTimeCodesPerSecond()
		{
			bool result = SdfPINVOKE.SdfLayer_HasTimeCodesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearTimeCodesPerSecond()
		{
			SdfPINVOKE.SdfLayer_ClearTimeCodesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetFramesPerSecond()
		{
			double result = SdfPINVOKE.SdfLayer_GetFramesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetFramesPerSecond(double framesPerSecond)
		{
			SdfPINVOKE.SdfLayer_SetFramesPerSecond(swigCPtr, framesPerSecond);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasFramesPerSecond()
		{
			bool result = SdfPINVOKE.SdfLayer_HasFramesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearFramesPerSecond()
		{
			SdfPINVOKE.SdfLayer_ClearFramesPerSecond(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public int GetFramePrecision()
		{
			int result = SdfPINVOKE.SdfLayer_GetFramePrecision(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetFramePrecision(int framePrecision)
		{
			SdfPINVOKE.SdfLayer_SetFramePrecision(swigCPtr, framePrecision);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasFramePrecision()
		{
			bool result = SdfPINVOKE.SdfLayer_HasFramePrecision(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearFramePrecision()
		{
			SdfPINVOKE.SdfLayer_ClearFramePrecision(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetOwner()
		{
			string result = SdfPINVOKE.SdfLayer_GetOwner(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetOwner(string owner)
		{
			SdfPINVOKE.SdfLayer_SetOwner(swigCPtr, owner);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasOwner()
		{
			bool result = SdfPINVOKE.SdfLayer_HasOwner(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearOwner()
		{
			SdfPINVOKE.SdfLayer_ClearOwner(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSessionOwner()
		{
			string result = SdfPINVOKE.SdfLayer_GetSessionOwner(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetSessionOwner(string owner)
		{
			SdfPINVOKE.SdfLayer_SetSessionOwner(swigCPtr, owner);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasSessionOwner()
		{
			bool result = SdfPINVOKE.SdfLayer_HasSessionOwner(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearSessionOwner()
		{
			SdfPINVOKE.SdfLayer_ClearSessionOwner(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetHasOwnedSubLayers()
		{
			bool result = SdfPINVOKE.SdfLayer_GetHasOwnedSubLayers(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetHasOwnedSubLayers(bool arg0)
		{
			SdfPINVOKE.SdfLayer_SetHasOwnedSubLayers(swigCPtr, arg0);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDictionary GetCustomLayerData()
		{
			VtDictionary result = new VtDictionary(SdfPINVOKE.SdfLayer_GetCustomLayerData(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetCustomLayerData(VtDictionary value)
		{
			SdfPINVOKE.SdfLayer_SetCustomLayerData(swigCPtr, VtDictionary.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasCustomLayerData()
		{
			bool result = SdfPINVOKE.SdfLayer_HasCustomLayerData(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearCustomLayerData()
		{
			SdfPINVOKE.SdfLayer_ClearCustomLayerData(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfPrimSpecView GetRootPrims()
		{
			SWIGTYPE_p_SdfPrimSpecView result = new SWIGTYPE_p_SdfPrimSpecView(SdfPINVOKE.SdfLayer_GetRootPrims(swigCPtr), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetRootPrims(SdfPrimSpecHandleVector rootPrims)
		{
			SdfPINVOKE.SdfLayer_SetRootPrims(swigCPtr, SdfPrimSpecHandleVector.getCPtr(rootPrims));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool InsertRootPrim(SdfPrimSpecHandle prim, int index)
		{
			bool result = SdfPINVOKE.SdfLayer_InsertRootPrim__SWIG_0(swigCPtr, SdfPrimSpecHandle.getCPtr(prim), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool InsertRootPrim(SdfPrimSpecHandle prim)
		{
			bool result = SdfPINVOKE.SdfLayer_InsertRootPrim__SWIG_1(swigCPtr, SdfPrimSpecHandle.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void RemoveRootPrim(SdfPrimSpecHandle prim)
		{
			SdfPINVOKE.SdfLayer_RemoveRootPrim(swigCPtr, SdfPrimSpecHandle.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ScheduleRemoveIfInert(SdfSpec spec)
		{
			SdfPINVOKE.SdfLayer_ScheduleRemoveIfInert(swigCPtr, SdfSpec.getCPtr(spec));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemovePrimIfInert(SdfPrimSpecHandle prim)
		{
			SdfPINVOKE.SdfLayer_RemovePrimIfInert(swigCPtr, SdfPrimSpecHandle.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemovePropertyIfHasOnlyRequiredFields(SdfPropertySpecHandle prop)
		{
			SdfPINVOKE.SdfLayer_RemovePropertyIfHasOnlyRequiredFields(swigCPtr, SdfPropertySpecHandle.getCPtr(prop));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveInertSceneDescription()
		{
			SdfPINVOKE.SdfLayer_RemoveInertSceneDescription(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRootPrimOrder(TfTokenVector names)
		{
			SdfPINVOKE.SdfLayer_SetRootPrimOrder(swigCPtr, TfTokenVector.getCPtr(names));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInRootPrimOrder(TfToken name, int index)
		{
			SdfPINVOKE.SdfLayer_InsertInRootPrimOrder__SWIG_0(swigCPtr, TfToken.getCPtr(name), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertInRootPrimOrder(TfToken name)
		{
			SdfPINVOKE.SdfLayer_InsertInRootPrimOrder__SWIG_1(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromRootPrimOrder(TfToken name)
		{
			SdfPINVOKE.SdfLayer_RemoveFromRootPrimOrder(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveFromRootPrimOrderByIndex(int index)
		{
			SdfPINVOKE.SdfLayer_RemoveFromRootPrimOrderByIndex(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ApplyRootPrimOrder(TfTokenVector vec)
		{
			SdfPINVOKE.SdfLayer_ApplyRootPrimOrder(swigCPtr, TfTokenVector.getCPtr(vec));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfSubLayerProxy GetSubLayerPaths()
		{
			SdfSubLayerProxy result = new SdfSubLayerProxy(SdfPINVOKE.SdfLayer_GetSubLayerPaths(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetSubLayerPaths(StdStringVector newPaths)
		{
			SdfPINVOKE.SdfLayer_SetSubLayerPaths(swigCPtr, StdStringVector.getCPtr(newPaths));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public uint GetNumSubLayerPaths()
		{
			uint result = SdfPINVOKE.SdfLayer_GetNumSubLayerPaths(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void InsertSubLayerPath(string path, int index)
		{
			SdfPINVOKE.SdfLayer_InsertSubLayerPath__SWIG_0(swigCPtr, path, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertSubLayerPath(string path)
		{
			SdfPINVOKE.SdfLayer_InsertSubLayerPath__SWIG_1(swigCPtr, path);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveSubLayerPath(int index)
		{
			SdfPINVOKE.SdfLayer_RemoveSubLayerPath(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerOffsetVector GetSubLayerOffsets()
		{
			SdfLayerOffsetVector result = new SdfLayerOffsetVector(SdfPINVOKE.SdfLayer_GetSubLayerOffsets(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerOffset GetSubLayerOffset(int index)
		{
			SdfLayerOffset result = new SdfLayerOffset(SdfPINVOKE.SdfLayer_GetSubLayerOffset(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetSubLayerOffset(SdfLayerOffset offset, int index)
		{
			SdfPINVOKE.SdfLayer_SetSubLayerOffset(swigCPtr, SdfLayerOffset.getCPtr(offset), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void SetDetachedLayerRules(DetachedLayerRules mask)
		{
			SdfPINVOKE.SdfLayer_SetDetachedLayerRules(DetachedLayerRules.getCPtr(mask));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static DetachedLayerRules GetDetachedLayerRules()
		{
			return new DetachedLayerRules(SdfPINVOKE.SdfLayer_GetDetachedLayerRules(), cMemoryOwn: false);
		}

		public static bool IsIncludedByDetachedLayerRules(string identifier)
		{
			bool result = SdfPINVOKE.SdfLayer_IsIncludedByDetachedLayerRules(identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringSet GetMutedLayers()
		{
			return new StdStringSet(SdfPINVOKE.SdfLayer_GetMutedLayers(), cMemoryOwn: true);
		}

		public bool IsMuted()
		{
			bool result = SdfPINVOKE.SdfLayer_IsMuted__SWIG_0(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsMuted(string path)
		{
			bool result = SdfPINVOKE.SdfLayer_IsMuted__SWIG_1(path);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetMuted(bool muted)
		{
			SdfPINVOKE.SdfLayer_SetMuted(swigCPtr, muted);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void AddToMutedLayers(string mutedPath)
		{
			SdfPINVOKE.SdfLayer_AddToMutedLayers(mutedPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void RemoveFromMutedLayers(string mutedPath)
		{
			SdfPINVOKE.SdfLayer_RemoveFromMutedLayers(mutedPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPrimSpecHandle GetPseudoRoot()
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfLayer_GetPseudoRoot(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecHandle GetObjectAtPath(SdfPath path)
		{
			SdfSpecHandle result = new SdfSpecHandle(SdfPINVOKE.SdfLayer_GetObjectAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetPrimAtPath(SdfPath path)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfLayer_GetPrimAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPropertySpecHandle GetPropertyAtPath(SdfPath path)
		{
			SdfPropertySpecHandle result = new SdfPropertySpecHandle(SdfPINVOKE.SdfLayer_GetPropertyAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfAttributeSpecHandle GetAttributeAtPath(SdfPath path)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfLayer_GetAttributeAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfRelationshipSpecHandle GetRelationshipAtPath(SdfPath path)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfLayer_GetRelationshipAtPath(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool PermissionToEdit()
		{
			bool result = SdfPINVOKE.SdfLayer_PermissionToEdit(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool PermissionToSave()
		{
			bool result = SdfPINVOKE.SdfLayer_PermissionToSave(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetPermissionToEdit(bool allow)
		{
			SdfPINVOKE.SdfLayer_SetPermissionToEdit(swigCPtr, allow);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPermissionToSave(bool allow)
		{
			SdfPINVOKE.SdfLayer_SetPermissionToSave(swigCPtr, allow);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfNamespaceEditDetail.Result CanApply(SdfBatchNamespaceEdit arg0, SdfNamespaceEditDetailVector details)
		{
			SdfNamespaceEditDetail.Result result = (SdfNamespaceEditDetail.Result)SdfPINVOKE.SdfLayer_CanApply__SWIG_0(swigCPtr, SdfBatchNamespaceEdit.getCPtr(arg0), SdfNamespaceEditDetailVector.getCPtr(details));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfNamespaceEditDetail.Result CanApply(SdfBatchNamespaceEdit arg0)
		{
			SdfNamespaceEditDetail.Result result = (SdfNamespaceEditDetail.Result)SdfPINVOKE.SdfLayer_CanApply__SWIG_1(swigCPtr, SdfBatchNamespaceEdit.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Apply(SdfBatchNamespaceEdit arg0)
		{
			bool result = SdfPINVOKE.SdfLayer_Apply(swigCPtr, SdfBatchNamespaceEdit.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsDirty()
		{
			bool result = SdfPINVOKE.SdfLayer_IsDirty(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__setT_double_t ListAllTimeSamples()
		{
			SWIGTYPE_p_std__setT_double_t result = new SWIGTYPE_p_std__setT_double_t(SdfPINVOKE.SdfLayer_ListAllTimeSamples(swigCPtr), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__setT_double_t ListTimeSamplesForPath(SdfPath path)
		{
			SWIGTYPE_p_std__setT_double_t result = new SWIGTYPE_p_std__setT_double_t(SdfPINVOKE.SdfLayer_ListTimeSamplesForPath(swigCPtr, SdfPath.getCPtr(path)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetBracketingTimeSamples(double time, out double tLower, out double tUpper)
		{
			bool result = SdfPINVOKE.SdfLayer_GetBracketingTimeSamples(swigCPtr, time, out tLower, out tUpper);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetNumTimeSamplesForPath(SdfPath path)
		{
			uint result = SdfPINVOKE.SdfLayer_GetNumTimeSamplesForPath(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetBracketingTimeSamplesForPath(SdfPath path, double time, out double tLower, out double tUpper)
		{
			bool result = SdfPINVOKE.SdfLayer_GetBracketingTimeSamplesForPath(swigCPtr, SdfPath.getCPtr(path), time, out tLower, out tUpper);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time, VtValue value)
		{
			bool result = SdfPINVOKE.SdfLayer_QueryTimeSample__SWIG_0(swigCPtr, SdfPath.getCPtr(path), time, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time)
		{
			bool result = SdfPINVOKE.SdfLayer_QueryTimeSample__SWIG_1(swigCPtr, SdfPath.getCPtr(path), time);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool QueryTimeSample(SdfPath path, double time, SWIGTYPE_p_SdfAbstractDataValue value)
		{
			bool result = SdfPINVOKE.SdfLayer_QueryTimeSample__SWIG_2(swigCPtr, SdfPath.getCPtr(path), time, SWIGTYPE_p_SdfAbstractDataValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetTimeSample(SdfPath path, double time, VtValue value)
		{
			SdfPINVOKE.SdfLayer_SetTimeSample__SWIG_0(swigCPtr, SdfPath.getCPtr(path), time, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetTimeSample(SdfPath path, double time, SWIGTYPE_p_SdfAbstractDataConstValue value)
		{
			SdfPINVOKE.SdfLayer_SetTimeSample__SWIG_1(swigCPtr, SdfPath.getCPtr(path), time, SWIGTYPE_p_SdfAbstractDataConstValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseTimeSample(SdfPath path, double time)
		{
			SdfPINVOKE.SdfLayer_EraseTimeSample(swigCPtr, SdfPath.getCPtr(path), time);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void DumpLayerInfo()
		{
			SdfPINVOKE.SdfLayer_DumpLayerInfo();
		}

		public bool WriteDataFile(string filename)
		{
			bool result = SdfPINVOKE.SdfLayer_WriteDataFile(swigCPtr, filename);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string ExportToString()
		{
			string result = SdfPINVOKE.SdfLayer_ExportToString(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override int GetHashCode()
		{
			int result = SdfPINVOKE.SdfLayer_GetHashCode(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
