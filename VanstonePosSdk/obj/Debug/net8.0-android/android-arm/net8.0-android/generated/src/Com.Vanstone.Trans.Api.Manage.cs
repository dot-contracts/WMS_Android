//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vanstone.Trans.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='Manage']"
	[global::Android.Runtime.Register ("com/vanstone/trans/api/Manage", DoNotGenerateAcw=true)]
	public partial class Manage : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/trans/api/Manage", typeof (Manage));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Manage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='Manage']/constructor[@name='Manage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Manage () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='Manage']/method[@name='GetBeforAppName_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("GetBeforAppName_Api", "([B)I", "")]
		public static unsafe int GetBeforAppName_Api (byte[]? OutAppName)
		{
			const string __id = "GetBeforAppName_Api.([B)I";
			IntPtr native_OutAppName = JNIEnv.NewArray (OutAppName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_OutAppName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (OutAppName != null) {
					JNIEnv.CopyArray (native_OutAppName, OutAppName);
					JNIEnv.DeleteLocalRef (native_OutAppName);
				}
				global::System.GC.KeepAlive (OutAppName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='Manage']/method[@name='GetMulAppInfo_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("GetMulAppInfo_Api", "([B[B)I", "")]
		public static unsafe int GetMulAppInfo_Api (byte[]? OutInfo, byte[]? OutInfoLen)
		{
			const string __id = "GetMulAppInfo_Api.([B[B)I";
			IntPtr native_OutInfo = JNIEnv.NewArray (OutInfo);
			IntPtr native_OutInfoLen = JNIEnv.NewArray (OutInfoLen);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_OutInfo);
				__args [1] = new JniArgumentValue (native_OutInfoLen);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (OutInfo != null) {
					JNIEnv.CopyArray (native_OutInfo, OutInfo);
					JNIEnv.DeleteLocalRef (native_OutInfo);
				}
				if (OutInfoLen != null) {
					JNIEnv.CopyArray (native_OutInfoLen, OutInfoLen);
					JNIEnv.DeleteLocalRef (native_OutInfoLen);
				}
				global::System.GC.KeepAlive (OutInfo);
				global::System.GC.KeepAlive (OutInfoLen);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='Manage']/method[@name='GetNextAppNamelib' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("GetNextAppNamelib", "([B)I", "")]
		public static unsafe int GetNextAppNamelib (byte[]? OutAppName)
		{
			const string __id = "GetNextAppNamelib.([B)I";
			IntPtr native_OutAppName = JNIEnv.NewArray (OutAppName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_OutAppName);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (OutAppName != null) {
					JNIEnv.CopyArray (native_OutAppName, OutAppName);
					JNIEnv.DeleteLocalRef (native_OutAppName);
				}
				global::System.GC.KeepAlive (OutAppName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='Manage']/method[@name='SwitchApp_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("SwitchApp_Api", "([B[BI)V", "")]
		public static unsafe void SwitchApp_Api (byte[]? lpNextName, byte[]? lpIn, int lpInLen)
		{
			const string __id = "SwitchApp_Api.([B[BI)V";
			IntPtr native_lpNextName = JNIEnv.NewArray (lpNextName);
			IntPtr native_lpIn = JNIEnv.NewArray (lpIn);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_lpNextName);
				__args [1] = new JniArgumentValue (native_lpIn);
				__args [2] = new JniArgumentValue (lpInLen);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (lpNextName != null) {
					JNIEnv.CopyArray (native_lpNextName, lpNextName);
					JNIEnv.DeleteLocalRef (native_lpNextName);
				}
				if (lpIn != null) {
					JNIEnv.CopyArray (native_lpIn, lpIn);
					JNIEnv.DeleteLocalRef (native_lpIn);
				}
				global::System.GC.KeepAlive (lpNextName);
				global::System.GC.KeepAlive (lpIn);
			}
		}

	}
}