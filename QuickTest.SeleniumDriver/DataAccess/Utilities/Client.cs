using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccess.Utilities
{
    public class Client : IDisposable, IClient
    {
        private readonly HttpClient _httpClient;

        
        public Client(HttpClient client)
        {
            //client.BaseAddress = new Uri(Environment.GetEnvironmentVariable("QUICKTESTAPI")); //not working
            client.BaseAddress = new Uri("http://localhost:8080/api/");
            client.Timeout = TimeSpan.FromSeconds(30);
            _httpClient = client;
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var resp = await _httpClient.GetAsync(endpoint);
            return await resp.Content.ReadAsAsync<T>();
        }

        public Task<T> PostAsync<T>(string endpoint, object content)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public static string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return string.Join("&", properties.ToArray());
        }
    }
}
