using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomSubsetVector : IDisposable, IEnumerable, IEnumerable<UsdGeomSubset>
	{
		public sealed class UsdGeomSubsetVectorEnumerator : IEnumerator, IEnumerator<UsdGeomSubset>, IDisposable
		{
			private UsdGeomSubsetVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdGeomSubset Current
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
					return (UsdGeomSubset)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdGeomSubsetVectorEnumerator(UsdGeomSubsetVector collection)
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

		public UsdGeomSubset this[int index]
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

		public UsdGeomSubsetVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomSubsetVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomSubsetVector obj)
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

		~UsdGeomSubsetVector()
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
						UsdGeomPINVOKE.delete_UsdGeomSubsetVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomSubsetVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdGeomSubset item in c)
			{
				Add(item);
			}
		}

		public UsdGeomSubsetVector(IEnumerable<UsdGeomSubset> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdGeomSubset item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdGeomSubset[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdGeomSubset[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdGeomSubset[] array, int arrayIndex, int count)
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

		public UsdGeomSubset[] ToArray()
		{
			UsdGeomSubset[] array = new UsdGeomSubset[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdGeomSubset> IEnumerable<UsdGeomSubset>.GetEnumerator()
		{
			return new UsdGeomSubsetVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdGeomSubsetVectorEnumerator(this);
		}

		public UsdGeomSubsetVectorEnumerator GetEnumerator()
		{
			return new UsdGeomSubsetVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_Clear(swigCPtr);
		}

		public void Add(UsdGeomSubset x)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_Add(swigCPtr, UsdGeomSubset.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdGeomPINVOKE.UsdGeomSubsetVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdGeomPINVOKE.UsdGeomSubsetVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_reserve(swigCPtr, n);
		}

		public UsdGeomSubsetVector()
			: this(UsdGeomPINVOKE.new_UsdGeomSubsetVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdGeomSubsetVector(UsdGeomSubsetVector other)
			: this(UsdGeomPINVOKE.new_UsdGeomSubsetVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomSubsetVector(int capacity)
			: this(UsdGeomPINVOKE.new_UsdGeomSubsetVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdGeomSubset getitemcopy(int index)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubsetVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdGeomSubset getitem(int index)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdGeomPINVOKE.UsdGeomSubsetVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdGeomSubset val)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_setitem(swigCPtr, index, UsdGeomSubset.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdGeomSubsetVector values)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomSubsetVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.UsdGeomSubsetVector_GetRange(swigCPtr, index, count);
			UsdGeomSubsetVector result = ((intPtr == IntPtr.Zero) ? null : new UsdGeomSubsetVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdGeomSubset x)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_Insert(swigCPtr, index, UsdGeomSubset.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdGeomSubsetVector values)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdGeomSubsetVector Repeat(UsdGeomSubset value, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.UsdGeomSubsetVector_Repeat(UsdGeomSubset.getCPtr(value), count);
			UsdGeomSubsetVector result = ((intPtr == IntPtr.Zero) ? null : new UsdGeomSubsetVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdGeomSubsetVector values)
		{
			UsdGeomPINVOKE.UsdGeomSubsetVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
