﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinLayoutsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void ScrollviewPageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            // This is to make the Scrollview page the root page. (No back arrow in navbar)
            //Application.Current.MainPage = new NavigationPage(new ScrollviewPage());

            // This is to add the Scrollview page to the Navigation Stack (Adds a back arrow in navbar)
            await Navigation.PushAsync(new ScrollviewPage());
            
        }
    }
}