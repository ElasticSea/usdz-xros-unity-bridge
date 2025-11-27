using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomPrimvar : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdGeomPrimvar(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomPrimvar obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomPrimvar obj)
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

		~UsdGeomPrimvar()
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
						UsdGeomPINVOKE.delete_UsdGeomPrimvar(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomPrimvar()
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvar__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdGeomPrimvar(UsdGeomPrimvar other)
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvar__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPrimvar(UsdAttribute attr)
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvar__SWIG_2(UsdAttribute.getCPtr(attr)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetInterpolation()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomPrimvar_GetInterpolation(swigCPtr), cMemoryOwn: true);
		}

		public bool SetInterpolation(TfToken interpolation)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_SetInterpolation(swigCPtr, TfToken.getCPtr(interpolation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAuthoredInterpolation()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_HasAuthoredInterpolation(swigCPtr);
		}

		public int GetElementSize()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_GetElementSize(swigCPtr);
		}

		public bool SetElementSize(int eltSize)
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_SetElementSize(swigCPtr, eltSize);
		}

		public bool HasAuthoredElementSize()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_HasAuthoredElementSize(swigCPtr);
		}

		public static bool IsPrimvar(UsdAttribute attr)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_IsPrimvar(UsdAttribute.getCPtr(attr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsValidPrimvarName(TfToken name)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_IsValidPrimvarName(TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken StripPrimvarsName(TfToken name)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomPrimvar_StripPrimvarsName(TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsValidInterpolation(TfToken interpolation)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_IsValidInterpolation(TfToken.getCPtr(interpolation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void GetDeclarationInfo(TfToken name, SdfValueTypeName typeName, TfToken interpolation, out int elementSize)
		{
			UsdGeomPINVOKE.UsdGeomPrimvar_GetDeclarationInfo(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), TfToken.getCPtr(interpolation), out elementSize);
		}

		public UsdAttribute GetAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPrimvar_GetAttr(swigCPtr), cMemoryOwn: false);
		}

		public bool IsDefined()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_IsDefined(swigCPtr);
		}

		public bool HasValue()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_HasValue(swigCPtr);
		}

		public bool HasAuthoredValue()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_HasAuthoredValue(swigCPtr);
		}

		public TfToken GetName()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomPrimvar_GetName(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetPrimvarName()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomPrimvar_GetPrimvarName(swigCPtr), cMemoryOwn: true);
		}

		public bool NameContainsNamespaces()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_NameContainsNamespaces(swigCPtr);
		}

		public TfToken GetBaseName()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomPrimvar_GetBaseName(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetNamespace()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomPrimvar_GetNamespace(swigCPtr), cMemoryOwn: true);
		}

		public StdStringVector SplitName()
		{
			return new StdStringVector(UsdGeomPINVOKE.UsdGeomPrimvar_SplitName(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(UsdGeomPINVOKE.UsdGeomPrimvar_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		public bool GetTimeSamples(StdDoubleVector times)
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_GetTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
		}

		public bool ValueMightBeTimeVarying()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_ValueMightBeTimeVarying(swigCPtr);
		}

		public bool SetIndices(VtIntArray indices, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_SetIndices__SWIG_0(swigCPtr, VtIntArray.getCPtr(indices), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetIndices(VtIntArray indices)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_SetIndices__SWIG_1(swigCPtr, VtIntArray.getCPtr(indices));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetIndices(VtIntArray indices, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_GetIndices__SWIG_0(swigCPtr, VtIntArray.getCPtr(indices), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetIndices(VtIntArray indices)
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_GetIndices__SWIG_1(swigCPtr, VtIntArray.getCPtr(indices));
		}

		public void BlockIndices()
		{
			UsdGeomPINVOKE.UsdGeomPrimvar_BlockIndices(swigCPtr);
		}

		public bool IsIndexed()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_IsIndexed(swigCPtr);
		}

		public UsdAttribute GetIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPrimvar_GetIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIndicesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPrimvar_CreateIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public bool SetUnauthoredValuesIndex(int unauthoredValuesIndex)
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_SetUnauthoredValuesIndex(swigCPtr, unauthoredValuesIndex);
		}

		public int GetUnauthoredValuesIndex()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_GetUnauthoredValuesIndex(swigCPtr);
		}

		public bool ComputeFlattened(VtValue value, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_ComputeFlattened__SWIG_2(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputeFlattened(VtValue value)
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_ComputeFlattened__SWIG_3(swigCPtr, VtValue.getCPtr(value));
		}

		public static bool ComputeFlattened(VtValue value, VtValue attrVal, VtIntArray indices, out string errString)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_ComputeFlattened__SWIG_4(VtValue.getCPtr(value), VtValue.getCPtr(attrVal), VtIntArray.getCPtr(indices), out errString);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsIdTarget()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvar_IsIdTarget(swigCPtr);
		}

		public bool SetIdTarget(SdfPath path)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPrimvar_SetIdTarget(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
