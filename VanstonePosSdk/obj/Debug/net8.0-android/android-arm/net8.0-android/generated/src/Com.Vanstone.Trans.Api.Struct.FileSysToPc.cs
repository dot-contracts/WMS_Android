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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']"
	[global::Android.Runtime.Register ("com/vanstone/trans/api/struct/FileSysToPc", DoNotGenerateAcw=true)]
	public partial class FileSysToPc : global::Java.Lang.Object, global::Com.Vanstone.Base.Interfaces.IStructInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/trans/api/struct/FileSysToPc", typeof (FileSysToPc));

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

		protected FileSysToPc (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/constructor[@name='FileSysToPc' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileSysToPc () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getFileListLen;
#pragma warning disable 0169
		static Delegate GetGetFileListLenHandler ()
		{
			if (cb_getFileListLen == null)
				cb_getFileListLen = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFileListLen));
			return cb_getFileListLen;
		}

		static IntPtr n_GetFileListLen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetFileListLen ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='getFileListLen' and count(parameter)=0]"
		[Register ("getFileListLen", "()[B", "GetGetFileListLenHandler")]
		public virtual unsafe byte[]? GetFileListLen ()
		{
			const string __id = "getFileListLen.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getFileSysCRC;
#pragma warning disable 0169
		static Delegate GetGetFileSysCRCHandler ()
		{
			if (cb_getFileSysCRC == null)
				cb_getFileSysCRC = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFileSysCRC));
			return cb_getFileSysCRC;
		}

		static IntPtr n_GetFileSysCRC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetFileSysCRC ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='getFileSysCRC' and count(parameter)=0]"
		[Register ("getFileSysCRC", "()[B", "GetGetFileSysCRCHandler")]
		public virtual unsafe byte[]? GetFileSysCRC ()
		{
			const string __id = "getFileSysCRC.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getFileSysData;
#pragma warning disable 0169
		static Delegate GetGetFileSysDataHandler ()
		{
			if (cb_getFileSysData == null)
				cb_getFileSysData = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetFileSysData));
			return cb_getFileSysData;
		}

		static IntPtr n_GetFileSysData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetFileSysData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='getFileSysData' and count(parameter)=0]"
		[Register ("getFileSysData", "()[[B", "GetGetFileSysDataHandler")]
		public virtual unsafe byte[][]? GetFileSysData ()
		{
			const string __id = "getFileSysData.()[[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[][]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte[]));
			} finally {
			}
		}

		static Delegate? cb_getPackEnd;
#pragma warning disable 0169
		static Delegate GetGetPackEndHandler ()
		{
			if (cb_getPackEnd == null)
				cb_getPackEnd = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPackEnd));
			return cb_getPackEnd;
		}

		static IntPtr n_GetPackEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetPackEnd ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='getPackEnd' and count(parameter)=0]"
		[Register ("getPackEnd", "()[B", "GetGetPackEndHandler")]
		public virtual unsafe byte[]? GetPackEnd ()
		{
			const string __id = "getPackEnd.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getPackHead;
#pragma warning disable 0169
		static Delegate GetGetPackHeadHandler ()
		{
			if (cb_getPackHead == null)
				cb_getPackHead = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPackHead));
			return cb_getPackHead;
		}

		static IntPtr n_GetPackHead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetPackHead ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='getPackHead' and count(parameter)=0]"
		[Register ("getPackHead", "()[B", "GetGetPackHeadHandler")]
		public virtual unsafe byte[]? GetPackHead ()
		{
			const string __id = "getPackHead.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_getPackLen;
#pragma warning disable 0169
		static Delegate GetGetPackLenHandler ()
		{
			if (cb_getPackLen == null)
				cb_getPackLen = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPackLen));
			return cb_getPackLen;
		}

		static IntPtr n_GetPackLen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetPackLen ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='getPackLen' and count(parameter)=0]"
		[Register ("getPackLen", "()[B", "GetGetPackLenHandler")]
		public virtual unsafe byte[]? GetPackLen ()
		{
			const string __id = "getPackLen.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate? cb_setFileListLen_arrayB;
#pragma warning disable 0169
		static Delegate GetSetFileListLen_arrayBHandler ()
		{
			if (cb_setFileListLen_arrayB == null)
				cb_setFileListLen_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetFileListLen_arrayB));
			return cb_setFileListLen_arrayB;
		}

		static void n_SetFileListLen_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_fileListLen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var fileListLen = (byte[]?) JNIEnv.GetArray (native_fileListLen, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetFileListLen (fileListLen);
			if (fileListLen != null)
				JNIEnv.CopyArray (fileListLen, native_fileListLen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='setFileListLen' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setFileListLen", "([B)V", "GetSetFileListLen_arrayBHandler")]
		public virtual unsafe void SetFileListLen (byte[]? fileListLen)
		{
			const string __id = "setFileListLen.([B)V";
			IntPtr native_fileListLen = JNIEnv.NewArray (fileListLen);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileListLen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (fileListLen != null) {
					JNIEnv.CopyArray (native_fileListLen, fileListLen);
					JNIEnv.DeleteLocalRef (native_fileListLen);
				}
				global::System.GC.KeepAlive (fileListLen);
			}
		}

		static Delegate? cb_setFileSysCRC_arrayB;
#pragma warning disable 0169
		static Delegate GetSetFileSysCRC_arrayBHandler ()
		{
			if (cb_setFileSysCRC_arrayB == null)
				cb_setFileSysCRC_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetFileSysCRC_arrayB));
			return cb_setFileSysCRC_arrayB;
		}

		static void n_SetFileSysCRC_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_fileSysCRC)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var fileSysCRC = (byte[]?) JNIEnv.GetArray (native_fileSysCRC, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetFileSysCRC (fileSysCRC);
			if (fileSysCRC != null)
				JNIEnv.CopyArray (fileSysCRC, native_fileSysCRC);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='setFileSysCRC' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setFileSysCRC", "([B)V", "GetSetFileSysCRC_arrayBHandler")]
		public virtual unsafe void SetFileSysCRC (byte[]? fileSysCRC)
		{
			const string __id = "setFileSysCRC.([B)V";
			IntPtr native_fileSysCRC = JNIEnv.NewArray (fileSysCRC);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileSysCRC);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (fileSysCRC != null) {
					JNIEnv.CopyArray (native_fileSysCRC, fileSysCRC);
					JNIEnv.DeleteLocalRef (native_fileSysCRC);
				}
				global::System.GC.KeepAlive (fileSysCRC);
			}
		}

		static Delegate? cb_setFileSysData_arrayarrayB;
#pragma warning disable 0169
		static Delegate GetSetFileSysData_arrayarrayBHandler ()
		{
			if (cb_setFileSysData_arrayarrayB == null)
				cb_setFileSysData_arrayarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetFileSysData_arrayarrayB));
			return cb_setFileSysData_arrayarrayB;
		}

		static void n_SetFileSysData_arrayarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_fileSysData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var fileSysData = (byte[][]?) JNIEnv.GetArray (native_fileSysData, JniHandleOwnership.DoNotTransfer, typeof (byte[]));
			__this.SetFileSysData (fileSysData);
			if (fileSysData != null)
				JNIEnv.CopyArray (fileSysData, native_fileSysData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='setFileSysData' and count(parameter)=1 and parameter[1][@type='byte[][]']]"
		[Register ("setFileSysData", "([[B)V", "GetSetFileSysData_arrayarrayBHandler")]
		public virtual unsafe void SetFileSysData (byte[][]? fileSysData)
		{
			const string __id = "setFileSysData.([[B)V";
			IntPtr native_fileSysData = JNIEnv.NewArray (fileSysData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileSysData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (fileSysData != null) {
					JNIEnv.CopyArray (native_fileSysData, fileSysData);
					JNIEnv.DeleteLocalRef (native_fileSysData);
				}
				global::System.GC.KeepAlive (fileSysData);
			}
		}

		static Delegate? cb_setPackEnd_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPackEnd_arrayBHandler ()
		{
			if (cb_setPackEnd_arrayB == null)
				cb_setPackEnd_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPackEnd_arrayB));
			return cb_setPackEnd_arrayB;
		}

		static void n_SetPackEnd_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_packEnd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var packEnd = (byte[]?) JNIEnv.GetArray (native_packEnd, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPackEnd (packEnd);
			if (packEnd != null)
				JNIEnv.CopyArray (packEnd, native_packEnd);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='setPackEnd' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPackEnd", "([B)V", "GetSetPackEnd_arrayBHandler")]
		public virtual unsafe void SetPackEnd (byte[]? packEnd)
		{
			const string __id = "setPackEnd.([B)V";
			IntPtr native_packEnd = JNIEnv.NewArray (packEnd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packEnd);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (packEnd != null) {
					JNIEnv.CopyArray (native_packEnd, packEnd);
					JNIEnv.DeleteLocalRef (native_packEnd);
				}
				global::System.GC.KeepAlive (packEnd);
			}
		}

		static Delegate? cb_setPackHead_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPackHead_arrayBHandler ()
		{
			if (cb_setPackHead_arrayB == null)
				cb_setPackHead_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPackHead_arrayB));
			return cb_setPackHead_arrayB;
		}

		static void n_SetPackHead_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_packHead)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var packHead = (byte[]?) JNIEnv.GetArray (native_packHead, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPackHead (packHead);
			if (packHead != null)
				JNIEnv.CopyArray (packHead, native_packHead);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='setPackHead' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPackHead", "([B)V", "GetSetPackHead_arrayBHandler")]
		public virtual unsafe void SetPackHead (byte[]? packHead)
		{
			const string __id = "setPackHead.([B)V";
			IntPtr native_packHead = JNIEnv.NewArray (packHead);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packHead);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (packHead != null) {
					JNIEnv.CopyArray (native_packHead, packHead);
					JNIEnv.DeleteLocalRef (native_packHead);
				}
				global::System.GC.KeepAlive (packHead);
			}
		}

		static Delegate? cb_setPackLen_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPackLen_arrayBHandler ()
		{
			if (cb_setPackLen_arrayB == null)
				cb_setPackLen_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPackLen_arrayB));
			return cb_setPackLen_arrayB;
		}

		static void n_SetPackLen_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_packLen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var packLen = (byte[]?) JNIEnv.GetArray (native_packLen, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPackLen (packLen);
			if (packLen != null)
				JNIEnv.CopyArray (packLen, native_packLen);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='setPackLen' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPackLen", "([B)V", "GetSetPackLen_arrayBHandler")]
		public virtual unsafe void SetPackLen (byte[]? packLen)
		{
			const string __id = "setPackLen.([B)V";
			IntPtr native_packLen = JNIEnv.NewArray (packLen);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packLen);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (packLen != null) {
					JNIEnv.CopyArray (native_packLen, packLen);
					JNIEnv.DeleteLocalRef (native_packLen);
				}
				global::System.GC.KeepAlive (packLen);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='size' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var buf = (byte[]?) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ToBean (buf);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='toBean' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vanstone.Trans.Api.Struct.FileSysToPc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.ToBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api.struct']/class[@name='FileSysToPc']/method[@name='toBytes' and count(parameter)=0]"
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