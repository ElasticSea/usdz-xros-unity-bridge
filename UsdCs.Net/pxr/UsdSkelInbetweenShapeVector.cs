using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelInbetweenShapeVector : IDisposable, IEnumerable, IEnumerable<UsdSkelInbetweenShape>
	{
		public sealed class UsdSkelInbetweenShapeVectorEnumerator : IEnumerator, IEnumerator<UsdSkelInbetweenShape>, IDisposable
		{
			private UsdSkelInbetweenShapeVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdSkelInbetweenShape Current
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
					return (UsdSkelInbetweenShape)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdSkelInbetweenShapeVectorEnumerator(UsdSkelInbetweenShapeVector collection)
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

		public UsdSkelInbetweenShape this[int index]
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

		public UsdSkelInbetweenShapeVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelInbetweenShapeVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelInbetweenShapeVector obj)
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

		~UsdSkelInbetweenShapeVector()
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
						UsdSkelPINVOKE.delete_UsdSkelInbetweenShapeVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelInbetweenShapeVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdSkelInbetweenShape item in c)
			{
				Add(item);
			}
		}

		public UsdSkelInbetweenShapeVector(IEnumerable<UsdSkelInbetweenShape> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdSkelInbetweenShape item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdSkelInbetweenShape[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdSkelInbetweenShape[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdSkelInbetweenShape[] array, int arrayIndex, int count)
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

		public UsdSkelInbetweenShape[] ToArray()
		{
			UsdSkelInbetweenShape[] array = new UsdSkelInbetweenShape[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdSkelInbetweenShape> IEnumerable<UsdSkelInbetweenShape>.GetEnumerator()
		{
			return new UsdSkelInbetweenShapeVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdSkelInbetweenShapeVectorEnumerator(this);
		}

		public UsdSkelInbetweenShapeVectorEnumerator GetEnumerator()
		{
			return new UsdSkelInbetweenShapeVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_Clear(swigCPtr);
		}

		public void Add(UsdSkelInbetweenShape x)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_Add(swigCPtr, UsdSkelInbetweenShape.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_reserve(swigCPtr, n);
		}

		public UsdSkelInbetweenShapeVector()
			: this(UsdSkelPINVOKE.new_UsdSkelInbetweenShapeVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkelInbetweenShapeVector(UsdSkelInbetweenShapeVector other)
			: this(UsdSkelPINVOKE.new_UsdSkelInbetweenShapeVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelInbetweenShapeVector(int capacity)
			: this(UsdSkelPINVOKE.new_UsdSkelInbetweenShapeVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdSkelInbetweenShape getitemcopy(int index)
		{
			UsdSkelInbetweenShape result = new UsdSkelInbetweenShape(UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdSkelInbetweenShape getitem(int index)
		{
			UsdSkelInbetweenShape result = new UsdSkelInbetweenShape(UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdSkelInbetweenShape val)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_setitem(swigCPtr, index, UsdSkelInbetweenShape.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdSkelInbetweenShapeVector values)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelInbetweenShapeVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_GetRange(swigCPtr, index, count);
			UsdSkelInbetweenShapeVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkelInbetweenShapeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdSkelInbetweenShape x)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_Insert(swigCPtr, index, UsdSkelInbetweenShape.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdSkelInbetweenShapeVector values)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdSkelInbetweenShapeVector Repeat(UsdSkelInbetweenShape value, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_Repeat(UsdSkelInbetweenShape.getCPtr(value), count);
			UsdSkelInbetweenShapeVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkelInbetweenShapeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdSkelInbetweenShapeVector values)
		{
			UsdSkelPINVOKE.UsdSkelInbetweenShapeVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
