using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfVariantSetSpecHandleVector : IDisposable, IEnumerable, IEnumerable<SdfVariantSetSpecHandle>
	{
		public sealed class SdfVariantSetSpecHandleVectorEnumerator : IEnumerator, IEnumerator<SdfVariantSetSpecHandle>, IDisposable
		{
			private SdfVariantSetSpecHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfVariantSetSpecHandle Current
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
					return (SdfVariantSetSpecHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfVariantSetSpecHandleVectorEnumerator(SdfVariantSetSpecHandleVector collection)
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

		public SdfVariantSetSpecHandle this[int index]
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

		public SdfVariantSetSpecHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfVariantSetSpecHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfVariantSetSpecHandleVector obj)
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

		~SdfVariantSetSpecHandleVector()
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
						SdfPINVOKE.delete_SdfVariantSetSpecHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfVariantSetSpecHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfVariantSetSpecHandle item in c)
			{
				Add(item);
			}
		}

		public SdfVariantSetSpecHandleVector(IEnumerable<SdfVariantSetSpecHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfVariantSetSpecHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfVariantSetSpecHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfVariantSetSpecHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfVariantSetSpecHandle[] array, int arrayIndex, int count)
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

		public SdfVariantSetSpecHandle[] ToArray()
		{
			SdfVariantSetSpecHandle[] array = new SdfVariantSetSpecHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfVariantSetSpecHandle> IEnumerable<SdfVariantSetSpecHandle>.GetEnumerator()
		{
			return new SdfVariantSetSpecHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfVariantSetSpecHandleVectorEnumerator(this);
		}

		public SdfVariantSetSpecHandleVectorEnumerator GetEnumerator()
		{
			return new SdfVariantSetSpecHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfVariantSetSpecHandle x)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_Add(swigCPtr, SdfVariantSetSpecHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfVariantSetSpecHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfVariantSetSpecHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_reserve(swigCPtr, n);
		}

		public SdfVariantSetSpecHandleVector()
			: this(SdfPINVOKE.new_SdfVariantSetSpecHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfVariantSetSpecHandleVector(SdfVariantSetSpecHandleVector other)
			: this(SdfPINVOKE.new_SdfVariantSetSpecHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSetSpecHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfVariantSetSpecHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfVariantSetSpecHandle getitemcopy(int index)
		{
			SdfVariantSetSpecHandle result = new SdfVariantSetSpecHandle(SdfPINVOKE.SdfVariantSetSpecHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfVariantSetSpecHandle getitem(int index)
		{
			SdfVariantSetSpecHandle result = new SdfVariantSetSpecHandle(SdfPINVOKE.SdfVariantSetSpecHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfVariantSetSpecHandle val)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_setitem(swigCPtr, index, SdfVariantSetSpecHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfVariantSetSpecHandleVector values)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSetSpecHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSetSpecHandleVector_GetRange(swigCPtr, index, count);
			SdfVariantSetSpecHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfVariantSetSpecHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfVariantSetSpecHandle x)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_Insert(swigCPtr, index, SdfVariantSetSpecHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfVariantSetSpecHandleVector values)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfVariantSetSpecHandleVector Repeat(SdfVariantSetSpecHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSetSpecHandleVector_Repeat(SdfVariantSetSpecHandle.getCPtr(value), count);
			SdfVariantSetSpecHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfVariantSetSpecHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfVariantSetSpecHandleVector values)
		{
			SdfPINVOKE.SdfVariantSetSpecHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
