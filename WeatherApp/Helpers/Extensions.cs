using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Helpers
{
    public static class Extensions
    {
        public static float KelvinToCelsius(this float kelv)
        {
            return (float)Math.Round(kelv - 273.15);
        }
        public static string CloudsInPercent(this int num)
        {
            return $"{num}%";
        }
    }
}
