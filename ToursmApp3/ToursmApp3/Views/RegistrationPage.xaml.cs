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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text; // Assuming you have named the Entry for username
            
            string password = passwordEntry.Text; // Assuming you have named the Entry for password

            // Basic validation
            if (string.IsNullOrEmpty(username) ||  string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }

            // Check for existing username
            if (UserRepository.RegisteredUsers.Exists(u => u.Username == username))
            {
                await DisplayAlert("Error", "Username already exists. Please choose another.", "OK");
                return;
            }

            // Add new user to the repository
            UserRepository.RegisteredUsers.Add(new UserRepository.User { Username = username, Password = password });

            // Registration success message
            await DisplayAlert("Success", "Registration successful!", "OK");
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}