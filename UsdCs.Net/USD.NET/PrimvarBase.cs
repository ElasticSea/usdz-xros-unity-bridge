using System;
using pxr;

namespace USD.NET
{
	public class PrimvarBase
	{
		[UsdMetadata]
		public PrimvarInterpolation interpolation;

		[UsdMetadata]
		public int elementSize = 1;

		[UsdMetadata]
		public int[] indices;

		public TfToken GetInterpolationToken()
		{
			return interpolation switch
			{
				PrimvarInterpolation.Constant => UsdGeomTokens.constant, 
				PrimvarInterpolation.FaceVarying => UsdGeomTokens.faceVarying, 
				PrimvarInterpolation.Uniform => UsdGeomTokens.uniform, 
				PrimvarInterpolation.Varying => UsdGeomTokens.varying, 
				PrimvarInterpolation.Vertex => UsdGeomTokens.vertex, 
				_ => throw new Exception("Unknown primvar interpolation"), 
			};
		}

		public void SetInterpolationToken(TfToken token)
		{
			if (token == UsdGeomTokens.constant)
			{
				interpolation = PrimvarInterpolation.Constant;
				return;
			}
			if (token == UsdGeomTokens.faceVarying)
			{
				interpolation = PrimvarInterpolation.FaceVarying;
				return;
			}
			if (token == UsdGeomTokens.uniform)
			{
				interpolation = PrimvarInterpolation.Uniform;
				return;
			}
			if (token == UsdGeomTokens.varying)
			{
				interpolation = PrimvarInterpolation.Varying;
				return;
			}
			if (token == UsdGeomTokens.vertex)
			{
				interpolation = PrimvarInterpolation.Vertex;
				return;
			}
			throw new Exception("Unknown primvar interpolation token");
		}
	}
}
