using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherRequest
    {
        public Main Main { get; set; }
        public string Name { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Sys Sys { get; set; }


        //public Coord Coord { get; set; }
        //public string Base { get; set; }
        //public int Visibility { get; set; }
        //public int Dt { get; set; }
        //public int Timezone { get; set; }
        //public int Id { get; set; }
        //public int Cod { get; set; }
    }
}
