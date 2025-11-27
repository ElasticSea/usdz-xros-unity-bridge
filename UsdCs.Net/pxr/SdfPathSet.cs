using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPathSet : IDisposable, ISet<SdfPath>, ICollection<SdfPath>, IEnumerable<SdfPath>, IEnumerable
	{
		public sealed class SdfPathSetEnumerator : IEnumerator, IEnumerator<SdfPath>, IDisposable
		{
			private SdfPathSet collectionRef;

			private IList<SdfPath> ItemsCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfPath Current
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
					return (SdfPath)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfPathSetEnumerator(SdfPathSet collection)
			{
				collectionRef = collection;
				ItemsCollection = new List<SdfPath>(collection.Items);
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

		private ICollection<SdfPath> Items
		{
			get
			{
				ICollection<SdfPath> collection = new List<SdfPath>();
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

		public SdfPathSet(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPathSet obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPathSet obj)
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

		~SdfPathSet()
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
						SdfPINVOKE.delete_SdfPathSet(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		void ICollection<SdfPath>.Add(SdfPath item)
		{
			((ISet<SdfPath>)this).Add(item);
		}

		public bool TryGetValue(SdfPath equalValue, out SdfPath actualValue)
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

		public void CopyTo(SdfPath[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(SdfPath[] array, int arrayIndex)
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
			using SdfPathSetEnumerator sdfPathSetEnumerator = GetEnumerator();
			while (sdfPathSetEnumerator.MoveNext())
			{
				SdfPath current = sdfPathSetEnumerator.Current;
				array.SetValue(current, arrayIndex++);
			}
		}

		public void ExceptWith(IEnumerable<SdfPath> other)
		{
			foreach (SdfPath item in other)
			{
				Remove(item);
			}
		}

		public void IntersectWith(IEnumerable<SdfPath> other)
		{
			SdfPathSet sdfPathSet = new SdfPathSet(this);
			Clear();
			foreach (SdfPath item in other)
			{
				if (sdfPathSet.Contains(item))
				{
					Add(item);
				}
			}
		}

		private static int count_enum(IEnumerable<SdfPath> other)
		{
			int num = 0;
			foreach (SdfPath item in other)
			{
				num++;
			}
			return num;
		}

		public bool IsProperSubsetOf(IEnumerable<SdfPath> other)
		{
			if (IsSubsetOf(other))
			{
				return Count < count_enum(other);
			}
			return false;
		}

		public bool IsProperSupersetOf(IEnumerable<SdfPath> other)
		{
			if (IsSupersetOf(other))
			{
				return Count > count_enum(other);
			}
			return false;
		}

		public bool IsSubsetOf(IEnumerable<SdfPath> other)
		{
			int num = 0;
			foreach (SdfPath item in other)
			{
				if (Contains(item))
				{
					num++;
				}
			}
			return num == Count;
		}

		public bool IsSupersetOf(IEnumerable<SdfPath> other)
		{
			foreach (SdfPath item in other)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		public bool Overlaps(IEnumerable<SdfPath> other)
		{
			foreach (SdfPath item in other)
			{
				if (Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		public bool SetEquals(IEnumerable<SdfPath> other)
		{
			if (IsSupersetOf(other))
			{
				return Count == count_enum(other);
			}
			return false;
		}

		public void SymmetricExceptWith(IEnumerable<SdfPath> other)
		{
			foreach (SdfPath item in other)
			{
				if (!Remove(item))
				{
					Add(item);
				}
			}
		}

		public void UnionWith(IEnumerable<SdfPath> other)
		{
			foreach (SdfPath item in other)
			{
				Add(item);
			}
		}

		IEnumerator<SdfPath> IEnumerable<SdfPath>.GetEnumerator()
		{
			return new SdfPathSetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfPathSetEnumerator(this);
		}

		public SdfPathSetEnumerator GetEnumerator()
		{
			return new SdfPathSetEnumerator(this);
		}

		public SdfPathSet()
			: this(SdfPINVOKE.new_SdfPathSet__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPathSet(SdfPathSet other)
			: this(SdfPINVOKE.new_SdfPathSet__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfPathSet_size(swigCPtr);
		}

		public bool empty()
		{
			return SdfPINVOKE.SdfPathSet_empty(swigCPtr);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfPathSet_Clear(swigCPtr);
		}

		public bool Add(SdfPath item)
		{
			bool result = SdfPINVOKE.SdfPathSet_Add(swigCPtr, SdfPath.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(SdfPath item)
		{
			bool result = SdfPINVOKE.SdfPathSet_Contains(swigCPtr, SdfPath.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Remove(SdfPath item)
		{
			bool result = SdfPINVOKE.SdfPathSet_Remove(swigCPtr, SdfPath.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfPath getitem(SdfPath item)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPathSet_getitem(swigCPtr, SdfPath.getCPtr(item)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return SdfPINVOKE.SdfPathSet_create_iterator_begin(swigCPtr);
		}

		private SdfPath get_next(IntPtr swigiterator)
		{
			return new SdfPath(SdfPINVOKE.SdfPathSet_get_next(swigCPtr, swigiterator), cMemoryOwn: false);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			SdfPINVOKE.SdfPathSet_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
