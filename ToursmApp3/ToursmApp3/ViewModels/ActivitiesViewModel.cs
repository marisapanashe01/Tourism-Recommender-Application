using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ToursmApp3.Models;

namespace ToursmApp3.ViewModels
{
    public class ActivitiesViewModel
    {
        public ObservableCollection<Activity> Activities { get; set; }

        public ActivitiesViewModel()
        {
            Activities = new ObservableCollection<Activity>
            {
                new Activity
                {
                    Title = "Victoria Falls Adventure",
                    Description = "Experience the majestic Victoria Falls with guided tours.",
                    Location = "Victoria Falls",
                    EventTime = DateTime.Now.AddDays(2),
                    ContactPhone = "+263 784 773 590",
                    ContactEmail = "info@victoriafalls.com",
                    Status = "Upcoming",
                    ImageSource = "vicfalls_adventure.jpg" // image URL
                },
                new Activity
                {
                    Title = "Hwange National Park Safari",
                    Description = "Join a safari tour in Hwange to see elephants and other wildlife.",
                    Location = "Hwange National Park",
                    EventTime = DateTime.Now.AddDays(-1),
                    ContactPhone = "+263 771 639 929",
                    ContactEmail = "safari@hwange.com",
                    Status = "Ended",
                    ImageSource = "hwange_safari.jpg" // image URL
                },
                 new Activity
                {
                    Title = "Great Zimbabwe Cultural Festival",
                    Description = "Celebrate the rich culture at the Great Zimbabwe ruins.",
                    Location = "Masvingo",
                    EventTime = DateTime.Now.AddHours(1),
                    ContactPhone = "+263 242 758 714",
                    ContactEmail = "info@greatzimbabwe.com",
                    Status = "Ongoing",
                    ImageSource = "gz_festival.jpg" // image URL
                },
            new Activity
                {
                    Title = "Zimbabwe Jazz Festival",
                    Description = "Get ready to groove to Sizzling Rythms at Zimbabwe Jazz Festival",
                    Location = "AllianceFrancaise Harare - 328 Herbet Chitepo Avenue",
                    EventTime = DateTime.Now.AddDays(16),
                    ContactPhone = "078 294 6551",
                    ContactEmail = "info@afcharare.com",
                    Status = "Upcoming",
                    ImageSource = "jazz_harare.jpg" // image URL
                },
                new Activity
                {
                    Title = "Victoria Falls Helicopter Ride",
                    Description = "Join a safari tour in Hwange to see elephants and other wildlife.",
                    Location = "Victoria Falls",
                    EventTime = DateTime.Now.AddDays(13),
                    ContactPhone = "+263 242 758 712",
                    ContactEmail = "info@vicfalls.com",
                    Status = "Upcoming",
                    ImageSource = "helicopter_ride.jpg" // image URL
                },
                new Activity
                {
                    Title = "Kariba Sunset Boat Cruise",
                    Description = "Cruise, Relax, and let the waves unwind you.",
                    Location = "Lake Kariba",
                    EventTime = DateTime.Now.AddDays(9),
                    ContactPhone = "+263 784 773 590",
                    ContactEmail = "info@lakekariba.com",
                    Status = "Upcoming",
                    ImageSource = "sunset_cruise.jpg" // image URL
                },
                new Activity
                {
                    Title = "Word Kalcha",
                    Description = "Poetry Lovers and Wordsmiths!Lets do it one more time.",
                    Location = "AllianceFrancaise Harare - 328 Herbet Chitepo Avenue",
                    EventTime = DateTime.Now.AddDays(-36),
                    ContactPhone = "0776 135 179",
                    ContactEmail = "info@afcharare.com",
                    Status = "Ended",
                    ImageSource = "word_kalcha.jpg" // image URL
                },
                new Activity
                {
                    Title = "Elephant Riding",
                    Description = "Join a safari tour in Hwange to see elephants and get to ride them.",
                    Location = "Hwange National Park",
                    EventTime = DateTime.Now.AddDays(3),
                    ContactPhone = "+263 750 409",
                    ContactEmail = "safari@hwange.com",
                    Status = "Upcoming",
                    ImageSource = "elephant_ride.jpg" // image URL
                }
            };
               
        }
    }
}