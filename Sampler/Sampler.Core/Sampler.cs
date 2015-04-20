using System;
using System.Reflection;

using NView;
using NView.Controls;

namespace Sampler
{
	public class Sampler
	{
		public readonly Stack MainView = new Stack {
			Orientation = StackOrientation.Vertical,
		};

		public Sampler ()
		{
			var apps = new object[] {
				new HelloWorld.HelloWorld (),
				new Counter.Counter (),
			};

			var labelLayout = new StackLayout {
				HorizontalAlignment = HorizontalAlignment.Left
			};
			var appLayout = new StackLayout {
				HorizontalAlignment = HorizontalAlignment.Center
			};

			// Pad the top
			for (var i = 0; i < 4; i++)
				MainView.AddChild (new Label { Text = " " }, labelLayout);

			foreach (var a in apps) {
				var view = (IView)a.GetType ().GetTypeInfo ().GetDeclaredField ("MainView").GetValue (a);

//				var button = new Button {
//					Text = a.GetType ().Name,
//				};
//				button.Clicked += delegate {
//					
//				};

				var label = new Label {
					Text = a.GetType ().Name,
				};

				MainView.AddChild (label, labelLayout);
				MainView.AddChild (view, appLayout);
			}
		}
	}
}

