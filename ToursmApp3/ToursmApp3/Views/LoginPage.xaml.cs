using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToursmApp3.Services;

namespace ToursmApp3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text; // Entry named usernameEntry
            string password = passwordEntry.Text; // Entry named passwordEntry

            // Validate user credentials
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Please enter both username and password.", "OK");
                return;
            }

            var user = UserRepository.RegisteredUsers.Find(u => u.Username == username);

            if (user == null)
            {
                await DisplayAlert("Error", "Username not found. Please register first.", "OK");
                return;
            }

            if (user.Password != password)
            {
                await DisplayAlert("Error", "Incorrect password. Please try again.", "OK");
                return;
            }

            // Proceed to the next page after successful login
            await Shell.Current.GoToAsync("//HomePage"); // Adjust as needed
        }

        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//RegistrationPage");
        }
    }
}