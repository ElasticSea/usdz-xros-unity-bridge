using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfNamespaceEditDetail : IDisposable
	{
		public enum Result
		{
			Error,
			Unbatched,
			Okay
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public Result result
		{
			get
			{
				return (Result)SdfPINVOKE.SdfNamespaceEditDetail_result_get(swigCPtr);
			}
			set
			{
				SdfPINVOKE.SdfNamespaceEditDetail_result_set(swigCPtr, (int)value);
			}
		}

		public SdfNamespaceEdit edit
		{
			get
			{
				IntPtr intPtr = SdfPINVOKE.SdfNamespaceEditDetail_edit_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfNamespaceEdit(intPtr, cMemoryOwn: false);
			}
			set
			{
				SdfPINVOKE.SdfNamespaceEditDetail_edit_set(swigCPtr, SdfNamespaceEdit.getCPtr(value));
			}
		}

		public string reason
		{
			get
			{
				string text = SdfPINVOKE.SdfNamespaceEditDetail_reason_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return text;
			}
			set
			{
				SdfPINVOKE.SdfNamespaceEditDetail_reason_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public SdfNamespaceEditDetail(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfNamespaceEditDetail obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfNamespaceEditDetail obj)
		{
			if (obj != null)
			{
				if (!obj.swigCMemOwn)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef handleRef = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				return handleRef;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		~SdfNamespaceEditDetail()
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
						SdfPINVOKE.delete_SdfNamespaceEditDetail(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfNamespaceEditDetail()
			: this(SdfPINVOKE.new_SdfNamespaceEditDetail__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfNamespaceEditDetail(Result arg0, SdfNamespaceEdit edit, string reason)
			: this(SdfPINVOKE.new_SdfNamespaceEditDetail__SWIG_1((int)arg0, SdfNamespaceEdit.getCPtr(edit), reason), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
