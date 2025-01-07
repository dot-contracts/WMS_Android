package mono.com.vanstone.base.interfaces;


public class CmdListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vanstone.base.interfaces.CmdListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_cmdAction:(ILjava/lang/Object;)V:GetCmdAction_ILjava_lang_Object_Handler:Com.Vanstone.Base.Interfaces.ICmdListenerInvoker, VanstonePosSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Vanstone.Base.Interfaces.ICmdListenerImplementor, VanstonePosSdk", CmdListenerImplementor.class, __md_methods);
	}


	public CmdListenerImplementor ()
	{
		super ();
		if (getClass () == CmdListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Vanstone.Base.Interfaces.ICmdListenerImplementor, VanstonePosSdk", "", this, new java.lang.Object[] {  });
		}
	}


	public void cmdAction (int p0, java.lang.Object p1)
	{
		n_cmdAction (p0, p1);
	}

	private native void n_cmdAction (int p0, java.lang.Object p1);

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
