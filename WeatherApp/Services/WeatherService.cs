
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Helpers;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService: IWeatherService
    {
        //private readonly string myKey = "34f898d23f6bab3e64220d5f0ca9794c";
        private readonly string myKey;
        private HttpClient Client { get; }
        public WeatherService(IHttpClientFactory httpClientFactory, IOptions<WeatherApi> options)
        {
            Client = httpClientFactory.CreateClient();
            myKey = options.Value.Key;
        }
        public async Task<WeatherRequest> Get(string name)
        {
            HttpResponseMessage response = await Client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid={myKey}");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WeatherRequest weatherRequest = JsonConvert.DeserializeObject<WeatherRequest>(content);
                return weatherRequest;
            }
            else
            {
                return null;
            }
        }
    }
}
