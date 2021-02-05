using InstagramApp.Interfaces;
using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstagramApp.Services
{
    class UserService : IUser
    {
        private List<User> _users;
        private readonly string imgSource = "https://loremflickr.com/100/100/";
        public UserService()
        {
            _users = new List<User>
            {
                new User { Id = 1, Name = "Jenny", Description = "My name is Jenny Blackpink", ImageUrl = String.Format("{0}{1}",imgSource,1) },
                new User { Id = 2, Name = "Rose", Description = "My name is Rose Blackpink", ImageUrl = String.Format("{0}{1}",imgSource,2) },
                new User { Id = 3, Name = "Jisoo", Description = "My name is Jisoo Blackpink", ImageUrl = String.Format("{0}{1}",imgSource,3) },
                new User { Id = 4, Name = "Lisa", Description = "My name is Lisa Blackpink", ImageUrl = String.Format("{0}{1}",imgSource,4) },
                new User { Id = 5, Name = "Sana", Description = "My name is Sana Blackpink", ImageUrl = String.Format("{0}{1}",imgSource,5) }
            };
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public User GetUser(int id)
        {
            return _users.Where(x => x.Id == id).First<User>();
        }
    }
}
