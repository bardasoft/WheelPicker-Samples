﻿using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Util;

namespace WheelPickerDemo.Forms.Droid
{
    [Activity(Label = "WheelPickerDemo", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            TaskScheduler.UnobservedTaskException += (sender, args) =>
            {
                Log.Error("WPDemo", $"{args.Exception.Message}: {args.Exception.StackTrace}");
            };

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}
