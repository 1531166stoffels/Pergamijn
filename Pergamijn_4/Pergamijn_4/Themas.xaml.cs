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
	public partial class Themas : ContentPage
	{
		public Themas ()
		{
			InitializeComponent ();

            BtnThema1.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Let op!", "De applicatie moet opnieuw worden opgestart.", "OK");

            };
            BtnThema2.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Let op!", "De applicatie moet opnieuw worden opgestart.", "OK");

            };

            BtnThema3.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Let op!", "De applicatie moet opnieuw worden opgestart.", "OK");

            };
        }
	}
}