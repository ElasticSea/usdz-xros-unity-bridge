using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrDiscoveryPluginContextRefPtrVector : IDisposable, IEnumerable, IEnumerable<NdrDiscoveryPluginContext>
	{
		public sealed class NdrDiscoveryPluginContextRefPtrVectorEnumerator : IEnumerator, IEnumerator<NdrDiscoveryPluginContext>, IDisposable
		{
			private NdrDiscoveryPluginContextRefPtrVector collectionRef;

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

			public NdrDiscoveryPluginContextRefPtrVectorEnumerator(NdrDiscoveryPluginContextRefPtrVector collection)
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

		public NdrDiscoveryPluginContextRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrDiscoveryPluginContextRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrDiscoveryPluginContextRefPtrVector obj)
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

		~NdrDiscoveryPluginContextRefPtrVector()
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
						NdrPINVOKE.delete_NdrDiscoveryPluginContextRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public NdrDiscoveryPluginContextRefPtrVector(IEnumerable c)
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

		public NdrDiscoveryPluginContextRefPtrVector(IEnumerable<NdrDiscoveryPluginContext> c)
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
			return new NdrDiscoveryPluginContextRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new NdrDiscoveryPluginContextRefPtrVectorEnumerator(this);
		}

		public NdrDiscoveryPluginContextRefPtrVectorEnumerator GetEnumerator()
		{
			return new NdrDiscoveryPluginContextRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_Clear(swigCPtr);
		}

		public void Add(NdrDiscoveryPluginContext x)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_Add(swigCPtr, NdrDiscoveryPluginContext.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_reserve(swigCPtr, n);
		}

		public NdrDiscoveryPluginContextRefPtrVector()
			: this(NdrPINVOKE.new_NdrDiscoveryPluginContextRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public NdrDiscoveryPluginContextRefPtrVector(NdrDiscoveryPluginContextRefPtrVector other)
			: this(NdrPINVOKE.new_NdrDiscoveryPluginContextRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrDiscoveryPluginContextRefPtrVector(int capacity)
			: this(NdrPINVOKE.new_NdrDiscoveryPluginContextRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private NdrDiscoveryPluginContext getitemcopy(int index)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_getitemcopy(swigCPtr, index);
			NdrDiscoveryPluginContext result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginContext(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private NdrDiscoveryPluginContext getitem(int index)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_getitem(swigCPtr, index);
			NdrDiscoveryPluginContext result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginContext(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, NdrDiscoveryPluginContext val)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_setitem(swigCPtr, index, NdrDiscoveryPluginContext.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(NdrDiscoveryPluginContextRefPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrDiscoveryPluginContextRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_GetRange(swigCPtr, index, count);
			NdrDiscoveryPluginContextRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginContextRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, NdrDiscoveryPluginContext x)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_Insert(swigCPtr, index, NdrDiscoveryPluginContext.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, NdrDiscoveryPluginContextRefPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static NdrDiscoveryPluginContextRefPtrVector Repeat(NdrDiscoveryPluginContext value, int count)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_Repeat(NdrDiscoveryPluginContext.getCPtr(value), count);
			NdrDiscoveryPluginContextRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginContextRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, NdrDiscoveryPluginContextRefPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginContextRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
