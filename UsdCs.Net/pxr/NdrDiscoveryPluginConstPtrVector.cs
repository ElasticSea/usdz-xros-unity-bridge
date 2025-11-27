using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrDiscoveryPluginConstPtrVector : IDisposable, IEnumerable, IEnumerable<NdrDiscoveryPlugin>
	{
		public sealed class NdrDiscoveryPluginConstPtrVectorEnumerator : IEnumerator, IEnumerator<NdrDiscoveryPlugin>, IDisposable
		{
			private NdrDiscoveryPluginConstPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public NdrDiscoveryPlugin Current
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
					return (NdrDiscoveryPlugin)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public NdrDiscoveryPluginConstPtrVectorEnumerator(NdrDiscoveryPluginConstPtrVector collection)
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

		public NdrDiscoveryPlugin this[int index]
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

		public NdrDiscoveryPluginConstPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrDiscoveryPluginConstPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrDiscoveryPluginConstPtrVector obj)
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

		~NdrDiscoveryPluginConstPtrVector()
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
						NdrPINVOKE.delete_NdrDiscoveryPluginConstPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public NdrDiscoveryPluginConstPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (NdrDiscoveryPlugin item in c)
			{
				Add(item);
			}
		}

		public NdrDiscoveryPluginConstPtrVector(IEnumerable<NdrDiscoveryPlugin> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (NdrDiscoveryPlugin item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(NdrDiscoveryPlugin[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(NdrDiscoveryPlugin[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, NdrDiscoveryPlugin[] array, int arrayIndex, int count)
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

		public NdrDiscoveryPlugin[] ToArray()
		{
			NdrDiscoveryPlugin[] array = new NdrDiscoveryPlugin[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<NdrDiscoveryPlugin> IEnumerable<NdrDiscoveryPlugin>.GetEnumerator()
		{
			return new NdrDiscoveryPluginConstPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new NdrDiscoveryPluginConstPtrVectorEnumerator(this);
		}

		public NdrDiscoveryPluginConstPtrVectorEnumerator GetEnumerator()
		{
			return new NdrDiscoveryPluginConstPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_Clear(swigCPtr);
		}

		public void Add(NdrDiscoveryPlugin x)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_Add(swigCPtr, NdrDiscoveryPlugin.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_reserve(swigCPtr, n);
		}

		public NdrDiscoveryPluginConstPtrVector()
			: this(NdrPINVOKE.new_NdrDiscoveryPluginConstPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public NdrDiscoveryPluginConstPtrVector(NdrDiscoveryPluginConstPtrVector other)
			: this(NdrPINVOKE.new_NdrDiscoveryPluginConstPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrDiscoveryPluginConstPtrVector(int capacity)
			: this(NdrPINVOKE.new_NdrDiscoveryPluginConstPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private NdrDiscoveryPlugin getitemcopy(int index)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_getitemcopy(swigCPtr, index);
			NdrDiscoveryPlugin result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPlugin(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private NdrDiscoveryPlugin getitem(int index)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_getitem(swigCPtr, index);
			NdrDiscoveryPlugin result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPlugin(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, NdrDiscoveryPlugin val)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_setitem(swigCPtr, index, NdrDiscoveryPlugin.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(NdrDiscoveryPluginConstPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrDiscoveryPluginConstPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_GetRange(swigCPtr, index, count);
			NdrDiscoveryPluginConstPtrVector result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginConstPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, NdrDiscoveryPlugin x)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_Insert(swigCPtr, index, NdrDiscoveryPlugin.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, NdrDiscoveryPluginConstPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static NdrDiscoveryPluginConstPtrVector Repeat(NdrDiscoveryPlugin value, int count)
		{
			IntPtr intPtr = NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_Repeat(NdrDiscoveryPlugin.getCPtr(value), count);
			NdrDiscoveryPluginConstPtrVector result = ((intPtr == IntPtr.Zero) ? null : new NdrDiscoveryPluginConstPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, NdrDiscoveryPluginConstPtrVector values)
		{
			NdrPINVOKE.NdrDiscoveryPluginConstPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
