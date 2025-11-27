using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfMatrix3d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint numRows = 3u;

		public const uint numColumns = 3u;

		public GfMatrix3d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfMatrix3d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfMatrix3d obj)
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

		~GfMatrix3d()
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
						GfPINVOKE.delete_GfMatrix3d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfMatrix3d()
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfMatrix3d(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_1(m00, m01, m02, m10, m11, m12, m20, m21, m22), cMemoryOwn: true)
		{
		}

		public GfMatrix3d(double s)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_2(s), cMemoryOwn: true)
		{
		}

		public GfMatrix3d(int s)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_3(s), cMemoryOwn: true)
		{
		}

		public GfMatrix3d(GfVec3d v)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_4(GfVec3d.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3d(StdDoubleVectorVector v)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_5(StdDoubleVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3d(StdFloatVectorVector v)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_6(StdFloatVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3d(GfRotation rot)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_7(GfRotation.getCPtr(rot)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3d(GfQuatd rot)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_8(GfQuatd.getCPtr(rot)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix3d(GfMatrix3f m)
			: this(GfPINVOKE.new_GfMatrix3d__SWIG_9(GfMatrix3f.getCPtr(m)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRow(int i, GfVec3d v)
		{
			GfPINVOKE.GfMatrix3d_SetRow(swigCPtr, i, GfVec3d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetColumn(int i, GfVec3d v)
		{
			GfPINVOKE.GfMatrix3d_SetColumn(swigCPtr, i, GfVec3d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d GetRow(int i)
		{
			return new GfVec3d(GfPINVOKE.GfMatrix3d_GetRow(swigCPtr, i), cMemoryOwn: true);
		}

		public GfVec3d GetColumn(int i)
		{
			return new GfVec3d(GfPINVOKE.GfMatrix3d_GetColumn(swigCPtr, i), cMemoryOwn: true);
		}

		public GfMatrix3d Set(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_Set(swigCPtr, m00, m01, m02, m10, m11, m12, m20, m21, m22), cMemoryOwn: false);
		}

		public GfMatrix3d SetIdentity()
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_SetIdentity(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix3d SetZero()
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_SetZero(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix3d SetDiagonal(double s)
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_SetDiagonal__SWIG_0(swigCPtr, s), cMemoryOwn: false);
		}

		public GfMatrix3d SetDiagonal(GfVec3d arg0)
		{
			GfMatrix3d result = new GfMatrix3d(GfPINVOKE.GfMatrix3d_SetDiagonal__SWIG_1(swigCPtr, GfVec3d.getCPtr(arg0)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix3d GetTranspose()
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_GetTranspose(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix3d GetInverse(out double det, double eps)
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_GetInverse__SWIG_0(swigCPtr, out det, eps), cMemoryOwn: true);
		}

		public GfMatrix3d GetInverse(out double det)
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_GetInverse__SWIG_1(swigCPtr, out det), cMemoryOwn: true);
		}

		public GfMatrix3d GetInverse()
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_GetInverse__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public double GetDeterminant()
		{
			return GfPINVOKE.GfMatrix3d_GetDeterminant(swigCPtr);
		}

		public bool Orthonormalize(bool issueWarning)
		{
			return GfPINVOKE.GfMatrix3d_Orthonormalize__SWIG_0(swigCPtr, issueWarning);
		}

		public bool Orthonormalize()
		{
			return GfPINVOKE.GfMatrix3d_Orthonormalize__SWIG_1(swigCPtr);
		}

		public GfMatrix3d GetOrthonormalized(bool issueWarning)
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_GetOrthonormalized__SWIG_0(swigCPtr, issueWarning), cMemoryOwn: true);
		}

		public GfMatrix3d GetOrthonormalized()
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_GetOrthonormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public double GetHandedness()
		{
			return GfPINVOKE.GfMatrix3d_GetHandedness(swigCPtr);
		}

		public bool IsRightHanded()
		{
			return GfPINVOKE.GfMatrix3d_IsRightHanded(swigCPtr);
		}

		public bool IsLeftHanded()
		{
			return GfPINVOKE.GfMatrix3d_IsLeftHanded(swigCPtr);
		}

		public GfMatrix3d SetScale(double scaleFactor)
		{
			return new GfMatrix3d(GfPINVOKE.GfMatrix3d_SetScale__SWIG_0(swigCPtr, scaleFactor), cMemoryOwn: false);
		}

		public GfMatrix3d SetRotate(GfQuatd rot)
		{
			GfMatrix3d result = new GfMatrix3d(GfPINVOKE.GfMatrix3d_SetRotate__SWIG_0(swigCPtr, GfQuatd.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix3d SetRotate(GfRotation rot)
		{
			GfMatrix3d result = new GfMatrix3d(GfPINVOKE.GfMatrix3d_SetRotate__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix3d SetScale(GfVec3d scaleFactors)
		{
			GfMatrix3d result = new GfMatrix3d(GfPINVOKE.GfMatrix3d_SetScale__SWIG_1(swigCPtr, GfVec3d.getCPtr(scaleFactors)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRotation ExtractRotation()
		{
			return new GfRotation(GfPINVOKE.GfMatrix3d_ExtractRotation(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d DecomposeRotation(GfVec3d axis0, GfVec3d axis1, GfVec3d axis2)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfMatrix3d_DecomposeRotation(swigCPtr, GfVec3d.getCPtr(axis0), GfVec3d.getCPtr(axis1), GfVec3d.getCPtr(axis2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfQuaternion ExtractRotationQuaternion()
		{
			return new GfQuaternion(GfPINVOKE.GfMatrix3d_ExtractRotationQuaternion(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfMatrix3d lhs, GfMatrix3d rhs)
		{
			bool result = GfPINVOKE.GfMatrix3d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfMatrix3d lhs, GfMatrix3d rhs)
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

		public static bool operator !=(GfMatrix3d lhs, GfMatrix3d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfMatrix3d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfMatrix3d_GetHashCode(swigCPtr);
		}

		public override string ToString()
		{
			return GfPINVOKE.GfMatrix3d_ToString(swigCPtr);
		}

		public void CopyToArray(double[] dest)
		{
			GfPINVOKE.GfMatrix3d_CopyToArray(swigCPtr, dest);
		}

		public void CopyFromArray(double[] src)
		{
			GfPINVOKE.GfMatrix3d_CopyFromArray(swigCPtr, src);
		}
	}
}
