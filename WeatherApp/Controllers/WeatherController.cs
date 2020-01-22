using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherController:ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWeatherService weatherService;
        public WeatherController(IWeatherService weatherService, IMapper mapper)
        {
            this.mapper = mapper;
            this.weatherService = weatherService;
        }
        [HttpGet()]
        [Route("GetWeather")]
        public  async Task<IActionResult> GetWeather(string name)
        {
            var weather =  await weatherService.Get(name);
            if (weather is null)
            {
                return NotFound();
            }
            var response = mapper.Map<WeatherModel>(weather);
            return Ok(response);
        }
    }
}
