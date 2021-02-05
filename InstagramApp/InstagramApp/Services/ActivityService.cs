using InstagramApp.Interfaces;
using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Services
{
    class ActivityService : IActivity
    {
        private List<Activity> _activities;
        private readonly string imgSource = "https://loremflickr.com/100/100/";

        public ActivityService()
        {
            _activities = new List<Activity>
            {
                new Activity { UserId = 1, Description = "Your facebook friend Jenny is on instagram", ImageUrl = String.Format("{0}{1}",imgSource,1) },
                new Activity { UserId = 2, Description = "Rose started following you", ImageUrl = String.Format("{0}{1}",imgSource,2) },
                new Activity { UserId = 3, Description = "Your facebook friend Jisoo is on instagram", ImageUrl = String.Format("{0}{1}",imgSource,3) },
                new Activity { UserId = 4, Description = "Lisa started following you", ImageUrl = String.Format("{0}{1}",imgSource,4) },
                new Activity { UserId = 5, Description = "Your facebook friend Sana is on instagram", ImageUrl = String.Format("{0}{1}",imgSource,5) }
            };
        }

        public List<Activity> GetActivities()
        {
            return _activities;
        }
    }
}
