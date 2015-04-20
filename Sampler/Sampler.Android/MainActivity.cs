using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using NView;

namespace Sampler.Android
{
	[Activity (Label = "Sampler.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		IView mainView = new Sampler ().MainView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			this.BindToNative<LinearLayout> (mainView, Resource.Id.myLayout);
		}
	}
}


