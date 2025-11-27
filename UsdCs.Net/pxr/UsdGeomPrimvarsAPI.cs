using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomPrimvarsAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.NonAppliedAPI;

		public UsdGeomPrimvarsAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomPrimvarsAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomPrimvarsAPI obj)
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
						UsdGeomPINVOKE.delete_UsdGeomPrimvarsAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomPrimvarsAPI(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvarsAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPrimvarsAPI()
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvarsAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomPrimvarsAPI(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvarsAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdGeomPrimvarsAPI Get(UsdStage stage, SdfPath path)
		{
			UsdGeomPrimvarsAPI result = new UsdGeomPrimvarsAPI(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar CreatePrimvar(TfToken name, SdfValueTypeName typeName, TfToken interpolation, int elementSize)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_0(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), TfToken.getCPtr(interpolation), elementSize), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar CreatePrimvar(TfToken name, SdfValueTypeName typeName, TfToken interpolation)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_1(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), TfToken.getCPtr(interpolation)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar CreatePrimvar(TfToken name, SdfValueTypeName typeName)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_2(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemovePrimvar(TfToken name)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvarsAPI_RemovePrimvar(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void BlockPrimvar(TfToken name)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarsAPI_BlockPrimvar(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPrimvar GetPrimvar(TfToken name)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_GetPrimvar(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvarVector GetPrimvars()
		{
			return new UsdGeomPrimvarVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_GetPrimvars(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvarVector GetAuthoredPrimvars()
		{
			return new UsdGeomPrimvarVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_GetAuthoredPrimvars(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvarVector GetPrimvarsWithValues()
		{
			return new UsdGeomPrimvarVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_GetPrimvarsWithValues(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvarVector GetPrimvarsWithAuthoredValues()
		{
			return new UsdGeomPrimvarVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_GetPrimvarsWithAuthoredValues(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvarVector FindInheritablePrimvars()
		{
			return new UsdGeomPrimvarVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_FindInheritablePrimvars(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvarVector FindIncrementallyInheritablePrimvars(UsdGeomPrimvarVector inheritedFromAncestors)
		{
			UsdGeomPrimvarVector result = new UsdGeomPrimvarVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_FindIncrementallyInheritablePrimvars(swigCPtr, UsdGeomPrimvarVector.getCPtr(inheritedFromAncestors)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar FindPrimvarWithInheritance(TfToken name)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_FindPrimvarWithInheritance__SWIG_0(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvar FindPrimvarWithInheritance(TfToken name, UsdGeomPrimvarVector inheritedFromAncestors)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_FindPrimvarWithInheritance__SWIG_1(swigCPtr, TfToken.getCPtr(name), UsdGeomPrimvarVector.getCPtr(inheritedFromAncestors)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomPrimvarVector FindPrimvarsWithInheritance()
		{
			return new UsdGeomPrimvarVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_FindPrimvarsWithInheritance__SWIG_0(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomPrimvarVector FindPrimvarsWithInheritance(UsdGeomPrimvarVector inheritedFromAncestors)
		{
			UsdGeomPrimvarVector result = new UsdGeomPrimvarVector(UsdGeomPINVOKE.UsdGeomPrimvarsAPI_FindPrimvarsWithInheritance__SWIG_1(swigCPtr, UsdGeomPrimvarVector.getCPtr(inheritedFromAncestors)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasPrimvar(TfToken name)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvarsAPI_HasPrimvar(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasPossiblyInheritedPrimvar(TfToken name)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvarsAPI_HasPossiblyInheritedPrimvar(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanContainPropertyName(TfToken name)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvarsAPI_CanContainPropertyName(TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
