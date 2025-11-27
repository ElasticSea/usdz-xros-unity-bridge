using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec3dVector : IDisposable, IEnumerable, IEnumerable<GfVec3d>
	{
		public sealed class GfVec3dVectorEnumerator : IEnumerator, IEnumerator<GfVec3d>, IDisposable
		{
			private GfVec3dVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public GfVec3d Current
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
					return (GfVec3d)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public GfVec3dVectorEnumerator(GfVec3dVector collection)
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

		public GfVec3d this[int index]
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

		public GfVec3dVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec3dVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec3dVector obj)
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

		~GfVec3dVector()
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
						GfPINVOKE.delete_GfVec3dVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec3dVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (GfVec3d item in c)
			{
				Add(item);
			}
		}

		public GfVec3dVector(IEnumerable<GfVec3d> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (GfVec3d item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(GfVec3d[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(GfVec3d[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, GfVec3d[] array, int arrayIndex, int count)
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

		public GfVec3d[] ToArray()
		{
			GfVec3d[] array = new GfVec3d[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<GfVec3d> IEnumerable<GfVec3d>.GetEnumerator()
		{
			return new GfVec3dVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new GfVec3dVectorEnumerator(this);
		}

		public GfVec3dVectorEnumerator GetEnumerator()
		{
			return new GfVec3dVectorEnumerator(this);
		}

		public void Clear()
		{
			GfPINVOKE.GfVec3dVector_Clear(swigCPtr);
		}

		public void Add(GfVec3d x)
		{
			GfPINVOKE.GfVec3dVector_Add(swigCPtr, GfVec3d.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return GfPINVOKE.GfVec3dVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return GfPINVOKE.GfVec3dVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			GfPINVOKE.GfVec3dVector_reserve(swigCPtr, n);
		}

		public GfVec3dVector()
			: this(GfPINVOKE.new_GfVec3dVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec3dVector(GfVec3dVector other)
			: this(GfPINVOKE.new_GfVec3dVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3dVector(int capacity)
			: this(GfPINVOKE.new_GfVec3dVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private GfVec3d getitemcopy(int index)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfVec3dVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private GfVec3d getitem(int index)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfVec3dVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, GfVec3d val)
		{
			GfPINVOKE.GfVec3dVector_setitem(swigCPtr, index, GfVec3d.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(GfVec3dVector values)
		{
			GfPINVOKE.GfVec3dVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3dVector GetRange(int index, int count)
		{
			IntPtr intPtr = GfPINVOKE.GfVec3dVector_GetRange(swigCPtr, index, count);
			GfVec3dVector result = ((intPtr == IntPtr.Zero) ? null : new GfVec3dVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, GfVec3d x)
		{
			GfPINVOKE.GfVec3dVector_Insert(swigCPtr, index, GfVec3d.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, GfVec3dVector values)
		{
			GfPINVOKE.GfVec3dVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			GfPINVOKE.GfVec3dVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			GfPINVOKE.GfVec3dVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec3dVector Repeat(GfVec3d value, int count)
		{
			IntPtr intPtr = GfPINVOKE.GfVec3dVector_Repeat(GfVec3d.getCPtr(value), count);
			GfVec3dVector result = ((intPtr == IntPtr.Zero) ? null : new GfVec3dVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			GfPINVOKE.GfVec3dVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			GfPINVOKE.GfVec3dVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, GfVec3dVector values)
		{
			GfPINVOKE.GfVec3dVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
