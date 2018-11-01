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
            this.Skills.Add("HTML");
            this.Skills.Add("CSS");
            this.Skills.Add("Visual Basic");
            this.Skills.Add("Adobe Photoshop");
            this.Skills.Add("Adobe Illustrator");
            this.Skills.Add("Adobe InDesign");
            this.Skills.Add("Adobe XD");
            this.Skills.Add("Microsoft Suite"); 

            skillsListView.ItemsSource = this.Skills;
		}

        private void Backbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
    
}