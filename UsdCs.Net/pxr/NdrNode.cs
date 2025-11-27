using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrNode : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public NdrNode(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrNode obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrNode obj)
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

		~NdrNode()
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
						NdrPINVOKE.delete_NdrNode(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfToken GetIdentifier()
		{
			return new TfToken(NdrPINVOKE.NdrNode_GetIdentifier(swigCPtr), cMemoryOwn: false);
		}

		public NdrVersion GetVersion()
		{
			return new NdrVersion(NdrPINVOKE.NdrNode_GetVersion(swigCPtr), cMemoryOwn: true);
		}

		public string GetName()
		{
			return NdrPINVOKE.NdrNode_GetName(swigCPtr);
		}

		public TfToken GetFamily()
		{
			return new TfToken(NdrPINVOKE.NdrNode_GetFamily(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetContext()
		{
			return new TfToken(NdrPINVOKE.NdrNode_GetContext(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetSourceType()
		{
			return new TfToken(NdrPINVOKE.NdrNode_GetSourceType(swigCPtr), cMemoryOwn: false);
		}

		public string GetResolvedDefinitionURI()
		{
			return NdrPINVOKE.NdrNode_GetResolvedDefinitionURI(swigCPtr);
		}

		public string GetResolvedImplementationURI()
		{
			return NdrPINVOKE.NdrNode_GetResolvedImplementationURI(swigCPtr);
		}

		public string GetSourceCode()
		{
			return NdrPINVOKE.NdrNode_GetSourceCode(swigCPtr);
		}

		public virtual bool IsValid()
		{
			return NdrPINVOKE.NdrNode_IsValid(swigCPtr);
		}

		public virtual string GetInfoString()
		{
			return NdrPINVOKE.NdrNode_GetInfoString(swigCPtr);
		}

		public TfTokenVector GetInputNames()
		{
			return new TfTokenVector(NdrPINVOKE.NdrNode_GetInputNames(swigCPtr), cMemoryOwn: false);
		}

		public TfTokenVector GetOutputNames()
		{
			return new TfTokenVector(NdrPINVOKE.NdrNode_GetOutputNames(swigCPtr), cMemoryOwn: false);
		}

		public NdrProperty GetInput(TfToken inputName)
		{
			IntPtr intPtr = NdrPINVOKE.NdrNode_GetInput(swigCPtr, TfToken.getCPtr(inputName));
			NdrProperty result = ((intPtr == IntPtr.Zero) ? null : new NdrProperty(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrProperty GetOutput(TfToken outputName)
		{
			IntPtr intPtr = NdrPINVOKE.NdrNode_GetOutput(swigCPtr, TfToken.getCPtr(outputName));
			NdrProperty result = ((intPtr == IntPtr.Zero) ? null : new NdrProperty(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrTokenMap GetMetadata()
		{
			return new NdrTokenMap(NdrPINVOKE.NdrNode_GetMetadata(swigCPtr), cMemoryOwn: false);
		}
	}
}
