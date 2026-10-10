using ToursmApp3.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToursmApp3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritesPage : ContentPage
    {
        private FavoritesService _favoritesService;

        // Parameterless constructor for XAML
        public FavoritesPage()
        {
            InitializeComponent();
            _favoritesService = new FavoritesService(); // Create a new instance (not ideal for single instance)
            BindingContext = _favoritesService;
        }

        // Constructor that accepts FavoritesService
        public FavoritesPage(FavoritesService favoritesService)
        {
            InitializeComponent();
            _favoritesService = favoritesService;
            BindingContext = _favoritesService; // Set the binding context
        }
    }
}