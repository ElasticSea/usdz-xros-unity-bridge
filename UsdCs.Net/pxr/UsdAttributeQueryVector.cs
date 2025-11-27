using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdAttributeQueryVector : IDisposable, IEnumerable, IEnumerable<UsdAttributeQuery>
	{
		public sealed class UsdAttributeQueryVectorEnumerator : IEnumerator, IEnumerator<UsdAttributeQuery>, IDisposable
		{
			private UsdAttributeQueryVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdAttributeQuery Current
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
					return (UsdAttributeQuery)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdAttributeQueryVectorEnumerator(UsdAttributeQueryVector collection)
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

		public UsdAttributeQuery this[int index]
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

		public UsdAttributeQueryVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdAttributeQueryVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdAttributeQueryVector obj)
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

		~UsdAttributeQueryVector()
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
						UsdPINVOKE.delete_UsdAttributeQueryVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdAttributeQueryVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdAttributeQuery item in c)
			{
				Add(item);
			}
		}

		public UsdAttributeQueryVector(IEnumerable<UsdAttributeQuery> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdAttributeQuery item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdAttributeQuery[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdAttributeQuery[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdAttributeQuery[] array, int arrayIndex, int count)
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

		public UsdAttributeQuery[] ToArray()
		{
			UsdAttributeQuery[] array = new UsdAttributeQuery[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdAttributeQuery> IEnumerable<UsdAttributeQuery>.GetEnumerator()
		{
			return new UsdAttributeQueryVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdAttributeQueryVectorEnumerator(this);
		}

		public UsdAttributeQueryVectorEnumerator GetEnumerator()
		{
			return new UsdAttributeQueryVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdPINVOKE.UsdAttributeQueryVector_Clear(swigCPtr);
		}

		public void Add(UsdAttributeQuery x)
		{
			UsdPINVOKE.UsdAttributeQueryVector_Add(swigCPtr, UsdAttributeQuery.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdPINVOKE.UsdAttributeQueryVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdPINVOKE.UsdAttributeQueryVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdPINVOKE.UsdAttributeQueryVector_reserve(swigCPtr, n);
		}

		public UsdAttributeQueryVector()
			: this(UsdPINVOKE.new_UsdAttributeQueryVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdAttributeQueryVector(UsdAttributeQueryVector other)
			: this(UsdPINVOKE.new_UsdAttributeQueryVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdAttributeQueryVector(int capacity)
			: this(UsdPINVOKE.new_UsdAttributeQueryVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdAttributeQuery getitemcopy(int index)
		{
			UsdAttributeQuery result = new UsdAttributeQuery(UsdPINVOKE.UsdAttributeQueryVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdAttributeQuery getitem(int index)
		{
			UsdAttributeQuery result = new UsdAttributeQuery(UsdPINVOKE.UsdAttributeQueryVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdAttributeQuery val)
		{
			UsdPINVOKE.UsdAttributeQueryVector_setitem(swigCPtr, index, UsdAttributeQuery.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdAttributeQueryVector values)
		{
			UsdPINVOKE.UsdAttributeQueryVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdAttributeQueryVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdAttributeQueryVector_GetRange(swigCPtr, index, count);
			UsdAttributeQueryVector result = ((intPtr == IntPtr.Zero) ? null : new UsdAttributeQueryVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdAttributeQuery x)
		{
			UsdPINVOKE.UsdAttributeQueryVector_Insert(swigCPtr, index, UsdAttributeQuery.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdAttributeQueryVector values)
		{
			UsdPINVOKE.UsdAttributeQueryVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdPINVOKE.UsdAttributeQueryVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdPINVOKE.UsdAttributeQueryVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdAttributeQueryVector Repeat(UsdAttributeQuery value, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdAttributeQueryVector_Repeat(UsdAttributeQuery.getCPtr(value), count);
			UsdAttributeQueryVector result = ((intPtr == IntPtr.Zero) ? null : new UsdAttributeQueryVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdPINVOKE.UsdAttributeQueryVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdPINVOKE.UsdAttributeQueryVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdAttributeQueryVector values)
		{
			UsdPINVOKE.UsdAttributeQueryVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
