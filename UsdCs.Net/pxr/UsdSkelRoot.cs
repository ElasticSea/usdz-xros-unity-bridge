using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelRoot : UsdGeomBoundable
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdSkelRoot(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdSkelPINVOKE.UsdSkelRoot_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelRoot obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelRoot obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						UsdSkelPINVOKE.delete_UsdSkelRoot(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdSkelRoot(UsdPrim prim)
			: this(UsdSkelPINVOKE.new_UsdSkelRoot__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelRoot()
			: this(UsdSkelPINVOKE.new_UsdSkelRoot__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdSkelRoot(UsdSchemaBase schemaObj)
			: this(UsdSkelPINVOKE.new_UsdSkelRoot__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelRoot_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelRoot_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdSkelRoot Get(UsdStage stage, SdfPath path)
		{
			UsdSkelRoot result = new UsdSkelRoot(UsdSkelPINVOKE.UsdSkelRoot_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdSkelRoot Define(UsdStage stage, SdfPath path)
		{
			UsdSkelRoot result = new UsdSkelRoot(UsdSkelPINVOKE.UsdSkelRoot_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdSkelRoot Find(UsdPrim prim)
		{
			UsdSkelRoot result = new UsdSkelRoot(UsdSkelPINVOKE.UsdSkelRoot_Find(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
