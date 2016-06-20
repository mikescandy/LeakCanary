using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Application]
    public class MyApplication : Application
    {
		public MyApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
		{
		}


		public override void OnCreate()
        {
            base.OnCreate();
			Com.Squareup.Leakcanary.BoundLeakCanary.Install(this);
        }
    }
}