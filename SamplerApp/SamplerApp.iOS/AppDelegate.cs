using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using NView;

namespace SamplerApp.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		IView mainView = new Sampler.Sampler ().MainView;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			var root = new UIViewController ();
			root.Title = "NView Sampler";
			root.View.BackgroundColor = UIColor.White;

			mainView.BindToNative (root);

			window = new UIWindow (UIScreen.MainScreen.Bounds) {
				RootViewController = new UINavigationController (root),
			};
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

