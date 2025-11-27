using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfReferenceListOpVector : IDisposable, IEnumerable, IEnumerable<SdfReferenceListOp>
	{
		public sealed class SdfReferenceListOpVectorEnumerator : IEnumerator, IEnumerator<SdfReferenceListOp>, IDisposable
		{
			private SdfReferenceListOpVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfReferenceListOp Current
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
					return (SdfReferenceListOp)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfReferenceListOpVectorEnumerator(SdfReferenceListOpVector collection)
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

		public SdfReferenceListOp this[int index]
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

		public SdfReferenceListOpVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfReferenceListOpVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfReferenceListOpVector obj)
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

		~SdfReferenceListOpVector()
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
						SdfPINVOKE.delete_SdfReferenceListOpVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfReferenceListOpVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfReferenceListOp item in c)
			{
				Add(item);
			}
		}

		public SdfReferenceListOpVector(IEnumerable<SdfReferenceListOp> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfReferenceListOp item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfReferenceListOp[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfReferenceListOp[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfReferenceListOp[] array, int arrayIndex, int count)
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

		public SdfReferenceListOp[] ToArray()
		{
			SdfReferenceListOp[] array = new SdfReferenceListOp[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfReferenceListOp> IEnumerable<SdfReferenceListOp>.GetEnumerator()
		{
			return new SdfReferenceListOpVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfReferenceListOpVectorEnumerator(this);
		}

		public SdfReferenceListOpVectorEnumerator GetEnumerator()
		{
			return new SdfReferenceListOpVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfReferenceListOpVector_Clear(swigCPtr);
		}

		public void Add(SdfReferenceListOp x)
		{
			SdfPINVOKE.SdfReferenceListOpVector_Add(swigCPtr, SdfReferenceListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfReferenceListOpVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfReferenceListOpVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfReferenceListOpVector_reserve(swigCPtr, n);
		}

		public SdfReferenceListOpVector()
			: this(SdfPINVOKE.new_SdfReferenceListOpVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfReferenceListOpVector(SdfReferenceListOpVector other)
			: this(SdfPINVOKE.new_SdfReferenceListOpVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfReferenceListOpVector(int capacity)
			: this(SdfPINVOKE.new_SdfReferenceListOpVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfReferenceListOp getitemcopy(int index)
		{
			SdfReferenceListOp result = new SdfReferenceListOp(SdfPINVOKE.SdfReferenceListOpVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfReferenceListOp getitem(int index)
		{
			SdfReferenceListOp result = new SdfReferenceListOp(SdfPINVOKE.SdfReferenceListOpVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfReferenceListOp val)
		{
			SdfPINVOKE.SdfReferenceListOpVector_setitem(swigCPtr, index, SdfReferenceListOp.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfReferenceListOpVector values)
		{
			SdfPINVOKE.SdfReferenceListOpVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfReferenceListOpVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfReferenceListOpVector_GetRange(swigCPtr, index, count);
			SdfReferenceListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfReferenceListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfReferenceListOp x)
		{
			SdfPINVOKE.SdfReferenceListOpVector_Insert(swigCPtr, index, SdfReferenceListOp.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfReferenceListOpVector values)
		{
			SdfPINVOKE.SdfReferenceListOpVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfReferenceListOpVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfReferenceListOpVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfReferenceListOpVector Repeat(SdfReferenceListOp value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfReferenceListOpVector_Repeat(SdfReferenceListOp.getCPtr(value), count);
			SdfReferenceListOpVector result = ((intPtr == IntPtr.Zero) ? null : new SdfReferenceListOpVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfReferenceListOpVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfReferenceListOpVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfReferenceListOpVector values)
		{
			SdfPINVOKE.SdfReferenceListOpVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
