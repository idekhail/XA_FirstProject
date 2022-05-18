using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android;

namespace XA_FirstProject
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            Button btn = FindViewById<Button>(Resource.Id.MyButton);
            TextView txtDisp= FindViewById<TextView>(Resource.Id.TxtDisp);

            btn.Click += delegate
            {
                txtDisp.Text = " Ahmed";
            };

        }
       
    }
}