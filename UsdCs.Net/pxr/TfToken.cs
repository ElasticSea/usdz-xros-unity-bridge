using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfToken : IDisposable
	{
		public class HashFunctor : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public HashFunctor(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(HashFunctor obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(HashFunctor obj)
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

			~HashFunctor()
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
							TfPINVOKE.delete_TfToken_HashFunctor(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public HashFunctor()
				: this(TfPINVOKE.new_TfToken_HashFunctor(), cMemoryOwn: true)
			{
			}
		}

		public enum _ImmortalTag
		{
			Immortal
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfToken(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfToken obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfToken obj)
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

		~TfToken()
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
						TfPINVOKE.delete_TfToken(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfToken()
			: this(TfPINVOKE.new_TfToken__SWIG_0(), cMemoryOwn: true)
		{
		}

		public TfToken(TfToken rhs)
			: this(TfPINVOKE.new_TfToken__SWIG_1(getCPtr(rhs)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken(string s)
			: this(TfPINVOKE.new_TfToken__SWIG_3(s), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken(string s, _ImmortalTag arg1)
			: this(TfPINVOKE.new_TfToken__SWIG_4(s, (int)arg1), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static TfToken Find(string s)
		{
			TfToken result = new TfToken(TfPINVOKE.TfToken_Find(s), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint Hash()
		{
			return TfPINVOKE.TfToken_Hash(swigCPtr);
		}

		public uint size()
		{
			return TfPINVOKE.TfToken_size(swigCPtr);
		}

		public string GetText()
		{
			return TfPINVOKE.TfToken_GetText(swigCPtr);
		}

		public string data()
		{
			return TfPINVOKE.TfToken_data(swigCPtr);
		}

		public string GetString()
		{
			return TfPINVOKE.TfToken_GetString(swigCPtr);
		}

		public void Swap(TfToken other)
		{
			TfPINVOKE.TfToken_Swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsEmpty()
		{
			return TfPINVOKE.TfToken_IsEmpty(swigCPtr);
		}

		public bool IsImmortal()
		{
			return TfPINVOKE.TfToken_IsImmortal(swigCPtr);
		}

		public static bool Equals(TfToken lhs, TfToken rhs)
		{
			bool result = TfPINVOKE.TfToken_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(TfToken lhs, TfToken rhs)
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

		public static bool operator !=(TfToken lhs, TfToken rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as TfToken);
		}

		public override int GetHashCode()
		{
			return TfPINVOKE.TfToken_GetHashCode(swigCPtr);
		}

		public static implicit operator string(TfToken value)
		{
			return value.GetText();
		}

		public override string ToString()
		{
			return GetText();
		}
	}
}
