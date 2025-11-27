using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdVolTokens : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static TfToken bool_ = new TfToken("bool");

		public static TfToken color = new TfToken("Color");

		public static TfToken double2 = new TfToken("double2");

		public static TfToken double3 = new TfToken("double3");

		public static TfToken double_ = new TfToken("double");

		public static TfToken field = new TfToken("field");

		public static TfToken fieldClass = new TfToken("fieldClass");

		public static TfToken fieldDataType = new TfToken("fieldDataType");

		public static TfToken fieldIndex = new TfToken("fieldIndex");

		public static TfToken fieldName = new TfToken("fieldName");

		public static TfToken fieldPurpose = new TfToken("fieldPurpose");

		public static TfToken filePath = new TfToken("filePath");

		public static TfToken float2 = new TfToken("float2");

		public static TfToken float3 = new TfToken("float3");

		public static TfToken float_ = new TfToken("float");

		public static TfToken fogVolume = new TfToken("fogVolume");

		public static TfToken half = new TfToken("half");

		public static TfToken half2 = new TfToken("half2");

		public static TfToken half3 = new TfToken("half3");

		public static TfToken int2 = new TfToken("int2");

		public static TfToken int3 = new TfToken("int3");

		public static TfToken int64 = new TfToken("int64");

		public static TfToken int_ = new TfToken("int");

		public static TfToken levelSet = new TfToken("levelSet");

		public static TfToken mask = new TfToken("mask");

		public static TfToken matrix3d = new TfToken("matrix3d");

		public static TfToken matrix4d = new TfToken("matrix4d");

		public static TfToken none = new TfToken("None");

		public static TfToken normal = new TfToken("Normal");

		public static TfToken point = new TfToken("Point");

		public static TfToken quatd = new TfToken("quatd");

		public static TfToken staggered = new TfToken("staggered");

		public static TfToken string_ = new TfToken("string");

		public static TfToken uint_ = new TfToken("uint");

		public static TfToken unknown = new TfToken("unknown");

		public static TfToken vector = new TfToken("Vector");

		public static TfToken vectorDataRoleHint = new TfToken("vectorDataRoleHint");

		public UsdVolTokens(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdVolTokens obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdVolTokens obj)
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

		~UsdVolTokens()
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
