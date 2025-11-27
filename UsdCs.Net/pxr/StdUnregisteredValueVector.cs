using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdUnregisteredValueVector : IDisposable, IEnumerable, IEnumerable<SdfUnregisteredValue>
	{
		public sealed class StdUnregisteredValueVectorEnumerator : IEnumerator, IEnumerator<SdfUnregisteredValue>, IDisposable
		{
			private StdUnregisteredValueVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfUnregisteredValue Current
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
					return (SdfUnregisteredValue)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdUnregisteredValueVectorEnumerator(StdUnregisteredValueVector collection)
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

		public SdfUnregisteredValue this[int index]
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

		public StdUnregisteredValueVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdUnregisteredValueVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdUnregisteredValueVector obj)
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

		~StdUnregisteredValueVector()
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
						SdfPINVOKE.delete_StdUnregisteredValueVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdUnregisteredValueVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfUnregisteredValue item in c)
			{
				Add(item);
			}
		}

		public StdUnregisteredValueVector(IEnumerable<SdfUnregisteredValue> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfUnregisteredValue item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfUnregisteredValue[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfUnregisteredValue[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfUnregisteredValue[] array, int arrayIndex, int count)
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

		public SdfUnregisteredValue[] ToArray()
		{
			SdfUnregisteredValue[] array = new SdfUnregisteredValue[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfUnregisteredValue> IEnumerable<SdfUnregisteredValue>.GetEnumerator()
		{
			return new StdUnregisteredValueVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdUnregisteredValueVectorEnumerator(this);
		}

		public StdUnregisteredValueVectorEnumerator GetEnumerator()
		{
			return new StdUnregisteredValueVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.StdUnregisteredValueVector_Clear(swigCPtr);
		}

		public void Add(SdfUnregisteredValue x)
		{
			SdfPINVOKE.StdUnregisteredValueVector_Add(swigCPtr, SdfUnregisteredValue.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.StdUnregisteredValueVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.StdUnregisteredValueVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.StdUnregisteredValueVector_reserve(swigCPtr, n);
		}

		public StdUnregisteredValueVector()
			: this(SdfPINVOKE.new_StdUnregisteredValueVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdUnregisteredValueVector(StdUnregisteredValueVector other)
			: this(SdfPINVOKE.new_StdUnregisteredValueVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdUnregisteredValueVector(int capacity)
			: this(SdfPINVOKE.new_StdUnregisteredValueVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfUnregisteredValue getitemcopy(int index)
		{
			SdfUnregisteredValue result = new SdfUnregisteredValue(SdfPINVOKE.StdUnregisteredValueVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfUnregisteredValue getitem(int index)
		{
			SdfUnregisteredValue result = new SdfUnregisteredValue(SdfPINVOKE.StdUnregisteredValueVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfUnregisteredValue val)
		{
			SdfPINVOKE.StdUnregisteredValueVector_setitem(swigCPtr, index, SdfUnregisteredValue.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdUnregisteredValueVector values)
		{
			SdfPINVOKE.StdUnregisteredValueVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdUnregisteredValueVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.StdUnregisteredValueVector_GetRange(swigCPtr, index, count);
			StdUnregisteredValueVector result = ((intPtr == IntPtr.Zero) ? null : new StdUnregisteredValueVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfUnregisteredValue x)
		{
			SdfPINVOKE.StdUnregisteredValueVector_Insert(swigCPtr, index, SdfUnregisteredValue.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdUnregisteredValueVector values)
		{
			SdfPINVOKE.StdUnregisteredValueVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.StdUnregisteredValueVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.StdUnregisteredValueVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdUnregisteredValueVector Repeat(SdfUnregisteredValue value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.StdUnregisteredValueVector_Repeat(SdfUnregisteredValue.getCPtr(value), count);
			StdUnregisteredValueVector result = ((intPtr == IntPtr.Zero) ? null : new StdUnregisteredValueVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.StdUnregisteredValueVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.StdUnregisteredValueVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdUnregisteredValueVector values)
		{
			SdfPINVOKE.StdUnregisteredValueVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
