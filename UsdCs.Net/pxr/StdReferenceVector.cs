using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdReferenceVector : IDisposable, IEnumerable, IEnumerable<SdfReference>
	{
		public sealed class StdReferenceVectorEnumerator : IEnumerator, IEnumerator<SdfReference>, IDisposable
		{
			private StdReferenceVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfReference Current
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
					return (SdfReference)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdReferenceVectorEnumerator(StdReferenceVector collection)
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

		public SdfReference this[int index]
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

		public StdReferenceVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdReferenceVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdReferenceVector obj)
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

		~StdReferenceVector()
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
						SdfPINVOKE.delete_StdReferenceVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdReferenceVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfReference item in c)
			{
				Add(item);
			}
		}

		public StdReferenceVector(IEnumerable<SdfReference> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfReference item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfReference[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfReference[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfReference[] array, int arrayIndex, int count)
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

		public SdfReference[] ToArray()
		{
			SdfReference[] array = new SdfReference[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfReference> IEnumerable<SdfReference>.GetEnumerator()
		{
			return new StdReferenceVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdReferenceVectorEnumerator(this);
		}

		public StdReferenceVectorEnumerator GetEnumerator()
		{
			return new StdReferenceVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.StdReferenceVector_Clear(swigCPtr);
		}

		public void Add(SdfReference x)
		{
			SdfPINVOKE.StdReferenceVector_Add(swigCPtr, SdfReference.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.StdReferenceVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.StdReferenceVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.StdReferenceVector_reserve(swigCPtr, n);
		}

		public StdReferenceVector()
			: this(SdfPINVOKE.new_StdReferenceVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdReferenceVector(StdReferenceVector other)
			: this(SdfPINVOKE.new_StdReferenceVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdReferenceVector(int capacity)
			: this(SdfPINVOKE.new_StdReferenceVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfReference getitemcopy(int index)
		{
			SdfReference result = new SdfReference(SdfPINVOKE.StdReferenceVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfReference getitem(int index)
		{
			SdfReference result = new SdfReference(SdfPINVOKE.StdReferenceVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfReference val)
		{
			SdfPINVOKE.StdReferenceVector_setitem(swigCPtr, index, SdfReference.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdReferenceVector values)
		{
			SdfPINVOKE.StdReferenceVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdReferenceVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.StdReferenceVector_GetRange(swigCPtr, index, count);
			StdReferenceVector result = ((intPtr == IntPtr.Zero) ? null : new StdReferenceVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfReference x)
		{
			SdfPINVOKE.StdReferenceVector_Insert(swigCPtr, index, SdfReference.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdReferenceVector values)
		{
			SdfPINVOKE.StdReferenceVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.StdReferenceVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.StdReferenceVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdReferenceVector Repeat(SdfReference value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.StdReferenceVector_Repeat(SdfReference.getCPtr(value), count);
			StdReferenceVector result = ((intPtr == IntPtr.Zero) ? null : new StdReferenceVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.StdReferenceVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.StdReferenceVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdReferenceVector values)
		{
			SdfPINVOKE.StdReferenceVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
