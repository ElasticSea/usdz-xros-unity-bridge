using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeConnectableAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.NonAppliedAPI;

		public UsdShadeConnectableAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdShadePINVOKE.UsdShadeConnectableAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeConnectableAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeConnectableAPI obj)
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
						UsdShadePINVOKE.delete_UsdShadeConnectableAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdShadeConnectableAPI(UsdPrim prim)
			: this(UsdShadePINVOKE.new_UsdShadeConnectableAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectableAPI()
			: this(UsdShadePINVOKE.new_UsdShadeConnectableAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdShadeConnectableAPI(UsdSchemaBase schemaObj)
			: this(UsdShadePINVOKE.new_UsdShadeConnectableAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeConnectableAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeConnectableAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdShadeConnectableAPI Get(UsdStage stage, SdfPath path)
		{
			UsdShadeConnectableAPI result = new UsdShadeConnectableAPI(UsdShadePINVOKE.UsdShadeConnectableAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsContainer()
		{
			return UsdShadePINVOKE.UsdShadeConnectableAPI_IsContainer(swigCPtr);
		}

		public bool RequiresEncapsulation()
		{
			return UsdShadePINVOKE.UsdShadeConnectableAPI_RequiresEncapsulation(swigCPtr);
		}

		public static bool CanConnect(UsdShadeInput input, UsdAttribute source)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_0(UsdShadeInput.getCPtr(input), UsdAttribute.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanConnect(UsdShadeInput input, UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_1(UsdShadeInput.getCPtr(input), UsdShadeInput.getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanConnect(UsdShadeInput input, UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_2(UsdShadeInput.getCPtr(input), UsdShadeOutput.getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanConnect(UsdShadeOutput output, UsdAttribute source)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_3(UsdShadeOutput.getCPtr(output), UsdAttribute.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanConnect(UsdShadeOutput output)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_4(UsdShadeOutput.getCPtr(output));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanConnect(UsdShadeOutput output, UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_5(UsdShadeOutput.getCPtr(output), UsdShadeInput.getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanConnect(UsdShadeOutput output, UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_CanConnect__SWIG_6(UsdShadeOutput.getCPtr(output), UsdShadeOutput.getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdAttribute shadingAttr, UsdShadeConnectionSourceInfo source, UsdShadeConnectionModification mod)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_0(UsdAttribute.getCPtr(shadingAttr), UsdShadeConnectionSourceInfo.getCPtr(source), (int)mod);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdAttribute shadingAttr, UsdShadeConnectionSourceInfo source)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_1(UsdAttribute.getCPtr(shadingAttr), UsdShadeConnectionSourceInfo.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeInput input, UsdShadeConnectionSourceInfo source, UsdShadeConnectionModification mod)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_2(UsdShadeInput.getCPtr(input), UsdShadeConnectionSourceInfo.getCPtr(source), (int)mod);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeInput input, UsdShadeConnectionSourceInfo source)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_3(UsdShadeInput.getCPtr(input), UsdShadeConnectionSourceInfo.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeOutput output, UsdShadeConnectionSourceInfo source, UsdShadeConnectionModification mod)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_4(UsdShadeOutput.getCPtr(output), UsdShadeConnectionSourceInfo.getCPtr(source), (int)mod);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeOutput output, UsdShadeConnectionSourceInfo source)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_5(UsdShadeOutput.getCPtr(output), UsdShadeConnectionSourceInfo.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdAttribute shadingAttr, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_6(UsdAttribute.getCPtr(shadingAttr), getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdAttribute shadingAttr, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_7(UsdAttribute.getCPtr(shadingAttr), getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdAttribute shadingAttr, UsdShadeConnectableAPI source, TfToken sourceName)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_8(UsdAttribute.getCPtr(shadingAttr), getCPtr(source), TfToken.getCPtr(sourceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeInput input, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_9(UsdShadeInput.getCPtr(input), getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeInput input, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_10(UsdShadeInput.getCPtr(input), getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeInput input, UsdShadeConnectableAPI source, TfToken sourceName)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_11(UsdShadeInput.getCPtr(input), getCPtr(source), TfToken.getCPtr(sourceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeOutput output, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_12(UsdShadeOutput.getCPtr(output), getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeOutput output, UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_13(UsdShadeOutput.getCPtr(output), getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeOutput output, UsdShadeConnectableAPI source, TfToken sourceName)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_14(UsdShadeOutput.getCPtr(output), getCPtr(source), TfToken.getCPtr(sourceName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdAttribute shadingAttr, SdfPath sourcePath)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_15(UsdAttribute.getCPtr(shadingAttr), SdfPath.getCPtr(sourcePath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeInput input, SdfPath sourcePath)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_16(UsdShadeInput.getCPtr(input), SdfPath.getCPtr(sourcePath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeOutput output, SdfPath sourcePath)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_17(UsdShadeOutput.getCPtr(output), SdfPath.getCPtr(sourcePath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdAttribute shadingAttr, UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_18(UsdAttribute.getCPtr(shadingAttr), UsdShadeInput.getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeInput input, UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_19(UsdShadeInput.getCPtr(input), UsdShadeInput.getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeOutput output, UsdShadeInput sourceInput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_20(UsdShadeOutput.getCPtr(output), UsdShadeInput.getCPtr(sourceInput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdAttribute shadingAttr, UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_21(UsdAttribute.getCPtr(shadingAttr), UsdShadeOutput.getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeInput input, UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_22(UsdShadeInput.getCPtr(input), UsdShadeOutput.getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ConnectToSource(UsdShadeOutput output, UsdShadeOutput sourceOutput)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ConnectToSource__SWIG_23(UsdShadeOutput.getCPtr(output), UsdShadeOutput.getCPtr(sourceOutput));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SetConnectedSources(UsdAttribute shadingAttr, SWIGTYPE_p_std__vectorT_UsdShadeConnectionSourceInfo_t sourceInfos)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_SetConnectedSources(UsdAttribute.getCPtr(shadingAttr), SWIGTYPE_p_std__vectorT_UsdShadeConnectionSourceInfo_t.getCPtr(sourceInfos));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetConnectedSource(UsdAttribute shadingAttr, UsdShadeConnectableAPI source, TfToken sourceName, SWIGTYPE_p_UsdShadeAttributeType sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSource__SWIG_0(UsdAttribute.getCPtr(shadingAttr), getCPtr(source), TfToken.getCPtr(sourceName), SWIGTYPE_p_UsdShadeAttributeType.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetConnectedSource(UsdShadeInput input, UsdShadeConnectableAPI source, TfToken sourceName, SWIGTYPE_p_UsdShadeAttributeType sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSource__SWIG_1(UsdShadeInput.getCPtr(input), getCPtr(source), TfToken.getCPtr(sourceName), SWIGTYPE_p_UsdShadeAttributeType.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetConnectedSource(UsdShadeOutput output, UsdShadeConnectableAPI source, TfToken sourceName, SWIGTYPE_p_UsdShadeAttributeType sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSource__SWIG_2(UsdShadeOutput.getCPtr(output), getCPtr(source), TfToken.getCPtr(sourceName), SWIGTYPE_p_UsdShadeAttributeType.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources(UsdAttribute shadingAttr, SdfPathVector invalidSourcePaths)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSources__SWIG_0(UsdAttribute.getCPtr(shadingAttr), SdfPathVector.getCPtr(invalidSourcePaths)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources(UsdAttribute shadingAttr)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSources__SWIG_1(UsdAttribute.getCPtr(shadingAttr)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources(UsdShadeInput input, SdfPathVector invalidSourcePaths)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSources__SWIG_2(UsdShadeInput.getCPtr(input), SdfPathVector.getCPtr(invalidSourcePaths)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources(UsdShadeInput input)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSources__SWIG_3(UsdShadeInput.getCPtr(input)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources(UsdShadeOutput output, SdfPathVector invalidSourcePaths)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSources__SWIG_4(UsdShadeOutput.getCPtr(output), SdfPathVector.getCPtr(invalidSourcePaths)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t GetConnectedSources(UsdShadeOutput output)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdShadeConnectionSourceInfo_1_t(UsdShadePINVOKE.UsdShadeConnectableAPI_GetConnectedSources__SWIG_5(UsdShadeOutput.getCPtr(output)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetRawConnectedSourcePaths(UsdAttribute shadingAttr, SdfPathVector sourcePaths)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_0(UsdAttribute.getCPtr(shadingAttr), SdfPathVector.getCPtr(sourcePaths));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetRawConnectedSourcePaths(UsdShadeInput input, SdfPathVector sourcePaths)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_1(UsdShadeInput.getCPtr(input), SdfPathVector.getCPtr(sourcePaths));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetRawConnectedSourcePaths(UsdShadeOutput output, SdfPathVector sourcePaths)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_2(UsdShadeOutput.getCPtr(output), SdfPathVector.getCPtr(sourcePaths));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool HasConnectedSource(UsdAttribute shadingAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_HasConnectedSource__SWIG_0(UsdAttribute.getCPtr(shadingAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool HasConnectedSource(UsdShadeInput input)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_HasConnectedSource__SWIG_1(UsdShadeInput.getCPtr(input));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool HasConnectedSource(UsdShadeOutput output)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_HasConnectedSource__SWIG_2(UsdShadeOutput.getCPtr(output));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsSourceConnectionFromBaseMaterial(UsdAttribute shadingAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_0(UsdAttribute.getCPtr(shadingAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsSourceConnectionFromBaseMaterial(UsdShadeInput input)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_1(UsdShadeInput.getCPtr(input));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsSourceConnectionFromBaseMaterial(UsdShadeOutput output)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_2(UsdShadeOutput.getCPtr(output));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool DisconnectSource(UsdAttribute shadingAttr, UsdAttribute sourceAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_0(UsdAttribute.getCPtr(shadingAttr), UsdAttribute.getCPtr(sourceAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool DisconnectSource(UsdAttribute shadingAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_1(UsdAttribute.getCPtr(shadingAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool DisconnectSource(UsdShadeInput input, UsdAttribute sourceAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_2(UsdShadeInput.getCPtr(input), UsdAttribute.getCPtr(sourceAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool DisconnectSource(UsdShadeInput input)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_3(UsdShadeInput.getCPtr(input));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool DisconnectSource(UsdShadeOutput output, UsdAttribute sourceAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_4(UsdShadeOutput.getCPtr(output), UsdAttribute.getCPtr(sourceAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool DisconnectSource(UsdShadeOutput output)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_DisconnectSource__SWIG_5(UsdShadeOutput.getCPtr(output));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ClearSources(UsdAttribute shadingAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ClearSources__SWIG_0(UsdAttribute.getCPtr(shadingAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ClearSources(UsdShadeInput input)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ClearSources__SWIG_1(UsdShadeInput.getCPtr(input));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ClearSources(UsdShadeOutput output)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ClearSources__SWIG_2(UsdShadeOutput.getCPtr(output));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ClearSource(UsdAttribute shadingAttr)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ClearSource__SWIG_0(UsdAttribute.getCPtr(shadingAttr));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ClearSource(UsdShadeInput input)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ClearSource__SWIG_1(UsdShadeInput.getCPtr(input));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ClearSource(UsdShadeOutput output)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_ClearSource__SWIG_2(UsdShadeOutput.getCPtr(output));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool HasConnectableAPI(TfType schemaType)
		{
			bool result = UsdShadePINVOKE.UsdShadeConnectableAPI_HasConnectableAPI(TfType.getCPtr(schemaType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeConnectableAPI_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetOutput(TfToken name)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeConnectableAPI_GetOutput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutputVector GetOutputs(bool onlyAuthored)
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeConnectableAPI_GetOutputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetOutputs()
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeConnectableAPI_GetOutputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeInput result = new UsdShadeInput(UsdShadePINVOKE.UsdShadeConnectableAPI_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInput GetInput(TfToken name)
		{
			UsdShadeInput result = new UsdShadeInput(UsdShadePINVOKE.UsdShadeConnectableAPI_GetInput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInputVector GetInputs(bool onlyAuthored)
		{
			return new UsdShadeInputVector(UsdShadePINVOKE.UsdShadeConnectableAPI_GetInputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeInputVector GetInputs()
		{
			return new UsdShadeInputVector(UsdShadePINVOKE.UsdShadeConnectableAPI_GetInputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}
	}
}
