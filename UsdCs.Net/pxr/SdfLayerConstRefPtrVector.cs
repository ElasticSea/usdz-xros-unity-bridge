using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerConstRefPtrVector : IDisposable, IEnumerable, IEnumerable<SdfLayer>
	{
		public sealed class SdfLayerConstRefPtrVectorEnumerator : IEnumerator, IEnumerator<SdfLayer>, IDisposable
		{
			private SdfLayerConstRefPtrVector collectionRef;

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

			public SdfLayerConstRefPtrVectorEnumerator(SdfLayerConstRefPtrVector collection)
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

		public SdfLayerConstRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerConstRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerConstRefPtrVector obj)
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

		~SdfLayerConstRefPtrVector()
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
						PcpPINVOKE.delete_SdfLayerConstRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfLayerConstRefPtrVector(IEnumerable c)
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

		public SdfLayerConstRefPtrVector(IEnumerable<SdfLayer> c)
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
			return new SdfLayerConstRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfLayerConstRefPtrVectorEnumerator(this);
		}

		public SdfLayerConstRefPtrVectorEnumerator GetEnumerator()
		{
			return new SdfLayerConstRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_Clear(swigCPtr);
		}

		public void Add(SdfLayer x)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_Add(swigCPtr, SdfLayer.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return PcpPINVOKE.SdfLayerConstRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return PcpPINVOKE.SdfLayerConstRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_reserve(swigCPtr, n);
		}

		public SdfLayerConstRefPtrVector()
			: this(PcpPINVOKE.new_SdfLayerConstRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfLayerConstRefPtrVector(SdfLayerConstRefPtrVector other)
			: this(PcpPINVOKE.new_SdfLayerConstRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerConstRefPtrVector(int capacity)
			: this(PcpPINVOKE.new_SdfLayerConstRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfLayer getitemcopy(int index)
		{
			IntPtr intPtr = PcpPINVOKE.SdfLayerConstRefPtrVector_getitemcopy(swigCPtr, index);
			SdfLayer result = ((intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfLayer getitem(int index)
		{
			IntPtr intPtr = PcpPINVOKE.SdfLayerConstRefPtrVector_getitem(swigCPtr, index);
			SdfLayer result = ((intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfLayer val)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_setitem(swigCPtr, index, SdfLayer.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfLayerConstRefPtrVector values)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerConstRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = PcpPINVOKE.SdfLayerConstRefPtrVector_GetRange(swigCPtr, index, count);
			SdfLayerConstRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerConstRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfLayer x)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_Insert(swigCPtr, index, SdfLayer.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfLayerConstRefPtrVector values)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfLayerConstRefPtrVector Repeat(SdfLayer value, int count)
		{
			IntPtr intPtr = PcpPINVOKE.SdfLayerConstRefPtrVector_Repeat(SdfLayer.getCPtr(value), count);
			SdfLayerConstRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerConstRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfLayerConstRefPtrVector values)
		{
			PcpPINVOKE.SdfLayerConstRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
