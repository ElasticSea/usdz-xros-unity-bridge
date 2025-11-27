using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfTimeCodeVector : IDisposable, IEnumerable, IEnumerable<SdfTimeCode>
	{
		public sealed class SdfTimeCodeVectorEnumerator : IEnumerator, IEnumerator<SdfTimeCode>, IDisposable
		{
			private SdfTimeCodeVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfTimeCode Current
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
					return (SdfTimeCode)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfTimeCodeVectorEnumerator(SdfTimeCodeVector collection)
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

		public SdfTimeCode this[int index]
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

		public SdfTimeCodeVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfTimeCodeVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfTimeCodeVector obj)
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

		~SdfTimeCodeVector()
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
						SdfPINVOKE.delete_SdfTimeCodeVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfTimeCodeVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfTimeCode item in c)
			{
				Add(item);
			}
		}

		public SdfTimeCodeVector(IEnumerable<SdfTimeCode> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfTimeCode item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfTimeCode[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfTimeCode[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfTimeCode[] array, int arrayIndex, int count)
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

		public SdfTimeCode[] ToArray()
		{
			SdfTimeCode[] array = new SdfTimeCode[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfTimeCode> IEnumerable<SdfTimeCode>.GetEnumerator()
		{
			return new SdfTimeCodeVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfTimeCodeVectorEnumerator(this);
		}

		public SdfTimeCodeVectorEnumerator GetEnumerator()
		{
			return new SdfTimeCodeVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfTimeCodeVector_Clear(swigCPtr);
		}

		public void Add(SdfTimeCode x)
		{
			SdfPINVOKE.SdfTimeCodeVector_Add(swigCPtr, SdfTimeCode.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfTimeCodeVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfTimeCodeVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfTimeCodeVector_reserve(swigCPtr, n);
		}

		public SdfTimeCodeVector()
			: this(SdfPINVOKE.new_SdfTimeCodeVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfTimeCodeVector(SdfTimeCodeVector other)
			: this(SdfPINVOKE.new_SdfTimeCodeVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfTimeCodeVector(int capacity)
			: this(SdfPINVOKE.new_SdfTimeCodeVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfTimeCode getitemcopy(int index)
		{
			SdfTimeCode result = new SdfTimeCode(SdfPINVOKE.SdfTimeCodeVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfTimeCode getitem(int index)
		{
			SdfTimeCode result = new SdfTimeCode(SdfPINVOKE.SdfTimeCodeVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfTimeCode val)
		{
			SdfPINVOKE.SdfTimeCodeVector_setitem(swigCPtr, index, SdfTimeCode.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfTimeCodeVector values)
		{
			SdfPINVOKE.SdfTimeCodeVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfTimeCodeVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfTimeCodeVector_GetRange(swigCPtr, index, count);
			SdfTimeCodeVector result = ((intPtr == IntPtr.Zero) ? null : new SdfTimeCodeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfTimeCode x)
		{
			SdfPINVOKE.SdfTimeCodeVector_Insert(swigCPtr, index, SdfTimeCode.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfTimeCodeVector values)
		{
			SdfPINVOKE.SdfTimeCodeVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfTimeCodeVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfTimeCodeVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfTimeCodeVector Repeat(SdfTimeCode value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfTimeCodeVector_Repeat(SdfTimeCode.getCPtr(value), count);
			SdfTimeCodeVector result = ((intPtr == IntPtr.Zero) ? null : new SdfTimeCodeVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfTimeCodeVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfTimeCodeVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfTimeCodeVector values)
		{
			SdfPINVOKE.SdfTimeCodeVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
