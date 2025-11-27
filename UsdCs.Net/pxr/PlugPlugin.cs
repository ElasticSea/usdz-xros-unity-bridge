using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PlugPlugin : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

		internal PlugPlugin(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(PlugPlugin obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~PlugPlugin()
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
						PlugPINVOKE.delete_PlugPlugin(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool Load()
		{
			bool result = PlugPINVOKE.PlugPlugin_Load(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsLoaded()
		{
			bool result = PlugPINVOKE.PlugPlugin_IsLoaded(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsResource()
		{
			bool result = PlugPINVOKE.PlugPlugin_IsResource(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_JsObject GetMetadata()
		{
			SWIGTYPE_p_JsObject result = new SWIGTYPE_p_JsObject(PlugPINVOKE.PlugPlugin_GetMetadata(swigCPtr), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_JsObject GetMetadataForType(TfType type)
		{
			SWIGTYPE_p_JsObject result = new SWIGTYPE_p_JsObject(PlugPINVOKE.PlugPlugin_GetMetadataForType(swigCPtr, TfType.getCPtr(type)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_JsObject GetDependencies()
		{
			SWIGTYPE_p_JsObject result = new SWIGTYPE_p_JsObject(PlugPINVOKE.PlugPlugin_GetDependencies(swigCPtr), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool DeclaresType(TfType type, bool includeSubclasses)
		{
			bool result = PlugPINVOKE.PlugPlugin_DeclaresType__SWIG_0(swigCPtr, TfType.getCPtr(type), includeSubclasses);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool DeclaresType(TfType type)
		{
			bool result = PlugPINVOKE.PlugPlugin_DeclaresType__SWIG_1(swigCPtr, TfType.getCPtr(type));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetName()
		{
			string result = PlugPINVOKE.PlugPlugin_GetName(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetPath()
		{
			string result = PlugPINVOKE.PlugPlugin_GetPath(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetResourcePath()
		{
			string result = PlugPINVOKE.PlugPlugin_GetResourcePath(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string MakeResourcePath(string path)
		{
			string result = PlugPINVOKE.PlugPlugin_MakeResourcePath(swigCPtr, path);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string FindPluginResource(string path, bool verify)
		{
			string result = PlugPINVOKE.PlugPlugin_FindPluginResource__SWIG_0(swigCPtr, path, verify);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string FindPluginResource(string path)
		{
			string result = PlugPINVOKE.PlugPlugin_FindPluginResource__SWIG_1(swigCPtr, path);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
