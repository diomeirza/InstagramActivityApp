using InstagramApp.Interfaces;
using InstagramApp.Models;
using InstagramApp.Services;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstagramMainPage : ContentPage
    {
        private IActivity _activityService;
        private List<Activity> _activities;
        public InstagramMainPage()
        {
            _activityService = new ActivityService();
            _activities = _activityService.GetActivities();
            InitializeComponent();

            ListActivity.ItemsSource = _activities;
        }

        private async void Activity_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var activity = e.SelectedItem as Activity;
            ListActivity.SelectedItem = null;
            await Navigation.PushAsync(new UserProfilePage(activity.UserId));
        }
    }
}