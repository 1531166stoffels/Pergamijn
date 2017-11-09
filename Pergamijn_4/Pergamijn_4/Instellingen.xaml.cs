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
	public partial class Instellingen : ContentPage
	{
		public Instellingen ()
		{
			InitializeComponent ();

            BtnAccounts.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Accounts());
            };

            BtnThemas.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Themas());
            };

            BtnRestricties.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Restricties());
            };

            BtnKids.Clicked += async (sender, args) =>
            {
                {
                    await DisplayAlert("Kids", "Kindemodus aanzetten?", "Ja", "Nee");
                    
                };
            };
        }
    }
	
}