using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpLayerStackIdentifier : IDisposable
	{
		public class Hash : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public Hash(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(Hash obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(Hash obj)
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

			~Hash()
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
							PcpPINVOKE.delete_PcpLayerStackIdentifier_Hash(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Hash()
				: this(PcpPINVOKE.new_PcpLayerStackIdentifier_Hash(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfLayerHandle rootLayer
		{
			get
			{
				IntPtr intPtr = PcpPINVOKE.PcpLayerStackIdentifier_rootLayer_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(intPtr, cMemoryOwn: false);
			}
		}

		public SdfLayerHandle sessionLayer
		{
			get
			{
				IntPtr intPtr = PcpPINVOKE.PcpLayerStackIdentifier_sessionLayer_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfLayerHandle(intPtr, cMemoryOwn: false);
			}
		}

		public ArResolverContext pathResolverContext
		{
			get
			{
				IntPtr intPtr = PcpPINVOKE.PcpLayerStackIdentifier_pathResolverContext_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new ArResolverContext(intPtr, cMemoryOwn: false);
			}
		}

		public PcpLayerStackIdentifier(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpLayerStackIdentifier obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpLayerStackIdentifier obj)
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

		~PcpLayerStackIdentifier()
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
						PcpPINVOKE.delete_PcpLayerStackIdentifier(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpLayerStackIdentifier()
			: this(PcpPINVOKE.new_PcpLayerStackIdentifier__SWIG_0(), cMemoryOwn: true)
		{
		}

		public PcpLayerStackIdentifier(SdfLayerHandle rootLayer_, SdfLayerHandle sessionLayer_, ArResolverContext pathResolverContext_)
			: this(PcpPINVOKE.new_PcpLayerStackIdentifier__SWIG_1(SdfLayerHandle.getCPtr(rootLayer_), SdfLayerHandle.getCPtr(sessionLayer_), ArResolverContext.getCPtr(pathResolverContext_)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackIdentifier(SdfLayerHandle rootLayer_, SdfLayerHandle sessionLayer_)
			: this(PcpPINVOKE.new_PcpLayerStackIdentifier__SWIG_2(SdfLayerHandle.getCPtr(rootLayer_), SdfLayerHandle.getCPtr(sessionLayer_)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackIdentifier(SdfLayerHandle rootLayer_)
			: this(PcpPINVOKE.new_PcpLayerStackIdentifier__SWIG_3(SdfLayerHandle.getCPtr(rootLayer_)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public uint GetHash()
		{
			return PcpPINVOKE.PcpLayerStackIdentifier_GetHash(swigCPtr);
		}
	}
}
