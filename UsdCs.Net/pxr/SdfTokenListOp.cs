using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfTokenListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfTokenListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfTokenListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfTokenListOp obj)
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

		~SdfTokenListOp()
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
						SdfPINVOKE.delete_SdfTokenListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfTokenListOp CreateExplicit(TfTokenVector explicitItems)
		{
			SdfTokenListOp result = new SdfTokenListOp(SdfPINVOKE.SdfTokenListOp_CreateExplicit__SWIG_0(TfTokenVector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfTokenListOp CreateExplicit()
		{
			return new SdfTokenListOp(SdfPINVOKE.SdfTokenListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfTokenListOp Create(TfTokenVector prependedItems, TfTokenVector appendedItems, TfTokenVector deletedItems)
		{
			SdfTokenListOp result = new SdfTokenListOp(SdfPINVOKE.SdfTokenListOp_Create__SWIG_0(TfTokenVector.getCPtr(prependedItems), TfTokenVector.getCPtr(appendedItems), TfTokenVector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfTokenListOp Create(TfTokenVector prependedItems, TfTokenVector appendedItems)
		{
			SdfTokenListOp result = new SdfTokenListOp(SdfPINVOKE.SdfTokenListOp_Create__SWIG_1(TfTokenVector.getCPtr(prependedItems), TfTokenVector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfTokenListOp Create(TfTokenVector prependedItems)
		{
			SdfTokenListOp result = new SdfTokenListOp(SdfPINVOKE.SdfTokenListOp_Create__SWIG_2(TfTokenVector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfTokenListOp Create()
		{
			return new SdfTokenListOp(SdfPINVOKE.SdfTokenListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfTokenListOp()
			: this(SdfPINVOKE.new_SdfTokenListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfTokenListOp rhs)
		{
			SdfPINVOKE.SdfTokenListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfTokenListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(TfToken item)
		{
			bool result = SdfPINVOKE.SdfTokenListOp_HasItem(swigCPtr, TfToken.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfTokenListOp_IsExplicit(swigCPtr);
		}

		public TfTokenVector GetExplicitItems()
		{
			return new TfTokenVector(SdfPINVOKE.SdfTokenListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetAddedItems()
		{
			return new TfTokenVector(SdfPINVOKE.SdfTokenListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetPrependedItems()
		{
			return new TfTokenVector(SdfPINVOKE.SdfTokenListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetAppendedItems()
		{
			return new TfTokenVector(SdfPINVOKE.SdfTokenListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetDeletedItems()
		{
			return new TfTokenVector(SdfPINVOKE.SdfTokenListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetOrderedItems()
		{
			return new TfTokenVector(SdfPINVOKE.SdfTokenListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetItems(SdfListOpType type)
		{
			return new TfTokenVector(SdfPINVOKE.SdfTokenListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(TfTokenVector items)
		{
			SdfPINVOKE.SdfTokenListOp_SetExplicitItems(swigCPtr, TfTokenVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(TfTokenVector items)
		{
			SdfPINVOKE.SdfTokenListOp_SetAddedItems(swigCPtr, TfTokenVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(TfTokenVector items)
		{
			SdfPINVOKE.SdfTokenListOp_SetPrependedItems(swigCPtr, TfTokenVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(TfTokenVector items)
		{
			SdfPINVOKE.SdfTokenListOp_SetAppendedItems(swigCPtr, TfTokenVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(TfTokenVector items)
		{
			SdfPINVOKE.SdfTokenListOp_SetDeletedItems(swigCPtr, TfTokenVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(TfTokenVector items)
		{
			SdfPINVOKE.SdfTokenListOp_SetOrderedItems(swigCPtr, TfTokenVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(TfTokenVector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfTokenListOp_SetItems(swigCPtr, TfTokenVector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfTokenListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfTokenListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, TfTokenVector newItems)
		{
			bool result = SdfPINVOKE.SdfTokenListOp_ReplaceOperations(swigCPtr, (int)op, index, n, TfTokenVector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfTokenListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfTokenListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
