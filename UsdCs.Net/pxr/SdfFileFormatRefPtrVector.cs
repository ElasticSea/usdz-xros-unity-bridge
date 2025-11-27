using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfFileFormatRefPtrVector : IDisposable, IEnumerable, IEnumerable<SdfFileFormat>
	{
		public sealed class SdfFileFormatRefPtrVectorEnumerator : IEnumerator, IEnumerator<SdfFileFormat>, IDisposable
		{
			private SdfFileFormatRefPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfFileFormat Current
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
					return (SdfFileFormat)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfFileFormatRefPtrVectorEnumerator(SdfFileFormatRefPtrVector collection)
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

		public SdfFileFormat this[int index]
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

		public SdfFileFormatRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfFileFormatRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfFileFormatRefPtrVector obj)
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

		~SdfFileFormatRefPtrVector()
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
						SdfPINVOKE.delete_SdfFileFormatRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfFileFormatRefPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfFileFormat item in c)
			{
				Add(item);
			}
		}

		public SdfFileFormatRefPtrVector(IEnumerable<SdfFileFormat> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfFileFormat item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfFileFormat[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfFileFormat[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfFileFormat[] array, int arrayIndex, int count)
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

		public SdfFileFormat[] ToArray()
		{
			SdfFileFormat[] array = new SdfFileFormat[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfFileFormat> IEnumerable<SdfFileFormat>.GetEnumerator()
		{
			return new SdfFileFormatRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfFileFormatRefPtrVectorEnumerator(this);
		}

		public SdfFileFormatRefPtrVectorEnumerator GetEnumerator()
		{
			return new SdfFileFormatRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_Clear(swigCPtr);
		}

		public void Add(SdfFileFormat x)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_Add(swigCPtr, SdfFileFormat.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfFileFormatRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfFileFormatRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_reserve(swigCPtr, n);
		}

		public SdfFileFormatRefPtrVector()
			: this(SdfPINVOKE.new_SdfFileFormatRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfFileFormatRefPtrVector(SdfFileFormatRefPtrVector other)
			: this(SdfPINVOKE.new_SdfFileFormatRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfFileFormatRefPtrVector(int capacity)
			: this(SdfPINVOKE.new_SdfFileFormatRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfFileFormat getitemcopy(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatRefPtrVector_getitemcopy(swigCPtr, index);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfFileFormat getitem(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatRefPtrVector_getitem(swigCPtr, index);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfFileFormat val)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_setitem(swigCPtr, index, SdfFileFormat.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfFileFormatRefPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfFileFormatRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatRefPtrVector_GetRange(swigCPtr, index, count);
			SdfFileFormatRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormatRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfFileFormat x)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_Insert(swigCPtr, index, SdfFileFormat.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfFileFormatRefPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfFileFormatRefPtrVector Repeat(SdfFileFormat value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatRefPtrVector_Repeat(SdfFileFormat.getCPtr(value), count);
			SdfFileFormatRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormatRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfFileFormatRefPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
