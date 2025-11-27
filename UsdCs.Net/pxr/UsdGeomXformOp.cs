using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomXformOp : IDisposable
	{
		public enum Type
		{
			TypeInvalid,
			TypeTranslate,
			TypeScale,
			TypeRotateX,
			TypeRotateY,
			TypeRotateZ,
			TypeRotateXYZ,
			TypeRotateXZY,
			TypeRotateYXZ,
			TypeRotateYZX,
			TypeRotateZXY,
			TypeRotateZYX,
			TypeOrient,
			TypeTransform
		}

		public enum Precision
		{
			PrecisionDouble,
			PrecisionFloat,
			PrecisionHalf
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdGeomXformOp(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomXformOp obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomXformOp obj)
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

		~UsdGeomXformOp()
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
						UsdGeomPINVOKE.delete_UsdGeomXformOp(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomXformOp()
			: this(UsdGeomPINVOKE.new_UsdGeomXformOp__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdGeomXformOp(UsdAttribute attr, bool isInverseOp)
			: this(UsdGeomPINVOKE.new_UsdGeomXformOp__SWIG_1(UsdAttribute.getCPtr(attr), isInverseOp), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomXformOp(UsdAttribute attr)
			: this(UsdGeomPINVOKE.new_UsdGeomXformOp__SWIG_2(UsdAttribute.getCPtr(attr)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool IsXformOp(UsdAttribute attr)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformOp_IsXformOp__SWIG_0(UsdAttribute.getCPtr(attr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsXformOp(TfToken attrName)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformOp_IsXformOp__SWIG_1(TfToken.getCPtr(attrName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken GetOpTypeToken(Type opType)
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomXformOp_GetOpTypeToken((int)opType), cMemoryOwn: false);
		}

		public static Type GetOpTypeEnum(TfToken opTypeToken)
		{
			Type result = (Type)UsdGeomPINVOKE.UsdGeomXformOp_GetOpTypeEnum(TfToken.getCPtr(opTypeToken));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static Precision GetPrecisionFromValueTypeName(SdfValueTypeName typeName)
		{
			Precision result = (Precision)UsdGeomPINVOKE.UsdGeomXformOp_GetPrecisionFromValueTypeName(SdfValueTypeName.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfValueTypeName GetValueTypeName(Type opType, Precision precision)
		{
			return new SdfValueTypeName(UsdGeomPINVOKE.UsdGeomXformOp_GetValueTypeName((int)opType, (int)precision), cMemoryOwn: false);
		}

		public static TfToken GetOpName(Type opType, TfToken opSuffix, bool inverse)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomXformOp_GetOpName__SWIG_0((int)opType, TfToken.getCPtr(opSuffix), inverse), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken GetOpName(Type opType, TfToken opSuffix)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomXformOp_GetOpName__SWIG_1((int)opType, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken GetOpName(Type opType)
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomXformOp_GetOpName__SWIG_2((int)opType), cMemoryOwn: true);
		}

		public Type GetOpType()
		{
			return (Type)UsdGeomPINVOKE.UsdGeomXformOp_GetOpType(swigCPtr);
		}

		public Precision GetPrecision()
		{
			return (Precision)UsdGeomPINVOKE.UsdGeomXformOp_GetPrecision(swigCPtr);
		}

		public bool IsInverseOp()
		{
			return UsdGeomPINVOKE.UsdGeomXformOp_IsInverseOp(swigCPtr);
		}

		public TfToken GetOpName()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomXformOp_GetOpName__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public bool HasSuffix(TfToken suffix)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformOp_HasSuffix(swigCPtr, TfToken.getCPtr(suffix));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfMatrix4d GetOpTransform(Type opType, VtValue opVal, bool isInverseOp)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomXformOp_GetOpTransform__SWIG_0((int)opType, VtValue.getCPtr(opVal), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfMatrix4d GetOpTransform(Type opType, VtValue opVal)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomXformOp_GetOpTransform__SWIG_1((int)opType, VtValue.getCPtr(opVal)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d GetOpTransform(UsdTimeCode time)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomXformOp_GetOpTransform__SWIG_2(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool MightBeTimeVarying()
		{
			return UsdGeomPINVOKE.UsdGeomXformOp_MightBeTimeVarying(swigCPtr);
		}

		public UsdAttribute GetAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomXformOp_GetAttr(swigCPtr), cMemoryOwn: false);
		}

		public bool IsDefined()
		{
			return UsdGeomPINVOKE.UsdGeomXformOp_IsDefined(swigCPtr);
		}

		public TfToken GetName()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomXformOp_GetName(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetBaseName()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomXformOp_GetBaseName(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetNamespace()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomXformOp_GetNamespace(swigCPtr), cMemoryOwn: true);
		}

		public StdStringVector SplitName()
		{
			return new StdStringVector(UsdGeomPINVOKE.UsdGeomXformOp_SplitName(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(UsdGeomPINVOKE.UsdGeomXformOp_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		public bool GetTimeSamples(StdDoubleVector times)
		{
			return UsdGeomPINVOKE.UsdGeomXformOp_GetTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
		}

		public uint GetNumTimeSamples()
		{
			return UsdGeomPINVOKE.UsdGeomXformOp_GetNumTimeSamples(swigCPtr);
		}

		public bool Set(GfMatrix4d value, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformOp_Set__SWIG_2(swigCPtr, GfMatrix4d.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Set(GfMatrix4d value)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformOp_Set__SWIG_3(swigCPtr, GfMatrix4d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
