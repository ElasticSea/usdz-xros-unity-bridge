using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfMatrix3f : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint numRows = 3u;

		public const uint numColumns = 3u;

		public GfMatrix3f(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfMatrix3f obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfMatrix3f obj)
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

		~GfMatrix3f()
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
						GfPINVOKE.delete_GfMatrix3f(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfMatrix3f()
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfMatrix3f(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_1(m00, m01, m02, m10, m11, m12, m20, m21, m22), cMemoryOwn: true)
		{
		}

		public GfMatrix3f(float s)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_2(s), cMemoryOwn: true)
		{
		}

		public GfMatrix3f(int s)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_3(s), cMemoryOwn: true)
		{
		}

		public GfMatrix3f(GfVec3f v)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_4(GfVec3f.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3f(StdDoubleVectorVector v)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_5(StdDoubleVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3f(StdFloatVectorVector v)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_6(StdFloatVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3f(GfRotation rot)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_7(GfRotation.getCPtr(rot)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3f(GfQuatf rot)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_8(GfQuatf.getCPtr(rot)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3f(GfMatrix3d m)
			: this(GfPINVOKE.new_GfMatrix3f__SWIG_9(GfMatrix3d.getCPtr(m)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRow(int i, GfVec3f v)
		{
			GfPINVOKE.GfMatrix3f_SetRow(swigCPtr, i, GfVec3f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetColumn(int i, GfVec3f v)
		{
			GfPINVOKE.GfMatrix3f_SetColumn(swigCPtr, i, GfVec3f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3f GetRow(int i)
		{
			return new GfVec3f(GfPINVOKE.GfMatrix3f_GetRow(swigCPtr, i), cMemoryOwn: true);
		}

		public GfVec3f GetColumn(int i)
		{
			return new GfVec3f(GfPINVOKE.GfMatrix3f_GetColumn(swigCPtr, i), cMemoryOwn: true);
		}

		public GfMatrix3f Set(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_Set(swigCPtr, m00, m01, m02, m10, m11, m12, m20, m21, m22), cMemoryOwn: false);
		}

		public GfMatrix3f SetIdentity()
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_SetIdentity(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix3f SetZero()
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_SetZero(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix3f SetDiagonal(float s)
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_SetDiagonal__SWIG_0(swigCPtr, s), cMemoryOwn: false);
		}

		public GfMatrix3f SetDiagonal(GfVec3f arg0)
		{
			GfMatrix3f result = new GfMatrix3f(GfPINVOKE.GfMatrix3f_SetDiagonal__SWIG_1(swigCPtr, GfVec3f.getCPtr(arg0)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix3f GetTranspose()
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_GetTranspose(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix3f GetInverse(out double det, double eps)
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_GetInverse__SWIG_0(swigCPtr, out det, eps), cMemoryOwn: true);
		}

		public GfMatrix3f GetInverse(out double det)
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_GetInverse__SWIG_1(swigCPtr, out det), cMemoryOwn: true);
		}

		public GfMatrix3f GetInverse()
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_GetInverse__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public double GetDeterminant()
		{
			return GfPINVOKE.GfMatrix3f_GetDeterminant(swigCPtr);
		}

		public bool Orthonormalize(bool issueWarning)
		{
			return GfPINVOKE.GfMatrix3f_Orthonormalize__SWIG_0(swigCPtr, issueWarning);
		}

		public bool Orthonormalize()
		{
			return GfPINVOKE.GfMatrix3f_Orthonormalize__SWIG_1(swigCPtr);
		}

		public GfMatrix3f GetOrthonormalized(bool issueWarning)
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_GetOrthonormalized__SWIG_0(swigCPtr, issueWarning), cMemoryOwn: true);
		}

		public GfMatrix3f GetOrthonormalized()
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_GetOrthonormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public double GetHandedness()
		{
			return GfPINVOKE.GfMatrix3f_GetHandedness(swigCPtr);
		}

		public bool IsRightHanded()
		{
			return GfPINVOKE.GfMatrix3f_IsRightHanded(swigCPtr);
		}

		public bool IsLeftHanded()
		{
			return GfPINVOKE.GfMatrix3f_IsLeftHanded(swigCPtr);
		}

		public GfMatrix3f SetScale(float scaleFactor)
		{
			return new GfMatrix3f(GfPINVOKE.GfMatrix3f_SetScale__SWIG_0(swigCPtr, scaleFactor), cMemoryOwn: false);
		}

		public GfMatrix3f SetRotate(GfQuatf rot)
		{
			GfMatrix3f result = new GfMatrix3f(GfPINVOKE.GfMatrix3f_SetRotate__SWIG_0(swigCPtr, GfQuatf.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix3f SetRotate(GfRotation rot)
		{
			GfMatrix3f result = new GfMatrix3f(GfPINVOKE.GfMatrix3f_SetRotate__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix3f SetScale(GfVec3f scaleFactors)
		{
			GfMatrix3f result = new GfMatrix3f(GfPINVOKE.GfMatrix3f_SetScale__SWIG_1(swigCPtr, GfVec3f.getCPtr(scaleFactors)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRotation ExtractRotation()
		{
			return new GfRotation(GfPINVOKE.GfMatrix3f_ExtractRotation(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3f DecomposeRotation(GfVec3f axis0, GfVec3f axis1, GfVec3f axis2)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfMatrix3f_DecomposeRotation(swigCPtr, GfVec3f.getCPtr(axis0), GfVec3f.getCPtr(axis1), GfVec3f.getCPtr(axis2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfQuaternion ExtractRotationQuaternion()
		{
			return new GfQuaternion(GfPINVOKE.GfMatrix3f_ExtractRotationQuaternion(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfMatrix3f lhs, GfMatrix3f rhs)
		{
			bool result = GfPINVOKE.GfMatrix3f_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfMatrix3f lhs, GfMatrix3f rhs)
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

		public static bool operator !=(GfMatrix3f lhs, GfMatrix3f rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfMatrix3f);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfMatrix3f_GetHashCode(swigCPtr);
		}

		public override string ToString()
		{
			return GfPINVOKE.GfMatrix3f_ToString(swigCPtr);
		}

		public void CopyToArray(float[] dest)
		{
			GfPINVOKE.GfMatrix3f_CopyToArray(swigCPtr, dest);
		}

		public void CopyFromArray(float[] src)
		{
			GfPINVOKE.GfMatrix3f_CopyFromArray(swigCPtr, src);
		}
	}
}
