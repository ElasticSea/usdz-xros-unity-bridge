using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelTopology : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdSkelTopology(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelTopology obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelTopology obj)
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

		~UsdSkelTopology()
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
						UsdSkelPINVOKE.delete_UsdSkelTopology(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelTopology()
			: this(UsdSkelPINVOKE.new_UsdSkelTopology__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkelTopology(SWIGTYPE_p_TfSpanT_TfToken_const_t paths)
			: this(UsdSkelPINVOKE.new_UsdSkelTopology__SWIG_1(SWIGTYPE_p_TfSpanT_TfToken_const_t.getCPtr(paths)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelTopology(SWIGTYPE_p_TfSpanT_SdfPath_const_t paths)
			: this(UsdSkelPINVOKE.new_UsdSkelTopology__SWIG_2(SWIGTYPE_p_TfSpanT_SdfPath_const_t.getCPtr(paths)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelTopology(VtIntArray parentIndices)
			: this(UsdSkelPINVOKE.new_UsdSkelTopology__SWIG_3(VtIntArray.getCPtr(parentIndices)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Validate(out string reason)
		{
			bool result = UsdSkelPINVOKE.UsdSkelTopology_Validate__SWIG_0(swigCPtr, out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Validate()
		{
			return UsdSkelPINVOKE.UsdSkelTopology_Validate__SWIG_1(swigCPtr);
		}

		public VtIntArray GetParentIndices()
		{
			return new VtIntArray(UsdSkelPINVOKE.UsdSkelTopology_GetParentIndices(swigCPtr), cMemoryOwn: false);
		}

		public uint GetNumJoints()
		{
			return UsdSkelPINVOKE.UsdSkelTopology_GetNumJoints(swigCPtr);
		}

		public uint size()
		{
			return UsdSkelPINVOKE.UsdSkelTopology_size(swigCPtr);
		}

		public int GetParent(uint index)
		{
			return UsdSkelPINVOKE.UsdSkelTopology_GetParent(swigCPtr, index);
		}

		public bool IsRoot(uint index)
		{
			return UsdSkelPINVOKE.UsdSkelTopology_IsRoot(swigCPtr, index);
		}

		public UsdSkelTopology(VtTokenArray topology)
			: this(UsdSkelPINVOKE.new_UsdSkelTopology__SWIG_4(VtTokenArray.getCPtr(topology)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
