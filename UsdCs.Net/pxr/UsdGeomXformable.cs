using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomXformable : UsdGeomImageable
	{
		public class XformQuery : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public XformQuery(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(XformQuery obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(XformQuery obj)
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

			~XformQuery()
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
							UsdGeomPINVOKE.delete_UsdGeomXformable_XformQuery(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public XformQuery()
				: this(UsdGeomPINVOKE.new_UsdGeomXformable_XformQuery__SWIG_0(), cMemoryOwn: true)
			{
			}

			public XformQuery(UsdGeomXformable xformable)
				: this(UsdGeomPINVOKE.new_UsdGeomXformable_XformQuery__SWIG_1(UsdGeomXformable.getCPtr(xformable)), cMemoryOwn: true)
			{
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public bool GetLocalTransformation(GfMatrix4d transform, UsdTimeCode time)
			{
				bool result = UsdGeomPINVOKE.UsdGeomXformable_XformQuery_GetLocalTransformation(swigCPtr, GfMatrix4d.getCPtr(transform), UsdTimeCode.getCPtr(time));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public bool GetResetXformStack()
			{
				return UsdGeomPINVOKE.UsdGeomXformable_XformQuery_GetResetXformStack(swigCPtr);
			}

			public bool TransformMightBeTimeVarying()
			{
				return UsdGeomPINVOKE.UsdGeomXformable_XformQuery_TransformMightBeTimeVarying(swigCPtr);
			}

			public bool HasNonEmptyXformOpOrder()
			{
				return UsdGeomPINVOKE.UsdGeomXformable_XformQuery_HasNonEmptyXformOpOrder(swigCPtr);
			}

			public bool GetTimeSamples(StdDoubleVector times)
			{
				return UsdGeomPINVOKE.UsdGeomXformable_XformQuery_GetTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
			}

			public bool IsAttributeIncludedInLocalTransform(TfToken attrName)
			{
				bool result = UsdGeomPINVOKE.UsdGeomXformable_XformQuery_IsAttributeIncludedInLocalTransform(swigCPtr, TfToken.getCPtr(attrName));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdGeomXformable(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomXformable_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomXformable obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomXformable obj)
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
						UsdGeomPINVOKE.delete_UsdGeomXformable(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomXformable(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomXformable__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomXformable()
			: this(UsdGeomPINVOKE.new_UsdGeomXformable__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomXformable(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomXformable__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomXformable_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomXformable_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomXformable Get(UsdStage stage, SdfPath path)
		{
			UsdGeomXformable result = new UsdGeomXformable(UsdGeomPINVOKE.UsdGeomXformable_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetXformOpOrderAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomXformable_GetXformOpOrderAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateXformOpOrderAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomXformable_CreateXformOpOrderAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateXformOpOrderAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomXformable_CreateXformOpOrderAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateXformOpOrderAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomXformable_CreateXformOpOrderAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddXformOp(UsdGeomXformOp.Type opType, UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddXformOp__SWIG_0(swigCPtr, (int)opType, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddXformOp(UsdGeomXformOp.Type opType, UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddXformOp__SWIG_1(swigCPtr, (int)opType, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddXformOp(UsdGeomXformOp.Type opType, UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddXformOp__SWIG_2(swigCPtr, (int)opType, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddXformOp(UsdGeomXformOp.Type opType)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddXformOp__SWIG_3(swigCPtr, (int)opType), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddTranslateOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddTranslateOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddTranslateOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddTranslateOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddTranslateOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddTranslateOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddTranslateOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddTranslateOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddScaleOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddScaleOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddScaleOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddScaleOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddScaleOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddScaleOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddScaleOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddScaleOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateXOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateXOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateYOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateYOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateZOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateZOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateXYZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXYZOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateXYZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXYZOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateXYZOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXYZOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateXYZOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXYZOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateXZYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXZYOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateXZYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXZYOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateXZYOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXZYOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateXZYOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateXZYOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateYXZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYXZOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateYXZOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYXZOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateYXZOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYXZOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateYXZOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYXZOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateYZXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYZXOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateYZXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYZXOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateYZXOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYZXOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateYZXOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateYZXOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateZXYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZXYOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateZXYOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZXYOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateZXYOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZXYOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateZXYOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZXYOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateZYXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZYXOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateZYXOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZYXOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddRotateZYXOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZYXOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddRotateZYXOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddRotateZYXOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddOrientOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddOrientOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddOrientOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddOrientOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddOrientOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddOrientOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddOrientOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddOrientOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddTransformOp(UsdGeomXformOp.Precision precision, TfToken opSuffix, bool isInverseOp)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddTransformOp__SWIG_0(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix), isInverseOp), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddTransformOp(UsdGeomXformOp.Precision precision, TfToken opSuffix)
		{
			UsdGeomXformOp result = new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddTransformOp__SWIG_1(swigCPtr, (int)precision, TfToken.getCPtr(opSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOp AddTransformOp(UsdGeomXformOp.Precision precision)
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddTransformOp__SWIG_2(swigCPtr, (int)precision), cMemoryOwn: true);
		}

		public UsdGeomXformOp AddTransformOp()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_AddTransformOp__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public bool SetResetXformStack(bool resetXform)
		{
			return UsdGeomPINVOKE.UsdGeomXformable_SetResetXformStack(swigCPtr, resetXform);
		}

		public bool GetResetXformStack()
		{
			return UsdGeomPINVOKE.UsdGeomXformable_GetResetXformStack(swigCPtr);
		}

		public bool SetXformOpOrder(UsdGeomXformOpVector orderedXformOps, bool resetXformStack)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_SetXformOpOrder__SWIG_0(swigCPtr, UsdGeomXformOpVector.getCPtr(orderedXformOps), resetXformStack);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetXformOpOrder(UsdGeomXformOpVector orderedXformOps)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_SetXformOpOrder__SWIG_1(swigCPtr, UsdGeomXformOpVector.getCPtr(orderedXformOps));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomXformOpVector GetOrderedXformOps(out bool resetsXformStack)
		{
			return new UsdGeomXformOpVector(UsdGeomPINVOKE.UsdGeomXformable_GetOrderedXformOps(swigCPtr, out resetsXformStack), cMemoryOwn: true);
		}

		public bool ClearXformOpOrder()
		{
			return UsdGeomPINVOKE.UsdGeomXformable_ClearXformOpOrder(swigCPtr);
		}

		public UsdGeomXformOp MakeMatrixXform()
		{
			return new UsdGeomXformOp(UsdGeomPINVOKE.UsdGeomXformable_MakeMatrixXform(swigCPtr), cMemoryOwn: true);
		}

		public bool TransformMightBeTimeVarying()
		{
			return UsdGeomPINVOKE.UsdGeomXformable_TransformMightBeTimeVarying__SWIG_0(swigCPtr);
		}

		public bool TransformMightBeTimeVarying(UsdGeomXformOpVector ops)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_TransformMightBeTimeVarying__SWIG_1(swigCPtr, UsdGeomXformOpVector.getCPtr(ops));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetTimeSamples(StdDoubleVector times)
		{
			return UsdGeomPINVOKE.UsdGeomXformable_GetTimeSamples__SWIG_0(swigCPtr, StdDoubleVector.getCPtr(times));
		}

		public static bool GetTimeSamples(UsdGeomXformOpVector orderedXformOps, StdDoubleVector times)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_GetTimeSamples__SWIG_1(UsdGeomXformOpVector.getCPtr(orderedXformOps), StdDoubleVector.getCPtr(times));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetLocalTransformation(GfMatrix4d transform, out bool resetsXformStack, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_0(swigCPtr, GfMatrix4d.getCPtr(transform), out resetsXformStack, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetLocalTransformation(GfMatrix4d transform, out bool resetsXformStack)
		{
			return UsdGeomPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_1(swigCPtr, GfMatrix4d.getCPtr(transform), out resetsXformStack);
		}

		public bool GetLocalTransformation(GfMatrix4d transform, out bool resetsXformStack, UsdGeomXformOpVector ops, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_2(swigCPtr, GfMatrix4d.getCPtr(transform), out resetsXformStack, UsdGeomXformOpVector.getCPtr(ops), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetLocalTransformation(GfMatrix4d transform, out bool resetsXformStack, UsdGeomXformOpVector ops)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_3(swigCPtr, GfMatrix4d.getCPtr(transform), out resetsXformStack, UsdGeomXformOpVector.getCPtr(ops));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetLocalTransformation(GfMatrix4d transform, UsdGeomXformOpVector ops, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_GetLocalTransformation__SWIG_4(GfMatrix4d.getCPtr(transform), UsdGeomXformOpVector.getCPtr(ops), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsTransformationAffectedByAttrNamed(TfToken attrName)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformable_IsTransformationAffectedByAttrNamed(TfToken.getCPtr(attrName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
