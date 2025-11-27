using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfNamespaceEditDetailVector : IDisposable, IEnumerable, IEnumerable<SdfNamespaceEditDetail>
	{
		public sealed class SdfNamespaceEditDetailVectorEnumerator : IEnumerator, IEnumerator<SdfNamespaceEditDetail>, IDisposable
		{
			private SdfNamespaceEditDetailVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfNamespaceEditDetail Current
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
					return (SdfNamespaceEditDetail)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfNamespaceEditDetailVectorEnumerator(SdfNamespaceEditDetailVector collection)
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

		public SdfNamespaceEditDetail this[int index]
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

		public SdfNamespaceEditDetailVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfNamespaceEditDetailVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfNamespaceEditDetailVector obj)
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

		~SdfNamespaceEditDetailVector()
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
						SdfPINVOKE.delete_SdfNamespaceEditDetailVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfNamespaceEditDetailVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfNamespaceEditDetail item in c)
			{
				Add(item);
			}
		}

		public SdfNamespaceEditDetailVector(IEnumerable<SdfNamespaceEditDetail> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfNamespaceEditDetail item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfNamespaceEditDetail[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfNamespaceEditDetail[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfNamespaceEditDetail[] array, int arrayIndex, int count)
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

		public SdfNamespaceEditDetail[] ToArray()
		{
			SdfNamespaceEditDetail[] array = new SdfNamespaceEditDetail[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfNamespaceEditDetail> IEnumerable<SdfNamespaceEditDetail>.GetEnumerator()
		{
			return new SdfNamespaceEditDetailVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfNamespaceEditDetailVectorEnumerator(this);
		}

		public SdfNamespaceEditDetailVectorEnumerator GetEnumerator()
		{
			return new SdfNamespaceEditDetailVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_Clear(swigCPtr);
		}

		public void Add(SdfNamespaceEditDetail x)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_Add(swigCPtr, SdfNamespaceEditDetail.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfNamespaceEditDetailVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfNamespaceEditDetailVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_reserve(swigCPtr, n);
		}

		public SdfNamespaceEditDetailVector()
			: this(SdfPINVOKE.new_SdfNamespaceEditDetailVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfNamespaceEditDetailVector(SdfNamespaceEditDetailVector other)
			: this(SdfPINVOKE.new_SdfNamespaceEditDetailVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfNamespaceEditDetailVector(int capacity)
			: this(SdfPINVOKE.new_SdfNamespaceEditDetailVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfNamespaceEditDetail getitemcopy(int index)
		{
			SdfNamespaceEditDetail result = new SdfNamespaceEditDetail(SdfPINVOKE.SdfNamespaceEditDetailVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfNamespaceEditDetail getitem(int index)
		{
			SdfNamespaceEditDetail result = new SdfNamespaceEditDetail(SdfPINVOKE.SdfNamespaceEditDetailVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfNamespaceEditDetail val)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_setitem(swigCPtr, index, SdfNamespaceEditDetail.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfNamespaceEditDetailVector values)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfNamespaceEditDetailVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfNamespaceEditDetailVector_GetRange(swigCPtr, index, count);
			SdfNamespaceEditDetailVector result = ((intPtr == IntPtr.Zero) ? null : new SdfNamespaceEditDetailVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfNamespaceEditDetail x)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_Insert(swigCPtr, index, SdfNamespaceEditDetail.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfNamespaceEditDetailVector values)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfNamespaceEditDetailVector Repeat(SdfNamespaceEditDetail value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfNamespaceEditDetailVector_Repeat(SdfNamespaceEditDetail.getCPtr(value), count);
			SdfNamespaceEditDetailVector result = ((intPtr == IntPtr.Zero) ? null : new SdfNamespaceEditDetailVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfNamespaceEditDetailVector values)
		{
			SdfPINVOKE.SdfNamespaceEditDetailVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
