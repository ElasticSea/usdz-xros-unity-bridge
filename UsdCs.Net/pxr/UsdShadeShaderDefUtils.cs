using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeShaderDefUtils : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdShadeShaderDefUtils(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeShaderDefUtils obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeShaderDefUtils obj)
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

		~UsdShadeShaderDefUtils()
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
						UsdShadePINVOKE.delete_UsdShadeShaderDefUtils(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static NdrNodeDiscoveryResultVector GetNodeDiscoveryResults(UsdShadeShader shaderDef, string sourceUri)
		{
			NdrNodeDiscoveryResultVector result = new NdrNodeDiscoveryResultVector(UsdShadePINVOKE.UsdShadeShaderDefUtils_GetNodeDiscoveryResults(UsdShadeShader.getCPtr(shaderDef), sourceUri), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string GetPrimvarNamesMetadataString(NdrTokenMap metadata, UsdShadeConnectableAPI shaderDef)
		{
			string result = UsdShadePINVOKE.UsdShadeShaderDefUtils_GetPrimvarNamesMetadataString(NdrTokenMap.getCPtr(metadata), UsdShadeConnectableAPI.getCPtr(shaderDef));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShaderDefUtils()
			: this(UsdShadePINVOKE.new_UsdShadeShaderDefUtils(), cMemoryOwn: true)
		{
		}
	}
}
