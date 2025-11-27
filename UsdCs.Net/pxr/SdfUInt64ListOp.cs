using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfUInt64ListOp : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfUInt64ListOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfUInt64ListOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfUInt64ListOp obj)
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

		~SdfUInt64ListOp()
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
						SdfPINVOKE.delete_SdfUInt64ListOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static SdfUInt64ListOp CreateExplicit(StdUInt64Vector explicitItems)
		{
			SdfUInt64ListOp result = new SdfUInt64ListOp(SdfPINVOKE.SdfUInt64ListOp_CreateExplicit__SWIG_0(StdUInt64Vector.getCPtr(explicitItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUInt64ListOp CreateExplicit()
		{
			return new SdfUInt64ListOp(SdfPINVOKE.SdfUInt64ListOp_CreateExplicit__SWIG_1(), cMemoryOwn: true);
		}

		public static SdfUInt64ListOp Create(StdUInt64Vector prependedItems, StdUInt64Vector appendedItems, StdUInt64Vector deletedItems)
		{
			SdfUInt64ListOp result = new SdfUInt64ListOp(SdfPINVOKE.SdfUInt64ListOp_Create__SWIG_0(StdUInt64Vector.getCPtr(prependedItems), StdUInt64Vector.getCPtr(appendedItems), StdUInt64Vector.getCPtr(deletedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUInt64ListOp Create(StdUInt64Vector prependedItems, StdUInt64Vector appendedItems)
		{
			SdfUInt64ListOp result = new SdfUInt64ListOp(SdfPINVOKE.SdfUInt64ListOp_Create__SWIG_1(StdUInt64Vector.getCPtr(prependedItems), StdUInt64Vector.getCPtr(appendedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUInt64ListOp Create(StdUInt64Vector prependedItems)
		{
			SdfUInt64ListOp result = new SdfUInt64ListOp(SdfPINVOKE.SdfUInt64ListOp_Create__SWIG_2(StdUInt64Vector.getCPtr(prependedItems)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfUInt64ListOp Create()
		{
			return new SdfUInt64ListOp(SdfPINVOKE.SdfUInt64ListOp_Create__SWIG_3(), cMemoryOwn: true);
		}

		public SdfUInt64ListOp()
			: this(SdfPINVOKE.new_SdfUInt64ListOp(), cMemoryOwn: true)
		{
		}

		public void Swap(SdfUInt64ListOp rhs)
		{
			SdfPINVOKE.SdfUInt64ListOp_Swap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasKeys()
		{
			return SdfPINVOKE.SdfUInt64ListOp_HasKeys(swigCPtr);
		}

		public bool HasItem(ulong item)
		{
			return SdfPINVOKE.SdfUInt64ListOp_HasItem(swigCPtr, item);
		}

		public bool IsExplicit()
		{
			return SdfPINVOKE.SdfUInt64ListOp_IsExplicit(swigCPtr);
		}

		public StdUInt64Vector GetExplicitItems()
		{
			return new StdUInt64Vector(SdfPINVOKE.SdfUInt64ListOp_GetExplicitItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUInt64Vector GetAddedItems()
		{
			return new StdUInt64Vector(SdfPINVOKE.SdfUInt64ListOp_GetAddedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUInt64Vector GetPrependedItems()
		{
			return new StdUInt64Vector(SdfPINVOKE.SdfUInt64ListOp_GetPrependedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUInt64Vector GetAppendedItems()
		{
			return new StdUInt64Vector(SdfPINVOKE.SdfUInt64ListOp_GetAppendedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUInt64Vector GetDeletedItems()
		{
			return new StdUInt64Vector(SdfPINVOKE.SdfUInt64ListOp_GetDeletedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUInt64Vector GetOrderedItems()
		{
			return new StdUInt64Vector(SdfPINVOKE.SdfUInt64ListOp_GetOrderedItems(swigCPtr), cMemoryOwn: false);
		}

		public StdUInt64Vector GetItems(SdfListOpType type)
		{
			return new StdUInt64Vector(SdfPINVOKE.SdfUInt64ListOp_GetItems(swigCPtr, (int)type), cMemoryOwn: false);
		}

		public void SetExplicitItems(StdUInt64Vector items)
		{
			SdfPINVOKE.SdfUInt64ListOp_SetExplicitItems(swigCPtr, StdUInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAddedItems(StdUInt64Vector items)
		{
			SdfPINVOKE.SdfUInt64ListOp_SetAddedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPrependedItems(StdUInt64Vector items)
		{
			SdfPINVOKE.SdfUInt64ListOp_SetPrependedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAppendedItems(StdUInt64Vector items)
		{
			SdfPINVOKE.SdfUInt64ListOp_SetAppendedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDeletedItems(StdUInt64Vector items)
		{
			SdfPINVOKE.SdfUInt64ListOp_SetDeletedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetOrderedItems(StdUInt64Vector items)
		{
			SdfPINVOKE.SdfUInt64ListOp_SetOrderedItems(swigCPtr, StdUInt64Vector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetItems(StdUInt64Vector items, SdfListOpType type)
		{
			SdfPINVOKE.SdfUInt64ListOp_SetItems(swigCPtr, StdUInt64Vector.getCPtr(items), (int)type);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Clear()
		{
			SdfPINVOKE.SdfUInt64ListOp_Clear(swigCPtr);
		}

		public void ClearAndMakeExplicit()
		{
			SdfPINVOKE.SdfUInt64ListOp_ClearAndMakeExplicit(swigCPtr);
		}

		public bool ReplaceOperations(SdfListOpType op, uint index, uint n, StdUInt64Vector newItems)
		{
			bool result = SdfPINVOKE.SdfUInt64ListOp_ReplaceOperations(swigCPtr, (int)op, index, n, StdUInt64Vector.getCPtr(newItems));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ComposeOperations(SdfUInt64ListOp stronger, SdfListOpType op)
		{
			SdfPINVOKE.SdfUInt64ListOp_ComposeOperations(swigCPtr, getCPtr(stronger), (int)op);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
