using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfInt64ListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfInt64ListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfInt64ListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfInt64ListOp obj)
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

		~SdfInt64ListOp()
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
						SdfPINVOKE.delete_SdfInt64ListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfInt64ListOp CreateExplicit(StdInt64Vector explicitItems)
		{
			SdfInt64ListOp result = new SdfInt64ListOp(SdfPINVOKE.SdfInt64ListOp_CreateExplicit__SWIG_0(StdInt64Vector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfInt64ListOp CreateExplicit()
		{
			return new SdfInt64ListOp(SdfPINVOKE.SdfInt64ListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfInt64ListOp Create(StdInt64Vector prependedItems, StdInt64Vector appendedItems, StdInt64Vector deletedItems)
		{
			SdfInt64ListOp result = new SdfInt64ListOp(SdfPINVOKE.SdfInt64ListOp_Create__SWIG_0(StdInt64Vector.getCPtr(prependedItems), StdInt64Vector.getCPtr(appendedItems), StdInt64Vector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfInt64ListOp Create(StdInt64Vector prependedItems, StdInt64Vector appendedItems)
		{
			SdfInt64ListOp result = new SdfInt64ListOp(SdfPINVOKE.SdfInt64ListOp_Create__SWIG_1(StdInt64Vector.getCPtr(prependedItems), StdInt64Vector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfInt64ListOp Create(StdInt64Vector prependedItems)
		{
			SdfInt64ListOp result = new SdfInt64ListOp(SdfPINVOKE.SdfInt64ListOp_Create__SWIG_2(StdInt64Vector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfInt64ListOp Create()
		{
			return new SdfInt64ListOp(SdfPINVOKE.SdfInt64ListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfInt64ListOp()
			: this(SdfPINVOKE.new_SdfInt64ListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfInt64ListOp rhs)
		{
			SdfPINVOKE.SdfInt64ListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfInt64ListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(long item)
		{
			return SdfPINVOKE.SdfInt64ListOp_HasItem(swigCPtr, item);
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfInt64ListOp_IsExplicit(swigCPtr);
		}

		public StdInt64Vector GetExplicitItems()
		{
			return new StdInt64Vector(SdfPINVOKE.SdfInt64ListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public StdInt64Vector GetAddedItems()
		{
			return new StdInt64Vector(SdfPINVOKE.SdfInt64ListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdInt64Vector GetPrependedItems()
		{
			return new StdInt64Vector(SdfPINVOKE.SdfInt64ListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdInt64Vector GetAppendedItems()
		{
			return new StdInt64Vector(SdfPINVOKE.SdfInt64ListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdInt64Vector GetDeletedItems()
		{
			return new StdInt64Vector(SdfPINVOKE.SdfInt64ListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdInt64Vector GetOrderedItems()
		{
			return new StdInt64Vector(SdfPINVOKE.SdfInt64ListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdInt64Vector GetItems(SdfListOpType type)
		{
			return new StdInt64Vector(SdfPINVOKE.SdfInt64ListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(StdInt64Vector items)
		{
			SdfPINVOKE.SdfInt64ListOp_SetExplicitItems(swigCPtr, StdInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(StdInt64Vector items)
		{
			SdfPINVOKE.SdfInt64ListOp_SetAddedItems(swigCPtr, StdInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(StdInt64Vector items)
		{
			SdfPINVOKE.SdfInt64ListOp_SetPrependedItems(swigCPtr, StdInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(StdInt64Vector items)
		{
			SdfPINVOKE.SdfInt64ListOp_SetAppendedItems(swigCPtr, StdInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(StdInt64Vector items)
		{
			SdfPINVOKE.SdfInt64ListOp_SetDeletedItems(swigCPtr, StdInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(StdInt64Vector items)
		{
			SdfPINVOKE.SdfInt64ListOp_SetOrderedItems(swigCPtr, StdInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(StdInt64Vector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfInt64ListOp_SetItems(swigCPtr, StdInt64Vector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfInt64ListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfInt64ListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdInt64Vector newItems)
		{
			bool result = SdfPINVOKE.SdfInt64ListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdInt64Vector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfInt64ListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfInt64ListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
