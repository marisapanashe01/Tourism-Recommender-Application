using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using ToursmApp3.ViewModels;
using ToursmApp3.Models;

namespace ToursmApp3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantsPage : ContentPage
    {
        public RestaurantsPage()
        {
            InitializeComponent();
            BindingContext = new RestaurantsViewModel();
        }

        private async void OnViewMapClicked(object sender, EventArgs e)
        {
            var restaurant = ((Button)sender).BindingContext as Restaurant;
            if (restaurant != null)
            {
                var location = $"{restaurant.Latitude},{restaurant.Longitude}";
                var uri = $"https://www.google.com/maps/search/?api=1&query={location}";
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
        }

        private void OnShowMenuClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var restaurant = button.BindingContext as Restaurant;

            // Find the MenuContainer within the button's parent
            var menuContainer = button.Parent.FindByName<StackLayout>("MenuContainer");

            if (menuContainer != null)
            {
                // Toggle the visibility of the menu container
                menuContainer.IsVisible = !menuContainer.IsVisible;
            }
        }
    }
}
