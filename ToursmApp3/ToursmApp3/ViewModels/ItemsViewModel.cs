using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Diagnostics;
using System.Threading.Tasks;
using ToursmApp3.Models;
using ToursmApp3.Views;
using Xamarin.Forms;
using ToursmApp3.Database;
using System.ComponentModel;

namespace ToursmApp3.ViewModels
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseHelper _databaseHelper;
        public ObservableCollection<Item> Items { get; set; }
        public ICommand LoadItemsCommand { get; }
        public ICommand AddItemCommand { get; }
        public ICommand ItemTapped { get; }

        private bool _isBusy; // Backing field for IsBusy
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy)); // Notify property change
            }
        }

        public ItemsViewModel()
        {
            _databaseHelper = new DatabaseHelper();
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await LoadItems());
            AddItemCommand = new Command(async () => await AddItem());
            ItemTapped = new Command<Item>(OnItemTapped);
        }

        public async Task LoadItems()
        {
            IsBusy = true; // Set IsBusy to true
            var items = await _databaseHelper.GetItemsAsync();
            Items.Clear();
            foreach (var item in items)
            {
                Items.Add(item);
            }
            IsBusy = false; // Set IsBusy to false after loading
        }

        public async void OnAppearing()
        {
            await LoadItems(); // Call LoadItems when the page appears
        }

        private async Task AddItem()
        {
            var newItem = new Item { Text = "New Item", Description = "Description of new item" };
            await _databaseHelper.SaveItemAsync(newItem);
            await LoadItems(); // Refresh the list
        }

        private void OnItemTapped(Item item)
        {
            // Handle item tapped
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}