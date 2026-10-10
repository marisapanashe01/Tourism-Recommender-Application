using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToursmApp3.ViewModels;
using Xamarin.Essentials;

namespace ToursmApp3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IconicMonumentsPage : ContentPage
    {
        public IconicMonumentsPage()
        {
            InitializeComponent();
            BindingContext = new IconicMonumentsViewModel(); // Ensure you have a ViewModel set up
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

