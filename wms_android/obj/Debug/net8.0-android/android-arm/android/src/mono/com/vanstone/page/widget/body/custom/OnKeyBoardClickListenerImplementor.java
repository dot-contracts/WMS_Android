package mono.com.vanstone.page.widget.body.custom;


public class OnKeyBoardClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vanstone.page.widget.body.custom.OnKeyBoardClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCancel:()V:GetOnCancelHandler:Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker, VanstonePosSdk\n" +
			"n_onEnter:(Ljava/lang/String;)V:GetOnEnter_Ljava_lang_String_Handler:Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker, VanstonePosSdk\n" +
			"n_onKeyBoardClick:(Landroid/view/View;Ljava/lang/String;)V:GetOnKeyBoardClick_Landroid_view_View_Ljava_lang_String_Handler:Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker, VanstonePosSdk\n" +
			"n_onKeyClick:(I)V:GetOnKeyClick_IHandler:Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerInvoker, VanstonePosSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerImplementor, VanstonePosSdk", OnKeyBoardClickListenerImplementor.class, __md_methods);
	}


	public OnKeyBoardClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnKeyBoardClickListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Vanstone.Page.Widget.Body.Custom.IOnKeyBoardClickListenerImplementor, VanstonePosSdk", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCancel ()
	{
		n_onCancel ();
	}

	private native void n_onCancel ();


	public void onEnter (java.lang.String p0)
	{
		n_onEnter (p0);
	}

	private native void n_onEnter (java.lang.String p0);


	public void onKeyBoardClick (android.view.View p0, java.lang.String p1)
	{
		n_onKeyBoardClick (p0, p1);
	}

	private native void n_onKeyBoardClick (android.view.View p0, java.lang.String p1);


	public void onKeyClick (int p0)
	{
		n_onKeyClick (p0);
	}

	private native void n_onKeyClick (int p0);

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
