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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']"
	[global::Android.Runtime.Register ("com/vanstone/trans/api/PiccExApi", DoNotGenerateAcw=true)]
	public partial class PiccExApi : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/trans/api/PiccExApi", typeof (PiccExApi));

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

		protected PiccExApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/constructor[@name='PiccExApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PiccExApi () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='PiccCheckEx_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("PiccCheckEx_Api", "(I[B[B)I", "")]
		public static unsafe int PiccCheckEx_Api (int mode, byte[]? CardType, byte[]? SerialNo)
		{
			const string __id = "PiccCheckEx_Api.(I[B[B)I";
			IntPtr native_CardType = JNIEnv.NewArray (CardType);
			IntPtr native_SerialNo = JNIEnv.NewArray (SerialNo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (mode);
				__args [1] = new JniArgumentValue (native_CardType);
				__args [2] = new JniArgumentValue (native_SerialNo);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (CardType != null) {
					JNIEnv.CopyArray (native_CardType, CardType);
					JNIEnv.DeleteLocalRef (native_CardType);
				}
				if (SerialNo != null) {
					JNIEnv.CopyArray (native_SerialNo, SerialNo);
					JNIEnv.DeleteLocalRef (native_SerialNo);
				}
				global::System.GC.KeepAlive (CardType);
				global::System.GC.KeepAlive (SerialNo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='PiccCloseEx_Api' and count(parameter)=0]"
		[Register ("PiccCloseEx_Api", "()I", "")]
		public static unsafe int PiccCloseEx_Api ()
		{
			const string __id = "PiccCloseEx_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='PiccIsoCommandEx_Api' and count(parameter)=2 and parameter[1][@type='com.vanstone.trans.api.struct.ApduSend'] and parameter[2][@type='com.vanstone.trans.api.struct.ApduResp']]"
		[Register ("PiccIsoCommandEx_Api", "(Lcom/vanstone/trans/api/struct/ApduSend;Lcom/vanstone/trans/api/struct/ApduResp;)V", "")]
		public static unsafe void PiccIsoCommandEx_Api (global::Com.Vanstone.Trans.Api.Struct.ApduSend? apduSend, global::Com.Vanstone.Trans.Api.Struct.ApduResp? apduResp)
		{
			const string __id = "PiccIsoCommandEx_Api.(Lcom/vanstone/trans/api/struct/ApduSend;Lcom/vanstone/trans/api/struct/ApduResp;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((apduSend == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apduSend).Handle);
				__args [1] = new JniArgumentValue ((apduResp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apduResp).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (apduSend);
				global::System.GC.KeepAlive (apduResp);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='PiccOpenEx_Api' and count(parameter)=0]"
		[Register ("PiccOpenEx_Api", "()I", "")]
		public static unsafe int PiccOpenEx_Api ()
		{
			const string __id = "PiccOpenEx_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='PiccQPBOCBalanceEx_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("PiccQPBOCBalanceEx_Api", "([B)I", "")]
		public static unsafe int PiccQPBOCBalanceEx_Api (byte[]? pnBalance)
		{
			const string __id = "PiccQPBOCBalanceEx_Api.([B)I";
			IntPtr native_pnBalance = JNIEnv.NewArray (pnBalance);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pnBalance);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (pnBalance != null) {
					JNIEnv.CopyArray (native_pnBalance, pnBalance);
					JNIEnv.DeleteLocalRef (native_pnBalance);
				}
				global::System.GC.KeepAlive (pnBalance);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='PiccQPBOCDetailEx_Api' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("PiccQPBOCDetailEx_Api", "([B)I", "")]
		public static unsafe int PiccQPBOCDetailEx_Api (byte[]? pBackData)
		{
			const string __id = "PiccQPBOCDetailEx_Api.([B)I";
			IntPtr native_pBackData = JNIEnv.NewArray (pBackData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pBackData);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (pBackData != null) {
					JNIEnv.CopyArray (native_pBackData, pBackData);
					JNIEnv.DeleteLocalRef (native_pBackData);
				}
				global::System.GC.KeepAlive (pBackData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='PiccQPBOCSaleEx_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("PiccQPBOCSaleEx_Api", "(I[B)I", "")]
		public static unsafe int PiccQPBOCSaleEx_Api (int nSaleAmt, byte[]? pBackData)
		{
			const string __id = "PiccQPBOCSaleEx_Api.(I[B)I";
			IntPtr native_pBackData = JNIEnv.NewArray (pBackData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nSaleAmt);
				__args [1] = new JniArgumentValue (native_pBackData);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (pBackData != null) {
					JNIEnv.CopyArray (native_pBackData, pBackData);
					JNIEnv.DeleteLocalRef (native_pBackData);
				}
				global::System.GC.KeepAlive (pBackData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='PiccRemoveEx_Api' and count(parameter)=0]"
		[Register ("PiccRemoveEx_Api", "()I", "")]
		public static unsafe int PiccRemoveEx_Api ()
		{
			const string __id = "PiccRemoveEx_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='PiccExApi']/method[@name='SidCardCommandEx_Api' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("SidCardCommandEx_Api", "([BI[B)I", "")]
		public static unsafe int SidCardCommandEx_Api (byte[]? apduSend, int sendLen, byte[]? apduRecv)
		{
			const string __id = "SidCardCommandEx_Api.([BI[B)I";
			IntPtr native_apduSend = JNIEnv.NewArray (apduSend);
			IntPtr native_apduRecv = JNIEnv.NewArray (apduRecv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_apduSend);
				__args [1] = new JniArgumentValue (sendLen);
				__args [2] = new JniArgumentValue (native_apduRecv);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (apduSend != null) {
					JNIEnv.CopyArray (native_apduSend, apduSend);
					JNIEnv.DeleteLocalRef (native_apduSend);
				}
				if (apduRecv != null) {
					JNIEnv.CopyArray (native_apduRecv, apduRecv);
					JNIEnv.DeleteLocalRef (native_apduRecv);
				}
				global::System.GC.KeepAlive (apduSend);
				global::System.GC.KeepAlive (apduRecv);
			}
		}

	}
}