using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPathListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfPathListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPathListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPathListOp obj)
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

		~SdfPathListOp()
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
						SdfPINVOKE.delete_SdfPathListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfPathListOp CreateExplicit(SdfPathVector explicitItems)
		{
			SdfPathListOp result = new SdfPathListOp(SdfPINVOKE.SdfPathListOp_CreateExplicit__SWIG_0(SdfPathVector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPathListOp CreateExplicit()
		{
			return new SdfPathListOp(SdfPINVOKE.SdfPathListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfPathListOp Create(SdfPathVector prependedItems, SdfPathVector appendedItems, SdfPathVector deletedItems)
		{
			SdfPathListOp result = new SdfPathListOp(SdfPINVOKE.SdfPathListOp_Create__SWIG_0(SdfPathVector.getCPtr(prependedItems), SdfPathVector.getCPtr(appendedItems), SdfPathVector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPathListOp Create(SdfPathVector prependedItems, SdfPathVector appendedItems)
		{
			SdfPathListOp result = new SdfPathListOp(SdfPINVOKE.SdfPathListOp_Create__SWIG_1(SdfPathVector.getCPtr(prependedItems), SdfPathVector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPathListOp Create(SdfPathVector prependedItems)
		{
			SdfPathListOp result = new SdfPathListOp(SdfPINVOKE.SdfPathListOp_Create__SWIG_2(SdfPathVector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfPathListOp Create()
		{
			return new SdfPathListOp(SdfPINVOKE.SdfPathListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfPathListOp()
			: this(SdfPINVOKE.new_SdfPathListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfPathListOp rhs)
		{
			SdfPINVOKE.SdfPathListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfPathListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(SdfPath item)
		{
			bool result = SdfPINVOKE.SdfPathListOp_HasItem(swigCPtr, SdfPath.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfPathListOp_IsExplicit(swigCPtr);
		}

		public SdfPathVector GetExplicitItems()
		{
			return new SdfPathVector(SdfPINVOKE.SdfPathListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public SdfPathVector GetAddedItems()
		{
			return new SdfPathVector(SdfPINVOKE.SdfPathListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public SdfPathVector GetPrependedItems()
		{
			return new SdfPathVector(SdfPINVOKE.SdfPathListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public SdfPathVector GetAppendedItems()
		{
			return new SdfPathVector(SdfPINVOKE.SdfPathListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public SdfPathVector GetDeletedItems()
		{
			return new SdfPathVector(SdfPINVOKE.SdfPathListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public SdfPathVector GetOrderedItems()
		{
			return new SdfPathVector(SdfPINVOKE.SdfPathListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public SdfPathVector GetItems(SdfListOpType type)
		{
			return new SdfPathVector(SdfPINVOKE.SdfPathListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(SdfPathVector items)
		{
			SdfPINVOKE.SdfPathListOp_SetExplicitItems(swigCPtr, SdfPathVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(SdfPathVector items)
		{
			SdfPINVOKE.SdfPathListOp_SetAddedItems(swigCPtr, SdfPathVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(SdfPathVector items)
		{
			SdfPINVOKE.SdfPathListOp_SetPrependedItems(swigCPtr, SdfPathVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(SdfPathVector items)
		{
			SdfPINVOKE.SdfPathListOp_SetAppendedItems(swigCPtr, SdfPathVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(SdfPathVector items)
		{
			SdfPINVOKE.SdfPathListOp_SetDeletedItems(swigCPtr, SdfPathVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(SdfPathVector items)
		{
			SdfPINVOKE.SdfPathListOp_SetOrderedItems(swigCPtr, SdfPathVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(SdfPathVector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfPathListOp_SetItems(swigCPtr, SdfPathVector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfPathListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfPathListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, SdfPathVector newItems)
		{
			bool result = SdfPINVOKE.SdfPathListOp_ReplaceOperations(swigCPtr, (int)op, index, n, SdfPathVector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfPathListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfPathListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
