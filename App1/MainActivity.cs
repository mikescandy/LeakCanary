using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Lang;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
		private atask atask;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate {
				atask = new atask();
				atask.Execute();
				button.Text = string.Format("{0} clicks!", count++);
			};
        }
    }

	public class atask : AsyncTask
	{
		protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
		{
			Thread.Sleep(20000);
			return null;
		}
	}
}

