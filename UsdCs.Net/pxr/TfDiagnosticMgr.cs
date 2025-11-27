using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfDiagnosticMgr : IDisposable
	{
		public class Delegate : IDisposable
		{
			public delegate void SwigDelegateDelegate_0(IntPtr err);

			public delegate void SwigDelegateDelegate_1(IntPtr context, string msg);

			public delegate void SwigDelegateDelegate_2(IntPtr status);

			public delegate void SwigDelegateDelegate_3(IntPtr warning);

			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			private SwigDelegateDelegate_0 swigDelegate0;

			private SwigDelegateDelegate_1 swigDelegate1;

			private SwigDelegateDelegate_2 swigDelegate2;

			private SwigDelegateDelegate_3 swigDelegate3;

			private static Type[] swigMethodTypes0 = new Type[1] { typeof(TfError) };

			private static Type[] swigMethodTypes1 = new Type[2]
			{
				typeof(TfCallContext),
				typeof(string)
			};

			private static Type[] swigMethodTypes2 = new Type[1] { typeof(TfStatus) };

			private static Type[] swigMethodTypes3 = new Type[1] { typeof(TfWarning) };

			public Delegate(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(Delegate obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(Delegate obj)
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

			~Delegate()
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
							TfPINVOKE.delete_TfDiagnosticMgr_Delegate(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public virtual void IssueError(TfError err)
			{
				TfPINVOKE.TfDiagnosticMgr_Delegate_IssueError(swigCPtr, TfError.getCPtr(err));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public virtual void IssueFatalError(TfCallContext context, string msg)
			{
				TfPINVOKE.TfDiagnosticMgr_Delegate_IssueFatalError(swigCPtr, TfCallContext.getCPtr(context), msg);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public virtual void IssueStatus(TfStatus status)
			{
				TfPINVOKE.TfDiagnosticMgr_Delegate_IssueStatus(swigCPtr, TfStatus.getCPtr(status));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public virtual void IssueWarning(TfWarning warning)
			{
				TfPINVOKE.TfDiagnosticMgr_Delegate_IssueWarning(swigCPtr, TfWarning.getCPtr(warning));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public Delegate()
				: this(TfPINVOKE.new_TfDiagnosticMgr_Delegate(), cMemoryOwn: true)
			{
				SwigDirectorConnect();
			}

			private void SwigDirectorConnect()
			{
				if (SwigDerivedClassHasMethod("IssueError", swigMethodTypes0))
				{
					swigDelegate0 = SwigDirectorMethodIssueError;
				}
				if (SwigDerivedClassHasMethod("IssueFatalError", swigMethodTypes1))
				{
					swigDelegate1 = SwigDirectorMethodIssueFatalError;
				}
				if (SwigDerivedClassHasMethod("IssueStatus", swigMethodTypes2))
				{
					swigDelegate2 = SwigDirectorMethodIssueStatus;
				}
				if (SwigDerivedClassHasMethod("IssueWarning", swigMethodTypes3))
				{
					swigDelegate3 = SwigDirectorMethodIssueWarning;
				}
				TfPINVOKE.TfDiagnosticMgr_Delegate_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
			}

			private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
			{
				MethodInfo[] methods = GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				MethodInfo[] array = methods;
				foreach (MethodInfo methodInfo in array)
				{
					if (methodInfo.DeclaringType == null || methodInfo.Name != methodName)
					{
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length != methodTypes.Length)
					{
						continue;
					}
					bool flag = true;
					for (int j = 0; j < parameters.Length; j++)
					{
						if (parameters[j].ParameterType != methodTypes[j])
						{
							flag = false;
							break;
						}
					}
					if (flag && methodInfo.IsVirtual && methodInfo.DeclaringType.IsSubclassOf(typeof(Delegate)) && methodInfo.DeclaringType != methodInfo.GetBaseDefinition().DeclaringType)
					{
						return true;
					}
				}
				return false;
			}

			private void SwigDirectorMethodIssueError(IntPtr err)
			{
				try
				{
					IssueError(new TfError(err, cMemoryOwn: false));
				}
				catch (Exception ex)
				{
					if (UsdCsPINVOKE.SWIGPendingException.Pending)
					{
						UsdCsPINVOKE.SWIGPendingException.Set(new AggregateException(ex, UsdCsPINVOKE.SWIGPendingException.Retrieve()));
					}
					else
					{
						UsdCsPINVOKE.SWIGPendingException.Set(ex);
					}
				}
			}

			private void SwigDirectorMethodIssueFatalError(IntPtr context, string msg)
			{
				try
				{
					IssueFatalError(new TfCallContext(context, cMemoryOwn: false), msg);
				}
				catch (Exception ex)
				{
					if (UsdCsPINVOKE.SWIGPendingException.Pending)
					{
						UsdCsPINVOKE.SWIGPendingException.Set(new AggregateException(ex, UsdCsPINVOKE.SWIGPendingException.Retrieve()));
					}
					else
					{
						UsdCsPINVOKE.SWIGPendingException.Set(ex);
					}
				}
			}

			private void SwigDirectorMethodIssueStatus(IntPtr status)
			{
				try
				{
					IssueStatus(new TfStatus(status, cMemoryOwn: false));
				}
				catch (Exception ex)
				{
					if (UsdCsPINVOKE.SWIGPendingException.Pending)
					{
						UsdCsPINVOKE.SWIGPendingException.Set(new AggregateException(ex, UsdCsPINVOKE.SWIGPendingException.Retrieve()));
					}
					else
					{
						UsdCsPINVOKE.SWIGPendingException.Set(ex);
					}
				}
			}

			private void SwigDirectorMethodIssueWarning(IntPtr warning)
			{
				try
				{
					IssueWarning(new TfWarning(warning, cMemoryOwn: false));
				}
				catch (Exception ex)
				{
					if (UsdCsPINVOKE.SWIGPendingException.Pending)
					{
						UsdCsPINVOKE.SWIGPendingException.Set(new AggregateException(ex, UsdCsPINVOKE.SWIGPendingException.Retrieve()));
					}
					else
					{
						UsdCsPINVOKE.SWIGPendingException.Set(ex);
					}
				}
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfDiagnosticMgr(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfDiagnosticMgr obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfDiagnosticMgr obj)
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

		~TfDiagnosticMgr()
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
						throw new MethodAccessException("C++ destructor does not have public access");
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static string GetCodeName(TfEnum code)
		{
			string result = TfPINVOKE.TfDiagnosticMgr_GetCodeName(TfEnum.getCPtr(code));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfDiagnosticMgr GetInstance()
		{
			return new TfDiagnosticMgr(TfPINVOKE.TfDiagnosticMgr_GetInstance(), cMemoryOwn: false);
		}

		public void AddDelegate(Delegate delegate_)
		{
			TfPINVOKE.TfDiagnosticMgr_AddDelegate(swigCPtr, Delegate.getCPtr(delegate_));
		}

		public void RemoveDelegate(Delegate delegate_)
		{
			TfPINVOKE.TfDiagnosticMgr_RemoveDelegate(swigCPtr, Delegate.getCPtr(delegate_));
		}

		public void SetQuiet(bool quiet)
		{
			TfPINVOKE.TfDiagnosticMgr_SetQuiet(swigCPtr, quiet);
		}

		public void AppendError(TfError e)
		{
			TfPINVOKE.TfDiagnosticMgr_AppendError(swigCPtr, TfError.getCPtr(e));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void PostError(TfDiagnosticBase diagnostic)
		{
			TfPINVOKE.TfDiagnosticMgr_PostError(swigCPtr, TfDiagnosticBase.getCPtr(diagnostic));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void PostWarning(TfDiagnosticBase diagnostic)
		{
			TfPINVOKE.TfDiagnosticMgr_PostWarning(swigCPtr, TfDiagnosticBase.getCPtr(diagnostic));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void PostStatus(TfDiagnosticBase diagnostic)
		{
			TfPINVOKE.TfDiagnosticMgr_PostStatus(swigCPtr, TfDiagnosticBase.getCPtr(diagnostic));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void PostFatal(TfCallContext context, TfEnum statusCode, string msg)
		{
			TfPINVOKE.TfDiagnosticMgr_PostFatal(swigCPtr, TfCallContext.getCPtr(context), TfEnum.getCPtr(statusCode), msg);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasActiveErrorMark()
		{
			return TfPINVOKE.TfDiagnosticMgr_HasActiveErrorMark(swigCPtr);
		}
	}
}
