using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfType : IDisposable
	{
		public class FactoryBase : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public FactoryBase(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(FactoryBase obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(FactoryBase obj)
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

			~FactoryBase()
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
							TfPINVOKE.delete_TfType_FactoryBase(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public FactoryBase()
				: this(TfPINVOKE.new_TfType_FactoryBase(), cMemoryOwn: true)
			{
			}
		}

		public enum LegacyFlags
		{
			ABSTRACT = 1,
			CONCRETE = 2,
			MANUFACTURABLE = 8
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfType(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfType obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfType obj)
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

		~TfType()
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
						TfPINVOKE.delete_TfType(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfType()
			: this(TfPINVOKE.new_TfType(), cMemoryOwn: true)
		{
		}

		public static TfType GetUnknownType()
		{
			return new TfType(TfPINVOKE.TfType_GetUnknownType(), cMemoryOwn: false);
		}

		public static TfType FindByName(string name)
		{
			TfType result = new TfType(TfPINVOKE.TfType_FindByName(name), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfType FindDerivedByName(string name)
		{
			TfType result = new TfType(TfPINVOKE.TfType_FindDerivedByName(swigCPtr, name), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfType GetRoot()
		{
			return new TfType(TfPINVOKE.TfType_GetRoot(), cMemoryOwn: false);
		}

		public string GetTypeName()
		{
			return TfPINVOKE.TfType_GetTypeName(swigCPtr);
		}

		public StdStringVector GetAliases(TfType derivedType)
		{
			StdStringVector result = new StdStringVector(TfPINVOKE.TfType_GetAliases(swigCPtr, getCPtr(derivedType)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTypeVector GetBaseTypes()
		{
			return new TfTypeVector(TfPINVOKE.TfType_GetBaseTypes(swigCPtr), cMemoryOwn: true);
		}

		public uint GetNBaseTypes(TfType out_, uint maxBases)
		{
			return TfPINVOKE.TfType_GetNBaseTypes(swigCPtr, getCPtr(out_), maxBases);
		}

		public TfTypeVector GetDirectlyDerivedTypes()
		{
			return new TfTypeVector(TfPINVOKE.TfType_GetDirectlyDerivedTypes(swigCPtr), cMemoryOwn: true);
		}

		public TfType GetCanonicalType()
		{
			return new TfType(TfPINVOKE.TfType_GetCanonicalType(swigCPtr), cMemoryOwn: false);
		}

		public void GetAllDerivedTypes(TfTypeSet result)
		{
			TfPINVOKE.TfType_GetAllDerivedTypes(swigCPtr, TfTypeSet.getCPtr(result));
		}

		public void GetAllAncestorTypes(TfTypeVector result)
		{
			TfPINVOKE.TfType_GetAllAncestorTypes(swigCPtr, TfTypeVector.getCPtr(result));
		}

		public bool IsA(TfType queryType)
		{
			bool result = TfPINVOKE.TfType_IsA(swigCPtr, getCPtr(queryType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsUnknown()
		{
			return TfPINVOKE.TfType_IsUnknown(swigCPtr);
		}

		public bool IsRoot()
		{
			return TfPINVOKE.TfType_IsRoot(swigCPtr);
		}

		public bool IsEnumType()
		{
			return TfPINVOKE.TfType_IsEnumType(swigCPtr);
		}

		public bool IsPlainOldDataType()
		{
			return TfPINVOKE.TfType_IsPlainOldDataType(swigCPtr);
		}

		public uint GetSizeof()
		{
			return TfPINVOKE.TfType_GetSizeof(swigCPtr);
		}

		public static TfType Declare(string typeName)
		{
			TfType result = new TfType(TfPINVOKE.TfType_Declare(typeName), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void AddAlias(TfType base_, string name)
		{
			TfPINVOKE.TfType_AddAlias(swigCPtr, getCPtr(base_), name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfType Alias(TfType base_, string name)
		{
			TfType result = new TfType(TfPINVOKE.TfType_Alias(swigCPtr, getCPtr(base_), name), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_void CastToAncestor(TfType ancestor, SWIGTYPE_p_void addr)
		{
			IntPtr intPtr = TfPINVOKE.TfType_CastToAncestor__SWIG_0(swigCPtr, getCPtr(ancestor), SWIGTYPE_p_void.getCPtr(addr));
			SWIGTYPE_p_void result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(intPtr, futureUse: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_void CastFromAncestor(TfType ancestor, SWIGTYPE_p_void addr)
		{
			IntPtr intPtr = TfPINVOKE.TfType_CastFromAncestor__SWIG_0(swigCPtr, getCPtr(ancestor), SWIGTYPE_p_void.getCPtr(addr));
			SWIGTYPE_p_void result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(intPtr, futureUse: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
