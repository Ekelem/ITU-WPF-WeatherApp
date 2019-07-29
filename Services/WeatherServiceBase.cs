using System;
using System.Threading.Tasks;
using WPFWeather.Data;
using WPFWeather.Models;

namespace WPFWeather.Services
{
    public abstract class WeatherServiceBase : IWeatherService
    {
        public async Task<WeatherDataModel> DownloadWeatherAsync(string city)
        {
            var jsonString = await GetWeatherAsync(city.ToLower());

            if (string.IsNullOrEmpty(jsonString)) throw new ArgumentOutOfRangeException(nameof(city));

            var weatherFromJson = Openweatherdata.FromJson(jsonString);

            return WeatherInfoMapper.Map(weatherFromJson);
        }

        protected abstract Task<string> GetWeatherAsync(string city);
    }
}