using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfIntListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfIntListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfIntListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfIntListOp obj)
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

		~SdfIntListOp()
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
						SdfPINVOKE.delete_SdfIntListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfIntListOp CreateExplicit(StdIntVector explicitItems)
		{
			SdfIntListOp result = new SdfIntListOp(SdfPINVOKE.SdfIntListOp_CreateExplicit__SWIG_0(StdIntVector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfIntListOp CreateExplicit()
		{
			return new SdfIntListOp(SdfPINVOKE.SdfIntListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfIntListOp Create(StdIntVector prependedItems, StdIntVector appendedItems, StdIntVector deletedItems)
		{
			SdfIntListOp result = new SdfIntListOp(SdfPINVOKE.SdfIntListOp_Create__SWIG_0(StdIntVector.getCPtr(prependedItems), StdIntVector.getCPtr(appendedItems), StdIntVector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfIntListOp Create(StdIntVector prependedItems, StdIntVector appendedItems)
		{
			SdfIntListOp result = new SdfIntListOp(SdfPINVOKE.SdfIntListOp_Create__SWIG_1(StdIntVector.getCPtr(prependedItems), StdIntVector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfIntListOp Create(StdIntVector prependedItems)
		{
			SdfIntListOp result = new SdfIntListOp(SdfPINVOKE.SdfIntListOp_Create__SWIG_2(StdIntVector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfIntListOp Create()
		{
			return new SdfIntListOp(SdfPINVOKE.SdfIntListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfIntListOp()
			: this(SdfPINVOKE.new_SdfIntListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfIntListOp rhs)
		{
			SdfPINVOKE.SdfIntListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfIntListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(int item)
		{
			return SdfPINVOKE.SdfIntListOp_HasItem(swigCPtr, item);
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfIntListOp_IsExplicit(swigCPtr);
		}

		public StdIntVector GetExplicitItems()
		{
			return new StdIntVector(SdfPINVOKE.SdfIntListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public StdIntVector GetAddedItems()
		{
			return new StdIntVector(SdfPINVOKE.SdfIntListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdIntVector GetPrependedItems()
		{
			return new StdIntVector(SdfPINVOKE.SdfIntListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdIntVector GetAppendedItems()
		{
			return new StdIntVector(SdfPINVOKE.SdfIntListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdIntVector GetDeletedItems()
		{
			return new StdIntVector(SdfPINVOKE.SdfIntListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdIntVector GetOrderedItems()
		{
			return new StdIntVector(SdfPINVOKE.SdfIntListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdIntVector GetItems(SdfListOpType type)
		{
			return new StdIntVector(SdfPINVOKE.SdfIntListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(StdIntVector items)
		{
			SdfPINVOKE.SdfIntListOp_SetExplicitItems(swigCPtr, StdIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(StdIntVector items)
		{
			SdfPINVOKE.SdfIntListOp_SetAddedItems(swigCPtr, StdIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(StdIntVector items)
		{
			SdfPINVOKE.SdfIntListOp_SetPrependedItems(swigCPtr, StdIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(StdIntVector items)
		{
			SdfPINVOKE.SdfIntListOp_SetAppendedItems(swigCPtr, StdIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(StdIntVector items)
		{
			SdfPINVOKE.SdfIntListOp_SetDeletedItems(swigCPtr, StdIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(StdIntVector items)
		{
			SdfPINVOKE.SdfIntListOp_SetOrderedItems(swigCPtr, StdIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(StdIntVector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfIntListOp_SetItems(swigCPtr, StdIntVector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfIntListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfIntListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdIntVector newItems)
		{
			bool result = SdfPINVOKE.SdfIntListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdIntVector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfIntListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfIntListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
