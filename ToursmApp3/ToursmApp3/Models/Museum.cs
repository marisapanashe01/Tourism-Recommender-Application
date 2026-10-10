using System;
using System.Collections.Generic;
using System.Text;

namespace ToursmApp3.Models
{
    public class Museum
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string Location { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ImageSource { get; set; }
        public string Directions { get; set; }
        public List<string> GalleryImages { get; set; } // List of images to showcase
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