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
	public partial class Accounts : ContentPage
	{
		public Accounts ()
		{
			InitializeComponent ();

            BtnYoutube.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                await Navigation.PushAsync(new Youtube());
            };

            BtnNetflix.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                await Navigation.PushAsync(new Netflix());
            };

            BtnZiggo.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                await Navigation.PushAsync(new Ziggo());
            };
        }
	}
}