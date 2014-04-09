using System.Windows;
using Last.fm.API;
using Last.fm.ViewModel;
using Microsoft.Phone.Controls;

namespace Last.fm.Views
{
    public partial class Login : PhoneApplicationPage
    {
        public LoginPageViewModel LoginPageViewModel { get; set; }
        public string test { get; set; }

        public string LoginTest { get; set; }

        public Login()
        {
            test = "qwe";
            InitializeComponent();
            LoginPageViewModel = new LoginPageViewModel();
          //  DataContext = LoginPageViewModel;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var auth = new Auth();
            auth.Authentication();
        }
    }
}