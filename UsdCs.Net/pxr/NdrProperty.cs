using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrProperty : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public NdrProperty(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrProperty obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrProperty obj)
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

		~NdrProperty()
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
						NdrPINVOKE.delete_NdrProperty(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public NdrProperty(TfToken name, TfToken type, VtValue defaultValue, bool isOutput, uint arraySize, bool isDynamicArray, NdrTokenMap metadata)
			: this(NdrPINVOKE.new_NdrProperty(TfToken.getCPtr(name), TfToken.getCPtr(type), VtValue.getCPtr(defaultValue), isOutput, arraySize, isDynamicArray, NdrTokenMap.getCPtr(metadata)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetName()
		{
			return new TfToken(NdrPINVOKE.NdrProperty_GetName(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetTfType()
		{
			return new TfToken(NdrPINVOKE.NdrProperty_GetTfType(swigCPtr), cMemoryOwn: false);
		}

		public VtValue GetDefaultValue()
		{
			return new VtValue(NdrPINVOKE.NdrProperty_GetDefaultValue(swigCPtr), cMemoryOwn: false);
		}

		public bool IsOutput()
		{
			return NdrPINVOKE.NdrProperty_IsOutput(swigCPtr);
		}

		public bool IsArray()
		{
			return NdrPINVOKE.NdrProperty_IsArray(swigCPtr);
		}

		public bool IsDynamicArray()
		{
			return NdrPINVOKE.NdrProperty_IsDynamicArray(swigCPtr);
		}

		public int GetArraySize()
		{
			return NdrPINVOKE.NdrProperty_GetArraySize(swigCPtr);
		}

		public virtual string GetInfoString()
		{
			return NdrPINVOKE.NdrProperty_GetInfoString(swigCPtr);
		}

		public virtual NdrTokenMap GetMetadata()
		{
			return new NdrTokenMap(NdrPINVOKE.NdrProperty_GetMetadata(swigCPtr), cMemoryOwn: false);
		}

		public virtual bool IsConnectable()
		{
			return NdrPINVOKE.NdrProperty_IsConnectable(swigCPtr);
		}

		public virtual bool CanConnectTo(NdrProperty other)
		{
			bool result = NdrPINVOKE.NdrProperty_CanConnectTo(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public virtual NdrSdfTypeIndicator GetTypeAsSdfType()
		{
			return new NdrSdfTypeIndicator(NdrPINVOKE.NdrProperty_GetTypeAsSdfType(swigCPtr), cMemoryOwn: true);
		}

		public virtual VtValue GetDefaultValueAsSdfType()
		{
			return new VtValue(NdrPINVOKE.NdrProperty_GetDefaultValueAsSdfType(swigCPtr), cMemoryOwn: false);
		}
	}
}
