using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfUnregisteredValueListOpVector : IDisposable, IEnumerable, IEnumerable<SdfUnregisteredValueListOp>
	{
		public sealed class SdfUnregisteredValueListOpVectorEnumerator : IEnumerator, IEnumerator<SdfUnregisteredValueListOp>, IDisposable
		{
			private SdfUnregisteredValueListOpVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfUnregisteredValueListOp Current
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
					return (SdfUnregisteredValueListOp)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfUnregisteredValueListOpVectorEnumerator(SdfUnregisteredValueListOpVector collection)
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

		public SdfUnregisteredValueListOp this[int index]
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

		public SdfUnregisteredValueListOpVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfUnregisteredValueListOpVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfUnregisteredValueListOpVector obj)
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

		~SdfUnregisteredValueListOpVector()
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
						SdfPINVOKE.delete_SdfUnregisteredValueListOpVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfUnregisteredValueListOpVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfUnregisteredValueListOp item in c)
			{
				Add(item);
			}
		}

		public SdfUnregisteredValueListOpVector(IEnumerable<SdfUnregisteredValueListOp> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfUnregisteredValueListOp item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfUnregisteredValueListOp[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfUnregisteredValueListOp[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfUnregisteredValueListOp[] array, int arrayIndex, int count)
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

		public SdfUnregisteredValueListOp[] ToArray()
		{
			SdfUnregisteredValueListOp[] array = new SdfUnregisteredValueListOp[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfUnregisteredValueListOp> IEnumerable<SdfUnregisteredValueListOp>.GetEnumerator()
		{
			return new SdfUnregisteredValueListOpVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfUnregisteredValueListOpVectorEnumerator(this);
		}

		public SdfUnregisteredValueListOpVectorEnumerator GetEnumerator()
		{
			return new SdfUnregisteredValueListOpVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_Clear(swigCPtr);
		}

		public void Add(SdfUnregisteredValueListOp x)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_Add(swigCPtr, SdfUnregisteredValueListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfUnregisteredValueListOpVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfUnregisteredValueListOpVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_reserve(swigCPtr, n);
		}

		public SdfUnregisteredValueListOpVector()
			: this(SdfPINVOKE.new_SdfUnregisteredValueListOpVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfUnregisteredValueListOpVector(SdfUnregisteredValueListOpVector other)
			: this(SdfPINVOKE.new_SdfUnregisteredValueListOpVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfUnregisteredValueListOpVector(int capacity)
			: this(SdfPINVOKE.new_SdfUnregisteredValueListOpVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfUnregisteredValueListOp getitemcopy(int index)
		{
			SdfUnregisteredValueListOp result = new SdfUnregisteredValueListOp(SdfPINVOKE.SdfUnregisteredValueListOpVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfUnregisteredValueListOp getitem(int index)
		{
			SdfUnregisteredValueListOp result = new SdfUnregisteredValueListOp(SdfPINVOKE.SdfUnregisteredValueListOpVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfUnregisteredValueListOp val)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_setitem(swigCPtr, index, SdfUnregisteredValueListOp.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfUnregisteredValueListOpVector values)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfUnregisteredValueListOpVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfUnregisteredValueListOpVector_GetRange(swigCPtr, index, count);
			SdfUnregisteredValueListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfUnregisteredValueListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfUnregisteredValueListOp x)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_Insert(swigCPtr, index, SdfUnregisteredValueListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfUnregisteredValueListOpVector values)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfUnregisteredValueListOpVector Repeat(SdfUnregisteredValueListOp value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfUnregisteredValueListOpVector_Repeat(SdfUnregisteredValueListOp.getCPtr(value), count);
			SdfUnregisteredValueListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfUnregisteredValueListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfUnregisteredValueListOpVector values)
		{
			SdfPINVOKE.SdfUnregisteredValueListOpVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
