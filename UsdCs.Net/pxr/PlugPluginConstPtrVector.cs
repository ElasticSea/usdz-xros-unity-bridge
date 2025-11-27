using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PlugPluginConstPtrVector : IDisposable, IEnumerable, IEnumerable<PlugPlugin>
	{
		public sealed class PlugPluginConstPtrVectorEnumerator : IEnumerator, IEnumerator<PlugPlugin>, IDisposable
		{
			private PlugPluginConstPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public PlugPlugin Current
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
					return (PlugPlugin)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public PlugPluginConstPtrVectorEnumerator(PlugPluginConstPtrVector collection)
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

		public PlugPlugin this[int index]
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

		public PlugPluginConstPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PlugPluginConstPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PlugPluginConstPtrVector obj)
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

		~PlugPluginConstPtrVector()
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
						PlugPINVOKE.delete_PlugPluginConstPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PlugPluginConstPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (PlugPlugin item in c)
			{
				Add(item);
			}
		}

		public PlugPluginConstPtrVector(IEnumerable<PlugPlugin> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (PlugPlugin item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(PlugPlugin[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(PlugPlugin[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, PlugPlugin[] array, int arrayIndex, int count)
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

		public PlugPlugin[] ToArray()
		{
			PlugPlugin[] array = new PlugPlugin[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<PlugPlugin> IEnumerable<PlugPlugin>.GetEnumerator()
		{
			return new PlugPluginConstPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new PlugPluginConstPtrVectorEnumerator(this);
		}

		public PlugPluginConstPtrVectorEnumerator GetEnumerator()
		{
			return new PlugPluginConstPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			PlugPINVOKE.PlugPluginConstPtrVector_Clear(swigCPtr);
		}

		public void Add(PlugPlugin x)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_Add(swigCPtr, PlugPlugin.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return PlugPINVOKE.PlugPluginConstPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return PlugPINVOKE.PlugPluginConstPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_reserve(swigCPtr, n);
		}

		public PlugPluginConstPtrVector()
			: this(PlugPINVOKE.new_PlugPluginConstPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PlugPluginConstPtrVector(PlugPluginConstPtrVector other)
			: this(PlugPINVOKE.new_PlugPluginConstPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PlugPluginConstPtrVector(int capacity)
			: this(PlugPINVOKE.new_PlugPluginConstPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private PlugPlugin getitemcopy(int index)
		{
			IntPtr intPtr = PlugPINVOKE.PlugPluginConstPtrVector_getitemcopy(swigCPtr, index);
			PlugPlugin result = ((intPtr == IntPtr.Zero) ? null : new PlugPlugin(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private PlugPlugin getitem(int index)
		{
			IntPtr intPtr = PlugPINVOKE.PlugPluginConstPtrVector_getitem(swigCPtr, index);
			PlugPlugin result = ((intPtr == IntPtr.Zero) ? null : new PlugPlugin(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, PlugPlugin val)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_setitem(swigCPtr, index, PlugPlugin.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(PlugPluginConstPtrVector values)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PlugPluginConstPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = PlugPINVOKE.PlugPluginConstPtrVector_GetRange(swigCPtr, index, count);
			PlugPluginConstPtrVector result = ((intPtr == IntPtr.Zero) ? null : new PlugPluginConstPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, PlugPlugin x)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_Insert(swigCPtr, index, PlugPlugin.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, PlugPluginConstPtrVector values)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static PlugPluginConstPtrVector Repeat(PlugPlugin value, int count)
		{
			IntPtr intPtr = PlugPINVOKE.PlugPluginConstPtrVector_Repeat(PlugPlugin.getCPtr(value), count);
			PlugPluginConstPtrVector result = ((intPtr == IntPtr.Zero) ? null : new PlugPluginConstPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			PlugPINVOKE.PlugPluginConstPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, PlugPluginConstPtrVector values)
		{
			PlugPINVOKE.PlugPluginConstPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
