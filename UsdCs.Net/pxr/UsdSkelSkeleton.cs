using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelSkeleton : UsdGeomBoundable
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdSkelSkeleton(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdSkelPINVOKE.UsdSkelSkeleton_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelSkeleton obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelSkeleton obj)
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
						UsdSkelPINVOKE.delete_UsdSkelSkeleton(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdSkelSkeleton(UsdPrim prim)
			: this(UsdSkelPINVOKE.new_UsdSkelSkeleton__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelSkeleton()
			: this(UsdSkelPINVOKE.new_UsdSkelSkeleton__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdSkelSkeleton(UsdSchemaBase schemaObj)
			: this(UsdSkelPINVOKE.new_UsdSkelSkeleton__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelSkeleton_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelSkeleton_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdSkelSkeleton Get(UsdStage stage, SdfPath path)
		{
			UsdSkelSkeleton result = new UsdSkelSkeleton(UsdSkelPINVOKE.UsdSkelSkeleton_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdSkelSkeleton Define(UsdStage stage, SdfPath path)
		{
			UsdSkelSkeleton result = new UsdSkelSkeleton(UsdSkelPINVOKE.UsdSkelSkeleton_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetJointsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_GetJointsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateJointsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateJointsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateJointsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateJointsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetJointNamesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_GetJointNamesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateJointNamesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateJointNamesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointNamesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateJointNamesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointNamesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateJointNamesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetBindTransformsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_GetBindTransformsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateBindTransformsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBindTransformsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBindTransformsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetRestTransformsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_GetRestTransformsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateRestTransformsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRestTransformsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRestTransformsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
