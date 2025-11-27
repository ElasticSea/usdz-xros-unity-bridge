using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfVariantSpecConstHandleVector : IDisposable, IEnumerable, IEnumerable<SdfVariantSpecConstHandle>
	{
		public sealed class SdfVariantSpecConstHandleVectorEnumerator : IEnumerator, IEnumerator<SdfVariantSpecConstHandle>, IDisposable
		{
			private SdfVariantSpecConstHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfVariantSpecConstHandle Current
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
					return (SdfVariantSpecConstHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfVariantSpecConstHandleVectorEnumerator(SdfVariantSpecConstHandleVector collection)
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

		public SdfVariantSpecConstHandle this[int index]
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

		public SdfVariantSpecConstHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfVariantSpecConstHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfVariantSpecConstHandleVector obj)
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

		~SdfVariantSpecConstHandleVector()
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
						SdfPINVOKE.delete_SdfVariantSpecConstHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfVariantSpecConstHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfVariantSpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public SdfVariantSpecConstHandleVector(IEnumerable<SdfVariantSpecConstHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfVariantSpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfVariantSpecConstHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfVariantSpecConstHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfVariantSpecConstHandle[] array, int arrayIndex, int count)
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

		public SdfVariantSpecConstHandle[] ToArray()
		{
			SdfVariantSpecConstHandle[] array = new SdfVariantSpecConstHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfVariantSpecConstHandle> IEnumerable<SdfVariantSpecConstHandle>.GetEnumerator()
		{
			return new SdfVariantSpecConstHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfVariantSpecConstHandleVectorEnumerator(this);
		}

		public SdfVariantSpecConstHandleVectorEnumerator GetEnumerator()
		{
			return new SdfVariantSpecConstHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfVariantSpecConstHandle x)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_Add(swigCPtr, SdfVariantSpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfVariantSpecConstHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfVariantSpecConstHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_reserve(swigCPtr, n);
		}

		public SdfVariantSpecConstHandleVector()
			: this(SdfPINVOKE.new_SdfVariantSpecConstHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfVariantSpecConstHandleVector(SdfVariantSpecConstHandleVector other)
			: this(SdfPINVOKE.new_SdfVariantSpecConstHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSpecConstHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfVariantSpecConstHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfVariantSpecConstHandle getitemcopy(int index)
		{
			SdfVariantSpecConstHandle result = new SdfVariantSpecConstHandle(SdfPINVOKE.SdfVariantSpecConstHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfVariantSpecConstHandle getitem(int index)
		{
			SdfVariantSpecConstHandle result = new SdfVariantSpecConstHandle(SdfPINVOKE.SdfVariantSpecConstHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfVariantSpecConstHandle val)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_setitem(swigCPtr, index, SdfVariantSpecConstHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfVariantSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSpecConstHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSpecConstHandleVector_GetRange(swigCPtr, index, count);
			SdfVariantSpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfVariantSpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfVariantSpecConstHandle x)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_Insert(swigCPtr, index, SdfVariantSpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfVariantSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfVariantSpecConstHandleVector Repeat(SdfVariantSpecConstHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSpecConstHandleVector_Repeat(SdfVariantSpecConstHandle.getCPtr(value), count);
			SdfVariantSpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfVariantSpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfVariantSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfVariantSpecConstHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
