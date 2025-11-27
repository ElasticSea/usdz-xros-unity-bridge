using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdPrimSiblingIterator : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdPrimSiblingIterator(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrimSiblingIterator obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrimSiblingIterator obj)
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

		~UsdPrimSiblingIterator()
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
						UsdPINVOKE.delete_UsdPrimSiblingIterator(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public void MoveNext()
		{
			UsdPINVOKE.UsdPrimSiblingIterator_MoveNext(swigCPtr);
		}

		public UsdPrim GetCurrent()
		{
			return new UsdPrim(UsdPINVOKE.UsdPrimSiblingIterator_GetCurrent(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(UsdPrimSiblingIterator lhs, UsdPrimSiblingIterator rhs)
		{
			bool result = UsdPINVOKE.UsdPrimSiblingIterator_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(UsdPrimSiblingIterator lhs, UsdPrimSiblingIterator rhs)
		{
			bool flag = (object)lhs == null;
			bool flag2 = (object)rhs == null;
			if (flag == flag2)
			{
				if (!(flag && flag2))
				{
					return Equals(lhs, rhs);
				}
				return true;
			}
			return false;
		}

		public static bool operator !=(UsdPrimSiblingIterator lhs, UsdPrimSiblingIterator rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as UsdPrimSiblingIterator);
		}

		public override int GetHashCode()
		{
			return UsdPINVOKE.UsdPrimSiblingIterator_GetHashCode(swigCPtr);
		}

		public UsdPrimSiblingIterator()
			: this(UsdPINVOKE.new_UsdPrimSiblingIterator(), cMemoryOwn: true)
		{
		}
	}
}
