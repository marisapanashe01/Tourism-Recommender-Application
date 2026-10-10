using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ToursmApp3.Models;

namespace ToursmApp3.ViewModels
{
    public class MapsViewModel
    {
        public ObservableCollection<Maps> Maps { get; set; }

        public MapsViewModel()
        {
            Maps = new ObservableCollection<Maps>
            {
                new Maps
                {
                    Name = "Your next Adventure Awaits!",
                    Description = "Maps are more than just tools for navigation; they are gateways to discovery. Whether you're planning a trip, exploring new cities, or finding hidden gems in your local area, maps provide valuable insights into the world around you. They help you uncover attractions, restaurants, and points of interest, making your journey more enjoyable and enriching. With the right maps, you can navigate unfamiliar terrains with confidence and make the most of your adventures. Embrace the art of exploration and let maps guide you to your next unforgettable experience!\r\n\r\nUsing offline maps, make sure you have downloaded offline maps in your map application (e.g., Petal Maps). For more detailed and accurate location information, consider using online maps like Google Maps or connect to a network",
                    History = "Im the map!!!",
                    ContactPhone = "+263 4277965",
                    ContactEmail = "info@zim.co.zw",
                    Directions = "Street, Warren Park, Harare",
                    Location = "Zimbabwe, Africa",
                    ImageSource = "maps_main.jpg"
                },
                            };
        }
    }
}

