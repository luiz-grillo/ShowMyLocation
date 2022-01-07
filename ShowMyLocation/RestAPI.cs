using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShowMyLocation
{
    public class RestAPI
    {
        private const string API_URL = "http://ip-api.com/json/";

        public Response GetResult(string ipAddress = null)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync($"{API_URL}{ipAddress}").Result;
                if (httpResponseMessage.IsSuccessStatusCode)
                    return httpResponseMessage.Content.ReadAsAsync<Response>().Result;
                else
                    return new Response();
            }
        }
    }
}
