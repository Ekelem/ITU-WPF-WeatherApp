using Newtonsoft.Json;

namespace WPFWeather.Data
{
    public class Wind
    {
        /// <summary>
        ///     cleaned https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp
        /// </summary>
        [JsonProperty("speed")] public double Speed { get; set; }

        [JsonProperty("deg")] public double Deg { get; set; }
    }
}