using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomImageable : UsdTyped
	{
		public class PurposeInfo : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public TfToken purpose
			{
				get
				{
					IntPtr intPtr = UsdGeomPINVOKE.UsdGeomImageable_PurposeInfo_purpose_get(swigCPtr);
					return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
				}
				set
				{
					UsdGeomPINVOKE.UsdGeomImageable_PurposeInfo_purpose_set(swigCPtr, TfToken.getCPtr(value));
				}
			}

			public bool isInheritable
			{
				get
				{
					return UsdGeomPINVOKE.UsdGeomImageable_PurposeInfo_isInheritable_get(swigCPtr);
				}
				set
				{
					UsdGeomPINVOKE.UsdGeomImageable_PurposeInfo_isInheritable_set(swigCPtr, value);
				}
			}

			public PurposeInfo(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(PurposeInfo obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(PurposeInfo obj)
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

			~PurposeInfo()
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
							UsdGeomPINVOKE.delete_UsdGeomImageable_PurposeInfo(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public PurposeInfo()
				: this(UsdGeomPINVOKE.new_UsdGeomImageable_PurposeInfo__SWIG_0(), cMemoryOwn: true)
			{
			}

			public PurposeInfo(TfToken purpose_, bool isInheritable_)
				: this(UsdGeomPINVOKE.new_UsdGeomImageable_PurposeInfo__SWIG_1(TfToken.getCPtr(purpose_), isInheritable_), cMemoryOwn: true)
			{
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public TfToken GetInheritablePurpose()
			{
				return new TfToken(UsdGeomPINVOKE.UsdGeomImageable_PurposeInfo_GetInheritablePurpose(swigCPtr), cMemoryOwn: false);
			}
		}

		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdGeomImageable(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomImageable_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomImageable obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomImageable obj)
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
						UsdGeomPINVOKE.delete_UsdGeomImageable(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomImageable(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomImageable__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomImageable()
			: this(UsdGeomPINVOKE.new_UsdGeomImageable__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomImageable(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomImageable__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomImageable_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomImageable_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomImageable Get(UsdStage stage, SdfPath path)
		{
			UsdGeomImageable result = new UsdGeomImageable(UsdGeomPINVOKE.UsdGeomImageable_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_GetVisibilityAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVisibilityAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_CreateVisibilityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVisibilityAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_CreateVisibilityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_CreateVisibilityAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetPurposeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_GetPurposeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreatePurposeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_CreatePurposeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePurposeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_CreatePurposeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePurposeAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_CreatePurposeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetProxyPrimRel()
		{
			return new UsdRelationship(UsdGeomPINVOKE.UsdGeomImageable_GetProxyPrimRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateProxyPrimRel()
		{
			return new UsdRelationship(UsdGeomPINVOKE.UsdGeomImageable_CreateProxyPrimRel(swigCPtr), cMemoryOwn: true);
		}

		public static TfTokenVector GetOrderedPurposeTokens()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomImageable_GetOrderedPurposeTokens(), cMemoryOwn: false);
		}

		public void MakeVisible(UsdTimeCode time)
		{
			UsdGeomPINVOKE.UsdGeomImageable_MakeVisible__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void MakeVisible()
		{
			UsdGeomPINVOKE.UsdGeomImageable_MakeVisible__SWIG_1(swigCPtr);
		}

		public void MakeInvisible(UsdTimeCode time)
		{
			UsdGeomPINVOKE.UsdGeomImageable_MakeInvisible__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void MakeInvisible()
		{
			UsdGeomPINVOKE.UsdGeomImageable_MakeInvisible__SWIG_1(swigCPtr);
		}

		public TfToken ComputeVisibility(UsdTimeCode time)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomImageable_ComputeVisibility__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken ComputeVisibility()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomImageable_ComputeVisibility__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetPurposeVisibilityAttr(TfToken purpose)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_GetPurposeVisibilityAttr__SWIG_0(swigCPtr, TfToken.getCPtr(purpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetPurposeVisibilityAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomImageable_GetPurposeVisibilityAttr__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public TfToken ComputeEffectiveVisibility(TfToken purpose, UsdTimeCode time)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomImageable_ComputeEffectiveVisibility__SWIG_0(swigCPtr, TfToken.getCPtr(purpose), UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken ComputeEffectiveVisibility(TfToken purpose)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomImageable_ComputeEffectiveVisibility__SWIG_1(swigCPtr, TfToken.getCPtr(purpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken ComputeEffectiveVisibility()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomImageable_ComputeEffectiveVisibility__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public PurposeInfo ComputePurposeInfo()
		{
			return new PurposeInfo(UsdGeomPINVOKE.UsdGeomImageable_ComputePurposeInfo__SWIG_0(swigCPtr), cMemoryOwn: true);
		}

		public PurposeInfo ComputePurposeInfo(PurposeInfo parentPurposeInfo)
		{
			PurposeInfo result = new PurposeInfo(UsdGeomPINVOKE.UsdGeomImageable_ComputePurposeInfo__SWIG_1(swigCPtr, PurposeInfo.getCPtr(parentPurposeInfo)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken ComputePurpose()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomImageable_ComputePurpose(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim ComputeProxyPrim(UsdPrim renderPrim)
		{
			return new UsdPrim(UsdGeomPINVOKE.UsdGeomImageable_ComputeProxyPrim__SWIG_0(swigCPtr, UsdPrim.getCPtr(renderPrim)), cMemoryOwn: true);
		}

		public UsdPrim ComputeProxyPrim()
		{
			return new UsdPrim(UsdGeomPINVOKE.UsdGeomImageable_ComputeProxyPrim__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public bool SetProxyPrim(UsdPrim proxy)
		{
			bool result = UsdGeomPINVOKE.UsdGeomImageable_SetProxyPrim__SWIG_0(swigCPtr, UsdPrim.getCPtr(proxy));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetProxyPrim(UsdSchemaBase proxy)
		{
			bool result = UsdGeomPINVOKE.UsdGeomImageable_SetProxyPrim__SWIG_1(swigCPtr, UsdSchemaBase.getCPtr(proxy));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeWorldBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3, TfToken purpose4)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3), TfToken.getCPtr(purpose4)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeWorldBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeWorldBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_2(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeWorldBound(UsdTimeCode time, TfToken purpose1)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_3(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeWorldBound(UsdTimeCode time)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_4(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeLocalBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3, TfToken purpose4)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3), TfToken.getCPtr(purpose4)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeLocalBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeLocalBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_2(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeLocalBound(UsdTimeCode time, TfToken purpose1)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_3(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeLocalBound(UsdTimeCode time)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_4(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeUntransformedBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3, TfToken purpose4)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3), TfToken.getCPtr(purpose4)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeUntransformedBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeUntransformedBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_2(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeUntransformedBound(UsdTimeCode time, TfToken purpose1)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_3(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfBBox3d ComputeUntransformedBound(UsdTimeCode time)
		{
			GfBBox3d result = new GfBBox3d(UsdGeomPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_4(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d ComputeLocalToWorldTransform(UsdTimeCode time)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomImageable_ComputeLocalToWorldTransform(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d ComputeParentToWorldTransform(UsdTimeCode time)
		{
			GfMatrix4d result = new GfMatrix4d(UsdGeomPINVOKE.UsdGeomImageable_ComputeParentToWorldTransform(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
