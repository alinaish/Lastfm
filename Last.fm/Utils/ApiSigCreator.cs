using System.IO.IsolatedStorage;
using System.Text;

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
