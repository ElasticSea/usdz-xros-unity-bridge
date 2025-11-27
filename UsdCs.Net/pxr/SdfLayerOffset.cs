using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerOffset : IDisposable
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
							SdfPINVOKE.delete_SdfLayerOffset_Hash(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Hash()
				: this(SdfPINVOKE.new_SdfLayerOffset_Hash(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfLayerOffset(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerOffset obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerOffset obj)
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

		~SdfLayerOffset()
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
						SdfPINVOKE.delete_SdfLayerOffset(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfLayerOffset(double offset, double scale)
			: this(SdfPINVOKE.new_SdfLayerOffset__SWIG_0(offset, scale), cMemoryOwn: true)
		{
		}

		public SdfLayerOffset(double offset)
			: this(SdfPINVOKE.new_SdfLayerOffset__SWIG_1(offset), cMemoryOwn: true)
		{
		}

		public SdfLayerOffset()
			: this(SdfPINVOKE.new_SdfLayerOffset__SWIG_2(), cMemoryOwn: true)
		{
		}

		public double GetOffset()
		{
			return SdfPINVOKE.SdfLayerOffset_GetOffset(swigCPtr);
		}

		public double GetScale()
		{
			return SdfPINVOKE.SdfLayerOffset_GetScale(swigCPtr);
		}

		public void SetOffset(double newOffset)
		{
			SdfPINVOKE.SdfLayerOffset_SetOffset(swigCPtr, newOffset);
		}

		public void SetScale(double newScale)
		{
			SdfPINVOKE.SdfLayerOffset_SetScale(swigCPtr, newScale);
		}

		public bool IsIdentity()
		{
			return SdfPINVOKE.SdfLayerOffset_IsIdentity(swigCPtr);
		}

		public bool IsValid()
		{
			return SdfPINVOKE.SdfLayerOffset_IsValid(swigCPtr);
		}

		public SdfLayerOffset GetInverse()
		{
			return new SdfLayerOffset(SdfPINVOKE.SdfLayerOffset_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public uint GetHash()
		{
			return SdfPINVOKE.SdfLayerOffset_GetHash(swigCPtr);
		}
	}
}
