using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class PcpLayerStackIdentifierStr : IDisposable
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
							PcpPINVOKE.delete_PcpLayerStackIdentifierStr_Hash(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Hash()
				: this(PcpPINVOKE.new_PcpLayerStackIdentifierStr_Hash(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string rootLayerId
		{
			get
			{
				string result = PcpPINVOKE.PcpLayerStackIdentifierStr_rootLayerId_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				PcpPINVOKE.PcpLayerStackIdentifierStr_rootLayerId_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public string sessionLayerId
		{
			get
			{
				string result = PcpPINVOKE.PcpLayerStackIdentifierStr_sessionLayerId_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				PcpPINVOKE.PcpLayerStackIdentifierStr_sessionLayerId_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public ArResolverContext pathResolverContext
		{
			get
			{
				IntPtr intPtr = PcpPINVOKE.PcpLayerStackIdentifierStr_pathResolverContext_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new ArResolverContext(intPtr, cMemoryOwn: false);
			}
			set
			{
				PcpPINVOKE.PcpLayerStackIdentifierStr_pathResolverContext_set(swigCPtr, ArResolverContext.getCPtr(value));
			}
		}

		public PcpLayerStackIdentifierStr(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(PcpLayerStackIdentifierStr obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(PcpLayerStackIdentifierStr obj)
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

		~PcpLayerStackIdentifierStr()
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
						PcpPINVOKE.delete_PcpLayerStackIdentifierStr(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public PcpLayerStackIdentifierStr(string rootLayerId, string sessionLayerId, ArResolverContext resolverContext)
			: this(PcpPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_0(rootLayerId, sessionLayerId, ArResolverContext.getCPtr(resolverContext)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackIdentifierStr(string rootLayerId, string sessionLayerId)
			: this(PcpPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_1(rootLayerId, sessionLayerId), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackIdentifierStr(string rootLayerId)
			: this(PcpPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_2(rootLayerId), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public PcpLayerStackIdentifierStr()
			: this(PcpPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_3(), cMemoryOwn: true)
		{
		}

		public PcpLayerStackIdentifierStr(PcpLayerStackIdentifier lsid)
			: this(PcpPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_4(PcpLayerStackIdentifier.getCPtr(lsid)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public uint GetHash()
		{
			return PcpPINVOKE.PcpLayerStackIdentifierStr_GetHash(swigCPtr);
		}
	}
}
