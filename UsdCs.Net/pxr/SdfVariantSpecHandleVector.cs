using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfVariantSpecHandleVector : IDisposable, IEnumerable, IEnumerable<SdfVariantSpecHandle>
	{
		public sealed class SdfVariantSpecHandleVectorEnumerator : IEnumerator, IEnumerator<SdfVariantSpecHandle>, IDisposable
		{
			private SdfVariantSpecHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfVariantSpecHandle Current
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
					return (SdfVariantSpecHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfVariantSpecHandleVectorEnumerator(SdfVariantSpecHandleVector collection)
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

		public SdfVariantSpecHandle this[int index]
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

		public SdfVariantSpecHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfVariantSpecHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfVariantSpecHandleVector obj)
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

		~SdfVariantSpecHandleVector()
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
						SdfPINVOKE.delete_SdfVariantSpecHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfVariantSpecHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfVariantSpecHandle item in c)
			{
				Add(item);
			}
		}

		public SdfVariantSpecHandleVector(IEnumerable<SdfVariantSpecHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfVariantSpecHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfVariantSpecHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfVariantSpecHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfVariantSpecHandle[] array, int arrayIndex, int count)
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

		public SdfVariantSpecHandle[] ToArray()
		{
			SdfVariantSpecHandle[] array = new SdfVariantSpecHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfVariantSpecHandle> IEnumerable<SdfVariantSpecHandle>.GetEnumerator()
		{
			return new SdfVariantSpecHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfVariantSpecHandleVectorEnumerator(this);
		}

		public SdfVariantSpecHandleVectorEnumerator GetEnumerator()
		{
			return new SdfVariantSpecHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfVariantSpecHandle x)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_Add(swigCPtr, SdfVariantSpecHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfVariantSpecHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfVariantSpecHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_reserve(swigCPtr, n);
		}

		public SdfVariantSpecHandleVector()
			: this(SdfPINVOKE.new_SdfVariantSpecHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfVariantSpecHandleVector(SdfVariantSpecHandleVector other)
			: this(SdfPINVOKE.new_SdfVariantSpecHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSpecHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfVariantSpecHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfVariantSpecHandle getitemcopy(int index)
		{
			SdfVariantSpecHandle result = new SdfVariantSpecHandle(SdfPINVOKE.SdfVariantSpecHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfVariantSpecHandle getitem(int index)
		{
			SdfVariantSpecHandle result = new SdfVariantSpecHandle(SdfPINVOKE.SdfVariantSpecHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfVariantSpecHandle val)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_setitem(swigCPtr, index, SdfVariantSpecHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfVariantSpecHandleVector values)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSpecHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSpecHandleVector_GetRange(swigCPtr, index, count);
			SdfVariantSpecHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfVariantSpecHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfVariantSpecHandle x)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_Insert(swigCPtr, index, SdfVariantSpecHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfVariantSpecHandleVector values)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfVariantSpecHandleVector Repeat(SdfVariantSpecHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSpecHandleVector_Repeat(SdfVariantSpecHandle.getCPtr(value), count);
			SdfVariantSpecHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfVariantSpecHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfVariantSpecHandleVector values)
		{
			SdfPINVOKE.SdfVariantSpecHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
