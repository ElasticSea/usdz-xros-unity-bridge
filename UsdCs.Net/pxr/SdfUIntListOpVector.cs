using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfUIntListOpVector : IDisposable, IEnumerable, IEnumerable<SdfUIntListOp>
	{
		public sealed class SdfUIntListOpVectorEnumerator : IEnumerator, IEnumerator<SdfUIntListOp>, IDisposable
		{
			private SdfUIntListOpVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfUIntListOp Current
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
					return (SdfUIntListOp)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfUIntListOpVectorEnumerator(SdfUIntListOpVector collection)
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

		public SdfUIntListOp this[int index]
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

		public SdfUIntListOpVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfUIntListOpVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfUIntListOpVector obj)
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

		~SdfUIntListOpVector()
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
						SdfPINVOKE.delete_SdfUIntListOpVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfUIntListOpVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfUIntListOp item in c)
			{
				Add(item);
			}
		}

		public SdfUIntListOpVector(IEnumerable<SdfUIntListOp> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfUIntListOp item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfUIntListOp[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfUIntListOp[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfUIntListOp[] array, int arrayIndex, int count)
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

		public SdfUIntListOp[] ToArray()
		{
			SdfUIntListOp[] array = new SdfUIntListOp[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfUIntListOp> IEnumerable<SdfUIntListOp>.GetEnumerator()
		{
			return new SdfUIntListOpVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfUIntListOpVectorEnumerator(this);
		}

		public SdfUIntListOpVectorEnumerator GetEnumerator()
		{
			return new SdfUIntListOpVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfUIntListOpVector_Clear(swigCPtr);
		}

		public void Add(SdfUIntListOp x)
		{
			SdfPINVOKE.SdfUIntListOpVector_Add(swigCPtr, SdfUIntListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfUIntListOpVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfUIntListOpVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfUIntListOpVector_reserve(swigCPtr, n);
		}

		public SdfUIntListOpVector()
			: this(SdfPINVOKE.new_SdfUIntListOpVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfUIntListOpVector(SdfUIntListOpVector other)
			: this(SdfPINVOKE.new_SdfUIntListOpVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfUIntListOpVector(int capacity)
			: this(SdfPINVOKE.new_SdfUIntListOpVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfUIntListOp getitemcopy(int index)
		{
			SdfUIntListOp result = new SdfUIntListOp(SdfPINVOKE.SdfUIntListOpVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfUIntListOp getitem(int index)
		{
			SdfUIntListOp result = new SdfUIntListOp(SdfPINVOKE.SdfUIntListOpVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfUIntListOp val)
		{
			SdfPINVOKE.SdfUIntListOpVector_setitem(swigCPtr, index, SdfUIntListOp.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfUIntListOpVector values)
		{
			SdfPINVOKE.SdfUIntListOpVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfUIntListOpVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfUIntListOpVector_GetRange(swigCPtr, index, count);
			SdfUIntListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfUIntListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfUIntListOp x)
		{
			SdfPINVOKE.SdfUIntListOpVector_Insert(swigCPtr, index, SdfUIntListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfUIntListOpVector values)
		{
			SdfPINVOKE.SdfUIntListOpVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfUIntListOpVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfUIntListOpVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfUIntListOpVector Repeat(SdfUIntListOp value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfUIntListOpVector_Repeat(SdfUIntListOp.getCPtr(value), count);
			SdfUIntListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfUIntListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfUIntListOpVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfUIntListOpVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfUIntListOpVector values)
		{
			SdfPINVOKE.SdfUIntListOpVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
