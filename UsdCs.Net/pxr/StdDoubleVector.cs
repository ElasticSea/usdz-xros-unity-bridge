using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdDoubleVector : IDisposable, IEnumerable, IList<double>, ICollection<double>, IEnumerable<double>
	{
		public sealed class StdDoubleVectorEnumerator : IEnumerator, IEnumerator<double>, IDisposable
		{
			private StdDoubleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public double Current
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
					return (double)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdDoubleVectorEnumerator(StdDoubleVector collection)
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

		public double this[int index]
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

		public StdDoubleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdDoubleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdDoubleVector obj)
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

		~StdDoubleVector()
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
						StdPINVOKE.delete_StdDoubleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdDoubleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (double item in c)
			{
				Add(item);
			}
		}

		public StdDoubleVector(IEnumerable<double> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (double item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(double[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(double[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, double[] array, int arrayIndex, int count)
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

		public double[] ToArray()
		{
			double[] array = new double[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<double> IEnumerable<double>.GetEnumerator()
		{
			return new StdDoubleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdDoubleVectorEnumerator(this);
		}

		public StdDoubleVectorEnumerator GetEnumerator()
		{
			return new StdDoubleVectorEnumerator(this);
		}

		public void Clear()
		{
			StdPINVOKE.StdDoubleVector_Clear(swigCPtr);
		}

		public void Add(double x)
		{
			StdPINVOKE.StdDoubleVector_Add(swigCPtr, x);
		}

		private uint size()
		{
			return StdPINVOKE.StdDoubleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return StdPINVOKE.StdDoubleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			StdPINVOKE.StdDoubleVector_reserve(swigCPtr, n);
		}

		public StdDoubleVector()
			: this(StdPINVOKE.new_StdDoubleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdDoubleVector(StdDoubleVector other)
			: this(StdPINVOKE.new_StdDoubleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdDoubleVector(int capacity)
			: this(StdPINVOKE.new_StdDoubleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private double getitemcopy(int index)
		{
			double result = StdPINVOKE.StdDoubleVector_getitemcopy(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private double getitem(int index)
		{
			double result = StdPINVOKE.StdDoubleVector_getitem(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, double val)
		{
			StdPINVOKE.StdDoubleVector_setitem(swigCPtr, index, val);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdDoubleVector values)
		{
			StdPINVOKE.StdDoubleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdDoubleVector GetRange(int index, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdDoubleVector_GetRange(swigCPtr, index, count);
			StdDoubleVector result = ((intPtr == IntPtr.Zero) ? null : new StdDoubleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, double x)
		{
			StdPINVOKE.StdDoubleVector_Insert(swigCPtr, index, x);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdDoubleVector values)
		{
			StdPINVOKE.StdDoubleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			StdPINVOKE.StdDoubleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			StdPINVOKE.StdDoubleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdDoubleVector Repeat(double value, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdDoubleVector_Repeat(value, count);
			StdDoubleVector result = ((intPtr == IntPtr.Zero) ? null : new StdDoubleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			StdPINVOKE.StdDoubleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			StdPINVOKE.StdDoubleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdDoubleVector values)
		{
			StdPINVOKE.StdDoubleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(double value)
		{
			return StdPINVOKE.StdDoubleVector_Contains(swigCPtr, value);
		}

		public int IndexOf(double value)
		{
			return StdPINVOKE.StdDoubleVector_IndexOf(swigCPtr, value);
		}

		public int LastIndexOf(double value)
		{
			return StdPINVOKE.StdDoubleVector_LastIndexOf(swigCPtr, value);
		}

		public bool Remove(double value)
		{
			return StdPINVOKE.StdDoubleVector_Remove(swigCPtr, value);
		}
	}
}
