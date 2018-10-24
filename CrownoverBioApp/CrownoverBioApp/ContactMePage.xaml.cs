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
	public partial class ContactMePage : ContentPage
	{
		public ContactMePage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        { 
            if(string.IsNullOrEmpty(nameEntry.Text)) 
            {
                DisplayAlert("Error", "Please Enter Name", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Please Enter Email", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(numberEntry.Text))
            {
                DisplayAlert("Error", "Please Enter Phone Number", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(messageEditor.Text))
            {
                DisplayAlert("Error", "Please Create a Message", "Ok");
                return;
            }
            DisplayAlert("Title","Message Here", "Okay");
        }
    }
}