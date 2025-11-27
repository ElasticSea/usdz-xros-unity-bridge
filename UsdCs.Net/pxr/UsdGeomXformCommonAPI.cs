using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomXformCommonAPI : UsdAPISchemaBase
	{
		public class Ops : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public UsdGeomXformOp translateOp
			{
				get
				{
					IntPtr intPtr = UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_translateOp_get(swigCPtr);
					return (intPtr == IntPtr.Zero) ? null : new UsdGeomXformOp(intPtr, cMemoryOwn: false);
				}
				set
				{
					UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_translateOp_set(swigCPtr, UsdGeomXformOp.getCPtr(value));
				}
			}

			public UsdGeomXformOp pivotOp
			{
				get
				{
					IntPtr intPtr = UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_pivotOp_get(swigCPtr);
					return (intPtr == IntPtr.Zero) ? null : new UsdGeomXformOp(intPtr, cMemoryOwn: false);
				}
				set
				{
					UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_pivotOp_set(swigCPtr, UsdGeomXformOp.getCPtr(value));
				}
			}

			public UsdGeomXformOp rotateOp
			{
				get
				{
					IntPtr intPtr = UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_rotateOp_get(swigCPtr);
					return (intPtr == IntPtr.Zero) ? null : new UsdGeomXformOp(intPtr, cMemoryOwn: false);
				}
				set
				{
					UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_rotateOp_set(swigCPtr, UsdGeomXformOp.getCPtr(value));
				}
			}

			public UsdGeomXformOp scaleOp
			{
				get
				{
					IntPtr intPtr = UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_scaleOp_get(swigCPtr);
					return (intPtr == IntPtr.Zero) ? null : new UsdGeomXformOp(intPtr, cMemoryOwn: false);
				}
				set
				{
					UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_scaleOp_set(swigCPtr, UsdGeomXformOp.getCPtr(value));
				}
			}

			public UsdGeomXformOp inversePivotOp
			{
				get
				{
					IntPtr intPtr = UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_inversePivotOp_get(swigCPtr);
					return (intPtr == IntPtr.Zero) ? null : new UsdGeomXformOp(intPtr, cMemoryOwn: false);
				}
				set
				{
					UsdGeomPINVOKE.UsdGeomXformCommonAPI_Ops_inversePivotOp_set(swigCPtr, UsdGeomXformOp.getCPtr(value));
				}
			}

			public Ops(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(Ops obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(Ops obj)
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

			~Ops()
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
							UsdGeomPINVOKE.delete_UsdGeomXformCommonAPI_Ops(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Ops()
				: this(UsdGeomPINVOKE.new_UsdGeomXformCommonAPI_Ops(), cMemoryOwn: true)
			{
			}
		}

		public enum RotationOrder
		{
			RotationOrderXYZ,
			RotationOrderXZY,
			RotationOrderYXZ,
			RotationOrderYZX,
			RotationOrderZXY,
			RotationOrderZYX
		}

		public enum OpFlags
		{
			OpNone = 0,
			OpTranslate = 1,
			OpPivot = 2,
			OpRotate = 4,
			OpScale = 8
		}

		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.NonAppliedAPI;

		public UsdGeomXformCommonAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomXformCommonAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomXformCommonAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomXformCommonAPI obj)
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
						UsdGeomPINVOKE.delete_UsdGeomXformCommonAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomXformCommonAPI(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomXformCommonAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomXformCommonAPI()
			: this(UsdGeomPINVOKE.new_UsdGeomXformCommonAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomXformCommonAPI(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomXformCommonAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomXformCommonAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomXformCommonAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdGeomXformCommonAPI Get(UsdStage stage, SdfPath path)
		{
			UsdGeomXformCommonAPI result = new UsdGeomXformCommonAPI(UsdGeomPINVOKE.UsdGeomXformCommonAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetXformVectors(GfVec3d translation, GfVec3f rotation, GfVec3f scale, GfVec3f pivot, RotationOrder rotOrder, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetXformVectors(swigCPtr, GfVec3d.getCPtr(translation), GfVec3f.getCPtr(rotation), GfVec3f.getCPtr(scale), GfVec3f.getCPtr(pivot), (int)rotOrder, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetXformVectors(out GfVec3d translation, out GfVec3f rotation, out GfVec3f scale, out GfVec3f pivot, out RotationOrder rotOrder, UsdTimeCode time)
		{
			GfVec3d gfVec3d = new GfVec3d();
			GfVec3f gfVec3f = new GfVec3f();
			GfVec3f gfVec3f2 = new GfVec3f();
			GfVec3f gfVec3f3 = new GfVec3f();
			try
			{
				bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_GetXformVectors(swigCPtr, GfVec3d.getCPtr(gfVec3d), GfVec3f.getCPtr(gfVec3f), GfVec3f.getCPtr(gfVec3f2), GfVec3f.getCPtr(gfVec3f3), out rotOrder, UsdTimeCode.getCPtr(time));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			finally
			{
				translation = gfVec3d;
				rotation = gfVec3f;
				scale = gfVec3f2;
				pivot = gfVec3f3;
			}
		}

		public bool GetXformVectorsByAccumulation(out GfVec3d translation, out GfVec3f rotation, out GfVec3f scale, out GfVec3f pivot, out RotationOrder rotOrder, UsdTimeCode time)
		{
			GfVec3d gfVec3d = new GfVec3d();
			GfVec3f gfVec3f = new GfVec3f();
			GfVec3f gfVec3f2 = new GfVec3f();
			GfVec3f gfVec3f3 = new GfVec3f();
			try
			{
				bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_GetXformVectorsByAccumulation(swigCPtr, GfVec3d.getCPtr(gfVec3d), GfVec3f.getCPtr(gfVec3f), GfVec3f.getCPtr(gfVec3f2), GfVec3f.getCPtr(gfVec3f3), out rotOrder, UsdTimeCode.getCPtr(time));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			finally
			{
				translation = gfVec3d;
				rotation = gfVec3f;
				scale = gfVec3f2;
				pivot = gfVec3f3;
			}
		}

		public bool GetResetXformStack()
		{
			return UsdGeomPINVOKE.UsdGeomXformCommonAPI_GetResetXformStack(swigCPtr);
		}

		public bool SetTranslate(GfVec3d translation, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetTranslate__SWIG_0(swigCPtr, GfVec3d.getCPtr(translation), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetTranslate(GfVec3d translation)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetTranslate__SWIG_1(swigCPtr, GfVec3d.getCPtr(translation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetPivot(GfVec3f pivot, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetPivot__SWIG_0(swigCPtr, GfVec3f.getCPtr(pivot), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetPivot(GfVec3f pivot)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetPivot__SWIG_1(swigCPtr, GfVec3f.getCPtr(pivot));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetRotate(GfVec3f rotation, RotationOrder rotOrder, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetRotate__SWIG_0(swigCPtr, GfVec3f.getCPtr(rotation), (int)rotOrder, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetRotate(GfVec3f rotation, RotationOrder rotOrder)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetRotate__SWIG_1(swigCPtr, GfVec3f.getCPtr(rotation), (int)rotOrder);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetRotate(GfVec3f rotation)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetRotate__SWIG_2(swigCPtr, GfVec3f.getCPtr(rotation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetScale(GfVec3f scale, UsdTimeCode time)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetScale__SWIG_0(swigCPtr, GfVec3f.getCPtr(scale), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetScale(GfVec3f scale)
		{
			bool result = UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetScale__SWIG_1(swigCPtr, GfVec3f.getCPtr(scale));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetResetXformStack(bool resetXformStack)
		{
			return UsdGeomPINVOKE.UsdGeomXformCommonAPI_SetResetXformStack(swigCPtr, resetXformStack);
		}

		public Ops CreateXformOps(RotationOrder rotOrder, OpFlags op1, OpFlags op2, OpFlags op3, OpFlags op4)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_0(swigCPtr, (int)rotOrder, (int)op1, (int)op2, (int)op3, (int)op4), cMemoryOwn: true);
		}

		public Ops CreateXformOps(RotationOrder rotOrder, OpFlags op1, OpFlags op2, OpFlags op3)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_1(swigCPtr, (int)rotOrder, (int)op1, (int)op2, (int)op3), cMemoryOwn: true);
		}

		public Ops CreateXformOps(RotationOrder rotOrder, OpFlags op1, OpFlags op2)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_2(swigCPtr, (int)rotOrder, (int)op1, (int)op2), cMemoryOwn: true);
		}

		public Ops CreateXformOps(RotationOrder rotOrder, OpFlags op1)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_3(swigCPtr, (int)rotOrder, (int)op1), cMemoryOwn: true);
		}

		public Ops CreateXformOps(RotationOrder rotOrder)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_4(swigCPtr, (int)rotOrder), cMemoryOwn: true);
		}

		public Ops CreateXformOps(OpFlags op1, OpFlags op2, OpFlags op3, OpFlags op4)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_5(swigCPtr, (int)op1, (int)op2, (int)op3, (int)op4), cMemoryOwn: true);
		}

		public Ops CreateXformOps(OpFlags op1, OpFlags op2, OpFlags op3)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_6(swigCPtr, (int)op1, (int)op2, (int)op3), cMemoryOwn: true);
		}

		public Ops CreateXformOps(OpFlags op1, OpFlags op2)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_7(swigCPtr, (int)op1, (int)op2), cMemoryOwn: true);
		}

		public Ops CreateXformOps(OpFlags op1)
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_8(swigCPtr, (int)op1), cMemoryOwn: true);
		}

		public Ops CreateXformOps()
		{
			return new Ops(UsdGeomPINVOKE.UsdGeomXformCommonAPI_CreateXformOps__SWIG_9(swigCPtr), cMemoryOwn: true);
		}

		public static GfMatrix4d GetRotationTransform(GfVec3f rotation, RotationOrder rotationOrder)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomXformCommonAPI_GetRotationTransform(GfVec3f.getCPtr(rotation), (int)rotationOrder), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomXformOp.Type ConvertRotationOrderToOpType(RotationOrder rotOrder)
		{
			return (UsdGeomXformOp.Type)UsdGeomPINVOKE.UsdGeomXformCommonAPI_ConvertRotationOrderToOpType((int)rotOrder);
		}

		public static RotationOrder ConvertOpTypeToRotationOrder(UsdGeomXformOp.Type opType)
		{
			return (RotationOrder)UsdGeomPINVOKE.UsdGeomXformCommonAPI_ConvertOpTypeToRotationOrder((int)opType);
		}

		public static bool CanConvertOpTypeToRotationOrder(UsdGeomXformOp.Type opType)
		{
			return UsdGeomPINVOKE.UsdGeomXformCommonAPI_CanConvertOpTypeToRotationOrder((int)opType);
		}

		private bool _IsValid()
		{
			return UsdGeomPINVOKE.UsdGeomXformCommonAPI__IsValid(swigCPtr);
		}

		public static implicit operator bool(UsdGeomXformCommonAPI obj)
		{
			return obj._IsValid();
		}
	}
}
