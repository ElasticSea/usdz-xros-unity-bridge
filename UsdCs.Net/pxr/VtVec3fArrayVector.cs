using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec3fArrayVector : IDisposable, IEnumerable, IEnumerable<VtVec3fArray>
	{
		public sealed class VtVec3fArrayVectorEnumerator : IEnumerator, IEnumerator<VtVec3fArray>, IDisposable
		{
			private VtVec3fArrayVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public VtVec3fArray Current
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
					return (VtVec3fArray)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public VtVec3fArrayVectorEnumerator(VtVec3fArrayVector collection)
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

		public VtVec3fArray this[int index]
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

		public VtVec3fArrayVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec3fArrayVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec3fArrayVector obj)
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

		~VtVec3fArrayVector()
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
						UsdGeomPINVOKE.delete_VtVec3fArrayVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public VtVec3fArrayVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (VtVec3fArray item in c)
			{
				Add(item);
			}
		}

		public VtVec3fArrayVector(IEnumerable<VtVec3fArray> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (VtVec3fArray item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(VtVec3fArray[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(VtVec3fArray[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, VtVec3fArray[] array, int arrayIndex, int count)
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

		public VtVec3fArray[] ToArray()
		{
			VtVec3fArray[] array = new VtVec3fArray[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<VtVec3fArray> IEnumerable<VtVec3fArray>.GetEnumerator()
		{
			return new VtVec3fArrayVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new VtVec3fArrayVectorEnumerator(this);
		}

		public VtVec3fArrayVectorEnumerator GetEnumerator()
		{
			return new VtVec3fArrayVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_Clear(swigCPtr);
		}

		public void Add(VtVec3fArray x)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_Add(swigCPtr, VtVec3fArray.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdGeomPINVOKE.VtVec3fArrayVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdGeomPINVOKE.VtVec3fArrayVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_reserve(swigCPtr, n);
		}

		public VtVec3fArrayVector()
			: this(UsdGeomPINVOKE.new_VtVec3fArrayVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec3fArrayVector(VtVec3fArrayVector other)
			: this(UsdGeomPINVOKE.new_VtVec3fArrayVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3fArrayVector(int capacity)
			: this(UsdGeomPINVOKE.new_VtVec3fArrayVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private VtVec3fArray getitemcopy(int index)
		{
			VtVec3fArray result = new VtVec3fArray(UsdGeomPINVOKE.VtVec3fArrayVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private VtVec3fArray getitem(int index)
		{
			VtVec3fArray result = new VtVec3fArray(UsdGeomPINVOKE.VtVec3fArrayVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, VtVec3fArray val)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_setitem(swigCPtr, index, VtVec3fArray.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(VtVec3fArrayVector values)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3fArrayVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.VtVec3fArrayVector_GetRange(swigCPtr, index, count);
			VtVec3fArrayVector result = ((intPtr == IntPtr.Zero) ? null : new VtVec3fArrayVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, VtVec3fArray x)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_Insert(swigCPtr, index, VtVec3fArray.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, VtVec3fArrayVector values)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtVec3fArrayVector Repeat(VtVec3fArray value, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.VtVec3fArrayVector_Repeat(VtVec3fArray.getCPtr(value), count);
			VtVec3fArrayVector result = ((intPtr == IntPtr.Zero) ? null : new VtVec3fArrayVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, VtVec3fArrayVector values)
		{
			UsdGeomPINVOKE.VtVec3fArrayVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
