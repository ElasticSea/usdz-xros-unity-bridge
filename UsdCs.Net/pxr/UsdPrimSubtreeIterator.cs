using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdPrimSubtreeIterator : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdPrimSubtreeIterator(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrimSubtreeIterator obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrimSubtreeIterator obj)
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

		~UsdPrimSubtreeIterator()
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
						UsdPINVOKE.delete_UsdPrimSubtreeIterator(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public void MoveNext()
		{
			UsdPINVOKE.UsdPrimSubtreeIterator_MoveNext(swigCPtr);
		}

		public UsdPrim GetCurrent()
		{
			return new UsdPrim(UsdPINVOKE.UsdPrimSubtreeIterator_GetCurrent(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(UsdPrimSubtreeIterator lhs, UsdPrimSubtreeIterator rhs)
		{
			bool result = UsdPINVOKE.UsdPrimSubtreeIterator_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(UsdPrimSubtreeIterator lhs, UsdPrimSubtreeIterator rhs)
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

		public static bool operator !=(UsdPrimSubtreeIterator lhs, UsdPrimSubtreeIterator rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as UsdPrimSubtreeIterator);
		}

		public override int GetHashCode()
		{
			return UsdPINVOKE.UsdPrimSubtreeIterator_GetHashCode(swigCPtr);
		}

		public UsdPrimSubtreeIterator()
			: this(UsdPINVOKE.new_UsdPrimSubtreeIterator(), cMemoryOwn: true)
		{
		}
	}
}
