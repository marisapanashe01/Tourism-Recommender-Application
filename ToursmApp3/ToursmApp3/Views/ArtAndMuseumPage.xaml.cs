using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToursmApp3.ViewModels;

namespace ToursmApp3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtAndMuseumPage : ContentPage
    {
        public ArtAndMuseumPage()
        {
            InitializeComponent();
            BindingContext = new ArtAndMuseumViewModel();
        }

        private async void OnViewGalleryClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var item = button.CommandParameter;

            // Implement logic to display the gallery images
            await DisplayAlert("Gallery", "Show gallery images here.", "OK");
        }
    }
}
