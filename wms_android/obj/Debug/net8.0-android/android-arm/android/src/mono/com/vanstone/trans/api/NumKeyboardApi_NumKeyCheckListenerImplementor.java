package mono.com.vanstone.trans.api;


public class NumKeyboardApi_NumKeyCheckListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vanstone.trans.api.NumKeyboardApi.NumKeyCheckListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttach:()V:GetOnAttachHandler:Com.Vanstone.Trans.Api.NumKeyboardApi/INumKeyCheckListenerInvoker, VanstonePosSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Vanstone.Trans.Api.NumKeyboardApi+INumKeyCheckListenerImplementor, VanstonePosSdk", NumKeyboardApi_NumKeyCheckListenerImplementor.class, __md_methods);
	}


	public NumKeyboardApi_NumKeyCheckListenerImplementor ()
	{
		super ();
		if (getClass () == NumKeyboardApi_NumKeyCheckListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Vanstone.Trans.Api.NumKeyboardApi+INumKeyCheckListenerImplementor, VanstonePosSdk", "", this, new java.lang.Object[] {  });
		}
	}


	public void onAttach ()
	{
		n_onAttach ();
	}

	private native void n_onAttach ();

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
