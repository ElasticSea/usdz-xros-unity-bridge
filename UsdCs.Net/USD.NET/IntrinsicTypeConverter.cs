using System;
using System.Collections.Generic;
using System.Linq;
using pxr;

namespace USD.NET
{
	[Preserve]
	public class IntrinsicTypeConverter
	{
		public static string MakeValidIdentifier(string unityIdentifier)
		{
			return Tf.TfMakeValidIdentifier(unityIdentifier);
		}

		public static string JoinNamespace(string first, string second)
		{
			if (string.IsNullOrEmpty(first))
			{
				return second ?? string.Empty;
			}
			if (string.IsNullOrEmpty(second))
			{
				return first ?? string.Empty;
			}
			if (string.IsNullOrEmpty(first) && string.IsNullOrEmpty(second))
			{
				return string.Empty;
			}
			return first + ":" + second;
		}

		[Preserve]
		public static VtTokenArray ToVtArray(string[] input)
		{
			VtTokenArray vtTokenArray = new VtTokenArray((uint)input.Length);
			for (int i = 0; i < input.Length; i++)
			{
				vtTokenArray[i] = new TfToken(input[i]);
			}
			return vtTokenArray;
		}

		[Preserve]
		public static VtTokenArray ListToVtArray(List<string> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<string> ListFromVtArray(VtTokenArray input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public static string[] FromVtArray(VtTokenArray input)
		{
			string[] output = UsdIo.ArrayAllocator.Malloc<string>(input.size());
			FromVtArray(input, ref output);
			return output;
		}

		[Preserve]
		public static void FromVtArray(VtTokenArray input, ref string[] output)
		{
			if (output.Length != input.size())
			{
				output = UsdIo.ArrayAllocator.Malloc<string>(input.size());
			}
			for (int i = 0; i < input.size(); i++)
			{
				output[i] = input[i];
			}
		}

		[Preserve]
		public static SdfAssetPathArray ToVtArray(SdfAssetPath[] input)
		{
			SdfAssetPathArray sdfAssetPathArray = new SdfAssetPathArray((uint)input.Length);
			for (int i = 0; i < input.Length; i++)
			{
				sdfAssetPathArray[i] = new SdfAssetPath(input[i].GetAssetPath());
			}
			return sdfAssetPathArray;
		}

		[Preserve]
		public static SdfAssetPathArray ListToVtArray(List<SdfAssetPath> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<SdfAssetPath> ListFromVtArray(SdfAssetPathArray input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public static SdfAssetPath[] FromVtArray(SdfAssetPathArray input)
		{
			SdfAssetPath[] output = UsdIo.ArrayAllocator.Malloc<SdfAssetPath>(input.size());
			FromVtArray(input, ref output);
			return output;
		}

		[Preserve]
		public static void FromVtArray(SdfAssetPathArray input, ref SdfAssetPath[] output)
		{
			if (output.Length != input.size())
			{
				output = UsdIo.ArrayAllocator.Malloc<SdfAssetPath>(input.size());
			}
			for (int i = 0; i < input.size(); i++)
			{
				output[i] = input[i];
			}
		}

		[Preserve]
		public unsafe static VtBoolArray ToVtArray(bool[] input)
		{
			VtBoolArray vtBoolArray = new VtBoolArray((uint)input.Length);
			fixed (bool* value = input)
			{
				vtBoolArray.CopyFromArray(new IntPtr(value));
			}
			return vtBoolArray;
		}

		[Preserve]
		public static bool[] FromVtArray(VtBoolArray input)
		{
			bool[] output = UsdIo.ArrayAllocator.Malloc<bool>(input.size());
			FromVtArray(input, ref output);
			return output;
		}

		[Preserve]
		public unsafe static void FromVtArray(VtBoolArray input, ref bool[] output)
		{
			if (output.Length != input.size())
			{
				output = UsdIo.ArrayAllocator.Malloc<bool>(input.size());
			}
			fixed (bool* value = output)
			{
				input.CopyToArray(new IntPtr(value));
			}
		}

		[Preserve]
		public static VtBoolArray ListToVtArray(List<bool> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public unsafe static List<bool> ListFromVtArray(VtBoolArray input)
		{
			bool[] array = UsdIo.ArrayAllocator.Malloc<bool>(input.size());
			fixed (bool* value = array)
			{
				input.CopyToArray(new IntPtr(value));
			}
			return array.ToList();
		}

		[Preserve]
		public unsafe static VtUCharArray ToVtArray(byte[] input)
		{
			VtUCharArray vtUCharArray = new VtUCharArray((uint)input.Length);
			fixed (byte* value = input)
			{
				vtUCharArray.CopyFromArray(new IntPtr(value));
			}
			return vtUCharArray;
		}

		[Preserve]
		public static VtUCharArray ListToVtArray(List<byte> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<byte> ListFromVtArray(VtUCharArray input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public static byte[] FromVtArray(VtUCharArray input)
		{
			byte[] output = UsdIo.ArrayAllocator.Malloc<byte>(input.size());
			FromVtArray(input, ref output);
			return output;
		}

		[Preserve]
		public unsafe static void FromVtArray(VtUCharArray input, ref byte[] output)
		{
			if (output.Length != input.size())
			{
				output = UsdIo.ArrayAllocator.Malloc<byte>(input.size());
			}
			fixed (byte* value = output)
			{
				input.CopyToArray(new IntPtr(value));
			}
		}

		[Preserve]
		public static VtIntArray ListToVtArray(List<int> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<int> ListFromVtArray(VtIntArray input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public unsafe static VtIntArray ToVtArray(int[] input)
		{
			VtIntArray vtIntArray = new VtIntArray((uint)input.Length);
			fixed (int* value = input)
			{
				vtIntArray.CopyFromArray(new IntPtr(value));
			}
			return vtIntArray;
		}

		[Preserve]
		public static int[] FromVtArray(VtIntArray input)
		{
			int[] output = UsdIo.ArrayAllocator.Malloc<int>(input.size());
			FromVtArray(input, ref output);
			return output;
		}

		[Preserve]
		public unsafe static void FromVtArray(VtIntArray input, ref int[] output)
		{
			if (output.Length != input.size())
			{
				output = UsdIo.ArrayAllocator.Malloc<int>(input.size());
			}
			fixed (int* value = output)
			{
				input.CopyToArray(new IntPtr(value));
			}
		}

		[Preserve]
		public static VtUIntArray ListToVtArray(List<uint> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<uint> ListFromVtArray(VtUIntArray input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public unsafe static VtUIntArray ToVtArray(uint[] input)
		{
			VtUIntArray vtUIntArray = new VtUIntArray((uint)input.Length);
			fixed (uint* value = input)
			{
				vtUIntArray.CopyFromArray(new IntPtr(value));
			}
			return vtUIntArray;
		}

		[Preserve]
		public static uint[] FromVtArray(VtUIntArray input)
		{
			uint[] output = UsdIo.ArrayAllocator.Malloc<uint>(input.size());
			FromVtArray(input, ref output);
			return output;
		}

		[Preserve]
		public unsafe static void FromVtArray(VtUIntArray input, ref uint[] output)
		{
			if (output.Length != input.size())
			{
				output = UsdIo.ArrayAllocator.Malloc<uint>(input.size());
			}
			fixed (uint* value = output)
			{
				input.CopyToArray(new IntPtr(value));
			}
		}

		[Preserve]
		public static VtInt64Array ListToVtArray(List<long> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<long> ListFromVtArray(VtInt64Array input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public unsafe static VtInt64Array ToVtArray(long[] input)
		{
			VtInt64Array vtInt64Array = new VtInt64Array((uint)input.Length);
			fixed (long* value = input)
			{
				vtInt64Array.CopyFromArray(new IntPtr(value));
			}
			return vtInt64Array;
		}

		[Preserve]
		public static long[] FromVtArray(VtInt64Array input)
		{
			long[] output = UsdIo.ArrayAllocator.Malloc<long>(input.size());
			FromVtArray(input, ref output);
			return output;
		}

		[Preserve]
		public unsafe static void FromVtArray(VtInt64Array input, ref long[] output)
		{
			if (output.Length != input.size())
			{
				output = UsdIo.ArrayAllocator.Malloc<long>(input.size());
			}
			fixed (long* value = output)
			{
				input.CopyToArray(new IntPtr(value));
			}
		}

		[Preserve]
		public static VtUInt64Array ListToVtArray(List<ulong> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<ulong> ListFromVtArray(VtUInt64Array input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public unsafe static VtUInt64Array ToVtArray(ulong[] input)
		{
			VtUInt64Array vtUInt64Array = new VtUInt64Array((uint)input.Length);
			fixed (ulong* value = input)
			{
				vtUInt64Array.CopyFromArray(new IntPtr(value));
			}
			return vtUInt64Array;
		}

		[Preserve]
		public static ulong[] FromVtArray(VtUInt64Array input)
		{
			ulong[] output = UsdIo.ArrayAllocator.Malloc<ulong>(input.size());
			FromVtArray(input, ref output);
			return output;
		}

		[Preserve]
		public unsafe static void FromVtArray(VtUInt64Array input, ref ulong[] output)
		{
			if (output.Length != input.size())
			{
				output = UsdIo.ArrayAllocator.Malloc<ulong>(input.size());
			}
			fixed (ulong* value = output)
			{
				input.CopyToArray(new IntPtr(value));
			}
		}

		[Preserve]
		public static VtFloatArray ListToVtArray(List<float> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<float> ListFromVtArray(VtFloatArray input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public unsafe static VtFloatArray ToVtArray(float[] input)
		{
			VtFloatArray vtFloatArray = new VtFloatArray((uint)input.Length);
			fixed (float* value = input)
			{
				vtFloatArray.CopyFromArray(new IntPtr(value));
			}
			return vtFloatArray;
		}

		[Preserve]
		public unsafe static float[] FromVtArray(VtFloatArray input)
		{
			float[] array = UsdIo.ArrayAllocator.Malloc<float>(input.size());
			fixed (float* value = array)
			{
				input.CopyToArray(new IntPtr(value));
			}
			return array;
		}

		[Preserve]
		public static VtDoubleArray ListToVtArray(List<double> input)
		{
			return ToVtArray(input.ToArray());
		}

		[Preserve]
		public static List<double> ListFromVtArray(VtDoubleArray input)
		{
			return FromVtArray(input).ToList();
		}

		[Preserve]
		public unsafe static VtDoubleArray ToVtArray(double[] input)
		{
			VtDoubleArray vtDoubleArray = new VtDoubleArray((uint)input.Length);
			fixed (double* value = input)
			{
				vtDoubleArray.CopyFromArray(new IntPtr(value));
			}
			return vtDoubleArray;
		}

		[Preserve]
		public unsafe static double[] FromVtArray(VtDoubleArray input)
		{
			double[] array = UsdIo.ArrayAllocator.Malloc<double>(input.size());
			fixed (double* value = array)
			{
				input.CopyToArray(new IntPtr(value));
			}
			return array;
		}
	}
}
