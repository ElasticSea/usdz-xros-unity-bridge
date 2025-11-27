using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPropertySpecHandleVector : IDisposable, IEnumerable, IEnumerable<SdfPropertySpecHandle>
	{
		public sealed class SdfPropertySpecHandleVectorEnumerator : IEnumerator, IEnumerator<SdfPropertySpecHandle>, IDisposable
		{
			private SdfPropertySpecHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfPropertySpecHandle Current
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
					return (SdfPropertySpecHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfPropertySpecHandleVectorEnumerator(SdfPropertySpecHandleVector collection)
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

		public SdfPropertySpecHandle this[int index]
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

		public SdfPropertySpecHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPropertySpecHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPropertySpecHandleVector obj)
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

		~SdfPropertySpecHandleVector()
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
						SdfPINVOKE.delete_SdfPropertySpecHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPropertySpecHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfPropertySpecHandle item in c)
			{
				Add(item);
			}
		}

		public SdfPropertySpecHandleVector(IEnumerable<SdfPropertySpecHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfPropertySpecHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfPropertySpecHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfPropertySpecHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfPropertySpecHandle[] array, int arrayIndex, int count)
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

		public SdfPropertySpecHandle[] ToArray()
		{
			SdfPropertySpecHandle[] array = new SdfPropertySpecHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfPropertySpecHandle> IEnumerable<SdfPropertySpecHandle>.GetEnumerator()
		{
			return new SdfPropertySpecHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfPropertySpecHandleVectorEnumerator(this);
		}

		public SdfPropertySpecHandleVectorEnumerator GetEnumerator()
		{
			return new SdfPropertySpecHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfPropertySpecHandle x)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_Add(swigCPtr, SdfPropertySpecHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfPropertySpecHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfPropertySpecHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_reserve(swigCPtr, n);
		}

		public SdfPropertySpecHandleVector()
			: this(SdfPINVOKE.new_SdfPropertySpecHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPropertySpecHandleVector(SdfPropertySpecHandleVector other)
			: this(SdfPINVOKE.new_SdfPropertySpecHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPropertySpecHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfPropertySpecHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfPropertySpecHandle getitemcopy(int index)
		{
			SdfPropertySpecHandle result = new SdfPropertySpecHandle(SdfPINVOKE.SdfPropertySpecHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfPropertySpecHandle getitem(int index)
		{
			SdfPropertySpecHandle result = new SdfPropertySpecHandle(SdfPINVOKE.SdfPropertySpecHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfPropertySpecHandle val)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_setitem(swigCPtr, index, SdfPropertySpecHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfPropertySpecHandleVector values)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPropertySpecHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfPropertySpecHandleVector_GetRange(swigCPtr, index, count);
			SdfPropertySpecHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfPropertySpecHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfPropertySpecHandle x)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_Insert(swigCPtr, index, SdfPropertySpecHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfPropertySpecHandleVector values)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfPropertySpecHandleVector Repeat(SdfPropertySpecHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfPropertySpecHandleVector_Repeat(SdfPropertySpecHandle.getCPtr(value), count);
			SdfPropertySpecHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfPropertySpecHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfPropertySpecHandleVector values)
		{
			SdfPINVOKE.SdfPropertySpecHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
