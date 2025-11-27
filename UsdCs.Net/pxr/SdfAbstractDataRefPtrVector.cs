using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfAbstractDataRefPtrVector : IDisposable, IEnumerable, IEnumerable<SWIGTYPE_p_SdfAbstractData>
	{
		public sealed class SdfAbstractDataRefPtrVectorEnumerator : IEnumerator, IEnumerator<SWIGTYPE_p_SdfAbstractData>, IDisposable
		{
			private SdfAbstractDataRefPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SWIGTYPE_p_SdfAbstractData Current
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
					return (SWIGTYPE_p_SdfAbstractData)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfAbstractDataRefPtrVectorEnumerator(SdfAbstractDataRefPtrVector collection)
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

		public SWIGTYPE_p_SdfAbstractData this[int index]
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

		public SdfAbstractDataRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfAbstractDataRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfAbstractDataRefPtrVector obj)
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

		~SdfAbstractDataRefPtrVector()
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
						SdfPINVOKE.delete_SdfAbstractDataRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfAbstractDataRefPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SWIGTYPE_p_SdfAbstractData item in c)
			{
				Add(item);
			}
		}

		public SdfAbstractDataRefPtrVector(IEnumerable<SWIGTYPE_p_SdfAbstractData> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SWIGTYPE_p_SdfAbstractData item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SWIGTYPE_p_SdfAbstractData[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SWIGTYPE_p_SdfAbstractData[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SWIGTYPE_p_SdfAbstractData[] array, int arrayIndex, int count)
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

		public SWIGTYPE_p_SdfAbstractData[] ToArray()
		{
			SWIGTYPE_p_SdfAbstractData[] array = new SWIGTYPE_p_SdfAbstractData[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SWIGTYPE_p_SdfAbstractData> IEnumerable<SWIGTYPE_p_SdfAbstractData>.GetEnumerator()
		{
			return new SdfAbstractDataRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfAbstractDataRefPtrVectorEnumerator(this);
		}

		public SdfAbstractDataRefPtrVectorEnumerator GetEnumerator()
		{
			return new SdfAbstractDataRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_Clear(swigCPtr);
		}

		public void Add(SWIGTYPE_p_SdfAbstractData x)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_Add(swigCPtr, SWIGTYPE_p_SdfAbstractData.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfAbstractDataRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfAbstractDataRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_reserve(swigCPtr, n);
		}

		public SdfAbstractDataRefPtrVector()
			: this(SdfPINVOKE.new_SdfAbstractDataRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfAbstractDataRefPtrVector(SdfAbstractDataRefPtrVector other)
			: this(SdfPINVOKE.new_SdfAbstractDataRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAbstractDataRefPtrVector(int capacity)
			: this(SdfPINVOKE.new_SdfAbstractDataRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SWIGTYPE_p_SdfAbstractData getitemcopy(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAbstractDataRefPtrVector_getitemcopy(swigCPtr, index);
			SWIGTYPE_p_SdfAbstractData result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SdfAbstractData(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SWIGTYPE_p_SdfAbstractData getitem(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAbstractDataRefPtrVector_getitem(swigCPtr, index);
			SWIGTYPE_p_SdfAbstractData result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SdfAbstractData(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SWIGTYPE_p_SdfAbstractData val)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_setitem(swigCPtr, index, SWIGTYPE_p_SdfAbstractData.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfAbstractDataRefPtrVector values)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAbstractDataRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAbstractDataRefPtrVector_GetRange(swigCPtr, index, count);
			SdfAbstractDataRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfAbstractDataRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SWIGTYPE_p_SdfAbstractData x)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_Insert(swigCPtr, index, SWIGTYPE_p_SdfAbstractData.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfAbstractDataRefPtrVector values)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfAbstractDataRefPtrVector Repeat(SWIGTYPE_p_SdfAbstractData value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAbstractDataRefPtrVector_Repeat(SWIGTYPE_p_SdfAbstractData.getCPtr(value), count);
			SdfAbstractDataRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfAbstractDataRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfAbstractDataRefPtrVector values)
		{
			SdfPINVOKE.SdfAbstractDataRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
