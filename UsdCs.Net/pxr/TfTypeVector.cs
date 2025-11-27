using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfTypeVector : IDisposable, IEnumerable, IEnumerable<TfType>
	{
		public sealed class TfTypeVectorEnumerator : IEnumerator, IEnumerator<TfType>, IDisposable
		{
			private TfTypeVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public TfType Current
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
					return (TfType)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public TfTypeVectorEnumerator(TfTypeVector collection)
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

		public TfType this[int index]
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

		public TfTypeVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfTypeVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfTypeVector obj)
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

		~TfTypeVector()
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
						TfPINVOKE.delete_TfTypeVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfTypeVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (TfType item in c)
			{
				Add(item);
			}
		}

		public TfTypeVector(IEnumerable<TfType> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (TfType item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(TfType[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(TfType[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, TfType[] array, int arrayIndex, int count)
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

		public TfType[] ToArray()
		{
			TfType[] array = new TfType[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<TfType> IEnumerable<TfType>.GetEnumerator()
		{
			return new TfTypeVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TfTypeVectorEnumerator(this);
		}

		public TfTypeVectorEnumerator GetEnumerator()
		{
			return new TfTypeVectorEnumerator(this);
		}

		public void Clear()
		{
			TfPINVOKE.TfTypeVector_Clear(swigCPtr);
		}

		public void Add(TfType x)
		{
			TfPINVOKE.TfTypeVector_Add(swigCPtr, TfType.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return TfPINVOKE.TfTypeVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return TfPINVOKE.TfTypeVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			TfPINVOKE.TfTypeVector_reserve(swigCPtr, n);
		}

		public TfTypeVector()
			: this(TfPINVOKE.new_TfTypeVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public TfTypeVector(TfTypeVector other)
			: this(TfPINVOKE.new_TfTypeVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfTypeVector(int capacity)
			: this(TfPINVOKE.new_TfTypeVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private TfType getitemcopy(int index)
		{
			TfType result = new TfType(TfPINVOKE.TfTypeVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private TfType getitem(int index)
		{
			TfType result = new TfType(TfPINVOKE.TfTypeVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, TfType val)
		{
			TfPINVOKE.TfTypeVector_setitem(swigCPtr, index, TfType.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(TfTypeVector values)
		{
			TfPINVOKE.TfTypeVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfTypeVector GetRange(int index, int count)
		{
			IntPtr intPtr = TfPINVOKE.TfTypeVector_GetRange(swigCPtr, index, count);
			TfTypeVector result = ((intPtr == IntPtr.Zero) ? null : new TfTypeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, TfType x)
		{
			TfPINVOKE.TfTypeVector_Insert(swigCPtr, index, TfType.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, TfTypeVector values)
		{
			TfPINVOKE.TfTypeVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			TfPINVOKE.TfTypeVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			TfPINVOKE.TfTypeVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static TfTypeVector Repeat(TfType value, int count)
		{
			IntPtr intPtr = TfPINVOKE.TfTypeVector_Repeat(TfType.getCPtr(value), count);
			TfTypeVector result = ((intPtr == IntPtr.Zero) ? null : new TfTypeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			TfPINVOKE.TfTypeVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			TfPINVOKE.TfTypeVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, TfTypeVector values)
		{
			TfPINVOKE.TfTypeVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
