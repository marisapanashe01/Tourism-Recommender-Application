using System.Globalization;
using System.Resources;
using Xamarin.Forms;

namespace ToursmApp3.Services
{
    public static class Localization
    {
        private static ResourceManager resourceManager = new ResourceManager("ToursmApp3.Resources.values.Strings", typeof(Localization).Assembly);

        public static string GetString(string key)
        {
            return resourceManager.GetString(key, CultureInfo.CurrentCulture);
        }

        // Method to set both CurrentCulture and CurrentUICulture
        public static void SetCulture(string culture)
        {
            try
            {
                // Set the culture for both CurrentCulture and CurrentUICulture
                CultureInfo.CurrentCulture = new CultureInfo(culture);
                CultureInfo.CurrentUICulture = new CultureInfo(culture);
            }
            catch (CultureNotFoundException)
            {
                // Handle the exception if the culture is not valid
                // Optionally log or set a default culture
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; // Fallback
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture; // Fallback
            }
        }
    }
}