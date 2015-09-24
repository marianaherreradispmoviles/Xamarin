using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Hello, Forms!",
					VerticalOptions = LayoutOptions.Bottom,
					HorizontalOptions = LayoutOptions.Left,
					BackgroundColor = Color.Blue,
					TextColor = Color.Green
				},
			};
		}
	}
}
