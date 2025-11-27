using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfValueTypeName : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfValueTypeName(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfValueTypeName obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfValueTypeName obj)
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

		~SdfValueTypeName()
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
						SdfPINVOKE.delete_SdfValueTypeName(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfValueTypeName()
			: this(SdfPINVOKE.new_SdfValueTypeName(), cMemoryOwn: true)
		{
		}

		public TfToken GetAsToken()
		{
			return new TfToken(SdfPINVOKE.SdfValueTypeName_GetAsToken(swigCPtr), cMemoryOwn: true);
		}

		public TfType GetTfType()
		{
			return new TfType(SdfPINVOKE.SdfValueTypeName_GetTfType(swigCPtr), cMemoryOwn: false);
		}

		public string GetCPPTypeName()
		{
			return SdfPINVOKE.SdfValueTypeName_GetCPPTypeName(swigCPtr);
		}

		public TfToken GetRole()
		{
			return new TfToken(SdfPINVOKE.SdfValueTypeName_GetRole(swigCPtr), cMemoryOwn: false);
		}

		public VtValue GetDefaultValue()
		{
			return new VtValue(SdfPINVOKE.SdfValueTypeName_GetDefaultValue(swigCPtr), cMemoryOwn: false);
		}

		public SdfValueTypeName GetScalarType()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfValueTypeName_GetScalarType(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetArrayType()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfValueTypeName_GetArrayType(swigCPtr), cMemoryOwn: true);
		}

		public bool IsScalar()
		{
			return SdfPINVOKE.SdfValueTypeName_IsScalar(swigCPtr);
		}

		public bool IsArray()
		{
			return SdfPINVOKE.SdfValueTypeName_IsArray(swigCPtr);
		}

		public SdfTupleDimensions GetDimensions()
		{
			return new SdfTupleDimensions(SdfPINVOKE.SdfValueTypeName_GetDimensions(swigCPtr), cMemoryOwn: true);
		}

		public uint GetHash()
		{
			return SdfPINVOKE.SdfValueTypeName_GetHash(swigCPtr);
		}

		public TfTokenVector GetAliasesAsTokens()
		{
			return new TfTokenVector(SdfPINVOKE.SdfValueTypeName_GetAliasesAsTokens(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(SdfValueTypeName lhs, SdfValueTypeName rhs)
		{
			bool result = SdfPINVOKE.SdfValueTypeName_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(SdfValueTypeName lhs, SdfValueTypeName rhs)
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

		public static bool operator !=(SdfValueTypeName lhs, SdfValueTypeName rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as SdfValueTypeName);
		}

		public override int GetHashCode()
		{
			return SdfPINVOKE.SdfValueTypeName_GetHashCode(swigCPtr);
		}
	}
}
