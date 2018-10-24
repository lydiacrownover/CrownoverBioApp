using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrownoverBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
       public ObservableCollection<string> Skills { get; set; }

		public SkillsPage ()
		{
			InitializeComponent ();

            this.Skills = new ObservableCollection<string>();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(skillEntry.Text))
            {
                DisplayAlert("Error", "Please Enter Skill", "Ok");
                return;
            }
            this.Skills.Add(skillEntry.Text);

            skillEntry.Text = "";

            skillsListView.ItemsSource = this.Skills;
        }
    }
}