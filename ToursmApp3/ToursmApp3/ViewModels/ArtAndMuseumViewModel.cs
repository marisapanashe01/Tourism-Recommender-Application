using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ToursmApp3.Models;

namespace ToursmApp3.ViewModels
{
    public class ArtAndMuseumViewModel
    {
        public ObservableCollection<ArtGallery> ArtGalleries { get; set; }
        public ObservableCollection<Museum> Museums { get; set; }

        public ArtAndMuseumViewModel()
        {
            ArtGalleries = new ObservableCollection<ArtGallery>
            {
                new ArtGallery
                {
                    Name = "National Gallery of Zimbabwe",
                    Description = "Founded in 1957, it showcases Zimbabwean art.",
                    History = "The National Gallery of Zimbabwe (NGZ) is a gallery in Harare, Zimbabwe, dedicated to the presentation and conservation of Zimbabwe's contemporary art and visual heritage. The original National Gallery of Rhodesia was designed and directed by Frank McEwen, a British citizen credited with bringing Shona Sculpture to the spotlight.[1] The Gallery was officially opened by Queen Elizabeth The Queen Mother on July 16, 1957, and Queen Elizabeth II attended the sixth Zimbabwe Heritage Exhibition there in October 1991.",
                    Location = "Harare",
                    ContactPhone = "+263 4 704 666",
                    ContactEmail = "info@ngz.co.zw",
                    Directions = "Julius Nyerere Way, Central Business District, Harare",
                    ImageSource = "ngz_main.jpg",
                    GalleryImages = new List<string>
                    {
                        "ngz1.jpg",
                        "ngz2.jpg",
                        "ngz3.jpg",
                        "ngz4.jpg"
                    }
                },
                new ArtGallery
                {
                    Name = "Mutare National Art Gallery of Zimbabwe",
                    Description = "A leading institution for contemporary art in the heart of Mutare.",
                    History = "The National Gallery of Zimbabwe in Mutare was opened in 1999 at Kopje House, a historical building built in 1897 and the first hospital in Mutare. It was declared a Monument in the late 1970s and thereafter became a Culture House under the custody of the National Museums and Monuments.",
                    Location = "Mutare",
                    ContactPhone = "+263 784 773 590",
                    ContactEmail = "info@ngz.co.zw",
                    Directions = "Herbert Chitepo Street,Eleventh Avenue, Kopje House,No. 122 on the corner of Third Street and Eleventh Avenue",
                    ImageSource = "mng_main.jpg",
                    GalleryImages = new List<string>
                    {
                        "mng1.jpg",
                        "mng2.jpg",
                        "mng3.jpg",
                        "mng4.jpg"
                    }
                },

                // Add more galleries here
            };

            Museums = new ObservableCollection<Museum>
            {
                new Museum
                {
                    Name = "Zimbabwe Museum of Human Sciences",
                    Description = "Established to preserve the heritage of Zimbabwe.",
                    History = "The Zimbabwe Museum of Human Sciences, formerly the Queen Victoria Museum, is a museum in Harare, Zimbabwe. The museum contains the seven-hundred-year-old Lemba artifact Ngoma Lungundu, which some believe to be a replica of the Ark of the Covenant. It is the oldest wooden object ever found in sub-Saharan Africa. The “ngoma lungundu” belongs to the Lemba people – black Africans who claim Jewish ancestry. They say the vessel was built almost 700 years ago from the remains of the original Ark, which the Bible says was used to store Moses’ 10 Commandments. The Zimbabwe Museum of Human Sciences is located 5km from the city center.",
                    Location = "Harare",
                    ContactPhone = "+263 4751 7978",
                    ContactEmail = "info@zmhs.co.zw",
                    Directions = "Street, Central Business District, Harare",
                    ImageSource = "mhs_main.jpg",
                    GalleryImages = new List<string>
                    {
                        "mhs1.jpg",
                        "mhs2.jpg",
                        "mhs3.jpg",
                        "mhs4.jpg",
                        "mhs5.jpg"
                    }
                },
                new Museum
                {
                    Name = "Mutare Museum of Arts, Craft and Culture",
                    Description = "A museum dedicated to the history of humanity.",
                    History = "Mutare Museum was initially established by local enthusiasts as the Umtali Museum Society in 1954, before becoming a National Museum in 1959 and will always be indebted for its most spectacular collection of vintage cars, motorbikes and wagons, coaches and steam engines donated to the Museum by local enthusiastic collectors and the first Honorary Curator, Captain E. F. Boultbee.",
                    Location = "Mutare",
                    ContactPhone = "+263 2063630",
                    ContactEmail = "info@mutaremuseum.co.zw",
                    Directions = "Aerodrome Road, CBD, Manicaland",
                    ImageSource = "mm_main.jpg",
                    GalleryImages = new List<string>
                    {
                        "mm1.jpg",
                        "mm2.jpg",
                        "mm3.jpg"
                    }
                },
                // Add more museums here
            };
        }
    }
}