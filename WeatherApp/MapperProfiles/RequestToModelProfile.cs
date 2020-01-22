using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Helpers;
using WeatherApp.Models;

namespace WeatherApp.MapperProfiles
{
    public class RequestToModelProfile:Profile
    {
        public RequestToModelProfile()
        {
            CreateMap<WeatherRequest, WeatherModel>().ForMember(dest => dest.Country, x => x.MapFrom(src => src.Sys.Country))
                                                     .ForMember(dest => dest.Temperature, x => x.MapFrom(src => src.Main.Temp.KelvinToCelsius()))
                                                     .ForMember(dest => dest.TempMin, x => x.MapFrom(src => src.Main.Temp_Min.KelvinToCelsius()))
                                                     .ForMember(dest => dest.TempMax, x => x.MapFrom(src => src.Main.Temp_Max.KelvinToCelsius()))
                                                     .ForMember(dest => dest.Humidity, x => x.MapFrom(src => src.Main.Humidity))
                                                     .ForMember(dest => dest.Clouds, x => x.MapFrom(src => src.Clouds.All.CloudsInPercent()))
                                                     .ForMember(dest => dest.WindSpeed, x => x.MapFrom(src => src.Wind.Speed))
                                                     .ForMember(dest => dest.Pressure, x => x.MapFrom(src => src.Main.Pressure));
        }
    }
}
