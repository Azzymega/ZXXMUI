using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;
using QWFramework;

namespace UndefineIntegralQWXamarin;

public class Adapter : PagerAdapter
{
    Context _context;

    public Adapter (Context context)
    {
        this._context = context;
    }
    public override bool IsViewFromObject(View view, Object @object)
    {
        return view == @object;
    }
    public override void DestroyItem(View container, int position, Java.Lang.Object view)
    {
        var viewPager = container.JavaCast<ViewPager>();
        viewPager.RemoveView(view as View);
    }
    public override int Count => 3;
    public override Object InstantiateItem (View container, int position)
    {
        if (position == 0)
        {
            View view = View.Inflate(_context, Resource.Layout.application,null);
            Button bt = (Button)view.FindViewById(Resource.Id.button);
            bt.Click += delegate
            {
                EditText text = (EditText)view.FindViewById(Resource.Id.editTextTextPersonName);
                EditText text2 = (EditText)view.FindViewById(Resource.Id.editTextTextPersonName2);
                UndefinedIntegral integral = new UndefinedIntegral(text.Text, new UndefineIntegralEvaluator(text.Text));
                text2.Text = integral.ReturnAnswer();
            };
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView (view);
            return view;
        }

        if (position == 1)
        {
            View view = View.Inflate(_context, Resource.Layout.instruction,null);
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView (view);
            return view;
        }
        if (position == 2)
        {
            View view = View.Inflate(_context, Resource.Layout.integrali,null);
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView (view);
            return view;
        }

        return null;
    }
}