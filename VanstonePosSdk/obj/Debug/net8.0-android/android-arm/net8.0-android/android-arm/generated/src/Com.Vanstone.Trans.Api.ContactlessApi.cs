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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']"
	[global::Android.Runtime.Register ("com/vanstone/trans/api/ContactlessApi", DoNotGenerateAcw=true)]
	public partial class ContactlessApi : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/trans/api/ContactlessApi", typeof (ContactlessApi));

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

		protected ContactlessApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/constructor[@name='ContactlessApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContactlessApi () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='M1Decrement_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("M1Decrement_Api", "(II)I", "")]
		public static unsafe int M1Decrement_Api (int blockNum, int value)
		{
			const string __id = "M1Decrement_Api.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (blockNum);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='M1Increment_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("M1Increment_Api", "(II)I", "")]
		public static unsafe int M1Increment_Api (int blockNum, int value)
		{
			const string __id = "M1Increment_Api.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (blockNum);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='M1Restore_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("M1Restore_Api", "(I)I", "")]
		public static unsafe int M1Restore_Api (int blockNum)
		{
			const string __id = "M1Restore_Api.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (blockNum);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='M1Transfer_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("M1Transfer_Api", "(I)I", "")]
		public static unsafe int M1Transfer_Api (int blockNum)
		{
			const string __id = "M1Transfer_Api.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (blockNum);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='cardAAnticollision_Api' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int[]']]"
		[Register ("cardAAnticollision_Api", "([B[I)I", "")]
		public static unsafe int CardAAnticollision_Api (byte[]? uid, int[]? sak)
		{
			const string __id = "cardAAnticollision_Api.([B[I)I";
			IntPtr native_uid = JNIEnv.NewArray (uid);
			IntPtr native_sak = JNIEnv.NewArray (sak);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_uid);
				__args [1] = new JniArgumentValue (native_sak);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (uid != null) {
					JNIEnv.CopyArray (native_uid, uid);
					JNIEnv.DeleteLocalRef (native_uid);
				}
				if (sak != null) {
					JNIEnv.CopyArray (native_sak, sak);
					JNIEnv.DeleteLocalRef (native_sak);
				}
				global::System.GC.KeepAlive (uid);
				global::System.GC.KeepAlive (sak);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='cardADeselect_Api' and count(parameter)=0]"
		[Register ("cardADeselect_Api", "()I", "")]
		public static unsafe int CardADeselect_Api ()
		{
			const string __id = "cardADeselect_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='cardAPause_Api' and count(parameter)=0]"
		[Register ("cardAPause_Api", "()I", "")]
		public static unsafe int CardAPause_Api ()
		{
			const string __id = "cardAPause_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='cardARats_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("cardARats_Api", "(I[B)I", "")]
		public static unsafe int CardARats_Api (int mode, byte[]? ats)
		{
			const string __id = "cardARats_Api.(I[B)I";
			IntPtr native_ats = JNIEnv.NewArray (ats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (mode);
				__args [1] = new JniArgumentValue (native_ats);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (ats != null) {
					JNIEnv.CopyArray (native_ats, ats);
					JNIEnv.DeleteLocalRef (native_ats);
				}
				global::System.GC.KeepAlive (ats);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='cardAReq_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("cardAReq_Api", "([B)I", "")]
		public static unsafe int CardAReq_Api (byte[]? ATQA)
		{
			const string __id = "cardAReq_Api.([B)I";
			IntPtr native_ATQA = JNIEnv.NewArray (ATQA);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ATQA);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (ATQA != null) {
					JNIEnv.CopyArray (native_ATQA, ATQA);
					JNIEnv.DeleteLocalRef (native_ATQA);
				}
				global::System.GC.KeepAlive (ATQA);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='cardAWakeUp_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("cardAWakeUp_Api", "([B)I", "")]
		public static unsafe int CardAWakeUp_Api (byte[]? ATQA)
		{
			const string __id = "cardAWakeUp_Api.([B)I";
			IntPtr native_ATQA = JNIEnv.NewArray (ATQA);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ATQA);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (ATQA != null) {
					JNIEnv.CopyArray (native_ATQA, ATQA);
					JNIEnv.DeleteLocalRef (native_ATQA);
				}
				global::System.GC.KeepAlive (ATQA);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='closeField_Api' and count(parameter)=0]"
		[Register ("closeField_Api", "()I", "")]
		public static unsafe int CloseField_Api ()
		{
			const string __id = "closeField_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='openField_Api' and count(parameter)=0]"
		[Register ("openField_Api", "()I", "")]
		public static unsafe int OpenField_Api ()
		{
			const string __id = "openField_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='readSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("readSecurityMem_Api", "(I[BI)I", "")]
		public static unsafe int ReadSecurityMem_Api (int offset, byte[]? dataOut, int dataLen)
		{
			const string __id = "readSecurityMem_Api.(I[BI)I";
			IntPtr native_dataOut = JNIEnv.NewArray (dataOut);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (native_dataOut);
				__args [2] = new JniArgumentValue (dataLen);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (dataOut != null) {
					JNIEnv.CopyArray (native_dataOut, dataOut);
					JNIEnv.DeleteLocalRef (native_dataOut);
				}
				global::System.GC.KeepAlive (dataOut);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='ContactlessApi']/method[@name='writeSecurityMem_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("writeSecurityMem_Api", "(I[BI)I", "")]
		public static unsafe int WriteSecurityMem_Api (int offset, byte[]? data, int dataLen)
		{
			const string __id = "writeSecurityMem_Api.(I[BI)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue (dataLen);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}