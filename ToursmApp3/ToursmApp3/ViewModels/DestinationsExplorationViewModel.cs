using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using ToursmApp3.Services; // Ensure to include the FavoritesService namespace

namespace ToursmApp3.ViewModels
{
    public class DestinationsExplorationViewModel
    {
        public ObservableCollection<TouristDestination> Destinations { get; set; }
        private readonly FavoritesService _favoritesService;

        // Command to add a destination to favorites
        public ICommand AddToFavoritesCommand { get; }

        public DestinationsExplorationViewModel(FavoritesService favoritesService)
        {
            _favoritesService = favoritesService;

            // Initialize destinations collections
            Destinations = new ObservableCollection<TouristDestination>
            {
                // Initialize your destinations here
                new TouristDestination { ImageSource = "victoria_falls.jpg", Name = "Victoria Falls", Description = "One of the Seven Natural Wonders of the World." },
                new TouristDestination { ImageSource = "hwange_national_park.jpg", Name = "Hwange National Park", Description = "Home to diverse wildlife." },
                new TouristDestination { ImageSource = "great_zimbabwe.jpg", Name = "Great Zimbabwe", Description = "A UNESCO World Heritage Site." },
                 new TouristDestination { ImageSource = "lake_kariba.jpg", Name = "Lake Kariba", Description = "The largest man-made lake in the world." },
                new TouristDestination { ImageSource = "matobo_hills.jpg", Name = "Matobo Hills", Description = "Famous for its rock formations and wildlife." },
                new TouristDestination { ImageSource = "mana_pools.jpg", Name = "Mana Pools", Description = "Known for walking safaris and canoeing." },
                new TouristDestination { ImageSource = "binga.jpg", Name = "Binga", Description = "A scenic town on the shores of Lake Kariba." },
                new TouristDestination { ImageSource = "chimanimani.jpg", Name = "Chimanimani", Description = "Offers stunning mountain scenery and hiking." },
                new TouristDestination { ImageSource = "nyanga.jpg", Name = "Nyanga", Description = "Home to beautiful waterfalls and lush landscapes." },
                new TouristDestination { ImageSource = "khami.jpg", Name = "Khami Ruins", Description = "A mountainous region with diverse flora." },
                new TouristDestination { ImageSource = "xmass_pass.jpg", Name = "Christmas Pass", Description = "A scenic mountain pass with breathtaking views." },
                new TouristDestination { ImageSource = "vumba.jpg", Name = "Vumba", Description = "Known for its botanical gardens and views." },
                new TouristDestination { ImageSource = "zambezi.jpg", Name = "Zambezi River", Description = "The fourth-longest river in Africa." },
                new TouristDestination { ImageSource = "hwange.jpg", Name = "Hwange", Description = "Famous for elephants and natural beauty." },
                new TouristDestination { ImageSource = "kariba.jpg", Name = "Kariba", Description = "Known for fishing and water sports." },
                new TouristDestination { ImageSource = "chipinge.jpg", Name = "Chipinge", Description = "Famous for its tea plantations." },
                new TouristDestination { ImageSource = "masvingo.jpg", Name = "Masvingo", Description = "Home to ancient ruins." },
                new TouristDestination { ImageSource = "gweru.jpg", Name = "Gweru", Description = "Known for its historical significance." },
                new TouristDestination { ImageSource = "kwekwe.jpg", Name = "Kwekwe", Description = "Famous for gold mining." },
                new TouristDestination { ImageSource = "bikita.jpg", Name = "Bikita", Description = "Known for its beautiful scenery." },
                 new TouristDestination { ImageSource = "harare.jpg", Name = "Harare", Description = "Zimbabwes Capital City and Business Environment." },
                new TouristDestination { ImageSource = "mutare.jpg", Name = "Mutare", Description = "Known for its beautiful landscapes." }
                // Add other destinations...
            };

            // Initialize the command
            AddToFavoritesCommand = new Command<TouristDestination>(AddToFavorites);
        }

        public void AddToFavorites(TouristDestination destination)
        {
            if (destination != null && !_favoritesService.Favorites.Contains(destination))
            {
                _favoritesService.Favorites.Add(destination);
                // Show notification that destination was added
                Application.Current.MainPage.DisplayAlert("Success", $"{destination.Name} added to favorites!", "OK");
            }
            else
            {
                // Notify if the destination is already in favorites
                Application.Current.MainPage.DisplayAlert("Alert", $"{destination.Name} is already in favorites.", "OK");
            }
        }
    }

    public class TouristDestination
    {
        public string ImageSource { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}