using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpLayerStackRefPtrVector : IDisposable, IEnumerable, IEnumerable<PcpLayerStack>
	{
		public sealed class PcpLayerStackRefPtrVectorEnumerator : IEnumerator, IEnumerator<PcpLayerStack>, IDisposable
		{
			private PcpLayerStackRefPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public PcpLayerStack Current
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
					return (PcpLayerStack)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public PcpLayerStackRefPtrVectorEnumerator(PcpLayerStackRefPtrVector collection)
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

		public PcpLayerStack this[int index]
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

		public PcpLayerStackRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpLayerStackRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpLayerStackRefPtrVector obj)
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

		~PcpLayerStackRefPtrVector()
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
						PcpPINVOKE.delete_PcpLayerStackRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpLayerStackRefPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (PcpLayerStack item in c)
			{
				Add(item);
			}
		}

		public PcpLayerStackRefPtrVector(IEnumerable<PcpLayerStack> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (PcpLayerStack item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(PcpLayerStack[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(PcpLayerStack[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, PcpLayerStack[] array, int arrayIndex, int count)
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

		public PcpLayerStack[] ToArray()
		{
			PcpLayerStack[] array = new PcpLayerStack[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<PcpLayerStack> IEnumerable<PcpLayerStack>.GetEnumerator()
		{
			return new PcpLayerStackRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new PcpLayerStackRefPtrVectorEnumerator(this);
		}

		public PcpLayerStackRefPtrVectorEnumerator GetEnumerator()
		{
			return new PcpLayerStackRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_Clear(swigCPtr);
		}

		public void Add(PcpLayerStack x)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_Add(swigCPtr, PcpLayerStack.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return PcpPINVOKE.PcpLayerStackRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return PcpPINVOKE.PcpLayerStackRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_reserve(swigCPtr, n);
		}

		public PcpLayerStackRefPtrVector()
			: this(PcpPINVOKE.new_PcpLayerStackRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PcpLayerStackRefPtrVector(PcpLayerStackRefPtrVector other)
			: this(PcpPINVOKE.new_PcpLayerStackRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackRefPtrVector(int capacity)
			: this(PcpPINVOKE.new_PcpLayerStackRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private PcpLayerStack getitemcopy(int index)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStackRefPtrVector_getitemcopy(swigCPtr, index);
			PcpLayerStack result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStack(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private PcpLayerStack getitem(int index)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStackRefPtrVector_getitem(swigCPtr, index);
			PcpLayerStack result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStack(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, PcpLayerStack val)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_setitem(swigCPtr, index, PcpLayerStack.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(PcpLayerStackRefPtrVector values)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStackRefPtrVector_GetRange(swigCPtr, index, count);
			PcpLayerStackRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStackRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, PcpLayerStack x)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_Insert(swigCPtr, index, PcpLayerStack.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, PcpLayerStackRefPtrVector values)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static PcpLayerStackRefPtrVector Repeat(PcpLayerStack value, int count)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStackRefPtrVector_Repeat(PcpLayerStack.getCPtr(value), count);
			PcpLayerStackRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStackRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, PcpLayerStackRefPtrVector values)
		{
			PcpPINVOKE.PcpLayerStackRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
