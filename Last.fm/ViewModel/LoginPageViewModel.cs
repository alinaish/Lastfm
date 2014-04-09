using System;
using System.IO.IsolatedStorage;
using System.Net;
using Last.fm.Utils;

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

        //public void GetSession()
        //{
        //    var requestParams = new RequestParameters("auth.getMobileSession");
        //    requestParams.Add("username", _login);
        //    requestParams.Add("password",_password);

        //    var apiSig = ApiSigCreator.CreateApiKey(requestParams);
        //    requestParams.Add("api_key", IsolatedStorageSettings.ApplicationSettings["api_key"] as string);
        //    requestParams.Add("secret", IsolatedStorageSettings.ApplicationSettings["secret"] as string);
        //    requestParams.Add("api_sig", apiSig);

        //    GetAuth(requestParams);
        //}

        private void GetAuth(RequestParameters parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://ws.audioscrobbler.com/2.0/");
            request.Method = "POST";

            var bytesPayload = parameters.ToBytes();

            request.ContentLength = bytesPayload.Length;
            request.BeginGetResponse(GetRequestStreamCallback, request);
        }

        private void GetRequestStreamCallback(IAsyncResult ar)
        {
            throw new NotImplementedException();
        }
    }
}
