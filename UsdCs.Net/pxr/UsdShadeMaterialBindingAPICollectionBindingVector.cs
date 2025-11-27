using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeMaterialBindingAPICollectionBindingVector : IDisposable, IEnumerable, IEnumerable<UsdShadeMaterialBindingAPI.CollectionBinding>
	{
		public sealed class UsdShadeMaterialBindingAPICollectionBindingVectorEnumerator : IEnumerator, IEnumerator<UsdShadeMaterialBindingAPI.CollectionBinding>, IDisposable
		{
			private UsdShadeMaterialBindingAPICollectionBindingVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdShadeMaterialBindingAPI.CollectionBinding Current
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
					return (UsdShadeMaterialBindingAPI.CollectionBinding)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdShadeMaterialBindingAPICollectionBindingVectorEnumerator(UsdShadeMaterialBindingAPICollectionBindingVector collection)
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

		public UsdShadeMaterialBindingAPI.CollectionBinding this[int index]
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

		public UsdShadeMaterialBindingAPICollectionBindingVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeMaterialBindingAPICollectionBindingVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeMaterialBindingAPICollectionBindingVector obj)
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

		~UsdShadeMaterialBindingAPICollectionBindingVector()
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
						UsdShadePINVOKE.delete_UsdShadeMaterialBindingAPICollectionBindingVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeMaterialBindingAPICollectionBindingVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeMaterialBindingAPI.CollectionBinding item in c)
			{
				Add(item);
			}
		}

		public UsdShadeMaterialBindingAPICollectionBindingVector(IEnumerable<UsdShadeMaterialBindingAPI.CollectionBinding> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeMaterialBindingAPI.CollectionBinding item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdShadeMaterialBindingAPI.CollectionBinding[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdShadeMaterialBindingAPI.CollectionBinding[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdShadeMaterialBindingAPI.CollectionBinding[] array, int arrayIndex, int count)
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

		public UsdShadeMaterialBindingAPI.CollectionBinding[] ToArray()
		{
			UsdShadeMaterialBindingAPI.CollectionBinding[] array = new UsdShadeMaterialBindingAPI.CollectionBinding[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdShadeMaterialBindingAPI.CollectionBinding> IEnumerable<UsdShadeMaterialBindingAPI.CollectionBinding>.GetEnumerator()
		{
			return new UsdShadeMaterialBindingAPICollectionBindingVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdShadeMaterialBindingAPICollectionBindingVectorEnumerator(this);
		}

		public UsdShadeMaterialBindingAPICollectionBindingVectorEnumerator GetEnumerator()
		{
			return new UsdShadeMaterialBindingAPICollectionBindingVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_Clear(swigCPtr);
		}

		public void Add(UsdShadeMaterialBindingAPI.CollectionBinding x)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_Add(swigCPtr, UsdShadeMaterialBindingAPI.CollectionBinding.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_reserve(swigCPtr, n);
		}

		public UsdShadeMaterialBindingAPICollectionBindingVector()
			: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdShadeMaterialBindingAPICollectionBindingVector(UsdShadeMaterialBindingAPICollectionBindingVector other)
			: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeMaterialBindingAPICollectionBindingVector(int capacity)
			: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdShadeMaterialBindingAPI.CollectionBinding getitemcopy(int index)
		{
			UsdShadeMaterialBindingAPI.CollectionBinding result = new UsdShadeMaterialBindingAPI.CollectionBinding(UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdShadeMaterialBindingAPI.CollectionBinding getitem(int index)
		{
			UsdShadeMaterialBindingAPI.CollectionBinding result = new UsdShadeMaterialBindingAPI.CollectionBinding(UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdShadeMaterialBindingAPI.CollectionBinding val)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_setitem(swigCPtr, index, UsdShadeMaterialBindingAPI.CollectionBinding.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdShadeMaterialBindingAPICollectionBindingVector values)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeMaterialBindingAPICollectionBindingVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_GetRange(swigCPtr, index, count);
			UsdShadeMaterialBindingAPICollectionBindingVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeMaterialBindingAPICollectionBindingVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdShadeMaterialBindingAPI.CollectionBinding x)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_Insert(swigCPtr, index, UsdShadeMaterialBindingAPI.CollectionBinding.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdShadeMaterialBindingAPICollectionBindingVector values)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdShadeMaterialBindingAPICollectionBindingVector Repeat(UsdShadeMaterialBindingAPI.CollectionBinding value, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_Repeat(UsdShadeMaterialBindingAPI.CollectionBinding.getCPtr(value), count);
			UsdShadeMaterialBindingAPICollectionBindingVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeMaterialBindingAPICollectionBindingVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdShadeMaterialBindingAPICollectionBindingVector values)
		{
			UsdShadePINVOKE.UsdShadeMaterialBindingAPICollectionBindingVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
