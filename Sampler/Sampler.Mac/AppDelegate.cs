using System;

using Foundation;
using AppKit;
using NView;

namespace Sampler
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;

		IView mainView = new Sampler ().MainView;

		public AppDelegate ()
		{
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);

			mainView.BindToNative (mainWindowController.Window.ContentView);
		}
	}
}

