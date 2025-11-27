using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfRotation : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfRotation(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfRotation obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfRotation obj)
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

		~GfRotation()
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
						GfPINVOKE.delete_GfRotation(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfRotation()
			: this(GfPINVOKE.new_GfRotation__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfRotation(GfVec3d axis, double angle)
			: this(GfPINVOKE.new_GfRotation__SWIG_1(GfVec3d.getCPtr(axis), angle), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRotation(GfQuaternion quaternion)
			: this(GfPINVOKE.new_GfRotation__SWIG_2(GfQuaternion.getCPtr(quaternion)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRotation(GfQuatd quat)
			: this(GfPINVOKE.new_GfRotation__SWIG_3(GfQuatd.getCPtr(quat)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRotation(GfVec3d rotateFrom, GfVec3d rotateTo)
			: this(GfPINVOKE.new_GfRotation__SWIG_4(GfVec3d.getCPtr(rotateFrom), GfVec3d.getCPtr(rotateTo)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRotation SetAxisAngle(GfVec3d axis, double angle)
		{
			GfRotation result = new GfRotation(GfPINVOKE.GfRotation_SetAxisAngle(swigCPtr, GfVec3d.getCPtr(axis), angle), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRotation SetQuat(GfQuatd quat)
		{
			GfRotation result = new GfRotation(GfPINVOKE.GfRotation_SetQuat(swigCPtr, GfQuatd.getCPtr(quat)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRotation SetQuaternion(GfQuaternion quat)
		{
			GfRotation result = new GfRotation(GfPINVOKE.GfRotation_SetQuaternion(swigCPtr, GfQuaternion.getCPtr(quat)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRotation SetRotateInto(GfVec3d rotateFrom, GfVec3d rotateTo)
		{
			GfRotation result = new GfRotation(GfPINVOKE.GfRotation_SetRotateInto(swigCPtr, GfVec3d.getCPtr(rotateFrom), GfVec3d.getCPtr(rotateTo)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRotation SetIdentity()
		{
			return new GfRotation(GfPINVOKE.GfRotation_SetIdentity(swigCPtr), cMemoryOwn: false);
		}

		public GfVec3d GetAxis()
		{
			return new GfVec3d(GfPINVOKE.GfRotation_GetAxis(swigCPtr), cMemoryOwn: false);
		}

		public double GetAngle()
		{
			return GfPINVOKE.GfRotation_GetAngle(swigCPtr);
		}

		public GfQuaternion GetQuaternion()
		{
			return new GfQuaternion(GfPINVOKE.GfRotation_GetQuaternion(swigCPtr), cMemoryOwn: true);
		}

		public GfQuatd GetQuat()
		{
			return new GfQuatd(GfPINVOKE.GfRotation_GetQuat(swigCPtr), cMemoryOwn: true);
		}

		public GfRotation GetInverse()
		{
			return new GfRotation(GfPINVOKE.GfRotation_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d Decompose(GfVec3d axis0, GfVec3d axis1, GfVec3d axis2)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfRotation_Decompose(swigCPtr, GfVec3d.getCPtr(axis0), GfVec3d.getCPtr(axis1), GfVec3d.getCPtr(axis2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void DecomposeRotation(GfMatrix4d rot, GfVec3d TwAxis, GfVec3d FBAxis, GfVec3d LRAxis, double handedness, out double thetaTw, out double thetaFB, out double thetaLR, out double thetaSw, bool useHint, double swShift)
		{
			GfPINVOKE.GfRotation_DecomposeRotation__SWIG_0(GfMatrix4d.getCPtr(rot), GfVec3d.getCPtr(TwAxis), GfVec3d.getCPtr(FBAxis), GfVec3d.getCPtr(LRAxis), handedness, out thetaTw, out thetaFB, out thetaLR, out thetaSw, useHint, swShift);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void DecomposeRotation(GfMatrix4d rot, GfVec3d TwAxis, GfVec3d FBAxis, GfVec3d LRAxis, double handedness, out double thetaTw, out double thetaFB, out double thetaLR, out double thetaSw, bool useHint)
		{
			GfPINVOKE.GfRotation_DecomposeRotation__SWIG_1(GfMatrix4d.getCPtr(rot), GfVec3d.getCPtr(TwAxis), GfVec3d.getCPtr(FBAxis), GfVec3d.getCPtr(LRAxis), handedness, out thetaTw, out thetaFB, out thetaLR, out thetaSw, useHint);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void DecomposeRotation(GfMatrix4d rot, GfVec3d TwAxis, GfVec3d FBAxis, GfVec3d LRAxis, double handedness, out double thetaTw, out double thetaFB, out double thetaLR, out double thetaSw)
		{
			GfPINVOKE.GfRotation_DecomposeRotation__SWIG_2(GfMatrix4d.getCPtr(rot), GfVec3d.getCPtr(TwAxis), GfVec3d.getCPtr(FBAxis), GfVec3d.getCPtr(LRAxis), handedness, out thetaTw, out thetaFB, out thetaLR, out thetaSw);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void DecomposeRotation(GfMatrix4d rot, GfVec3d TwAxis, GfVec3d FBAxis, GfVec3d LRAxis, double handedness, out double thetaTw, out double thetaFB, out double thetaLR)
		{
			GfPINVOKE.GfRotation_DecomposeRotation__SWIG_3(GfMatrix4d.getCPtr(rot), GfVec3d.getCPtr(TwAxis), GfVec3d.getCPtr(FBAxis), GfVec3d.getCPtr(LRAxis), handedness, out thetaTw, out thetaFB, out thetaLR);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfRotation RotateOntoProjected(GfVec3d v1, GfVec3d v2, GfVec3d axis)
		{
			GfRotation result = new GfRotation(GfPINVOKE.GfRotation_RotateOntoProjected(GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2), GfVec3d.getCPtr(axis)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void MatchClosestEulerRotation(double targetTw, double targetFB, double targetLR, double targetSw, out double thetaTw, out double thetaFB, out double thetaLR, out double thetaSw)
		{
			GfPINVOKE.GfRotation_MatchClosestEulerRotation(targetTw, targetFB, targetLR, targetSw, out thetaTw, out thetaFB, out thetaLR, out thetaSw);
		}

		public GfVec3f TransformDir(GfVec3f vec)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfRotation_TransformDir__SWIG_0(swigCPtr, GfVec3f.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d TransformDir(GfVec3d vec)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfRotation_TransformDir__SWIG_1(swigCPtr, GfVec3d.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfRotation lhs, GfRotation rhs)
		{
			bool result = GfPINVOKE.GfRotation_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfRotation lhs, GfRotation rhs)
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

		public static bool operator !=(GfRotation lhs, GfRotation rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfRotation);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfRotation_GetHashCode(swigCPtr);
		}
	}
}
