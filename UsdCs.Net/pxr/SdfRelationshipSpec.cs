using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfRelationshipSpec : SdfPropertySpec
	{
		private HandleRef swigCPtr;

		public SdfRelationshipSpec(IntPtr cPtr, bool cMemoryOwn)
			: base(SdfPINVOKE.SdfRelationshipSpec_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfRelationshipSpec obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfRelationshipSpec obj)
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
						SdfPINVOKE.delete_SdfRelationshipSpec(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public static SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name, bool custom, SdfVariability variability)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfRelationshipSpec_New__SWIG_0(SdfPrimSpecHandle.getCPtr(owner), name, custom, (int)variability), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name, bool custom)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfRelationshipSpec_New__SWIG_1(SdfPrimSpecHandle.getCPtr(owner), name, custom), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name)
		{
			SdfRelationshipSpecHandle result = new SdfRelationshipSpecHandle(SdfPINVOKE.SdfRelationshipSpec_New__SWIG_2(SdfPrimSpecHandle.getCPtr(owner), name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_SdfTargetsProxy GetTargetPathList()
		{
			return new SWIGTYPE_p_SdfTargetsProxy(SdfPINVOKE.SdfRelationshipSpec_GetTargetPathList(swigCPtr), futureUse: true);
		}

		public bool HasTargetPathList()
		{
			return SdfPINVOKE.SdfRelationshipSpec_HasTargetPathList(swigCPtr);
		}

		public void ClearTargetPathList()
		{
			SdfPINVOKE.SdfRelationshipSpec_ClearTargetPathList(swigCPtr);
		}

		public void ReplaceTargetPath(SdfPath oldPath, SdfPath newPath)
		{
			SdfPINVOKE.SdfRelationshipSpec_ReplaceTargetPath(swigCPtr, SdfPath.getCPtr(oldPath), SdfPath.getCPtr(newPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveTargetPath(SdfPath path, bool preserveTargetOrder)
		{
			SdfPINVOKE.SdfRelationshipSpec_RemoveTargetPath__SWIG_0(swigCPtr, SdfPath.getCPtr(path), preserveTargetOrder);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveTargetPath(SdfPath path)
		{
			SdfPINVOKE.SdfRelationshipSpec_RemoveTargetPath__SWIG_1(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetNoLoadHint()
		{
			return SdfPINVOKE.SdfRelationshipSpec_GetNoLoadHint(swigCPtr);
		}

		public void SetNoLoadHint(bool noload)
		{
			SdfPINVOKE.SdfRelationshipSpec_SetNoLoadHint(swigCPtr, noload);
		}
	}
}
