using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfTokenVector : IDisposable, IEnumerable, IEnumerable<TfToken>
	{
		public sealed class TfTokenVectorEnumerator : IEnumerator, IEnumerator<TfToken>, IDisposable
		{
			private TfTokenVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public TfToken Current
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
					return (TfToken)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public TfTokenVectorEnumerator(TfTokenVector collection)
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

		public TfToken this[int index]
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

		public TfTokenVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfTokenVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfTokenVector obj)
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

		~TfTokenVector()
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
						TfPINVOKE.delete_TfTokenVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfTokenVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (TfToken item in c)
			{
				Add(item);
			}
		}

		public TfTokenVector(IEnumerable<TfToken> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (TfToken item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(TfToken[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(TfToken[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, TfToken[] array, int arrayIndex, int count)
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

		public TfToken[] ToArray()
		{
			TfToken[] array = new TfToken[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<TfToken> IEnumerable<TfToken>.GetEnumerator()
		{
			return new TfTokenVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TfTokenVectorEnumerator(this);
		}

		public TfTokenVectorEnumerator GetEnumerator()
		{
			return new TfTokenVectorEnumerator(this);
		}

		public void Clear()
		{
			TfPINVOKE.TfTokenVector_Clear(swigCPtr);
		}

		public void Add(TfToken x)
		{
			TfPINVOKE.TfTokenVector_Add(swigCPtr, TfToken.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return TfPINVOKE.TfTokenVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return TfPINVOKE.TfTokenVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			TfPINVOKE.TfTokenVector_reserve(swigCPtr, n);
		}

		public TfTokenVector()
			: this(TfPINVOKE.new_TfTokenVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public TfTokenVector(TfTokenVector other)
			: this(TfPINVOKE.new_TfTokenVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfTokenVector(int capacity)
			: this(TfPINVOKE.new_TfTokenVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private TfToken getitemcopy(int index)
		{
			TfToken result = new TfToken(TfPINVOKE.TfTokenVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private TfToken getitem(int index)
		{
			TfToken result = new TfToken(TfPINVOKE.TfTokenVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, TfToken val)
		{
			TfPINVOKE.TfTokenVector_setitem(swigCPtr, index, TfToken.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(TfTokenVector values)
		{
			TfPINVOKE.TfTokenVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfTokenVector GetRange(int index, int count)
		{
			IntPtr intPtr = TfPINVOKE.TfTokenVector_GetRange(swigCPtr, index, count);
			TfTokenVector result = ((intPtr == IntPtr.Zero) ? null : new TfTokenVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, TfToken x)
		{
			TfPINVOKE.TfTokenVector_Insert(swigCPtr, index, TfToken.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, TfTokenVector values)
		{
			TfPINVOKE.TfTokenVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			TfPINVOKE.TfTokenVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			TfPINVOKE.TfTokenVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static TfTokenVector Repeat(TfToken value, int count)
		{
			IntPtr intPtr = TfPINVOKE.TfTokenVector_Repeat(TfToken.getCPtr(value), count);
			TfTokenVector result = ((intPtr == IntPtr.Zero) ? null : new TfTokenVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			TfPINVOKE.TfTokenVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			TfPINVOKE.TfTokenVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, TfTokenVector values)
		{
			TfPINVOKE.TfTokenVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
