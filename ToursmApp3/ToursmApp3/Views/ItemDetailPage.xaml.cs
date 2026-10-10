using System.ComponentModel;
using ToursmApp3.ViewModels;
using Xamarin.Forms;

namespace ToursmApp3.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}