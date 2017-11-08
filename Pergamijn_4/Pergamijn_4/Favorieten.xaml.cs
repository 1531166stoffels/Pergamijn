using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pergamijn_4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Favorieten : ContentPage
	{
		public Favorieten ()
		{
			InitializeComponent ();

            BtnF1.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnF2.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnF3.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnF4.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnF5.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnF6.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnF7.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

          
        }
    }
}