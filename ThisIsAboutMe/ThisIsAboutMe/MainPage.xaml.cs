﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ThisIsAboutMe
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_ClickedSkills(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void Button_ClickedContactMe(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new ContactPage());
        }

        private void Button_ClickedAboutMe(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMe());
        }
    }
}
