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

namespace Com.Vanstone.Trans.Api.Struct {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']"
	[global::Android.Runtime.Register ("com/vanstone/trans/api/struct/CdmaSet", DoNotGenerateAcw=true)]
	public partial class CdmaSet : global::Java.Lang.Object, global::Com.Vanstone.Base.Interfaces.IStructInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/trans/api/struct/CdmaSet", typeof (CdmaSet));

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

		protected CdmaSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/constructor[@name='CdmaSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CdmaSet () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getCdmaNeedUser;
#pragma warning disable 0169
		static Delegate GetGetCdmaNeedUserHandler ()
		{
			if (cb_getCdmaNeedUser == null)
				cb_getCdmaNeedUser = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_B (n_GetCdmaNeedUser));
			return cb_getCdmaNeedUser;
		}

		static sbyte n_GetCdmaNeedUser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CdmaNeedUser;
		}
#pragma warning restore 0169

		static Delegate? cb_setCdmaNeedUser_B;
#pragma warning disable 0169
		static Delegate GetSetCdmaNeedUser_BHandler ()
		{
			if (cb_setCdmaNeedUser_B == null)
				cb_setCdmaNeedUser_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_V (n_SetCdmaNeedUser_B));
			return cb_setCdmaNeedUser_B;
		}

		static void n_SetCdmaNeedUser_B (IntPtr jnienv, IntPtr native__this, sbyte cdmaNeedUser)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.CdmaNeedUser = cdmaNeedUser;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte CdmaNeedUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='getCdmaNeedUser' and count(parameter)=0]"
			[Register ("getCdmaNeedUser", "()B", "GetGetCdmaNeedUserHandler")]
			get {
				const string __id = "getCdmaNeedUser.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='setCdmaNeedUser' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setCdmaNeedUser", "(B)V", "GetSetCdmaNeedUser_BHandler")]
			set {
				const string __id = "setCdmaNeedUser.(B)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getSunny;
#pragma warning disable 0169
		static Delegate GetGetSunnyHandler ()
		{
			if (cb_getSunny == null)
				cb_getSunny = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_B (n_GetSunny));
			return cb_getSunny;
		}

		static sbyte n_GetSunny (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Sunny;
		}
#pragma warning restore 0169

		static Delegate? cb_setSunny_B;
#pragma warning disable 0169
		static Delegate GetSetSunny_BHandler ()
		{
			if (cb_setSunny_B == null)
				cb_setSunny_B = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPB_V (n_SetSunny_B));
			return cb_setSunny_B;
		}

		static void n_SetSunny_B (IntPtr jnienv, IntPtr native__this, sbyte sunny)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Sunny = sunny;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte Sunny {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='getSunny' and count(parameter)=0]"
			[Register ("getSunny", "()B", "GetGetSunnyHandler")]
			get {
				const string __id = "getSunny.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='setSunny' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setSunny", "(B)V", "GetSetSunny_BHandler")]
			set {
				const string __id = "setSunny.(B)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getCdmaIp1;
#pragma warning disable 0169
		static Delegate GetGetCdmaIp1Handler ()
		{
			if (cb_getCdmaIp1 == null)
				cb_getCdmaIp1 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCdmaIp1));
			return cb_getCdmaIp1;
		}

		static IntPtr n_GetCdmaIp1 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetCdmaIp1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='getCdmaIp1' and count(parameter)=0]"
		[Register ("getCdmaIp1", "()[B", "GetGetCdmaIp1Handler")]
		public virtual unsafe byte[]? GetCdmaIp1 ()
		{
			const string __id = "getCdmaIp1.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getCdmaIp2;
#pragma warning disable 0169
		static Delegate GetGetCdmaIp2Handler ()
		{
			if (cb_getCdmaIp2 == null)
				cb_getCdmaIp2 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCdmaIp2));
			return cb_getCdmaIp2;
		}

		static IntPtr n_GetCdmaIp2 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetCdmaIp2 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='getCdmaIp2' and count(parameter)=0]"
		[Register ("getCdmaIp2", "()[B", "GetGetCdmaIp2Handler")]
		public virtual unsafe byte[]? GetCdmaIp2 ()
		{
			const string __id = "getCdmaIp2.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getCdmaPort1;
#pragma warning disable 0169
		static Delegate GetGetCdmaPort1Handler ()
		{
			if (cb_getCdmaPort1 == null)
				cb_getCdmaPort1 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCdmaPort1));
			return cb_getCdmaPort1;
		}

		static IntPtr n_GetCdmaPort1 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetCdmaPort1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='getCdmaPort1' and count(parameter)=0]"
		[Register ("getCdmaPort1", "()[B", "GetGetCdmaPort1Handler")]
		public virtual unsafe byte[]? GetCdmaPort1 ()
		{
			const string __id = "getCdmaPort1.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getCdmaPort2;
#pragma warning disable 0169
		static Delegate GetGetCdmaPort2Handler ()
		{
			if (cb_getCdmaPort2 == null)
				cb_getCdmaPort2 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCdmaPort2));
			return cb_getCdmaPort2;
		}

		static IntPtr n_GetCdmaPort2 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetCdmaPort2 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='getCdmaPort2' and count(parameter)=0]"
		[Register ("getCdmaPort2", "()[B", "GetGetCdmaPort2Handler")]
		public virtual unsafe byte[]? GetCdmaPort2 ()
		{
			const string __id = "getCdmaPort2.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getCdmaUser1;
#pragma warning disable 0169
		static Delegate GetGetCdmaUser1Handler ()
		{
			if (cb_getCdmaUser1 == null)
				cb_getCdmaUser1 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCdmaUser1));
			return cb_getCdmaUser1;
		}

		static IntPtr n_GetCdmaUser1 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetCdmaUser1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='getCdmaUser1' and count(parameter)=0]"
		[Register ("getCdmaUser1", "()[B", "GetGetCdmaUser1Handler")]
		public virtual unsafe byte[]? GetCdmaUser1 ()
		{
			const string __id = "getCdmaUser1.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getCdmaUserPwd1;
#pragma warning disable 0169
		static Delegate GetGetCdmaUserPwd1Handler ()
		{
			if (cb_getCdmaUserPwd1 == null)
				cb_getCdmaUserPwd1 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCdmaUserPwd1));
			return cb_getCdmaUserPwd1;
		}

		static IntPtr n_GetCdmaUserPwd1 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetCdmaUserPwd1 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='getCdmaUserPwd1' and count(parameter)=0]"
		[Register ("getCdmaUserPwd1", "()[B", "GetGetCdmaUserPwd1Handler")]
		public virtual unsafe byte[]? GetCdmaUserPwd1 ()
		{
			const string __id = "getCdmaUserPwd1.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_setCdmaIp1_arrayB;
#pragma warning disable 0169
		static Delegate GetSetCdmaIp1_arrayBHandler ()
		{
			if (cb_setCdmaIp1_arrayB == null)
				cb_setCdmaIp1_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCdmaIp1_arrayB));
			return cb_setCdmaIp1_arrayB;
		}

		static void n_SetCdmaIp1_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cdmaIp1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var cdmaIp1 = (byte[]?) JNIEnv.GetArray (native_cdmaIp1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetCdmaIp1 (cdmaIp1);
			if (cdmaIp1 != null)
				JNIEnv.CopyArray (cdmaIp1, native_cdmaIp1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='setCdmaIp1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setCdmaIp1", "([B)V", "GetSetCdmaIp1_arrayBHandler")]
		public virtual unsafe void SetCdmaIp1 (byte[]? cdmaIp1)
		{
			const string __id = "setCdmaIp1.([B)V";
			IntPtr native_cdmaIp1 = JNIEnv.NewArray (cdmaIp1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cdmaIp1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (cdmaIp1 != null) {
					JNIEnv.CopyArray (native_cdmaIp1, cdmaIp1);
					JNIEnv.DeleteLocalRef (native_cdmaIp1);
				}
				global::System.GC.KeepAlive (cdmaIp1);
			}
		}

		static Delegate? cb_setCdmaIp2_arrayB;
#pragma warning disable 0169
		static Delegate GetSetCdmaIp2_arrayBHandler ()
		{
			if (cb_setCdmaIp2_arrayB == null)
				cb_setCdmaIp2_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCdmaIp2_arrayB));
			return cb_setCdmaIp2_arrayB;
		}

		static void n_SetCdmaIp2_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cdmaIp2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var cdmaIp2 = (byte[]?) JNIEnv.GetArray (native_cdmaIp2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetCdmaIp2 (cdmaIp2);
			if (cdmaIp2 != null)
				JNIEnv.CopyArray (cdmaIp2, native_cdmaIp2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='setCdmaIp2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setCdmaIp2", "([B)V", "GetSetCdmaIp2_arrayBHandler")]
		public virtual unsafe void SetCdmaIp2 (byte[]? cdmaIp2)
		{
			const string __id = "setCdmaIp2.([B)V";
			IntPtr native_cdmaIp2 = JNIEnv.NewArray (cdmaIp2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cdmaIp2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (cdmaIp2 != null) {
					JNIEnv.CopyArray (native_cdmaIp2, cdmaIp2);
					JNIEnv.DeleteLocalRef (native_cdmaIp2);
				}
				global::System.GC.KeepAlive (cdmaIp2);
			}
		}

		static Delegate? cb_setCdmaPort1_arrayB;
#pragma warning disable 0169
		static Delegate GetSetCdmaPort1_arrayBHandler ()
		{
			if (cb_setCdmaPort1_arrayB == null)
				cb_setCdmaPort1_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCdmaPort1_arrayB));
			return cb_setCdmaPort1_arrayB;
		}

		static void n_SetCdmaPort1_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cdmaPort1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var cdmaPort1 = (byte[]?) JNIEnv.GetArray (native_cdmaPort1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetCdmaPort1 (cdmaPort1);
			if (cdmaPort1 != null)
				JNIEnv.CopyArray (cdmaPort1, native_cdmaPort1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='setCdmaPort1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setCdmaPort1", "([B)V", "GetSetCdmaPort1_arrayBHandler")]
		public virtual unsafe void SetCdmaPort1 (byte[]? cdmaPort1)
		{
			const string __id = "setCdmaPort1.([B)V";
			IntPtr native_cdmaPort1 = JNIEnv.NewArray (cdmaPort1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cdmaPort1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (cdmaPort1 != null) {
					JNIEnv.CopyArray (native_cdmaPort1, cdmaPort1);
					JNIEnv.DeleteLocalRef (native_cdmaPort1);
				}
				global::System.GC.KeepAlive (cdmaPort1);
			}
		}

		static Delegate? cb_setCdmaPort2_arrayB;
#pragma warning disable 0169
		static Delegate GetSetCdmaPort2_arrayBHandler ()
		{
			if (cb_setCdmaPort2_arrayB == null)
				cb_setCdmaPort2_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCdmaPort2_arrayB));
			return cb_setCdmaPort2_arrayB;
		}

		static void n_SetCdmaPort2_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cdmaPort2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var cdmaPort2 = (byte[]?) JNIEnv.GetArray (native_cdmaPort2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetCdmaPort2 (cdmaPort2);
			if (cdmaPort2 != null)
				JNIEnv.CopyArray (cdmaPort2, native_cdmaPort2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='setCdmaPort2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setCdmaPort2", "([B)V", "GetSetCdmaPort2_arrayBHandler")]
		public virtual unsafe void SetCdmaPort2 (byte[]? cdmaPort2)
		{
			const string __id = "setCdmaPort2.([B)V";
			IntPtr native_cdmaPort2 = JNIEnv.NewArray (cdmaPort2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cdmaPort2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (cdmaPort2 != null) {
					JNIEnv.CopyArray (native_cdmaPort2, cdmaPort2);
					JNIEnv.DeleteLocalRef (native_cdmaPort2);
				}
				global::System.GC.KeepAlive (cdmaPort2);
			}
		}

		static Delegate? cb_setCdmaUser1_arrayB;
#pragma warning disable 0169
		static Delegate GetSetCdmaUser1_arrayBHandler ()
		{
			if (cb_setCdmaUser1_arrayB == null)
				cb_setCdmaUser1_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCdmaUser1_arrayB));
			return cb_setCdmaUser1_arrayB;
		}

		static void n_SetCdmaUser1_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cdmaUser1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var cdmaUser1 = (byte[]?) JNIEnv.GetArray (native_cdmaUser1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetCdmaUser1 (cdmaUser1);
			if (cdmaUser1 != null)
				JNIEnv.CopyArray (cdmaUser1, native_cdmaUser1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='setCdmaUser1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setCdmaUser1", "([B)V", "GetSetCdmaUser1_arrayBHandler")]
		public virtual unsafe void SetCdmaUser1 (byte[]? cdmaUser1)
		{
			const string __id = "setCdmaUser1.([B)V";
			IntPtr native_cdmaUser1 = JNIEnv.NewArray (cdmaUser1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cdmaUser1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (cdmaUser1 != null) {
					JNIEnv.CopyArray (native_cdmaUser1, cdmaUser1);
					JNIEnv.DeleteLocalRef (native_cdmaUser1);
				}
				global::System.GC.KeepAlive (cdmaUser1);
			}
		}

		static Delegate? cb_setCdmaUserPwd1_arrayB;
#pragma warning disable 0169
		static Delegate GetSetCdmaUserPwd1_arrayBHandler ()
		{
			if (cb_setCdmaUserPwd1_arrayB == null)
				cb_setCdmaUserPwd1_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCdmaUserPwd1_arrayB));
			return cb_setCdmaUserPwd1_arrayB;
		}

		static void n_SetCdmaUserPwd1_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cdmaUserPwd1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var cdmaUserPwd1 = (byte[]?) JNIEnv.GetArray (native_cdmaUserPwd1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetCdmaUserPwd1 (cdmaUserPwd1);
			if (cdmaUserPwd1 != null)
				JNIEnv.CopyArray (cdmaUserPwd1, native_cdmaUserPwd1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='setCdmaUserPwd1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setCdmaUserPwd1", "([B)V", "GetSetCdmaUserPwd1_arrayBHandler")]
		public virtual unsafe void SetCdmaUserPwd1 (byte[]? cdmaUserPwd1)
		{
			const string __id = "setCdmaUserPwd1.([B)V";
			IntPtr native_cdmaUserPwd1 = JNIEnv.NewArray (cdmaUserPwd1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cdmaUserPwd1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (cdmaUserPwd1 != null) {
					JNIEnv.CopyArray (native_cdmaUserPwd1, cdmaUserPwd1);
					JNIEnv.DeleteLocalRef (native_cdmaUserPwd1);
				}
				global::System.GC.KeepAlive (cdmaUserPwd1);
			}
		}

		static Delegate? cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Size));
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_toBean_arrayB;
#pragma warning disable 0169
		static Delegate GetToBean_arrayBHandler ()
		{
			if (cb_toBean_arrayB == null)
				cb_toBean_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_ToBean_arrayB));
			return cb_toBean_arrayB;
		}

		static void n_ToBean_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ToBean (buf);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='toBean' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toBean", "([B)V", "GetToBean_arrayBHandler")]
		public virtual unsafe void ToBean (byte[]? buf)
		{
			const string __id = "toBean.([B)V";
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_buf);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
				global::System.GC.KeepAlive (buf);
			}
		}

		static Delegate? cb_toBytes;
#pragma warning disable 0169
		static Delegate GetToBytesHandler ()
		{
			if (cb_toBytes == null)
				cb_toBytes = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ToBytes));
			return cb_toBytes;
		}

		static IntPtr n_ToBytes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.CdmaSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.ToBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='CdmaSet']/method[@name='toBytes' and count(parameter)=0]"
		[Register ("toBytes", "()[B", "GetToBytesHandler")]
		public virtual unsafe byte[]? ToBytes ()
		{
			const string __id = "toBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}