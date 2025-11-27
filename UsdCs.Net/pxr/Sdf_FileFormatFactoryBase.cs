using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class Sdf_FileFormatFactoryBase : TfType.FactoryBase
	{
		private HandleRef swigCPtr;

		public Sdf_FileFormatFactoryBase(IntPtr cPtr, bool cMemoryOwn)
			: base(SdfPINVOKE.Sdf_FileFormatFactoryBase_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(Sdf_FileFormatFactoryBase obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(Sdf_FileFormatFactoryBase obj)
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
						SdfPINVOKE.delete_Sdf_FileFormatFactoryBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public virtual SdfFileFormat New()
		{
			IntPtr intPtr = SdfPINVOKE.Sdf_FileFormatFactoryBase_New(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true);
		}
	}
}
