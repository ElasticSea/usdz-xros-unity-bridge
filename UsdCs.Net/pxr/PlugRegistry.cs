using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PlugRegistry : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public PlugRegistry(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PlugRegistry obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PlugRegistry obj)
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

		~PlugRegistry()
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
						throw new MethodAccessException("C++ destructor does not have public access");
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static PlugRegistry GetInstance()
		{
			return new PlugRegistry(PlugPINVOKE.PlugRegistry_GetInstance(), cMemoryOwn: false);
		}

		public SWIGTYPE_p_PlugPluginPtrVector RegisterPlugins(string pathToPlugInfo)
		{
			SWIGTYPE_p_PlugPluginPtrVector result = new SWIGTYPE_p_PlugPluginPtrVector(PlugPINVOKE.PlugRegistry_RegisterPlugins__SWIG_0(swigCPtr, pathToPlugInfo), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PlugPluginPtrVector RegisterPlugins(StdStringVector pathsToPlugInfo)
		{
			SWIGTYPE_p_PlugPluginPtrVector result = new SWIGTYPE_p_PlugPluginPtrVector(PlugPINVOKE.PlugRegistry_RegisterPlugins__SWIG_1(swigCPtr, StdStringVector.getCPtr(pathsToPlugInfo)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfType FindTypeByName(string typeName)
		{
			TfType result = new TfType(PlugPINVOKE.PlugRegistry_FindTypeByName(typeName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfType FindDerivedTypeByName(TfType base_, string typeName)
		{
			TfType result = new TfType(PlugPINVOKE.PlugRegistry_FindDerivedTypeByName(TfType.getCPtr(base_), typeName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfTypeVector GetDirectlyDerivedTypes(TfType base_)
		{
			TfTypeVector result = new TfTypeVector(PlugPINVOKE.PlugRegistry_GetDirectlyDerivedTypes(TfType.getCPtr(base_)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void GetAllDerivedTypes(TfType base_, TfTypeSet result)
		{
			PlugPINVOKE.PlugRegistry_GetAllDerivedTypes(TfType.getCPtr(base_), TfTypeSet.getCPtr(result));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PlugPlugin GetPluginForType(TfType t)
		{
			IntPtr intPtr = PlugPINVOKE.PlugRegistry_GetPluginForType(swigCPtr, TfType.getCPtr(t));
			PlugPlugin result = ((intPtr == IntPtr.Zero) ? null : new PlugPlugin(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_PlugPluginPtrVector GetAllPlugins()
		{
			return new SWIGTYPE_p_PlugPluginPtrVector(PlugPINVOKE.PlugRegistry_GetAllPlugins(swigCPtr), futureUse: true);
		}

		public PlugPlugin GetPluginWithName(string name)
		{
			IntPtr intPtr = PlugPINVOKE.PlugRegistry_GetPluginWithName(swigCPtr, name);
			PlugPlugin result = ((intPtr == IntPtr.Zero) ? null : new PlugPlugin(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetStringFromPluginMetaData(TfType type, string key)
		{
			string result = PlugPINVOKE.PlugRegistry_GetStringFromPluginMetaData(swigCPtr, TfType.getCPtr(type), key);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_JsValue GetDataFromPluginMetaData(TfType type, string key)
		{
			SWIGTYPE_p_JsValue result = new SWIGTYPE_p_JsValue(PlugPINVOKE.PlugRegistry_GetDataFromPluginMetaData(swigCPtr, TfType.getCPtr(type), key), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
