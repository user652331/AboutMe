﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThisIsAboutMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageSent : ContentPage
    {
        public MessageSent()
        {
            InitializeComponent();
        }

        private void Button_ClickedBack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}