using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdrShaderNode : NdrNode
	{
		private HandleRef swigCPtr;

		public SdrShaderNode(IntPtr cPtr, bool cMemoryOwn)
			: base(SdrPINVOKE.SdrShaderNode_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdrShaderNode obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdrShaderNode obj)
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
						SdrPINVOKE.delete_SdrShaderNode(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public SdrShaderProperty GetShaderInput(TfToken inputName)
		{
			IntPtr intPtr = SdrPINVOKE.SdrShaderNode_GetShaderInput(swigCPtr, TfToken.getCPtr(inputName));
			SdrShaderProperty result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderProperty(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderProperty GetShaderOutput(TfToken outputName)
		{
			IntPtr intPtr = SdrPINVOKE.SdrShaderNode_GetShaderOutput(swigCPtr, TfToken.getCPtr(outputName));
			SdrShaderProperty result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderProperty(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetAssetIdentifierInputNames()
		{
			return new TfTokenVector(SdrPINVOKE.SdrShaderNode_GetAssetIdentifierInputNames(swigCPtr), cMemoryOwn: true);
		}

		public SdrShaderProperty GetDefaultInput()
		{
			IntPtr intPtr = SdrPINVOKE.SdrShaderNode_GetDefaultInput(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdrShaderProperty(intPtr, cMemoryOwn: false);
		}

		public TfToken GetLabel()
		{
			return new TfToken(SdrPINVOKE.SdrShaderNode_GetLabel(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetCategory()
		{
			return new TfToken(SdrPINVOKE.SdrShaderNode_GetCategory(swigCPtr), cMemoryOwn: false);
		}

		public string GetRole()
		{
			return SdrPINVOKE.SdrShaderNode_GetRole(swigCPtr);
		}

		public string GetHelp()
		{
			return SdrPINVOKE.SdrShaderNode_GetHelp(swigCPtr);
		}

		public TfTokenVector GetDepartments()
		{
			return new TfTokenVector(SdrPINVOKE.SdrShaderNode_GetDepartments(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetPages()
		{
			return new TfTokenVector(SdrPINVOKE.SdrShaderNode_GetPages(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetPrimvars()
		{
			return new TfTokenVector(SdrPINVOKE.SdrShaderNode_GetPrimvars(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetAdditionalPrimvarProperties()
		{
			return new TfTokenVector(SdrPINVOKE.SdrShaderNode_GetAdditionalPrimvarProperties(swigCPtr), cMemoryOwn: false);
		}

		public string GetImplementationName()
		{
			return SdrPINVOKE.SdrShaderNode_GetImplementationName(swigCPtr);
		}

		public TfTokenVector GetPropertyNamesForPage(string pageName)
		{
			TfTokenVector result = new TfTokenVector(SdrPINVOKE.SdrShaderNode_GetPropertyNamesForPage(swigCPtr, pageName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetAllVstructNames()
		{
			return new TfTokenVector(SdrPINVOKE.SdrShaderNode_GetAllVstructNames(swigCPtr), cMemoryOwn: true);
		}
	}
}
