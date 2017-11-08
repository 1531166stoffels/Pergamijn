﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pergamijn_4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login_Instellingen : ContentPage
	{
		public Login_Instellingen ()
		{
			InitializeComponent ();

            BtnInstellingenLogin.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Instellingen());
            };
        }
	}
}