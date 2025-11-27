using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfBBox3d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfBBox3d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfBBox3d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfBBox3d obj)
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

		~GfBBox3d()
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
						GfPINVOKE.delete_GfBBox3d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfBBox3d()
			: this(GfPINVOKE.new_GfBBox3d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfBBox3d(GfBBox3d rhs)
			: this(GfPINVOKE.new_GfBBox3d__SWIG_1(getCPtr(rhs)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfBBox3d(GfRange3d box)
			: this(GfPINVOKE.new_GfBBox3d__SWIG_2(GfRange3d.getCPtr(box)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfBBox3d(GfRange3d box, GfMatrix4d matrix)
			: this(GfPINVOKE.new_GfBBox3d__SWIG_3(GfRange3d.getCPtr(box), GfMatrix4d.getCPtr(matrix)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Set(GfRange3d box, GfMatrix4d matrix)
		{
			GfPINVOKE.GfBBox3d_Set(swigCPtr, GfRange3d.getCPtr(box), GfMatrix4d.getCPtr(matrix));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetMatrix(GfMatrix4d matrix)
		{
			GfPINVOKE.GfBBox3d_SetMatrix(swigCPtr, GfMatrix4d.getCPtr(matrix));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(GfRange3d box)
		{
			GfPINVOKE.GfBBox3d_SetRange(swigCPtr, GfRange3d.getCPtr(box));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRange3d GetRange()
		{
			return new GfRange3d(GfPINVOKE.GfBBox3d_GetRange(swigCPtr), cMemoryOwn: false);
		}

		public GfRange3d GetBox()
		{
			return new GfRange3d(GfPINVOKE.GfBBox3d_GetBox(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix4d GetMatrix()
		{
			return new GfMatrix4d(GfPINVOKE.GfBBox3d_GetMatrix(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix4d GetInverseMatrix()
		{
			return new GfMatrix4d(GfPINVOKE.GfBBox3d_GetInverseMatrix(swigCPtr), cMemoryOwn: false);
		}

		public void SetHasZeroAreaPrimitives(bool hasThem)
		{
			GfPINVOKE.GfBBox3d_SetHasZeroAreaPrimitives(swigCPtr, hasThem);
		}

		public bool HasZeroAreaPrimitives()
		{
			return GfPINVOKE.GfBBox3d_HasZeroAreaPrimitives(swigCPtr);
		}

		public double GetVolume()
		{
			return GfPINVOKE.GfBBox3d_GetVolume(swigCPtr);
		}

		public void Transform(GfMatrix4d matrix)
		{
			GfPINVOKE.GfBBox3d_Transform(swigCPtr, GfMatrix4d.getCPtr(matrix));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRange3d ComputeAlignedRange()
		{
			return new GfRange3d(GfPINVOKE.GfBBox3d_ComputeAlignedRange(swigCPtr), cMemoryOwn: true);
		}

		public GfRange3d ComputeAlignedBox()
		{
			return new GfRange3d(GfPINVOKE.GfBBox3d_ComputeAlignedBox(swigCPtr), cMemoryOwn: true);
		}

		public static GfBBox3d Combine(GfBBox3d b1, GfBBox3d b2)
		{
			GfBBox3d result = new GfBBox3d(GfPINVOKE.GfBBox3d_Combine(getCPtr(b1), getCPtr(b2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d ComputeCentroid()
		{
			return new GfVec3d(GfPINVOKE.GfBBox3d_ComputeCentroid(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfBBox3d lhs, GfBBox3d rhs)
		{
			bool result = GfPINVOKE.GfBBox3d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfBBox3d lhs, GfBBox3d rhs)
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

		public static bool operator !=(GfBBox3d lhs, GfBBox3d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfBBox3d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfBBox3d_GetHashCode(swigCPtr);
		}
	}
}
