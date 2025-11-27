using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfNamespaceEdit : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const int AtEnd = -1;

		public const int Same = -2;

		public SdfPath currentPath
		{
			get
			{
				IntPtr intPtr = SdfPINVOKE.SdfNamespaceEdit_currentPath_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfPath(intPtr, cMemoryOwn: false);
			}
			set
			{
				SdfPINVOKE.SdfNamespaceEdit_currentPath_set(swigCPtr, SdfPath.getCPtr(value));
			}
		}

		public SdfPath newPath
		{
			get
			{
				IntPtr intPtr = SdfPINVOKE.SdfNamespaceEdit_newPath_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfPath(intPtr, cMemoryOwn: false);
			}
			set
			{
				SdfPINVOKE.SdfNamespaceEdit_newPath_set(swigCPtr, SdfPath.getCPtr(value));
			}
		}

		public int index
		{
			get
			{
				return SdfPINVOKE.SdfNamespaceEdit_index_get(swigCPtr);
			}
			set
			{
				SdfPINVOKE.SdfNamespaceEdit_index_set(swigCPtr, value);
			}
		}

		public SdfNamespaceEdit(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfNamespaceEdit obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfNamespaceEdit obj)
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

		~SdfNamespaceEdit()
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
						SdfPINVOKE.delete_SdfNamespaceEdit(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfNamespaceEdit()
			: this(SdfPINVOKE.new_SdfNamespaceEdit__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfNamespaceEdit(SdfPath currentPath_, SdfPath newPath_, int index_)
			: this(SdfPINVOKE.new_SdfNamespaceEdit__SWIG_1(SdfPath.getCPtr(currentPath_), SdfPath.getCPtr(newPath_), index_), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfNamespaceEdit(SdfPath currentPath_, SdfPath newPath_)
			: this(SdfPINVOKE.new_SdfNamespaceEdit__SWIG_2(SdfPath.getCPtr(currentPath_), SdfPath.getCPtr(newPath_)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfNamespaceEdit Remove(SdfPath currentPath)
		{
			SdfNamespaceEdit result = new SdfNamespaceEdit(SdfPINVOKE.SdfNamespaceEdit_Remove(SdfPath.getCPtr(currentPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfNamespaceEdit Rename(SdfPath currentPath, TfToken name)
		{
			SdfNamespaceEdit result = new SdfNamespaceEdit(SdfPINVOKE.SdfNamespaceEdit_Rename(SdfPath.getCPtr(currentPath), TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfNamespaceEdit Reorder(SdfPath currentPath, int index)
		{
			SdfNamespaceEdit result = new SdfNamespaceEdit(SdfPINVOKE.SdfNamespaceEdit_Reorder(SdfPath.getCPtr(currentPath), index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfNamespaceEdit Reparent(SdfPath currentPath, SdfPath newParentPath, int index)
		{
			SdfNamespaceEdit result = new SdfNamespaceEdit(SdfPINVOKE.SdfNamespaceEdit_Reparent(SdfPath.getCPtr(currentPath), SdfPath.getCPtr(newParentPath), index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfNamespaceEdit ReparentAndRename(SdfPath currentPath, SdfPath newParentPath, TfToken name, int index)
		{
			SdfNamespaceEdit result = new SdfNamespaceEdit(SdfPINVOKE.SdfNamespaceEdit_ReparentAndRename(SdfPath.getCPtr(currentPath), SdfPath.getCPtr(newParentPath), TfToken.getCPtr(name), index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
