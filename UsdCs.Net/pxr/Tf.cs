namespace pxr
{
	public class Tf
	{
		public static string TfStringPrintf(string fmt)
		{
			return TfPINVOKE.TfStringPrintf(fmt);
		}

		public static string TfSafeString(string ptr)
		{
			return TfPINVOKE.TfSafeString(ptr);
		}

		public static string TfIntToString(int i)
		{
			return TfPINVOKE.TfIntToString(i);
		}

		public static double TfStringToDouble(string txt)
		{
			double result = TfPINVOKE.TfStringToDouble__SWIG_0(txt);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double TfStringToDouble(string text, int len)
		{
			return TfPINVOKE.TfStringToDouble__SWIG_2(text, len);
		}

		public static int TfStringToLong(string txt, out bool outOfRange)
		{
			int result = TfPINVOKE.TfStringToLong__SWIG_0(txt, out outOfRange);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static int TfStringToLong(string txt)
		{
			int result = TfPINVOKE.TfStringToLong__SWIG_1(txt);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static uint TfStringToULong(string txt, out bool outOfRange)
		{
			uint result = TfPINVOKE.TfStringToULong__SWIG_0(txt, out outOfRange);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static uint TfStringToULong(string txt)
		{
			uint result = TfPINVOKE.TfStringToULong__SWIG_1(txt);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static long TfStringToInt64(string txt, out bool outOfRange)
		{
			long result = TfPINVOKE.TfStringToInt64__SWIG_0(txt, out outOfRange);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static long TfStringToInt64(string txt)
		{
			long result = TfPINVOKE.TfStringToInt64__SWIG_1(txt);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static ulong TfStringToUInt64(string txt, out bool outOfRange)
		{
			ulong result = TfPINVOKE.TfStringToUInt64__SWIG_0(txt, out outOfRange);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static ulong TfStringToUInt64(string txt)
		{
			ulong result = TfPINVOKE.TfStringToUInt64__SWIG_1(txt);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Tf_StringStartsWithImpl(string s, uint slen, string prefix, uint prelen)
		{
			return TfPINVOKE.Tf_StringStartsWithImpl(s, slen, prefix, prelen);
		}

		public static bool TfStringStartsWith(string s, string prefix)
		{
			bool result = TfPINVOKE.TfStringStartsWith__SWIG_0(s, prefix);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Tf_StringEndsWithImpl(string s, uint slen, string suffix, uint suflen)
		{
			return TfPINVOKE.Tf_StringEndsWithImpl(s, slen, suffix, suflen);
		}

		public static bool TfStringEndsWith(string s, string suffix)
		{
			bool result = TfPINVOKE.TfStringEndsWith__SWIG_0(s, suffix);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool TfStringContains(string s, string substring)
		{
			bool result = TfPINVOKE.TfStringContains__SWIG_0(s, substring);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool TfStringContains(string s, TfToken substring)
		{
			bool result = TfPINVOKE.TfStringContains__SWIG_2(s, TfToken.getCPtr(substring));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringToLower(string source)
		{
			string result = TfPINVOKE.TfStringToLower(source);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringToUpper(string source)
		{
			string result = TfPINVOKE.TfStringToUpper(source);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringCapitalize(string source)
		{
			string result = TfPINVOKE.TfStringCapitalize(source);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringTrimLeft(string s, string trimChars)
		{
			string result = TfPINVOKE.TfStringTrimLeft__SWIG_0(s, trimChars);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringTrimLeft(string s)
		{
			string result = TfPINVOKE.TfStringTrimLeft__SWIG_1(s);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringTrimRight(string s, string trimChars)
		{
			string result = TfPINVOKE.TfStringTrimRight__SWIG_0(s, trimChars);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringTrimRight(string s)
		{
			string result = TfPINVOKE.TfStringTrimRight__SWIG_1(s);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringTrim(string s, string trimChars)
		{
			string result = TfPINVOKE.TfStringTrim__SWIG_0(s, trimChars);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringTrim(string s)
		{
			string result = TfPINVOKE.TfStringTrim__SWIG_1(s);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringGetCommonPrefix(string a, string b)
		{
			string result = TfPINVOKE.TfStringGetCommonPrefix(a, b);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringGetSuffix(string name, char delimiter)
		{
			string result = TfPINVOKE.TfStringGetSuffix__SWIG_0(name, delimiter);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringGetSuffix(string name)
		{
			string result = TfPINVOKE.TfStringGetSuffix__SWIG_1(name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringGetBeforeSuffix(string name, char delimiter)
		{
			string result = TfPINVOKE.TfStringGetBeforeSuffix__SWIG_0(name, delimiter);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringGetBeforeSuffix(string name)
		{
			string result = TfPINVOKE.TfStringGetBeforeSuffix__SWIG_1(name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfGetBaseName(string fileName)
		{
			string result = TfPINVOKE.TfGetBaseName(fileName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfGetPathName(string fileName)
		{
			string result = TfPINVOKE.TfGetPathName(fileName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringReplace(string source, string from, string to)
		{
			string result = TfPINVOKE.TfStringReplace(source, from, to);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringJoin(StdStringVector strings, string separator)
		{
			string result = TfPINVOKE.TfStringJoin__SWIG_2(StdStringVector.getCPtr(strings), separator);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringJoin(StdStringVector strings)
		{
			string result = TfPINVOKE.TfStringJoin__SWIG_3(StdStringVector.getCPtr(strings));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringJoin(StdStringSet strings, string separator)
		{
			string result = TfPINVOKE.TfStringJoin__SWIG_4(StdStringSet.getCPtr(strings), separator);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringJoin(StdStringSet strings)
		{
			string result = TfPINVOKE.TfStringJoin__SWIG_5(StdStringSet.getCPtr(strings));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfStringSplit(string src, string separator)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfStringSplit(src, separator), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfStringTokenize(string source, string delimiters)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfStringTokenize__SWIG_0(source, delimiters), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfStringTokenize(string source)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfStringTokenize__SWIG_1(source), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringSet TfStringTokenizeToSet(string source, string delimiters)
		{
			StdStringSet result = new StdStringSet(TfPINVOKE.TfStringTokenizeToSet__SWIG_0(source, delimiters), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringSet TfStringTokenizeToSet(string source)
		{
			StdStringSet result = new StdStringSet(TfPINVOKE.TfStringTokenizeToSet__SWIG_1(source), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfQuotedStringTokenize(string source, string delimiters, out string errors)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfQuotedStringTokenize__SWIG_0(source, delimiters, out errors), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfQuotedStringTokenize(string source, string delimiters)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfQuotedStringTokenize__SWIG_1(source, delimiters), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfQuotedStringTokenize(string source)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfQuotedStringTokenize__SWIG_2(source), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfMatchedStringTokenize(string source, char openDelimiter, char closeDelimiter, char escapeCharacter, out string errors)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfMatchedStringTokenize__SWIG_0(source, openDelimiter, closeDelimiter, escapeCharacter, out errors), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfMatchedStringTokenize(string source, char openDelimiter, char closeDelimiter, char escapeCharacter)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfMatchedStringTokenize__SWIG_1(source, openDelimiter, closeDelimiter, escapeCharacter), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfMatchedStringTokenize(string source, char openDelimiter, char closeDelimiter)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfMatchedStringTokenize__SWIG_2(source, openDelimiter, closeDelimiter), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfMatchedStringTokenize(string source, char openDelimiter, char closeDelimiter, out string errors)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfMatchedStringTokenize__SWIG_3(source, openDelimiter, closeDelimiter, out errors), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringify(bool v)
		{
			return TfPINVOKE.TfStringify__SWIG_1(v);
		}

		public static string TfStringify(string arg0)
		{
			string result = TfPINVOKE.TfStringify__SWIG_2(arg0);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfStringify(float arg0)
		{
			return TfPINVOKE.TfStringify__SWIG_3(arg0);
		}

		public static string TfStringify(double arg0)
		{
			return TfPINVOKE.TfStringify__SWIG_4(arg0);
		}

		public static bool TfDoubleToString(double d, string buffer, int len, bool emitTrailingZero)
		{
			return TfPINVOKE.TfDoubleToString(d, buffer, len, emitTrailingZero);
		}

		public static string TfStringGlobToRegex(string s)
		{
			string result = TfPINVOKE.TfStringGlobToRegex(s);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfEscapeString(string in_)
		{
			string result = TfPINVOKE.TfEscapeString(in_);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void TfEscapeStringReplaceChar(SWIGTYPE_p_p_char in_, SWIGTYPE_p_p_char out_)
		{
			TfPINVOKE.TfEscapeStringReplaceChar(SWIGTYPE_p_p_char.getCPtr(in_), SWIGTYPE_p_p_char.getCPtr(out_));
		}

		public static string TfStringCatPaths(string prefix, string suffix)
		{
			string result = TfPINVOKE.TfStringCatPaths(prefix, suffix);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool TfIsValidIdentifier(string identifier)
		{
			bool result = TfPINVOKE.TfIsValidIdentifier(identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfMakeValidIdentifier(string in_)
		{
			string result = TfPINVOKE.TfMakeValidIdentifier(in_);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string TfGetXmlEscapedString(string in_)
		{
			string result = TfPINVOKE.TfGetXmlEscapedString(in_);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfTokenVector TfToTokenVector(StdStringVector sv)
		{
			TfTokenVector result = new TfTokenVector(TfPINVOKE.TfToTokenVector(StdStringVector.getCPtr(sv)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TfToStringVector(TfTokenVector tv)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfToStringVector(TfTokenVector.getCPtr(tv)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
