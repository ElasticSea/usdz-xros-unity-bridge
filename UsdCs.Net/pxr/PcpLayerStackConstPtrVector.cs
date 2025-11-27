using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpLayerStackConstPtrVector : IDisposable, IEnumerable, IEnumerable<PcpLayerStack>
	{
		public sealed class PcpLayerStackConstPtrVectorEnumerator : IEnumerator, IEnumerator<PcpLayerStack>, IDisposable
		{
			private PcpLayerStackConstPtrVector collectionRef;

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

			public PcpLayerStackConstPtrVectorEnumerator(PcpLayerStackConstPtrVector collection)
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

		public PcpLayerStackConstPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpLayerStackConstPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpLayerStackConstPtrVector obj)
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

		~PcpLayerStackConstPtrVector()
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
						PcpPINVOKE.delete_PcpLayerStackConstPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpLayerStackConstPtrVector(IEnumerable c)
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

		public PcpLayerStackConstPtrVector(IEnumerable<PcpLayerStack> c)
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
			return new PcpLayerStackConstPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new PcpLayerStackConstPtrVectorEnumerator(this);
		}

		public PcpLayerStackConstPtrVectorEnumerator GetEnumerator()
		{
			return new PcpLayerStackConstPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_Clear(swigCPtr);
		}

		public void Add(PcpLayerStack x)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_Add(swigCPtr, PcpLayerStack.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return PcpPINVOKE.PcpLayerStackConstPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return PcpPINVOKE.PcpLayerStackConstPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_reserve(swigCPtr, n);
		}

		public PcpLayerStackConstPtrVector()
			: this(PcpPINVOKE.new_PcpLayerStackConstPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PcpLayerStackConstPtrVector(PcpLayerStackConstPtrVector other)
			: this(PcpPINVOKE.new_PcpLayerStackConstPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackConstPtrVector(int capacity)
			: this(PcpPINVOKE.new_PcpLayerStackConstPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private PcpLayerStack getitemcopy(int index)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStackConstPtrVector_getitemcopy(swigCPtr, index);
			PcpLayerStack result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStack(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private PcpLayerStack getitem(int index)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStackConstPtrVector_getitem(swigCPtr, index);
			PcpLayerStack result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStack(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, PcpLayerStack val)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_setitem(swigCPtr, index, PcpLayerStack.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(PcpLayerStackConstPtrVector values)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackConstPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStackConstPtrVector_GetRange(swigCPtr, index, count);
			PcpLayerStackConstPtrVector result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStackConstPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, PcpLayerStack x)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_Insert(swigCPtr, index, PcpLayerStack.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, PcpLayerStackConstPtrVector values)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static PcpLayerStackConstPtrVector Repeat(PcpLayerStack value, int count)
		{
			IntPtr intPtr = PcpPINVOKE.PcpLayerStackConstPtrVector_Repeat(PcpLayerStack.getCPtr(value), count);
			PcpLayerStackConstPtrVector result = ((intPtr == IntPtr.Zero) ? null : new PcpLayerStackConstPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, PcpLayerStackConstPtrVector values)
		{
			PcpPINVOKE.PcpLayerStackConstPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
