using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdVolVolume : UsdGeomGprim
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdVolVolume(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdVolPINVOKE.UsdVolVolume_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdVolVolume obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdVolVolume obj)
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
						UsdVolPINVOKE.delete_UsdVolVolume(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdVolVolume(UsdPrim prim)
			: this(UsdVolPINVOKE.new_UsdVolVolume__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdVolVolume()
			: this(UsdVolPINVOKE.new_UsdVolVolume__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdVolVolume(UsdSchemaBase schemaObj)
			: this(UsdVolPINVOKE.new_UsdVolVolume__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolVolume_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolVolume_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdVolVolume Get(UsdStage stage, SdfPath path)
		{
			UsdVolVolume result = new UsdVolVolume(UsdVolPINVOKE.UsdVolVolume_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdVolVolume Define(UsdStage stage, SdfPath path)
		{
			UsdVolVolume result = new UsdVolVolume(UsdVolPINVOKE.UsdVolVolume_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__mapT_TfToken_SdfPath_std__lessT_TfToken_t_t GetFieldPaths()
		{
			return new SWIGTYPE_p_std__mapT_TfToken_SdfPath_std__lessT_TfToken_t_t(UsdVolPINVOKE.UsdVolVolume_GetFieldPaths(swigCPtr), futureUse: true);
		}

		public bool HasFieldRelationship(TfToken name)
		{
			bool result = UsdVolPINVOKE.UsdVolVolume_HasFieldRelationship(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath GetFieldPath(TfToken name)
		{
			SdfPath result = new SdfPath(UsdVolPINVOKE.UsdVolVolume_GetFieldPath(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CreateFieldRelationship(TfToken name, SdfPath fieldPath)
		{
			bool result = UsdVolPINVOKE.UsdVolVolume_CreateFieldRelationship(swigCPtr, TfToken.getCPtr(name), SdfPath.getCPtr(fieldPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool BlockFieldRelationship(TfToken name)
		{
			bool result = UsdVolPINVOKE.UsdVolVolume_BlockFieldRelationship(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
