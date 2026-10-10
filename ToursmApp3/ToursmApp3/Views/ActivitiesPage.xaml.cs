using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToursmApp3.ViewModels;
using ToursmApp3.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToursmApp3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivitiesPage : ContentPage
    {
        public ActivitiesPage()
        {
            InitializeComponent();
            BindingContext = new ActivitiesViewModel(); // Set the ViewModel
        }
    }
}