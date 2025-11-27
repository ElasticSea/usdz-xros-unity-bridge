using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomNurbsPatch : UsdGeomPointBased
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdGeomNurbsPatch(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomNurbsPatch_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomNurbsPatch obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomNurbsPatch obj)
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
						UsdGeomPINVOKE.delete_UsdGeomNurbsPatch(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomNurbsPatch(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomNurbsPatch__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomNurbsPatch()
			: this(UsdGeomPINVOKE.new_UsdGeomNurbsPatch__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomNurbsPatch(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomNurbsPatch__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomNurbsPatch Get(UsdStage stage, SdfPath path)
		{
			UsdGeomNurbsPatch result = new UsdGeomNurbsPatch(UsdGeomPINVOKE.UsdGeomNurbsPatch_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdGeomNurbsPatch Define(UsdStage stage, SdfPath path)
		{
			UsdGeomNurbsPatch result = new UsdGeomNurbsPatch(UsdGeomPINVOKE.UsdGeomNurbsPatch_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetUVertexCountAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetUVertexCountAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateUVertexCountAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateUVertexCountAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateUVertexCountAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVVertexCountAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetVVertexCountAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVVertexCountAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVVertexCountAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVVertexCountAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetUOrderAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetUOrderAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateUOrderAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateUOrderAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateUOrderAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVOrderAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetVOrderAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVOrderAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVOrderAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVOrderAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetUKnotsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetUKnotsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateUKnotsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateUKnotsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateUKnotsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVKnotsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetVKnotsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVKnotsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVKnotsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVKnotsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetUFormAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetUFormAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateUFormAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUFormAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateUFormAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUFormAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateUFormAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateUFormAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVFormAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetVFormAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVFormAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVFormAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVFormAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVFormAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVFormAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVFormAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetURangeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetURangeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateURangeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateURangeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateURangeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateURangeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateURangeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateURangeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVRangeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetVRangeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVRangeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVRangeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVRangeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetPointWeightsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetPointWeightsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreatePointWeightsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePointWeightsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePointWeightsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTrimCurveCountsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetTrimCurveCountsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTrimCurveCountsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveCountsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveCountsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTrimCurveOrdersAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetTrimCurveOrdersAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTrimCurveOrdersAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveOrdersAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveOrdersAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTrimCurveVertexCountsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetTrimCurveVertexCountsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTrimCurveVertexCountsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveVertexCountsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveVertexCountsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTrimCurveKnotsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetTrimCurveKnotsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTrimCurveKnotsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveKnotsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveKnotsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTrimCurveRangesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetTrimCurveRangesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTrimCurveRangesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveRangesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurveRangesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTrimCurvePointsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_GetTrimCurvePointsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTrimCurvePointsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurvePointsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTrimCurvePointsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
