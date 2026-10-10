using System;
using System.Collections.Generic;
using System.ComponentModel;
using ToursmApp3.Models;
using ToursmApp3.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToursmApp3.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}