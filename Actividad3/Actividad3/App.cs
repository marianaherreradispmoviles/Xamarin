﻿using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Mariana Herrera Sánchez - Cuenta 412110971",
					TextColor = Color.Green,
					VerticalOptions = LayoutOptions.End,
					HorizontalOptions = LayoutOptions.Start,
				},
			};
		}
	}
}
