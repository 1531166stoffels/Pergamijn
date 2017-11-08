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
	public partial class Aanbevolen : ContentPage
	{
        public Aanbevolen()
        {
            InitializeComponent();

            BtnA1.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA2.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA3.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA4.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA5.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA6.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA7.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA8.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA9.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA10.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA11.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

            BtnA12.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };

        }
	}
}