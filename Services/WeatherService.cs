using System;
using System.Net.Http;
using System.Threading.Tasks;
using WPFWeather.Data;
using WPFWeather.Models;

namespace WPFWeather.Services
{
    class WeatherService : IWeatherService
    {
        private readonly string _openWeatherMapAppId = "5174c48b50122686367191e785842895"; //Don't steal API key please

        protected async Task<string> GetWeatherAsync(string city)
        {
            var address =
                $@"http://api.openweathermap.org/data/2.5/weather?q={city}&APPID={_openWeatherMapAppId}&mode=json&units=metric";

            var client = new HttpClient();
            try
            {
                return await client.GetStringAsync(address);
            }
            catch (HttpRequestException e) when (e.Message.Contains("404"))
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (HttpRequestException)
            {
                throw new InvalidOperationException();
            }
        }

        public async Task<WeatherDataModel> DownloadWeatherAsync(string city)
        {
            var jsonString = await GetWeatherAsync(city.ToLower());

            if (string.IsNullOrEmpty(jsonString)) throw new ArgumentOutOfRangeException(nameof(city));

            var weatherFromJson = Openweatherdata.FromJson(jsonString);

            return WeatherInfoMapper.Map(weatherFromJson);
        }
    }
}
