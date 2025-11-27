using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdZipFile : IDisposable
	{
		public class FileInfo : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public uint dataOffset
			{
				get
				{
					return UsdPINVOKE.UsdZipFile_FileInfo_dataOffset_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdZipFile_FileInfo_dataOffset_set(swigCPtr, value);
				}
			}

			public uint size
			{
				get
				{
					return UsdPINVOKE.UsdZipFile_FileInfo_size_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdZipFile_FileInfo_size_set(swigCPtr, value);
				}
			}

			public uint uncompressedSize
			{
				get
				{
					return UsdPINVOKE.UsdZipFile_FileInfo_uncompressedSize_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdZipFile_FileInfo_uncompressedSize_set(swigCPtr, value);
				}
			}

			public ushort compressionMethod
			{
				get
				{
					return UsdPINVOKE.UsdZipFile_FileInfo_compressionMethod_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdZipFile_FileInfo_compressionMethod_set(swigCPtr, value);
				}
			}

			public bool encrypted
			{
				get
				{
					return UsdPINVOKE.UsdZipFile_FileInfo_encrypted_get(swigCPtr);
				}
				set
				{
					UsdPINVOKE.UsdZipFile_FileInfo_encrypted_set(swigCPtr, value);
				}
			}

			public FileInfo(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(FileInfo obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(FileInfo obj)
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

			~FileInfo()
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
							UsdPINVOKE.delete_UsdZipFile_FileInfo(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public FileInfo()
				: this(UsdPINVOKE.new_UsdZipFile_FileInfo(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdZipFile(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdZipFile obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdZipFile obj)
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

		~UsdZipFile()
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
						UsdPINVOKE.delete_UsdZipFile(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static UsdZipFile Open(string filePath)
		{
			UsdZipFile result = new UsdZipFile(UsdPINVOKE.UsdZipFile_Open__SWIG_0(filePath), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdZipFile Open(SWIGTYPE_p_std__shared_ptrT_ArAsset_t asset)
		{
			UsdZipFile result = new UsdZipFile(UsdPINVOKE.UsdZipFile_Open__SWIG_1(SWIGTYPE_p_std__shared_ptrT_ArAsset_t.getCPtr(asset)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdZipFile()
			: this(UsdPINVOKE.new_UsdZipFile(), cMemoryOwn: true)
		{
		}

		public SWIGTYPE_p_UsdZipFile__Iterator begin()
		{
			return new SWIGTYPE_p_UsdZipFile__Iterator(UsdPINVOKE.UsdZipFile_begin(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_UsdZipFile__Iterator cbegin()
		{
			return new SWIGTYPE_p_UsdZipFile__Iterator(UsdPINVOKE.UsdZipFile_cbegin(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_UsdZipFile__Iterator end()
		{
			return new SWIGTYPE_p_UsdZipFile__Iterator(UsdPINVOKE.UsdZipFile_end(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_UsdZipFile__Iterator cend()
		{
			return new SWIGTYPE_p_UsdZipFile__Iterator(UsdPINVOKE.UsdZipFile_cend(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_UsdZipFile__Iterator Find(string path)
		{
			SWIGTYPE_p_UsdZipFile__Iterator result = new SWIGTYPE_p_UsdZipFile__Iterator(UsdPINVOKE.UsdZipFile_Find(swigCPtr, path), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void DumpContents()
		{
			UsdPINVOKE.UsdZipFile_DumpContents(swigCPtr);
		}

		public StdStringVector GetFileNames()
		{
			return new StdStringVector(UsdPINVOKE.UsdZipFile_GetFileNames(swigCPtr), cMemoryOwn: true);
		}

		public IntPtr GetFile(string filePath, out int size)
		{
			IntPtr result = UsdPINVOKE.UsdZipFile_GetFile(swigCPtr, filePath, out size);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public FileInfo GetFileInfo(string filePath)
		{
			FileInfo result = new FileInfo(UsdPINVOKE.UsdZipFile_GetFileInfo(swigCPtr, filePath), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
