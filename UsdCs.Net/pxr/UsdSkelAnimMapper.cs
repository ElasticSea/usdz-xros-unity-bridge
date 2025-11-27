using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelAnimMapper : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwnBase;

		internal UsdSkelAnimMapper(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwnBase = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(UsdSkelAnimMapper obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		~UsdSkelAnimMapper()
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
					if (swigCMemOwnBase)
					{
						swigCMemOwnBase = false;
						UsdSkelPINVOKE.delete_UsdSkelAnimMapper(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkelAnimMapper()
			: this(UsdSkelPINVOKE.new_UsdSkelAnimMapper__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkelAnimMapper(uint size)
			: this(UsdSkelPINVOKE.new_UsdSkelAnimMapper__SWIG_1(size), cMemoryOwn: true)
		{
		}

		public UsdSkelAnimMapper(VtTokenArray sourceOrder, VtTokenArray targetOrder)
			: this(UsdSkelPINVOKE.new_UsdSkelAnimMapper__SWIG_2(VtTokenArray.getCPtr(sourceOrder), VtTokenArray.getCPtr(targetOrder)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelAnimMapper(TfToken sourceOrder, uint sourceOrderSize, TfToken targetOrder, uint targetOrderSize)
			: this(UsdSkelPINVOKE.new_UsdSkelAnimMapper__SWIG_3(TfToken.getCPtr(sourceOrder), sourceOrderSize, TfToken.getCPtr(targetOrder), targetOrderSize), cMemoryOwn: true)
		{
		}

		public bool Remap(VtValue source, VtValue target, int elementSize, VtValue defaultValue)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimMapper_Remap__SWIG_3(swigCPtr, VtValue.getCPtr(source), VtValue.getCPtr(target), elementSize, VtValue.getCPtr(defaultValue));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Remap(VtValue source, VtValue target, int elementSize)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimMapper_Remap__SWIG_4(swigCPtr, VtValue.getCPtr(source), VtValue.getCPtr(target), elementSize);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Remap(VtValue source, VtValue target)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimMapper_Remap__SWIG_5(swigCPtr, VtValue.getCPtr(source), VtValue.getCPtr(target));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsIdentity()
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimMapper_IsIdentity(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsSparse()
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimMapper_IsSparse(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsNull()
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimMapper_IsNull(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint size()
		{
			uint result = UsdSkelPINVOKE.UsdSkelAnimMapper_size(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
