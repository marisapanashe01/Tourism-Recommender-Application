using Xamarin.Forms;
using ToursmApp3.ViewModels;
using ToursmApp3.Services; // Make sure to include this namespace
using System.Linq;

namespace ToursmApp3.Views
{
    public partial class DestinationsExplorationPage : ContentPage
    {
        private FavoritesService _favoritesService;

        // Parameterless constructor for XAML
        public DestinationsExplorationPage()
        {
            InitializeComponent();
            // You can initialize a default FavoritesService here if needed
            _favoritesService = new FavoritesService();
            BindingContext = new DestinationsExplorationViewModel(_favoritesService);
        }

        // Constructor that accepts FavoritesService
        public DestinationsExplorationPage(FavoritesService favoritesService)
        {
            InitializeComponent();
            _favoritesService = favoritesService;
            BindingContext = new DestinationsExplorationViewModel(favoritesService);
        }

        // Example event handler for destination selection
        private async void OnDestinationSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is TouristDestination selectedDestination)
            {
                await DisplayAlert(selectedDestination.Name, selectedDestination.Description, "OK");
                ((CollectionView)sender).SelectedItem = null; // Deselect the item
            }
        }
    }
}