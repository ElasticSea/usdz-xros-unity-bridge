using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelTokens : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static TfToken bindTransforms = new TfToken("bindTransforms");

		public static TfToken blendShapeWeights = new TfToken("blendShapeWeights");

		public static TfToken blendShapes = new TfToken("blendShapes");

		public static TfToken classicLinear = new TfToken("classicLinear");

		public static TfToken dualQuaternion = new TfToken("dualQuaternion");

		public static TfToken jointNames = new TfToken("jointNames");

		public static TfToken joints = new TfToken("joints");

		public static TfToken normalOffsets = new TfToken("normalOffsets");

		public static TfToken offsets = new TfToken("offsets");

		public static TfToken pointIndices = new TfToken("pointIndices");

		public static TfToken primvarsSkelGeomBindTransform = new TfToken("primvars:skel:geomBindTransform");

		public static TfToken primvarsSkelJointIndices = new TfToken("primvars:skel:jointIndices");

		public static TfToken primvarsSkelJointWeights = new TfToken("primvars:skel:jointWeights");

		public static TfToken primvarsSkelSkinningMethod = new TfToken("primvars:skel:skinningMethod");

		public static TfToken restTransforms = new TfToken("restTransforms");

		public static TfToken rotations = new TfToken("rotations");

		public static TfToken scales = new TfToken("scales");

		public static TfToken skelAnimationSource = new TfToken("skel:animationSource");

		public static TfToken skelBlendShapeTargets = new TfToken("skel:blendShapeTargets");

		public static TfToken skelBlendShapes = new TfToken("skel:blendShapes");

		public static TfToken skelJoints = new TfToken("skel:joints");

		public static TfToken skelSkeleton = new TfToken("skel:skeleton");

		public static TfToken translations = new TfToken("translations");

		public static TfToken weight = new TfToken("weight");

		public UsdSkelTokens(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelTokens obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelTokens obj)
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

		~UsdSkelTokens()
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
						throw new MethodAccessException("C++ destructor does not have public access");
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}
	}
}
