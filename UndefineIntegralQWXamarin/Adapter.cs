using System;
using System.IO;
using System.Text;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Widget;
using QWFramework.Core;
using QWFramework.Export;
using Xamarin.Forms;
using Application = Android.App.Application;
using Button = Android.Widget.Button;
using Object = Java.Lang.Object;
using View = Android.Views.View;

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
            Button word = (Button)view.FindViewById(Resource.Id.button2);
            Button excel = (Button)view.FindViewById(Resource.Id.button3);
            excel.Click += delegate
            {
                Dialog dialog = new Dialog(_context);
                View viewx = View.Inflate(_context, Resource.Layout.pathpicker, null);
                Button bt = (Button)viewx.FindViewById(Resource.Id.button4);
                bt.Click += delegate
                { 
                    EditText path = (EditText)viewx.FindViewById(Resource.Id.editTextTextPersonName3);
                    EditText text2 = (EditText)view.FindViewById(Resource.Id.editTextTextPersonName2);
                    XLSX xl = new XLSX(path.Text,text2.Text);
                };
                dialog.SetContentView(viewx);
                dialog.Show();
            };
            word.Click += delegate
            {
                Dialog dialog = new Dialog(_context);
                View viewx = View.Inflate(_context, Resource.Layout.pathpicker, null);
                Button bt = (Button)viewx.FindViewById(Resource.Id.button4);
                bt.Click += delegate
                { 
                    EditText path = (EditText)viewx.FindViewById(Resource.Id.editTextTextPersonName3);
                    EditText text2 = (EditText)view.FindViewById(Resource.Id.editTextTextPersonName2);
                    using (FileStream fstream = new FileStream(path.Text, FileMode.OpenOrCreate))
                    {
                        fstream.Write(Encoding.ASCII.GetBytes(text2.Text));
                    }
                };
                dialog.SetContentView(viewx);
                dialog.Show();
            };
            bt.Click += delegate
            {
                try
                {
                    EditText text = (EditText)view.FindViewById(Resource.Id.editTextTextPersonName);
                    EditText text2 = (EditText)view.FindViewById(Resource.Id.editTextTextPersonName2);
                    UndefinedIntegral integral = new UndefinedIntegral(text.Text, new UndefineIntegralEvaluator(text.Text));
                    text2.Text = integral.ReturnAnswer();
                }
                catch
                {
                    Toast.MakeText(Application.Context, "Вы ошиблись при вводе", ToastLength.Long).Show();
                }
            };
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView (view);
            return view;
        }

        if (position == 1)
        {
            View view = View.Inflate(Application.Context, Resource.Layout.instruction,null);
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView (view);
            return view;
        }
        if (position == 2)
        {
            View view = View.Inflate(Application.Context, Resource.Layout.integrali,null);
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView (view);
            return view;
        }

        return null;
    }
}