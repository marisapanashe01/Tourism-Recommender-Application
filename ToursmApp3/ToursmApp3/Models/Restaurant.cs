using System;
using System.Collections.Generic;
using System.Text;

namespace ToursmApp3.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ImageSource { get; set; }
        public string Directions { get; set; }
        public string MenuImageSource { get; set; } // New property for menu image
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<string> MenuImages { get; set; } //List of image URLs
                                                     // Star rating as a string of emojis
        public string StarRating
        {
            get
            {
                int rating = 4; // Example rating
                return new string('⭐', rating); // Replace with actual rating logic
            }
        }
    }
}