using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeConnectionSourceInfo : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdShadeConnectableAPI source
		{
			get
			{
				IntPtr intPtr = UsdShadePINVOKE.UsdShadeConnectionSourceInfo_source_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new UsdShadeConnectableAPI(intPtr, cMemoryOwn: false);
			}
			set
			{
				UsdShadePINVOKE.UsdShadeConnectionSourceInfo_source_set(swigCPtr, UsdShadeConnectableAPI.getCPtr(value));
			}
		}

		public TfToken sourceName
		{
			get
			{
				IntPtr intPtr = UsdShadePINVOKE.UsdShadeConnectionSourceInfo_sourceName_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				UsdShadePINVOKE.UsdShadeConnectionSourceInfo_sourceName_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public UsdShadeAttributeType sourceType
		{
			get
			{
				return (UsdShadeAttributeType)UsdShadePINVOKE.UsdShadeConnectionSourceInfo_sourceType_get(swigCPtr);
			}
			set
			{
				UsdShadePINVOKE.UsdShadeConnectionSourceInfo_sourceType_set(swigCPtr, (int)value);
			}
		}

		public SdfValueTypeName typeName
		{
			get
			{
				IntPtr intPtr = UsdShadePINVOKE.UsdShadeConnectionSourceInfo_typeName_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfValueTypeName(intPtr, cMemoryOwn: false);
			}
			set
			{
				UsdShadePINVOKE.UsdShadeConnectionSourceInfo_typeName_set(swigCPtr, SdfValueTypeName.getCPtr(value));
			}
		}

		public UsdShadeConnectionSourceInfo(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeConnectionSourceInfo obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeConnectionSourceInfo obj)
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

		~UsdShadeConnectionSourceInfo()
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
						UsdShadePINVOKE.delete_UsdShadeConnectionSourceInfo(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeConnectionSourceInfo()
			: this(UsdShadePINVOKE.new_UsdShadeConnectionSourceInfo__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdShadeConnectionSourceInfo(UsdShadeConnectableAPI source_, TfToken sourceName_, UsdShadeAttributeType sourceType_, SdfValueTypeName typeName_)
			: this(UsdShadePINVOKE.new_UsdShadeConnectionSourceInfo__SWIG_1(UsdShadeConnectableAPI.getCPtr(source_), TfToken.getCPtr(sourceName_), (int)sourceType_, SdfValueTypeName.getCPtr(typeName_)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectionSourceInfo(UsdShadeConnectableAPI source_, TfToken sourceName_, UsdShadeAttributeType sourceType_)
			: this(UsdShadePINVOKE.new_UsdShadeConnectionSourceInfo__SWIG_2(UsdShadeConnectableAPI.getCPtr(source_), TfToken.getCPtr(sourceName_), (int)sourceType_), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectionSourceInfo(UsdShadeInput input)
			: this(UsdShadePINVOKE.new_UsdShadeConnectionSourceInfo__SWIG_3(UsdShadeInput.getCPtr(input)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectionSourceInfo(UsdShadeOutput output)
			: this(UsdShadePINVOKE.new_UsdShadeConnectionSourceInfo__SWIG_4(UsdShadeOutput.getCPtr(output)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectionSourceInfo(UsdStage stage, SdfPath sourcePath)
			: this(UsdShadePINVOKE.new_UsdShadeConnectionSourceInfo__SWIG_5(UsdStage.getCPtr(stage), SdfPath.getCPtr(sourcePath)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsValid()
		{
			return UsdShadePINVOKE.UsdShadeConnectionSourceInfo_IsValid(swigCPtr);
		}
	}
}
