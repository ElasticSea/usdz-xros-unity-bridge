using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfUIntListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfUIntListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfUIntListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfUIntListOp obj)
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

		~SdfUIntListOp()
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
						SdfPINVOKE.delete_SdfUIntListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfUIntListOp CreateExplicit(StdUIntVector explicitItems)
		{
			SdfUIntListOp result = new SdfUIntListOp(SdfPINVOKE.SdfUIntListOp_CreateExplicit__SWIG_0(StdUIntVector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUIntListOp CreateExplicit()
		{
			return new SdfUIntListOp(SdfPINVOKE.SdfUIntListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfUIntListOp Create(StdUIntVector prependedItems, StdUIntVector appendedItems, StdUIntVector deletedItems)
		{
			SdfUIntListOp result = new SdfUIntListOp(SdfPINVOKE.SdfUIntListOp_Create__SWIG_0(StdUIntVector.getCPtr(prependedItems), StdUIntVector.getCPtr(appendedItems), StdUIntVector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUIntListOp Create(StdUIntVector prependedItems, StdUIntVector appendedItems)
		{
			SdfUIntListOp result = new SdfUIntListOp(SdfPINVOKE.SdfUIntListOp_Create__SWIG_1(StdUIntVector.getCPtr(prependedItems), StdUIntVector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUIntListOp Create(StdUIntVector prependedItems)
		{
			SdfUIntListOp result = new SdfUIntListOp(SdfPINVOKE.SdfUIntListOp_Create__SWIG_2(StdUIntVector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUIntListOp Create()
		{
			return new SdfUIntListOp(SdfPINVOKE.SdfUIntListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfUIntListOp()
			: this(SdfPINVOKE.new_SdfUIntListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfUIntListOp rhs)
		{
			SdfPINVOKE.SdfUIntListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfUIntListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(uint item)
		{
			return SdfPINVOKE.SdfUIntListOp_HasItem(swigCPtr, item);
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfUIntListOp_IsExplicit(swigCPtr);
		}

		public StdUIntVector GetExplicitItems()
		{
			return new StdUIntVector(SdfPINVOKE.SdfUIntListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUIntVector GetAddedItems()
		{
			return new StdUIntVector(SdfPINVOKE.SdfUIntListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUIntVector GetPrependedItems()
		{
			return new StdUIntVector(SdfPINVOKE.SdfUIntListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUIntVector GetAppendedItems()
		{
			return new StdUIntVector(SdfPINVOKE.SdfUIntListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUIntVector GetDeletedItems()
		{
			return new StdUIntVector(SdfPINVOKE.SdfUIntListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUIntVector GetOrderedItems()
		{
			return new StdUIntVector(SdfPINVOKE.SdfUIntListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUIntVector GetItems(SdfListOpType type)
		{
			return new StdUIntVector(SdfPINVOKE.SdfUIntListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(StdUIntVector items)
		{
			SdfPINVOKE.SdfUIntListOp_SetExplicitItems(swigCPtr, StdUIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(StdUIntVector items)
		{
			SdfPINVOKE.SdfUIntListOp_SetAddedItems(swigCPtr, StdUIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(StdUIntVector items)
		{
			SdfPINVOKE.SdfUIntListOp_SetPrependedItems(swigCPtr, StdUIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(StdUIntVector items)
		{
			SdfPINVOKE.SdfUIntListOp_SetAppendedItems(swigCPtr, StdUIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(StdUIntVector items)
		{
			SdfPINVOKE.SdfUIntListOp_SetDeletedItems(swigCPtr, StdUIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(StdUIntVector items)
		{
			SdfPINVOKE.SdfUIntListOp_SetOrderedItems(swigCPtr, StdUIntVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(StdUIntVector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfUIntListOp_SetItems(swigCPtr, StdUIntVector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfUIntListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfUIntListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdUIntVector newItems)
		{
			bool result = SdfPINVOKE.SdfUIntListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdUIntVector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfUIntListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfUIntListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
