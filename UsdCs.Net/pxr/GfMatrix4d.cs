using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfMatrix4d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint numRows = 4u;

		public const uint numColumns = 4u;

		public GfMatrix4d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfMatrix4d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfMatrix4d obj)
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

		~GfMatrix4d()
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
						GfPINVOKE.delete_GfMatrix4d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfMatrix4d()
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfMatrix4d(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_1(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33), cMemoryOwn: true)
		{
		}

		public GfMatrix4d(double s)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_2(s), cMemoryOwn: true)
		{
		}

		public GfMatrix4d(GfVec4d v)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_3(GfVec4d.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4d(StdDoubleVectorVector v)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_4(StdDoubleVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4d(StdFloatVectorVector v)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_5(StdFloatVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4d(StdDoubleVector r0, StdDoubleVector r1, StdDoubleVector r2, StdDoubleVector r3)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_6(StdDoubleVector.getCPtr(r0), StdDoubleVector.getCPtr(r1), StdDoubleVector.getCPtr(r2), StdDoubleVector.getCPtr(r3)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4d(StdFloatVector r0, StdFloatVector r1, StdFloatVector r2, StdFloatVector r3)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_7(StdFloatVector.getCPtr(r0), StdFloatVector.getCPtr(r1), StdFloatVector.getCPtr(r2), StdFloatVector.getCPtr(r3)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4d(GfRotation rotate, GfVec3d translate)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_8(GfRotation.getCPtr(rotate), GfVec3d.getCPtr(translate)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4d(GfMatrix3d rotmx, GfVec3d translate)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_9(GfMatrix3d.getCPtr(rotmx), GfVec3d.getCPtr(translate)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4d(GfMatrix4f m)
			: this(GfPINVOKE.new_GfMatrix4d__SWIG_10(GfMatrix4f.getCPtr(m)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRow(int i, GfVec4d v)
		{
			GfPINVOKE.GfMatrix4d_SetRow(swigCPtr, i, GfVec4d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetColumn(int i, GfVec4d v)
		{
			GfPINVOKE.GfMatrix4d_SetColumn(swigCPtr, i, GfVec4d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4d GetRow(int i)
		{
			return new GfVec4d(GfPINVOKE.GfMatrix4d_GetRow(swigCPtr, i), cMemoryOwn: true);
		}

		public GfVec4d GetColumn(int i)
		{
			return new GfVec4d(GfPINVOKE.GfMatrix4d_GetColumn(swigCPtr, i), cMemoryOwn: true);
		}

		public GfMatrix4d Set(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_Set(swigCPtr, m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33), cMemoryOwn: false);
		}

		public GfMatrix4d SetIdentity()
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetIdentity(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix4d SetZero()
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetZero(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix4d SetDiagonal(double s)
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetDiagonal__SWIG_0(swigCPtr, s), cMemoryOwn: false);
		}

		public GfMatrix4d SetDiagonal(GfVec4d arg0)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetDiagonal__SWIG_1(swigCPtr, GfVec4d.getCPtr(arg0)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d GetTranspose()
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_GetTranspose(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix4d GetInverse(out double det, double eps)
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_GetInverse__SWIG_0(swigCPtr, out det, eps), cMemoryOwn: true);
		}

		public GfMatrix4d GetInverse(out double det)
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_GetInverse__SWIG_1(swigCPtr, out det), cMemoryOwn: true);
		}

		public GfMatrix4d GetInverse()
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_GetInverse__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public double GetDeterminant()
		{
			return GfPINVOKE.GfMatrix4d_GetDeterminant(swigCPtr);
		}

		public void SetRow3(int i, GfVec3d v)
		{
			GfPINVOKE.GfMatrix4d_SetRow3(swigCPtr, i, GfVec3d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d GetRow3(int i)
		{
			return new GfVec3d(GfPINVOKE.GfMatrix4d_GetRow3(swigCPtr, i), cMemoryOwn: true);
		}

		public double GetDeterminant3()
		{
			return GfPINVOKE.GfMatrix4d_GetDeterminant3(swigCPtr);
		}

		public bool HasOrthogonalRows3()
		{
			return GfPINVOKE.GfMatrix4d_HasOrthogonalRows3(swigCPtr);
		}

		public bool Orthonormalize(bool issueWarning)
		{
			return GfPINVOKE.GfMatrix4d_Orthonormalize__SWIG_0(swigCPtr, issueWarning);
		}

		public bool Orthonormalize()
		{
			return GfPINVOKE.GfMatrix4d_Orthonormalize__SWIG_1(swigCPtr);
		}

		public GfMatrix4d GetOrthonormalized(bool issueWarning)
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_GetOrthonormalized__SWIG_0(swigCPtr, issueWarning), cMemoryOwn: true);
		}

		public GfMatrix4d GetOrthonormalized()
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_GetOrthonormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public double GetHandedness()
		{
			return GfPINVOKE.GfMatrix4d_GetHandedness(swigCPtr);
		}

		public bool IsRightHanded()
		{
			return GfPINVOKE.GfMatrix4d_IsRightHanded(swigCPtr);
		}

		public bool IsLeftHanded()
		{
			return GfPINVOKE.GfMatrix4d_IsLeftHanded(swigCPtr);
		}

		public GfMatrix4d SetScale(double scaleFactor)
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetScale__SWIG_0(swigCPtr, scaleFactor), cMemoryOwn: false);
		}

		public GfMatrix4d RemoveScaleShear()
		{
			return new GfMatrix4d(GfPINVOKE.GfMatrix4d_RemoveScaleShear(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix4d SetRotate(GfQuatd rot)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetRotate__SWIG_0(swigCPtr, GfQuatd.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetRotateOnly(GfQuatd rot)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetRotateOnly__SWIG_0(swigCPtr, GfQuatd.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetRotate(GfRotation rot)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetRotate__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetRotateOnly(GfRotation rot)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetRotateOnly__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetRotate(GfMatrix3d mx)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetRotate__SWIG_2(swigCPtr, GfMatrix3d.getCPtr(mx)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetRotateOnly(GfMatrix3d mx)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetRotateOnly__SWIG_2(swigCPtr, GfMatrix3d.getCPtr(mx)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetScale(GfVec3d scaleFactors)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetScale__SWIG_1(swigCPtr, GfVec3d.getCPtr(scaleFactors)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetTranslate(GfVec3d trans)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetTranslate(swigCPtr, GfVec3d.getCPtr(trans)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetTranslateOnly(GfVec3d t)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetTranslateOnly(swigCPtr, GfVec3d.getCPtr(t)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetTransform(GfRotation rotate, GfVec3d translate)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetTransform__SWIG_0(swigCPtr, GfRotation.getCPtr(rotate), GfVec3d.getCPtr(translate)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetTransform(GfMatrix3d rotmx, GfVec3d translate)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetTransform__SWIG_1(swigCPtr, GfMatrix3d.getCPtr(rotmx), GfVec3d.getCPtr(translate)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetLookAt(GfVec3d eyePoint, GfVec3d centerPoint, GfVec3d upDirection)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetLookAt__SWIG_0(swigCPtr, GfVec3d.getCPtr(eyePoint), GfVec3d.getCPtr(centerPoint), GfVec3d.getCPtr(upDirection)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4d SetLookAt(GfVec3d eyePoint, GfRotation orientation)
		{
			GfMatrix4d result = new GfMatrix4d(GfPINVOKE.GfMatrix4d_SetLookAt__SWIG_1(swigCPtr, GfVec3d.getCPtr(eyePoint), GfRotation.getCPtr(orientation)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Factor(GfMatrix4d r, GfVec3d s, GfMatrix4d u, GfVec3d t, GfMatrix4d p, double eps)
		{
			return GfPINVOKE.GfMatrix4d_Factor__SWIG_0(swigCPtr, getCPtr(r), GfVec3d.getCPtr(s), getCPtr(u), GfVec3d.getCPtr(t), getCPtr(p), eps);
		}

		public bool Factor(GfMatrix4d r, GfVec3d s, GfMatrix4d u, GfVec3d t, GfMatrix4d p)
		{
			return GfPINVOKE.GfMatrix4d_Factor__SWIG_1(swigCPtr, getCPtr(r), GfVec3d.getCPtr(s), getCPtr(u), GfVec3d.getCPtr(t), getCPtr(p));
		}

		public GfVec3d ExtractTranslation()
		{
			return new GfVec3d(GfPINVOKE.GfMatrix4d_ExtractTranslation(swigCPtr), cMemoryOwn: true);
		}

		public GfRotation ExtractRotation()
		{
			return new GfRotation(GfPINVOKE.GfMatrix4d_ExtractRotation(swigCPtr), cMemoryOwn: true);
		}

		public GfQuatd ExtractRotationQuat()
		{
			return new GfQuatd(GfPINVOKE.GfMatrix4d_ExtractRotationQuat(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d DecomposeRotation(GfVec3d axis0, GfVec3d axis1, GfVec3d axis2)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfMatrix4d_DecomposeRotation(swigCPtr, GfVec3d.getCPtr(axis0), GfVec3d.getCPtr(axis1), GfVec3d.getCPtr(axis2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix3d ExtractRotationMatrix()
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix4d_ExtractRotationMatrix(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d Transform(GfVec3d vec)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfMatrix4d_Transform__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3f Transform(GfVec3f vec)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfMatrix4d_Transform__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d TransformDir(GfVec3d vec)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfMatrix4d_TransformDir__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3f TransformDir(GfVec3f vec)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfMatrix4d_TransformDir__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d TransformAffine(GfVec3d vec)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfMatrix4d_TransformAffine__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3f TransformAffine(GfVec3f vec)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfMatrix4d_TransformAffine__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfMatrix4d lhs, GfMatrix4d rhs)
		{
			bool result = GfPINVOKE.GfMatrix4d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfMatrix4d lhs, GfMatrix4d rhs)
		{
			bool flag = (object)lhs == null;
			bool flag2 = (object)rhs == null;
			if (flag == flag2)
			{
				if (!(flag && flag2))
				{
					return Equals(lhs, rhs);
				}
				return true;
			}
			return false;
		}

		public static bool operator !=(GfMatrix4d lhs, GfMatrix4d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfMatrix4d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfMatrix4d_GetHashCode(swigCPtr);
		}

		public override string ToString()
		{
			return GfPINVOKE.GfMatrix4d_ToString(swigCPtr);
		}

		public void CopyToArray(double[] dest)
		{
			GfPINVOKE.GfMatrix4d_CopyToArray(swigCPtr, dest);
		}

		public void CopyFromArray(double[] src)
		{
			GfPINVOKE.GfMatrix4d_CopyFromArray(swigCPtr, src);
		}
	}
}
