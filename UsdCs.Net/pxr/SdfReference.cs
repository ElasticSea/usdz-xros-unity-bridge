using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfReference : IDisposable
	{
		public class IdentityEqual : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public IdentityEqual(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(IdentityEqual obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(IdentityEqual obj)
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

			~IdentityEqual()
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
							SdfPINVOKE.delete_SdfReference_IdentityEqual(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public IdentityEqual()
				: this(SdfPINVOKE.new_SdfReference_IdentityEqual(), cMemoryOwn: true)
			{
			}
		}

		public class IdentityLessThan : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public IdentityLessThan(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(IdentityLessThan obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(IdentityLessThan obj)
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

			~IdentityLessThan()
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
							SdfPINVOKE.delete_SdfReference_IdentityLessThan(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public IdentityLessThan()
				: this(SdfPINVOKE.new_SdfReference_IdentityLessThan(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfReference(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfReference obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfReference obj)
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

		~SdfReference()
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
						SdfPINVOKE.delete_SdfReference(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfReference(string assetPath, SdfPath primPath, SdfLayerOffset layerOffset, VtDictionary customData)
			: this(SdfPINVOKE.new_SdfReference__SWIG_0(assetPath, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset), VtDictionary.getCPtr(customData)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfReference(string assetPath, SdfPath primPath, SdfLayerOffset layerOffset)
			: this(SdfPINVOKE.new_SdfReference__SWIG_1(assetPath, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfReference(string assetPath, SdfPath primPath)
			: this(SdfPINVOKE.new_SdfReference__SWIG_2(assetPath, SdfPath.getCPtr(primPath)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfReference(string assetPath)
			: this(SdfPINVOKE.new_SdfReference__SWIG_3(assetPath), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfReference()
			: this(SdfPINVOKE.new_SdfReference__SWIG_4(), cMemoryOwn: true)
		{
		}

		public string GetAssetPath()
		{
			return SdfPINVOKE.SdfReference_GetAssetPath(swigCPtr);
		}

		public void SetAssetPath(string assetPath)
		{
			SdfPINVOKE.SdfReference_SetAssetPath(swigCPtr, assetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPath GetPrimPath()
		{
			return new SdfPath(SdfPINVOKE.SdfReference_GetPrimPath(swigCPtr), cMemoryOwn: false);
		}

		public void SetPrimPath(SdfPath primPath)
		{
			SdfPINVOKE.SdfReference_SetPrimPath(swigCPtr, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerOffset GetLayerOffset()
		{
			return new SdfLayerOffset(SdfPINVOKE.SdfReference_GetLayerOffset(swigCPtr), cMemoryOwn: false);
		}

		public void SetLayerOffset(SdfLayerOffset layerOffset)
		{
			SdfPINVOKE.SdfReference_SetLayerOffset(swigCPtr, SdfLayerOffset.getCPtr(layerOffset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDictionary GetCustomData()
		{
			return new VtDictionary(SdfPINVOKE.SdfReference_GetCustomData(swigCPtr), cMemoryOwn: false);
		}

		public void SetCustomData(VtDictionary customData)
		{
			SdfPINVOKE.SdfReference_SetCustomData__SWIG_0(swigCPtr, VtDictionary.getCPtr(customData));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetCustomData(string name, VtValue value)
		{
			SdfPINVOKE.SdfReference_SetCustomData__SWIG_1(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SwapCustomData(VtDictionary customData)
		{
			SdfPINVOKE.SdfReference_SwapCustomData(swigCPtr, VtDictionary.getCPtr(customData));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsInternal()
		{
			return SdfPINVOKE.SdfReference_IsInternal(swigCPtr);
		}
	}
}
