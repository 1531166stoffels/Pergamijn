using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pergamijn_4
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();


            BtnAanbevolen.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Aanbevolen());
            };

            BtnFavorieten.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                await Navigation.PushAsync(new Favorieten());
            };

            BtnTV.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Live_TV_1());
            };

            BtnInstellingen.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Login_Instellingen());
            };
        }
	}
}
