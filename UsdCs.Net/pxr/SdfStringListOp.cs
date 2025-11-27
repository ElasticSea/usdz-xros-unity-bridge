using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfStringListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfStringListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfStringListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfStringListOp obj)
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

		~SdfStringListOp()
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
						SdfPINVOKE.delete_SdfStringListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfStringListOp CreateExplicit(StdStringVector explicitItems)
		{
			SdfStringListOp result = new SdfStringListOp(SdfPINVOKE.SdfStringListOp_CreateExplicit__SWIG_0(StdStringVector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfStringListOp CreateExplicit()
		{
			return new SdfStringListOp(SdfPINVOKE.SdfStringListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfStringListOp Create(StdStringVector prependedItems, StdStringVector appendedItems, StdStringVector deletedItems)
		{
			SdfStringListOp result = new SdfStringListOp(SdfPINVOKE.SdfStringListOp_Create__SWIG_0(StdStringVector.getCPtr(prependedItems), StdStringVector.getCPtr(appendedItems), StdStringVector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfStringListOp Create(StdStringVector prependedItems, StdStringVector appendedItems)
		{
			SdfStringListOp result = new SdfStringListOp(SdfPINVOKE.SdfStringListOp_Create__SWIG_1(StdStringVector.getCPtr(prependedItems), StdStringVector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfStringListOp Create(StdStringVector prependedItems)
		{
			SdfStringListOp result = new SdfStringListOp(SdfPINVOKE.SdfStringListOp_Create__SWIG_2(StdStringVector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfStringListOp Create()
		{
			return new SdfStringListOp(SdfPINVOKE.SdfStringListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfStringListOp()
			: this(SdfPINVOKE.new_SdfStringListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfStringListOp rhs)
		{
			SdfPINVOKE.SdfStringListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfStringListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(string item)
		{
			bool result = SdfPINVOKE.SdfStringListOp_HasItem(swigCPtr, item);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfStringListOp_IsExplicit(swigCPtr);
		}

		public StdStringVector GetExplicitItems()
		{
			return new StdStringVector(SdfPINVOKE.SdfStringListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public StdStringVector GetAddedItems()
		{
			return new StdStringVector(SdfPINVOKE.SdfStringListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdStringVector GetPrependedItems()
		{
			return new StdStringVector(SdfPINVOKE.SdfStringListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdStringVector GetAppendedItems()
		{
			return new StdStringVector(SdfPINVOKE.SdfStringListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdStringVector GetDeletedItems()
		{
			return new StdStringVector(SdfPINVOKE.SdfStringListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdStringVector GetOrderedItems()
		{
			return new StdStringVector(SdfPINVOKE.SdfStringListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdStringVector GetItems(SdfListOpType type)
		{
			return new StdStringVector(SdfPINVOKE.SdfStringListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(StdStringVector items)
		{
			SdfPINVOKE.SdfStringListOp_SetExplicitItems(swigCPtr, StdStringVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(StdStringVector items)
		{
			SdfPINVOKE.SdfStringListOp_SetAddedItems(swigCPtr, StdStringVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(StdStringVector items)
		{
			SdfPINVOKE.SdfStringListOp_SetPrependedItems(swigCPtr, StdStringVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(StdStringVector items)
		{
			SdfPINVOKE.SdfStringListOp_SetAppendedItems(swigCPtr, StdStringVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(StdStringVector items)
		{
			SdfPINVOKE.SdfStringListOp_SetDeletedItems(swigCPtr, StdStringVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(StdStringVector items)
		{
			SdfPINVOKE.SdfStringListOp_SetOrderedItems(swigCPtr, StdStringVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(StdStringVector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfStringListOp_SetItems(swigCPtr, StdStringVector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfStringListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfStringListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdStringVector newItems)
		{
			bool result = SdfPINVOKE.SdfStringListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdStringVector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfStringListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfStringListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
