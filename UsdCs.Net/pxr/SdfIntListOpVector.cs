using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfIntListOpVector : IDisposable, IEnumerable, IEnumerable<SdfIntListOp>
	{
		public sealed class SdfIntListOpVectorEnumerator : IEnumerator, IEnumerator<SdfIntListOp>, IDisposable
		{
			private SdfIntListOpVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfIntListOp Current
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
					return (SdfIntListOp)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfIntListOpVectorEnumerator(SdfIntListOpVector collection)
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

		public SdfIntListOp this[int index]
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

		public SdfIntListOpVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfIntListOpVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfIntListOpVector obj)
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

		~SdfIntListOpVector()
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
						SdfPINVOKE.delete_SdfIntListOpVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfIntListOpVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfIntListOp item in c)
			{
				Add(item);
			}
		}

		public SdfIntListOpVector(IEnumerable<SdfIntListOp> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfIntListOp item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfIntListOp[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfIntListOp[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfIntListOp[] array, int arrayIndex, int count)
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

		public SdfIntListOp[] ToArray()
		{
			SdfIntListOp[] array = new SdfIntListOp[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfIntListOp> IEnumerable<SdfIntListOp>.GetEnumerator()
		{
			return new SdfIntListOpVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfIntListOpVectorEnumerator(this);
		}

		public SdfIntListOpVectorEnumerator GetEnumerator()
		{
			return new SdfIntListOpVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfIntListOpVector_Clear(swigCPtr);
		}

		public void Add(SdfIntListOp x)
		{
			SdfPINVOKE.SdfIntListOpVector_Add(swigCPtr, SdfIntListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfIntListOpVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfIntListOpVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfIntListOpVector_reserve(swigCPtr, n);
		}

		public SdfIntListOpVector()
			: this(SdfPINVOKE.new_SdfIntListOpVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfIntListOpVector(SdfIntListOpVector other)
			: this(SdfPINVOKE.new_SdfIntListOpVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfIntListOpVector(int capacity)
			: this(SdfPINVOKE.new_SdfIntListOpVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfIntListOp getitemcopy(int index)
		{
			SdfIntListOp result = new SdfIntListOp(SdfPINVOKE.SdfIntListOpVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfIntListOp getitem(int index)
		{
			SdfIntListOp result = new SdfIntListOp(SdfPINVOKE.SdfIntListOpVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfIntListOp val)
		{
			SdfPINVOKE.SdfIntListOpVector_setitem(swigCPtr, index, SdfIntListOp.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfIntListOpVector values)
		{
			SdfPINVOKE.SdfIntListOpVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfIntListOpVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfIntListOpVector_GetRange(swigCPtr, index, count);
			SdfIntListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfIntListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfIntListOp x)
		{
			SdfPINVOKE.SdfIntListOpVector_Insert(swigCPtr, index, SdfIntListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfIntListOpVector values)
		{
			SdfPINVOKE.SdfIntListOpVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfIntListOpVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfIntListOpVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfIntListOpVector Repeat(SdfIntListOp value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfIntListOpVector_Repeat(SdfIntListOp.getCPtr(value), count);
			SdfIntListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfIntListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfIntListOpVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfIntListOpVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfIntListOpVector values)
		{
			SdfPINVOKE.SdfIntListOpVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
