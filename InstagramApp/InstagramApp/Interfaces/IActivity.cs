using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Interfaces
{
    interface IActivity
    {
        List<Activity> GetActivities();
    }
}
