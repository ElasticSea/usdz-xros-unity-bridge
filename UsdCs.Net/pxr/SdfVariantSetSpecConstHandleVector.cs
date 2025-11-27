using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfVariantSetSpecConstHandleVector : IDisposable, IEnumerable, IEnumerable<SdfVariantSetSpecConstHandle>
	{
		public sealed class SdfVariantSetSpecConstHandleVectorEnumerator : IEnumerator, IEnumerator<SdfVariantSetSpecConstHandle>, IDisposable
		{
			private SdfVariantSetSpecConstHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfVariantSetSpecConstHandle Current
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
					return (SdfVariantSetSpecConstHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfVariantSetSpecConstHandleVectorEnumerator(SdfVariantSetSpecConstHandleVector collection)
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

		public SdfVariantSetSpecConstHandle this[int index]
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

		public SdfVariantSetSpecConstHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfVariantSetSpecConstHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfVariantSetSpecConstHandleVector obj)
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

		~SdfVariantSetSpecConstHandleVector()
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
						SdfPINVOKE.delete_SdfVariantSetSpecConstHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfVariantSetSpecConstHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfVariantSetSpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public SdfVariantSetSpecConstHandleVector(IEnumerable<SdfVariantSetSpecConstHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfVariantSetSpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfVariantSetSpecConstHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfVariantSetSpecConstHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfVariantSetSpecConstHandle[] array, int arrayIndex, int count)
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

		public SdfVariantSetSpecConstHandle[] ToArray()
		{
			SdfVariantSetSpecConstHandle[] array = new SdfVariantSetSpecConstHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfVariantSetSpecConstHandle> IEnumerable<SdfVariantSetSpecConstHandle>.GetEnumerator()
		{
			return new SdfVariantSetSpecConstHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfVariantSetSpecConstHandleVectorEnumerator(this);
		}

		public SdfVariantSetSpecConstHandleVectorEnumerator GetEnumerator()
		{
			return new SdfVariantSetSpecConstHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfVariantSetSpecConstHandle x)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_Add(swigCPtr, SdfVariantSetSpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfVariantSetSpecConstHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfVariantSetSpecConstHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_reserve(swigCPtr, n);
		}

		public SdfVariantSetSpecConstHandleVector()
			: this(SdfPINVOKE.new_SdfVariantSetSpecConstHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfVariantSetSpecConstHandleVector(SdfVariantSetSpecConstHandleVector other)
			: this(SdfPINVOKE.new_SdfVariantSetSpecConstHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSetSpecConstHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfVariantSetSpecConstHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfVariantSetSpecConstHandle getitemcopy(int index)
		{
			SdfVariantSetSpecConstHandle result = new SdfVariantSetSpecConstHandle(SdfPINVOKE.SdfVariantSetSpecConstHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfVariantSetSpecConstHandle getitem(int index)
		{
			SdfVariantSetSpecConstHandle result = new SdfVariantSetSpecConstHandle(SdfPINVOKE.SdfVariantSetSpecConstHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfVariantSetSpecConstHandle val)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_setitem(swigCPtr, index, SdfVariantSetSpecConstHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfVariantSetSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSetSpecConstHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSetSpecConstHandleVector_GetRange(swigCPtr, index, count);
			SdfVariantSetSpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfVariantSetSpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfVariantSetSpecConstHandle x)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_Insert(swigCPtr, index, SdfVariantSetSpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfVariantSetSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfVariantSetSpecConstHandleVector Repeat(SdfVariantSetSpecConstHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSetSpecConstHandleVector_Repeat(SdfVariantSetSpecConstHandle.getCPtr(value), count);
			SdfVariantSetSpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfVariantSetSpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfVariantSetSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfVariantSetSpecConstHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
