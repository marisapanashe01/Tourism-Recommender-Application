using System;
using System.Collections.Generic;
using System.Text;

namespace ToursmApp3.Models
{
    public class Activity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set;  }
        public DateTime EventTime { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Status { get; set; } // "Past", "Ongoing", "Future"
        public string ImageSource { get; set; } // New property for image URL
    }
}
