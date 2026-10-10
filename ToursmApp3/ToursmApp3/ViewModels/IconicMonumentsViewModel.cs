using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ToursmApp3.Models;

namespace ToursmApp3.ViewModels
{
    public class IconicMonumentsViewModel
    {
        public ObservableCollection<Monument> Monuments { get; set; }

        public IconicMonumentsViewModel()
        {
            Monuments = new ObservableCollection<Monument>
            {
                new Monument
                {
                    Name = "National Heroes Acre",
                    Description = "Zimbabwes National Heroes Memorial Park",
                    History = "National Heroes' Acre or simply Heroes' Acre is a burial ground and national monument in Harare, Zimbabwe. The 23-hectare (57-acre) site is situated on a ridge seven kilometres from Harare, towards Norton. Its stated purpose is to commemorate Patriotic Front guerrillas killed during the Rhodesian Bush War, and contemporary Zimbabweans whose dedication or commitment to their country justify their interment at the shrine. People buried here are considered heroes by the incumbent Zimbabwe African National Union – Patriotic Front regime, which has administered the country since independence at 1980.[1] Indeed, most of the recipients of the 'hero status' were known to be Zanu-PF sympathisers.[2]\r\n\r\nThe actual monument itself is modeled after two AK-47s lying back-to-back; the graves are meant to resemble their magazines.[3][4] It closely mirrors the design of the Revolutionary Martyrs' Cemetery in Taesong-guyŏk, just outside Pyongyang, North Korea.[5]\r\n\r\nThe monument is an early example of work of the North Korean firm Mansudae Overseas Projects, which went on to construct a similar cemetery in Namibia, Heroes' Acre.[6]",
                    ContactPhone = "+263 4277965",
                    ContactEmail = "info@nationalheroes.co.zw",
                    Directions = "Street, Warren Park, Harare",
                    Location = "Harare, Zimbabwe",
                    ImageSource = "monu_main.jpg"
                },
                new Monument
                {
                    Name = "Great Zimbabwe Ruins",
                    Description = "The largest ancient stone structure in sub-Saharan Africa.",
                    History = "Great Zimbabwe is a medieval city in the south-eastern hills of the modern country of Zimbabwe, near Lake Mutirikwe and the town of Masvingo. It was the capital of the Kingdom of Zimbabwe from the 13th century, having been settled in the 4th century AD.[1] Construction on the city began in the 11th century and continued until it was abandoned in the 15th century.[2][3][4] The edifices were erected by ancestors of the Shona people, currently located in Zimbabwe and nearby countries.[5] The stone city spans an area of 7.22 square kilometres (2.79 sq mi) and could have housed up to 18,000 people at its peak, giving it a population density of approximately 2,500 inhabitants per square kilometre (6,500/sq mi). It is recognised as a World Heritage Site by UNESCO.\r\n\r\nGreat Zimbabwe is believed to have served as a royal palace for the local monarch. As such, it would have been used as the seat of political power. Among the edifice's most prominent features were its walls, some of which are 11 metres (36 ft) high.[5] They were constructed of \"dry stone\" (that is, without mortar). Eventually, the city was abandoned and fell into ruin.",
                    ContactPhone = "+263 77539 8917",
                    ContactEmail = "info@greatzimruins.co.zw",
                    Directions = "Masvingo, Masvingo Province",
                    Location = "Masvingo, Zimbabwe",
                    ImageSource = "monu_gz.jpg"
                },
                 new Monument
                {
                    Name = "Victoria Falls",
                    Description = "It is one of the world's largest waterfalls",
                    History = "Victoria Falls (Lozi: Mosi-oa-Tunya, \"Thundering Smoke\"; Tonga: Shungu Namutitima, \"Boiling Water\") is a waterfall on the Zambezi River, located on the border between Zambia and Zimbabwe.[2] It is one of the world's largest waterfalls, with a width of 1,708 m (5,604 ft). The region around it is inhabited by several species of plants and animals.\r\n\r\nArchaeology and oral history describe a long record of African knowledge of the site. Although known to some European geographers before the 19th century, Scottish missionary David Livingstone identified the falls in 1855, naming them Victoria Falls after Queen Victoria. Since the mid-20th century, the site has been a major tourist destination. Zambia and Zimbabwe both have national parks and tourism infrastructure at the site. Research in the late 2010s found that precipitation variability due to climate change is likely to alter the character of the falls.",
                    ContactPhone = "+263 77 229 2502",
                    ContactEmail = "info@vicfalls.co.zw",
                    Directions = "Masvingo, Matebeleland North",
                    Location = "Victoria Falls, Zimbabwe",
                    ImageSource = "monu_vicfalls.jpg"
                },
                // Add more monuments here
            };
        }
    }
}