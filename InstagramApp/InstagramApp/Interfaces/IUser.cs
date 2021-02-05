using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Interfaces
{
    interface IUser
    {
        List<User> GetUsers();
        User GetUser(int id);
    }
}
