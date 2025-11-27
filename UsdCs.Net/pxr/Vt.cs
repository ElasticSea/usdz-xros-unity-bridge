namespace pxr
{
	public class Vt
	{
		public static VtDictionary VtGetEmptyDictionary()
		{
			return new VtDictionary(VtPINVOKE.VtGetEmptyDictionary(), cMemoryOwn: false);
		}

		public static VtDictionary VtDictionaryOver(VtDictionary strong, VtDictionary weak, bool coerceToWeakerOpinionType)
		{
			VtDictionary result = new VtDictionary(VtPINVOKE.VtDictionaryOver__SWIG_0(VtDictionary.getCPtr(strong), VtDictionary.getCPtr(weak), coerceToWeakerOpinionType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static VtDictionary VtDictionaryOver(VtDictionary strong, VtDictionary weak)
		{
			VtDictionary result = new VtDictionary(VtPINVOKE.VtDictionaryOver__SWIG_1(VtDictionary.getCPtr(strong), VtDictionary.getCPtr(weak)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static VtDictionary VtDictionaryOverRecursive(VtDictionary strong, VtDictionary weak, bool coerceToWeakerOpinionType)
		{
			VtDictionary result = new VtDictionary(VtPINVOKE.VtDictionaryOverRecursive__SWIG_0(VtDictionary.getCPtr(strong), VtDictionary.getCPtr(weak), coerceToWeakerOpinionType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static VtDictionary VtDictionaryOverRecursive(VtDictionary strong, VtDictionary weak)
		{
			VtDictionary result = new VtDictionary(VtPINVOKE.VtDictionaryOverRecursive__SWIG_1(VtDictionary.getCPtr(strong), VtDictionary.getCPtr(weak)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double VtValueTodouble(VtValue value)
		{
			double result = VtPINVOKE.VtValueTodouble__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueTodouble(VtValue value, out double output)
		{
			VtPINVOKE.VtValueTodouble__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtDoubleArray VtValueToVtDoubleArray(VtValue value)
		{
			VtDoubleArray result = new VtDoubleArray(VtPINVOKE.VtValueToVtDoubleArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtDoubleArray(VtValue value, out VtDoubleArray output)
		{
			VtDoubleArray vtDoubleArray = new VtDoubleArray();
			try
			{
				VtPINVOKE.VtValueToVtDoubleArray__SWIG_1(VtValue.getCPtr(value), VtDoubleArray.getCPtr(vtDoubleArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtDoubleArray;
			}
		}

		public static float VtValueTofloat(VtValue value)
		{
			float result = VtPINVOKE.VtValueTofloat__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueTofloat(VtValue value, out float output)
		{
			VtPINVOKE.VtValueTofloat__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtFloatArray VtValueToVtFloatArray(VtValue value)
		{
			VtFloatArray result = new VtFloatArray(VtPINVOKE.VtValueToVtFloatArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtFloatArray(VtValue value, out VtFloatArray output)
		{
			VtFloatArray vtFloatArray = new VtFloatArray();
			try
			{
				VtPINVOKE.VtValueToVtFloatArray__SWIG_1(VtValue.getCPtr(value), VtFloatArray.getCPtr(vtFloatArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtFloatArray;
			}
		}

		public static GfHalf VtValueToGfHalf(VtValue value)
		{
			GfHalf result = new GfHalf(VtPINVOKE.VtValueToGfHalf__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfHalf(VtValue value, out GfHalf output)
		{
			GfHalf gfHalf = new GfHalf();
			try
			{
				VtPINVOKE.VtValueToGfHalf__SWIG_1(VtValue.getCPtr(value), GfHalf.getCPtr(gfHalf));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfHalf;
			}
		}

		public static VtHalfArray VtValueToVtHalfArray(VtValue value)
		{
			VtHalfArray result = new VtHalfArray(VtPINVOKE.VtValueToVtHalfArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtHalfArray(VtValue value, out VtHalfArray output)
		{
			VtHalfArray vtHalfArray = new VtHalfArray();
			try
			{
				VtPINVOKE.VtValueToVtHalfArray__SWIG_1(VtValue.getCPtr(value), VtHalfArray.getCPtr(vtHalfArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtHalfArray;
			}
		}

		public static bool VtValueTobool(VtValue value)
		{
			bool result = VtPINVOKE.VtValueTobool__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueTobool(VtValue value, out bool output)
		{
			VtPINVOKE.VtValueTobool__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtBoolArray VtValueToVtBoolArray(VtValue value)
		{
			VtBoolArray result = new VtBoolArray(VtPINVOKE.VtValueToVtBoolArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtBoolArray(VtValue value, out VtBoolArray output)
		{
			VtBoolArray vtBoolArray = new VtBoolArray();
			try
			{
				VtPINVOKE.VtValueToVtBoolArray__SWIG_1(VtValue.getCPtr(value), VtBoolArray.getCPtr(vtBoolArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtBoolArray;
			}
		}

		public static char VtValueTochar(VtValue value)
		{
			char result = VtPINVOKE.VtValueTochar__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueTochar(VtValue value, out char output)
		{
			VtPINVOKE.VtValueTochar__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtCharArray VtValueToVtCharArray(VtValue value)
		{
			VtCharArray result = new VtCharArray(VtPINVOKE.VtValueToVtCharArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtCharArray(VtValue value, out VtCharArray output)
		{
			VtCharArray vtCharArray = new VtCharArray();
			try
			{
				VtPINVOKE.VtValueToVtCharArray__SWIG_1(VtValue.getCPtr(value), VtCharArray.getCPtr(vtCharArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtCharArray;
			}
		}

		public static byte VtValueTobyte(VtValue value)
		{
			byte result = VtPINVOKE.VtValueTobyte__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueTobyte(VtValue value, out byte output)
		{
			VtPINVOKE.VtValueTobyte__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtUCharArray VtValueToVtUCharArray(VtValue value)
		{
			VtUCharArray result = new VtUCharArray(VtPINVOKE.VtValueToVtUCharArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtUCharArray(VtValue value, out VtUCharArray output)
		{
			VtUCharArray vtUCharArray = new VtUCharArray();
			try
			{
				VtPINVOKE.VtValueToVtUCharArray__SWIG_1(VtValue.getCPtr(value), VtUCharArray.getCPtr(vtUCharArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtUCharArray;
			}
		}

		public static int VtValueToint(VtValue value)
		{
			int result = VtPINVOKE.VtValueToint__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToint(VtValue value, out int output)
		{
			VtPINVOKE.VtValueToint__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtIntArray VtValueToVtIntArray(VtValue value)
		{
			VtIntArray result = new VtIntArray(VtPINVOKE.VtValueToVtIntArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtIntArray(VtValue value, out VtIntArray output)
		{
			VtIntArray vtIntArray = new VtIntArray();
			try
			{
				VtPINVOKE.VtValueToVtIntArray__SWIG_1(VtValue.getCPtr(value), VtIntArray.getCPtr(vtIntArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtIntArray;
			}
		}

		public static uint VtValueTouint(VtValue value)
		{
			uint result = VtPINVOKE.VtValueTouint__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueTouint(VtValue value, out uint output)
		{
			VtPINVOKE.VtValueTouint__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtUIntArray VtValueToVtUIntArray(VtValue value)
		{
			VtUIntArray result = new VtUIntArray(VtPINVOKE.VtValueToVtUIntArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtUIntArray(VtValue value, out VtUIntArray output)
		{
			VtUIntArray vtUIntArray = new VtUIntArray();
			try
			{
				VtPINVOKE.VtValueToVtUIntArray__SWIG_1(VtValue.getCPtr(value), VtUIntArray.getCPtr(vtUIntArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtUIntArray;
			}
		}

		public static long VtValueTolong(VtValue value)
		{
			long result = VtPINVOKE.VtValueTolong__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueTolong(VtValue value, out long output)
		{
			VtPINVOKE.VtValueTolong__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtInt64Array VtValueToVtInt64Array(VtValue value)
		{
			VtInt64Array result = new VtInt64Array(VtPINVOKE.VtValueToVtInt64Array__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtInt64Array(VtValue value, out VtInt64Array output)
		{
			VtInt64Array vtInt64Array = new VtInt64Array();
			try
			{
				VtPINVOKE.VtValueToVtInt64Array__SWIG_1(VtValue.getCPtr(value), VtInt64Array.getCPtr(vtInt64Array));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtInt64Array;
			}
		}

		public static ulong VtValueToulong(VtValue value)
		{
			ulong result = VtPINVOKE.VtValueToulong__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToulong(VtValue value, out ulong output)
		{
			VtPINVOKE.VtValueToulong__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtUInt64Array VtValueToVtUInt64Array(VtValue value)
		{
			VtUInt64Array result = new VtUInt64Array(VtPINVOKE.VtValueToVtUInt64Array__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtUInt64Array(VtValue value, out VtUInt64Array output)
		{
			VtUInt64Array vtUInt64Array = new VtUInt64Array();
			try
			{
				VtPINVOKE.VtValueToVtUInt64Array__SWIG_1(VtValue.getCPtr(value), VtUInt64Array.getCPtr(vtUInt64Array));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtUInt64Array;
			}
		}

		public static GfVec4i VtValueToGfVec4i(VtValue value)
		{
			GfVec4i result = new GfVec4i(VtPINVOKE.VtValueToGfVec4i__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec4i(VtValue value, out GfVec4i output)
		{
			GfVec4i gfVec4i = new GfVec4i();
			try
			{
				VtPINVOKE.VtValueToGfVec4i__SWIG_1(VtValue.getCPtr(value), GfVec4i.getCPtr(gfVec4i));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec4i;
			}
		}

		public static VtVec4iArray VtValueToVtVec4iArray(VtValue value)
		{
			VtVec4iArray result = new VtVec4iArray(VtPINVOKE.VtValueToVtVec4iArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec4iArray(VtValue value, out VtVec4iArray output)
		{
			VtVec4iArray vtVec4iArray = new VtVec4iArray();
			try
			{
				VtPINVOKE.VtValueToVtVec4iArray__SWIG_1(VtValue.getCPtr(value), VtVec4iArray.getCPtr(vtVec4iArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec4iArray;
			}
		}

		public static GfVec3i VtValueToGfVec3i(VtValue value)
		{
			GfVec3i result = new GfVec3i(VtPINVOKE.VtValueToGfVec3i__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec3i(VtValue value, out GfVec3i output)
		{
			GfVec3i gfVec3i = new GfVec3i();
			try
			{
				VtPINVOKE.VtValueToGfVec3i__SWIG_1(VtValue.getCPtr(value), GfVec3i.getCPtr(gfVec3i));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec3i;
			}
		}

		public static VtVec3iArray VtValueToVtVec3iArray(VtValue value)
		{
			VtVec3iArray result = new VtVec3iArray(VtPINVOKE.VtValueToVtVec3iArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec3iArray(VtValue value, out VtVec3iArray output)
		{
			VtVec3iArray vtVec3iArray = new VtVec3iArray();
			try
			{
				VtPINVOKE.VtValueToVtVec3iArray__SWIG_1(VtValue.getCPtr(value), VtVec3iArray.getCPtr(vtVec3iArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec3iArray;
			}
		}

		public static GfVec2i VtValueToGfVec2i(VtValue value)
		{
			GfVec2i result = new GfVec2i(VtPINVOKE.VtValueToGfVec2i__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec2i(VtValue value, out GfVec2i output)
		{
			GfVec2i gfVec2i = new GfVec2i();
			try
			{
				VtPINVOKE.VtValueToGfVec2i__SWIG_1(VtValue.getCPtr(value), GfVec2i.getCPtr(gfVec2i));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec2i;
			}
		}

		public static VtVec2iArray VtValueToVtVec2iArray(VtValue value)
		{
			VtVec2iArray result = new VtVec2iArray(VtPINVOKE.VtValueToVtVec2iArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec2iArray(VtValue value, out VtVec2iArray output)
		{
			VtVec2iArray vtVec2iArray = new VtVec2iArray();
			try
			{
				VtPINVOKE.VtValueToVtVec2iArray__SWIG_1(VtValue.getCPtr(value), VtVec2iArray.getCPtr(vtVec2iArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec2iArray;
			}
		}

		public static GfVec4h VtValueToGfVec4h(VtValue value)
		{
			GfVec4h result = new GfVec4h(VtPINVOKE.VtValueToGfVec4h__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec4h(VtValue value, out GfVec4h output)
		{
			GfVec4h gfVec4h = new GfVec4h();
			try
			{
				VtPINVOKE.VtValueToGfVec4h__SWIG_1(VtValue.getCPtr(value), GfVec4h.getCPtr(gfVec4h));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec4h;
			}
		}

		public static VtVec4hArray VtValueToVtVec4hArray(VtValue value)
		{
			VtVec4hArray result = new VtVec4hArray(VtPINVOKE.VtValueToVtVec4hArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec4hArray(VtValue value, out VtVec4hArray output)
		{
			VtVec4hArray vtVec4hArray = new VtVec4hArray();
			try
			{
				VtPINVOKE.VtValueToVtVec4hArray__SWIG_1(VtValue.getCPtr(value), VtVec4hArray.getCPtr(vtVec4hArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec4hArray;
			}
		}

		public static GfVec3h VtValueToGfVec3h(VtValue value)
		{
			GfVec3h result = new GfVec3h(VtPINVOKE.VtValueToGfVec3h__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec3h(VtValue value, out GfVec3h output)
		{
			GfVec3h gfVec3h = new GfVec3h();
			try
			{
				VtPINVOKE.VtValueToGfVec3h__SWIG_1(VtValue.getCPtr(value), GfVec3h.getCPtr(gfVec3h));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec3h;
			}
		}

		public static VtVec3hArray VtValueToVtVec3hArray(VtValue value)
		{
			VtVec3hArray result = new VtVec3hArray(VtPINVOKE.VtValueToVtVec3hArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec3hArray(VtValue value, out VtVec3hArray output)
		{
			VtVec3hArray vtVec3hArray = new VtVec3hArray();
			try
			{
				VtPINVOKE.VtValueToVtVec3hArray__SWIG_1(VtValue.getCPtr(value), VtVec3hArray.getCPtr(vtVec3hArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec3hArray;
			}
		}

		public static GfVec2h VtValueToGfVec2h(VtValue value)
		{
			GfVec2h result = new GfVec2h(VtPINVOKE.VtValueToGfVec2h__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec2h(VtValue value, out GfVec2h output)
		{
			GfVec2h gfVec2h = new GfVec2h();
			try
			{
				VtPINVOKE.VtValueToGfVec2h__SWIG_1(VtValue.getCPtr(value), GfVec2h.getCPtr(gfVec2h));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec2h;
			}
		}

		public static VtVec2hArray VtValueToVtVec2hArray(VtValue value)
		{
			VtVec2hArray result = new VtVec2hArray(VtPINVOKE.VtValueToVtVec2hArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec2hArray(VtValue value, out VtVec2hArray output)
		{
			VtVec2hArray vtVec2hArray = new VtVec2hArray();
			try
			{
				VtPINVOKE.VtValueToVtVec2hArray__SWIG_1(VtValue.getCPtr(value), VtVec2hArray.getCPtr(vtVec2hArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec2hArray;
			}
		}

		public static GfVec4f VtValueToGfVec4f(VtValue value)
		{
			GfVec4f result = new GfVec4f(VtPINVOKE.VtValueToGfVec4f__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec4f(VtValue value, out GfVec4f output)
		{
			GfVec4f gfVec4f = new GfVec4f();
			try
			{
				VtPINVOKE.VtValueToGfVec4f__SWIG_1(VtValue.getCPtr(value), GfVec4f.getCPtr(gfVec4f));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec4f;
			}
		}

		public static VtVec4fArray VtValueToVtVec4fArray(VtValue value)
		{
			VtVec4fArray result = new VtVec4fArray(VtPINVOKE.VtValueToVtVec4fArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec4fArray(VtValue value, out VtVec4fArray output)
		{
			VtVec4fArray vtVec4fArray = new VtVec4fArray();
			try
			{
				VtPINVOKE.VtValueToVtVec4fArray__SWIG_1(VtValue.getCPtr(value), VtVec4fArray.getCPtr(vtVec4fArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec4fArray;
			}
		}

		public static GfVec3f VtValueToGfVec3f(VtValue value)
		{
			GfVec3f result = new GfVec3f(VtPINVOKE.VtValueToGfVec3f__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec3f(VtValue value, out GfVec3f output)
		{
			GfVec3f gfVec3f = new GfVec3f();
			try
			{
				VtPINVOKE.VtValueToGfVec3f__SWIG_1(VtValue.getCPtr(value), GfVec3f.getCPtr(gfVec3f));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec3f;
			}
		}

		public static VtVec3fArray VtValueToVtVec3fArray(VtValue value)
		{
			VtVec3fArray result = new VtVec3fArray(VtPINVOKE.VtValueToVtVec3fArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec3fArray(VtValue value, out VtVec3fArray output)
		{
			VtVec3fArray vtVec3fArray = new VtVec3fArray();
			try
			{
				VtPINVOKE.VtValueToVtVec3fArray__SWIG_1(VtValue.getCPtr(value), VtVec3fArray.getCPtr(vtVec3fArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec3fArray;
			}
		}

		public static GfVec2f VtValueToGfVec2f(VtValue value)
		{
			GfVec2f result = new GfVec2f(VtPINVOKE.VtValueToGfVec2f__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec2f(VtValue value, out GfVec2f output)
		{
			GfVec2f gfVec2f = new GfVec2f();
			try
			{
				VtPINVOKE.VtValueToGfVec2f__SWIG_1(VtValue.getCPtr(value), GfVec2f.getCPtr(gfVec2f));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec2f;
			}
		}

		public static VtVec2fArray VtValueToVtVec2fArray(VtValue value)
		{
			VtVec2fArray result = new VtVec2fArray(VtPINVOKE.VtValueToVtVec2fArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec2fArray(VtValue value, out VtVec2fArray output)
		{
			VtVec2fArray vtVec2fArray = new VtVec2fArray();
			try
			{
				VtPINVOKE.VtValueToVtVec2fArray__SWIG_1(VtValue.getCPtr(value), VtVec2fArray.getCPtr(vtVec2fArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec2fArray;
			}
		}

		public static GfVec4d VtValueToGfVec4d(VtValue value)
		{
			GfVec4d result = new GfVec4d(VtPINVOKE.VtValueToGfVec4d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec4d(VtValue value, out GfVec4d output)
		{
			GfVec4d gfVec4d = new GfVec4d();
			try
			{
				VtPINVOKE.VtValueToGfVec4d__SWIG_1(VtValue.getCPtr(value), GfVec4d.getCPtr(gfVec4d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec4d;
			}
		}

		public static VtVec4dArray VtValueToVtVec4dArray(VtValue value)
		{
			VtVec4dArray result = new VtVec4dArray(VtPINVOKE.VtValueToVtVec4dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec4dArray(VtValue value, out VtVec4dArray output)
		{
			VtVec4dArray vtVec4dArray = new VtVec4dArray();
			try
			{
				VtPINVOKE.VtValueToVtVec4dArray__SWIG_1(VtValue.getCPtr(value), VtVec4dArray.getCPtr(vtVec4dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec4dArray;
			}
		}

		public static GfVec3d VtValueToGfVec3d(VtValue value)
		{
			GfVec3d result = new GfVec3d(VtPINVOKE.VtValueToGfVec3d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec3d(VtValue value, out GfVec3d output)
		{
			GfVec3d gfVec3d = new GfVec3d();
			try
			{
				VtPINVOKE.VtValueToGfVec3d__SWIG_1(VtValue.getCPtr(value), GfVec3d.getCPtr(gfVec3d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec3d;
			}
		}

		public static VtVec3dArray VtValueToVtVec3dArray(VtValue value)
		{
			VtVec3dArray result = new VtVec3dArray(VtPINVOKE.VtValueToVtVec3dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec3dArray(VtValue value, out VtVec3dArray output)
		{
			VtVec3dArray vtVec3dArray = new VtVec3dArray();
			try
			{
				VtPINVOKE.VtValueToVtVec3dArray__SWIG_1(VtValue.getCPtr(value), VtVec3dArray.getCPtr(vtVec3dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec3dArray;
			}
		}

		public static GfVec2d VtValueToGfVec2d(VtValue value)
		{
			GfVec2d result = new GfVec2d(VtPINVOKE.VtValueToGfVec2d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfVec2d(VtValue value, out GfVec2d output)
		{
			GfVec2d gfVec2d = new GfVec2d();
			try
			{
				VtPINVOKE.VtValueToGfVec2d__SWIG_1(VtValue.getCPtr(value), GfVec2d.getCPtr(gfVec2d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfVec2d;
			}
		}

		public static VtVec2dArray VtValueToVtVec2dArray(VtValue value)
		{
			VtVec2dArray result = new VtVec2dArray(VtPINVOKE.VtValueToVtVec2dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtVec2dArray(VtValue value, out VtVec2dArray output)
		{
			VtVec2dArray vtVec2dArray = new VtVec2dArray();
			try
			{
				VtPINVOKE.VtValueToVtVec2dArray__SWIG_1(VtValue.getCPtr(value), VtVec2dArray.getCPtr(vtVec2dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtVec2dArray;
			}
		}

		public static GfMatrix4d VtValueToGfMatrix4d(VtValue value)
		{
			GfMatrix4d result = new GfMatrix4d(VtPINVOKE.VtValueToGfMatrix4d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfMatrix4d(VtValue value, out GfMatrix4d output)
		{
			GfMatrix4d gfMatrix4d = new GfMatrix4d();
			try
			{
				VtPINVOKE.VtValueToGfMatrix4d__SWIG_1(VtValue.getCPtr(value), GfMatrix4d.getCPtr(gfMatrix4d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfMatrix4d;
			}
		}

		public static VtMatrix4dArray VtValueToVtMatrix4dArray(VtValue value)
		{
			VtMatrix4dArray result = new VtMatrix4dArray(VtPINVOKE.VtValueToVtMatrix4dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtMatrix4dArray(VtValue value, out VtMatrix4dArray output)
		{
			VtMatrix4dArray vtMatrix4dArray = new VtMatrix4dArray();
			try
			{
				VtPINVOKE.VtValueToVtMatrix4dArray__SWIG_1(VtValue.getCPtr(value), VtMatrix4dArray.getCPtr(vtMatrix4dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtMatrix4dArray;
			}
		}

		public static GfMatrix3d VtValueToGfMatrix3d(VtValue value)
		{
			GfMatrix3d result = new GfMatrix3d(VtPINVOKE.VtValueToGfMatrix3d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfMatrix3d(VtValue value, out GfMatrix3d output)
		{
			GfMatrix3d gfMatrix3d = new GfMatrix3d();
			try
			{
				VtPINVOKE.VtValueToGfMatrix3d__SWIG_1(VtValue.getCPtr(value), GfMatrix3d.getCPtr(gfMatrix3d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfMatrix3d;
			}
		}

		public static VtMatrix3dArray VtValueToVtMatrix3dArray(VtValue value)
		{
			VtMatrix3dArray result = new VtMatrix3dArray(VtPINVOKE.VtValueToVtMatrix3dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtMatrix3dArray(VtValue value, out VtMatrix3dArray output)
		{
			VtMatrix3dArray vtMatrix3dArray = new VtMatrix3dArray();
			try
			{
				VtPINVOKE.VtValueToVtMatrix3dArray__SWIG_1(VtValue.getCPtr(value), VtMatrix3dArray.getCPtr(vtMatrix3dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtMatrix3dArray;
			}
		}

		public static GfMatrix2d VtValueToGfMatrix2d(VtValue value)
		{
			GfMatrix2d result = new GfMatrix2d(VtPINVOKE.VtValueToGfMatrix2d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfMatrix2d(VtValue value, out GfMatrix2d output)
		{
			GfMatrix2d gfMatrix2d = new GfMatrix2d();
			try
			{
				VtPINVOKE.VtValueToGfMatrix2d__SWIG_1(VtValue.getCPtr(value), GfMatrix2d.getCPtr(gfMatrix2d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfMatrix2d;
			}
		}

		public static VtMatrix2dArray VtValueToVtMatrix2dArray(VtValue value)
		{
			VtMatrix2dArray result = new VtMatrix2dArray(VtPINVOKE.VtValueToVtMatrix2dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtMatrix2dArray(VtValue value, out VtMatrix2dArray output)
		{
			VtMatrix2dArray vtMatrix2dArray = new VtMatrix2dArray();
			try
			{
				VtPINVOKE.VtValueToVtMatrix2dArray__SWIG_1(VtValue.getCPtr(value), VtMatrix2dArray.getCPtr(vtMatrix2dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtMatrix2dArray;
			}
		}

		public static GfMatrix4f VtValueToGfMatrix4f(VtValue value)
		{
			GfMatrix4f result = new GfMatrix4f(VtPINVOKE.VtValueToGfMatrix4f__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfMatrix4f(VtValue value, out GfMatrix4f output)
		{
			GfMatrix4f gfMatrix4f = new GfMatrix4f();
			try
			{
				VtPINVOKE.VtValueToGfMatrix4f__SWIG_1(VtValue.getCPtr(value), GfMatrix4f.getCPtr(gfMatrix4f));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfMatrix4f;
			}
		}

		public static VtMatrix4fArray VtValueToVtMatrix4fArray(VtValue value)
		{
			VtMatrix4fArray result = new VtMatrix4fArray(VtPINVOKE.VtValueToVtMatrix4fArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtMatrix4fArray(VtValue value, out VtMatrix4fArray output)
		{
			VtMatrix4fArray vtMatrix4fArray = new VtMatrix4fArray();
			try
			{
				VtPINVOKE.VtValueToVtMatrix4fArray__SWIG_1(VtValue.getCPtr(value), VtMatrix4fArray.getCPtr(vtMatrix4fArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtMatrix4fArray;
			}
		}

		public static GfMatrix3f VtValueToGfMatrix3f(VtValue value)
		{
			GfMatrix3f result = new GfMatrix3f(VtPINVOKE.VtValueToGfMatrix3f__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfMatrix3f(VtValue value, out GfMatrix3f output)
		{
			GfMatrix3f gfMatrix3f = new GfMatrix3f();
			try
			{
				VtPINVOKE.VtValueToGfMatrix3f__SWIG_1(VtValue.getCPtr(value), GfMatrix3f.getCPtr(gfMatrix3f));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfMatrix3f;
			}
		}

		public static VtMatrix3fArray VtValueToVtMatrix3fArray(VtValue value)
		{
			VtMatrix3fArray result = new VtMatrix3fArray(VtPINVOKE.VtValueToVtMatrix3fArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtMatrix3fArray(VtValue value, out VtMatrix3fArray output)
		{
			VtMatrix3fArray vtMatrix3fArray = new VtMatrix3fArray();
			try
			{
				VtPINVOKE.VtValueToVtMatrix3fArray__SWIG_1(VtValue.getCPtr(value), VtMatrix3fArray.getCPtr(vtMatrix3fArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtMatrix3fArray;
			}
		}

		public static GfMatrix2f VtValueToGfMatrix2f(VtValue value)
		{
			GfMatrix2f result = new GfMatrix2f(VtPINVOKE.VtValueToGfMatrix2f__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfMatrix2f(VtValue value, out GfMatrix2f output)
		{
			GfMatrix2f gfMatrix2f = new GfMatrix2f();
			try
			{
				VtPINVOKE.VtValueToGfMatrix2f__SWIG_1(VtValue.getCPtr(value), GfMatrix2f.getCPtr(gfMatrix2f));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfMatrix2f;
			}
		}

		public static VtMatrix2fArray VtValueToVtMatrix2fArray(VtValue value)
		{
			VtMatrix2fArray result = new VtMatrix2fArray(VtPINVOKE.VtValueToVtMatrix2fArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtMatrix2fArray(VtValue value, out VtMatrix2fArray output)
		{
			VtMatrix2fArray vtMatrix2fArray = new VtMatrix2fArray();
			try
			{
				VtPINVOKE.VtValueToVtMatrix2fArray__SWIG_1(VtValue.getCPtr(value), VtMatrix2fArray.getCPtr(vtMatrix2fArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtMatrix2fArray;
			}
		}

		public static GfRange3d VtValueToGfRange3d(VtValue value)
		{
			GfRange3d result = new GfRange3d(VtPINVOKE.VtValueToGfRange3d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfRange3d(VtValue value, out GfRange3d output)
		{
			GfRange3d gfRange3d = new GfRange3d();
			try
			{
				VtPINVOKE.VtValueToGfRange3d__SWIG_1(VtValue.getCPtr(value), GfRange3d.getCPtr(gfRange3d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfRange3d;
			}
		}

		public static VtRange3dArray VtValueToVtRange3dArray(VtValue value)
		{
			VtRange3dArray result = new VtRange3dArray(VtPINVOKE.VtValueToVtRange3dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtRange3dArray(VtValue value, out VtRange3dArray output)
		{
			VtRange3dArray vtRange3dArray = new VtRange3dArray();
			try
			{
				VtPINVOKE.VtValueToVtRange3dArray__SWIG_1(VtValue.getCPtr(value), VtRange3dArray.getCPtr(vtRange3dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtRange3dArray;
			}
		}

		public static GfRange2d VtValueToGfRange2d(VtValue value)
		{
			GfRange2d result = new GfRange2d(VtPINVOKE.VtValueToGfRange2d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfRange2d(VtValue value, out GfRange2d output)
		{
			GfRange2d gfRange2d = new GfRange2d();
			try
			{
				VtPINVOKE.VtValueToGfRange2d__SWIG_1(VtValue.getCPtr(value), GfRange2d.getCPtr(gfRange2d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfRange2d;
			}
		}

		public static VtRange2dArray VtValueToVtRange2dArray(VtValue value)
		{
			VtRange2dArray result = new VtRange2dArray(VtPINVOKE.VtValueToVtRange2dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtRange2dArray(VtValue value, out VtRange2dArray output)
		{
			VtRange2dArray vtRange2dArray = new VtRange2dArray();
			try
			{
				VtPINVOKE.VtValueToVtRange2dArray__SWIG_1(VtValue.getCPtr(value), VtRange2dArray.getCPtr(vtRange2dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtRange2dArray;
			}
		}

		public static GfRange1f VtValueToGfRange1f(VtValue value)
		{
			GfRange1f result = new GfRange1f(VtPINVOKE.VtValueToGfRange1f__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfRange1f(VtValue value, out GfRange1f output)
		{
			GfRange1f gfRange1f = new GfRange1f();
			try
			{
				VtPINVOKE.VtValueToGfRange1f__SWIG_1(VtValue.getCPtr(value), GfRange1f.getCPtr(gfRange1f));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfRange1f;
			}
		}

		public static VtRange1fArray VtValueToVtRange1fArray(VtValue value)
		{
			VtRange1fArray result = new VtRange1fArray(VtPINVOKE.VtValueToVtRange1fArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtRange1fArray(VtValue value, out VtRange1fArray output)
		{
			VtRange1fArray vtRange1fArray = new VtRange1fArray();
			try
			{
				VtPINVOKE.VtValueToVtRange1fArray__SWIG_1(VtValue.getCPtr(value), VtRange1fArray.getCPtr(vtRange1fArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtRange1fArray;
			}
		}

		public static GfRange1d VtValueToGfRange1d(VtValue value)
		{
			GfRange1d result = new GfRange1d(VtPINVOKE.VtValueToGfRange1d__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfRange1d(VtValue value, out GfRange1d output)
		{
			GfRange1d gfRange1d = new GfRange1d();
			try
			{
				VtPINVOKE.VtValueToGfRange1d__SWIG_1(VtValue.getCPtr(value), GfRange1d.getCPtr(gfRange1d));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfRange1d;
			}
		}

		public static VtRange1dArray VtValueToVtRange1dArray(VtValue value)
		{
			VtRange1dArray result = new VtRange1dArray(VtPINVOKE.VtValueToVtRange1dArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtRange1dArray(VtValue value, out VtRange1dArray output)
		{
			VtRange1dArray vtRange1dArray = new VtRange1dArray();
			try
			{
				VtPINVOKE.VtValueToVtRange1dArray__SWIG_1(VtValue.getCPtr(value), VtRange1dArray.getCPtr(vtRange1dArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtRange1dArray;
			}
		}

		public static GfInterval VtValueToGfInterval(VtValue value)
		{
			GfInterval result = new GfInterval(VtPINVOKE.VtValueToGfInterval__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfInterval(VtValue value, out GfInterval output)
		{
			GfInterval gfInterval = new GfInterval();
			try
			{
				VtPINVOKE.VtValueToGfInterval__SWIG_1(VtValue.getCPtr(value), GfInterval.getCPtr(gfInterval));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfInterval;
			}
		}

		public static VtIntervalArray VtValueToVtIntervalArray(VtValue value)
		{
			VtIntervalArray result = new VtIntervalArray(VtPINVOKE.VtValueToVtIntervalArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtIntervalArray(VtValue value, out VtIntervalArray output)
		{
			VtIntervalArray vtIntervalArray = new VtIntervalArray();
			try
			{
				VtPINVOKE.VtValueToVtIntervalArray__SWIG_1(VtValue.getCPtr(value), VtIntervalArray.getCPtr(vtIntervalArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtIntervalArray;
			}
		}

		public static string VtValueTostring(VtValue value)
		{
			string result = VtPINVOKE.VtValueTostring__SWIG_0(VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueTostring(VtValue value, out string output)
		{
			VtPINVOKE.VtValueTostring__SWIG_1(VtValue.getCPtr(value), out output);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtStringArray VtValueToVtStringArray(VtValue value)
		{
			VtStringArray result = new VtStringArray(VtPINVOKE.VtValueToVtStringArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtStringArray(VtValue value, out VtStringArray output)
		{
			VtStringArray vtStringArray = new VtStringArray();
			try
			{
				VtPINVOKE.VtValueToVtStringArray__SWIG_1(VtValue.getCPtr(value), VtStringArray.getCPtr(vtStringArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtStringArray;
			}
		}

		public static TfToken VtValueToTfToken(VtValue value)
		{
			TfToken result = new TfToken(VtPINVOKE.VtValueToTfToken__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToTfToken(VtValue value, out TfToken output)
		{
			TfToken tfToken = new TfToken();
			try
			{
				VtPINVOKE.VtValueToTfToken__SWIG_1(VtValue.getCPtr(value), TfToken.getCPtr(tfToken));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = tfToken;
			}
		}

		public static VtTokenArray VtValueToVtTokenArray(VtValue value)
		{
			VtTokenArray result = new VtTokenArray(VtPINVOKE.VtValueToVtTokenArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtTokenArray(VtValue value, out VtTokenArray output)
		{
			VtTokenArray vtTokenArray = new VtTokenArray();
			try
			{
				VtPINVOKE.VtValueToVtTokenArray__SWIG_1(VtValue.getCPtr(value), VtTokenArray.getCPtr(vtTokenArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtTokenArray;
			}
		}

		public static GfQuath VtValueToGfQuath(VtValue value)
		{
			GfQuath result = new GfQuath(VtPINVOKE.VtValueToGfQuath__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfQuath(VtValue value, out GfQuath output)
		{
			GfQuath gfQuath = new GfQuath();
			try
			{
				VtPINVOKE.VtValueToGfQuath__SWIG_1(VtValue.getCPtr(value), GfQuath.getCPtr(gfQuath));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfQuath;
			}
		}

		public static VtQuathArray VtValueToVtQuathArray(VtValue value)
		{
			VtQuathArray result = new VtQuathArray(VtPINVOKE.VtValueToVtQuathArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtQuathArray(VtValue value, out VtQuathArray output)
		{
			VtQuathArray vtQuathArray = new VtQuathArray();
			try
			{
				VtPINVOKE.VtValueToVtQuathArray__SWIG_1(VtValue.getCPtr(value), VtQuathArray.getCPtr(vtQuathArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtQuathArray;
			}
		}

		public static GfQuatf VtValueToGfQuatf(VtValue value)
		{
			GfQuatf result = new GfQuatf(VtPINVOKE.VtValueToGfQuatf__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfQuatf(VtValue value, out GfQuatf output)
		{
			GfQuatf gfQuatf = new GfQuatf();
			try
			{
				VtPINVOKE.VtValueToGfQuatf__SWIG_1(VtValue.getCPtr(value), GfQuatf.getCPtr(gfQuatf));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfQuatf;
			}
		}

		public static VtQuatfArray VtValueToVtQuatfArray(VtValue value)
		{
			VtQuatfArray result = new VtQuatfArray(VtPINVOKE.VtValueToVtQuatfArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtQuatfArray(VtValue value, out VtQuatfArray output)
		{
			VtQuatfArray vtQuatfArray = new VtQuatfArray();
			try
			{
				VtPINVOKE.VtValueToVtQuatfArray__SWIG_1(VtValue.getCPtr(value), VtQuatfArray.getCPtr(vtQuatfArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtQuatfArray;
			}
		}

		public static GfQuatd VtValueToGfQuatd(VtValue value)
		{
			GfQuatd result = new GfQuatd(VtPINVOKE.VtValueToGfQuatd__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfQuatd(VtValue value, out GfQuatd output)
		{
			GfQuatd gfQuatd = new GfQuatd();
			try
			{
				VtPINVOKE.VtValueToGfQuatd__SWIG_1(VtValue.getCPtr(value), GfQuatd.getCPtr(gfQuatd));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfQuatd;
			}
		}

		public static VtQuatdArray VtValueToVtQuatdArray(VtValue value)
		{
			VtQuatdArray result = new VtQuatdArray(VtPINVOKE.VtValueToVtQuatdArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtQuatdArray(VtValue value, out VtQuatdArray output)
		{
			VtQuatdArray vtQuatdArray = new VtQuatdArray();
			try
			{
				VtPINVOKE.VtValueToVtQuatdArray__SWIG_1(VtValue.getCPtr(value), VtQuatdArray.getCPtr(vtQuatdArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtQuatdArray;
			}
		}

		public static GfQuaternion VtValueToGfQuaternion(VtValue value)
		{
			GfQuaternion result = new GfQuaternion(VtPINVOKE.VtValueToGfQuaternion__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfQuaternion(VtValue value, out GfQuaternion output)
		{
			GfQuaternion gfQuaternion = new GfQuaternion();
			try
			{
				VtPINVOKE.VtValueToGfQuaternion__SWIG_1(VtValue.getCPtr(value), GfQuaternion.getCPtr(gfQuaternion));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfQuaternion;
			}
		}

		public static VtQuaternionArray VtValueToVtQuaternionArray(VtValue value)
		{
			VtQuaternionArray result = new VtQuaternionArray(VtPINVOKE.VtValueToVtQuaternionArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtQuaternionArray(VtValue value, out VtQuaternionArray output)
		{
			VtQuaternionArray vtQuaternionArray = new VtQuaternionArray();
			try
			{
				VtPINVOKE.VtValueToVtQuaternionArray__SWIG_1(VtValue.getCPtr(value), VtQuaternionArray.getCPtr(vtQuaternionArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtQuaternionArray;
			}
		}

		public static GfDualQuath VtValueToGfDualQuath(VtValue value)
		{
			GfDualQuath result = new GfDualQuath(VtPINVOKE.VtValueToGfDualQuath__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfDualQuath(VtValue value, out GfDualQuath output)
		{
			GfDualQuath gfDualQuath = new GfDualQuath();
			try
			{
				VtPINVOKE.VtValueToGfDualQuath__SWIG_1(VtValue.getCPtr(value), GfDualQuath.getCPtr(gfDualQuath));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfDualQuath;
			}
		}

		public static VtDualQuathArray VtValueToVtDualQuathArray(VtValue value)
		{
			VtDualQuathArray result = new VtDualQuathArray(VtPINVOKE.VtValueToVtDualQuathArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtDualQuathArray(VtValue value, out VtDualQuathArray output)
		{
			VtDualQuathArray vtDualQuathArray = new VtDualQuathArray();
			try
			{
				VtPINVOKE.VtValueToVtDualQuathArray__SWIG_1(VtValue.getCPtr(value), VtDualQuathArray.getCPtr(vtDualQuathArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtDualQuathArray;
			}
		}

		public static GfDualQuatf VtValueToGfDualQuatf(VtValue value)
		{
			GfDualQuatf result = new GfDualQuatf(VtPINVOKE.VtValueToGfDualQuatf__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfDualQuatf(VtValue value, out GfDualQuatf output)
		{
			GfDualQuatf gfDualQuatf = new GfDualQuatf();
			try
			{
				VtPINVOKE.VtValueToGfDualQuatf__SWIG_1(VtValue.getCPtr(value), GfDualQuatf.getCPtr(gfDualQuatf));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfDualQuatf;
			}
		}

		public static VtDualQuatfArray VtValueToVtDualQuatfArray(VtValue value)
		{
			VtDualQuatfArray result = new VtDualQuatfArray(VtPINVOKE.VtValueToVtDualQuatfArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtDualQuatfArray(VtValue value, out VtDualQuatfArray output)
		{
			VtDualQuatfArray vtDualQuatfArray = new VtDualQuatfArray();
			try
			{
				VtPINVOKE.VtValueToVtDualQuatfArray__SWIG_1(VtValue.getCPtr(value), VtDualQuatfArray.getCPtr(vtDualQuatfArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtDualQuatfArray;
			}
		}

		public static GfDualQuatd VtValueToGfDualQuatd(VtValue value)
		{
			GfDualQuatd result = new GfDualQuatd(VtPINVOKE.VtValueToGfDualQuatd__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfDualQuatd(VtValue value, out GfDualQuatd output)
		{
			GfDualQuatd gfDualQuatd = new GfDualQuatd();
			try
			{
				VtPINVOKE.VtValueToGfDualQuatd__SWIG_1(VtValue.getCPtr(value), GfDualQuatd.getCPtr(gfDualQuatd));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfDualQuatd;
			}
		}

		public static VtDualQuatdArray VtValueToVtDualQuatdArray(VtValue value)
		{
			VtDualQuatdArray result = new VtDualQuatdArray(VtPINVOKE.VtValueToVtDualQuatdArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToVtDualQuatdArray(VtValue value, out VtDualQuatdArray output)
		{
			VtDualQuatdArray vtDualQuatdArray = new VtDualQuatdArray();
			try
			{
				VtPINVOKE.VtValueToVtDualQuatdArray__SWIG_1(VtValue.getCPtr(value), VtDualQuatdArray.getCPtr(vtDualQuatdArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = vtDualQuatdArray;
			}
		}

		public static GfFrustum VtValueToGfFrustum(VtValue value)
		{
			GfFrustum result = new GfFrustum(VtPINVOKE.VtValueToGfFrustum__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToGfFrustum(VtValue value, out GfFrustum output)
		{
			GfFrustum gfFrustum = new GfFrustum();
			try
			{
				VtPINVOKE.VtValueToGfFrustum__SWIG_1(VtValue.getCPtr(value), GfFrustum.getCPtr(gfFrustum));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = gfFrustum;
			}
		}

		public static SdfAssetPath VtValueToSdfAssetPath(VtValue value)
		{
			SdfAssetPath result = new SdfAssetPath(VtPINVOKE.VtValueToSdfAssetPath__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToSdfAssetPath(VtValue value, out SdfAssetPath output)
		{
			SdfAssetPath sdfAssetPath = new SdfAssetPath();
			try
			{
				VtPINVOKE.VtValueToSdfAssetPath__SWIG_1(VtValue.getCPtr(value), SdfAssetPath.getCPtr(sdfAssetPath));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = sdfAssetPath;
			}
		}

		public static SdfAssetPathArray VtValueToSdfAssetPathArray(VtValue value)
		{
			SdfAssetPathArray result = new SdfAssetPathArray(VtPINVOKE.VtValueToSdfAssetPathArray__SWIG_0(VtValue.getCPtr(value)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void VtValueToSdfAssetPathArray(VtValue value, out SdfAssetPathArray output)
		{
			SdfAssetPathArray sdfAssetPathArray = new SdfAssetPathArray();
			try
			{
				VtPINVOKE.VtValueToSdfAssetPathArray__SWIG_1(VtValue.getCPtr(value), SdfAssetPathArray.getCPtr(sdfAssetPathArray));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
			finally
			{
				output = sdfAssetPathArray;
			}
		}
	}
}
