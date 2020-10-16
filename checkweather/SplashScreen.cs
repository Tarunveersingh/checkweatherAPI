using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace checkweather
{
//    [Activity(Label = "@string/app_name", Theme = "@style/Theme.Splash", MainLauncher = true)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //this function is used for pausing the application 
            Thread.Sleep(1500);
            //again we  can start same activity
            StartActivity(typeof(HomeActivity));
            Finish();
        }
    }
}