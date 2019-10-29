using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThisIsAboutMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsPage : ContentPage


    {
        public ObservableCollection<string> ListingMySkills { get; set; }



        public SkillsPage()
        {
            InitializeComponent();

            this.ListingMySkills = new ObservableCollection<string>();

        }

        private void InputButton_Clicked(object sender, EventArgs e)
        {
            this.ListingMySkills.Add(InputAskill.Text);

            InputAskill.Text = "";

            SkillsListView.ItemsSource = this.ListingMySkills;
        }
    }
}