using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdTimeCodeVector : IDisposable, IEnumerable, IEnumerable<UsdTimeCode>
	{
		public sealed class UsdTimeCodeVectorEnumerator : IEnumerator, IEnumerator<UsdTimeCode>, IDisposable
		{
			private UsdTimeCodeVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdTimeCode Current
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
					return (UsdTimeCode)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdTimeCodeVectorEnumerator(UsdTimeCodeVector collection)
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

		public UsdTimeCode this[int index]
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

		public UsdTimeCodeVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdTimeCodeVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdTimeCodeVector obj)
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

		~UsdTimeCodeVector()
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
						UsdPINVOKE.delete_UsdTimeCodeVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdTimeCodeVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdTimeCode item in c)
			{
				Add(item);
			}
		}

		public UsdTimeCodeVector(IEnumerable<UsdTimeCode> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdTimeCode item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdTimeCode[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdTimeCode[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdTimeCode[] array, int arrayIndex, int count)
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

		public UsdTimeCode[] ToArray()
		{
			UsdTimeCode[] array = new UsdTimeCode[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdTimeCode> IEnumerable<UsdTimeCode>.GetEnumerator()
		{
			return new UsdTimeCodeVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdTimeCodeVectorEnumerator(this);
		}

		public UsdTimeCodeVectorEnumerator GetEnumerator()
		{
			return new UsdTimeCodeVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdPINVOKE.UsdTimeCodeVector_Clear(swigCPtr);
		}

		public void Add(UsdTimeCode x)
		{
			UsdPINVOKE.UsdTimeCodeVector_Add(swigCPtr, UsdTimeCode.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdPINVOKE.UsdTimeCodeVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdPINVOKE.UsdTimeCodeVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdPINVOKE.UsdTimeCodeVector_reserve(swigCPtr, n);
		}

		public UsdTimeCodeVector()
			: this(UsdPINVOKE.new_UsdTimeCodeVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdTimeCodeVector(UsdTimeCodeVector other)
			: this(UsdPINVOKE.new_UsdTimeCodeVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdTimeCodeVector(int capacity)
			: this(UsdPINVOKE.new_UsdTimeCodeVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdTimeCode getitemcopy(int index)
		{
			UsdTimeCode result = new UsdTimeCode(UsdPINVOKE.UsdTimeCodeVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdTimeCode getitem(int index)
		{
			UsdTimeCode result = new UsdTimeCode(UsdPINVOKE.UsdTimeCodeVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdTimeCode val)
		{
			UsdPINVOKE.UsdTimeCodeVector_setitem(swigCPtr, index, UsdTimeCode.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdTimeCodeVector values)
		{
			UsdPINVOKE.UsdTimeCodeVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdTimeCodeVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdTimeCodeVector_GetRange(swigCPtr, index, count);
			UsdTimeCodeVector result = ((intPtr == IntPtr.Zero) ? null : new UsdTimeCodeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdTimeCode x)
		{
			UsdPINVOKE.UsdTimeCodeVector_Insert(swigCPtr, index, UsdTimeCode.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdTimeCodeVector values)
		{
			UsdPINVOKE.UsdTimeCodeVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdPINVOKE.UsdTimeCodeVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdPINVOKE.UsdTimeCodeVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdTimeCodeVector Repeat(UsdTimeCode value, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdTimeCodeVector_Repeat(UsdTimeCode.getCPtr(value), count);
			UsdTimeCodeVector result = ((intPtr == IntPtr.Zero) ? null : new UsdTimeCodeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdPINVOKE.UsdTimeCodeVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdPINVOKE.UsdTimeCodeVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdTimeCodeVector values)
		{
			UsdPINVOKE.UsdTimeCodeVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
