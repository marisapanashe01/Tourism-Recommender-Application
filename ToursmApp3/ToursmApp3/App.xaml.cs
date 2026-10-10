using ToursmApp3.Services;
using ToursmApp3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ToursmApp3
{
    public partial class App : Application
    {
        private readonly FavoritesService _favoritesService;

        public App()
        {
            InitializeComponent();

            // Register your services here
            DependencyService.Register<MockDataStore>();

            // Create a single instance of FavoritesService
            _favoritesService = new FavoritesService();

            // Set the MainPage to the AppShell and pass the FavoritesService as needed
            MainPage = new AppShell(); // Make sure AppShell handles navigation correctly
        }

        protected override void OnStart()
        {
            // Check for user-preferred culture and set it
            if (Application.Current.Properties.ContainsKey("UserCulture"))
            {
                var userCulture = Application.Current.Properties["UserCulture"].ToString();
                Localization.SetCulture(userCulture);
            }
            else
            {
                // Default to English if no user preference is set
                Localization.SetCulture("en");
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}