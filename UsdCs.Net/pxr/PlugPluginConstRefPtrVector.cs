using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PlugPluginConstRefPtrVector : IDisposable, IEnumerable, IEnumerable<PlugPlugin>
	{
		public sealed class PlugPluginConstRefPtrVectorEnumerator : IEnumerator, IEnumerator<PlugPlugin>, IDisposable
		{
			private PlugPluginConstRefPtrVector collectionRef;

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

			public PlugPluginConstRefPtrVectorEnumerator(PlugPluginConstRefPtrVector collection)
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

		public PlugPluginConstRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PlugPluginConstRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PlugPluginConstRefPtrVector obj)
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

		~PlugPluginConstRefPtrVector()
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
						PlugPINVOKE.delete_PlugPluginConstRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PlugPluginConstRefPtrVector(IEnumerable c)
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

		public PlugPluginConstRefPtrVector(IEnumerable<PlugPlugin> c)
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
			return new PlugPluginConstRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new PlugPluginConstRefPtrVectorEnumerator(this);
		}

		public PlugPluginConstRefPtrVectorEnumerator GetEnumerator()
		{
			return new PlugPluginConstRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_Clear(swigCPtr);
		}

		public void Add(PlugPlugin x)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_Add(swigCPtr, PlugPlugin.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return PlugPINVOKE.PlugPluginConstRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return PlugPINVOKE.PlugPluginConstRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_reserve(swigCPtr, n);
		}

		public PlugPluginConstRefPtrVector()
			: this(PlugPINVOKE.new_PlugPluginConstRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PlugPluginConstRefPtrVector(PlugPluginConstRefPtrVector other)
			: this(PlugPINVOKE.new_PlugPluginConstRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PlugPluginConstRefPtrVector(int capacity)
			: this(PlugPINVOKE.new_PlugPluginConstRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private PlugPlugin getitemcopy(int index)
		{
			IntPtr intPtr = PlugPINVOKE.PlugPluginConstRefPtrVector_getitemcopy(swigCPtr, index);
			PlugPlugin result = ((intPtr == IntPtr.Zero) ? null : new PlugPlugin(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private PlugPlugin getitem(int index)
		{
			IntPtr intPtr = PlugPINVOKE.PlugPluginConstRefPtrVector_getitem(swigCPtr, index);
			PlugPlugin result = ((intPtr == IntPtr.Zero) ? null : new PlugPlugin(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, PlugPlugin val)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_setitem(swigCPtr, index, PlugPlugin.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(PlugPluginConstRefPtrVector values)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PlugPluginConstRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = PlugPINVOKE.PlugPluginConstRefPtrVector_GetRange(swigCPtr, index, count);
			PlugPluginConstRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new PlugPluginConstRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, PlugPlugin x)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_Insert(swigCPtr, index, PlugPlugin.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, PlugPluginConstRefPtrVector values)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static PlugPluginConstRefPtrVector Repeat(PlugPlugin value, int count)
		{
			IntPtr intPtr = PlugPINVOKE.PlugPluginConstRefPtrVector_Repeat(PlugPlugin.getCPtr(value), count);
			PlugPluginConstRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new PlugPluginConstRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, PlugPluginConstRefPtrVector values)
		{
			PlugPINVOKE.PlugPluginConstRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
