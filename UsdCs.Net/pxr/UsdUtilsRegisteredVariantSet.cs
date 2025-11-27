using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdUtilsRegisteredVariantSet : IDisposable
	{
		public enum SelectionExportPolicy
		{
			Never,
			IfAuthored,
			Always
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string name => UsdUtilsPINVOKE.UsdUtilsRegisteredVariantSet_name_get(swigCPtr);

		public SelectionExportPolicy selectionExportPolicy => (SelectionExportPolicy)UsdUtilsPINVOKE.UsdUtilsRegisteredVariantSet_selectionExportPolicy_get(swigCPtr);

		public UsdUtilsRegisteredVariantSet(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdUtilsRegisteredVariantSet obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdUtilsRegisteredVariantSet obj)
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

		~UsdUtilsRegisteredVariantSet()
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
						UsdUtilsPINVOKE.delete_UsdUtilsRegisteredVariantSet(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdUtilsRegisteredVariantSet(string name, SelectionExportPolicy selectionExportPolicy)
			: this(UsdUtilsPINVOKE.new_UsdUtilsRegisteredVariantSet(name, (int)selectionExportPolicy), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
