﻿using System;
using System.Windows.Media; //ImageSource
using System.Windows.Media.Imaging; //BitmapImage
using WPFWeather.Models;
using WPFWeather.Data;

namespace WPFWeather.Services
{
    public class WeatherInfoMapper
    {
        public static WeatherDataModel Map(Openweatherdata openweather)
        {
            return new WeatherDataModel
            {
                CityName = openweather.Name,
                Country = openweather.Sys.Country,
                Description = openweather.Weather[0].Description,
                Humidity = openweather.Main.Humidity,
                Icon = GetIcon(openweather.Weather[0].Icon),
                Longitude = (decimal) openweather.Coord.Lon,
                Latitude = (decimal)openweather.Coord.Lat,
                Sunrise = DateTimeOffset.FromUnixTimeSeconds(openweather.Sys.Sunrise).DateTime,
                Sunset = DateTimeOffset.FromUnixTimeSeconds(openweather.Sys.Sunset).DateTime,
                Temperature = (decimal) openweather.Main.Temp,
                WindDirection = (decimal) openweather.Wind.Deg,
                WindSpeed = (decimal) openweather.Wind.Speed
            };
        }

        private static ImageSource GetIcon(string icon)
        {
            if (icon == null) return null;
            return new BitmapImage(new Uri("/Icons/" + icon + ".png", UriKind.RelativeOrAbsolute));
        }
    }
}