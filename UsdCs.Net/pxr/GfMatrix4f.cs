using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfMatrix4f : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint numRows = 4u;

		public const uint numColumns = 4u;

		public GfMatrix4f(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfMatrix4f obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfMatrix4f obj)
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

		~GfMatrix4f()
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
						GfPINVOKE.delete_GfMatrix4f(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfMatrix4f()
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfMatrix4f(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_1(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33), cMemoryOwn: true)
		{
		}

		public GfMatrix4f(float s)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_2(s), cMemoryOwn: true)
		{
		}

		public GfMatrix4f(GfVec4f v)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_3(GfVec4f.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4f(StdDoubleVectorVector v)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_4(StdDoubleVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4f(StdFloatVectorVector v)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_5(StdFloatVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4f(StdDoubleVector r0, StdDoubleVector r1, StdDoubleVector r2, StdDoubleVector r3)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_6(StdDoubleVector.getCPtr(r0), StdDoubleVector.getCPtr(r1), StdDoubleVector.getCPtr(r2), StdDoubleVector.getCPtr(r3)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4f(StdFloatVector r0, StdFloatVector r1, StdFloatVector r2, StdFloatVector r3)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_7(StdFloatVector.getCPtr(r0), StdFloatVector.getCPtr(r1), StdFloatVector.getCPtr(r2), StdFloatVector.getCPtr(r3)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4f(GfRotation rotate, GfVec3f translate)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_8(GfRotation.getCPtr(rotate), GfVec3f.getCPtr(translate)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4f(GfMatrix3f rotmx, GfVec3f translate)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_9(GfMatrix3f.getCPtr(rotmx), GfVec3f.getCPtr(translate)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix4f(GfMatrix4d m)
			: this(GfPINVOKE.new_GfMatrix4f__SWIG_10(GfMatrix4d.getCPtr(m)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRow(int i, GfVec4f v)
		{
			GfPINVOKE.GfMatrix4f_SetRow(swigCPtr, i, GfVec4f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetColumn(int i, GfVec4f v)
		{
			GfPINVOKE.GfMatrix4f_SetColumn(swigCPtr, i, GfVec4f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4f GetRow(int i)
		{
			return new GfVec4f(GfPINVOKE.GfMatrix4f_GetRow(swigCPtr, i), cMemoryOwn: true);
		}

		public GfVec4f GetColumn(int i)
		{
			return new GfVec4f(GfPINVOKE.GfMatrix4f_GetColumn(swigCPtr, i), cMemoryOwn: true);
		}

		public GfMatrix4f Set(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_Set(swigCPtr, m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33), cMemoryOwn: false);
		}

		public GfMatrix4f SetIdentity()
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetIdentity(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix4f SetZero()
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetZero(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix4f SetDiagonal(float s)
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetDiagonal__SWIG_0(swigCPtr, s), cMemoryOwn: false);
		}

		public GfMatrix4f SetDiagonal(GfVec4f arg0)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetDiagonal__SWIG_1(swigCPtr, GfVec4f.getCPtr(arg0)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f GetTranspose()
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_GetTranspose(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix4f GetInverse(out double det, double eps)
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_GetInverse__SWIG_0(swigCPtr, out det, eps), cMemoryOwn: true);
		}

		public GfMatrix4f GetInverse(out double det)
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_GetInverse__SWIG_1(swigCPtr, out det), cMemoryOwn: true);
		}

		public GfMatrix4f GetInverse()
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_GetInverse__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public double GetDeterminant()
		{
			return GfPINVOKE.GfMatrix4f_GetDeterminant(swigCPtr);
		}

		public void SetRow3(int i, GfVec3f v)
		{
			GfPINVOKE.GfMatrix4f_SetRow3(swigCPtr, i, GfVec3f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3f GetRow3(int i)
		{
			return new GfVec3f(GfPINVOKE.GfMatrix4f_GetRow3(swigCPtr, i), cMemoryOwn: true);
		}

		public double GetDeterminant3()
		{
			return GfPINVOKE.GfMatrix4f_GetDeterminant3(swigCPtr);
		}

		public bool HasOrthogonalRows3()
		{
			return GfPINVOKE.GfMatrix4f_HasOrthogonalRows3(swigCPtr);
		}

		public bool Orthonormalize(bool issueWarning)
		{
			return GfPINVOKE.GfMatrix4f_Orthonormalize__SWIG_0(swigCPtr, issueWarning);
		}

		public bool Orthonormalize()
		{
			return GfPINVOKE.GfMatrix4f_Orthonormalize__SWIG_1(swigCPtr);
		}

		public GfMatrix4f GetOrthonormalized(bool issueWarning)
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_GetOrthonormalized__SWIG_0(swigCPtr, issueWarning), cMemoryOwn: true);
		}

		public GfMatrix4f GetOrthonormalized()
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_GetOrthonormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public double GetHandedness()
		{
			return GfPINVOKE.GfMatrix4f_GetHandedness(swigCPtr);
		}

		public bool IsRightHanded()
		{
			return GfPINVOKE.GfMatrix4f_IsRightHanded(swigCPtr);
		}

		public bool IsLeftHanded()
		{
			return GfPINVOKE.GfMatrix4f_IsLeftHanded(swigCPtr);
		}

		public GfMatrix4f SetScale(float scaleFactor)
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetScale__SWIG_0(swigCPtr, scaleFactor), cMemoryOwn: false);
		}

		public GfMatrix4f RemoveScaleShear()
		{
			return new GfMatrix4f(GfPINVOKE.GfMatrix4f_RemoveScaleShear(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix4f SetRotate(GfQuatf rot)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetRotate__SWIG_0(swigCPtr, GfQuatf.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetRotateOnly(GfQuatf rot)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetRotateOnly__SWIG_0(swigCPtr, GfQuatf.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetRotate(GfRotation rot)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetRotate__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetRotateOnly(GfRotation rot)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetRotateOnly__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetRotate(GfMatrix3f mx)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetRotate__SWIG_2(swigCPtr, GfMatrix3f.getCPtr(mx)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetRotateOnly(GfMatrix3f mx)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetRotateOnly__SWIG_2(swigCPtr, GfMatrix3f.getCPtr(mx)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetScale(GfVec3f scaleFactors)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetScale__SWIG_1(swigCPtr, GfVec3f.getCPtr(scaleFactors)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetTranslate(GfVec3f trans)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetTranslate(swigCPtr, GfVec3f.getCPtr(trans)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetTranslateOnly(GfVec3f t)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetTranslateOnly(swigCPtr, GfVec3f.getCPtr(t)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetTransform(GfRotation rotate, GfVec3f translate)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetTransform__SWIG_0(swigCPtr, GfRotation.getCPtr(rotate), GfVec3f.getCPtr(translate)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetTransform(GfMatrix3f rotmx, GfVec3f translate)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetTransform__SWIG_1(swigCPtr, GfMatrix3f.getCPtr(rotmx), GfVec3f.getCPtr(translate)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetLookAt(GfVec3f eyePoint, GfVec3f centerPoint, GfVec3f upDirection)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetLookAt__SWIG_0(swigCPtr, GfVec3f.getCPtr(eyePoint), GfVec3f.getCPtr(centerPoint), GfVec3f.getCPtr(upDirection)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix4f SetLookAt(GfVec3f eyePoint, GfRotation orientation)
		{
			GfMatrix4f result = new GfMatrix4f(GfPINVOKE.GfMatrix4f_SetLookAt__SWIG_1(swigCPtr, GfVec3f.getCPtr(eyePoint), GfRotation.getCPtr(orientation)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Factor(GfMatrix4f r, GfVec3f s, GfMatrix4f u, GfVec3f t, GfMatrix4f p, float eps)
		{
			return GfPINVOKE.GfMatrix4f_Factor__SWIG_0(swigCPtr, getCPtr(r), GfVec3f.getCPtr(s), getCPtr(u), GfVec3f.getCPtr(t), getCPtr(p), eps);
		}

		public bool Factor(GfMatrix4f r, GfVec3f s, GfMatrix4f u, GfVec3f t, GfMatrix4f p)
		{
			return GfPINVOKE.GfMatrix4f_Factor__SWIG_1(swigCPtr, getCPtr(r), GfVec3f.getCPtr(s), getCPtr(u), GfVec3f.getCPtr(t), getCPtr(p));
		}

		public GfVec3f ExtractTranslation()
		{
			return new GfVec3f(GfPINVOKE.GfMatrix4f_ExtractTranslation(swigCPtr), cMemoryOwn: true);
		}

		public GfRotation ExtractRotation()
		{
			return new GfRotation(GfPINVOKE.GfMatrix4f_ExtractRotation(swigCPtr), cMemoryOwn: true);
		}

		public GfQuatf ExtractRotationQuat()
		{
			return new GfQuatf(GfPINVOKE.GfMatrix4f_ExtractRotationQuat(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3f DecomposeRotation(GfVec3f axis0, GfVec3f axis1, GfVec3f axis2)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfMatrix4f_DecomposeRotation(swigCPtr, GfVec3f.getCPtr(axis0), GfVec3f.getCPtr(axis1), GfVec3f.getCPtr(axis2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix3f ExtractRotationMatrix()
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix4f_ExtractRotationMatrix(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d Transform(GfVec3d vec)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfMatrix4f_Transform__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3f Transform(GfVec3f vec)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfMatrix4f_Transform__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d TransformDir(GfVec3d vec)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfMatrix4f_TransformDir__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3f TransformDir(GfVec3f vec)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfMatrix4f_TransformDir__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d TransformAffine(GfVec3d vec)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfMatrix4f_TransformAffine__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3f TransformAffine(GfVec3f vec)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfMatrix4f_TransformAffine__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfMatrix4f lhs, GfMatrix4f rhs)
		{
			bool result = GfPINVOKE.GfMatrix4f_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfMatrix4f lhs, GfMatrix4f rhs)
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

		public static bool operator !=(GfMatrix4f lhs, GfMatrix4f rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfMatrix4f);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfMatrix4f_GetHashCode(swigCPtr);
		}

		public override string ToString()
		{
			return GfPINVOKE.GfMatrix4f_ToString(swigCPtr);
		}

		public void CopyToArray(float[] dest)
		{
			GfPINVOKE.GfMatrix4f_CopyToArray(swigCPtr, dest);
		}

		public void CopyFromArray(float[] src)
		{
			GfPINVOKE.GfMatrix4f_CopyFromArray(swigCPtr, src);
		}
	}
}
