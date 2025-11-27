using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfBatchNamespaceEdit : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfBatchNamespaceEdit(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfBatchNamespaceEdit obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfBatchNamespaceEdit obj)
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

		~SdfBatchNamespaceEdit()
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
						SdfPINVOKE.delete_SdfBatchNamespaceEdit(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfBatchNamespaceEdit()
			: this(SdfPINVOKE.new_SdfBatchNamespaceEdit__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfBatchNamespaceEdit(SdfBatchNamespaceEdit arg0)
			: this(SdfPINVOKE.new_SdfBatchNamespaceEdit__SWIG_1(getCPtr(arg0)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfBatchNamespaceEdit(SdfNamespaceEditVector arg0)
			: this(SdfPINVOKE.new_SdfBatchNamespaceEdit__SWIG_2(SdfNamespaceEditVector.getCPtr(arg0)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Add(SdfNamespaceEdit edit)
		{
			SdfPINVOKE.SdfBatchNamespaceEdit_Add__SWIG_0(swigCPtr, SdfNamespaceEdit.getCPtr(edit));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Add(SdfPath currentPath, SdfPath newPath, int index)
		{
			SdfPINVOKE.SdfBatchNamespaceEdit_Add__SWIG_1(swigCPtr, SdfPath.getCPtr(currentPath), SdfPath.getCPtr(newPath), index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Add(SdfPath currentPath, SdfPath newPath)
		{
			SdfPINVOKE.SdfBatchNamespaceEdit_Add__SWIG_2(swigCPtr, SdfPath.getCPtr(currentPath), SdfPath.getCPtr(newPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfNamespaceEditVector GetEdits()
		{
			return new SdfNamespaceEditVector(SdfPINVOKE.SdfBatchNamespaceEdit_GetEdits(swigCPtr), cMemoryOwn: false);
		}
	}
}
