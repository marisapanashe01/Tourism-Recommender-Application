using System;
using System.Collections.Generic;
using System.Text;

namespace ToursmApp3.Services
{
    public static class UserRepository
    {
        public static List<User> RegisteredUsers { get; } = new List<User>();

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
