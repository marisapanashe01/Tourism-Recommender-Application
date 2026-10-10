using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ToursmApp3.ViewModels;
using Xamarin.Forms;

namespace ToursmApp3.Services
{
    public class FavoritesService
    {
        public ObservableCollection<TouristDestination> Favorites { get; private set; }

        public FavoritesService()
        {
            Favorites = new ObservableCollection<TouristDestination>();
        }
    }
}