using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeffWilcox.Utilities.Silverlight;

namespace Last.fm.Utils
{
    public class ApiSigCreator
    {
        //TODO: remove this, get api_key from storage
        private static string apiKey = "ebeab87ba9e90909edf2db7e701ddd8b";
        private static string secret = "eeebd49f0674043c4ccbfff247eb3906";

        public static string CreateApiKey(RequestParameters parameters)
        {
            var sb = new StringBuilder();

            sb.Append("apikey" + apiKey);
            sb.Append("method" + parameters["method"]);
            sb.Append("username" + parameters["username"]);
            sb.Append("password" + parameters["password"]);
            sb.Append("secret" + secret);


            return MD5CryptoServiceProvider.GetMd5String(sb.ToString());
        }
    }
}
