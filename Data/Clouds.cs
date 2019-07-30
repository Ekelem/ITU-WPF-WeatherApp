using Newtonsoft.Json;

namespace WPFWeather.Data
{
    public class Clouds
    {
        /// <summary>
        ///     cleaned https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp
        /// </summary>
        [JsonProperty("all")] public long All { get; set; }
    }
}