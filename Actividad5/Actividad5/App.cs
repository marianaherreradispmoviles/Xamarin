using System;
using Xamarin.Forms;

namespace Actividad5
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			ContentPage contentPage = new ContentPage();

			//Padding agrega un margen al contenido
			//Device.OnPlatform permite modificar este margen dependiendo de la plataforma IOS, Android y Windows Phone
			//Para saber más sobe Device.OnPlatform revisa 
			contentPage.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					new Label
					{
						Text = "Blue",
						TextColor = Color.Blue
					},
					new Label
					{
						Text = "Silver",
						TextColor = Color.Silver
					},
					new Label
					{
						Text = "Lime",
						TextColor = Color.Lime
					},
					new Label
					{
						Text = "Gray",
						TextColor = Color.Gray
					},
					new Label
					{
						Text = "Red",
						TextColor = Color.Red
					},
					new Label
					{
						Text = "Olive",
						TextColor = Color.Olive
					}
				}
			};

			contentPage.Content = stackLayout;
			return contentPage;
		}
	}
}

