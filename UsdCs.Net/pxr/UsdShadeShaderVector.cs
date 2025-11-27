using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeShaderVector : IDisposable, IEnumerable, IEnumerable<UsdShadeShader>
	{
		public sealed class UsdShadeShaderVectorEnumerator : IEnumerator, IEnumerator<UsdShadeShader>, IDisposable
		{
			private UsdShadeShaderVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdShadeShader Current
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
					return (UsdShadeShader)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdShadeShaderVectorEnumerator(UsdShadeShaderVector collection)
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

		public UsdShadeShader this[int index]
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

		public UsdShadeShaderVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeShaderVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeShaderVector obj)
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

		~UsdShadeShaderVector()
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
						UsdShadePINVOKE.delete_UsdShadeShaderVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeShaderVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeShader item in c)
			{
				Add(item);
			}
		}

		public UsdShadeShaderVector(IEnumerable<UsdShadeShader> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeShader item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdShadeShader[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdShadeShader[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdShadeShader[] array, int arrayIndex, int count)
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

		public UsdShadeShader[] ToArray()
		{
			UsdShadeShader[] array = new UsdShadeShader[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdShadeShader> IEnumerable<UsdShadeShader>.GetEnumerator()
		{
			return new UsdShadeShaderVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdShadeShaderVectorEnumerator(this);
		}

		public UsdShadeShaderVectorEnumerator GetEnumerator()
		{
			return new UsdShadeShaderVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdShadePINVOKE.UsdShadeShaderVector_Clear(swigCPtr);
		}

		public void Add(UsdShadeShader x)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_Add(swigCPtr, UsdShadeShader.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdShadePINVOKE.UsdShadeShaderVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdShadePINVOKE.UsdShadeShaderVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_reserve(swigCPtr, n);
		}

		public UsdShadeShaderVector()
			: this(UsdShadePINVOKE.new_UsdShadeShaderVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdShadeShaderVector(UsdShadeShaderVector other)
			: this(UsdShadePINVOKE.new_UsdShadeShaderVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeShaderVector(int capacity)
			: this(UsdShadePINVOKE.new_UsdShadeShaderVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdShadeShader getitemcopy(int index)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeShaderVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdShadeShader getitem(int index)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeShaderVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdShadeShader val)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_setitem(swigCPtr, index, UsdShadeShader.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdShadeShaderVector values)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeShaderVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeShaderVector_GetRange(swigCPtr, index, count);
			UsdShadeShaderVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeShaderVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdShadeShader x)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_Insert(swigCPtr, index, UsdShadeShader.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdShadeShaderVector values)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdShadeShaderVector Repeat(UsdShadeShader value, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeShaderVector_Repeat(UsdShadeShader.getCPtr(value), count);
			UsdShadeShaderVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeShaderVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdShadePINVOKE.UsdShadeShaderVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdShadeShaderVector values)
		{
			UsdShadePINVOKE.UsdShadeShaderVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
