using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ToursmApp3.ViewModels
{
    public class BookingPageViewModel
    {
        public ICommand OpenRidaApp => new Command(async () =>
        {
            var ridaAppUrl = "rida://"; // URL scheme for Rida app
            var ridaWebUrl = "https://play.google.com/store/apps/details?id=com.rida"; // Fallback to Play Store

            await OpenAppOrWebsite(ridaAppUrl, ridaWebUrl);
        });

        public ICommand OpenInDriveApp => new Command(async () =>
        {
            var inDriveAppUrl = "indrive://"; // URL scheme for InDrive app
            var inDriveWebUrl = "https://play.google.com/store/apps/details?id=com.indrive"; // Fallback to Play Store

            await OpenAppOrWebsite(inDriveAppUrl, inDriveWebUrl);
        });

        private async Task OpenAppOrWebsite(string appUrl, string webUrl)
        {
            try
            {
                // Attempt to open the app
                await Launcher.OpenAsync(appUrl);
            }
            catch
            {
                // If the app is not installed, open the web URL
                await Launcher.OpenAsync(webUrl);
            }
        }

        public ICommand OpenBookingDotCom => new Command(async () =>
        {
            await Launcher.OpenAsync("https://www.booking.com");
        });

        public ICommand OpenTripAdvisor => new Command(async () =>
        {
            await Launcher.OpenAsync("https://www.tripadvisor.com");
        });

        public ICommand OpenAirbnb => new Command(async () =>
        {
            await Launcher.OpenAsync("https://www.airbnb.com");
        });
    }
}