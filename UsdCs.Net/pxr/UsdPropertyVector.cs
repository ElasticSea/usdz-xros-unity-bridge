using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdPropertyVector : IDisposable, IEnumerable, IEnumerable<UsdProperty>
	{
		public sealed class UsdPropertyVectorEnumerator : IEnumerator, IEnumerator<UsdProperty>, IDisposable
		{
			private UsdPropertyVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdProperty Current
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
					return (UsdProperty)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdPropertyVectorEnumerator(UsdPropertyVector collection)
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

		public UsdProperty this[int index]
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

		public UsdPropertyVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPropertyVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPropertyVector obj)
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

		~UsdPropertyVector()
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
						UsdPINVOKE.delete_UsdPropertyVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdPropertyVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdProperty item in c)
			{
				Add(item);
			}
		}

		public UsdPropertyVector(IEnumerable<UsdProperty> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdProperty item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdProperty[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdProperty[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdProperty[] array, int arrayIndex, int count)
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

		public UsdProperty[] ToArray()
		{
			UsdProperty[] array = new UsdProperty[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdProperty> IEnumerable<UsdProperty>.GetEnumerator()
		{
			return new UsdPropertyVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdPropertyVectorEnumerator(this);
		}

		public UsdPropertyVectorEnumerator GetEnumerator()
		{
			return new UsdPropertyVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdPINVOKE.UsdPropertyVector_Clear(swigCPtr);
		}

		public void Add(UsdProperty x)
		{
			UsdPINVOKE.UsdPropertyVector_Add(swigCPtr, UsdProperty.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdPINVOKE.UsdPropertyVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdPINVOKE.UsdPropertyVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdPINVOKE.UsdPropertyVector_reserve(swigCPtr, n);
		}

		public UsdPropertyVector()
			: this(UsdPINVOKE.new_UsdPropertyVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdPropertyVector(UsdPropertyVector other)
			: this(UsdPINVOKE.new_UsdPropertyVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPropertyVector(int capacity)
			: this(UsdPINVOKE.new_UsdPropertyVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdProperty getitemcopy(int index)
		{
			UsdProperty result = new UsdProperty(UsdPINVOKE.UsdPropertyVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdProperty getitem(int index)
		{
			UsdProperty result = new UsdProperty(UsdPINVOKE.UsdPropertyVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdProperty val)
		{
			UsdPINVOKE.UsdPropertyVector_setitem(swigCPtr, index, UsdProperty.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdPropertyVector values)
		{
			UsdPINVOKE.UsdPropertyVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPropertyVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdPropertyVector_GetRange(swigCPtr, index, count);
			UsdPropertyVector result = ((intPtr == IntPtr.Zero) ? null : new UsdPropertyVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdProperty x)
		{
			UsdPINVOKE.UsdPropertyVector_Insert(swigCPtr, index, UsdProperty.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdPropertyVector values)
		{
			UsdPINVOKE.UsdPropertyVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdPINVOKE.UsdPropertyVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdPINVOKE.UsdPropertyVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdPropertyVector Repeat(UsdProperty value, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdPropertyVector_Repeat(UsdProperty.getCPtr(value), count);
			UsdPropertyVector result = ((intPtr == IntPtr.Zero) ? null : new UsdPropertyVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdPINVOKE.UsdPropertyVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdPINVOKE.UsdPropertyVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdPropertyVector values)
		{
			UsdPINVOKE.UsdPropertyVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
