using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerOffsetVector : IDisposable, IEnumerable, IEnumerable<SdfLayerOffset>
	{
		public sealed class SdfLayerOffsetVectorEnumerator : IEnumerator, IEnumerator<SdfLayerOffset>, IDisposable
		{
			private SdfLayerOffsetVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfLayerOffset Current
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
					return (SdfLayerOffset)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfLayerOffsetVectorEnumerator(SdfLayerOffsetVector collection)
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

		public SdfLayerOffset this[int index]
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

		public SdfLayerOffsetVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerOffsetVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerOffsetVector obj)
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

		~SdfLayerOffsetVector()
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
						SdfPINVOKE.delete_SdfLayerOffsetVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfLayerOffsetVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfLayerOffset item in c)
			{
				Add(item);
			}
		}

		public SdfLayerOffsetVector(IEnumerable<SdfLayerOffset> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfLayerOffset item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfLayerOffset[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfLayerOffset[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfLayerOffset[] array, int arrayIndex, int count)
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

		public SdfLayerOffset[] ToArray()
		{
			SdfLayerOffset[] array = new SdfLayerOffset[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfLayerOffset> IEnumerable<SdfLayerOffset>.GetEnumerator()
		{
			return new SdfLayerOffsetVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfLayerOffsetVectorEnumerator(this);
		}

		public SdfLayerOffsetVectorEnumerator GetEnumerator()
		{
			return new SdfLayerOffsetVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfLayerOffsetVector_Clear(swigCPtr);
		}

		public void Add(SdfLayerOffset x)
		{
			SdfPINVOKE.SdfLayerOffsetVector_Add(swigCPtr, SdfLayerOffset.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfLayerOffsetVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfLayerOffsetVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfLayerOffsetVector_reserve(swigCPtr, n);
		}

		public SdfLayerOffsetVector()
			: this(SdfPINVOKE.new_SdfLayerOffsetVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfLayerOffsetVector(SdfLayerOffsetVector other)
			: this(SdfPINVOKE.new_SdfLayerOffsetVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerOffsetVector(int capacity)
			: this(SdfPINVOKE.new_SdfLayerOffsetVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfLayerOffset getitemcopy(int index)
		{
			SdfLayerOffset result = new SdfLayerOffset(SdfPINVOKE.SdfLayerOffsetVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfLayerOffset getitem(int index)
		{
			SdfLayerOffset result = new SdfLayerOffset(SdfPINVOKE.SdfLayerOffsetVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfLayerOffset val)
		{
			SdfPINVOKE.SdfLayerOffsetVector_setitem(swigCPtr, index, SdfLayerOffset.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfLayerOffsetVector values)
		{
			SdfPINVOKE.SdfLayerOffsetVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerOffsetVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerOffsetVector_GetRange(swigCPtr, index, count);
			SdfLayerOffsetVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerOffsetVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfLayerOffset x)
		{
			SdfPINVOKE.SdfLayerOffsetVector_Insert(swigCPtr, index, SdfLayerOffset.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfLayerOffsetVector values)
		{
			SdfPINVOKE.SdfLayerOffsetVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfLayerOffsetVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfLayerOffsetVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfLayerOffsetVector Repeat(SdfLayerOffset value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerOffsetVector_Repeat(SdfLayerOffset.getCPtr(value), count);
			SdfLayerOffsetVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerOffsetVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfLayerOffsetVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfLayerOffsetVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfLayerOffsetVector values)
		{
			SdfPINVOKE.SdfLayerOffsetVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
