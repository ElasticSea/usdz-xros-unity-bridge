using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfNamespaceEditVector : IDisposable, IEnumerable, IEnumerable<SdfNamespaceEdit>
	{
		public sealed class SdfNamespaceEditVectorEnumerator : IEnumerator, IEnumerator<SdfNamespaceEdit>, IDisposable
		{
			private SdfNamespaceEditVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfNamespaceEdit Current
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
					return (SdfNamespaceEdit)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfNamespaceEditVectorEnumerator(SdfNamespaceEditVector collection)
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

		public SdfNamespaceEdit this[int index]
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

		public SdfNamespaceEditVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfNamespaceEditVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfNamespaceEditVector obj)
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

		~SdfNamespaceEditVector()
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
						SdfPINVOKE.delete_SdfNamespaceEditVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfNamespaceEditVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfNamespaceEdit item in c)
			{
				Add(item);
			}
		}

		public SdfNamespaceEditVector(IEnumerable<SdfNamespaceEdit> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfNamespaceEdit item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfNamespaceEdit[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfNamespaceEdit[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfNamespaceEdit[] array, int arrayIndex, int count)
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

		public SdfNamespaceEdit[] ToArray()
		{
			SdfNamespaceEdit[] array = new SdfNamespaceEdit[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfNamespaceEdit> IEnumerable<SdfNamespaceEdit>.GetEnumerator()
		{
			return new SdfNamespaceEditVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfNamespaceEditVectorEnumerator(this);
		}

		public SdfNamespaceEditVectorEnumerator GetEnumerator()
		{
			return new SdfNamespaceEditVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfNamespaceEditVector_Clear(swigCPtr);
		}

		public void Add(SdfNamespaceEdit x)
		{
			SdfPINVOKE.SdfNamespaceEditVector_Add(swigCPtr, SdfNamespaceEdit.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfNamespaceEditVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfNamespaceEditVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfNamespaceEditVector_reserve(swigCPtr, n);
		}

		public SdfNamespaceEditVector()
			: this(SdfPINVOKE.new_SdfNamespaceEditVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfNamespaceEditVector(SdfNamespaceEditVector other)
			: this(SdfPINVOKE.new_SdfNamespaceEditVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfNamespaceEditVector(int capacity)
			: this(SdfPINVOKE.new_SdfNamespaceEditVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfNamespaceEdit getitemcopy(int index)
		{
			SdfNamespaceEdit result = new SdfNamespaceEdit(SdfPINVOKE.SdfNamespaceEditVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfNamespaceEdit getitem(int index)
		{
			SdfNamespaceEdit result = new SdfNamespaceEdit(SdfPINVOKE.SdfNamespaceEditVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfNamespaceEdit val)
		{
			SdfPINVOKE.SdfNamespaceEditVector_setitem(swigCPtr, index, SdfNamespaceEdit.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfNamespaceEditVector values)
		{
			SdfPINVOKE.SdfNamespaceEditVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfNamespaceEditVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfNamespaceEditVector_GetRange(swigCPtr, index, count);
			SdfNamespaceEditVector result = ((intPtr == IntPtr.Zero) ? null : new SdfNamespaceEditVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfNamespaceEdit x)
		{
			SdfPINVOKE.SdfNamespaceEditVector_Insert(swigCPtr, index, SdfNamespaceEdit.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfNamespaceEditVector values)
		{
			SdfPINVOKE.SdfNamespaceEditVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfNamespaceEditVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfNamespaceEditVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfNamespaceEditVector Repeat(SdfNamespaceEdit value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfNamespaceEditVector_Repeat(SdfNamespaceEdit.getCPtr(value), count);
			SdfNamespaceEditVector result = ((intPtr == IntPtr.Zero) ? null : new SdfNamespaceEditVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfNamespaceEditVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfNamespaceEditVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfNamespaceEditVector values)
		{
			SdfPINVOKE.SdfNamespaceEditVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
