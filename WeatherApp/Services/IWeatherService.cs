using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface IWeatherService
    {
        Task<WeatherRequest> Get(string name);
    }
}
