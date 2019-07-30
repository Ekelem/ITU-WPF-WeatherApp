using Newtonsoft.Json;

namespace WPFWeather.Data
{
    public class Sys
    {
        /// <summary>
        ///     cleaned https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp
        /// </summary>
        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("sunrise")] public long Sunrise { get; set; }

        [JsonProperty("sunset")] public long Sunset { get; set; }
    }
}