using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomBasisCurvesComputeInterpolationInfo : IDisposable, IEnumerable, IEnumerable<UsdGeomBasisCurvesComputeInterpolationInfoPair>
	{
		public sealed class UsdGeomBasisCurvesComputeInterpolationInfoEnumerator : IEnumerator, IEnumerator<UsdGeomBasisCurvesComputeInterpolationInfoPair>, IDisposable
		{
			private UsdGeomBasisCurvesComputeInterpolationInfo collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdGeomBasisCurvesComputeInterpolationInfoPair Current
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
					return (UsdGeomBasisCurvesComputeInterpolationInfoPair)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdGeomBasisCurvesComputeInterpolationInfoEnumerator(UsdGeomBasisCurvesComputeInterpolationInfo collection)
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

		public UsdGeomBasisCurvesComputeInterpolationInfoPair this[int index]
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

		public UsdGeomBasisCurvesComputeInterpolationInfo(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomBasisCurvesComputeInterpolationInfo obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomBasisCurvesComputeInterpolationInfo obj)
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

		~UsdGeomBasisCurvesComputeInterpolationInfo()
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
						UsdGeomPINVOKE.delete_UsdGeomBasisCurvesComputeInterpolationInfo(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomBasisCurvesComputeInterpolationInfo(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdGeomBasisCurvesComputeInterpolationInfoPair item in c)
			{
				Add(item);
			}
		}

		public UsdGeomBasisCurvesComputeInterpolationInfo(IEnumerable<UsdGeomBasisCurvesComputeInterpolationInfoPair> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdGeomBasisCurvesComputeInterpolationInfoPair item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdGeomBasisCurvesComputeInterpolationInfoPair[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdGeomBasisCurvesComputeInterpolationInfoPair[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdGeomBasisCurvesComputeInterpolationInfoPair[] array, int arrayIndex, int count)
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

		public UsdGeomBasisCurvesComputeInterpolationInfoPair[] ToArray()
		{
			UsdGeomBasisCurvesComputeInterpolationInfoPair[] array = new UsdGeomBasisCurvesComputeInterpolationInfoPair[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdGeomBasisCurvesComputeInterpolationInfoPair> IEnumerable<UsdGeomBasisCurvesComputeInterpolationInfoPair>.GetEnumerator()
		{
			return new UsdGeomBasisCurvesComputeInterpolationInfoEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdGeomBasisCurvesComputeInterpolationInfoEnumerator(this);
		}

		public UsdGeomBasisCurvesComputeInterpolationInfoEnumerator GetEnumerator()
		{
			return new UsdGeomBasisCurvesComputeInterpolationInfoEnumerator(this);
		}

		public void Clear()
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Clear(swigCPtr);
		}

		public void Add(UsdGeomBasisCurvesComputeInterpolationInfoPair x)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Add(swigCPtr, UsdGeomBasisCurvesComputeInterpolationInfoPair.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_reserve(swigCPtr, n);
		}

		public UsdGeomBasisCurvesComputeInterpolationInfo()
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdGeomBasisCurvesComputeInterpolationInfo(UsdGeomBasisCurvesComputeInterpolationInfo other)
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomBasisCurvesComputeInterpolationInfo(int capacity)
			: this(UsdGeomPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdGeomBasisCurvesComputeInterpolationInfoPair getitemcopy(int index)
		{
			UsdGeomBasisCurvesComputeInterpolationInfoPair result = new UsdGeomBasisCurvesComputeInterpolationInfoPair(UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdGeomBasisCurvesComputeInterpolationInfoPair getitem(int index)
		{
			UsdGeomBasisCurvesComputeInterpolationInfoPair result = new UsdGeomBasisCurvesComputeInterpolationInfoPair(UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdGeomBasisCurvesComputeInterpolationInfoPair val)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_setitem(swigCPtr, index, UsdGeomBasisCurvesComputeInterpolationInfoPair.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdGeomBasisCurvesComputeInterpolationInfo values)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomBasisCurvesComputeInterpolationInfo GetRange(int index, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_GetRange(swigCPtr, index, count);
			UsdGeomBasisCurvesComputeInterpolationInfo result = ((intPtr == IntPtr.Zero) ? null : new UsdGeomBasisCurvesComputeInterpolationInfo(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdGeomBasisCurvesComputeInterpolationInfoPair x)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Insert(swigCPtr, index, UsdGeomBasisCurvesComputeInterpolationInfoPair.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdGeomBasisCurvesComputeInterpolationInfo values)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdGeomBasisCurvesComputeInterpolationInfo Repeat(UsdGeomBasisCurvesComputeInterpolationInfoPair value, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Repeat(UsdGeomBasisCurvesComputeInterpolationInfoPair.getCPtr(value), count);
			UsdGeomBasisCurvesComputeInterpolationInfo result = ((intPtr == IntPtr.Zero) ? null : new UsdGeomBasisCurvesComputeInterpolationInfo(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdGeomBasisCurvesComputeInterpolationInfo values)
		{
			UsdGeomPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
