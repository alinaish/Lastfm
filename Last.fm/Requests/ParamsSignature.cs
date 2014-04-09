using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Last.fm.Utils;

namespace Last.fm.Requests
{
    class ParamsSignature
    {
        private readonly List<string> _paramNames;

        public ParamsSignature()
        {
            _paramNames = new List<string> { "api_key", "username", "password", "method" };
        }

        public string MakeSignature(RequestParameters parameters)
        {
            var sigParams =
                parameters.Where(param => _paramNames.Contains(param.Key))
                    .OrderBy(param => param.Key)
                    .ToDictionary(param => param.Key, param => param.Value);

            //var signatureStr = sigParams.ToString() + IsolatedStorageSettings.ApplicationSettings["secret"];

            var result = new StringBuilder();

            foreach (var param in sigParams)
            {
                result.Append(param.Key).Append(param.Value);
            }
            result.Append(IsolatedStorageSettings.ApplicationSettings["secret"]);

            return MD5.GetMd5String(result.ToString());

        }
    }
}
