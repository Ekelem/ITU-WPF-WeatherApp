using Newtonsoft.Json;

namespace WPFWeather.Data
{
    public class Coord
    {
        /// <summary>
        ///     cleaned https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp
        /// </summary>
        [JsonProperty("lon")] public double Lon { get; set; }

        [JsonProperty("lat")] public double Lat { get; set; }
    }
}