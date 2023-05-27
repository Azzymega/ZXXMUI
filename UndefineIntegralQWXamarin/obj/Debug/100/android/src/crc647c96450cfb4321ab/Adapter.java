package crc647c96450cfb4321ab;


public class Adapter
	extends androidx.viewpager.widget.PagerAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_isViewFromObject:(Landroid/view/View;Ljava/lang/Object;)Z:GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler\n" +
			"n_destroyItem:(Landroid/view/View;ILjava/lang/Object;)V:GetDestroyItem_Landroid_view_View_ILjava_lang_Object_Handler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_instantiateItem:(Landroid/view/View;I)Ljava/lang/Object;:GetInstantiateItem_Landroid_view_View_IHandler\n" +
			"";
		mono.android.Runtime.register ("UndefineIntegralQWXamarin.Adapter, UndefineIntegralQWXamarin", Adapter.class, __md_methods);
	}


	public Adapter ()
	{
		super ();
		if (getClass () == Adapter.class)
			mono.android.TypeManager.Activate ("UndefineIntegralQWXamarin.Adapter, UndefineIntegralQWXamarin", "", this, new java.lang.Object[] {  });
	}

	public Adapter (android.content.Context p0)
	{
		super ();
		if (getClass () == Adapter.class)
			mono.android.TypeManager.Activate ("UndefineIntegralQWXamarin.Adapter, UndefineIntegralQWXamarin", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public boolean isViewFromObject (android.view.View p0, java.lang.Object p1)
	{
		return n_isViewFromObject (p0, p1);
	}

	private native boolean n_isViewFromObject (android.view.View p0, java.lang.Object p1);


	public void destroyItem (android.view.View p0, int p1, java.lang.Object p2)
	{
		n_destroyItem (p0, p1, p2);
	}

	private native void n_destroyItem (android.view.View p0, int p1, java.lang.Object p2);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public java.lang.Object instantiateItem (android.view.View p0, int p1)
	{
		return n_instantiateItem (p0, p1);
	}

	private native java.lang.Object n_instantiateItem (android.view.View p0, int p1);

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
