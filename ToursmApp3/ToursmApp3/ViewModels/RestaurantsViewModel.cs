using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToursmApp3.Models;

namespace ToursmApp3.ViewModels
{
    public class RestaurantsViewModel
    {
        public ObservableCollection<Restaurant> Restaurants { get; set; }

        public RestaurantsViewModel()
        {
            Restaurants = new ObservableCollection<Restaurant>
            {
                new Restaurant
                {
                    Name = "The Boma",
                    Description = "Are you planning to visit soon? It’s a fantastic experience with great food and lively entertainment!",
                    Location = "Victoria Falls",
                    ContactPhone = "+263 83 284 3206",
                    ContactEmail = "theboma.co.zw",
                    ImageSource = "boma_main.jpg", // image URL
                    Directions = "471 Squire Cummings Road, Victoria Falls",
                    MenuImages = new List<string> // to use a list of menu images
                    {
                        "boma_menu1.jpg",
                        "boma_menu2.jpg",
                        "boma_menu3.jpg"
                    },
                    Latitude = -17.908962593179847, 
                    Longitude = 25.8191377669834
                },
                new Restaurant
                {
                    Name = "Cafe Nush",
                    Description = "A hotel restaurant serving a variety of local and international dishes.",
                    Location = "Harare",
                    ContactPhone = "+263 78 247 0696",
                    ContactEmail = "info@cafenush.com",
                    ImageSource = "cafenush_main.jpg", // image URL
                    Directions = "King George Road Avondale Shopping Centre, Harare 1770 Zimbabwe",
                    MenuImages = new List<string>
                    {
                        "nush_menu1.jpg",
                        "nush_menu2.jpg",
                        "nush_menu3.jpg",
                        "nush_menu4.jpg",
                        "nush_menu5.jpg",
                        "nush_menu6.jpg"
                    },
                    Latitude = -17.80247073603715,
                    Longitude = 31.038636911004307
                },
                new Restaurant
                {
                    Name = "Miombo Mountain Lodge and Spa",
                    Description = "Miombo Safari Camp has the distinction of being the closest quality accommodation to Hwange National Park Main Gate & is located in the DETE annex, on a private concession within the eastern border of the Hwange National Park. ",
                    Location = "Harare",
                    ContactPhone = "+1 (646) 542 0667",
                    ContactEmail = "info@miombolodge.com",
                    ImageSource = "miombo_main.jpg", // image URL
                    Directions = "170 Km South of Vic Falls Airport, Near Derte,Hwange Zimbabwe.",
                    MenuImages = new List<string>
                    {
                        "miombo_menu1.jpg"
                    },
                    Latitude = -17.616265438104666,
                    Longitude = 30.994149482163564
                },
                new Restaurant
                {
                    Name = "3 Monkeys Restaurant",
                    Description = "A hotel restaurant serving a variety of local and international dishes.",
                    Location = "Harare",
                    ContactPhone = "+263 71 693 8368",
                    ContactEmail = "3monkeyszw.com",
                    ImageSource = "monkies_main.jpg", // image URL
                    Directions = "Honeydew Lifestyle Center, 16 Greendale Avenue, Harare",
                    MenuImages = new List<string>
                    {
                        "monkies_menu1.jpg",
                        "monkies_menu2.jpg",
                        "monkies_menu3.jpg",
                        "monkies_menu4.jpg",
                        "monkies_menu5.jpg"
                    },
                    Latitude = -17.826220740514017,
                    Longitude = 31.10179759566269 
                },
                // Add more restaurants here
            };

            // Group restaurants into pairs for carousel display (if needed)
            GroupedRestaurants = new ObservableCollection<ObservableCollection<Restaurant>>();
            for (int i = 0; i < Restaurants.Count; i += 2)
            {
                var pair = new ObservableCollection<Restaurant>();
                pair.Add(Restaurants[i]);
                if (i + 1 < Restaurants.Count)
                    pair.Add(Restaurants[i + 1]);
                GroupedRestaurants.Add(pair);
            }
        }

        public ObservableCollection<ObservableCollection<Restaurant>> GroupedRestaurants { get; set; }
    }
}