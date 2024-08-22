package crc64dc94172e70d5f7d7;


public class Bienvenido
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ReciclaPeru.Droid.Bienvenido, ReciclaPeru.Android", Bienvenido.class, __md_methods);
	}


	public Bienvenido ()
	{
		super ();
		if (getClass () == Bienvenido.class) {
			mono.android.TypeManager.Activate ("ReciclaPeru.Droid.Bienvenido, ReciclaPeru.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
