using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrVersion : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public NdrVersion(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrVersion obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrVersion obj)
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

		~NdrVersion()
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
						NdrPINVOKE.delete_NdrVersion(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public NdrVersion()
			: this(NdrPINVOKE.new_NdrVersion__SWIG_0(), cMemoryOwn: true)
		{
		}

		public NdrVersion(int major, int minor)
			: this(NdrPINVOKE.new_NdrVersion__SWIG_1(major, minor), cMemoryOwn: true)
		{
		}

		public NdrVersion(int major)
			: this(NdrPINVOKE.new_NdrVersion__SWIG_2(major), cMemoryOwn: true)
		{
		}

		public NdrVersion(string x)
			: this(NdrPINVOKE.new_NdrVersion__SWIG_3(x), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrVersion GetAsDefault()
		{
			return new NdrVersion(NdrPINVOKE.NdrVersion_GetAsDefault(swigCPtr), cMemoryOwn: true);
		}

		public int GetMajor()
		{
			return NdrPINVOKE.NdrVersion_GetMajor(swigCPtr);
		}

		public int GetMinor()
		{
			return NdrPINVOKE.NdrVersion_GetMinor(swigCPtr);
		}

		public bool IsDefault()
		{
			return NdrPINVOKE.NdrVersion_IsDefault(swigCPtr);
		}

		public string GetString()
		{
			return NdrPINVOKE.NdrVersion_GetString(swigCPtr);
		}

		public string GetStringSuffix()
		{
			return NdrPINVOKE.NdrVersion_GetStringSuffix(swigCPtr);
		}

		public uint GetHash()
		{
			return NdrPINVOKE.NdrVersion_GetHash(swigCPtr);
		}
	}
}
