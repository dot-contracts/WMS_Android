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

namespace Com.Vanstone.Trans.Api.Constants {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']"
	[global::Android.Runtime.Register ("com/vanstone/trans/api/constants/TmsFuncConstants", DoNotGenerateAcw=true)]
	public partial class TmsFuncConstants : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='APPNUM']"
		[Register ("APPNUM")]
		public const int Appnum = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='APP_FILE_EXT']"
		[Register ("APP_FILE_EXT")]
		public const string AppFileExt = (string) ".exe";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='DIR_TMS']"
		[Register ("DIR_TMS")]
		public const string DirTms = (string) "tms";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='FNAME_TASKINI']"
		[Register ("FNAME_TASKINI")]
		public const string FnameTaskini = (string) ".\\tms.ini";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='MULTITASKINI']"
		[Register ("MULTITASKINI")]
		public const string Multitaskini = (string) "\\mtd0\\res\\multitask.ini";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='TMS_APPID']"
		[Register ("TMS_APPID")]
		public const string TmsAppid = (string) "0000";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='TMS_APPVER_LEN']"
		[Register ("TMS_APPVER_LEN")]
		public const int TmsAppverLen = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='TMS_FACTORY_ID']"
		[Register ("TMS_FACTORY_ID")]
		public const string TmsFactoryId = (string) "10";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/field[@name='TMS_MACHINE_ID']"
		[Register ("TMS_MACHINE_ID")]
		public const string TmsMachineId = (string) "01";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vanstone/trans/api/constants/TmsFuncConstants", typeof (TmsFuncConstants));

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

		protected TmsFuncConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vanstone.trans.api.constants']/class[@name='TmsFuncConstants']/constructor[@name='TmsFuncConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TmsFuncConstants () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}