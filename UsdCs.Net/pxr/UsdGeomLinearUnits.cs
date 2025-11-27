using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomLinearUnits : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const double nanometers = 1E-09;

		public const double micrometers = 1E-06;

		public const double millimeters = 0.001;

		public const double centimeters = 0.01;

		public const double meters = 1.0;

		public const double kilometers = 1000.0;

		public const double lightYears = 9460730472580800.0;

		public const double inches = 0.0254;

		public const double feet = 0.3048;

		public const double yards = 0.9144;

		public const double miles = 1609.344;

		public UsdGeomLinearUnits(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomLinearUnits obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomLinearUnits obj)
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

		~UsdGeomLinearUnits()
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
						UsdGeomPINVOKE.delete_UsdGeomLinearUnits(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomLinearUnits()
			: this(UsdGeomPINVOKE.new_UsdGeomLinearUnits(), cMemoryOwn: true)
		{
		}
	}
}
