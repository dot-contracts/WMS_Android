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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']"
	[global::Android.Runtime.Register ("com/vanstone/trans/api/BtPrinterApi", DoNotGenerateAcw=true)]
	public partial class BtPrinterApi : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='blueSocket']"
		[Register ("blueSocket")]
		public static global::Android.Bluetooth.BluetoothSocket? BlueSocket {
			get {
				const string __id = "blueSocket.Landroid/bluetooth/BluetoothSocket;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothSocket> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "blueSocket.Landroid/bluetooth/BluetoothSocket;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='bufSize']"
		[Register ("bufSize")]
		public const int BufSize = (int) 102400;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='encoding']"
		[Register ("encoding")]
		public static string? Encoding {
			get {
				const string __id = "encoding.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "encoding.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='ENCODING_GBK']"
		[Register ("ENCODING_GBK")]
		public const string EncodingGbk = (string) "GBK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='ENCODING_UTF8']"
		[Register ("ENCODING_UTF8")]
		public const string EncodingUtf8 = (string) "UTF-8";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='errCode']"
		[Register ("errCode")]
		public int ErrCode {
			get {
				const string __id = "errCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "errCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='errMsg']"
		[Register ("errMsg")]
		public string? ErrMsg {
			get {
				const string __id = "errMsg.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errMsg.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='g_MacAddr']"
		[Register ("g_MacAddr")]
		public static string? GMacAddr {
			get {
				const string __id = "g_MacAddr.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "g_MacAddr.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='g_PrnMemBuf']"
		[Register ("g_PrnMemBuf")]
		public static IList<byte>? GPrnMemBuf {
			get {
				const string __id = "g_PrnMemBuf.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "g_PrnMemBuf.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='g_PrnMemBufLen']"
		[Register ("g_PrnMemBufLen")]
		public static int GPrnMemBufLen {
			get {
				const string __id = "g_PrnMemBufLen.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "g_PrnMemBufLen.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='lainjie']"
		[Register ("lainjie")]
		public static int Lainjie {
			get {
				const string __id = "lainjie.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "lainjie.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='LANG_CH']"
		[Register ("LANG_CH")]
		public const int LangCh = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='LANG_PERSIAN']"
		[Register ("LANG_PERSIAN")]
		public const int LangPersian = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='SPP_UUID']"
		[Register ("SPP_UUID")]
		public static string? SppUuid {
			get {
				const string __id = "SPP_UUID.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "SPP_UUID.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/field[@name='stopTime']"
		[Register ("stopTime")]
		public static int StopTime {
			get {
				const string __id = "stopTime.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "stopTime.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/trans/api/BtPrinterApi", typeof (BtPrinterApi));

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

		protected BtPrinterApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/constructor[@name='BtPrinterApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BtPrinterApi () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnAlignSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnAlignSet_Api", "(I)V", "")]
		public static unsafe void PrnAlignSet_Api (int align)
		{
			const string __id = "PrnAlignSet_Api.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (align);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnBarcode_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("PrnBarcode_Api", "(Ljava/lang/String;)V", "")]
		public static unsafe void PrnBarcode_Api (string? code)
		{
			const string __id = "PrnBarcode_Api.(Ljava/lang/String;)V";
			IntPtr native_code = JNIEnv.NewString ((string?)code);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_code);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_code);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnClose_Api' and count(parameter)=0]"
		[Register ("PrnClose_Api", "()V", "")]
		public static unsafe void PrnClose_Api ()
		{
			const string __id = "PrnClose_Api.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnClrBuff_Api' and count(parameter)=0]"
		[Register ("PrnClrBuff_Api", "()V", "")]
		public static unsafe void PrnClrBuff_Api ()
		{
			const string __id = "PrnClrBuff_Api.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnFontSet_Api' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("PrnFontSet_Api", "(III)V", "")]
		public static unsafe void PrnFontSet_Api (int Ascii, int CFont, int Zoom)
		{
			const string __id = "PrnFontSet_Api.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (Ascii);
				__args [1] = new JniArgumentValue (CFont);
				__args [2] = new JniArgumentValue (Zoom);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnHTSet_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("PrnHTSet_Api", "(Z)V", "")]
		public static unsafe void PrnHTSet_Api (bool flag)
		{
			const string __id = "PrnHTSet_Api.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnLeftIndSet_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnLeftIndSet_Api", "(I)I", "")]
		public static unsafe int PrnLeftIndSet_Api (int usLeftIndent)
		{
			const string __id = "PrnLeftIndSet_Api.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (usLeftIndent);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnLessen_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("PrnLessen_Api", "(Z)V", "")]
		public static unsafe void PrnLessen_Api (bool flag)
		{
			const string __id = "PrnLessen_Api.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnLineSpaceSet_Api' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("PrnLineSpaceSet_Api", "(II)V", "")]
		public static unsafe void PrnLineSpaceSet_Api (int ucLineSpace, int ucCharSpace)
		{
			const string __id = "PrnLineSpaceSet_Api.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (ucLineSpace);
				__args [1] = new JniArgumentValue (ucCharSpace);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnLine_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("PrnLine_Api", "(Z)V", "")]
		public static unsafe void PrnLine_Api (bool flag)
		{
			const string __id = "PrnLine_Api.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnLogo_Api' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("PrnLogo_Api", "(Landroid/graphics/Bitmap;)I", "")]
		public static unsafe int PrnLogo_Api (global::Android.Graphics.Bitmap? bitmap)
		{
			const string __id = "PrnLogo_Api.(Landroid/graphics/Bitmap;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnLogo_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("PrnLogo_Api", "(Ljava/lang/String;)I", "")]
		public static unsafe int PrnLogo_Api (string? hexData)
		{
			const string __id = "PrnLogo_Api.(Ljava/lang/String;)I";
			IntPtr native_hexData = JNIEnv.NewString ((string?)hexData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hexData);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_hexData);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnOpen_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("PrnOpen_Api", "(Ljava/lang/String;)I", "")]
		public static unsafe int PrnOpen_Api (string? macAddr)
		{
			const string __id = "PrnOpen_Api.(Ljava/lang/String;)I";
			IntPtr native_macAddr = JNIEnv.NewString ((string?)macAddr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_macAddr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_macAddr);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnQrcode_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("PrnQrcode_Api", "(Ljava/lang/String;)V", "")]
		public static unsafe void PrnQrcode_Api (string? code)
		{
			const string __id = "PrnQrcode_Api.(Ljava/lang/String;)V";
			IntPtr native_code = JNIEnv.NewString ((string?)code);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_code);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_code);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnStart_Api' and count(parameter)=0]"
		[Register ("PrnStart_Api", "()I", "")]
		public static unsafe int PrnStart_Api ()
		{
			const string __id = "PrnStart_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnStatus_Api' and count(parameter)=0]"
		[Register ("PrnStatus_Api", "()I", "")]
		public static unsafe int PrnStatus_Api ()
		{
			const string __id = "PrnStatus_Api.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnStep_Api' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("PrnStep_Api", "(I)I", "")]
		public static unsafe int PrnStep_Api (int sPixel)
		{
			const string __id = "PrnStep_Api.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sPixel);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnStr_Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("PrnStr_Api", "(Ljava/lang/String;)I", "")]
		public static unsafe int PrnStr_Api (string? data)
		{
			const string __id = "PrnStr_Api.(Ljava/lang/String;)I";
			IntPtr native_data = JNIEnv.NewString ((string?)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='PrnZoom_Api' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("PrnZoom_Api", "(Z)V", "")]
		public static unsafe void PrnZoom_Api (bool flag)
		{
			const string __id = "PrnZoom_Api.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='ZoomImage_Api' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("ZoomImage_Api", "(Landroid/graphics/Bitmap;DD)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap? ZoomImage_Api (global::Android.Graphics.Bitmap? bitmap, double newWidth, double newHeight)
		{
			const string __id = "ZoomImage_Api.(Landroid/graphics/Bitmap;DD)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (newWidth);
				__args [2] = new JniArgumentValue (newHeight);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vanstone.trans.api']/class[@name='BtPrinterApi']/method[@name='setEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEncoding", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetEncoding (string? coding)
		{
			const string __id = "setEncoding.(Ljava/lang/String;)V";
			IntPtr native_coding = JNIEnv.NewString ((string?)coding);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_coding);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_coding);
			}
		}

	}
}