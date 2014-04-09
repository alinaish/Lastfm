using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeffWilcox.Utilities.Silverlight;

namespace Last.fm.Utils
{
    public class ApiSigCreator
    {
        public static string CreateApiKey(RequestParameters parameters)
        {
            var sb = new StringBuilder();

            sb.Append("apikey" + IsolatedStorageSettings.ApplicationSettings["api_key"]);
            sb.Append("method" + parameters["method"]);
            sb.Append("username" + parameters["username"]);
            sb.Append("password" + parameters["password"]);
            sb.Append("secret" + IsolatedStorageSettings.ApplicationSettings["secret"]);


            return MD5CryptoServiceProvider.GetMd5String(sb.ToString());
        }
    }
}
