using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrownoverBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutMePage : ContentPage
	{
		public AboutMePage ()
		{
			InitializeComponent ();
		}

        private void Backbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}