using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeMaterialBindingAPI : UsdAPISchemaBase
	{
		public class DirectBinding : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public DirectBinding(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(DirectBinding obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(DirectBinding obj)
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

			~DirectBinding()
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
							UsdShadePINVOKE.delete_UsdShadeMaterialBindingAPI_DirectBinding(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public DirectBinding()
				: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPI_DirectBinding__SWIG_0(), cMemoryOwn: true)
			{
			}

			public DirectBinding(UsdRelationship bindingRel)
				: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPI_DirectBinding__SWIG_1(UsdRelationship.getCPtr(bindingRel)), cMemoryOwn: true)
			{
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public UsdShadeMaterial GetMaterial()
			{
				return new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_DirectBinding_GetMaterial(swigCPtr), cMemoryOwn: true);
			}

			public SdfPath GetMaterialPath()
			{
				return new SdfPath(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_DirectBinding_GetMaterialPath(swigCPtr), cMemoryOwn: false);
			}

			public UsdRelationship GetBindingRel()
			{
				return new UsdRelationship(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_DirectBinding_GetBindingRel(swigCPtr), cMemoryOwn: false);
			}

			public TfToken GetMaterialPurpose()
			{
				return new TfToken(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_DirectBinding_GetMaterialPurpose(swigCPtr), cMemoryOwn: false);
			}
		}

		public class CollectionBinding : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public CollectionBinding(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(CollectionBinding obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(CollectionBinding obj)
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

			~CollectionBinding()
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
							UsdShadePINVOKE.delete_UsdShadeMaterialBindingAPI_CollectionBinding(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public CollectionBinding()
				: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPI_CollectionBinding__SWIG_0(), cMemoryOwn: true)
			{
			}

			public CollectionBinding(UsdRelationship collBindingRel)
				: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPI_CollectionBinding__SWIG_1(UsdRelationship.getCPtr(collBindingRel)), cMemoryOwn: true)
			{
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public UsdShadeMaterial GetMaterial()
			{
				return new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CollectionBinding_GetMaterial(swigCPtr), cMemoryOwn: true);
			}

			public UsdCollectionAPI GetCollection()
			{
				return new UsdCollectionAPI(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CollectionBinding_GetCollection(swigCPtr), cMemoryOwn: true);
			}

			public static bool IsCollectionBindingRel(UsdRelationship bindingRel)
			{
				bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CollectionBinding_IsCollectionBindingRel(UsdRelationship.getCPtr(bindingRel));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public bool IsValid()
			{
				return UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CollectionBinding_IsValid(swigCPtr);
			}

			public SdfPath GetCollectionPath()
			{
				return new SdfPath(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CollectionBinding_GetCollectionPath(swigCPtr), cMemoryOwn: false);
			}

			public SdfPath GetMaterialPath()
			{
				return new SdfPath(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CollectionBinding_GetMaterialPath(swigCPtr), cMemoryOwn: false);
			}

			public UsdRelationship GetBindingRel()
			{
				return new UsdRelationship(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CollectionBinding_GetBindingRel(swigCPtr), cMemoryOwn: false);
			}
		}

		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdShadeMaterialBindingAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeMaterialBindingAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeMaterialBindingAPI obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						UsdShadePINVOKE.delete_UsdShadeMaterialBindingAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdShadeMaterialBindingAPI(UsdPrim prim)
			: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeMaterialBindingAPI()
			: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdShadeMaterialBindingAPI(UsdSchemaBase schemaObj)
			: this(UsdShadePINVOKE.new_UsdShadeMaterialBindingAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdShadeMaterialBindingAPI Get(UsdStage stage, SdfPath path)
		{
			UsdShadeMaterialBindingAPI result = new UsdShadeMaterialBindingAPI(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdShadeMaterialBindingAPI Apply(UsdPrim prim)
		{
			UsdShadeMaterialBindingAPI result = new UsdShadeMaterialBindingAPI(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship GetDirectBindingRel(TfToken materialPurpose)
		{
			UsdRelationship result = new UsdRelationship(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetDirectBindingRel__SWIG_0(swigCPtr, TfToken.getCPtr(materialPurpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship GetDirectBindingRel()
		{
			return new UsdRelationship(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetDirectBindingRel__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetCollectionBindingRel(TfToken bindingName, TfToken materialPurpose)
		{
			UsdRelationship result = new UsdRelationship(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetCollectionBindingRel__SWIG_0(swigCPtr, TfToken.getCPtr(bindingName), TfToken.getCPtr(materialPurpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship GetCollectionBindingRel(TfToken bindingName)
		{
			UsdRelationship result = new UsdRelationship(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetCollectionBindingRel__SWIG_1(swigCPtr, TfToken.getCPtr(bindingName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationshipVector GetCollectionBindingRels(TfToken materialPurpose)
		{
			UsdRelationshipVector result = new UsdRelationshipVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetCollectionBindingRels__SWIG_0(swigCPtr, TfToken.getCPtr(materialPurpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationshipVector GetCollectionBindingRels()
		{
			return new UsdRelationshipVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetCollectionBindingRels__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public DirectBinding GetDirectBinding(TfToken materialPurpose)
		{
			DirectBinding result = new DirectBinding(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetDirectBinding__SWIG_0(swigCPtr, TfToken.getCPtr(materialPurpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public DirectBinding GetDirectBinding()
		{
			return new DirectBinding(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetDirectBinding__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeMaterialBindingAPICollectionBindingVector GetCollectionBindings(TfToken materialPurpose)
		{
			UsdShadeMaterialBindingAPICollectionBindingVector result = new UsdShadeMaterialBindingAPICollectionBindingVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetCollectionBindings__SWIG_0(swigCPtr, TfToken.getCPtr(materialPurpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeMaterialBindingAPICollectionBindingVector GetCollectionBindings()
		{
			return new UsdShadeMaterialBindingAPICollectionBindingVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetCollectionBindings__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static TfToken GetMaterialBindingStrength(UsdRelationship bindingRel)
		{
			TfToken result = new TfToken(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetMaterialBindingStrength(UsdRelationship.getCPtr(bindingRel)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SetMaterialBindingStrength(UsdRelationship bindingRel, TfToken bindingStrength)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_SetMaterialBindingStrength(UsdRelationship.getCPtr(bindingRel), TfToken.getCPtr(bindingStrength));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Bind(UsdShadeMaterial material, TfToken bindingStrength, TfToken materialPurpose)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Bind__SWIG_0(swigCPtr, UsdShadeMaterial.getCPtr(material), TfToken.getCPtr(bindingStrength), TfToken.getCPtr(materialPurpose));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Bind(UsdShadeMaterial material, TfToken bindingStrength)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Bind__SWIG_1(swigCPtr, UsdShadeMaterial.getCPtr(material), TfToken.getCPtr(bindingStrength));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Bind(UsdShadeMaterial material)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Bind__SWIG_2(swigCPtr, UsdShadeMaterial.getCPtr(material));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Bind(UsdCollectionAPI collection, UsdShadeMaterial material, TfToken bindingName, TfToken bindingStrength, TfToken materialPurpose)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Bind__SWIG_3(swigCPtr, UsdCollectionAPI.getCPtr(collection), UsdShadeMaterial.getCPtr(material), TfToken.getCPtr(bindingName), TfToken.getCPtr(bindingStrength), TfToken.getCPtr(materialPurpose));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Bind(UsdCollectionAPI collection, UsdShadeMaterial material, TfToken bindingName, TfToken bindingStrength)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Bind__SWIG_4(swigCPtr, UsdCollectionAPI.getCPtr(collection), UsdShadeMaterial.getCPtr(material), TfToken.getCPtr(bindingName), TfToken.getCPtr(bindingStrength));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Bind(UsdCollectionAPI collection, UsdShadeMaterial material, TfToken bindingName)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Bind__SWIG_5(swigCPtr, UsdCollectionAPI.getCPtr(collection), UsdShadeMaterial.getCPtr(material), TfToken.getCPtr(bindingName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Bind(UsdCollectionAPI collection, UsdShadeMaterial material)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_Bind__SWIG_6(swigCPtr, UsdCollectionAPI.getCPtr(collection), UsdShadeMaterial.getCPtr(material));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UnbindDirectBinding(TfToken materialPurpose)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_UnbindDirectBinding__SWIG_0(swigCPtr, TfToken.getCPtr(materialPurpose));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UnbindDirectBinding()
		{
			return UsdShadePINVOKE.UsdShadeMaterialBindingAPI_UnbindDirectBinding__SWIG_1(swigCPtr);
		}

		public bool UnbindCollectionBinding(TfToken bindingName, TfToken materialPurpose)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_UnbindCollectionBinding__SWIG_0(swigCPtr, TfToken.getCPtr(bindingName), TfToken.getCPtr(materialPurpose));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UnbindCollectionBinding(TfToken bindingName)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_UnbindCollectionBinding__SWIG_1(swigCPtr, TfToken.getCPtr(bindingName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool UnbindAllBindings()
		{
			return UsdShadePINVOKE.UsdShadeMaterialBindingAPI_UnbindAllBindings(swigCPtr);
		}

		public bool RemovePrimFromBindingCollection(UsdPrim prim, TfToken bindingName, TfToken materialPurpose)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_RemovePrimFromBindingCollection(swigCPtr, UsdPrim.getCPtr(prim), TfToken.getCPtr(bindingName), TfToken.getCPtr(materialPurpose));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddPrimToBindingCollection(UsdPrim prim, TfToken bindingName, TfToken materialPurpose)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_AddPrimToBindingCollection(swigCPtr, UsdPrim.getCPtr(prim), TfToken.getCPtr(bindingName), TfToken.getCPtr(materialPurpose));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfTokenVector GetMaterialPurposes()
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetMaterialPurposes(), cMemoryOwn: true);
		}

		public static SdfPath GetResolvedTargetPathFromBindingRel(UsdRelationship bindingRel)
		{
			SdfPath result = new SdfPath(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetResolvedTargetPathFromBindingRel(UsdRelationship.getCPtr(bindingRel)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeMaterial ComputeBoundMaterial(TfToken materialPurpose, UsdRelationship bindingRel)
		{
			UsdShadeMaterial result = new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_0(swigCPtr, TfToken.getCPtr(materialPurpose), UsdRelationship.getCPtr(bindingRel)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeMaterial ComputeBoundMaterial(TfToken materialPurpose)
		{
			UsdShadeMaterial result = new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_1(swigCPtr, TfToken.getCPtr(materialPurpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeMaterial ComputeBoundMaterial()
		{
			return new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public static UsdShadeMaterialVector ComputeBoundMaterials(UsdPrimVector prims, TfToken materialPurpose, UsdRelationshipVector bindingRels)
		{
			UsdShadeMaterialVector result = new UsdShadeMaterialVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_0(UsdPrimVector.getCPtr(prims), TfToken.getCPtr(materialPurpose), UsdRelationshipVector.getCPtr(bindingRels)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdShadeMaterialVector ComputeBoundMaterials(UsdPrimVector prims, TfToken materialPurpose)
		{
			UsdShadeMaterialVector result = new UsdShadeMaterialVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_1(UsdPrimVector.getCPtr(prims), TfToken.getCPtr(materialPurpose)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdShadeMaterialVector ComputeBoundMaterials(UsdPrimVector prims)
		{
			UsdShadeMaterialVector result = new UsdShadeMaterialVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_2(UsdPrimVector.getCPtr(prims)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomSubset CreateMaterialBindSubset(TfToken subsetName, VtIntArray indices, TfToken elementType)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CreateMaterialBindSubset__SWIG_0(swigCPtr, TfToken.getCPtr(subsetName), VtIntArray.getCPtr(indices), TfToken.getCPtr(elementType)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomSubset CreateMaterialBindSubset(TfToken subsetName, VtIntArray indices)
		{
			UsdGeomSubset result = new UsdGeomSubset(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CreateMaterialBindSubset__SWIG_1(swigCPtr, TfToken.getCPtr(subsetName), VtIntArray.getCPtr(indices)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdGeomSubsetVector GetMaterialBindSubsets()
		{
			return new UsdGeomSubsetVector(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetMaterialBindSubsets(swigCPtr), cMemoryOwn: true);
		}

		public bool SetMaterialBindSubsetsFamilyType(TfToken familyType)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_SetMaterialBindSubsetsFamilyType(swigCPtr, TfToken.getCPtr(familyType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetMaterialBindSubsetsFamilyType()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeMaterialBindingAPI_GetMaterialBindSubsetsFamilyType(swigCPtr), cMemoryOwn: true);
		}

		public static bool CanContainPropertyName(TfToken name)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterialBindingAPI_CanContainPropertyName(TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
