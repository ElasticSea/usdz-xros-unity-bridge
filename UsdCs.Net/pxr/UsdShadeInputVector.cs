using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeInputVector : IDisposable, IEnumerable, IEnumerable<UsdShadeInput>
	{
		public sealed class UsdShadeInputVectorEnumerator : IEnumerator, IEnumerator<UsdShadeInput>, IDisposable
		{
			private UsdShadeInputVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdShadeInput Current
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
					return (UsdShadeInput)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdShadeInputVectorEnumerator(UsdShadeInputVector collection)
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

		public UsdShadeInput this[int index]
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

		public UsdShadeInputVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeInputVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeInputVector obj)
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

		~UsdShadeInputVector()
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
						UsdShadePINVOKE.delete_UsdShadeInputVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeInputVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeInput item in c)
			{
				Add(item);
			}
		}

		public UsdShadeInputVector(IEnumerable<UsdShadeInput> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeInput item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdShadeInput[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdShadeInput[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdShadeInput[] array, int arrayIndex, int count)
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

		public UsdShadeInput[] ToArray()
		{
			UsdShadeInput[] array = new UsdShadeInput[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdShadeInput> IEnumerable<UsdShadeInput>.GetEnumerator()
		{
			return new UsdShadeInputVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdShadeInputVectorEnumerator(this);
		}

		public UsdShadeInputVectorEnumerator GetEnumerator()
		{
			return new UsdShadeInputVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdShadePINVOKE.UsdShadeInputVector_Clear(swigCPtr);
		}

		public void Add(UsdShadeInput x)
		{
			UsdShadePINVOKE.UsdShadeInputVector_Add(swigCPtr, UsdShadeInput.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdShadePINVOKE.UsdShadeInputVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdShadePINVOKE.UsdShadeInputVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdShadePINVOKE.UsdShadeInputVector_reserve(swigCPtr, n);
		}

		public UsdShadeInputVector()
			: this(UsdShadePINVOKE.new_UsdShadeInputVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdShadeInputVector(UsdShadeInputVector other)
			: this(UsdShadePINVOKE.new_UsdShadeInputVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeInputVector(int capacity)
			: this(UsdShadePINVOKE.new_UsdShadeInputVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdShadeInput getitemcopy(int index)
		{
			UsdShadeInput result = new UsdShadeInput(UsdShadePINVOKE.UsdShadeInputVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdShadeInput getitem(int index)
		{
			UsdShadeInput result = new UsdShadeInput(UsdShadePINVOKE.UsdShadeInputVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdShadeInput val)
		{
			UsdShadePINVOKE.UsdShadeInputVector_setitem(swigCPtr, index, UsdShadeInput.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdShadeInputVector values)
		{
			UsdShadePINVOKE.UsdShadeInputVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeInputVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeInputVector_GetRange(swigCPtr, index, count);
			UsdShadeInputVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeInputVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdShadeInput x)
		{
			UsdShadePINVOKE.UsdShadeInputVector_Insert(swigCPtr, index, UsdShadeInput.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdShadeInputVector values)
		{
			UsdShadePINVOKE.UsdShadeInputVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdShadePINVOKE.UsdShadeInputVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeInputVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdShadeInputVector Repeat(UsdShadeInput value, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeInputVector_Repeat(UsdShadeInput.getCPtr(value), count);
			UsdShadeInputVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeInputVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdShadePINVOKE.UsdShadeInputVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeInputVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdShadeInputVector values)
		{
			UsdShadePINVOKE.UsdShadeInputVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
