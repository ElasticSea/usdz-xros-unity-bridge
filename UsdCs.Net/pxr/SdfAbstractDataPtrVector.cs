using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfAbstractDataPtrVector : IDisposable, IEnumerable, IEnumerable<SWIGTYPE_p_SdfAbstractData>
	{
		public sealed class SdfAbstractDataPtrVectorEnumerator : IEnumerator, IEnumerator<SWIGTYPE_p_SdfAbstractData>, IDisposable
		{
			private SdfAbstractDataPtrVector collectionRef;

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

			public SdfAbstractDataPtrVectorEnumerator(SdfAbstractDataPtrVector collection)
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

		public SdfAbstractDataPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfAbstractDataPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfAbstractDataPtrVector obj)
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

		~SdfAbstractDataPtrVector()
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
						SdfPINVOKE.delete_SdfAbstractDataPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfAbstractDataPtrVector(IEnumerable c)
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

		public SdfAbstractDataPtrVector(IEnumerable<SWIGTYPE_p_SdfAbstractData> c)
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
			return new SdfAbstractDataPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfAbstractDataPtrVectorEnumerator(this);
		}

		public SdfAbstractDataPtrVectorEnumerator GetEnumerator()
		{
			return new SdfAbstractDataPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_Clear(swigCPtr);
		}

		public void Add(SWIGTYPE_p_SdfAbstractData x)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_Add(swigCPtr, SWIGTYPE_p_SdfAbstractData.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfAbstractDataPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfAbstractDataPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_reserve(swigCPtr, n);
		}

		public SdfAbstractDataPtrVector()
			: this(SdfPINVOKE.new_SdfAbstractDataPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfAbstractDataPtrVector(SdfAbstractDataPtrVector other)
			: this(SdfPINVOKE.new_SdfAbstractDataPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAbstractDataPtrVector(int capacity)
			: this(SdfPINVOKE.new_SdfAbstractDataPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SWIGTYPE_p_SdfAbstractData getitemcopy(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAbstractDataPtrVector_getitemcopy(swigCPtr, index);
			SWIGTYPE_p_SdfAbstractData result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SdfAbstractData(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SWIGTYPE_p_SdfAbstractData getitem(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAbstractDataPtrVector_getitem(swigCPtr, index);
			SWIGTYPE_p_SdfAbstractData result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SdfAbstractData(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SWIGTYPE_p_SdfAbstractData val)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_setitem(swigCPtr, index, SWIGTYPE_p_SdfAbstractData.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfAbstractDataPtrVector values)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAbstractDataPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAbstractDataPtrVector_GetRange(swigCPtr, index, count);
			SdfAbstractDataPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfAbstractDataPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SWIGTYPE_p_SdfAbstractData x)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_Insert(swigCPtr, index, SWIGTYPE_p_SdfAbstractData.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfAbstractDataPtrVector values)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfAbstractDataPtrVector Repeat(SWIGTYPE_p_SdfAbstractData value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAbstractDataPtrVector_Repeat(SWIGTYPE_p_SdfAbstractData.getCPtr(value), count);
			SdfAbstractDataPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfAbstractDataPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfAbstractDataPtrVector values)
		{
			SdfPINVOKE.SdfAbstractDataPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
