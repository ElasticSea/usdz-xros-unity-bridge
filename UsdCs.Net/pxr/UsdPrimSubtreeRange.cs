using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using USD.NET;

namespace pxr
{
	public class UsdPrimSubtreeRange : IEnumerable, IEnumerable<UsdPrim>
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdPrimSubtreeRange(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrimSubtreeRange obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrimSubtreeRange obj)
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

		~UsdPrimSubtreeRange()
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
						UsdPINVOKE.delete_UsdPrimSubtreeRange(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdPrimSubtreeIterator begin()
		{
			return new UsdPrimSubtreeIterator(UsdPINVOKE.UsdPrimSubtreeRange_begin(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSubtreeIterator end()
		{
			return new UsdPrimSubtreeIterator(UsdPINVOKE.UsdPrimSubtreeRange_end(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSubtreeIterator GetStart()
		{
			return new UsdPrimSubtreeIterator(UsdPINVOKE.UsdPrimSubtreeRange_GetStart(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrimSubtreeIterator GetEnd()
		{
			return new UsdPrimSubtreeIterator(UsdPINVOKE.UsdPrimSubtreeRange_GetEnd(swigCPtr), cMemoryOwn: true);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SubtreeIterator(this);
		}

		public IEnumerator<UsdPrim> GetEnumerator()
		{
			return new SubtreeIterator(this);
		}

		public UsdPrimSubtreeRange()
			: this(UsdPINVOKE.new_UsdPrimSubtreeRange(), cMemoryOwn: true)
		{
		}
	}
}
