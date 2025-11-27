using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using USD.NET;

namespace pxr
{
	public class UsdPrimSiblingRange : IEnumerable, IEnumerable<UsdPrim>
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdPrimSiblingRange(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrimSiblingRange obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrimSiblingRange obj)
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

		~UsdPrimSiblingRange()
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
						UsdPINVOKE.delete_UsdPrimSiblingRange(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdPrimSiblingIterator begin()
		{
			return new UsdPrimSiblingIterator(UsdPINVOKE.UsdPrimSiblingRange_begin(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSiblingIterator end()
		{
			return new UsdPrimSiblingIterator(UsdPINVOKE.UsdPrimSiblingRange_end(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSiblingIterator GetStart()
		{
			return new UsdPrimSiblingIterator(UsdPINVOKE.UsdPrimSiblingRange_GetStart(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSiblingIterator GetEnd()
		{
			return new UsdPrimSiblingIterator(UsdPINVOKE.UsdPrimSiblingRange_GetEnd(swigCPtr), cMemoryOwn: true);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SiblingIterator(this);
		}

		public IEnumerator<UsdPrim> GetEnumerator()
		{
			return new SiblingIterator(this);
		}

		public UsdPrimSiblingRange()
			: this(UsdPINVOKE.new_UsdPrimSiblingRange(), cMemoryOwn: true)
		{
		}
	}
}
