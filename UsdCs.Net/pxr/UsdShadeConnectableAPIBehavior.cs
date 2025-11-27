using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeConnectableAPIBehavior : IDisposable
	{
		public enum ConnectableNodeTypes
		{
			BasicNodes,
			DerivedContainerNodes
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdShadeConnectableAPIBehavior(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeConnectableAPIBehavior obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeConnectableAPIBehavior obj)
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

		~UsdShadeConnectableAPIBehavior()
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
						UsdShadePINVOKE.delete_UsdShadeConnectableAPIBehavior(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeConnectableAPIBehavior()
			: this(UsdShadePINVOKE.new_UsdShadeConnectableAPIBehavior__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdShadeConnectableAPIBehavior(bool isContainer, bool requiresEncapsulation)
			: this(UsdShadePINVOKE.new_UsdShadeConnectableAPIBehavior__SWIG_1(isContainer, requiresEncapsulation), cMemoryOwn: true)
		{
		}

		public virtual bool CanConnectInputToSource(UsdShadeInput arg0, UsdAttribute arg1, out string reason)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPIBehavior_CanConnectInputToSource(swigCPtr, UsdShadeInput.getCPtr(arg0), UsdAttribute.getCPtr(arg1), out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool CanConnectOutputToSource(UsdShadeOutput arg0, UsdAttribute arg1, out string reason)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPIBehavior_CanConnectOutputToSource(swigCPtr, UsdShadeOutput.getCPtr(arg0), UsdAttribute.getCPtr(arg1), out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual bool IsContainer()
		{
			return UsdShadePINVOKE.UsdShadeConnectableAPIBehavior_IsContainer(swigCPtr);
		}

		public virtual bool RequiresEncapsulation()
		{
			return UsdShadePINVOKE.UsdShadeConnectableAPIBehavior_RequiresEncapsulation(swigCPtr);
		}
	}
}
