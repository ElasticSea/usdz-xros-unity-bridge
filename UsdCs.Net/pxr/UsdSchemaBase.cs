using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSchemaBase : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractBase;

		public UsdSchemaBase(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSchemaBase obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSchemaBase obj)
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

		~UsdSchemaBase()
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
						UsdPINVOKE.delete_UsdSchemaBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool IsConcrete()
		{
			return UsdPINVOKE.UsdSchemaBase_IsConcrete(swigCPtr);
		}

		public bool IsTyped()
		{
			return UsdPINVOKE.UsdSchemaBase_IsTyped(swigCPtr);
		}

		public bool IsAPISchema()
		{
			return UsdPINVOKE.UsdSchemaBase_IsAPISchema(swigCPtr);
		}

		public bool IsAppliedAPISchema()
		{
			return UsdPINVOKE.UsdSchemaBase_IsAppliedAPISchema(swigCPtr);
		}

		public bool IsMultipleApplyAPISchema()
		{
			return UsdPINVOKE.UsdSchemaBase_IsMultipleApplyAPISchema(swigCPtr);
		}

		public UsdSchemaKind GetSchemaKind()
		{
			return (UsdSchemaKind)UsdPINVOKE.UsdSchemaBase_GetSchemaKind(swigCPtr);
		}

		public UsdSchemaBase(UsdPrim prim)
			: this(UsdPINVOKE.new_UsdSchemaBase__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSchemaBase()
			: this(UsdPINVOKE.new_UsdSchemaBase__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdSchemaBase(UsdSchemaBase otherSchema)
			: this(UsdPINVOKE.new_UsdSchemaBase__SWIG_2(getCPtr(otherSchema)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdPINVOKE.UsdSchemaBase_GetPrim(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(UsdPINVOKE.UsdSchemaBase_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_UsdPrimDefinition GetSchemaClassPrimDefinition()
		{
			IntPtr intPtr = UsdPINVOKE.UsdSchemaBase_GetSchemaClassPrimDefinition(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_UsdPrimDefinition(intPtr, futureUse: false);
		}

		public static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdPINVOKE.UsdSchemaBase_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdSchemaBase_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		private bool _IsValid()
		{
			return UsdPINVOKE.UsdSchemaBase__IsValid(swigCPtr);
		}

		public static implicit operator bool(UsdSchemaBase obj)
		{
			return obj._IsValid();
		}

		public static bool Equals(UsdSchemaBase lhs, UsdSchemaBase rhs)
		{
			bool result = UsdPINVOKE.UsdSchemaBase_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override int GetHashCode()
		{
			return UsdPINVOKE.UsdSchemaBase_GetHashCode(swigCPtr);
		}

		public static bool operator ==(UsdSchemaBase lhs, UsdSchemaBase rhs)
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

		public static bool operator !=(UsdSchemaBase lhs, UsdSchemaBase rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as UsdSchemaBase);
		}
	}
}
