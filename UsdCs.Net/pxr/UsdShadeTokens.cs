using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeTokens : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static TfToken allPurpose = new TfToken("");

		public static TfToken bindMaterialAs = new TfToken("bindMaterialAs");

		public static TfToken coordSys = new TfToken("coordSys");

		public static TfToken coordSys_MultipleApplyTemplate_Binding = new TfToken("coordSys:__INSTANCE_NAME__:binding");

		public static TfToken displacement = new TfToken("displacement");

		public static TfToken fallbackStrength = new TfToken("fallbackStrength");

		public static TfToken full = new TfToken("full");

		public static TfToken id = new TfToken("id");

		public static TfToken infoId = new TfToken("info:id");

		public static TfToken infoImplementationSource = new TfToken("info:implementationSource");

		public static TfToken inputs = new TfToken("inputs:");

		public static TfToken interfaceOnly = new TfToken("interfaceOnly");

		public static TfToken materialBind = new TfToken("materialBind");

		public static TfToken materialBinding = new TfToken("material:binding");

		public static TfToken materialBindingCollection = new TfToken("material:binding:collection");

		public static TfToken materialVariant = new TfToken("materialVariant");

		public static TfToken outputs = new TfToken("outputs:");

		public static TfToken outputsDisplacement = new TfToken("outputs:displacement");

		public static TfToken outputsSurface = new TfToken("outputs:surface");

		public static TfToken outputsVolume = new TfToken("outputs:volume");

		public static TfToken preview = new TfToken("preview");

		public static TfToken sdrMetadata = new TfToken("sdrMetadata");

		public static TfToken sourceAsset = new TfToken("sourceAsset");

		public static TfToken sourceCode = new TfToken("sourceCode");

		public static TfToken strongerThanDescendants = new TfToken("strongerThanDescendants");

		public static TfToken subIdentifier = new TfToken("subIdentifier");

		public static TfToken surface = new TfToken("surface");

		public static TfToken universalRenderContext = new TfToken("");

		public static TfToken universalSourceType = new TfToken("");

		public static TfToken volume = new TfToken("volume");

		public static TfToken weakerThanDescendants = new TfToken("weakerThanDescendants");

		public UsdShadeTokens(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeTokens obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeTokens obj)
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

		~UsdShadeTokens()
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
	}
}
