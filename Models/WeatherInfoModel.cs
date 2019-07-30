using System;
using System.Windows.Media;

namespace WPFWeather.Models
{
    public struct WeatherDataModel
    {
        public string CityName { get; set; }
        public string Description { get; set; }
        public ImageSource Icon { get; set; }
        //Coords properties
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        //Main properties
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal Pressure { get; set; }
        //Sys properties
        public string Country { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        //Wind properties
        public decimal WindSpeed { get; set; }
        public decimal WindDirection { get; set; }
    }
}