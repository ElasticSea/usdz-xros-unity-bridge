using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdAttributeVector : IDisposable, IEnumerable, IEnumerable<UsdAttribute>
	{
		public sealed class UsdAttributeVectorEnumerator : IEnumerator, IEnumerator<UsdAttribute>, IDisposable
		{
			private UsdAttributeVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdAttribute Current
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
					return (UsdAttribute)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdAttributeVectorEnumerator(UsdAttributeVector collection)
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

		public UsdAttribute this[int index]
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

		public UsdAttributeVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdAttributeVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdAttributeVector obj)
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

		~UsdAttributeVector()
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
						UsdPINVOKE.delete_UsdAttributeVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdAttributeVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdAttribute item in c)
			{
				Add(item);
			}
		}

		public UsdAttributeVector(IEnumerable<UsdAttribute> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdAttribute item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdAttribute[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdAttribute[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdAttribute[] array, int arrayIndex, int count)
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

		public UsdAttribute[] ToArray()
		{
			UsdAttribute[] array = new UsdAttribute[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdAttribute> IEnumerable<UsdAttribute>.GetEnumerator()
		{
			return new UsdAttributeVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdAttributeVectorEnumerator(this);
		}

		public UsdAttributeVectorEnumerator GetEnumerator()
		{
			return new UsdAttributeVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdPINVOKE.UsdAttributeVector_Clear(swigCPtr);
		}

		public void Add(UsdAttribute x)
		{
			UsdPINVOKE.UsdAttributeVector_Add(swigCPtr, UsdAttribute.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdPINVOKE.UsdAttributeVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdPINVOKE.UsdAttributeVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdPINVOKE.UsdAttributeVector_reserve(swigCPtr, n);
		}

		public UsdAttributeVector()
			: this(UsdPINVOKE.new_UsdAttributeVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdAttributeVector(UsdAttributeVector other)
			: this(UsdPINVOKE.new_UsdAttributeVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdAttributeVector(int capacity)
			: this(UsdPINVOKE.new_UsdAttributeVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdAttribute getitemcopy(int index)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdAttributeVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdAttribute getitem(int index)
		{
			UsdAttribute result = new UsdAttribute(UsdPINVOKE.UsdAttributeVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdAttribute val)
		{
			UsdPINVOKE.UsdAttributeVector_setitem(swigCPtr, index, UsdAttribute.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdAttributeVector values)
		{
			UsdPINVOKE.UsdAttributeVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdAttributeVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdAttributeVector_GetRange(swigCPtr, index, count);
			UsdAttributeVector result = ((intPtr == IntPtr.Zero) ? null : new UsdAttributeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdAttribute x)
		{
			UsdPINVOKE.UsdAttributeVector_Insert(swigCPtr, index, UsdAttribute.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdAttributeVector values)
		{
			UsdPINVOKE.UsdAttributeVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdPINVOKE.UsdAttributeVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdPINVOKE.UsdAttributeVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdAttributeVector Repeat(UsdAttribute value, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdAttributeVector_Repeat(UsdAttribute.getCPtr(value), count);
			UsdAttributeVector result = ((intPtr == IntPtr.Zero) ? null : new UsdAttributeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdPINVOKE.UsdAttributeVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdPINVOKE.UsdAttributeVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdAttributeVector values)
		{
			UsdPINVOKE.UsdAttributeVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
