
using FirstProject.Model;
using Newtonsoft.Json;
using OpenStack.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Util
{
    class RestService 
    {
        public static TodoModel model;

        public async Task<T> GetRequest<T>(string url) 
        {
            try
            {
                var handler = new HttpClientHandler { UseCookies = false };
                var client = new HttpClient(handler) { BaseAddress = new Uri(url) };
                var message = new HttpRequestMessage(HttpMethod.Get, new Uri(url));
                HttpResponseMessage result = await client.SendAsync(message);

                var response = await result.Content.ReadAsStringAsync();
                var responseObj = (T)JsonConvert.DeserializeObject(response, typeof(T));
                return responseObj;
            }catch (Exception ex)
            {

            }
            return (T)(object)"{}";
        }
    }
}
