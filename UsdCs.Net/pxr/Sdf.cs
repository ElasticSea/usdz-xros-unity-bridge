namespace pxr
{
	public class Sdf
	{
		public static uint Sdf_SizeofPrimPathNode => SdfPINVOKE.Sdf_SizeofPrimPathNode_get();

		public static uint Sdf_SizeofPropPathNode => SdfPINVOKE.Sdf_SizeofPropPathNode_get();

		public static SdfPrimSpecHandle SdfCreatePrimInLayer(SdfLayerHandle layer, SdfPath primPath)
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfCreatePrimInLayer(SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(primPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SdfJustCreatePrimInLayer(SdfLayerHandle layer, SdfPath primPath)
		{
			bool result = SdfPINVOKE.SdfJustCreatePrimInLayer(SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SdfJustCreatePrimAttributeInLayer(SdfLayerHandle layer, SdfPath attrPath, SdfValueTypeName typeName, SdfVariability variability, bool isCustom)
		{
			bool result = SdfPINVOKE.SdfJustCreatePrimAttributeInLayer__SWIG_0(SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(attrPath), SdfValueTypeName.getCPtr(typeName), (int)variability, isCustom);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SdfJustCreatePrimAttributeInLayer(SdfLayerHandle layer, SdfPath attrPath, SdfValueTypeName typeName, SdfVariability variability)
		{
			bool result = SdfPINVOKE.SdfJustCreatePrimAttributeInLayer__SWIG_1(SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(attrPath), SdfValueTypeName.getCPtr(typeName), (int)variability);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SdfJustCreatePrimAttributeInLayer(SdfLayerHandle layer, SdfPath attrPath, SdfValueTypeName typeName)
		{
			bool result = SdfPINVOKE.SdfJustCreatePrimAttributeInLayer__SWIG_2(SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(attrPath), SdfValueTypeName.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfVariantSpecHandle SdfCreateVariantInLayer(SdfLayerHandle layer, SdfPath primPath, string variantSetName, string variantName)
		{
			SdfVariantSpecHandle result = new SdfVariantSpecHandle(SdfPINVOKE.SdfCreateVariantInLayer(SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(primPath), variantSetName, variantName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static int SdfFindReferenceByIdentity(StdReferenceVector references, SdfReference referenceId)
		{
			int result = SdfPINVOKE.SdfFindReferenceByIdentity(StdReferenceVector.getCPtr(references), SdfReference.getCPtr(referenceId));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SdfIsDefiningSpecifier(SdfSpecifier spec)
		{
			return SdfPINVOKE.SdfIsDefiningSpecifier((int)spec);
		}

		public static TfEnum SdfDefaultUnit(TfToken typeName)
		{
			TfEnum result = new TfEnum(SdfPINVOKE.SdfDefaultUnit__SWIG_0(TfToken.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfEnum SdfDefaultUnit(TfEnum unit)
		{
			TfEnum result = new TfEnum(SdfPINVOKE.SdfDefaultUnit__SWIG_1(TfEnum.getCPtr(unit)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string SdfUnitCategory(TfEnum unit)
		{
			string result = SdfPINVOKE.SdfUnitCategory(TfEnum.getCPtr(unit));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double SdfConvertUnit(TfEnum fromUnit, TfEnum toUnit)
		{
			double result = SdfPINVOKE.SdfConvertUnit(TfEnum.getCPtr(fromUnit), TfEnum.getCPtr(toUnit));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string SdfGetNameForUnit(TfEnum unit)
		{
			string result = SdfPINVOKE.SdfGetNameForUnit(TfEnum.getCPtr(unit));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfEnum SdfGetUnitFromName(string name)
		{
			TfEnum result = new TfEnum(SdfPINVOKE.SdfGetUnitFromName(name), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SdfValueHasValidType(VtValue value)
		{
			bool result = SdfPINVOKE.SdfValueHasValidType(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfType SdfGetTypeForValueTypeName(TfToken name)
		{
			TfType result = new TfType(SdfPINVOKE.SdfGetTypeForValueTypeName(TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfValueTypeName SdfGetValueTypeNameForValue(VtValue value)
		{
			SdfValueTypeName result = new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeNameForValue(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken SdfGetRoleNameForValueTypeName(TfToken typeName)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfGetRoleNameForValueTypeName(TfToken.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SdfConvertToValidMetadataDictionary(VtDictionary dict, out string errMsg)
		{
			bool result = SdfPINVOKE.SdfConvertToValidMetadataDictionary(VtDictionary.getCPtr(dict), out errMsg);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfNamespaceEditDetail.Result CombineResult(SdfNamespaceEditDetail.Result lhs, SdfNamespaceEditDetail.Result rhs)
		{
			return (SdfNamespaceEditDetail.Result)SdfPINVOKE.CombineResult((int)lhs, (int)rhs);
		}

		public static SdfNamespaceEditDetail.Result CombineError(SdfNamespaceEditDetail.Result arg0)
		{
			return (SdfNamespaceEditDetail.Result)SdfPINVOKE.CombineError((int)arg0);
		}

		public static SdfNamespaceEditDetail.Result CombineUnbatched(SdfNamespaceEditDetail.Result other)
		{
			return (SdfNamespaceEditDetail.Result)SdfPINVOKE.CombineUnbatched((int)other);
		}

		public static void GetPathFromVector(SdfPathVector paths, int index, SdfPath output)
		{
			SdfPINVOKE.GetPathFromVector(SdfPathVector.getCPtr(paths), index, SdfPath.getCPtr(output));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void intrusive_ptr_add_ref(SWIGTYPE_p_Sdf_PathNode arg0)
		{
			SdfPINVOKE.intrusive_ptr_add_ref(SWIGTYPE_p_Sdf_PathNode.getCPtr(arg0));
		}

		public static void intrusive_ptr_release(SWIGTYPE_p_Sdf_PathNode arg0)
		{
			SdfPINVOKE.intrusive_ptr_release(SWIGTYPE_p_Sdf_PathNode.getCPtr(arg0));
		}

		public static string Sdf_PathGetDebuggerPathText(SdfPath arg0)
		{
			string result = SdfPINVOKE.Sdf_PathGetDebuggerPathText(SdfPath.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_std__setT_SdfPath_t__const_iterator SdfPathFindLongestPrefix(SdfPathSet set, SdfPath path)
		{
			SWIGTYPE_p_std__setT_SdfPath_t__const_iterator result = new SWIGTYPE_p_std__setT_SdfPath_t__const_iterator(SdfPINVOKE.SdfPathFindLongestPrefix(SdfPathSet.getCPtr(set), SdfPath.getCPtr(path)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_std__setT_SdfPath_t__const_iterator SdfPathFindLongestStrictPrefix(SdfPathSet set, SdfPath path)
		{
			SWIGTYPE_p_std__setT_SdfPath_t__const_iterator result = new SWIGTYPE_p_std__setT_SdfPath_t__const_iterator(SdfPINVOKE.SdfPathFindLongestStrictPrefix(SdfPathSet.getCPtr(set), SdfPath.getCPtr(path)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfValueTypeName SdfGetValueTypeBool()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeBool(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeUChar()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeUChar(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeUInt()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeUInt(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt64()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt64(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeUInt64()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeUInt64(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeHalf()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeHalf(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFloat()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFloat(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeDouble()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeDouble(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTimeCode()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTimeCode(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeString()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeString(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeToken()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeToken(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeAsset()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeAsset(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeOpaque()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeOpaque(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeGroup()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeGroup(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt2()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt2(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt3()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt3(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt4()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt4(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeHalf2()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeHalf2(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeHalf3()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeHalf3(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeHalf4()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeHalf4(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFloat2()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFloat2(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFloat3()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFloat3(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFloat4()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFloat4(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeDouble2()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeDouble2(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeDouble3()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeDouble3(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeDouble4()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeDouble4(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypePoint3h()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypePoint3h(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypePoint3f()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypePoint3f(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypePoint3d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypePoint3d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeVector3h()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeVector3h(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeVector3f()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeVector3f(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeVector3d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeVector3d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeNormal3h()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeNormal3h(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeNormal3f()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeNormal3f(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeNormal3d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeNormal3d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor3h()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor3h(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor3f()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor3f(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor3d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor3d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor4h()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor4h(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor4f()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor4f(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor4d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor4d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeQuath()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeQuath(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeQuatf()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeQuatf(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeQuatd()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeQuatd(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeMatrix2d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeMatrix2d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeMatrix3d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeMatrix3d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeMatrix4d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeMatrix4d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFrame4d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFrame4d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord2h()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord2h(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord2f()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord2f(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord2d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord2d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord3h()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord3h(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord3f()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord3f(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord3d()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord3d(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeBoolArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeBoolArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeUCharArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeUCharArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeIntArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeIntArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeUIntArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeUIntArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt64Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt64Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeUInt64Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeUInt64Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeHalfArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeHalfArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFloatArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFloatArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeDoubleArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeDoubleArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTimeCodeArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTimeCodeArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeStringArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeStringArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTokenArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTokenArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeAssetArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeAssetArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt2Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt2Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt3Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt3Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeInt4Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeInt4Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeHalf2Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeHalf2Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeHalf3Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeHalf3Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeHalf4Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeHalf4Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFloat2Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFloat2Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFloat3Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFloat3Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFloat4Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFloat4Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeDouble2Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeDouble2Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeDouble3Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeDouble3Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeDouble4Array()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeDouble4Array(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypePoint3hArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypePoint3hArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypePoint3fArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypePoint3fArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypePoint3dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypePoint3dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeVector3hArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeVector3hArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeVector3fArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeVector3fArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeVector3dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeVector3dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeNormal3hArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeNormal3hArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeNormal3fArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeNormal3fArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeNormal3dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeNormal3dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor3hArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor3hArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor3fArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor3fArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor3dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor3dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor4hArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor4hArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor4fArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor4fArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeColor4dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeColor4dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeQuathArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeQuathArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeQuatfArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeQuatfArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeQuatdArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeQuatdArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeMatrix2dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeMatrix2dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeMatrix3dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeMatrix3dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeMatrix4dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeMatrix4dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeFrame4dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeFrame4dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord2hArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord2hArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord2fArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord2fArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord2dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord2dArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord3hArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord3hArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord3fArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord3fArray(), cMemoryOwn: true);
		}

		public static SdfValueTypeName SdfGetValueTypeTexCoord3dArray()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfGetValueTypeTexCoord3dArray(), cMemoryOwn: true);
		}
	}
}
