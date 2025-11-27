using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeShaderDefParserPlugin : NdrParserPlugin
	{
		private HandleRef swigCPtr;

		public UsdShadeShaderDefParserPlugin(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdShadePINVOKE.UsdShadeShaderDefParserPlugin_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeShaderDefParserPlugin obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeShaderDefParserPlugin obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						UsdShadePINVOKE.delete_UsdShadeShaderDefParserPlugin(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdShadeShaderDefParserPlugin()
			: this(UsdShadePINVOKE.new_UsdShadeShaderDefParserPlugin(), cMemoryOwn: true)
		{
		}

		public override TfTokenVector GetDiscoveryTypes()
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeShaderDefParserPlugin_GetDiscoveryTypes(swigCPtr), cMemoryOwn: false);
		}

		public override TfToken GetSourceType()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeShaderDefParserPlugin_GetSourceType(swigCPtr), cMemoryOwn: false);
		}
	}
}
