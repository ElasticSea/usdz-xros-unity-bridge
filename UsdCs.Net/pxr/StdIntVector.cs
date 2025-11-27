using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdIntVector : IDisposable, IEnumerable, IList<int>, ICollection<int>, IEnumerable<int>
	{
		public sealed class StdIntVectorEnumerator : IEnumerator, IEnumerator<int>, IDisposable
		{
			private StdIntVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public int Current
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
					return (int)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdIntVectorEnumerator(StdIntVector collection)
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

		public int this[int index]
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

		public StdIntVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdIntVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdIntVector obj)
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

		~StdIntVector()
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
						StdPINVOKE.delete_StdIntVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdIntVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (int item in c)
			{
				Add(item);
			}
		}

		public StdIntVector(IEnumerable<int> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (int item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(int[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(int[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, int[] array, int arrayIndex, int count)
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

		public int[] ToArray()
		{
			int[] array = new int[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			return new StdIntVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdIntVectorEnumerator(this);
		}

		public StdIntVectorEnumerator GetEnumerator()
		{
			return new StdIntVectorEnumerator(this);
		}

		public void Clear()
		{
			StdPINVOKE.StdIntVector_Clear(swigCPtr);
		}

		public void Add(int x)
		{
			StdPINVOKE.StdIntVector_Add(swigCPtr, x);
		}

		private uint size()
		{
			return StdPINVOKE.StdIntVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return StdPINVOKE.StdIntVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			StdPINVOKE.StdIntVector_reserve(swigCPtr, n);
		}

		public StdIntVector()
			: this(StdPINVOKE.new_StdIntVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdIntVector(StdIntVector other)
			: this(StdPINVOKE.new_StdIntVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdIntVector(int capacity)
			: this(StdPINVOKE.new_StdIntVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private int getitemcopy(int index)
		{
			int result = StdPINVOKE.StdIntVector_getitemcopy(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private int getitem(int index)
		{
			int result = StdPINVOKE.StdIntVector_getitem(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, int val)
		{
			StdPINVOKE.StdIntVector_setitem(swigCPtr, index, val);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdIntVector values)
		{
			StdPINVOKE.StdIntVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdIntVector GetRange(int index, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdIntVector_GetRange(swigCPtr, index, count);
			StdIntVector result = ((intPtr == IntPtr.Zero) ? null : new StdIntVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, int x)
		{
			StdPINVOKE.StdIntVector_Insert(swigCPtr, index, x);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdIntVector values)
		{
			StdPINVOKE.StdIntVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			StdPINVOKE.StdIntVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			StdPINVOKE.StdIntVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdIntVector Repeat(int value, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdIntVector_Repeat(value, count);
			StdIntVector result = ((intPtr == IntPtr.Zero) ? null : new StdIntVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			StdPINVOKE.StdIntVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			StdPINVOKE.StdIntVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdIntVector values)
		{
			StdPINVOKE.StdIntVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(int value)
		{
			return StdPINVOKE.StdIntVector_Contains(swigCPtr, value);
		}

		public int IndexOf(int value)
		{
			return StdPINVOKE.StdIntVector_IndexOf(swigCPtr, value);
		}

		public int LastIndexOf(int value)
		{
			return StdPINVOKE.StdIntVector_LastIndexOf(swigCPtr, value);
		}

		public bool Remove(int value)
		{
			return StdPINVOKE.StdIntVector_Remove(swigCPtr, value);
		}
	}
}
