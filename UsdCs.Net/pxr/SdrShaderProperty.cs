using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdrShaderProperty : NdrProperty
	{
		private HandleRef swigCPtr;

		public SdrShaderProperty(IntPtr cPtr, bool cMemoryOwn)
			: base(SdrPINVOKE.SdrShaderProperty_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdrShaderProperty obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdrShaderProperty obj)
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
						SdrPINVOKE.delete_SdrShaderProperty(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public SdrShaderProperty(TfToken name, TfToken type, VtValue defaultValue, bool isOutput, uint arraySize, NdrTokenMap metadata, NdrTokenMap hints, SWIGTYPE_p_std__vectorT_std__pairT_TfToken_TfToken_t_t options)
			: this(SdrPINVOKE.new_SdrShaderProperty(TfToken.getCPtr(name), TfToken.getCPtr(type), VtValue.getCPtr(defaultValue), isOutput, arraySize, NdrTokenMap.getCPtr(metadata), NdrTokenMap.getCPtr(hints), SWIGTYPE_p_std__vectorT_std__pairT_TfToken_TfToken_t_t.getCPtr(options)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetLabel()
		{
			return new TfToken(SdrPINVOKE.SdrShaderProperty_GetLabel(swigCPtr), cMemoryOwn: false);
		}

		public string GetHelp()
		{
			return SdrPINVOKE.SdrShaderProperty_GetHelp(swigCPtr);
		}

		public TfToken GetPage()
		{
			return new TfToken(SdrPINVOKE.SdrShaderProperty_GetPage(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetWidget()
		{
			return new TfToken(SdrPINVOKE.SdrShaderProperty_GetWidget(swigCPtr), cMemoryOwn: false);
		}

		public NdrTokenMap GetHints()
		{
			return new NdrTokenMap(SdrPINVOKE.SdrShaderProperty_GetHints(swigCPtr), cMemoryOwn: false);
		}

		public SWIGTYPE_p_std__vectorT_std__pairT_TfToken_TfToken_t_t GetOptions()
		{
			return new SWIGTYPE_p_std__vectorT_std__pairT_TfToken_TfToken_t_t(SdrPINVOKE.SdrShaderProperty_GetOptions(swigCPtr), futureUse: false);
		}

		public string GetImplementationName()
		{
			return SdrPINVOKE.SdrShaderProperty_GetImplementationName(swigCPtr);
		}

		public TfToken GetVStructMemberOf()
		{
			return new TfToken(SdrPINVOKE.SdrShaderProperty_GetVStructMemberOf(swigCPtr), cMemoryOwn: false);
		}

		public TfToken GetVStructMemberName()
		{
			return new TfToken(SdrPINVOKE.SdrShaderProperty_GetVStructMemberName(swigCPtr), cMemoryOwn: false);
		}

		public bool IsVStructMember()
		{
			return SdrPINVOKE.SdrShaderProperty_IsVStructMember(swigCPtr);
		}

		public bool IsVStruct()
		{
			return SdrPINVOKE.SdrShaderProperty_IsVStruct(swigCPtr);
		}

		public TfToken GetVStructConditionalExpr()
		{
			return new TfToken(SdrPINVOKE.SdrShaderProperty_GetVStructConditionalExpr(swigCPtr), cMemoryOwn: false);
		}

		public override bool IsConnectable()
		{
			return SdrPINVOKE.SdrShaderProperty_IsConnectable(swigCPtr);
		}

		public TfTokenVector GetValidConnectionTypes()
		{
			return new TfTokenVector(SdrPINVOKE.SdrShaderProperty_GetValidConnectionTypes(swigCPtr), cMemoryOwn: false);
		}

		public override bool CanConnectTo(NdrProperty other)
		{
			bool result = SdrPINVOKE.SdrShaderProperty_CanConnectTo(swigCPtr, NdrProperty.getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override NdrSdfTypeIndicator GetTypeAsSdfType()
		{
			return new NdrSdfTypeIndicator(SdrPINVOKE.SdrShaderProperty_GetTypeAsSdfType(swigCPtr), cMemoryOwn: true);
		}

		public override VtValue GetDefaultValueAsSdfType()
		{
			return new VtValue(SdrPINVOKE.SdrShaderProperty_GetDefaultValueAsSdfType(swigCPtr), cMemoryOwn: false);
		}

		public bool IsAssetIdentifier()
		{
			return SdrPINVOKE.SdrShaderProperty_IsAssetIdentifier(swigCPtr);
		}

		public bool IsDefaultInput()
		{
			return SdrPINVOKE.SdrShaderProperty_IsDefaultInput(swigCPtr);
		}
	}
}
