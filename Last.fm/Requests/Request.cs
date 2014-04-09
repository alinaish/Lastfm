using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Last.fm.Requests
{
    class Request
    {
        public string serviceUri = "https://ws.audioscrobbler.com/2.0/";

        public async Task<string> MakeRequest(Dictionary<string, string> parameters)
        {
            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(serviceUri);

            

            var methodParameter = "?method=" + parameters["method"];
            parameters.Remove("method");
            var content = new FormUrlEncodedContent(parameters);
            HttpResponseMessage response = await client.PostAsync(methodParameter, content);
            response.EnsureSuccessStatusCode();
            string resultContent = await response.Content.ReadAsStringAsync();
            var x = JsonConvert.DeserializeObject<AuthModel>(resultContent);
            return resultContent;
        }
    }
}
