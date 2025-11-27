using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelPackedJointAnimation : UsdSkelAnimation
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdSkelPackedJointAnimation(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdSkelPINVOKE.UsdSkelPackedJointAnimation_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelPackedJointAnimation obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelPackedJointAnimation obj)
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
						UsdSkelPINVOKE.delete_UsdSkelPackedJointAnimation(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdSkelPackedJointAnimation(UsdPrim prim)
			: this(UsdSkelPINVOKE.new_UsdSkelPackedJointAnimation__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelPackedJointAnimation()
			: this(UsdSkelPINVOKE.new_UsdSkelPackedJointAnimation__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdSkelPackedJointAnimation(UsdSchemaBase schemaObj)
			: this(UsdSkelPINVOKE.new_UsdSkelPackedJointAnimation__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelPackedJointAnimation_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelPackedJointAnimation_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdSkelPackedJointAnimation Get(UsdStage stage, SdfPath path)
		{
			UsdSkelPackedJointAnimation result = new UsdSkelPackedJointAnimation(UsdSkelPINVOKE.UsdSkelPackedJointAnimation_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new static UsdSkelPackedJointAnimation Define(UsdStage stage, SdfPath path)
		{
			UsdSkelPackedJointAnimation result = new UsdSkelPackedJointAnimation(UsdSkelPINVOKE.UsdSkelPackedJointAnimation_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
