using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfFileFormatPtrVector : IDisposable, IEnumerable, IEnumerable<SdfFileFormat>
	{
		public sealed class SdfFileFormatPtrVectorEnumerator : IEnumerator, IEnumerator<SdfFileFormat>, IDisposable
		{
			private SdfFileFormatPtrVector collectionRef;

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

			public SdfFileFormatPtrVectorEnumerator(SdfFileFormatPtrVector collection)
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

		public SdfFileFormatPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfFileFormatPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfFileFormatPtrVector obj)
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

		~SdfFileFormatPtrVector()
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
						SdfPINVOKE.delete_SdfFileFormatPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfFileFormatPtrVector(IEnumerable c)
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

		public SdfFileFormatPtrVector(IEnumerable<SdfFileFormat> c)
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
			return new SdfFileFormatPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfFileFormatPtrVectorEnumerator(this);
		}

		public SdfFileFormatPtrVectorEnumerator GetEnumerator()
		{
			return new SdfFileFormatPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfFileFormatPtrVector_Clear(swigCPtr);
		}

		public void Add(SdfFileFormat x)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_Add(swigCPtr, SdfFileFormat.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfFileFormatPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfFileFormatPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_reserve(swigCPtr, n);
		}

		public SdfFileFormatPtrVector()
			: this(SdfPINVOKE.new_SdfFileFormatPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfFileFormatPtrVector(SdfFileFormatPtrVector other)
			: this(SdfPINVOKE.new_SdfFileFormatPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfFileFormatPtrVector(int capacity)
			: this(SdfPINVOKE.new_SdfFileFormatPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfFileFormat getitemcopy(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatPtrVector_getitemcopy(swigCPtr, index);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfFileFormat getitem(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatPtrVector_getitem(swigCPtr, index);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfFileFormat val)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_setitem(swigCPtr, index, SdfFileFormat.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfFileFormatPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfFileFormatPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatPtrVector_GetRange(swigCPtr, index, count);
			SdfFileFormatPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormatPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfFileFormat x)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_Insert(swigCPtr, index, SdfFileFormat.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfFileFormatPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfFileFormatPtrVector Repeat(SdfFileFormat value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatPtrVector_Repeat(SdfFileFormat.getCPtr(value), count);
			SdfFileFormatPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormatPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfFileFormatPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfFileFormatPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
