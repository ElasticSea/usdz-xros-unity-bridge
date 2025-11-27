using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrDiscoveryPluginContextConstRefPtrVector : IDisposable, IEnumerable, IEnumerable<NdrDiscoveryPluginContext>
	{
		public sealed class NdrDiscoveryPluginContextConstRefPtrVectorEnumerator : IEnumerator, IEnumerator<NdrDiscoveryPluginContext>, IDisposable
		{
			private NdrDiscoveryPluginContextConstRefPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public NdrDiscoveryPluginContext Current
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
					return (NdrDiscoveryPluginContext)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public NdrDiscoveryPluginContextConstRefPtrVectorEnumerator(NdrDiscoveryPluginContextConstRefPtrVector collection)
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

		public NdrDiscoveryPluginContext this[int index]
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

		public NdrDiscoveryPluginContextConstRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrDiscoveryPluginContextConstRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrDiscoveryPluginContextConstRefPtrVector obj)
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

		~NdrDiscoveryPluginContextConstRefPtrVector()
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
						NdrPINVOKE.delete_NdrDiscoveryPluginContextConstRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public NdrDiscoveryPluginContextConstRefPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (NdrDiscoveryPluginContext item in c)
			{
				Add(item);
			}
		}

		public NdrDiscoveryPluginContextConstRefPtrVector(IEnumerable<NdrDiscoveryPluginContext> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (NdrDiscoveryPluginContext item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(NdrDiscoveryPluginContext[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(NdrDiscoveryPluginContext[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, NdrDiscoveryPluginContext[] array, int arrayIndex, int count)
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

		public NdrDiscoveryPluginContext[] ToArray()
		{
			NdrDiscoveryPluginContext[] array = new NdrDiscoveryPluginContext[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<NdrDiscoveryPluginContext> IEnumerable<NdrDiscoveryPluginContext>.GetEnumerator()
		{
			return new NdrDiscoveryPluginContextConstRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new NdrDiscoveryPluginContextConstRefPtrVectorEnumerator(this);
		}

		public NdrDiscoveryPluginContextConstRefPtrVectorEnumerator GetEnumerator()
		{
			return new NdrDiscoveryPluginContextConstRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_Clear(swigCPtr);
		}

		public void Add(NdrDiscoveryPluginContext x)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_Add(swigCPtr, NdrDiscoveryPluginContext.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_reserve(swigCPtr, n);
		}

		public NdrDiscoveryPluginContextConstRefPtrVector()
			: this(NdrPINVOKE.new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public NdrDiscoveryPluginContextConstRefPtrVector(NdrDiscoveryPluginContextConstRefPtrVector other)
			: this(NdrPINVOKE.new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrDiscoveryPluginContextConstRefPtrVector(int capacity)
			: this(NdrPINVOKE.new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private NdrDiscoveryPluginContext getitemcopy(int index)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_getitemcopy(swigCPtr, index);
			NdrDiscoveryPluginContext result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginContext(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private NdrDiscoveryPluginContext getitem(int index)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_getitem(swigCPtr, index);
			NdrDiscoveryPluginContext result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginContext(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, NdrDiscoveryPluginContext val)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_setitem(swigCPtr, index, NdrDiscoveryPluginContext.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(NdrDiscoveryPluginContextConstRefPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrDiscoveryPluginContextConstRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_GetRange(swigCPtr, index, count);
			NdrDiscoveryPluginContextConstRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginContextConstRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, NdrDiscoveryPluginContext x)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_Insert(swigCPtr, index, NdrDiscoveryPluginContext.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, NdrDiscoveryPluginContextConstRefPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static NdrDiscoveryPluginContextConstRefPtrVector Repeat(NdrDiscoveryPluginContext value, int count)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_Repeat(NdrDiscoveryPluginContext.getCPtr(value), count);
			NdrDiscoveryPluginContextConstRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginContextConstRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, NdrDiscoveryPluginContextConstRefPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextConstRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
