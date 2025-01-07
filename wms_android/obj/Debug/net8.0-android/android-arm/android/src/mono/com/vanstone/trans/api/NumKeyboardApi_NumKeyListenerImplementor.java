package mono.com.vanstone.trans.api;


public class NumKeyboardApi_NumKeyListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vanstone.trans.api.NumKeyboardApi.NumKeyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAvailable:()V:GetOnAvailableHandler:Com.Vanstone.Trans.Api.NumKeyboardApi/INumKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onDisplayUpdate:(Ljava/lang/String;)V:GetOnDisplayUpdate_Ljava_lang_String_Handler:Com.Vanstone.Trans.Api.NumKeyboardApi/INumKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onException:(Ljava/lang/String;)V:GetOnException_Ljava_lang_String_Handler:Com.Vanstone.Trans.Api.NumKeyboardApi/INumKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onKeyDown:(ILjava/lang/String;)V:GetOnKeyDown_ILjava_lang_String_Handler:Com.Vanstone.Trans.Api.NumKeyboardApi/INumKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onKeyUp:(ILjava/lang/String;)V:GetOnKeyUp_ILjava_lang_String_Handler:Com.Vanstone.Trans.Api.NumKeyboardApi/INumKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onPayRequest:(Lcom/vanstone/trans/api/NumKeyboardApi$NumKeyPayRequest;)V:GetOnPayRequest_Lcom_vanstone_trans_api_NumKeyboardApi_NumKeyPayRequest_Handler:Com.Vanstone.Trans.Api.NumKeyboardApi/INumKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onRelease:()V:GetOnReleaseHandler:Com.Vanstone.Trans.Api.NumKeyboardApi/INumKeyListenerInvoker, VanstonePosSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Vanstone.Trans.Api.NumKeyboardApi+INumKeyListenerImplementor, VanstonePosSdk", NumKeyboardApi_NumKeyListenerImplementor.class, __md_methods);
	}


	public NumKeyboardApi_NumKeyListenerImplementor ()
	{
		super ();
		if (getClass () == NumKeyboardApi_NumKeyListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Vanstone.Trans.Api.NumKeyboardApi+INumKeyListenerImplementor, VanstonePosSdk", "", this, new java.lang.Object[] {  });
		}
	}


	public void onAvailable ()
	{
		n_onAvailable ();
	}

	private native void n_onAvailable ();


	public void onDisplayUpdate (java.lang.String p0)
	{
		n_onDisplayUpdate (p0);
	}

	private native void n_onDisplayUpdate (java.lang.String p0);


	public void onException (java.lang.String p0)
	{
		n_onException (p0);
	}

	private native void n_onException (java.lang.String p0);


	public void onKeyDown (int p0, java.lang.String p1)
	{
		n_onKeyDown (p0, p1);
	}

	private native void n_onKeyDown (int p0, java.lang.String p1);


	public void onKeyUp (int p0, java.lang.String p1)
	{
		n_onKeyUp (p0, p1);
	}

	private native void n_onKeyUp (int p0, java.lang.String p1);


	public void onPayRequest (com.vanstone.trans.api.NumKeyboardApi.NumKeyPayRequest p0)
	{
		n_onPayRequest (p0);
	}

	private native void n_onPayRequest (com.vanstone.trans.api.NumKeyboardApi.NumKeyPayRequest p0);


	public void onRelease ()
	{
		n_onRelease ();
	}

	private native void n_onRelease ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
