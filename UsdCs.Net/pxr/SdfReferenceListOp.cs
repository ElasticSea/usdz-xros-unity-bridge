using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfReferenceListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfReferenceListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfReferenceListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfReferenceListOp obj)
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

		~SdfReferenceListOp()
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
						SdfPINVOKE.delete_SdfReferenceListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfReferenceListOp CreateExplicit(StdReferenceVector explicitItems)
		{
			SdfReferenceListOp result = new SdfReferenceListOp(SdfPINVOKE.SdfReferenceListOp_CreateExplicit__SWIG_0(StdReferenceVector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfReferenceListOp CreateExplicit()
		{
			return new SdfReferenceListOp(SdfPINVOKE.SdfReferenceListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfReferenceListOp Create(StdReferenceVector prependedItems, StdReferenceVector appendedItems, StdReferenceVector deletedItems)
		{
			SdfReferenceListOp result = new SdfReferenceListOp(SdfPINVOKE.SdfReferenceListOp_Create__SWIG_0(StdReferenceVector.getCPtr(prependedItems), StdReferenceVector.getCPtr(appendedItems), StdReferenceVector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfReferenceListOp Create(StdReferenceVector prependedItems, StdReferenceVector appendedItems)
		{
			SdfReferenceListOp result = new SdfReferenceListOp(SdfPINVOKE.SdfReferenceListOp_Create__SWIG_1(StdReferenceVector.getCPtr(prependedItems), StdReferenceVector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfReferenceListOp Create(StdReferenceVector prependedItems)
		{
			SdfReferenceListOp result = new SdfReferenceListOp(SdfPINVOKE.SdfReferenceListOp_Create__SWIG_2(StdReferenceVector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfReferenceListOp Create()
		{
			return new SdfReferenceListOp(SdfPINVOKE.SdfReferenceListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfReferenceListOp()
			: this(SdfPINVOKE.new_SdfReferenceListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfReferenceListOp rhs)
		{
			SdfPINVOKE.SdfReferenceListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfReferenceListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(SdfReference item)
		{
			bool result = SdfPINVOKE.SdfReferenceListOp_HasItem(swigCPtr, SdfReference.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfReferenceListOp_IsExplicit(swigCPtr);
		}

		public StdReferenceVector GetExplicitItems()
		{
			return new StdReferenceVector(SdfPINVOKE.SdfReferenceListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public StdReferenceVector GetAddedItems()
		{
			return new StdReferenceVector(SdfPINVOKE.SdfReferenceListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdReferenceVector GetPrependedItems()
		{
			return new StdReferenceVector(SdfPINVOKE.SdfReferenceListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdReferenceVector GetAppendedItems()
		{
			return new StdReferenceVector(SdfPINVOKE.SdfReferenceListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdReferenceVector GetDeletedItems()
		{
			return new StdReferenceVector(SdfPINVOKE.SdfReferenceListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdReferenceVector GetOrderedItems()
		{
			return new StdReferenceVector(SdfPINVOKE.SdfReferenceListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdReferenceVector GetItems(SdfListOpType type)
		{
			return new StdReferenceVector(SdfPINVOKE.SdfReferenceListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(StdReferenceVector items)
		{
			SdfPINVOKE.SdfReferenceListOp_SetExplicitItems(swigCPtr, StdReferenceVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(StdReferenceVector items)
		{
			SdfPINVOKE.SdfReferenceListOp_SetAddedItems(swigCPtr, StdReferenceVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(StdReferenceVector items)
		{
			SdfPINVOKE.SdfReferenceListOp_SetPrependedItems(swigCPtr, StdReferenceVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(StdReferenceVector items)
		{
			SdfPINVOKE.SdfReferenceListOp_SetAppendedItems(swigCPtr, StdReferenceVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(StdReferenceVector items)
		{
			SdfPINVOKE.SdfReferenceListOp_SetDeletedItems(swigCPtr, StdReferenceVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(StdReferenceVector items)
		{
			SdfPINVOKE.SdfReferenceListOp_SetOrderedItems(swigCPtr, StdReferenceVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(StdReferenceVector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfReferenceListOp_SetItems(swigCPtr, StdReferenceVector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfReferenceListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfReferenceListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdReferenceVector newItems)
		{
			bool result = SdfPINVOKE.SdfReferenceListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdReferenceVector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfReferenceListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfReferenceListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
