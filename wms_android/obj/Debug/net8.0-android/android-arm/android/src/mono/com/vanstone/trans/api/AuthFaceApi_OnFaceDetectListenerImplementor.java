package mono.com.vanstone.trans.api;


public class AuthFaceApi_OnFaceDetectListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vanstone.trans.api.AuthFaceApi.OnFaceDetectListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(I)V:GetOnError_IHandler:Com.Vanstone.Trans.Api.AuthFaceApi/IOnFaceDetectListenerInvoker, VanstonePosSdk\n" +
			"n_onPreview:([BII)V:GetOnPreview_arrayBIIHandler:Com.Vanstone.Trans.Api.AuthFaceApi/IOnFaceDetectListenerInvoker, VanstonePosSdk\n" +
			"n_onShowFrame:(Landroid/graphics/RectF;II)V:GetOnShowFrame_Landroid_graphics_RectF_IIHandler:Com.Vanstone.Trans.Api.AuthFaceApi/IOnFaceDetectListenerInvoker, VanstonePosSdk\n" +
			"n_onSuccess:(Landroid/os/Bundle;)V:GetOnSuccess_Landroid_os_Bundle_Handler:Com.Vanstone.Trans.Api.AuthFaceApi/IOnFaceDetectListenerInvoker, VanstonePosSdk\n" +
			"n_onTip:(I)V:GetOnTip_IHandler:Com.Vanstone.Trans.Api.AuthFaceApi/IOnFaceDetectListenerInvoker, VanstonePosSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Vanstone.Trans.Api.AuthFaceApi+IOnFaceDetectListenerImplementor, VanstonePosSdk", AuthFaceApi_OnFaceDetectListenerImplementor.class, __md_methods);
	}


	public AuthFaceApi_OnFaceDetectListenerImplementor ()
	{
		super ();
		if (getClass () == AuthFaceApi_OnFaceDetectListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Vanstone.Trans.Api.AuthFaceApi+IOnFaceDetectListenerImplementor, VanstonePosSdk", "", this, new java.lang.Object[] {  });
		}
	}


	public void onError (int p0)
	{
		n_onError (p0);
	}

	private native void n_onError (int p0);


	public void onPreview (byte[] p0, int p1, int p2)
	{
		n_onPreview (p0, p1, p2);
	}

	private native void n_onPreview (byte[] p0, int p1, int p2);


	public void onShowFrame (android.graphics.RectF p0, int p1, int p2)
	{
		n_onShowFrame (p0, p1, p2);
	}

	private native void n_onShowFrame (android.graphics.RectF p0, int p1, int p2);


	public void onSuccess (android.os.Bundle p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (android.os.Bundle p0);


	public void onTip (int p0)
	{
		n_onTip (p0);
	}

	private native void n_onTip (int p0);

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
