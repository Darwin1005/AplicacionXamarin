using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content.PM;

namespace ReciclaPeru.Droid
{
    [Activity(Label = "Darwin's", Icon ="@mipmap/logo", NoHistory =true,
        Theme ="@style/nuevotema",MainLauncher =true, ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize)]
    public class Bienvenido : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            // Create your application here
        }
    }
}