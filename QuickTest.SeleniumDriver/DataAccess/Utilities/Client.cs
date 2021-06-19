using DataAccess.Interfaces;
using DataAccess.Models;
using Newtonsoft.Json;
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
            var res = await _httpClient.GetAsync(endpoint);
            return await res.Content.ReadAsAsync<T>();
        }

        public async Task<T> PostAsync<T>(string endpoint, object body)
        {
            var httpContent =
                new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            var res = await _httpClient.PostAsync(endpoint, httpContent);
            return await res.Content.ReadAsAsync<T>();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }        
    }
}
