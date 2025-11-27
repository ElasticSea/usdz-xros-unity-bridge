using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdFloatVectorVector : IDisposable, IEnumerable, IEnumerable<StdFloatVector>
	{
		public sealed class StdFloatVectorVectorEnumerator : IEnumerator, IEnumerator<StdFloatVector>, IDisposable
		{
			private StdFloatVectorVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public StdFloatVector Current
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
					return (StdFloatVector)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdFloatVectorVectorEnumerator(StdFloatVectorVector collection)
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

		public StdFloatVector this[int index]
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

		public StdFloatVectorVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdFloatVectorVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdFloatVectorVector obj)
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

		~StdFloatVectorVector()
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
						StdPINVOKE.delete_StdFloatVectorVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdFloatVectorVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (StdFloatVector item in c)
			{
				Add(item);
			}
		}

		public StdFloatVectorVector(IEnumerable<StdFloatVector> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (StdFloatVector item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(StdFloatVector[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(StdFloatVector[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, StdFloatVector[] array, int arrayIndex, int count)
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

		public StdFloatVector[] ToArray()
		{
			StdFloatVector[] array = new StdFloatVector[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<StdFloatVector> IEnumerable<StdFloatVector>.GetEnumerator()
		{
			return new StdFloatVectorVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdFloatVectorVectorEnumerator(this);
		}

		public StdFloatVectorVectorEnumerator GetEnumerator()
		{
			return new StdFloatVectorVectorEnumerator(this);
		}

		public void Clear()
		{
			StdPINVOKE.StdFloatVectorVector_Clear(swigCPtr);
		}

		public void Add(StdFloatVector x)
		{
			StdPINVOKE.StdFloatVectorVector_Add(swigCPtr, StdFloatVector.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return StdPINVOKE.StdFloatVectorVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return StdPINVOKE.StdFloatVectorVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			StdPINVOKE.StdFloatVectorVector_reserve(swigCPtr, n);
		}

		public StdFloatVectorVector()
			: this(StdPINVOKE.new_StdFloatVectorVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdFloatVectorVector(StdFloatVectorVector other)
			: this(StdPINVOKE.new_StdFloatVectorVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdFloatVectorVector(int capacity)
			: this(StdPINVOKE.new_StdFloatVectorVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private StdFloatVector getitemcopy(int index)
		{
			StdFloatVector result = new StdFloatVector(StdPINVOKE.StdFloatVectorVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private StdFloatVector getitem(int index)
		{
			StdFloatVector result = new StdFloatVector(StdPINVOKE.StdFloatVectorVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, StdFloatVector val)
		{
			StdPINVOKE.StdFloatVectorVector_setitem(swigCPtr, index, StdFloatVector.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdFloatVectorVector values)
		{
			StdPINVOKE.StdFloatVectorVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdFloatVectorVector GetRange(int index, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdFloatVectorVector_GetRange(swigCPtr, index, count);
			StdFloatVectorVector result = ((intPtr == IntPtr.Zero) ? null : new StdFloatVectorVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, StdFloatVector x)
		{
			StdPINVOKE.StdFloatVectorVector_Insert(swigCPtr, index, StdFloatVector.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdFloatVectorVector values)
		{
			StdPINVOKE.StdFloatVectorVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			StdPINVOKE.StdFloatVectorVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			StdPINVOKE.StdFloatVectorVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdFloatVectorVector Repeat(StdFloatVector value, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdFloatVectorVector_Repeat(StdFloatVector.getCPtr(value), count);
			StdFloatVectorVector result = ((intPtr == IntPtr.Zero) ? null : new StdFloatVectorVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			StdPINVOKE.StdFloatVectorVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			StdPINVOKE.StdFloatVectorVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdFloatVectorVector values)
		{
			StdPINVOKE.StdFloatVectorVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
