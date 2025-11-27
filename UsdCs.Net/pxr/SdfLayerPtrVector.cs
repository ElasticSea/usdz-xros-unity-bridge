using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerPtrVector : IDisposable, IEnumerable, IEnumerable<SdfLayer>
	{
		public sealed class SdfLayerPtrVectorEnumerator : IEnumerator, IEnumerator<SdfLayer>, IDisposable
		{
			private SdfLayerPtrVector collectionRef;

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

			public SdfLayerPtrVectorEnumerator(SdfLayerPtrVector collection)
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

		public SdfLayerPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerPtrVector obj)
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

		~SdfLayerPtrVector()
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
						UsdUtilsPINVOKE.delete_SdfLayerPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfLayerPtrVector(IEnumerable c)
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

		public SdfLayerPtrVector(IEnumerable<SdfLayer> c)
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
			return new SdfLayerPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfLayerPtrVectorEnumerator(this);
		}

		public SdfLayerPtrVectorEnumerator GetEnumerator()
		{
			return new SdfLayerPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_Clear(swigCPtr);
		}

		public void Add(SdfLayer x)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_Add(swigCPtr, SdfLayer.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdUtilsPINVOKE.SdfLayerPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdUtilsPINVOKE.SdfLayerPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_reserve(swigCPtr, n);
		}

		public SdfLayerPtrVector()
			: this(UsdUtilsPINVOKE.new_SdfLayerPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfLayerPtrVector(SdfLayerPtrVector other)
			: this(UsdUtilsPINVOKE.new_SdfLayerPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerPtrVector(int capacity)
			: this(UsdUtilsPINVOKE.new_SdfLayerPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfLayer getitemcopy(int index)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.SdfLayerPtrVector_getitemcopy(swigCPtr, index);
			SdfLayer result = ((intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfLayer getitem(int index)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.SdfLayerPtrVector_getitem(swigCPtr, index);
			SdfLayer result = ((intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfLayer val)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_setitem(swigCPtr, index, SdfLayer.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfLayerPtrVector values)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.SdfLayerPtrVector_GetRange(swigCPtr, index, count);
			SdfLayerPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfLayer x)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_Insert(swigCPtr, index, SdfLayer.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfLayerPtrVector values)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfLayerPtrVector Repeat(SdfLayer value, int count)
		{
			IntPtr intPtr = UsdUtilsPINVOKE.SdfLayerPtrVector_Repeat(SdfLayer.getCPtr(value), count);
			SdfLayerPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfLayerPtrVector values)
		{
			UsdUtilsPINVOKE.SdfLayerPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
