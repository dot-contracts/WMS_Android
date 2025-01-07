package mono.com.vanstone.utils;


public class PPUpdate_IUpdatePinPadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vanstone.utils.PPUpdate.IUpdatePinPadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(I)I:GetOnError_IHandler:Com.Vanstone.Utils.PPUpdate/IUpdatePinPadListenerInvoker, VanstonePosSdk\n" +
			"n_onFinishUpdate:()I:GetOnFinishUpdateHandler:Com.Vanstone.Utils.PPUpdate/IUpdatePinPadListenerInvoker, VanstonePosSdk\n" +
			"n_onIsUpdate:(I)Z:GetOnIsUpdate_IHandler:Com.Vanstone.Utils.PPUpdate/IUpdatePinPadListenerInvoker, VanstonePosSdk\n" +
			"n_onProgress:(Ljava/lang/String;II)I:GetOnProgress_Ljava_lang_String_IIHandler:Com.Vanstone.Utils.PPUpdate/IUpdatePinPadListenerInvoker, VanstonePosSdk\n" +
			"n_onTips:(I)I:GetOnTips_IHandler:Com.Vanstone.Utils.PPUpdate/IUpdatePinPadListenerInvoker, VanstonePosSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Vanstone.Utils.PPUpdate+IUpdatePinPadListenerImplementor, VanstonePosSdk", PPUpdate_IUpdatePinPadListenerImplementor.class, __md_methods);
	}


	public PPUpdate_IUpdatePinPadListenerImplementor ()
	{
		super ();
		if (getClass () == PPUpdate_IUpdatePinPadListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Vanstone.Utils.PPUpdate+IUpdatePinPadListenerImplementor, VanstonePosSdk", "", this, new java.lang.Object[] {  });
		}
	}


	public int onError (int p0)
	{
		return n_onError (p0);
	}

	private native int n_onError (int p0);


	public int onFinishUpdate ()
	{
		return n_onFinishUpdate ();
	}

	private native int n_onFinishUpdate ();


	public boolean onIsUpdate (int p0)
	{
		return n_onIsUpdate (p0);
	}

	private native boolean n_onIsUpdate (int p0);


	public int onProgress (java.lang.String p0, int p1, int p2)
	{
		return n_onProgress (p0, p1, p2);
	}

	private native int n_onProgress (java.lang.String p0, int p1, int p2);


	public int onTips (int p0)
	{
		return n_onTips (p0);
	}

	private native int n_onTips (int p0);

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
