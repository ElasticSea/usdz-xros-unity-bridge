using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfTimeCode : IDisposable
	{
		public class Hash : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public Hash(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(Hash obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(Hash obj)
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

			~Hash()
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
							SdfPINVOKE.delete_SdfTimeCode_Hash(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Hash()
				: this(SdfPINVOKE.new_SdfTimeCode_Hash(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfTimeCode(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfTimeCode obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfTimeCode obj)
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

		~SdfTimeCode()
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
						SdfPINVOKE.delete_SdfTimeCode(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfTimeCode(double time)
			: this(SdfPINVOKE.new_SdfTimeCode__SWIG_0(time), cMemoryOwn: true)
		{
		}

		public SdfTimeCode()
			: this(SdfPINVOKE.new_SdfTimeCode__SWIG_1(), cMemoryOwn: true)
		{
		}

		public uint GetHash()
		{
			return SdfPINVOKE.SdfTimeCode_GetHash(swigCPtr);
		}

		public double GetValue()
		{
			return SdfPINVOKE.SdfTimeCode_GetValue(swigCPtr);
		}
	}
}
