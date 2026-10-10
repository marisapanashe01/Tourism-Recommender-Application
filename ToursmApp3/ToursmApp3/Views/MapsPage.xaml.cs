using System;
using ToursmApp3.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using ToursmApp3.ViewModels;

namespace ToursmApp3.Views
{
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();
            BindingContext = new MapsViewModel(); // Ensure you have a ViewModel set up
        }

        private async void OnViewMapClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var location = button.CommandParameter.ToString();

            // Open the location in Google Maps or default browser
            var uri = $"https://www.google.com/maps/search/?api=1&query={location}";
            await Launcher.OpenAsync(uri);
        }
    }
}