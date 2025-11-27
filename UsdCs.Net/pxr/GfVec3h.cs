using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec3h : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 3u;

		public float this[int index]
		{
			get
			{
				return GetValue(index);
			}
			set
			{
				SetValue(index, value);
			}
		}

		public GfVec3h(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec3h obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec3h obj)
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

		~GfVec3h()
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
						GfPINVOKE.delete_GfVec3h(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec3h()
			: this(GfPINVOKE.new_GfVec3h__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec3h(GfHalf value)
			: this(GfPINVOKE.new_GfVec3h__SWIG_1(GfHalf.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3h(GfHalf s0, GfHalf s1, GfHalf s2)
			: this(GfPINVOKE.new_GfVec3h__SWIG_2(GfHalf.getCPtr(s0), GfHalf.getCPtr(s1), GfHalf.getCPtr(s2)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3h(GfVec3d other)
			: this(GfPINVOKE.new_GfVec3h__SWIG_4(GfVec3d.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3h(GfVec3f other)
			: this(GfPINVOKE.new_GfVec3h__SWIG_5(GfVec3f.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3h(GfVec3i other)
			: this(GfPINVOKE.new_GfVec3h__SWIG_6(GfVec3i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec3h XAxis()
		{
			return new GfVec3h(GfPINVOKE.GfVec3h_XAxis(), cMemoryOwn: true);
		}

		public static GfVec3h YAxis()
		{
			return new GfVec3h(GfPINVOKE.GfVec3h_YAxis(), cMemoryOwn: true);
		}

		public static GfVec3h ZAxis()
		{
			return new GfVec3h(GfPINVOKE.GfVec3h_ZAxis(), cMemoryOwn: true);
		}

		public static GfVec3h Axis(uint i)
		{
			return new GfVec3h(GfPINVOKE.GfVec3h_Axis(i), cMemoryOwn: true);
		}

		public GfVec3h Set(GfHalf s0, GfHalf s1, GfHalf s2)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfVec3h_Set__SWIG_0(swigCPtr, GfHalf.getCPtr(s0), GfHalf.getCPtr(s1), GfHalf.getCPtr(s2)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3h Set(GfHalf a)
		{
			return new GfVec3h(GfPINVOKE.GfVec3h_Set__SWIG_1(swigCPtr, GfHalf.getCPtr(a)), cMemoryOwn: false);
		}

		public GfVec3h GetProjection(GfVec3h v)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfVec3h_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3h GetComplement(GfVec3h b)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfVec3h_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfHalf GetLengthSq()
		{
			return new GfHalf(GfPINVOKE.GfVec3h_GetLengthSq(swigCPtr), cMemoryOwn: true);
		}

		public GfHalf GetLength()
		{
			return new GfHalf(GfPINVOKE.GfVec3h_GetLength(swigCPtr), cMemoryOwn: true);
		}

		public GfHalf Normalize(GfHalf eps)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfVec3h_Normalize__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfHalf Normalize()
		{
			return new GfHalf(GfPINVOKE.GfVec3h_Normalize__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3h GetNormalized(GfHalf eps)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfVec3h_GetNormalized__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3h GetNormalized()
		{
			return new GfVec3h(GfPINVOKE.GfVec3h_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool OrthogonalizeBasis(GfVec3h tx, GfVec3h ty, GfVec3h tz, bool normalize, double eps)
		{
			return GfPINVOKE.GfVec3h_OrthogonalizeBasis__SWIG_0(getCPtr(tx), getCPtr(ty), getCPtr(tz), normalize, eps);
		}

		public static bool OrthogonalizeBasis(GfVec3h tx, GfVec3h ty, GfVec3h tz, bool normalize)
		{
			return GfPINVOKE.GfVec3h_OrthogonalizeBasis__SWIG_1(getCPtr(tx), getCPtr(ty), getCPtr(tz), normalize);
		}

		public void BuildOrthonormalFrame(GfVec3h v1, GfVec3h v2, GfHalf eps)
		{
			GfPINVOKE.GfVec3h_BuildOrthonormalFrame__SWIG_0(swigCPtr, getCPtr(v1), getCPtr(v2), GfHalf.getCPtr(eps));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void BuildOrthonormalFrame(GfVec3h v1, GfVec3h v2)
		{
			GfPINVOKE.GfVec3h_BuildOrthonormalFrame__SWIG_1(swigCPtr, getCPtr(v1), getCPtr(v2));
		}

		public static bool Equals(GfVec3h lhs, GfVec3h rhs)
		{
			bool result = GfPINVOKE.GfVec3h_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec3h lhs, GfVec3h rhs)
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

		public static bool operator !=(GfVec3h lhs, GfVec3h rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec3h);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec3h_GetHashCode(swigCPtr);
		}

		protected float GetValue(int index)
		{
			return GfPINVOKE.GfVec3h_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, float value)
		{
			GfPINVOKE.GfVec3h_SetValue(swigCPtr, index, value);
		}
	}
}
