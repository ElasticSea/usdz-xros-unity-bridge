using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class _NdrFilesystemDiscoveryPluginPtrVector : IDisposable, IEnumerable, IEnumerable<SWIGTYPE_p__NdrFilesystemDiscoveryPlugin>
	{
		public sealed class _NdrFilesystemDiscoveryPluginPtrVectorEnumerator : IEnumerator, IEnumerator<SWIGTYPE_p__NdrFilesystemDiscoveryPlugin>, IDisposable
		{
			private _NdrFilesystemDiscoveryPluginPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SWIGTYPE_p__NdrFilesystemDiscoveryPlugin Current
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
					return (SWIGTYPE_p__NdrFilesystemDiscoveryPlugin)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public _NdrFilesystemDiscoveryPluginPtrVectorEnumerator(_NdrFilesystemDiscoveryPluginPtrVector collection)
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

		public SWIGTYPE_p__NdrFilesystemDiscoveryPlugin this[int index]
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

		public _NdrFilesystemDiscoveryPluginPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(_NdrFilesystemDiscoveryPluginPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(_NdrFilesystemDiscoveryPluginPtrVector obj)
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

		~_NdrFilesystemDiscoveryPluginPtrVector()
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
						NdrPINVOKE.delete__NdrFilesystemDiscoveryPluginPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public _NdrFilesystemDiscoveryPluginPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SWIGTYPE_p__NdrFilesystemDiscoveryPlugin item in c)
			{
				Add(item);
			}
		}

		public _NdrFilesystemDiscoveryPluginPtrVector(IEnumerable<SWIGTYPE_p__NdrFilesystemDiscoveryPlugin> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SWIGTYPE_p__NdrFilesystemDiscoveryPlugin item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SWIGTYPE_p__NdrFilesystemDiscoveryPlugin[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SWIGTYPE_p__NdrFilesystemDiscoveryPlugin[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SWIGTYPE_p__NdrFilesystemDiscoveryPlugin[] array, int arrayIndex, int count)
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

		public SWIGTYPE_p__NdrFilesystemDiscoveryPlugin[] ToArray()
		{
			SWIGTYPE_p__NdrFilesystemDiscoveryPlugin[] array = new SWIGTYPE_p__NdrFilesystemDiscoveryPlugin[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SWIGTYPE_p__NdrFilesystemDiscoveryPlugin> IEnumerable<SWIGTYPE_p__NdrFilesystemDiscoveryPlugin>.GetEnumerator()
		{
			return new _NdrFilesystemDiscoveryPluginPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new _NdrFilesystemDiscoveryPluginPtrVectorEnumerator(this);
		}

		public _NdrFilesystemDiscoveryPluginPtrVectorEnumerator GetEnumerator()
		{
			return new _NdrFilesystemDiscoveryPluginPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_Clear(swigCPtr);
		}

		public void Add(SWIGTYPE_p__NdrFilesystemDiscoveryPlugin x)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_Add(swigCPtr, SWIGTYPE_p__NdrFilesystemDiscoveryPlugin.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_reserve(swigCPtr, n);
		}

		public _NdrFilesystemDiscoveryPluginPtrVector()
			: this(NdrPINVOKE.new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public _NdrFilesystemDiscoveryPluginPtrVector(_NdrFilesystemDiscoveryPluginPtrVector other)
			: this(NdrPINVOKE.new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public _NdrFilesystemDiscoveryPluginPtrVector(int capacity)
			: this(NdrPINVOKE.new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SWIGTYPE_p__NdrFilesystemDiscoveryPlugin getitemcopy(int index)
		{
			IntPtr intPtr = NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_getitemcopy(swigCPtr, index);
			SWIGTYPE_p__NdrFilesystemDiscoveryPlugin result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p__NdrFilesystemDiscoveryPlugin(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SWIGTYPE_p__NdrFilesystemDiscoveryPlugin getitem(int index)
		{
			IntPtr intPtr = NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_getitem(swigCPtr, index);
			SWIGTYPE_p__NdrFilesystemDiscoveryPlugin result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p__NdrFilesystemDiscoveryPlugin(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SWIGTYPE_p__NdrFilesystemDiscoveryPlugin val)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_setitem(swigCPtr, index, SWIGTYPE_p__NdrFilesystemDiscoveryPlugin.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(_NdrFilesystemDiscoveryPluginPtrVector values)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public _NdrFilesystemDiscoveryPluginPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_GetRange(swigCPtr, index, count);
			_NdrFilesystemDiscoveryPluginPtrVector result = ((intPtr == IntPtr.Zero) ? null : new _NdrFilesystemDiscoveryPluginPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SWIGTYPE_p__NdrFilesystemDiscoveryPlugin x)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_Insert(swigCPtr, index, SWIGTYPE_p__NdrFilesystemDiscoveryPlugin.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, _NdrFilesystemDiscoveryPluginPtrVector values)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static _NdrFilesystemDiscoveryPluginPtrVector Repeat(SWIGTYPE_p__NdrFilesystemDiscoveryPlugin value, int count)
		{
			IntPtr intPtr = NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_Repeat(SWIGTYPE_p__NdrFilesystemDiscoveryPlugin.getCPtr(value), count);
			_NdrFilesystemDiscoveryPluginPtrVector result = ((intPtr == IntPtr.Zero) ? null : new _NdrFilesystemDiscoveryPluginPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, _NdrFilesystemDiscoveryPluginPtrVector values)
		{
			NdrPINVOKE._NdrFilesystemDiscoveryPluginPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
