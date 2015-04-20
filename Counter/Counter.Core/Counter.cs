using System;
using NView.Controls;

namespace Counter
{
	public class Counter
	{
		public readonly Stack MainView = new Stack {
			Orientation = StackOrientation.Horizontal,
		};

		public readonly Label CountLabel = new Label { Text = "0" };
		public readonly Button IncrementButton = new Button { Text = "Count" };
		public readonly Button ResetButton = new Button { Text = "Reset" };

		public Counter ()
		{
			var labelLayout = new StackLayout {
				HorizontalAlignment = HorizontalAlignment.Left
			};
			var buttonLayout = new StackLayout {
				HorizontalAlignment = HorizontalAlignment.Right
			};

			MainView.AddChild (CountLabel, labelLayout);

			MainView.AddChild (IncrementButton, buttonLayout);
			MainView.AddChild (ResetButton, buttonLayout);
		}
	}
}

