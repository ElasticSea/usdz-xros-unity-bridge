using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerHandleSet : IDisposable, ISet<SdfLayerHandle>, ICollection<SdfLayerHandle>, IEnumerable<SdfLayerHandle>, IEnumerable
	{
		public sealed class SdfLayerHandleSetEnumerator : IEnumerator, IEnumerator<SdfLayerHandle>, IDisposable
		{
			private SdfLayerHandleSet collectionRef;

			private IList<SdfLayerHandle> ItemsCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfLayerHandle Current
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
					return (SdfLayerHandle)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfLayerHandleSetEnumerator(SdfLayerHandleSet collection)
			{
				collectionRef = collection;
				ItemsCollection = new List<SdfLayerHandle>(collection.Items);
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
					currentObject = ItemsCollection[currentIndex];
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

		public int Count => (int)size();

		public bool IsReadOnly => false;

		private ICollection<SdfLayerHandle> Items
		{
			get
			{
				ICollection<SdfLayerHandle> collection = new List<SdfLayerHandle>();
				int count = Count;
				if (count > 0)
				{
					IntPtr swigiterator = create_iterator_begin();
					for (int i = 0; i < count; i++)
					{
						collection.Add(get_next(swigiterator));
					}
					destroy_iterator(swigiterator);
				}
				return collection;
			}
		}

		public SdfLayerHandleSet(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerHandleSet obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerHandleSet obj)
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

		~SdfLayerHandleSet()
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
						SdfPINVOKE.delete_SdfLayerHandleSet(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		void ICollection<SdfLayerHandle>.Add(SdfLayerHandle item)
		{
			((ISet<SdfLayerHandle>)this).Add(item);
		}

		public bool TryGetValue(SdfLayerHandle equalValue, out SdfLayerHandle actualValue)
		{
			try
			{
				actualValue = getitem(equalValue);
				return true;
			}
			catch
			{
				actualValue = null;
				return false;
			}
		}

		public void CopyTo(SdfLayerHandle[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(SdfLayerHandle[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
			}
			if (array.Rank > 1)
			{
				throw new ArgumentException("Multi dimensional array.", "array");
			}
			if (arrayIndex + Count > array.Length)
			{
				throw new ArgumentException("Number of elements to copy is too large.");
			}
			using SdfLayerHandleSetEnumerator sdfLayerHandleSetEnumerator = GetEnumerator();
			while (sdfLayerHandleSetEnumerator.MoveNext())
			{
				SdfLayerHandle current = sdfLayerHandleSetEnumerator.Current;
				array.SetValue(current, arrayIndex++);
			}
		}

		public void ExceptWith(IEnumerable<SdfLayerHandle> other)
		{
			foreach (SdfLayerHandle item in other)
			{
				Remove(item);
			}
		}

		public void IntersectWith(IEnumerable<SdfLayerHandle> other)
		{
			SdfLayerHandleSet sdfLayerHandleSet = new SdfLayerHandleSet(this);
			Clear();
			foreach (SdfLayerHandle item in other)
			{
				if (sdfLayerHandleSet.Contains(item))
				{
					Add(item);
				}
			}
		}

		private static int count_enum(IEnumerable<SdfLayerHandle> other)
		{
			int num = 0;
			foreach (SdfLayerHandle item in other)
			{
				num++;
			}
			return num;
		}

		public bool IsProperSubsetOf(IEnumerable<SdfLayerHandle> other)
		{
			if (IsSubsetOf(other))
			{
				return Count < count_enum(other);
			}
			return false;
		}

		public bool IsProperSupersetOf(IEnumerable<SdfLayerHandle> other)
		{
			if (IsSupersetOf(other))
			{
				return Count > count_enum(other);
			}
			return false;
		}

		public bool IsSubsetOf(IEnumerable<SdfLayerHandle> other)
		{
			int num = 0;
			foreach (SdfLayerHandle item in other)
			{
				if (Contains(item))
				{
					num++;
				}
			}
			return num == Count;
		}

		public bool IsSupersetOf(IEnumerable<SdfLayerHandle> other)
		{
			foreach (SdfLayerHandle item in other)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		public bool Overlaps(IEnumerable<SdfLayerHandle> other)
		{
			foreach (SdfLayerHandle item in other)
			{
				if (Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		public bool SetEquals(IEnumerable<SdfLayerHandle> other)
		{
			if (IsSupersetOf(other))
			{
				return Count == count_enum(other);
			}
			return false;
		}

		public void SymmetricExceptWith(IEnumerable<SdfLayerHandle> other)
		{
			foreach (SdfLayerHandle item in other)
			{
				if (!Remove(item))
				{
					Add(item);
				}
			}
		}

		public void UnionWith(IEnumerable<SdfLayerHandle> other)
		{
			foreach (SdfLayerHandle item in other)
			{
				Add(item);
			}
		}

		IEnumerator<SdfLayerHandle> IEnumerable<SdfLayerHandle>.GetEnumerator()
		{
			return new SdfLayerHandleSetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfLayerHandleSetEnumerator(this);
		}

		public SdfLayerHandleSetEnumerator GetEnumerator()
		{
			return new SdfLayerHandleSetEnumerator(this);
		}

		public SdfLayerHandleSet()
			: this(SdfPINVOKE.new_SdfLayerHandleSet__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfLayerHandleSet(SdfLayerHandleSet other)
			: this(SdfPINVOKE.new_SdfLayerHandleSet__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfLayerHandleSet_size(swigCPtr);
		}

		public bool empty()
		{
			return SdfPINVOKE.SdfLayerHandleSet_empty(swigCPtr);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfLayerHandleSet_Clear(swigCPtr);
		}

		public bool Add(SdfLayerHandle item)
		{
			bool result = SdfPINVOKE.SdfLayerHandleSet_Add(swigCPtr, SdfLayerHandle.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(SdfLayerHandle item)
		{
			bool result = SdfPINVOKE.SdfLayerHandleSet_Contains(swigCPtr, SdfLayerHandle.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Remove(SdfLayerHandle item)
		{
			bool result = SdfPINVOKE.SdfLayerHandleSet_Remove(swigCPtr, SdfLayerHandle.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfLayerHandle getitem(SdfLayerHandle item)
		{
			SdfLayerHandle result = new SdfLayerHandle(SdfPINVOKE.SdfLayerHandleSet_getitem(swigCPtr, SdfLayerHandle.getCPtr(item)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return SdfPINVOKE.SdfLayerHandleSet_create_iterator_begin(swigCPtr);
		}

		private SdfLayerHandle get_next(IntPtr swigiterator)
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfLayerHandleSet_get_next(swigCPtr, swigiterator), cMemoryOwn: false);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			SdfPINVOKE.SdfLayerHandleSet_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
