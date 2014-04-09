using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last.fm.ViewModel
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string _login;
        private string _password;

        public string Login 
        { 
            get
            {
                return _login;
            }
            set 
            { 
                _login = value; 
                OnPropertyChanged(); 
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value; 
                OnPropertyChanged();
            }
        }
    }
}
