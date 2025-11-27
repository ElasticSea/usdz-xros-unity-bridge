using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfAttributeSpecHandleVector : IDisposable, IEnumerable, IEnumerable<SdfAttributeSpecHandle>
	{
		public sealed class SdfAttributeSpecHandleVectorEnumerator : IEnumerator, IEnumerator<SdfAttributeSpecHandle>, IDisposable
		{
			private SdfAttributeSpecHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfAttributeSpecHandle Current
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
					return (SdfAttributeSpecHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfAttributeSpecHandleVectorEnumerator(SdfAttributeSpecHandleVector collection)
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

		public SdfAttributeSpecHandle this[int index]
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

		public SdfAttributeSpecHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfAttributeSpecHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfAttributeSpecHandleVector obj)
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

		~SdfAttributeSpecHandleVector()
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
						SdfPINVOKE.delete_SdfAttributeSpecHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfAttributeSpecHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfAttributeSpecHandle item in c)
			{
				Add(item);
			}
		}

		public SdfAttributeSpecHandleVector(IEnumerable<SdfAttributeSpecHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfAttributeSpecHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfAttributeSpecHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfAttributeSpecHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfAttributeSpecHandle[] array, int arrayIndex, int count)
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

		public SdfAttributeSpecHandle[] ToArray()
		{
			SdfAttributeSpecHandle[] array = new SdfAttributeSpecHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfAttributeSpecHandle> IEnumerable<SdfAttributeSpecHandle>.GetEnumerator()
		{
			return new SdfAttributeSpecHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfAttributeSpecHandleVectorEnumerator(this);
		}

		public SdfAttributeSpecHandleVectorEnumerator GetEnumerator()
		{
			return new SdfAttributeSpecHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfAttributeSpecHandle x)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_Add(swigCPtr, SdfAttributeSpecHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfAttributeSpecHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfAttributeSpecHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_reserve(swigCPtr, n);
		}

		public SdfAttributeSpecHandleVector()
			: this(SdfPINVOKE.new_SdfAttributeSpecHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfAttributeSpecHandleVector(SdfAttributeSpecHandleVector other)
			: this(SdfPINVOKE.new_SdfAttributeSpecHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAttributeSpecHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfAttributeSpecHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfAttributeSpecHandle getitemcopy(int index)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfAttributeSpecHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfAttributeSpecHandle getitem(int index)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfAttributeSpecHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfAttributeSpecHandle val)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_setitem(swigCPtr, index, SdfAttributeSpecHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfAttributeSpecHandleVector values)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAttributeSpecHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAttributeSpecHandleVector_GetRange(swigCPtr, index, count);
			SdfAttributeSpecHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfAttributeSpecHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfAttributeSpecHandle x)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_Insert(swigCPtr, index, SdfAttributeSpecHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfAttributeSpecHandleVector values)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfAttributeSpecHandleVector Repeat(SdfAttributeSpecHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfAttributeSpecHandleVector_Repeat(SdfAttributeSpecHandle.getCPtr(value), count);
			SdfAttributeSpecHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfAttributeSpecHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfAttributeSpecHandleVector values)
		{
			SdfPINVOKE.SdfAttributeSpecHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
