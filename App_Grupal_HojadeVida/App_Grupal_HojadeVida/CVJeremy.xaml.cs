﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Grupal_HojadeVida
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CVJeremy : ContentPage
    {
        public CVJeremy()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalJeremy());
        }
    }
}