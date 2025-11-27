using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPrimSpecConstHandleVector : IDisposable, IEnumerable, IEnumerable<SdfPrimSpecConstHandle>
	{
		public sealed class SdfPrimSpecConstHandleVectorEnumerator : IEnumerator, IEnumerator<SdfPrimSpecConstHandle>, IDisposable
		{
			private SdfPrimSpecConstHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfPrimSpecConstHandle Current
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
					return (SdfPrimSpecConstHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfPrimSpecConstHandleVectorEnumerator(SdfPrimSpecConstHandleVector collection)
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

		public SdfPrimSpecConstHandle this[int index]
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

		public SdfPrimSpecConstHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPrimSpecConstHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPrimSpecConstHandleVector obj)
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

		~SdfPrimSpecConstHandleVector()
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
						SdfPINVOKE.delete_SdfPrimSpecConstHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPrimSpecConstHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfPrimSpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public SdfPrimSpecConstHandleVector(IEnumerable<SdfPrimSpecConstHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfPrimSpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfPrimSpecConstHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfPrimSpecConstHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfPrimSpecConstHandle[] array, int arrayIndex, int count)
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

		public SdfPrimSpecConstHandle[] ToArray()
		{
			SdfPrimSpecConstHandle[] array = new SdfPrimSpecConstHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfPrimSpecConstHandle> IEnumerable<SdfPrimSpecConstHandle>.GetEnumerator()
		{
			return new SdfPrimSpecConstHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfPrimSpecConstHandleVectorEnumerator(this);
		}

		public SdfPrimSpecConstHandleVectorEnumerator GetEnumerator()
		{
			return new SdfPrimSpecConstHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfPrimSpecConstHandle x)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_Add(swigCPtr, SdfPrimSpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfPrimSpecConstHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_reserve(swigCPtr, n);
		}

		public SdfPrimSpecConstHandleVector()
			: this(SdfPINVOKE.new_SdfPrimSpecConstHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPrimSpecConstHandleVector(SdfPrimSpecConstHandleVector other)
			: this(SdfPINVOKE.new_SdfPrimSpecConstHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPrimSpecConstHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfPrimSpecConstHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfPrimSpecConstHandle getitemcopy(int index)
		{
			SdfPrimSpecConstHandle result = new SdfPrimSpecConstHandle(SdfPINVOKE.SdfPrimSpecConstHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfPrimSpecConstHandle getitem(int index)
		{
			SdfPrimSpecConstHandle result = new SdfPrimSpecConstHandle(SdfPINVOKE.SdfPrimSpecConstHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfPrimSpecConstHandle val)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_setitem(swigCPtr, index, SdfPrimSpecConstHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfPrimSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPrimSpecConstHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfPrimSpecConstHandleVector_GetRange(swigCPtr, index, count);
			SdfPrimSpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfPrimSpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfPrimSpecConstHandle x)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_Insert(swigCPtr, index, SdfPrimSpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfPrimSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfPrimSpecConstHandleVector Repeat(SdfPrimSpecConstHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfPrimSpecConstHandleVector_Repeat(SdfPrimSpecConstHandle.getCPtr(value), count);
			SdfPrimSpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfPrimSpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfPrimSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfPrimSpecConstHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
