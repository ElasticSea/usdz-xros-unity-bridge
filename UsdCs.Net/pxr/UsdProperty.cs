using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdProperty : UsdObject
	{
		private HandleRef swigCPtr;

		public UsdProperty(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdProperty_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdProperty obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdProperty obj)
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
						UsdPINVOKE.delete_UsdProperty(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdProperty()
			: this(UsdPINVOKE.new_UsdProperty(), cMemoryOwn: true)
		{
		}

		public SdfPropertySpecHandleVector GetPropertyStack(UsdTimeCode time)
		{
			SdfPropertySpecHandleVector result = new SdfPropertySpecHandleVector(UsdPINVOKE.UsdProperty_GetPropertyStack__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPropertySpecHandleVector GetPropertyStack()
		{
			return new SdfPropertySpecHandleVector(UsdPINVOKE.UsdProperty_GetPropertyStack__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__vectorT_std__pairT_SdfPropertySpecHandle_SdfLayerOffset_t_t GetPropertyStackWithLayerOffsets(UsdTimeCode time)
		{
			SWIGTYPE_p_std__vectorT_std__pairT_SdfPropertySpecHandle_SdfLayerOffset_t_t result = new SWIGTYPE_p_std__vectorT_std__pairT_SdfPropertySpecHandle_SdfLayerOffset_t_t(UsdPINVOKE.UsdProperty_GetPropertyStackWithLayerOffsets__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_std__pairT_SdfPropertySpecHandle_SdfLayerOffset_t_t GetPropertyStackWithLayerOffsets()
		{
			return new SWIGTYPE_p_std__vectorT_std__pairT_SdfPropertySpecHandle_SdfLayerOffset_t_t(UsdPINVOKE.UsdProperty_GetPropertyStackWithLayerOffsets__SWIG_1(swigCPtr), futureUse: true);
		}

		public TfToken GetBaseName()
		{
			return new TfToken(UsdPINVOKE.UsdProperty_GetBaseName(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetNamespace()
		{
			return new TfToken(UsdPINVOKE.UsdProperty_GetNamespace(swigCPtr), cMemoryOwn: true);
		}

		public StdStringVector SplitName()
		{
			return new StdStringVector(UsdPINVOKE.UsdProperty_SplitName(swigCPtr), cMemoryOwn: true);
		}

		public string GetDisplayGroup()
		{
			return UsdPINVOKE.UsdProperty_GetDisplayGroup(swigCPtr);
		}

		public bool SetDisplayGroup(string displayGroup)
		{
			bool result = UsdPINVOKE.UsdProperty_SetDisplayGroup(swigCPtr, displayGroup);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearDisplayGroup()
		{
			return UsdPINVOKE.UsdProperty_ClearDisplayGroup(swigCPtr);
		}

		public bool HasAuthoredDisplayGroup()
		{
			return UsdPINVOKE.UsdProperty_HasAuthoredDisplayGroup(swigCPtr);
		}

		public StdStringVector GetNestedDisplayGroups()
		{
			return new StdStringVector(UsdPINVOKE.UsdProperty_GetNestedDisplayGroups(swigCPtr), cMemoryOwn: true);
		}

		public bool SetNestedDisplayGroups(StdStringVector nestedGroups)
		{
			bool result = UsdPINVOKE.UsdProperty_SetNestedDisplayGroups(swigCPtr, StdStringVector.getCPtr(nestedGroups));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsCustom()
		{
			return UsdPINVOKE.UsdProperty_IsCustom(swigCPtr);
		}

		public bool SetCustom(bool isCustom)
		{
			return UsdPINVOKE.UsdProperty_SetCustom(swigCPtr, isCustom);
		}

		public bool IsDefined()
		{
			return UsdPINVOKE.UsdProperty_IsDefined(swigCPtr);
		}

		public bool IsAuthored()
		{
			return UsdPINVOKE.UsdProperty_IsAuthored(swigCPtr);
		}

		public bool IsAuthoredAt(UsdEditTarget editTarget)
		{
			bool result = UsdPINVOKE.UsdProperty_IsAuthoredAt(swigCPtr, UsdEditTarget.getCPtr(editTarget));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdProperty FlattenTo(UsdPrim parent)
		{
			UsdProperty result = new UsdProperty(UsdPINVOKE.UsdProperty_FlattenTo__SWIG_0(swigCPtr, UsdPrim.getCPtr(parent)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdProperty FlattenTo(UsdPrim parent, TfToken propName)
		{
			UsdProperty result = new UsdProperty(UsdPINVOKE.UsdProperty_FlattenTo__SWIG_1(swigCPtr, UsdPrim.getCPtr(parent), TfToken.getCPtr(propName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdProperty FlattenTo(UsdProperty property)
		{
			UsdProperty result = new UsdProperty(UsdPINVOKE.UsdProperty_FlattenTo__SWIG_2(swigCPtr, getCPtr(property)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
