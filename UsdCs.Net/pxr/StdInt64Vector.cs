using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdInt64Vector : IDisposable, IEnumerable, IList<long>, ICollection<long>, IEnumerable<long>
	{
		public sealed class StdInt64VectorEnumerator : IEnumerator, IEnumerator<long>, IDisposable
		{
			private StdInt64Vector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public long Current
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
					return (long)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdInt64VectorEnumerator(StdInt64Vector collection)
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

		public long this[int index]
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

		public StdInt64Vector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdInt64Vector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdInt64Vector obj)
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

		~StdInt64Vector()
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
						StdPINVOKE.delete_StdInt64Vector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdInt64Vector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (long item in c)
			{
				Add(item);
			}
		}

		public StdInt64Vector(IEnumerable<long> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (long item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(long[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(long[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, long[] array, int arrayIndex, int count)
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

		public long[] ToArray()
		{
			long[] array = new long[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<long> IEnumerable<long>.GetEnumerator()
		{
			return new StdInt64VectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdInt64VectorEnumerator(this);
		}

		public StdInt64VectorEnumerator GetEnumerator()
		{
			return new StdInt64VectorEnumerator(this);
		}

		public void Clear()
		{
			StdPINVOKE.StdInt64Vector_Clear(swigCPtr);
		}

		public void Add(long x)
		{
			StdPINVOKE.StdInt64Vector_Add(swigCPtr, x);
		}

		private uint size()
		{
			return StdPINVOKE.StdInt64Vector_size(swigCPtr);
		}

		private uint capacity()
		{
			return StdPINVOKE.StdInt64Vector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			StdPINVOKE.StdInt64Vector_reserve(swigCPtr, n);
		}

		public StdInt64Vector()
			: this(StdPINVOKE.new_StdInt64Vector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdInt64Vector(StdInt64Vector other)
			: this(StdPINVOKE.new_StdInt64Vector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdInt64Vector(int capacity)
			: this(StdPINVOKE.new_StdInt64Vector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private long getitemcopy(int index)
		{
			long result = StdPINVOKE.StdInt64Vector_getitemcopy(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private long getitem(int index)
		{
			long result = StdPINVOKE.StdInt64Vector_getitem(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, long val)
		{
			StdPINVOKE.StdInt64Vector_setitem(swigCPtr, index, val);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdInt64Vector values)
		{
			StdPINVOKE.StdInt64Vector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdInt64Vector GetRange(int index, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdInt64Vector_GetRange(swigCPtr, index, count);
			StdInt64Vector result = ((intPtr == IntPtr.Zero) ? null : new StdInt64Vector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, long x)
		{
			StdPINVOKE.StdInt64Vector_Insert(swigCPtr, index, x);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdInt64Vector values)
		{
			StdPINVOKE.StdInt64Vector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			StdPINVOKE.StdInt64Vector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			StdPINVOKE.StdInt64Vector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdInt64Vector Repeat(long value, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdInt64Vector_Repeat(value, count);
			StdInt64Vector result = ((intPtr == IntPtr.Zero) ? null : new StdInt64Vector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			StdPINVOKE.StdInt64Vector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			StdPINVOKE.StdInt64Vector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdInt64Vector values)
		{
			StdPINVOKE.StdInt64Vector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(long value)
		{
			return StdPINVOKE.StdInt64Vector_Contains(swigCPtr, value);
		}

		public int IndexOf(long value)
		{
			return StdPINVOKE.StdInt64Vector_IndexOf(swigCPtr, value);
		}

		public int LastIndexOf(long value)
		{
			return StdPINVOKE.StdInt64Vector_LastIndexOf(swigCPtr, value);
		}

		public bool Remove(long value)
		{
			return StdPINVOKE.StdInt64Vector_Remove(swigCPtr, value);
		}
	}
}
