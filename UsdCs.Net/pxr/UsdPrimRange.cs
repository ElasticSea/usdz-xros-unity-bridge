using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using USD.NET;

namespace pxr
{
	public class UsdPrimRange : IEnumerable, IEnumerable<UsdPrim>
	{
		public class EndSentinel : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public EndSentinel(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(EndSentinel obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(EndSentinel obj)
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

			~EndSentinel()
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
							UsdPINVOKE.delete_UsdPrimRange_EndSentinel(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}
		}

		public class iterator : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public iterator(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(iterator obj)
			{
				if (!(obj == null))
				{
					return obj.swigCPtr;
				}
				return new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(iterator obj)
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

			~iterator()
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
							UsdPINVOKE.delete_UsdPrimRange_iterator(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public iterator()
				: this(UsdPINVOKE.new_UsdPrimRange_iterator__SWIG_0(), cMemoryOwn: true)
			{
			}

			public iterator(EndSentinel e)
				: this(UsdPINVOKE.new_UsdPrimRange_iterator__SWIG_1(EndSentinel.getCPtr(e)), cMemoryOwn: true)
			{
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public bool IsPostVisit()
			{
				return UsdPINVOKE.UsdPrimRange_iterator_IsPostVisit(swigCPtr);
			}

			public void PruneChildren()
			{
				UsdPINVOKE.UsdPrimRange_iterator_PruneChildren(swigCPtr);
			}

			public static bool Equals(iterator lhs, iterator rhs)
			{
				bool result = UsdPINVOKE.UsdPrimRange_iterator_Equals(getCPtr(lhs), getCPtr(rhs));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public static bool operator ==(iterator lhs, iterator rhs)
			{
				bool flag = (object)lhs == null;
				bool flag2 = (object)rhs == null;
				if (flag == flag2)
				{
					if (!(flag && flag2))
					{
						return Equals(lhs, rhs);
					}
					return true;
				}
				return false;
			}

			public static bool operator !=(iterator lhs, iterator rhs)
			{
				return !(lhs == rhs);
			}

			public override bool Equals(object rhs)
			{
				return Equals(this, rhs as iterator);
			}

			public override int GetHashCode()
			{
				return UsdPINVOKE.UsdPrimRange_iterator_GetHashCode(swigCPtr);
			}

			public void MoveNext()
			{
				UsdPINVOKE.UsdPrimRange_iterator_MoveNext(swigCPtr);
			}

			public UsdPrim GetCurrent()
			{
				return new UsdPrim(UsdPINVOKE.UsdPrimRange_iterator_GetCurrent(swigCPtr), cMemoryOwn: true);
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdPrimRange(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrimRange obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrimRange obj)
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

		~UsdPrimRange()
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
						UsdPINVOKE.delete_UsdPrimRange(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdPrimRange()
			: this(UsdPINVOKE.new_UsdPrimRange__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdPrimRange(UsdPrim start)
			: this(UsdPINVOKE.new_UsdPrimRange__SWIG_1(UsdPrim.getCPtr(start)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPrimRange(UsdPrim start, Usd_PrimFlagsPredicate predicate)
			: this(UsdPINVOKE.new_UsdPrimRange__SWIG_2(UsdPrim.getCPtr(start), Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdPrimRange PreAndPostVisit(UsdPrim start)
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdPrimRange_PreAndPostVisit__SWIG_0(UsdPrim.getCPtr(start)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdPrimRange PreAndPostVisit(UsdPrim start, Usd_PrimFlagsPredicate predicate)
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdPrimRange_PreAndPostVisit__SWIG_1(UsdPrim.getCPtr(start), Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdPrimRange AllPrims(UsdPrim start)
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdPrimRange_AllPrims(UsdPrim.getCPtr(start)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdPrimRange AllPrimsPreAndPostVisit(UsdPrim start)
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdPrimRange_AllPrimsPreAndPostVisit(UsdPrim.getCPtr(start)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdPrimRange Stage(UsdStage stage, Usd_PrimFlagsPredicate predicate)
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdPrimRange_Stage__SWIG_0(UsdStage.getCPtr(stage), Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdPrimRange Stage(UsdStage stage)
		{
			UsdPrimRange result = new UsdPrimRange(UsdPINVOKE.UsdPrimRange_Stage__SWIG_1(UsdStage.getCPtr(stage)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public iterator GetStart()
		{
			return new iterator(UsdPINVOKE.UsdPrimRange_GetStart(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetCurrent()
		{
			return new UsdPrim(UsdPINVOKE.UsdPrimRange_GetCurrent(swigCPtr), cMemoryOwn: true);
		}

		public iterator GetEnd()
		{
			return new iterator(UsdPINVOKE.UsdPrimRange_GetEnd(swigCPtr), cMemoryOwn: true);
		}

		public void IncrementBegin()
		{
			UsdPINVOKE.UsdPrimRange_IncrementBegin(swigCPtr);
		}

		public void SetBegin(iterator newBegin)
		{
			UsdPINVOKE.UsdPrimRange_SetBegin(swigCPtr, iterator.getCPtr(newBegin));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsEmpty()
		{
			return UsdPINVOKE.UsdPrimRange_IsEmpty(swigCPtr);
		}

		public static bool Equals(UsdPrimRange lhs, UsdPrimRange rhs)
		{
			bool result = UsdPINVOKE.UsdPrimRange_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(UsdPrimRange lhs, UsdPrimRange rhs)
		{
			bool flag = (object)lhs == null;
			bool flag2 = (object)rhs == null;
			if (flag == flag2)
			{
				if (!(flag && flag2))
				{
					return Equals(lhs, rhs);
				}
				return true;
			}
			return false;
		}

		public static bool operator !=(UsdPrimRange lhs, UsdPrimRange rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as UsdPrimRange);
		}

		public override int GetHashCode()
		{
			return UsdPINVOKE.UsdPrimRange_GetHashCode(swigCPtr);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new RangeIterator(this);
		}

		public IEnumerator<UsdPrim> GetEnumerator()
		{
			return new RangeIterator(this);
		}
	}
}
