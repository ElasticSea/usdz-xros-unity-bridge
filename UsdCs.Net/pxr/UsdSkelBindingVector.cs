using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelBindingVector : IDisposable, IEnumerable, IEnumerable<UsdSkelBinding>
	{
		public sealed class UsdSkelBindingVectorEnumerator : IEnumerator, IEnumerator<UsdSkelBinding>, IDisposable
		{
			private UsdSkelBindingVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdSkelBinding Current
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
					return (UsdSkelBinding)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdSkelBindingVectorEnumerator(UsdSkelBindingVector collection)
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

		public UsdSkelBinding this[int index]
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

		public UsdSkelBindingVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelBindingVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelBindingVector obj)
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

		~UsdSkelBindingVector()
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
						UsdSkelPINVOKE.delete_UsdSkelBindingVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelBindingVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdSkelBinding item in c)
			{
				Add(item);
			}
		}

		public UsdSkelBindingVector(IEnumerable<UsdSkelBinding> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdSkelBinding item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdSkelBinding[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdSkelBinding[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdSkelBinding[] array, int arrayIndex, int count)
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

		public UsdSkelBinding[] ToArray()
		{
			UsdSkelBinding[] array = new UsdSkelBinding[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdSkelBinding> IEnumerable<UsdSkelBinding>.GetEnumerator()
		{
			return new UsdSkelBindingVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdSkelBindingVectorEnumerator(this);
		}

		public UsdSkelBindingVectorEnumerator GetEnumerator()
		{
			return new UsdSkelBindingVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_Clear(swigCPtr);
		}

		public void Add(UsdSkelBinding x)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_Add(swigCPtr, UsdSkelBinding.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdSkelPINVOKE.UsdSkelBindingVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdSkelPINVOKE.UsdSkelBindingVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_reserve(swigCPtr, n);
		}

		public UsdSkelBindingVector()
			: this(UsdSkelPINVOKE.new_UsdSkelBindingVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkelBindingVector(UsdSkelBindingVector other)
			: this(UsdSkelPINVOKE.new_UsdSkelBindingVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelBindingVector(int capacity)
			: this(UsdSkelPINVOKE.new_UsdSkelBindingVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdSkelBinding getitemcopy(int index)
		{
			UsdSkelBinding result = new UsdSkelBinding(UsdSkelPINVOKE.UsdSkelBindingVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdSkelBinding getitem(int index)
		{
			UsdSkelBinding result = new UsdSkelBinding(UsdSkelPINVOKE.UsdSkelBindingVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdSkelBinding val)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_setitem(swigCPtr, index, UsdSkelBinding.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdSkelBindingVector values)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelBindingVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelBindingVector_GetRange(swigCPtr, index, count);
			UsdSkelBindingVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkelBindingVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdSkelBinding x)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_Insert(swigCPtr, index, UsdSkelBinding.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdSkelBindingVector values)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdSkelBindingVector Repeat(UsdSkelBinding value, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelBindingVector_Repeat(UsdSkelBinding.getCPtr(value), count);
			UsdSkelBindingVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkelBindingVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdSkelBindingVector values)
		{
			UsdSkelPINVOKE.UsdSkelBindingVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
