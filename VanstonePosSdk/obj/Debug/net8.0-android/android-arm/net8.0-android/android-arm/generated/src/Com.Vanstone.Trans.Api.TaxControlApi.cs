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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='TaxControlApi']"
	[global::Android.Runtime.Register ("com/vanstone/trans/api/TaxControlApi", DoNotGenerateAcw=true)]
	public partial class TaxControlApi : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/trans/api/TaxControlApi", typeof (TaxControlApi));

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

		protected TaxControlApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='TaxControlApi']/constructor[@name='TaxControlApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TaxControlApi () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='TaxControlApi']/method[@name='TaxControlClosedev_Api' and count(parameter)=0]"
		[Register ("TaxControlClosedev_Api", "()I", "")]
		public static unsafe int TaxControlClosedev_Api ()
		{
			const string __id = "TaxControlClosedev_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='TaxControlApi']/method[@name='TaxControlOpendev_Api' and count(parameter)=0]"
		[Register ("TaxControlOpendev_Api", "()I", "")]
		public static unsafe int TaxControlOpendev_Api ()
		{
			const string __id = "TaxControlOpendev_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='TaxControlApi']/method[@name='TaxControlSenddevWithTimeOut_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("TaxControlSenddevWithTimeOut_Api", "([B[BI)I", "")]
		public static unsafe int TaxControlSenddevWithTimeOut_Api (byte[]? sebuffer, byte[]? rebuffer, int timeout)
		{
			const string __id = "TaxControlSenddevWithTimeOut_Api.([B[BI)I";
			IntPtr native_sebuffer = JNIEnv.NewArray (sebuffer);
			IntPtr native_rebuffer = JNIEnv.NewArray (rebuffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sebuffer);
				__args [1] = new JniArgumentValue (native_rebuffer);
				__args [2] = new JniArgumentValue (timeout);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (sebuffer != null) {
					JNIEnv.CopyArray (native_sebuffer, sebuffer);
					JNIEnv.DeleteLocalRef (native_sebuffer);
				}
				if (rebuffer != null) {
					JNIEnv.CopyArray (native_rebuffer, rebuffer);
					JNIEnv.DeleteLocalRef (native_rebuffer);
				}
				global::System.GC.KeepAlive (sebuffer);
				global::System.GC.KeepAlive (rebuffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='TaxControlApi']/method[@name='TaxControlSenddev_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("TaxControlSenddev_Api", "([B[B)I", "")]
		public static unsafe int TaxControlSenddev_Api (byte[]? sebuffer, byte[]? rebuffer)
		{
			const string __id = "TaxControlSenddev_Api.([B[B)I";
			IntPtr native_sebuffer = JNIEnv.NewArray (sebuffer);
			IntPtr native_rebuffer = JNIEnv.NewArray (rebuffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sebuffer);
				__args [1] = new JniArgumentValue (native_rebuffer);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (sebuffer != null) {
					JNIEnv.CopyArray (native_sebuffer, sebuffer);
					JNIEnv.DeleteLocalRef (native_sebuffer);
				}
				if (rebuffer != null) {
					JNIEnv.CopyArray (native_rebuffer, rebuffer);
					JNIEnv.DeleteLocalRef (native_rebuffer);
				}
				global::System.GC.KeepAlive (sebuffer);
				global::System.GC.KeepAlive (rebuffer);
			}
		}

	}
}