package mono.com.vanstone.base.interfaces;


public class PedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.vanstone.base.interfaces.PedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_processCallback:([B)V:GetProcessCallback_arrayBHandler:Com.Vanstone.Base.Interfaces.IPedListenerInvoker, VanstonePosSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Vanstone.Base.Interfaces.IPedListenerImplementor, VanstonePosSdk", PedListenerImplementor.class, __md_methods);
	}


	public PedListenerImplementor ()
	{
		super ();
		if (getClass () == PedListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Vanstone.Base.Interfaces.IPedListenerImplementor, VanstonePosSdk", "", this, new java.lang.Object[] {  });
		}
	}


	public void processCallback (byte[] p0)
	{
		n_processCallback (p0);
	}

	private native void n_processCallback (byte[] p0);

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
