using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrNodeDiscoveryResult : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfToken identifier
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResult_identifier_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_identifier_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public NdrVersion version
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResult_version_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new NdrVersion(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_version_set(swigCPtr, NdrVersion.getCPtr(value));
			}
		}

		public string name
		{
			get
			{
				string result = NdrPINVOKE.NdrNodeDiscoveryResult_name_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_name_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public TfToken family
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResult_family_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_family_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public TfToken discoveryType
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResult_discoveryType_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_discoveryType_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public TfToken sourceType
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResult_sourceType_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_sourceType_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public string uri
		{
			get
			{
				string result = NdrPINVOKE.NdrNodeDiscoveryResult_uri_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_uri_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public string resolvedUri
		{
			get
			{
				string result = NdrPINVOKE.NdrNodeDiscoveryResult_resolvedUri_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_resolvedUri_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public string sourceCode
		{
			get
			{
				string result = NdrPINVOKE.NdrNodeDiscoveryResult_sourceCode_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_sourceCode_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public NdrTokenMap metadata
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResult_metadata_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new NdrTokenMap(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_metadata_set(swigCPtr, NdrTokenMap.getCPtr(value));
			}
		}

		public string blindData
		{
			get
			{
				string result = NdrPINVOKE.NdrNodeDiscoveryResult_blindData_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_blindData_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public TfToken subIdentifier
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrNodeDiscoveryResult_subIdentifier_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrNodeDiscoveryResult_subIdentifier_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public NdrNodeDiscoveryResult(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrNodeDiscoveryResult obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrNodeDiscoveryResult obj)
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

		~NdrNodeDiscoveryResult()
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
						NdrPINVOKE.delete_NdrNodeDiscoveryResult(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public NdrNodeDiscoveryResult(TfToken identifier, NdrVersion version, string name, TfToken family, TfToken discoveryType, TfToken sourceType, string uri, string resolvedUri, string sourceCode, NdrTokenMap metadata, string blindData, TfToken subIdentifier)
			: this(NdrPINVOKE.new_NdrNodeDiscoveryResult__SWIG_0(TfToken.getCPtr(identifier), NdrVersion.getCPtr(version), name, TfToken.getCPtr(family), TfToken.getCPtr(discoveryType), TfToken.getCPtr(sourceType), uri, resolvedUri, sourceCode, NdrTokenMap.getCPtr(metadata), blindData, TfToken.getCPtr(subIdentifier)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrNodeDiscoveryResult(TfToken identifier, NdrVersion version, string name, TfToken family, TfToken discoveryType, TfToken sourceType, string uri, string resolvedUri, string sourceCode, NdrTokenMap metadata, string blindData)
			: this(NdrPINVOKE.new_NdrNodeDiscoveryResult__SWIG_1(TfToken.getCPtr(identifier), NdrVersion.getCPtr(version), name, TfToken.getCPtr(family), TfToken.getCPtr(discoveryType), TfToken.getCPtr(sourceType), uri, resolvedUri, sourceCode, NdrTokenMap.getCPtr(metadata), blindData), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrNodeDiscoveryResult(TfToken identifier, NdrVersion version, string name, TfToken family, TfToken discoveryType, TfToken sourceType, string uri, string resolvedUri, string sourceCode, NdrTokenMap metadata)
			: this(NdrPINVOKE.new_NdrNodeDiscoveryResult__SWIG_2(TfToken.getCPtr(identifier), NdrVersion.getCPtr(version), name, TfToken.getCPtr(family), TfToken.getCPtr(discoveryType), TfToken.getCPtr(sourceType), uri, resolvedUri, sourceCode, NdrTokenMap.getCPtr(metadata)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrNodeDiscoveryResult(TfToken identifier, NdrVersion version, string name, TfToken family, TfToken discoveryType, TfToken sourceType, string uri, string resolvedUri, string sourceCode)
			: this(NdrPINVOKE.new_NdrNodeDiscoveryResult__SWIG_3(TfToken.getCPtr(identifier), NdrVersion.getCPtr(version), name, TfToken.getCPtr(family), TfToken.getCPtr(discoveryType), TfToken.getCPtr(sourceType), uri, resolvedUri, sourceCode), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrNodeDiscoveryResult(TfToken identifier, NdrVersion version, string name, TfToken family, TfToken discoveryType, TfToken sourceType, string uri, string resolvedUri)
			: this(NdrPINVOKE.new_NdrNodeDiscoveryResult__SWIG_4(TfToken.getCPtr(identifier), NdrVersion.getCPtr(version), name, TfToken.getCPtr(family), TfToken.getCPtr(discoveryType), TfToken.getCPtr(sourceType), uri, resolvedUri), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
