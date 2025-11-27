using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeMaterialVector : IDisposable, IEnumerable, IEnumerable<UsdShadeMaterial>
	{
		public sealed class UsdShadeMaterialVectorEnumerator : IEnumerator, IEnumerator<UsdShadeMaterial>, IDisposable
		{
			private UsdShadeMaterialVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdShadeMaterial Current
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
					return (UsdShadeMaterial)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdShadeMaterialVectorEnumerator(UsdShadeMaterialVector collection)
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

		public UsdShadeMaterial this[int index]
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

		public UsdShadeMaterialVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeMaterialVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeMaterialVector obj)
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

		~UsdShadeMaterialVector()
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
						UsdShadePINVOKE.delete_UsdShadeMaterialVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeMaterialVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeMaterial item in c)
			{
				Add(item);
			}
		}

		public UsdShadeMaterialVector(IEnumerable<UsdShadeMaterial> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeMaterial item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdShadeMaterial[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdShadeMaterial[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdShadeMaterial[] array, int arrayIndex, int count)
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

		public UsdShadeMaterial[] ToArray()
		{
			UsdShadeMaterial[] array = new UsdShadeMaterial[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdShadeMaterial> IEnumerable<UsdShadeMaterial>.GetEnumerator()
		{
			return new UsdShadeMaterialVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdShadeMaterialVectorEnumerator(this);
		}

		public UsdShadeMaterialVectorEnumerator GetEnumerator()
		{
			return new UsdShadeMaterialVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_Clear(swigCPtr);
		}

		public void Add(UsdShadeMaterial x)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_Add(swigCPtr, UsdShadeMaterial.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdShadePINVOKE.UsdShadeMaterialVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdShadePINVOKE.UsdShadeMaterialVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_reserve(swigCPtr, n);
		}

		public UsdShadeMaterialVector()
			: this(UsdShadePINVOKE.new_UsdShadeMaterialVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdShadeMaterialVector(UsdShadeMaterialVector other)
			: this(UsdShadePINVOKE.new_UsdShadeMaterialVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeMaterialVector(int capacity)
			: this(UsdShadePINVOKE.new_UsdShadeMaterialVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdShadeMaterial getitemcopy(int index)
		{
			UsdShadeMaterial result = new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterialVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdShadeMaterial getitem(int index)
		{
			UsdShadeMaterial result = new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterialVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdShadeMaterial val)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_setitem(swigCPtr, index, UsdShadeMaterial.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdShadeMaterialVector values)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeMaterialVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeMaterialVector_GetRange(swigCPtr, index, count);
			UsdShadeMaterialVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeMaterialVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdShadeMaterial x)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_Insert(swigCPtr, index, UsdShadeMaterial.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdShadeMaterialVector values)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdShadeMaterialVector Repeat(UsdShadeMaterial value, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeMaterialVector_Repeat(UsdShadeMaterial.getCPtr(value), count);
			UsdShadeMaterialVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeMaterialVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdShadeMaterialVector values)
		{
			UsdShadePINVOKE.UsdShadeMaterialVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
