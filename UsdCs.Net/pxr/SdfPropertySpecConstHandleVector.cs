using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPropertySpecConstHandleVector : IDisposable, IEnumerable, IEnumerable<SdfPropertySpecConstHandle>
	{
		public sealed class SdfPropertySpecConstHandleVectorEnumerator : IEnumerator, IEnumerator<SdfPropertySpecConstHandle>, IDisposable
		{
			private SdfPropertySpecConstHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfPropertySpecConstHandle Current
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
					return (SdfPropertySpecConstHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfPropertySpecConstHandleVectorEnumerator(SdfPropertySpecConstHandleVector collection)
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

		public SdfPropertySpecConstHandle this[int index]
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

		public SdfPropertySpecConstHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPropertySpecConstHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPropertySpecConstHandleVector obj)
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

		~SdfPropertySpecConstHandleVector()
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
						SdfPINVOKE.delete_SdfPropertySpecConstHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPropertySpecConstHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfPropertySpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public SdfPropertySpecConstHandleVector(IEnumerable<SdfPropertySpecConstHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfPropertySpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfPropertySpecConstHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfPropertySpecConstHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfPropertySpecConstHandle[] array, int arrayIndex, int count)
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

		public SdfPropertySpecConstHandle[] ToArray()
		{
			SdfPropertySpecConstHandle[] array = new SdfPropertySpecConstHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfPropertySpecConstHandle> IEnumerable<SdfPropertySpecConstHandle>.GetEnumerator()
		{
			return new SdfPropertySpecConstHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfPropertySpecConstHandleVectorEnumerator(this);
		}

		public SdfPropertySpecConstHandleVectorEnumerator GetEnumerator()
		{
			return new SdfPropertySpecConstHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfPropertySpecConstHandle x)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_Add(swigCPtr, SdfPropertySpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfPropertySpecConstHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfPropertySpecConstHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_reserve(swigCPtr, n);
		}

		public SdfPropertySpecConstHandleVector()
			: this(SdfPINVOKE.new_SdfPropertySpecConstHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPropertySpecConstHandleVector(SdfPropertySpecConstHandleVector other)
			: this(SdfPINVOKE.new_SdfPropertySpecConstHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPropertySpecConstHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfPropertySpecConstHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfPropertySpecConstHandle getitemcopy(int index)
		{
			SdfPropertySpecConstHandle result = new SdfPropertySpecConstHandle(SdfPINVOKE.SdfPropertySpecConstHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfPropertySpecConstHandle getitem(int index)
		{
			SdfPropertySpecConstHandle result = new SdfPropertySpecConstHandle(SdfPINVOKE.SdfPropertySpecConstHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfPropertySpecConstHandle val)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_setitem(swigCPtr, index, SdfPropertySpecConstHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfPropertySpecConstHandleVector values)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPropertySpecConstHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfPropertySpecConstHandleVector_GetRange(swigCPtr, index, count);
			SdfPropertySpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfPropertySpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfPropertySpecConstHandle x)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_Insert(swigCPtr, index, SdfPropertySpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfPropertySpecConstHandleVector values)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfPropertySpecConstHandleVector Repeat(SdfPropertySpecConstHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfPropertySpecConstHandleVector_Repeat(SdfPropertySpecConstHandle.getCPtr(value), count);
			SdfPropertySpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfPropertySpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfPropertySpecConstHandleVector values)
		{
			SdfPINVOKE.SdfPropertySpecConstHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
