using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfTfTokenListOpVector : IDisposable, IEnumerable, IEnumerable<SdfTokenListOp>
	{
		public sealed class SdfTfTokenListOpVectorEnumerator : IEnumerator, IEnumerator<SdfTokenListOp>, IDisposable
		{
			private SdfTfTokenListOpVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfTokenListOp Current
			{
				get
				{
					if (currentIndex == -1)
					{
						throw new InvalidOperationException("Enumeration not started.");
					}
					if (currentIndex > currentSize - 1)
					{
						throw new InvalidOperationException("Enumeration finished.");
					}
					if (currentObject == null)
					{
						throw new InvalidOperationException("Collection modified.");
					}
					return (SdfTokenListOp)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfTfTokenListOpVectorEnumerator(SdfTfTokenListOpVector collection)
			{
				collectionRef = collection;
				currentIndex = -1;
				currentObject = null;
				currentSize = collectionRef.Count;
			}

			public bool MoveNext()
			{
				int count = collectionRef.Count;
				bool flag = currentIndex + 1 < count && count == currentSize;
				if (flag)
				{
					currentIndex++;
					currentObject = collectionRef[currentIndex];
				}
				else
				{
					currentObject = null;
				}
				return flag;
			}

			public void Reset()
			{
				currentIndex = -1;
				currentObject = null;
				if (collectionRef.Count != currentSize)
				{
					throw new InvalidOperationException("Collection modified.");
				}
			}

			public void Dispose()
			{
				currentIndex = -1;
				currentObject = null;
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

		public SdfTokenListOp this[int index]
		{
			get
			{
				return getitem(index);
			}
			set
			{
				setitem(index, value);
			}
		}

		public int Capacity
		{
			get
			{
				return (int)capacity();
			}
			set
			{
				if (value < 0 || (uint)value < size())
				{
					throw new ArgumentOutOfRangeException("Capacity");
				}
				reserve((uint)value);
			}
		}

		public int Count => (int)size();

		public bool IsSynchronized => false;

		public SdfTfTokenListOpVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfTfTokenListOpVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfTfTokenListOpVector obj)
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

		~SdfTfTokenListOpVector()
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
						SdfPINVOKE.delete_SdfTfTokenListOpVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfTfTokenListOpVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfTokenListOp item in c)
			{
				Add(item);
			}
		}

		public SdfTfTokenListOpVector(IEnumerable<SdfTokenListOp> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfTokenListOp item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfTokenListOp[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfTokenListOp[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfTokenListOp[] array, int arrayIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Value is less than zero");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Value is less than zero");
			}
			if (array.Rank > 1)
			{
				throw new ArgumentException("Multi dimensional array.", "array");
			}
			if (index + count > Count || arrayIndex + count > array.Length)
			{
				throw new ArgumentException("Number of elements to copy is too large.");
			}
			for (int i = 0; i < count; i++)
			{
				array.SetValue(getitemcopy(index + i), arrayIndex + i);
			}
		}

		public SdfTokenListOp[] ToArray()
		{
			SdfTokenListOp[] array = new SdfTokenListOp[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfTokenListOp> IEnumerable<SdfTokenListOp>.GetEnumerator()
		{
			return new SdfTfTokenListOpVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfTfTokenListOpVectorEnumerator(this);
		}

		public SdfTfTokenListOpVectorEnumerator GetEnumerator()
		{
			return new SdfTfTokenListOpVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfTfTokenListOpVector_Clear(swigCPtr);
		}

		public void Add(SdfTokenListOp x)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_Add(swigCPtr, SdfTokenListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfTfTokenListOpVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfTfTokenListOpVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_reserve(swigCPtr, n);
		}

		public SdfTfTokenListOpVector()
			: this(SdfPINVOKE.new_SdfTfTokenListOpVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfTfTokenListOpVector(SdfTfTokenListOpVector other)
			: this(SdfPINVOKE.new_SdfTfTokenListOpVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfTfTokenListOpVector(int capacity)
			: this(SdfPINVOKE.new_SdfTfTokenListOpVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfTokenListOp getitemcopy(int index)
		{
			SdfTokenListOp result = new SdfTokenListOp(SdfPINVOKE.SdfTfTokenListOpVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfTokenListOp getitem(int index)
		{
			SdfTokenListOp result = new SdfTokenListOp(SdfPINVOKE.SdfTfTokenListOpVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfTokenListOp val)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_setitem(swigCPtr, index, SdfTokenListOp.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfTfTokenListOpVector values)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfTfTokenListOpVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfTfTokenListOpVector_GetRange(swigCPtr, index, count);
			SdfTfTokenListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfTfTokenListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfTokenListOp x)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_Insert(swigCPtr, index, SdfTokenListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfTfTokenListOpVector values)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfTfTokenListOpVector Repeat(SdfTokenListOp value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfTfTokenListOpVector_Repeat(SdfTokenListOp.getCPtr(value), count);
			SdfTfTokenListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfTfTokenListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfTfTokenListOpVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfTfTokenListOpVector values)
		{
			SdfPINVOKE.SdfTfTokenListOpVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
