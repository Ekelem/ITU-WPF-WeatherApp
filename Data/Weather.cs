using Newtonsoft.Json;

namespace WPFWeather.Data
{
    public class Weather
    {
        /// <summary>
        ///     cleaned https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("main")] public string Main { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("icon")] public string Icon { get; set; }
    }
}