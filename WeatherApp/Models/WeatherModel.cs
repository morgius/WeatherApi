using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherModel
    {
        public string Name { get; set; }
        public float Temperature { get; set; }
        public float TempMin { get; set; }
        public float TempMax { get; set; }
        public int Humidity { get; set; }
        public string Clouds { get; set; }
        public float WindSpeed { get; set; }
        public int Pressure { get; set; }
        public string Country { get; set; }
    }
}
