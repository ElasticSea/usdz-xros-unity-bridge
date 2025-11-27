namespace pxr
{
	public class Gf
	{
		public static double GfDot(GfDualQuatd dq1, GfDualQuatd dq2)
		{
			double result = GfPINVOKE.GfDot__SWIG_0(GfDualQuatd.getCPtr(dq1), GfDualQuatd.getCPtr(dq2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfDot(GfDualQuatf dq1, GfDualQuatf dq2)
		{
			float result = GfPINVOKE.GfDot__SWIG_1(GfDualQuatf.getCPtr(dq1), GfDualQuatf.getCPtr(dq2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfDot(GfDualQuath dq1, GfDualQuath dq2)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfDot__SWIG_2(GfDualQuath.getCPtr(dq1), GfDualQuath.getCPtr(dq2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfApplyGamma(GfVec3f v, double gamma)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfApplyGamma__SWIG_0(GfVec3f.getCPtr(v), gamma), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfApplyGamma(GfVec3d v, double gamma)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfApplyGamma__SWIG_1(GfVec3d.getCPtr(v), gamma), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfApplyGamma(GfVec3h v, double gamma)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfApplyGamma__SWIG_2(GfVec3h.getCPtr(v), gamma), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfApplyGamma(GfVec4f v, double gamma)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfApplyGamma__SWIG_3(GfVec4f.getCPtr(v), gamma), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfApplyGamma(GfVec4d v, double gamma)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfApplyGamma__SWIG_4(GfVec4d.getCPtr(v), gamma), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4h GfApplyGamma(GfVec4h v, double gamma)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfApplyGamma__SWIG_5(GfVec4h.getCPtr(v), gamma), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfApplyGamma(float v, double gamma)
		{
			return GfPINVOKE.GfApplyGamma__SWIG_6(v, gamma);
		}

		public static byte GfApplyGamma(byte v, double gamma)
		{
			return GfPINVOKE.GfApplyGamma__SWIG_7(v, gamma);
		}

		public static double GfGetDisplayGamma()
		{
			return GfPINVOKE.GfGetDisplayGamma();
		}

		public static GfVec3f GfConvertLinearToDisplay(GfVec3f v)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfConvertLinearToDisplay__SWIG_0(GfVec3f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfConvertLinearToDisplay(GfVec3d v)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfConvertLinearToDisplay__SWIG_1(GfVec3d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfConvertLinearToDisplay(GfVec3h v)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfConvertLinearToDisplay__SWIG_2(GfVec3h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfConvertLinearToDisplay(GfVec4f v)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfConvertLinearToDisplay__SWIG_3(GfVec4f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfConvertLinearToDisplay(GfVec4d v)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfConvertLinearToDisplay__SWIG_4(GfVec4d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4h GfConvertLinearToDisplay(GfVec4h v)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfConvertLinearToDisplay__SWIG_5(GfVec4h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfConvertLinearToDisplay(float v)
		{
			return GfPINVOKE.GfConvertLinearToDisplay__SWIG_6(v);
		}

		public static byte GfConvertLinearToDisplay(byte v)
		{
			return GfPINVOKE.GfConvertLinearToDisplay__SWIG_7(v);
		}

		public static GfVec3f GfConvertDisplayToLinear(GfVec3f v)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfConvertDisplayToLinear__SWIG_0(GfVec3f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfConvertDisplayToLinear(GfVec3d v)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfConvertDisplayToLinear__SWIG_1(GfVec3d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfConvertDisplayToLinear(GfVec3h v)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfConvertDisplayToLinear__SWIG_2(GfVec3h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfConvertDisplayToLinear(GfVec4f v)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfConvertDisplayToLinear__SWIG_3(GfVec4f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfConvertDisplayToLinear(GfVec4d v)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfConvertDisplayToLinear__SWIG_4(GfVec4d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4h GfConvertDisplayToLinear(GfVec4h v)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfConvertDisplayToLinear__SWIG_5(GfVec4h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfConvertDisplayToLinear(float v)
		{
			return GfPINVOKE.GfConvertDisplayToLinear__SWIG_6(v);
		}

		public static byte GfConvertDisplayToLinear(byte v)
		{
			return GfPINVOKE.GfConvertDisplayToLinear__SWIG_7(v);
		}

		public static GfVec4f GfGetHomogenized(GfVec4f v)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfGetHomogenized__SWIG_0(GfVec4f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfHomogeneousCross(GfVec4f a, GfVec4f b)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfHomogeneousCross__SWIG_0(GfVec4f.getCPtr(a), GfVec4f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfGetHomogenized(GfVec4d v)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfGetHomogenized__SWIG_1(GfVec4d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfHomogeneousCross(GfVec4d a, GfVec4d b)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfHomogeneousCross__SWIG_1(GfVec4d.getCPtr(a), GfVec4d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfProject(GfVec4f v)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfProject__SWIG_0(GfVec4f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfProject(GfVec4d v)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfProject__SWIG_1(GfVec4d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine arg0, GfLine arg1, GfVec3d arg2, GfVec3d arg3, out double arg4, out double arg5)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_0(GfLine.getCPtr(arg0), GfLine.getCPtr(arg1), GfVec3d.getCPtr(arg2), GfVec3d.getCPtr(arg3), out arg4, out arg5);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine l1, GfLine l2, GfVec3d p1, GfVec3d p2, out double t1)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_1(GfLine.getCPtr(l1), GfLine.getCPtr(l2), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out t1);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine l1, GfLine l2, GfVec3d p1, GfVec3d p2)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_2(GfLine.getCPtr(l1), GfLine.getCPtr(l2), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine l1, GfLine l2, GfVec3d p1)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_3(GfLine.getCPtr(l1), GfLine.getCPtr(l2), GfVec3d.getCPtr(p1));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine l1, GfLine l2)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_4(GfLine.getCPtr(l1), GfLine.getCPtr(l2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine arg0, GfLineSeg arg1, GfVec3d arg2, GfVec3d arg3, out double arg4, out double arg5)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_5(GfLine.getCPtr(arg0), GfLineSeg.getCPtr(arg1), GfVec3d.getCPtr(arg2), GfVec3d.getCPtr(arg3), out arg4, out arg5);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLineSeg arg0, GfLineSeg arg1, GfVec3d arg2, GfVec3d arg3, out double arg4, out double arg5)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_6(GfLineSeg.getCPtr(arg0), GfLineSeg.getCPtr(arg1), GfVec3d.getCPtr(arg2), GfVec3d.getCPtr(arg3), out arg4, out arg5);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine line, GfLineSeg seg, GfVec3d p1, GfVec3d p2, out double t1)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_7(GfLine.getCPtr(line), GfLineSeg.getCPtr(seg), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out t1);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine line, GfLineSeg seg, GfVec3d p1, GfVec3d p2)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_8(GfLine.getCPtr(line), GfLineSeg.getCPtr(seg), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine line, GfLineSeg seg, GfVec3d p1)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_9(GfLine.getCPtr(line), GfLineSeg.getCPtr(seg), GfVec3d.getCPtr(p1));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLine line, GfLineSeg seg)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_10(GfLine.getCPtr(line), GfLineSeg.getCPtr(seg));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLineSeg seg1, GfLineSeg seg2, GfVec3d p1, GfVec3d p2, out double t1)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_11(GfLineSeg.getCPtr(seg1), GfLineSeg.getCPtr(seg2), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out t1);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLineSeg seg1, GfLineSeg seg2, GfVec3d p1, GfVec3d p2)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_12(GfLineSeg.getCPtr(seg1), GfLineSeg.getCPtr(seg2), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLineSeg seg1, GfLineSeg seg2, GfVec3d p1)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_13(GfLineSeg.getCPtr(seg1), GfLineSeg.getCPtr(seg2), GfVec3d.getCPtr(p1));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfLineSeg seg1, GfLineSeg seg2)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_14(GfLineSeg.getCPtr(seg1), GfLineSeg.getCPtr(seg2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(double a, double b, double epsilon)
		{
			return GfPINVOKE.GfIsClose__SWIG_0(a, b, epsilon);
		}

		public static double GfRadiansToDegrees(double radians)
		{
			return GfPINVOKE.GfRadiansToDegrees(radians);
		}

		public static double GfDegreesToRadians(double degrees)
		{
			return GfPINVOKE.GfDegreesToRadians(degrees);
		}

		public static double GfSqrt(double f)
		{
			return GfPINVOKE.GfSqrt__SWIG_0(f);
		}

		public static float GfSqrt(float f)
		{
			return GfPINVOKE.GfSqrt__SWIG_1(f);
		}

		public static double GfExp(double f)
		{
			return GfPINVOKE.GfExp__SWIG_0(f);
		}

		public static float GfExp(float f)
		{
			return GfPINVOKE.GfExp__SWIG_1(f);
		}

		public static double GfLog(double f)
		{
			return GfPINVOKE.GfLog__SWIG_0(f);
		}

		public static float GfLog(float f)
		{
			return GfPINVOKE.GfLog__SWIG_1(f);
		}

		public static double GfFloor(double f)
		{
			return GfPINVOKE.GfFloor__SWIG_0(f);
		}

		public static float GfFloor(float f)
		{
			return GfPINVOKE.GfFloor__SWIG_1(f);
		}

		public static double GfCeil(double f)
		{
			return GfPINVOKE.GfCeil__SWIG_0(f);
		}

		public static float GfCeil(float f)
		{
			return GfPINVOKE.GfCeil__SWIG_1(f);
		}

		public static double GfAbs(double f)
		{
			return GfPINVOKE.GfAbs__SWIG_0(f);
		}

		public static float GfAbs(float f)
		{
			return GfPINVOKE.GfAbs__SWIG_1(f);
		}

		public static double GfRound(double f)
		{
			return GfPINVOKE.GfRound__SWIG_0(f);
		}

		public static float GfRound(float f)
		{
			return GfPINVOKE.GfRound__SWIG_1(f);
		}

		public static double GfPow(double f, double p)
		{
			return GfPINVOKE.GfPow__SWIG_0(f, p);
		}

		public static float GfPow(float f, float p)
		{
			return GfPINVOKE.GfPow__SWIG_1(f, p);
		}

		public static double GfSin(double v)
		{
			return GfPINVOKE.GfSin__SWIG_0(v);
		}

		public static float GfSin(float v)
		{
			return GfPINVOKE.GfSin__SWIG_1(v);
		}

		public static double GfCos(double v)
		{
			return GfPINVOKE.GfCos__SWIG_0(v);
		}

		public static float GfCos(float v)
		{
			return GfPINVOKE.GfCos__SWIG_1(v);
		}

		public static void GfSinCos(double v, out double s, out double c)
		{
			GfPINVOKE.GfSinCos__SWIG_0(v, out s, out c);
		}

		public static void GfSinCos(float v, out float s, out float c)
		{
			GfPINVOKE.GfSinCos__SWIG_1(v, out s, out c);
		}

		public static double GfClamp(double value, double min, double max)
		{
			return GfPINVOKE.GfClamp__SWIG_0(value, min, max);
		}

		public static float GfClamp(float value, float min, float max)
		{
			return GfPINVOKE.GfClamp__SWIG_1(value, min, max);
		}

		public static double GfMod(double a, double b)
		{
			return GfPINVOKE.GfMod__SWIG_0(a, b);
		}

		public static float GfMod(float a, float b)
		{
			return GfPINVOKE.GfMod__SWIG_1(a, b);
		}

		public static double GfSqr(double x)
		{
			return GfPINVOKE.GfSqr__SWIG_1(x);
		}

		public static double GfSqr(int x)
		{
			return GfPINVOKE.GfSqr__SWIG_2(x);
		}

		public static double GfSqr(GfVec2i x)
		{
			double result = GfPINVOKE.GfSqr__SWIG_3(GfVec2i.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfSqr(GfVec3i x)
		{
			double result = GfPINVOKE.GfSqr__SWIG_4(GfVec3i.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfSqr(GfVec2f x)
		{
			double result = GfPINVOKE.GfSqr__SWIG_5(GfVec2f.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfSqr(GfVec3f x)
		{
			double result = GfPINVOKE.GfSqr__SWIG_6(GfVec3f.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfSqr(GfVec4f x)
		{
			double result = GfPINVOKE.GfSqr__SWIG_7(GfVec4f.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfSqr(GfVec2d x)
		{
			double result = GfPINVOKE.GfSqr__SWIG_8(GfVec2d.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfSqr(GfVec3d x)
		{
			double result = GfPINVOKE.GfSqr__SWIG_9(GfVec3d.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfSqr(GfVec4d x)
		{
			double result = GfPINVOKE.GfSqr__SWIG_10(GfVec4d.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfSgn(double v)
		{
			return GfPINVOKE.GfSgn__SWIG_1(v);
		}

		public static int GfSgn(int v)
		{
			return GfPINVOKE.GfSgn__SWIG_2(v);
		}

		public static double GfLerp(double alpha, double a, double b)
		{
			return GfPINVOKE.GfLerp__SWIG_1(alpha, a, b);
		}

		public static float GfLerp(double alpha, float a, float b)
		{
			return GfPINVOKE.GfLerp__SWIG_2(alpha, a, b);
		}

		public static GfVec2i GfLerp(double alpha, GfVec2i a, GfVec2i b)
		{
			GfVec2i result = new GfVec2i(GfPINVOKE.GfLerp__SWIG_3(alpha, GfVec2i.getCPtr(a), GfVec2i.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3i GfLerp(double alpha, GfVec3i a, GfVec3i b)
		{
			GfVec3i result = new GfVec3i(GfPINVOKE.GfLerp__SWIG_4(alpha, GfVec3i.getCPtr(a), GfVec3i.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2f GfLerp(double alpha, GfVec2f a, GfVec2f b)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfLerp__SWIG_5(alpha, GfVec2f.getCPtr(a), GfVec2f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfLerp(double alpha, GfVec3f a, GfVec3f b)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfLerp__SWIG_6(alpha, GfVec3f.getCPtr(a), GfVec3f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfLerp(double alpha, GfVec4f a, GfVec4f b)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfLerp__SWIG_7(alpha, GfVec4f.getCPtr(a), GfVec4f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2d GfLerp(double alpha, GfVec2d a, GfVec2d b)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfLerp__SWIG_8(alpha, GfVec2d.getCPtr(a), GfVec2d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfLerp(double alpha, GfVec3d a, GfVec3d b)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfLerp__SWIG_9(alpha, GfVec3d.getCPtr(a), GfVec3d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfLerp(double alpha, GfVec4d a, GfVec4d b)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfLerp__SWIG_10(alpha, GfVec4d.getCPtr(a), GfVec4d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfMin(double a1, double a2)
		{
			return GfPINVOKE.GfMin__SWIG_4(a1, a2);
		}

		public static double GfMin(double a1, double a2, double a3)
		{
			return GfPINVOKE.GfMin__SWIG_5(a1, a2, a3);
		}

		public static double GfMin(double a1, double a2, double a3, double a4)
		{
			return GfPINVOKE.GfMin__SWIG_6(a1, a2, a3, a4);
		}

		public static double GfMin(double a1, double a2, double a3, double a4, double a5)
		{
			return GfPINVOKE.GfMin__SWIG_7(a1, a2, a3, a4, a5);
		}

		public static int GfMin(int a1, int a2)
		{
			return GfPINVOKE.GfMin__SWIG_8(a1, a2);
		}

		public static int GfMin(int a1, int a2, int a3)
		{
			return GfPINVOKE.GfMin__SWIG_9(a1, a2, a3);
		}

		public static int GfMin(int a1, int a2, int a3, int a4)
		{
			return GfPINVOKE.GfMin__SWIG_10(a1, a2, a3, a4);
		}

		public static int GfMin(int a1, int a2, int a3, int a4, int a5)
		{
			return GfPINVOKE.GfMin__SWIG_11(a1, a2, a3, a4, a5);
		}

		public static double GfMax(double a1, double a2)
		{
			return GfPINVOKE.GfMax__SWIG_4(a1, a2);
		}

		public static double GfMax(double a1, double a2, double a3)
		{
			return GfPINVOKE.GfMax__SWIG_5(a1, a2, a3);
		}

		public static double GfMax(double a1, double a2, double a3, double a4)
		{
			return GfPINVOKE.GfMax__SWIG_6(a1, a2, a3, a4);
		}

		public static double GfMax(double a1, double a2, double a3, double a4, double a5)
		{
			return GfPINVOKE.GfMax__SWIG_7(a1, a2, a3, a4, a5);
		}

		public static int GfMax(int a1, int a2)
		{
			return GfPINVOKE.GfMax__SWIG_8(a1, a2);
		}

		public static int GfMax(int a1, int a2, int a3)
		{
			return GfPINVOKE.GfMax__SWIG_9(a1, a2, a3);
		}

		public static int GfMax(int a1, int a2, int a3, int a4)
		{
			return GfPINVOKE.GfMax__SWIG_10(a1, a2, a3, a4);
		}

		public static int GfMax(int a1, int a2, int a3, int a4, int a5)
		{
			return GfPINVOKE.GfMax__SWIG_11(a1, a2, a3, a4, a5);
		}

		public static bool GfIsClose(GfMatrix2d m1, GfMatrix2d m2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_1(GfMatrix2d.getCPtr(m1), GfMatrix2d.getCPtr(m2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfMatrix2f m1, GfMatrix2f m2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_2(GfMatrix2f.getCPtr(m1), GfMatrix2f.getCPtr(m2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfMatrix3d m1, GfMatrix3d m2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_3(GfMatrix3d.getCPtr(m1), GfMatrix3d.getCPtr(m2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfMatrix3f m1, GfMatrix3f m2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_4(GfMatrix3f.getCPtr(m1), GfMatrix3f.getCPtr(m2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfMatrix4d m1, GfMatrix4d m2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_5(GfMatrix4d.getCPtr(m1), GfMatrix4d.getCPtr(m2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfMatrix4f m1, GfMatrix4f m2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_6(GfMatrix4f.getCPtr(m1), GfMatrix4f.getCPtr(m2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFitPlaneToPoints(GfVec3dVector points, GfPlane fitPlane)
		{
			bool result = GfPINVOKE.GfFitPlaneToPoints(GfVec3dVector.getCPtr(points), GfPlane.getCPtr(fitPlane));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfDot(GfQuatd q1, GfQuatd q2)
		{
			double result = GfPINVOKE.GfDot__SWIG_3(GfQuatd.getCPtr(q1), GfQuatd.getCPtr(q2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfQuatd GfSlerp(double alpha, GfQuatd q0, GfQuatd q1)
		{
			GfQuatd result = new GfQuatd(GfPINVOKE.GfSlerp__SWIG_0(alpha, GfQuatd.getCPtr(q0), GfQuatd.getCPtr(q1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfQuatd GfSlerp(GfQuatd q0, GfQuatd q1, double alpha)
		{
			GfQuatd result = new GfQuatd(GfPINVOKE.GfSlerp__SWIG_1(GfQuatd.getCPtr(q0), GfQuatd.getCPtr(q1), alpha), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfQuaternion GfSlerp(double alpha, GfQuaternion q0, GfQuaternion q1)
		{
			GfQuaternion result = new GfQuaternion(GfPINVOKE.GfSlerp__SWIG_2(alpha, GfQuaternion.getCPtr(q0), GfQuaternion.getCPtr(q1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfQuaternion GfSlerp(GfQuaternion q0, GfQuaternion q1, double alpha)
		{
			GfQuaternion result = new GfQuaternion(GfPINVOKE.GfSlerp__SWIG_3(GfQuaternion.getCPtr(q0), GfQuaternion.getCPtr(q1), alpha), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfDot(GfQuaternion q1, GfQuaternion q2)
		{
			double result = GfPINVOKE.GfDot__SWIG_4(GfQuaternion.getCPtr(q1), GfQuaternion.getCPtr(q2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfDot(GfQuatf q1, GfQuatf q2)
		{
			float result = GfPINVOKE.GfDot__SWIG_5(GfQuatf.getCPtr(q1), GfQuatf.getCPtr(q2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfQuatf GfSlerp(double alpha, GfQuatf q0, GfQuatf q1)
		{
			GfQuatf result = new GfQuatf(GfPINVOKE.GfSlerp__SWIG_4(alpha, GfQuatf.getCPtr(q0), GfQuatf.getCPtr(q1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfQuatf GfSlerp(GfQuatf q0, GfQuatf q1, double alpha)
		{
			GfQuatf result = new GfQuatf(GfPINVOKE.GfSlerp__SWIG_5(GfQuatf.getCPtr(q0), GfQuatf.getCPtr(q1), alpha), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfDot(GfQuath q1, GfQuath q2)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfDot__SWIG_6(GfQuath.getCPtr(q1), GfQuath.getCPtr(q2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfQuath GfSlerp(double alpha, GfQuath q0, GfQuath q1)
		{
			GfQuath result = new GfQuath(GfPINVOKE.GfSlerp__SWIG_6(alpha, GfQuath.getCPtr(q0), GfQuath.getCPtr(q1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfQuath GfSlerp(GfQuath q0, GfQuath q1, double alpha)
		{
			GfQuath result = new GfQuath(GfPINVOKE.GfSlerp__SWIG_7(GfQuath.getCPtr(q0), GfQuath.getCPtr(q1), alpha), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay arg0, GfLine arg1, GfVec3d arg2, GfVec3d arg3, out double arg4, out double arg5)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_15(GfRay.getCPtr(arg0), GfLine.getCPtr(arg1), GfVec3d.getCPtr(arg2), GfVec3d.getCPtr(arg3), out arg4, out arg5);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay arg0, GfLineSeg arg1, GfVec3d arg2, GfVec3d arg3, out double arg4, out double arg5)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_16(GfRay.getCPtr(arg0), GfLineSeg.getCPtr(arg1), GfVec3d.getCPtr(arg2), GfVec3d.getCPtr(arg3), out arg4, out arg5);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay ray, GfLine line, GfVec3d rayPoint, GfVec3d linePoint, out double rayDistance)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_17(GfRay.getCPtr(ray), GfLine.getCPtr(line), GfVec3d.getCPtr(rayPoint), GfVec3d.getCPtr(linePoint), out rayDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay ray, GfLine line, GfVec3d rayPoint, GfVec3d linePoint)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_18(GfRay.getCPtr(ray), GfLine.getCPtr(line), GfVec3d.getCPtr(rayPoint), GfVec3d.getCPtr(linePoint));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay ray, GfLine line, GfVec3d rayPoint)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_19(GfRay.getCPtr(ray), GfLine.getCPtr(line), GfVec3d.getCPtr(rayPoint));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay ray, GfLine line)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_20(GfRay.getCPtr(ray), GfLine.getCPtr(line));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay ray, GfLineSeg seg, GfVec3d rayPoint, GfVec3d segPoint, out double rayDistance)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_21(GfRay.getCPtr(ray), GfLineSeg.getCPtr(seg), GfVec3d.getCPtr(rayPoint), GfVec3d.getCPtr(segPoint), out rayDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay ray, GfLineSeg seg, GfVec3d rayPoint, GfVec3d segPoint)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_22(GfRay.getCPtr(ray), GfLineSeg.getCPtr(seg), GfVec3d.getCPtr(rayPoint), GfVec3d.getCPtr(segPoint));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay ray, GfLineSeg seg, GfVec3d rayPoint)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_23(GfRay.getCPtr(ray), GfLineSeg.getCPtr(seg), GfVec3d.getCPtr(rayPoint));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfFindClosestPoints(GfRay ray, GfLineSeg seg)
		{
			bool result = GfPINVOKE.GfFindClosestPoints__SWIG_24(GfRay.getCPtr(ray), GfLineSeg.getCPtr(seg));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2d GfCompMult(GfVec2d v1, GfVec2d v2)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfCompMult__SWIG_0(GfVec2d.getCPtr(v1), GfVec2d.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2d GfCompDiv(GfVec2d v1, GfVec2d v2)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfCompDiv__SWIG_0(GfVec2d.getCPtr(v1), GfVec2d.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfDot(GfVec2d v1, GfVec2d v2)
		{
			double result = GfPINVOKE.GfDot__SWIG_7(GfVec2d.getCPtr(v1), GfVec2d.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfGetLength(GfVec2d v)
		{
			double result = GfPINVOKE.GfGetLength__SWIG_0(GfVec2d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfNormalize(GfVec2d v, double eps)
		{
			return GfPINVOKE.GfNormalize__SWIG_0(GfVec2d.getCPtr(v), eps);
		}

		public static double GfNormalize(GfVec2d v)
		{
			return GfPINVOKE.GfNormalize__SWIG_1(GfVec2d.getCPtr(v));
		}

		public static GfVec2d GfGetNormalized(GfVec2d v, double eps)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfGetNormalized__SWIG_0(GfVec2d.getCPtr(v), eps), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2d GfGetNormalized(GfVec2d v)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfGetNormalized__SWIG_1(GfVec2d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2d GfGetProjection(GfVec2d a, GfVec2d b)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfGetProjection__SWIG_0(GfVec2d.getCPtr(a), GfVec2d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2d GfGetComplement(GfVec2d a, GfVec2d b)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfGetComplement__SWIG_0(GfVec2d.getCPtr(a), GfVec2d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec2d v1, GfVec2d v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_7(GfVec2d.getCPtr(v1), GfVec2d.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2f GfCompMult(GfVec2f v1, GfVec2f v2)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfCompMult__SWIG_1(GfVec2f.getCPtr(v1), GfVec2f.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2f GfCompDiv(GfVec2f v1, GfVec2f v2)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfCompDiv__SWIG_1(GfVec2f.getCPtr(v1), GfVec2f.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfDot(GfVec2f v1, GfVec2f v2)
		{
			float result = GfPINVOKE.GfDot__SWIG_8(GfVec2f.getCPtr(v1), GfVec2f.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfGetLength(GfVec2f v)
		{
			float result = GfPINVOKE.GfGetLength__SWIG_1(GfVec2f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfNormalize(GfVec2f v, float eps)
		{
			return GfPINVOKE.GfNormalize__SWIG_2(GfVec2f.getCPtr(v), eps);
		}

		public static float GfNormalize(GfVec2f v)
		{
			return GfPINVOKE.GfNormalize__SWIG_3(GfVec2f.getCPtr(v));
		}

		public static GfVec2f GfGetNormalized(GfVec2f v, float eps)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfGetNormalized__SWIG_2(GfVec2f.getCPtr(v), eps), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2f GfGetNormalized(GfVec2f v)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfGetNormalized__SWIG_3(GfVec2f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2f GfGetProjection(GfVec2f a, GfVec2f b)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfGetProjection__SWIG_1(GfVec2f.getCPtr(a), GfVec2f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2f GfGetComplement(GfVec2f a, GfVec2f b)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfGetComplement__SWIG_1(GfVec2f.getCPtr(a), GfVec2f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec2f v1, GfVec2f v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_8(GfVec2f.getCPtr(v1), GfVec2f.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2h GfCompMult(GfVec2h v1, GfVec2h v2)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfCompMult__SWIG_2(GfVec2h.getCPtr(v1), GfVec2h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2h GfCompDiv(GfVec2h v1, GfVec2h v2)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfCompDiv__SWIG_2(GfVec2h.getCPtr(v1), GfVec2h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfDot(GfVec2h v1, GfVec2h v2)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfDot__SWIG_9(GfVec2h.getCPtr(v1), GfVec2h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfGetLength(GfVec2h v)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfGetLength__SWIG_2(GfVec2h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfNormalize(GfVec2h v, GfHalf eps)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfNormalize__SWIG_4(GfVec2h.getCPtr(v), GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfNormalize(GfVec2h v)
		{
			return new GfHalf(GfPINVOKE.GfNormalize__SWIG_5(GfVec2h.getCPtr(v)), cMemoryOwn: true);
		}

		public static GfVec2h GfGetNormalized(GfVec2h v, GfHalf eps)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfGetNormalized__SWIG_4(GfVec2h.getCPtr(v), GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2h GfGetNormalized(GfVec2h v)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfGetNormalized__SWIG_5(GfVec2h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2h GfGetProjection(GfVec2h a, GfVec2h b)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfGetProjection__SWIG_2(GfVec2h.getCPtr(a), GfVec2h.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2h GfGetComplement(GfVec2h a, GfVec2h b)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfGetComplement__SWIG_2(GfVec2h.getCPtr(a), GfVec2h.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec2h v1, GfVec2h v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_9(GfVec2h.getCPtr(v1), GfVec2h.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2i GfCompMult(GfVec2i v1, GfVec2i v2)
		{
			GfVec2i result = new GfVec2i(GfPINVOKE.GfCompMult__SWIG_3(GfVec2i.getCPtr(v1), GfVec2i.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec2i GfCompDiv(GfVec2i v1, GfVec2i v2)
		{
			GfVec2i result = new GfVec2i(GfPINVOKE.GfCompDiv__SWIG_3(GfVec2i.getCPtr(v1), GfVec2i.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static int GfDot(GfVec2i v1, GfVec2i v2)
		{
			int result = GfPINVOKE.GfDot__SWIG_10(GfVec2i.getCPtr(v1), GfVec2i.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfCompMult(GfVec3d v1, GfVec3d v2)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfCompMult__SWIG_4(GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfCompDiv(GfVec3d v1, GfVec3d v2)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfCompDiv__SWIG_4(GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfDot(GfVec3d v1, GfVec3d v2)
		{
			double result = GfPINVOKE.GfDot__SWIG_11(GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfGetLength(GfVec3d v)
		{
			double result = GfPINVOKE.GfGetLength__SWIG_3(GfVec3d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfNormalize(GfVec3d v, double eps)
		{
			return GfPINVOKE.GfNormalize__SWIG_6(GfVec3d.getCPtr(v), eps);
		}

		public static double GfNormalize(GfVec3d v)
		{
			return GfPINVOKE.GfNormalize__SWIG_7(GfVec3d.getCPtr(v));
		}

		public static GfVec3d GfGetNormalized(GfVec3d v, double eps)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfGetNormalized__SWIG_6(GfVec3d.getCPtr(v), eps), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfGetNormalized(GfVec3d v)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfGetNormalized__SWIG_7(GfVec3d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfGetProjection(GfVec3d a, GfVec3d b)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfGetProjection__SWIG_3(GfVec3d.getCPtr(a), GfVec3d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfGetComplement(GfVec3d a, GfVec3d b)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfGetComplement__SWIG_3(GfVec3d.getCPtr(a), GfVec3d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec3d v1, GfVec3d v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_10(GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfOrthogonalizeBasis(GfVec3d tx, GfVec3d ty, GfVec3d tz, bool normalize, double eps)
		{
			return GfPINVOKE.GfOrthogonalizeBasis__SWIG_0(GfVec3d.getCPtr(tx), GfVec3d.getCPtr(ty), GfVec3d.getCPtr(tz), normalize, eps);
		}

		public static bool GfOrthogonalizeBasis(GfVec3d tx, GfVec3d ty, GfVec3d tz, bool normalize)
		{
			return GfPINVOKE.GfOrthogonalizeBasis__SWIG_1(GfVec3d.getCPtr(tx), GfVec3d.getCPtr(ty), GfVec3d.getCPtr(tz), normalize);
		}

		public static void GfBuildOrthonormalFrame(GfVec3d v0, GfVec3d v1, GfVec3d v2, double eps)
		{
			GfPINVOKE.GfBuildOrthonormalFrame__SWIG_0(GfVec3d.getCPtr(v0), GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2), eps);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void GfBuildOrthonormalFrame(GfVec3d v0, GfVec3d v1, GfVec3d v2)
		{
			GfPINVOKE.GfBuildOrthonormalFrame__SWIG_1(GfVec3d.getCPtr(v0), GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec3d GfCross(GfVec3d v1, GfVec3d v2)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfCross__SWIG_0(GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3d GfSlerp(double alpha, GfVec3d v0, GfVec3d v1)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfSlerp__SWIG_8(alpha, GfVec3d.getCPtr(v0), GfVec3d.getCPtr(v1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfCompMult(GfVec3f v1, GfVec3f v2)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfCompMult__SWIG_5(GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfCompDiv(GfVec3f v1, GfVec3f v2)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfCompDiv__SWIG_5(GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfDot(GfVec3f v1, GfVec3f v2)
		{
			float result = GfPINVOKE.GfDot__SWIG_12(GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfGetLength(GfVec3f v)
		{
			float result = GfPINVOKE.GfGetLength__SWIG_4(GfVec3f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfNormalize(GfVec3f v, float eps)
		{
			return GfPINVOKE.GfNormalize__SWIG_8(GfVec3f.getCPtr(v), eps);
		}

		public static float GfNormalize(GfVec3f v)
		{
			return GfPINVOKE.GfNormalize__SWIG_9(GfVec3f.getCPtr(v));
		}

		public static GfVec3f GfGetNormalized(GfVec3f v, float eps)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfGetNormalized__SWIG_8(GfVec3f.getCPtr(v), eps), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfGetNormalized(GfVec3f v)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfGetNormalized__SWIG_9(GfVec3f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfGetProjection(GfVec3f a, GfVec3f b)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfGetProjection__SWIG_4(GfVec3f.getCPtr(a), GfVec3f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfGetComplement(GfVec3f a, GfVec3f b)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfGetComplement__SWIG_4(GfVec3f.getCPtr(a), GfVec3f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec3f v1, GfVec3f v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_11(GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfOrthogonalizeBasis(GfVec3f tx, GfVec3f ty, GfVec3f tz, bool normalize, double eps)
		{
			return GfPINVOKE.GfOrthogonalizeBasis__SWIG_2(GfVec3f.getCPtr(tx), GfVec3f.getCPtr(ty), GfVec3f.getCPtr(tz), normalize, eps);
		}

		public static bool GfOrthogonalizeBasis(GfVec3f tx, GfVec3f ty, GfVec3f tz, bool normalize)
		{
			return GfPINVOKE.GfOrthogonalizeBasis__SWIG_3(GfVec3f.getCPtr(tx), GfVec3f.getCPtr(ty), GfVec3f.getCPtr(tz), normalize);
		}

		public static void GfBuildOrthonormalFrame(GfVec3f v0, GfVec3f v1, GfVec3f v2, float eps)
		{
			GfPINVOKE.GfBuildOrthonormalFrame__SWIG_2(GfVec3f.getCPtr(v0), GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2), eps);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void GfBuildOrthonormalFrame(GfVec3f v0, GfVec3f v1, GfVec3f v2)
		{
			GfPINVOKE.GfBuildOrthonormalFrame__SWIG_3(GfVec3f.getCPtr(v0), GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec3f GfCross(GfVec3f v1, GfVec3f v2)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfCross__SWIG_1(GfVec3f.getCPtr(v1), GfVec3f.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3f GfSlerp(double alpha, GfVec3f v0, GfVec3f v1)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfSlerp__SWIG_9(alpha, GfVec3f.getCPtr(v0), GfVec3f.getCPtr(v1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfCompMult(GfVec3h v1, GfVec3h v2)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfCompMult__SWIG_6(GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfCompDiv(GfVec3h v1, GfVec3h v2)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfCompDiv__SWIG_6(GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfDot(GfVec3h v1, GfVec3h v2)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfDot__SWIG_13(GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfGetLength(GfVec3h v)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfGetLength__SWIG_5(GfVec3h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfNormalize(GfVec3h v, GfHalf eps)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfNormalize__SWIG_10(GfVec3h.getCPtr(v), GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfNormalize(GfVec3h v)
		{
			return new GfHalf(GfPINVOKE.GfNormalize__SWIG_11(GfVec3h.getCPtr(v)), cMemoryOwn: true);
		}

		public static GfVec3h GfGetNormalized(GfVec3h v, GfHalf eps)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfGetNormalized__SWIG_10(GfVec3h.getCPtr(v), GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfGetNormalized(GfVec3h v)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfGetNormalized__SWIG_11(GfVec3h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfGetProjection(GfVec3h a, GfVec3h b)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfGetProjection__SWIG_5(GfVec3h.getCPtr(a), GfVec3h.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfGetComplement(GfVec3h a, GfVec3h b)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfGetComplement__SWIG_5(GfVec3h.getCPtr(a), GfVec3h.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec3h v1, GfVec3h v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_12(GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfOrthogonalizeBasis(GfVec3h tx, GfVec3h ty, GfVec3h tz, bool normalize, double eps)
		{
			return GfPINVOKE.GfOrthogonalizeBasis__SWIG_4(GfVec3h.getCPtr(tx), GfVec3h.getCPtr(ty), GfVec3h.getCPtr(tz), normalize, eps);
		}

		public static bool GfOrthogonalizeBasis(GfVec3h tx, GfVec3h ty, GfVec3h tz, bool normalize)
		{
			return GfPINVOKE.GfOrthogonalizeBasis__SWIG_5(GfVec3h.getCPtr(tx), GfVec3h.getCPtr(ty), GfVec3h.getCPtr(tz), normalize);
		}

		public static void GfBuildOrthonormalFrame(GfVec3h v0, GfVec3h v1, GfVec3h v2, GfHalf eps)
		{
			GfPINVOKE.GfBuildOrthonormalFrame__SWIG_4(GfVec3h.getCPtr(v0), GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2), GfHalf.getCPtr(eps));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static void GfBuildOrthonormalFrame(GfVec3h v0, GfVec3h v1, GfVec3h v2)
		{
			GfPINVOKE.GfBuildOrthonormalFrame__SWIG_5(GfVec3h.getCPtr(v0), GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec3h GfCross(GfVec3h v1, GfVec3h v2)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfCross__SWIG_2(GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3h GfSlerp(double alpha, GfVec3h v0, GfVec3h v1)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfSlerp__SWIG_10(alpha, GfVec3h.getCPtr(v0), GfVec3h.getCPtr(v1)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3i GfCompMult(GfVec3i v1, GfVec3i v2)
		{
			GfVec3i result = new GfVec3i(GfPINVOKE.GfCompMult__SWIG_7(GfVec3i.getCPtr(v1), GfVec3i.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec3i GfCompDiv(GfVec3i v1, GfVec3i v2)
		{
			GfVec3i result = new GfVec3i(GfPINVOKE.GfCompDiv__SWIG_7(GfVec3i.getCPtr(v1), GfVec3i.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static int GfDot(GfVec3i v1, GfVec3i v2)
		{
			int result = GfPINVOKE.GfDot__SWIG_14(GfVec3i.getCPtr(v1), GfVec3i.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfCompMult(GfVec4d v1, GfVec4d v2)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfCompMult__SWIG_8(GfVec4d.getCPtr(v1), GfVec4d.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfCompDiv(GfVec4d v1, GfVec4d v2)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfCompDiv__SWIG_8(GfVec4d.getCPtr(v1), GfVec4d.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfDot(GfVec4d v1, GfVec4d v2)
		{
			double result = GfPINVOKE.GfDot__SWIG_15(GfVec4d.getCPtr(v1), GfVec4d.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfGetLength(GfVec4d v)
		{
			double result = GfPINVOKE.GfGetLength__SWIG_6(GfVec4d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static double GfNormalize(GfVec4d v, double eps)
		{
			return GfPINVOKE.GfNormalize__SWIG_12(GfVec4d.getCPtr(v), eps);
		}

		public static double GfNormalize(GfVec4d v)
		{
			return GfPINVOKE.GfNormalize__SWIG_13(GfVec4d.getCPtr(v));
		}

		public static GfVec4d GfGetNormalized(GfVec4d v, double eps)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfGetNormalized__SWIG_12(GfVec4d.getCPtr(v), eps), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfGetNormalized(GfVec4d v)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfGetNormalized__SWIG_13(GfVec4d.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfGetProjection(GfVec4d a, GfVec4d b)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfGetProjection__SWIG_6(GfVec4d.getCPtr(a), GfVec4d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4d GfGetComplement(GfVec4d a, GfVec4d b)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfGetComplement__SWIG_6(GfVec4d.getCPtr(a), GfVec4d.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec4d v1, GfVec4d v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_13(GfVec4d.getCPtr(v1), GfVec4d.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfCompMult(GfVec4f v1, GfVec4f v2)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfCompMult__SWIG_9(GfVec4f.getCPtr(v1), GfVec4f.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfCompDiv(GfVec4f v1, GfVec4f v2)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfCompDiv__SWIG_9(GfVec4f.getCPtr(v1), GfVec4f.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfDot(GfVec4f v1, GfVec4f v2)
		{
			float result = GfPINVOKE.GfDot__SWIG_16(GfVec4f.getCPtr(v1), GfVec4f.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfGetLength(GfVec4f v)
		{
			float result = GfPINVOKE.GfGetLength__SWIG_7(GfVec4f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static float GfNormalize(GfVec4f v, float eps)
		{
			return GfPINVOKE.GfNormalize__SWIG_14(GfVec4f.getCPtr(v), eps);
		}

		public static float GfNormalize(GfVec4f v)
		{
			return GfPINVOKE.GfNormalize__SWIG_15(GfVec4f.getCPtr(v));
		}

		public static GfVec4f GfGetNormalized(GfVec4f v, float eps)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfGetNormalized__SWIG_14(GfVec4f.getCPtr(v), eps), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfGetNormalized(GfVec4f v)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfGetNormalized__SWIG_15(GfVec4f.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfGetProjection(GfVec4f a, GfVec4f b)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfGetProjection__SWIG_7(GfVec4f.getCPtr(a), GfVec4f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4f GfGetComplement(GfVec4f a, GfVec4f b)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfGetComplement__SWIG_7(GfVec4f.getCPtr(a), GfVec4f.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec4f v1, GfVec4f v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_14(GfVec4f.getCPtr(v1), GfVec4f.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4h GfCompMult(GfVec4h v1, GfVec4h v2)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfCompMult__SWIG_10(GfVec4h.getCPtr(v1), GfVec4h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4h GfCompDiv(GfVec4h v1, GfVec4h v2)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfCompDiv__SWIG_10(GfVec4h.getCPtr(v1), GfVec4h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfDot(GfVec4h v1, GfVec4h v2)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfDot__SWIG_17(GfVec4h.getCPtr(v1), GfVec4h.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfGetLength(GfVec4h v)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfGetLength__SWIG_8(GfVec4h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfNormalize(GfVec4h v, GfHalf eps)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfNormalize__SWIG_16(GfVec4h.getCPtr(v), GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfHalf GfNormalize(GfVec4h v)
		{
			return new GfHalf(GfPINVOKE.GfNormalize__SWIG_17(GfVec4h.getCPtr(v)), cMemoryOwn: true);
		}

		public static GfVec4h GfGetNormalized(GfVec4h v, GfHalf eps)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfGetNormalized__SWIG_16(GfVec4h.getCPtr(v), GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4h GfGetNormalized(GfVec4h v)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfGetNormalized__SWIG_17(GfVec4h.getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4h GfGetProjection(GfVec4h a, GfVec4h b)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfGetProjection__SWIG_8(GfVec4h.getCPtr(a), GfVec4h.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4h GfGetComplement(GfVec4h a, GfVec4h b)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfGetComplement__SWIG_8(GfVec4h.getCPtr(a), GfVec4h.getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GfIsClose(GfVec4h v1, GfVec4h v2, double tolerance)
		{
			bool result = GfPINVOKE.GfIsClose__SWIG_15(GfVec4h.getCPtr(v1), GfVec4h.getCPtr(v2), tolerance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4i GfCompMult(GfVec4i v1, GfVec4i v2)
		{
			GfVec4i result = new GfVec4i(GfPINVOKE.GfCompMult__SWIG_11(GfVec4i.getCPtr(v1), GfVec4i.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfVec4i GfCompDiv(GfVec4i v1, GfVec4i v2)
		{
			GfVec4i result = new GfVec4i(GfPINVOKE.GfCompDiv__SWIG_11(GfVec4i.getCPtr(v1), GfVec4i.getCPtr(v2)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static int GfDot(GfVec4i v1, GfVec4i v2)
		{
			int result = GfPINVOKE.GfDot__SWIG_18(GfVec4i.getCPtr(v1), GfVec4i.getCPtr(v2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
