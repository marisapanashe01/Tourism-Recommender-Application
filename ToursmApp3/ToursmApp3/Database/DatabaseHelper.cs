using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Essentials;
using ToursmApp3;
using ToursmApp3.Models;

namespace ToursmApp3.Database
{
    public class DatabaseHelper
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseHelper()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "items.db");
            _database = new SQLiteAsyncConnection(databasePath);
            _database.CreateTableAsync<Item>().Wait(); // Create table for Item
        }

        public Task<List<Item>> GetItemsAsync()
        {
            return _database.Table<Item>().ToListAsync();
        }

        public Task<int> SaveItemAsync(Item item)
        {
            return _database.InsertAsync(item);
        }

        public Task<int> DeleteItemAsync(Item item)
        {
            return _database.DeleteAsync(item);
        }
    }
}