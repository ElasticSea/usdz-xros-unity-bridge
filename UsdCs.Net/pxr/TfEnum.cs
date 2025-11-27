using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfEnum : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfEnum(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfEnum obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfEnum obj)
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

		~TfEnum()
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
						TfPINVOKE.delete_TfEnum(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfEnum()
			: this(TfPINVOKE.new_TfEnum(), cMemoryOwn: true)
		{
		}

		public int GetValueAsInt()
		{
			return TfPINVOKE.TfEnum_GetValueAsInt(swigCPtr);
		}

		public static string GetName(TfEnum val)
		{
			string result = TfPINVOKE.TfEnum_GetName(getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string GetFullName(TfEnum val)
		{
			string result = TfPINVOKE.TfEnum_GetFullName(getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string GetDisplayName(TfEnum val)
		{
			string result = TfPINVOKE.TfEnum_GetDisplayName(getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector GetAllNames(TfEnum val)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfEnum_GetAllNames(getCPtr(val)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfEnum GetValueFromFullName(string fullname, out bool foundIt)
		{
			TfEnum result = new TfEnum(TfPINVOKE.TfEnum_GetValueFromFullName__SWIG_0(fullname, out foundIt), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfEnum GetValueFromFullName(string fullname)
		{
			TfEnum result = new TfEnum(TfPINVOKE.TfEnum_GetValueFromFullName__SWIG_1(fullname), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsKnownEnumType(string typeName)
		{
			bool result = TfPINVOKE.TfEnum_IsKnownEnumType(typeName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void _AddName(TfEnum val, string valName, string displayName)
		{
			TfPINVOKE.TfEnum__AddName__SWIG_0(getCPtr(val), valName, displayName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void _AddName(TfEnum val, string valName)
		{
			TfPINVOKE.TfEnum__AddName__SWIG_1(getCPtr(val), valName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void AddName(TfEnum val, string valName, string displayName)
		{
			TfPINVOKE.TfEnum_AddName__SWIG_0(getCPtr(val), valName, displayName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void AddName(TfEnum val, string valName)
		{
			TfPINVOKE.TfEnum_AddName__SWIG_1(getCPtr(val), valName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
