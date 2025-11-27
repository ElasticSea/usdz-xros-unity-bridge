using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfFileFormat : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

		internal SdfFileFormat(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(SdfFileFormat obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~SdfFileFormat()
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
						SdfPINVOKE.delete_SdfFileFormat(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			SWIGTYPE_p_SdfSchemaBase result = new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfFileFormat_GetSchema(swigCPtr), futureUse: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetFormatId()
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfFileFormat_GetFormatId(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetTarget()
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfFileFormat_GetTarget(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetFileCookie()
		{
			string result = SdfPINVOKE.SdfFileFormat_GetFileCookie(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetVersionString()
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfFileFormat_GetVersionString(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsPrimaryFormatForExtensions()
		{
			bool result = SdfPINVOKE.SdfFileFormat_IsPrimaryFormatForExtensions(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringVector GetFileExtensions()
		{
			StdStringVector result = new StdStringVector(SdfPINVOKE.SdfFileFormat_GetFileExtensions(swigCPtr), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetPrimaryFileExtension()
		{
			string result = SdfPINVOKE.SdfFileFormat_GetPrimaryFileExtension(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsSupportedExtension(string extension)
		{
			bool result = SdfPINVOKE.SdfFileFormat_IsSupportedExtension(swigCPtr, extension);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool IsPackage()
		{
			bool result = SdfPINVOKE.SdfFileFormat_IsPackage(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual string GetPackageRootLayerPath(string resolvedPath)
		{
			string result = SdfPINVOKE.SdfFileFormat_GetPackageRootLayerPath(swigCPtr, resolvedPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual StdStringMap GetDefaultFileFormatArguments()
		{
			StdStringMap result = new StdStringMap(SdfPINVOKE.SdfFileFormat_GetDefaultFileFormatArguments(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual SWIGTYPE_p_SdfAbstractData InitData(StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormat_InitData(swigCPtr, StdStringMap.getCPtr(args));
			SWIGTYPE_p_SdfAbstractData result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SdfAbstractData(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_SdfAbstractData InitDetachedData(StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormat_InitDetachedData(swigCPtr, StdStringMap.getCPtr(args));
			SWIGTYPE_p_SdfAbstractData result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SdfAbstractData(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfLayerHandle NewLayer(SdfFileFormat fileFormat, string identifier, string realPath, SWIGTYPE_p_ArAssetInfo assetInfo, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormat_NewLayer(swigCPtr, getCPtr(fileFormat), identifier, realPath, SWIGTYPE_p_ArAssetInfo.getCPtr(assetInfo), StdStringMap.getCPtr(args));
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

		public bool ShouldSkipAnonymousReload()
		{
			bool result = SdfPINVOKE.SdfFileFormat_ShouldSkipAnonymousReload(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ShouldReadAnonymousLayers()
		{
			bool result = SdfPINVOKE.SdfFileFormat_ShouldReadAnonymousLayers(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool CanRead(string file)
		{
			bool result = SdfPINVOKE.SdfFileFormat_CanRead(swigCPtr, file);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool Read(SdfLayer layer, string resolvedPath, bool metadataOnly)
		{
			bool result = SdfPINVOKE.SdfFileFormat_Read(swigCPtr, SdfLayer.getCPtr(layer), resolvedPath, metadataOnly);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ReadDetached(SdfLayer layer, string resolvedPath, bool metadataOnly)
		{
			bool result = SdfPINVOKE.SdfFileFormat_ReadDetached(swigCPtr, SdfLayer.getCPtr(layer), resolvedPath, metadataOnly);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool WriteToFile(SdfLayer layer, string filePath, string comment, StdStringMap args)
		{
			bool result = SdfPINVOKE.SdfFileFormat_WriteToFile__SWIG_0(swigCPtr, SdfLayer.getCPtr(layer), filePath, comment, StdStringMap.getCPtr(args));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool WriteToFile(SdfLayer layer, string filePath, string comment)
		{
			bool result = SdfPINVOKE.SdfFileFormat_WriteToFile__SWIG_1(swigCPtr, SdfLayer.getCPtr(layer), filePath, comment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool WriteToFile(SdfLayer layer, string filePath)
		{
			bool result = SdfPINVOKE.SdfFileFormat_WriteToFile__SWIG_2(swigCPtr, SdfLayer.getCPtr(layer), filePath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool ReadFromString(SdfLayer layer, string str)
		{
			bool result = SdfPINVOKE.SdfFileFormat_ReadFromString(swigCPtr, SdfLayer.getCPtr(layer), str);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool WriteToString(SdfLayer layer, SWIGTYPE_p_std__string str, string comment)
		{
			bool result = SdfPINVOKE.SdfFileFormat_WriteToString__SWIG_0(swigCPtr, SdfLayer.getCPtr(layer), SWIGTYPE_p_std__string.getCPtr(str), comment);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool WriteToString(SdfLayer layer, SWIGTYPE_p_std__string str)
		{
			bool result = SdfPINVOKE.SdfFileFormat_WriteToString__SWIG_1(swigCPtr, SdfLayer.getCPtr(layer), SWIGTYPE_p_std__string.getCPtr(str));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual StdStringSet GetExternalAssetDependencies(SdfLayer layer)
		{
			StdStringSet result = new StdStringSet(SdfPINVOKE.SdfFileFormat_GetExternalAssetDependencies(swigCPtr, SdfLayer.getCPtr(layer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string GetFileExtension(string s)
		{
			string result = SdfPINVOKE.SdfFileFormat_GetFileExtension(s);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringSet FindAllFileFormatExtensions()
		{
			return new StdStringSet(SdfPINVOKE.SdfFileFormat_FindAllFileFormatExtensions(), cMemoryOwn: true);
		}

		public static SdfFileFormat FindById(TfToken formatId)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormat_FindById(TfToken.getCPtr(formatId));
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfFileFormat FindByExtension(string path, string target)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormat_FindByExtension__SWIG_0(path, target);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfFileFormat FindByExtension(string path)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormat_FindByExtension__SWIG_1(path);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfFileFormat FindByExtension(string path, StdStringMap args)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormat_FindByExtension__SWIG_2(path, StdStringMap.getCPtr(args));
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
