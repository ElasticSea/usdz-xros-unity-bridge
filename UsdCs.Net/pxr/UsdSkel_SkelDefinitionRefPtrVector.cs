using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkel_SkelDefinitionRefPtrVector : IDisposable, IEnumerable, IEnumerable<SWIGTYPE_p_UsdSkel_SkelDefinition>
	{
		public sealed class UsdSkel_SkelDefinitionRefPtrVectorEnumerator : IEnumerator, IEnumerator<SWIGTYPE_p_UsdSkel_SkelDefinition>, IDisposable
		{
			private UsdSkel_SkelDefinitionRefPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SWIGTYPE_p_UsdSkel_SkelDefinition Current
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
					return (SWIGTYPE_p_UsdSkel_SkelDefinition)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdSkel_SkelDefinitionRefPtrVectorEnumerator(UsdSkel_SkelDefinitionRefPtrVector collection)
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

		public SWIGTYPE_p_UsdSkel_SkelDefinition this[int index]
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

		public UsdSkel_SkelDefinitionRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkel_SkelDefinitionRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkel_SkelDefinitionRefPtrVector obj)
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

		~UsdSkel_SkelDefinitionRefPtrVector()
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
						UsdSkelPINVOKE.delete_UsdSkel_SkelDefinitionRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkel_SkelDefinitionRefPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SWIGTYPE_p_UsdSkel_SkelDefinition item in c)
			{
				Add(item);
			}
		}

		public UsdSkel_SkelDefinitionRefPtrVector(IEnumerable<SWIGTYPE_p_UsdSkel_SkelDefinition> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SWIGTYPE_p_UsdSkel_SkelDefinition item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SWIGTYPE_p_UsdSkel_SkelDefinition[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SWIGTYPE_p_UsdSkel_SkelDefinition[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SWIGTYPE_p_UsdSkel_SkelDefinition[] array, int arrayIndex, int count)
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

		public SWIGTYPE_p_UsdSkel_SkelDefinition[] ToArray()
		{
			SWIGTYPE_p_UsdSkel_SkelDefinition[] array = new SWIGTYPE_p_UsdSkel_SkelDefinition[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SWIGTYPE_p_UsdSkel_SkelDefinition> IEnumerable<SWIGTYPE_p_UsdSkel_SkelDefinition>.GetEnumerator()
		{
			return new UsdSkel_SkelDefinitionRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdSkel_SkelDefinitionRefPtrVectorEnumerator(this);
		}

		public UsdSkel_SkelDefinitionRefPtrVectorEnumerator GetEnumerator()
		{
			return new UsdSkel_SkelDefinitionRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_Clear(swigCPtr);
		}

		public void Add(SWIGTYPE_p_UsdSkel_SkelDefinition x)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_Add(swigCPtr, SWIGTYPE_p_UsdSkel_SkelDefinition.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_reserve(swigCPtr, n);
		}

		public UsdSkel_SkelDefinitionRefPtrVector()
			: this(UsdSkelPINVOKE.new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkel_SkelDefinitionRefPtrVector(UsdSkel_SkelDefinitionRefPtrVector other)
			: this(UsdSkelPINVOKE.new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkel_SkelDefinitionRefPtrVector(int capacity)
			: this(UsdSkelPINVOKE.new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SWIGTYPE_p_UsdSkel_SkelDefinition getitemcopy(int index)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_getitemcopy(swigCPtr, index);
			SWIGTYPE_p_UsdSkel_SkelDefinition result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_UsdSkel_SkelDefinition(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SWIGTYPE_p_UsdSkel_SkelDefinition getitem(int index)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_getitem(swigCPtr, index);
			SWIGTYPE_p_UsdSkel_SkelDefinition result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_UsdSkel_SkelDefinition(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SWIGTYPE_p_UsdSkel_SkelDefinition val)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_setitem(swigCPtr, index, SWIGTYPE_p_UsdSkel_SkelDefinition.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdSkel_SkelDefinitionRefPtrVector values)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkel_SkelDefinitionRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_GetRange(swigCPtr, index, count);
			UsdSkel_SkelDefinitionRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkel_SkelDefinitionRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SWIGTYPE_p_UsdSkel_SkelDefinition x)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_Insert(swigCPtr, index, SWIGTYPE_p_UsdSkel_SkelDefinition.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdSkel_SkelDefinitionRefPtrVector values)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdSkel_SkelDefinitionRefPtrVector Repeat(SWIGTYPE_p_UsdSkel_SkelDefinition value, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_Repeat(SWIGTYPE_p_UsdSkel_SkelDefinition.getCPtr(value), count);
			UsdSkel_SkelDefinitionRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkel_SkelDefinitionRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdSkel_SkelDefinitionRefPtrVector values)
		{
			UsdSkelPINVOKE.UsdSkel_SkelDefinitionRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
