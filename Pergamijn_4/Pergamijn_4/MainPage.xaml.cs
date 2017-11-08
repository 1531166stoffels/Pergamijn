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

            

        }
	}
}
