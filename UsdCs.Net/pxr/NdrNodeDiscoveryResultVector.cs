using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrNodeDiscoveryResultVector : IDisposable, IEnumerable, IEnumerable<NdrNodeDiscoveryResult>
	{
		public sealed class NdrNodeDiscoveryResultVectorEnumerator : IEnumerator, IEnumerator<NdrNodeDiscoveryResult>, IDisposable
		{
			private NdrNodeDiscoveryResultVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public NdrNodeDiscoveryResult Current
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
					return (NdrNodeDiscoveryResult)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public NdrNodeDiscoveryResultVectorEnumerator(NdrNodeDiscoveryResultVector collection)
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

		public NdrNodeDiscoveryResult this[int index]
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

		public NdrNodeDiscoveryResultVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrNodeDiscoveryResultVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrNodeDiscoveryResultVector obj)
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

		~NdrNodeDiscoveryResultVector()
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
						NdrPINVOKE.delete_NdrNodeDiscoveryResultVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public NdrNodeDiscoveryResultVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (NdrNodeDiscoveryResult item in c)
			{
				Add(item);
			}
		}

		public NdrNodeDiscoveryResultVector(IEnumerable<NdrNodeDiscoveryResult> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (NdrNodeDiscoveryResult item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(NdrNodeDiscoveryResult[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(NdrNodeDiscoveryResult[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, NdrNodeDiscoveryResult[] array, int arrayIndex, int count)
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

		public NdrNodeDiscoveryResult[] ToArray()
		{
			NdrNodeDiscoveryResult[] array = new NdrNodeDiscoveryResult[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<NdrNodeDiscoveryResult> IEnumerable<NdrNodeDiscoveryResult>.GetEnumerator()
		{
			return new NdrNodeDiscoveryResultVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new NdrNodeDiscoveryResultVectorEnumerator(this);
		}

		public NdrNodeDiscoveryResultVectorEnumerator GetEnumerator()
		{
			return new NdrNodeDiscoveryResultVectorEnumerator(this);
		}

		public void Clear()
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_Clear(swigCPtr);
		}

		public void Add(NdrNodeDiscoveryResult x)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_Add(swigCPtr, NdrNodeDiscoveryResult.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return NdrPINVOKE.NdrNodeDiscoveryResultVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return NdrPINVOKE.NdrNodeDiscoveryResultVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_reserve(swigCPtr, n);
		}

		public NdrNodeDiscoveryResultVector()
			: this(NdrPINVOKE.new_NdrNodeDiscoveryResultVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public NdrNodeDiscoveryResultVector(NdrNodeDiscoveryResultVector other)
			: this(NdrPINVOKE.new_NdrNodeDiscoveryResultVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrNodeDiscoveryResultVector(int capacity)
			: this(NdrPINVOKE.new_NdrNodeDiscoveryResultVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private NdrNodeDiscoveryResult getitemcopy(int index)
		{
			NdrNodeDiscoveryResult result = new NdrNodeDiscoveryResult(NdrPINVOKE.NdrNodeDiscoveryResultVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private NdrNodeDiscoveryResult getitem(int index)
		{
			NdrNodeDiscoveryResult result = new NdrNodeDiscoveryResult(NdrPINVOKE.NdrNodeDiscoveryResultVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, NdrNodeDiscoveryResult val)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_setitem(swigCPtr, index, NdrNodeDiscoveryResult.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(NdrNodeDiscoveryResultVector values)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrNodeDiscoveryResultVector GetRange(int index, int count)
		{
			IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResultVector_GetRange(swigCPtr, index, count);
			NdrNodeDiscoveryResultVector result = ((intPtr == IntPtr.Zero) ? null : new NdrNodeDiscoveryResultVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, NdrNodeDiscoveryResult x)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_Insert(swigCPtr, index, NdrNodeDiscoveryResult.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, NdrNodeDiscoveryResultVector values)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static NdrNodeDiscoveryResultVector Repeat(NdrNodeDiscoveryResult value, int count)
		{
			IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResultVector_Repeat(NdrNodeDiscoveryResult.getCPtr(value), count);
			NdrNodeDiscoveryResultVector result = ((intPtr == IntPtr.Zero) ? null : new NdrNodeDiscoveryResultVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, NdrNodeDiscoveryResultVector values)
		{
			NdrPINVOKE.NdrNodeDiscoveryResultVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
