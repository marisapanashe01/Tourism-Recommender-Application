using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ToursmApp3.ViewModels
{
    public class HomePageViewModel
    {
        public ObservableCollection<Destination> Destinations { get; set; }
        public ObservableCollection<Activity> Activities { get; set; }

        public HomePageViewModel()
        {
            Destinations = new ObservableCollection<Destination>
            {
                new Destination { ImageSource = "home_vicfalls.jpg", Name = "Victoria Falls", Description = "Overview:\r\nVictoria Falls, known locally as Mosi-oa-Tunya or \"The Smoke That Thunders,\" is one of the largest and most famous waterfalls in the world. Located on the border between Zambia and Zimbabwe, it measures about 1,708 meters (5,604 feet) wide and plunges over 100 meters (328 feet) into the Zambezi River gorge. The falls create a breathtaking spectacle, producing a mist that can be seen from miles away." },
                new Destination { ImageSource = "home_hwange.jpg", Name = "Hwange National Park", Description = "Overview:\r\nHwange National Park is Zimbabwe's largest national park, covering over 14,600 square kilometers (5,600 square miles). It is renowned for its large elephant population, estimated at over 50,000, and serves as an important conservation area for a variety of wildlife species." },
                new Destination { ImageSource = "home_gz.jpg", Name = "Great Zimbabwe", Description = "Overview:\r\nGreat Zimbabwe is a UNESCO World Heritage Site and the largest ancient stone structure in sub-Saharan Africa. This historical site was the capital of the Kingdom of Zimbabwe during the Late Iron Age (11th to 15th centuries) and is famous for its impressive stone ruins, including the Great Enclosure and the Hill Complex." }
            };

            Activities = new ObservableCollection<Activity>
            {
                new Activity { ImageSource = "home_safari.jpg", Name = "Safari Adventure", Description = "Overview:\r\nSafari adventures are a quintessential experience in Zimbabwe, allowing tourists to immerse themselves in the diverse wildlife and landscapes of the region.\r\n\r\nKey Features:\r\n\r\nGame Drives: Both day and night game drives are available, providing opportunities to see nocturnal animals and predators.\r\nGuided Walks: Walking safaris offer a unique perspective on the ecosystem, focusing on smaller wildlife and plant life.\r\nPhotography: Safaris are excellent for wildlife photography, with opportunities to capture stunning landscapes and animals in their natural habitats." },
                new Activity { ImageSource = "home_culturaltour.jpg", Name = "Cultural Tours", Description = "Overview:\r\nCultural tours provide insights into the rich traditions and heritage of Zimbabwean communities, enabling tourists to connect with local cultures.\r\n\r\nKey Features:\r\n\r\nVillage Visits: Tourists can visit local villages to experience traditional lifestyles, crafts, and cuisine.\r\nDance and Music: Cultural performances, including traditional dances and music, showcase the vibrant heritage of the people.\r\nArt and Craft: Opportunities to purchase handmade crafts and artworks directly from local artisans support the community and promote sustainable tourism." },
                new Activity { ImageSource = "home_fishing.jpg", Name = "Fishing at Lake Kariba", Description = "Overview:\r\nLake Kariba, one of the largest man-made lakes in the world, is a prime destination for fishing enthusiasts, offering a variety of fish species and stunning scenery.\r\n\r\nKey Features:\r\n\r\nFishing Species: The lake is home to species such as tiger fish, bream, and catfish, attracting anglers from around the globe.\r\nCharter Boats: Visitors can hire fishing charters for guided fishing trips, providing access to the best fishing spots.\r\nScenic Views: Fishing trips often include opportunities to enjoy breathtaking sunsets over the lake and view wildlife along the shores." }
            };
        }
    }

    public class Destination
    {
        public string ImageSource { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Activity
    {
        public string ImageSource { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; internal set; }
        public string Location { get; internal set; }
        public DateTime EventTime { get; internal set; }
        public string ContactPhone { get; internal set; }
        public string ContactEmail { get; internal set; }
        public string Status { get; internal set; }
    }
}