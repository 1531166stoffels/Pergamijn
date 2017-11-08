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
	public partial class Live_TV_1 : ContentPage
	{
		public Live_TV_1 ()
		{
			InitializeComponent ();

            BtnTV1.Clicked += async (sender, AssemblyLoadEventArgs) =>
            {
                DisplayAlert("Netflix", "Video begint met afspelen", "OK");

            };
        }
	}
}