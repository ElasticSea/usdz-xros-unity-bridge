using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelSkinningQueryVector : IDisposable, IEnumerable, IEnumerable<UsdSkelSkinningQuery>
	{
		public sealed class UsdSkelSkinningQueryVectorEnumerator : IEnumerator, IEnumerator<UsdSkelSkinningQuery>, IDisposable
		{
			private UsdSkelSkinningQueryVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdSkelSkinningQuery Current
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
					return (UsdSkelSkinningQuery)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdSkelSkinningQueryVectorEnumerator(UsdSkelSkinningQueryVector collection)
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

		public UsdSkelSkinningQuery this[int index]
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

		public UsdSkelSkinningQueryVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelSkinningQueryVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelSkinningQueryVector obj)
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

		~UsdSkelSkinningQueryVector()
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
						UsdSkelPINVOKE.delete_UsdSkelSkinningQueryVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelSkinningQueryVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdSkelSkinningQuery item in c)
			{
				Add(item);
			}
		}

		public UsdSkelSkinningQueryVector(IEnumerable<UsdSkelSkinningQuery> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdSkelSkinningQuery item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdSkelSkinningQuery[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdSkelSkinningQuery[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdSkelSkinningQuery[] array, int arrayIndex, int count)
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

		public UsdSkelSkinningQuery[] ToArray()
		{
			UsdSkelSkinningQuery[] array = new UsdSkelSkinningQuery[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdSkelSkinningQuery> IEnumerable<UsdSkelSkinningQuery>.GetEnumerator()
		{
			return new UsdSkelSkinningQueryVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdSkelSkinningQueryVectorEnumerator(this);
		}

		public UsdSkelSkinningQueryVectorEnumerator GetEnumerator()
		{
			return new UsdSkelSkinningQueryVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_Clear(swigCPtr);
		}

		public void Add(UsdSkelSkinningQuery x)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_Add(swigCPtr, UsdSkelSkinningQuery.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQueryVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdSkelPINVOKE.UsdSkelSkinningQueryVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_reserve(swigCPtr, n);
		}

		public UsdSkelSkinningQueryVector()
			: this(UsdSkelPINVOKE.new_UsdSkelSkinningQueryVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkelSkinningQueryVector(UsdSkelSkinningQueryVector other)
			: this(UsdSkelPINVOKE.new_UsdSkelSkinningQueryVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelSkinningQueryVector(int capacity)
			: this(UsdSkelPINVOKE.new_UsdSkelSkinningQueryVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdSkelSkinningQuery getitemcopy(int index)
		{
			UsdSkelSkinningQuery result = new UsdSkelSkinningQuery(UsdSkelPINVOKE.UsdSkelSkinningQueryVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdSkelSkinningQuery getitem(int index)
		{
			UsdSkelSkinningQuery result = new UsdSkelSkinningQuery(UsdSkelPINVOKE.UsdSkelSkinningQueryVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdSkelSkinningQuery val)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_setitem(swigCPtr, index, UsdSkelSkinningQuery.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdSkelSkinningQueryVector values)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelSkinningQueryVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelSkinningQueryVector_GetRange(swigCPtr, index, count);
			UsdSkelSkinningQueryVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkelSkinningQueryVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdSkelSkinningQuery x)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_Insert(swigCPtr, index, UsdSkelSkinningQuery.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdSkelSkinningQueryVector values)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdSkelSkinningQueryVector Repeat(UsdSkelSkinningQuery value, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkelSkinningQueryVector_Repeat(UsdSkelSkinningQuery.getCPtr(value), count);
			UsdSkelSkinningQueryVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkelSkinningQueryVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdSkelSkinningQueryVector values)
		{
			UsdSkelPINVOKE.UsdSkelSkinningQueryVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
