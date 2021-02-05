using InstagramApp.Interfaces;
using InstagramApp.Models;
using InstagramApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserProfilePage : ContentPage
    {
        private IUser _userService;
        private User _user;
        public UserProfilePage(int userId)
        {
            _userService = new UserService();
            _user = _userService.GetUser(userId);
            InitializeComponent();

            BindingContext = _user;
        }
    }
}