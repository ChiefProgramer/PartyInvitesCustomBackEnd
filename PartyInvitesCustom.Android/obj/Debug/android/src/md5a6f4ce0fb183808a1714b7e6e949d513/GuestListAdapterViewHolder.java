package md5a6f4ce0fb183808a1714b7e6e949d513;


public class GuestListAdapterViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("PartyInvitesCustom.Android.GuestListAdapterViewHolder, PartyInvitesCustom.Android", GuestListAdapterViewHolder.class, __md_methods);
	}


	public GuestListAdapterViewHolder ()
	{
		super ();
		if (getClass () == GuestListAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("PartyInvitesCustom.Android.GuestListAdapterViewHolder, PartyInvitesCustom.Android", "", this, new java.lang.Object[] {  });
	}

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
