package mono.com.vanstone.trans.api;


public class PedApi_OnPedKeyListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vanstone.trans.api.PedApi.OnPedKeyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCancel:()V:GetOnCancelHandler:Com.Vanstone.Trans.Api.PedApi/IOnPedKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onError:(I)V:GetOnError_IHandler:Com.Vanstone.Trans.Api.PedApi/IOnPedKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onKeyClick:(I)V:GetOnKeyClick_IHandler:Com.Vanstone.Trans.Api.PedApi/IOnPedKeyListenerInvoker, VanstonePosSdk\n" +
			"n_onSuccess:(Ljava/lang/String;)V:GetOnSuccess_Ljava_lang_String_Handler:Com.Vanstone.Trans.Api.PedApi/IOnPedKeyListenerInvoker, VanstonePosSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Vanstone.Trans.Api.PedApi+IOnPedKeyListenerImplementor, VanstonePosSdk", PedApi_OnPedKeyListenerImplementor.class, __md_methods);
	}


	public PedApi_OnPedKeyListenerImplementor ()
	{
		super ();
		if (getClass () == PedApi_OnPedKeyListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Vanstone.Trans.Api.PedApi+IOnPedKeyListenerImplementor, VanstonePosSdk", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCancel ()
	{
		n_onCancel ();
	}

	private native void n_onCancel ();


	public void onError (int p0)
	{
		n_onError (p0);
	}

	private native void n_onError (int p0);


	public void onKeyClick (int p0)
	{
		n_onKeyClick (p0);
	}

	private native void n_onKeyClick (int p0);


	public void onSuccess (java.lang.String p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (java.lang.String p0);

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
