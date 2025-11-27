using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeNodeGraph : UsdTyped
	{
		public class NodeGraphHasher : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public NodeGraphHasher(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(NodeGraphHasher obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(NodeGraphHasher obj)
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

			~NodeGraphHasher()
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
							UsdShadePINVOKE.delete_UsdShadeNodeGraph_NodeGraphHasher(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public NodeGraphHasher()
				: this(UsdShadePINVOKE.new_UsdShadeNodeGraph_NodeGraphHasher(), cMemoryOwn: true)
			{
			}
		}

		public class NodeGraphEqualFn : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public NodeGraphEqualFn(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(NodeGraphEqualFn obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(NodeGraphEqualFn obj)
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

			~NodeGraphEqualFn()
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
							UsdShadePINVOKE.delete_UsdShadeNodeGraph_NodeGraphEqualFn(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public NodeGraphEqualFn()
				: this(UsdShadePINVOKE.new_UsdShadeNodeGraph_NodeGraphEqualFn(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdShadeNodeGraph(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdShadePINVOKE.UsdShadeNodeGraph_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeNodeGraph obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeNodeGraph obj)
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
						UsdShadePINVOKE.delete_UsdShadeNodeGraph(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdShadeNodeGraph(UsdPrim prim)
			: this(UsdShadePINVOKE.new_UsdShadeNodeGraph__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeNodeGraph()
			: this(UsdShadePINVOKE.new_UsdShadeNodeGraph__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdShadeNodeGraph(UsdSchemaBase schemaObj)
			: this(UsdShadePINVOKE.new_UsdShadeNodeGraph__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeNodeGraph_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeNodeGraph_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdShadeNodeGraph Get(UsdStage stage, SdfPath path)
		{
			UsdShadeNodeGraph result = new UsdShadeNodeGraph(UsdShadePINVOKE.UsdShadeNodeGraph_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdShadeNodeGraph Define(UsdStage stage, SdfPath path)
		{
			UsdShadeNodeGraph result = new UsdShadeNodeGraph(UsdShadePINVOKE.UsdShadeNodeGraph_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeNodeGraph(UsdShadeConnectableAPI connectable)
			: this(UsdShadePINVOKE.new_UsdShadeNodeGraph__SWIG_3(UsdShadeConnectableAPI.getCPtr(connectable)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectableAPI ConnectableAPI()
		{
			return new UsdShadeConnectableAPI(UsdShadePINVOKE.UsdShadeNodeGraph_ConnectableAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeNodeGraph_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetOutput(TfToken name)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeNodeGraph_GetOutput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutputVector GetOutputs(bool onlyAuthored)
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeNodeGraph_GetOutputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetOutputs()
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeNodeGraph_GetOutputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeShader ComputeOutputSource(TfToken outputName, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeNodeGraph_ComputeOutputSource(swigCPtr, TfToken.getCPtr(outputName), TfToken.getCPtr(sourceName), out sourceType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeInput result = new UsdShadeInput(UsdShadePINVOKE.UsdShadeNodeGraph_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInput GetInput(TfToken name)
		{
			UsdShadeInput result = new UsdShadeInput(UsdShadePINVOKE.UsdShadeNodeGraph_GetInput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInputVector GetInputs(bool onlyAuthored)
		{
			return new UsdShadeInputVector(UsdShadePINVOKE.UsdShadeNodeGraph_GetInputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeInputVector GetInputs()
		{
			return new UsdShadeInputVector(UsdShadePINVOKE.UsdShadeNodeGraph_GetInputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeInputVector GetInterfaceInputs()
		{
			return new UsdShadeInputVector(UsdShadePINVOKE.UsdShadeNodeGraph_GetInterfaceInputs(swigCPtr), cMemoryOwn: true);
		}

		public InterfaceInputConsumersMap ComputeInterfaceInputConsumersMap(bool computeTransitiveConsumers)
		{
			return new InterfaceInputConsumersMap(UsdShadePINVOKE.UsdShadeNodeGraph_ComputeInterfaceInputConsumersMap__SWIG_0(swigCPtr, computeTransitiveConsumers), cMemoryOwn: true);
		}

		public InterfaceInputConsumersMap ComputeInterfaceInputConsumersMap()
		{
			return new InterfaceInputConsumersMap(UsdShadePINVOKE.UsdShadeNodeGraph_ComputeInterfaceInputConsumersMap__SWIG_1(swigCPtr), cMemoryOwn: true);
		}
	}
}
