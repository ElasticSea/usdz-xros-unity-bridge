using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtMatrix4dArrayVector : IDisposable, IEnumerable, IEnumerable<VtMatrix4dArray>
	{
		public sealed class VtMatrix4dArrayVectorEnumerator : IEnumerator, IEnumerator<VtMatrix4dArray>, IDisposable
		{
			private VtMatrix4dArrayVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public VtMatrix4dArray Current
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
					return (VtMatrix4dArray)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public VtMatrix4dArrayVectorEnumerator(VtMatrix4dArrayVector collection)
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

		public VtMatrix4dArray this[int index]
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

		public VtMatrix4dArrayVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtMatrix4dArrayVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtMatrix4dArrayVector obj)
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

		~VtMatrix4dArrayVector()
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
						UsdGeomPINVOKE.delete_VtMatrix4dArrayVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public VtMatrix4dArrayVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (VtMatrix4dArray item in c)
			{
				Add(item);
			}
		}

		public VtMatrix4dArrayVector(IEnumerable<VtMatrix4dArray> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (VtMatrix4dArray item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(VtMatrix4dArray[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(VtMatrix4dArray[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, VtMatrix4dArray[] array, int arrayIndex, int count)
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

		public VtMatrix4dArray[] ToArray()
		{
			VtMatrix4dArray[] array = new VtMatrix4dArray[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<VtMatrix4dArray> IEnumerable<VtMatrix4dArray>.GetEnumerator()
		{
			return new VtMatrix4dArrayVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new VtMatrix4dArrayVectorEnumerator(this);
		}

		public VtMatrix4dArrayVectorEnumerator GetEnumerator()
		{
			return new VtMatrix4dArrayVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_Clear(swigCPtr);
		}

		public void Add(VtMatrix4dArray x)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_Add(swigCPtr, VtMatrix4dArray.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdGeomPINVOKE.VtMatrix4dArrayVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdGeomPINVOKE.VtMatrix4dArrayVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_reserve(swigCPtr, n);
		}

		public VtMatrix4dArrayVector()
			: this(UsdGeomPINVOKE.new_VtMatrix4dArrayVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtMatrix4dArrayVector(VtMatrix4dArrayVector other)
			: this(UsdGeomPINVOKE.new_VtMatrix4dArrayVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix4dArrayVector(int capacity)
			: this(UsdGeomPINVOKE.new_VtMatrix4dArrayVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private VtMatrix4dArray getitemcopy(int index)
		{
			VtMatrix4dArray result = new VtMatrix4dArray(UsdGeomPINVOKE.VtMatrix4dArrayVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private VtMatrix4dArray getitem(int index)
		{
			VtMatrix4dArray result = new VtMatrix4dArray(UsdGeomPINVOKE.VtMatrix4dArrayVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, VtMatrix4dArray val)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_setitem(swigCPtr, index, VtMatrix4dArray.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(VtMatrix4dArrayVector values)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix4dArrayVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.VtMatrix4dArrayVector_GetRange(swigCPtr, index, count);
			VtMatrix4dArrayVector result = ((intPtr == IntPtr.Zero) ? null : new VtMatrix4dArrayVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, VtMatrix4dArray x)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_Insert(swigCPtr, index, VtMatrix4dArray.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, VtMatrix4dArrayVector values)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtMatrix4dArrayVector Repeat(VtMatrix4dArray value, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.VtMatrix4dArrayVector_Repeat(VtMatrix4dArray.getCPtr(value), count);
			VtMatrix4dArrayVector result = ((intPtr == IntPtr.Zero) ? null : new VtMatrix4dArrayVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, VtMatrix4dArrayVector values)
		{
			UsdGeomPINVOKE.VtMatrix4dArrayVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
