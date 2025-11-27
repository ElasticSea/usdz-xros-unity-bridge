using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerRefPtrVector : IDisposable, IEnumerable, IEnumerable<SdfLayer>
	{
		public sealed class SdfLayerRefPtrVectorEnumerator : IEnumerator, IEnumerator<SdfLayer>, IDisposable
		{
			private SdfLayerRefPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfLayer Current
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
					return (SdfLayer)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfLayerRefPtrVectorEnumerator(SdfLayerRefPtrVector collection)
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

		public SdfLayer this[int index]
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

		public SdfLayerRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerRefPtrVector obj)
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

		~SdfLayerRefPtrVector()
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
						SdfPINVOKE.delete_SdfLayerRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfLayerRefPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfLayer item in c)
			{
				Add(item);
			}
		}

		public SdfLayerRefPtrVector(IEnumerable<SdfLayer> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfLayer item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfLayer[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfLayer[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfLayer[] array, int arrayIndex, int count)
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

		public SdfLayer[] ToArray()
		{
			SdfLayer[] array = new SdfLayer[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfLayer> IEnumerable<SdfLayer>.GetEnumerator()
		{
			return new SdfLayerRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfLayerRefPtrVectorEnumerator(this);
		}

		public SdfLayerRefPtrVectorEnumerator GetEnumerator()
		{
			return new SdfLayerRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfLayerRefPtrVector_Clear(swigCPtr);
		}

		public void Add(SdfLayer x)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_Add(swigCPtr, SdfLayer.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfLayerRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfLayerRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_reserve(swigCPtr, n);
		}

		public SdfLayerRefPtrVector()
			: this(SdfPINVOKE.new_SdfLayerRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfLayerRefPtrVector(SdfLayerRefPtrVector other)
			: this(SdfPINVOKE.new_SdfLayerRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerRefPtrVector(int capacity)
			: this(SdfPINVOKE.new_SdfLayerRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfLayer getitemcopy(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerRefPtrVector_getitemcopy(swigCPtr, index);
			SdfLayer result = ((intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfLayer getitem(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerRefPtrVector_getitem(swigCPtr, index);
			SdfLayer result = ((intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfLayer val)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_setitem(swigCPtr, index, SdfLayer.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfLayerRefPtrVector values)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerRefPtrVector_GetRange(swigCPtr, index, count);
			SdfLayerRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfLayer x)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_Insert(swigCPtr, index, SdfLayer.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfLayerRefPtrVector values)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfLayerRefPtrVector Repeat(SdfLayer value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerRefPtrVector_Repeat(SdfLayer.getCPtr(value), count);
			SdfLayerRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfLayerRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfLayerRefPtrVector values)
		{
			SdfPINVOKE.SdfLayerRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
