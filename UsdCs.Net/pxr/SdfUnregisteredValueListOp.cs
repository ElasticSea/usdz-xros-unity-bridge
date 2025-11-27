using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfUnregisteredValueListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfUnregisteredValueListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfUnregisteredValueListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfUnregisteredValueListOp obj)
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

		~SdfUnregisteredValueListOp()
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
						SdfPINVOKE.delete_SdfUnregisteredValueListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfUnregisteredValueListOp CreateExplicit(StdUnregisteredValueVector explicitItems)
		{
			SdfUnregisteredValueListOp result = new SdfUnregisteredValueListOp(SdfPINVOKE.SdfUnregisteredValueListOp_CreateExplicit__SWIG_0(StdUnregisteredValueVector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUnregisteredValueListOp CreateExplicit()
		{
			return new SdfUnregisteredValueListOp(SdfPINVOKE.SdfUnregisteredValueListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfUnregisteredValueListOp Create(StdUnregisteredValueVector prependedItems, StdUnregisteredValueVector appendedItems, StdUnregisteredValueVector deletedItems)
		{
			SdfUnregisteredValueListOp result = new SdfUnregisteredValueListOp(SdfPINVOKE.SdfUnregisteredValueListOp_Create__SWIG_0(StdUnregisteredValueVector.getCPtr(prependedItems), StdUnregisteredValueVector.getCPtr(appendedItems), StdUnregisteredValueVector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUnregisteredValueListOp Create(StdUnregisteredValueVector prependedItems, StdUnregisteredValueVector appendedItems)
		{
			SdfUnregisteredValueListOp result = new SdfUnregisteredValueListOp(SdfPINVOKE.SdfUnregisteredValueListOp_Create__SWIG_1(StdUnregisteredValueVector.getCPtr(prependedItems), StdUnregisteredValueVector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUnregisteredValueListOp Create(StdUnregisteredValueVector prependedItems)
		{
			SdfUnregisteredValueListOp result = new SdfUnregisteredValueListOp(SdfPINVOKE.SdfUnregisteredValueListOp_Create__SWIG_2(StdUnregisteredValueVector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUnregisteredValueListOp Create()
		{
			return new SdfUnregisteredValueListOp(SdfPINVOKE.SdfUnregisteredValueListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfUnregisteredValueListOp()
			: this(SdfPINVOKE.new_SdfUnregisteredValueListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfUnregisteredValueListOp rhs)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfUnregisteredValueListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(SdfUnregisteredValue item)
		{
			bool result = SdfPINVOKE.SdfUnregisteredValueListOp_HasItem(swigCPtr, SdfUnregisteredValue.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfUnregisteredValueListOp_IsExplicit(swigCPtr);
		}

		public StdUnregisteredValueVector GetExplicitItems()
		{
			return new StdUnregisteredValueVector(SdfPINVOKE.SdfUnregisteredValueListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUnregisteredValueVector GetAddedItems()
		{
			return new StdUnregisteredValueVector(SdfPINVOKE.SdfUnregisteredValueListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUnregisteredValueVector GetPrependedItems()
		{
			return new StdUnregisteredValueVector(SdfPINVOKE.SdfUnregisteredValueListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUnregisteredValueVector GetAppendedItems()
		{
			return new StdUnregisteredValueVector(SdfPINVOKE.SdfUnregisteredValueListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUnregisteredValueVector GetDeletedItems()
		{
			return new StdUnregisteredValueVector(SdfPINVOKE.SdfUnregisteredValueListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUnregisteredValueVector GetOrderedItems()
		{
			return new StdUnregisteredValueVector(SdfPINVOKE.SdfUnregisteredValueListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUnregisteredValueVector GetItems(SdfListOpType type)
		{
			return new StdUnregisteredValueVector(SdfPINVOKE.SdfUnregisteredValueListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(StdUnregisteredValueVector items)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_SetExplicitItems(swigCPtr, StdUnregisteredValueVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(StdUnregisteredValueVector items)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_SetAddedItems(swigCPtr, StdUnregisteredValueVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(StdUnregisteredValueVector items)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_SetPrependedItems(swigCPtr, StdUnregisteredValueVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(StdUnregisteredValueVector items)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_SetAppendedItems(swigCPtr, StdUnregisteredValueVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(StdUnregisteredValueVector items)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_SetDeletedItems(swigCPtr, StdUnregisteredValueVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(StdUnregisteredValueVector items)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_SetOrderedItems(swigCPtr, StdUnregisteredValueVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(StdUnregisteredValueVector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_SetItems(swigCPtr, StdUnregisteredValueVector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdUnregisteredValueVector newItems)
		{
			bool result = SdfPINVOKE.SdfUnregisteredValueListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdUnregisteredValueVector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfUnregisteredValueListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfUnregisteredValueListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
