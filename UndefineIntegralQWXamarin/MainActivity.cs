using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using QWFramework;

namespace UndefineIntegralQWXamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private UndefinedIntegral _integral;
        private EditText _editText;
        private Button _button;
        private TextView _textView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            _editText = FindViewById<EditText>(Resource.Id.textEditor);
            _button = FindViewById<Button>(Resource.Id.button3);
            _textView = FindViewById<TextView>(Resource.Id.textView2);
            _button.Click += (sender, e) =>
            {
                try
                {
                    _integral = new UndefinedIntegral(_editText.Text, new UndefineIntegralEvaluator(_editText.Text));
                    _textView.Text = _integral.ReturnAnswer();
                }
                catch
                {
                    Toast.MakeText(this, "Вы ошиблись при вводе. Поправьте ошибку.", ToastLength.Long);
                }
            };
        }
    }
}