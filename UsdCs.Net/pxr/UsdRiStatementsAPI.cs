using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdRiStatementsAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdRiStatementsAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdRiPINVOKE.UsdRiStatementsAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdRiStatementsAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdRiStatementsAPI obj)
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
						UsdRiPINVOKE.delete_UsdRiStatementsAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdRiStatementsAPI(UsdPrim prim)
			: this(UsdRiPINVOKE.new_UsdRiStatementsAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdRiStatementsAPI()
			: this(UsdRiPINVOKE.new_UsdRiStatementsAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdRiStatementsAPI(UsdSchemaBase schemaObj)
			: this(UsdRiPINVOKE.new_UsdRiStatementsAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdRiPINVOKE.UsdRiStatementsAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdRiPINVOKE.UsdRiStatementsAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdRiStatementsAPI Get(UsdStage stage, SdfPath path)
		{
			UsdRiStatementsAPI result = new UsdRiStatementsAPI(UsdRiPINVOKE.UsdRiStatementsAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdRiPINVOKE.UsdRiStatementsAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdRiPINVOKE.UsdRiStatementsAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdRiStatementsAPI Apply(UsdPrim prim)
		{
			UsdRiStatementsAPI result = new UsdRiStatementsAPI(UsdRiPINVOKE.UsdRiStatementsAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRiAttribute(TfToken name, string riType, string nameSpace)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiStatementsAPI_CreateRiAttribute__SWIG_0(swigCPtr, TfToken.getCPtr(name), riType, nameSpace), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRiAttribute(TfToken name, string riType)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiStatementsAPI_CreateRiAttribute__SWIG_1(swigCPtr, TfToken.getCPtr(name), riType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRiAttribute(TfToken name, TfType tfType, string nameSpace)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiStatementsAPI_CreateRiAttribute__SWIG_2(swigCPtr, TfToken.getCPtr(name), TfType.getCPtr(tfType), nameSpace), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRiAttribute(TfToken name, TfType tfType)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiStatementsAPI_CreateRiAttribute__SWIG_3(swigCPtr, TfToken.getCPtr(name), TfType.getCPtr(tfType)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetRiAttribute(TfToken name, string nameSpace)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiStatementsAPI_GetRiAttribute__SWIG_0(swigCPtr, TfToken.getCPtr(name), nameSpace), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetRiAttribute(TfToken name)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiStatementsAPI_GetRiAttribute__SWIG_1(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPropertyVector GetRiAttributes(string nameSpace)
		{
			UsdPropertyVector result = new UsdPropertyVector(UsdRiPINVOKE.UsdRiStatementsAPI_GetRiAttributes__SWIG_0(swigCPtr, nameSpace), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPropertyVector GetRiAttributes()
		{
			return new UsdPropertyVector(UsdRiPINVOKE.UsdRiStatementsAPI_GetRiAttributes__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static TfToken GetRiAttributeName(UsdProperty prop)
		{
			TfToken result = new TfToken(UsdRiPINVOKE.UsdRiStatementsAPI_GetRiAttributeName(UsdProperty.getCPtr(prop)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken GetRiAttributeNameSpace(UsdProperty prop)
		{
			TfToken result = new TfToken(UsdRiPINVOKE.UsdRiStatementsAPI_GetRiAttributeNameSpace(UsdProperty.getCPtr(prop)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsRiAttribute(UsdProperty prop)
		{
			bool result = UsdRiPINVOKE.UsdRiStatementsAPI_IsRiAttribute(UsdProperty.getCPtr(prop));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string MakeRiAttributePropertyName(string attrName)
		{
			string result = UsdRiPINVOKE.UsdRiStatementsAPI_MakeRiAttributePropertyName(attrName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetCoordinateSystem(string coordSysName)
		{
			UsdRiPINVOKE.UsdRiStatementsAPI_SetCoordinateSystem(swigCPtr, coordSysName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetCoordinateSystem()
		{
			return UsdRiPINVOKE.UsdRiStatementsAPI_GetCoordinateSystem(swigCPtr);
		}

		public bool HasCoordinateSystem()
		{
			return UsdRiPINVOKE.UsdRiStatementsAPI_HasCoordinateSystem(swigCPtr);
		}

		public void SetScopedCoordinateSystem(string coordSysName)
		{
			UsdRiPINVOKE.UsdRiStatementsAPI_SetScopedCoordinateSystem(swigCPtr, coordSysName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetScopedCoordinateSystem()
		{
			return UsdRiPINVOKE.UsdRiStatementsAPI_GetScopedCoordinateSystem(swigCPtr);
		}

		public bool HasScopedCoordinateSystem()
		{
			return UsdRiPINVOKE.UsdRiStatementsAPI_HasScopedCoordinateSystem(swigCPtr);
		}

		public bool GetModelCoordinateSystems(SdfPathVector targets)
		{
			return UsdRiPINVOKE.UsdRiStatementsAPI_GetModelCoordinateSystems(swigCPtr, SdfPathVector.getCPtr(targets));
		}

		public bool GetModelScopedCoordinateSystems(SdfPathVector targets)
		{
			return UsdRiPINVOKE.UsdRiStatementsAPI_GetModelScopedCoordinateSystems(swigCPtr, SdfPathVector.getCPtr(targets));
		}
	}
}
