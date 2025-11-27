using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfRelationshipSpecConstHandleVector : IDisposable, IEnumerable, IEnumerable<SdfRelationshipSpecConstHandle>
	{
		public sealed class SdfRelationshipSpecConstHandleVectorEnumerator : IEnumerator, IEnumerator<SdfRelationshipSpecConstHandle>, IDisposable
		{
			private SdfRelationshipSpecConstHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfRelationshipSpecConstHandle Current
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
					return (SdfRelationshipSpecConstHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfRelationshipSpecConstHandleVectorEnumerator(SdfRelationshipSpecConstHandleVector collection)
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

		public SdfRelationshipSpecConstHandle this[int index]
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

		public SdfRelationshipSpecConstHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfRelationshipSpecConstHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfRelationshipSpecConstHandleVector obj)
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

		~SdfRelationshipSpecConstHandleVector()
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
						SdfPINVOKE.delete_SdfRelationshipSpecConstHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfRelationshipSpecConstHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfRelationshipSpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public SdfRelationshipSpecConstHandleVector(IEnumerable<SdfRelationshipSpecConstHandle> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfRelationshipSpecConstHandle item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfRelationshipSpecConstHandle[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfRelationshipSpecConstHandle[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfRelationshipSpecConstHandle[] array, int arrayIndex, int count)
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

		public SdfRelationshipSpecConstHandle[] ToArray()
		{
			SdfRelationshipSpecConstHandle[] array = new SdfRelationshipSpecConstHandle[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfRelationshipSpecConstHandle> IEnumerable<SdfRelationshipSpecConstHandle>.GetEnumerator()
		{
			return new SdfRelationshipSpecConstHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfRelationshipSpecConstHandleVectorEnumerator(this);
		}

		public SdfRelationshipSpecConstHandleVectorEnumerator GetEnumerator()
		{
			return new SdfRelationshipSpecConstHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfRelationshipSpecConstHandle x)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_Add(swigCPtr, SdfRelationshipSpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfRelationshipSpecConstHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_reserve(swigCPtr, n);
		}

		public SdfRelationshipSpecConstHandleVector()
			: this(SdfPINVOKE.new_SdfRelationshipSpecConstHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfRelationshipSpecConstHandleVector(SdfRelationshipSpecConstHandleVector other)
			: this(SdfPINVOKE.new_SdfRelationshipSpecConstHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfRelationshipSpecConstHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfRelationshipSpecConstHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfRelationshipSpecConstHandle getitemcopy(int index)
		{
			SdfRelationshipSpecConstHandle result = new SdfRelationshipSpecConstHandle(SdfPINVOKE.SdfRelationshipSpecConstHandleVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfRelationshipSpecConstHandle getitem(int index)
		{
			SdfRelationshipSpecConstHandle result = new SdfRelationshipSpecConstHandle(SdfPINVOKE.SdfRelationshipSpecConstHandleVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfRelationshipSpecConstHandle val)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_setitem(swigCPtr, index, SdfRelationshipSpecConstHandle.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfRelationshipSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfRelationshipSpecConstHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfRelationshipSpecConstHandleVector_GetRange(swigCPtr, index, count);
			SdfRelationshipSpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfRelationshipSpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfRelationshipSpecConstHandle x)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_Insert(swigCPtr, index, SdfRelationshipSpecConstHandle.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfRelationshipSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfRelationshipSpecConstHandleVector Repeat(SdfRelationshipSpecConstHandle value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfRelationshipSpecConstHandleVector_Repeat(SdfRelationshipSpecConstHandle.getCPtr(value), count);
			SdfRelationshipSpecConstHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfRelationshipSpecConstHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfRelationshipSpecConstHandleVector values)
		{
			SdfPINVOKE.SdfRelationshipSpecConstHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
