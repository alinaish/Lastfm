using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Last.fm.Requests;
using Last.fm.Utils;

namespace Last.fm.API
{
    class Auth
    {
        private Dictionary<string, string>  authParams;
        private string secret = "eeebd49f0674043c4ccbfff247eb3906";
        public Auth()
        {
            authParams = new Dictionary<string, string>();
            authParams.Add("api_key", "ebeab87ba9e90909edf2db7e701ddd8b");
            authParams.Add("password", "[ekbnennfrvfkj");
            authParams.Add("username", "Alina6664");
            authParams.Add("method", "auth.getMobileSession");
        }

        public async void Authentication()
        {
            var sortedParams = new Dictionary<string, string>();
            sortedParams = authParams.OrderBy(param => param.Key)
                .ToDictionary(param => param.Key, param => param.Value);

            //var sortedParams = authParams;

            var builder = new StringBuilder();

            foreach (var param in sortedParams)
            {
                builder.Append(param.Key).Append(param.Value);
            }

            var requestParameters = new RequestParameters("auth");
            requestParameters.Add("username", "huesername");
            requestParameters.Add("password", "huyasword");
            requestParameters.Add("test", "huest");

            var paramSignature = new ParamsSignature();
            var x = paramSignature.MakeSignature(requestParameters);

            builder.Append(secret);

            var signature = MD5CryptoServiceProvider.GetMd5String(builder.ToString());
            authParams.Add("api_sig", signature);

            authParams.Add("format", "JSON");
            var request = new Request();
            string response = await request.MakeRequest(authParams);
        }
    }
}
