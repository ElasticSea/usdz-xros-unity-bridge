using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfFileFormatConstPtrVector : IDisposable, IEnumerable, IEnumerable<SdfFileFormat>
	{
		public sealed class SdfFileFormatConstPtrVectorEnumerator : IEnumerator, IEnumerator<SdfFileFormat>, IDisposable
		{
			private SdfFileFormatConstPtrVector collectionRef;

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

			public SdfFileFormatConstPtrVectorEnumerator(SdfFileFormatConstPtrVector collection)
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

		public SdfFileFormatConstPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfFileFormatConstPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfFileFormatConstPtrVector obj)
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

		~SdfFileFormatConstPtrVector()
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
						SdfPINVOKE.delete_SdfFileFormatConstPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfFileFormatConstPtrVector(IEnumerable c)
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

		public SdfFileFormatConstPtrVector(IEnumerable<SdfFileFormat> c)
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
			return new SdfFileFormatConstPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfFileFormatConstPtrVectorEnumerator(this);
		}

		public SdfFileFormatConstPtrVectorEnumerator GetEnumerator()
		{
			return new SdfFileFormatConstPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_Clear(swigCPtr);
		}

		public void Add(SdfFileFormat x)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_Add(swigCPtr, SdfFileFormat.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfFileFormatConstPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfFileFormatConstPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_reserve(swigCPtr, n);
		}

		public SdfFileFormatConstPtrVector()
			: this(SdfPINVOKE.new_SdfFileFormatConstPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfFileFormatConstPtrVector(SdfFileFormatConstPtrVector other)
			: this(SdfPINVOKE.new_SdfFileFormatConstPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfFileFormatConstPtrVector(int capacity)
			: this(SdfPINVOKE.new_SdfFileFormatConstPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfFileFormat getitemcopy(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatConstPtrVector_getitemcopy(swigCPtr, index);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfFileFormat getitem(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatConstPtrVector_getitem(swigCPtr, index);
			SdfFileFormat result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormat(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfFileFormat val)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_setitem(swigCPtr, index, SdfFileFormat.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfFileFormatConstPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfFileFormatConstPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatConstPtrVector_GetRange(swigCPtr, index, count);
			SdfFileFormatConstPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormatConstPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfFileFormat x)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_Insert(swigCPtr, index, SdfFileFormat.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfFileFormatConstPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfFileFormatConstPtrVector Repeat(SdfFileFormat value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfFileFormatConstPtrVector_Repeat(SdfFileFormat.getCPtr(value), count);
			SdfFileFormatConstPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfFileFormatConstPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfFileFormatConstPtrVector values)
		{
			SdfPINVOKE.SdfFileFormatConstPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
