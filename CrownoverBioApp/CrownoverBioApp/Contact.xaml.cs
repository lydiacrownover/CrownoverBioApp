﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrownoverBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contact : ContentPage
	{
		public Contact ()
		{
			InitializeComponent ();
		}

        private void contactmeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactMePage());
        }
    }
}