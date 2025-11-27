using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdDoubleVectorVector : IDisposable, IEnumerable, IEnumerable<StdDoubleVector>
	{
		public sealed class StdDoubleVectorVectorEnumerator : IEnumerator, IEnumerator<StdDoubleVector>, IDisposable
		{
			private StdDoubleVectorVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public StdDoubleVector Current
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
					return (StdDoubleVector)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdDoubleVectorVectorEnumerator(StdDoubleVectorVector collection)
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

		public StdDoubleVector this[int index]
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

		public StdDoubleVectorVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdDoubleVectorVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdDoubleVectorVector obj)
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

		~StdDoubleVectorVector()
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
						StdPINVOKE.delete_StdDoubleVectorVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdDoubleVectorVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (StdDoubleVector item in c)
			{
				Add(item);
			}
		}

		public StdDoubleVectorVector(IEnumerable<StdDoubleVector> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (StdDoubleVector item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(StdDoubleVector[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(StdDoubleVector[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, StdDoubleVector[] array, int arrayIndex, int count)
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

		public StdDoubleVector[] ToArray()
		{
			StdDoubleVector[] array = new StdDoubleVector[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<StdDoubleVector> IEnumerable<StdDoubleVector>.GetEnumerator()
		{
			return new StdDoubleVectorVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdDoubleVectorVectorEnumerator(this);
		}

		public StdDoubleVectorVectorEnumerator GetEnumerator()
		{
			return new StdDoubleVectorVectorEnumerator(this);
		}

		public void Clear()
		{
			StdPINVOKE.StdDoubleVectorVector_Clear(swigCPtr);
		}

		public void Add(StdDoubleVector x)
		{
			StdPINVOKE.StdDoubleVectorVector_Add(swigCPtr, StdDoubleVector.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return StdPINVOKE.StdDoubleVectorVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return StdPINVOKE.StdDoubleVectorVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			StdPINVOKE.StdDoubleVectorVector_reserve(swigCPtr, n);
		}

		public StdDoubleVectorVector()
			: this(StdPINVOKE.new_StdDoubleVectorVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdDoubleVectorVector(StdDoubleVectorVector other)
			: this(StdPINVOKE.new_StdDoubleVectorVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdDoubleVectorVector(int capacity)
			: this(StdPINVOKE.new_StdDoubleVectorVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private StdDoubleVector getitemcopy(int index)
		{
			StdDoubleVector result = new StdDoubleVector(StdPINVOKE.StdDoubleVectorVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private StdDoubleVector getitem(int index)
		{
			StdDoubleVector result = new StdDoubleVector(StdPINVOKE.StdDoubleVectorVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, StdDoubleVector val)
		{
			StdPINVOKE.StdDoubleVectorVector_setitem(swigCPtr, index, StdDoubleVector.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdDoubleVectorVector values)
		{
			StdPINVOKE.StdDoubleVectorVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdDoubleVectorVector GetRange(int index, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdDoubleVectorVector_GetRange(swigCPtr, index, count);
			StdDoubleVectorVector result = ((intPtr == IntPtr.Zero) ? null : new StdDoubleVectorVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, StdDoubleVector x)
		{
			StdPINVOKE.StdDoubleVectorVector_Insert(swigCPtr, index, StdDoubleVector.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdDoubleVectorVector values)
		{
			StdPINVOKE.StdDoubleVectorVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			StdPINVOKE.StdDoubleVectorVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			StdPINVOKE.StdDoubleVectorVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdDoubleVectorVector Repeat(StdDoubleVector value, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdDoubleVectorVector_Repeat(StdDoubleVector.getCPtr(value), count);
			StdDoubleVectorVector result = ((intPtr == IntPtr.Zero) ? null : new StdDoubleVectorVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			StdPINVOKE.StdDoubleVectorVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			StdPINVOKE.StdDoubleVectorVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdDoubleVectorVector values)
		{
			StdPINVOKE.StdDoubleVectorVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
