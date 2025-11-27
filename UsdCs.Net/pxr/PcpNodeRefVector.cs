using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpNodeRefVector : IDisposable, IEnumerable, IEnumerable<PcpNodeRef>
	{
		public sealed class PcpNodeRefVectorEnumerator : IEnumerator, IEnumerator<PcpNodeRef>, IDisposable
		{
			private PcpNodeRefVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public PcpNodeRef Current
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
					return (PcpNodeRef)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public PcpNodeRefVectorEnumerator(PcpNodeRefVector collection)
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

		public PcpNodeRef this[int index]
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

		public PcpNodeRefVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpNodeRefVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpNodeRefVector obj)
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

		~PcpNodeRefVector()
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
						PcpPINVOKE.delete_PcpNodeRefVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpNodeRefVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (PcpNodeRef item in c)
			{
				Add(item);
			}
		}

		public PcpNodeRefVector(IEnumerable<PcpNodeRef> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (PcpNodeRef item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(PcpNodeRef[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(PcpNodeRef[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, PcpNodeRef[] array, int arrayIndex, int count)
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

		public PcpNodeRef[] ToArray()
		{
			PcpNodeRef[] array = new PcpNodeRef[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<PcpNodeRef> IEnumerable<PcpNodeRef>.GetEnumerator()
		{
			return new PcpNodeRefVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new PcpNodeRefVectorEnumerator(this);
		}

		public PcpNodeRefVectorEnumerator GetEnumerator()
		{
			return new PcpNodeRefVectorEnumerator(this);
		}

		public void Clear()
		{
			PcpPINVOKE.PcpNodeRefVector_Clear(swigCPtr);
		}

		public void Add(PcpNodeRef x)
		{
			PcpPINVOKE.PcpNodeRefVector_Add(swigCPtr, PcpNodeRef.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return PcpPINVOKE.PcpNodeRefVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return PcpPINVOKE.PcpNodeRefVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			PcpPINVOKE.PcpNodeRefVector_reserve(swigCPtr, n);
		}

		public PcpNodeRefVector()
			: this(PcpPINVOKE.new_PcpNodeRefVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PcpNodeRefVector(PcpNodeRefVector other)
			: this(PcpPINVOKE.new_PcpNodeRefVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpNodeRefVector(int capacity)
			: this(PcpPINVOKE.new_PcpNodeRefVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private PcpNodeRef getitemcopy(int index)
		{
			PcpNodeRef result = new PcpNodeRef(PcpPINVOKE.PcpNodeRefVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private PcpNodeRef getitem(int index)
		{
			PcpNodeRef result = new PcpNodeRef(PcpPINVOKE.PcpNodeRefVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, PcpNodeRef val)
		{
			PcpPINVOKE.PcpNodeRefVector_setitem(swigCPtr, index, PcpNodeRef.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(PcpNodeRefVector values)
		{
			PcpPINVOKE.PcpNodeRefVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpNodeRefVector GetRange(int index, int count)
		{
			IntPtr intPtr = PcpPINVOKE.PcpNodeRefVector_GetRange(swigCPtr, index, count);
			PcpNodeRefVector result = ((intPtr == IntPtr.Zero) ? null : new PcpNodeRefVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, PcpNodeRef x)
		{
			PcpPINVOKE.PcpNodeRefVector_Insert(swigCPtr, index, PcpNodeRef.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, PcpNodeRefVector values)
		{
			PcpPINVOKE.PcpNodeRefVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			PcpPINVOKE.PcpNodeRefVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			PcpPINVOKE.PcpNodeRefVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static PcpNodeRefVector Repeat(PcpNodeRef value, int count)
		{
			IntPtr intPtr = PcpPINVOKE.PcpNodeRefVector_Repeat(PcpNodeRef.getCPtr(value), count);
			PcpNodeRefVector result = ((intPtr == IntPtr.Zero) ? null : new PcpNodeRefVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			PcpPINVOKE.PcpNodeRefVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			PcpPINVOKE.PcpNodeRefVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, PcpNodeRefVector values)
		{
			PcpPINVOKE.PcpNodeRefVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
