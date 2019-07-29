using System;
using Newtonsoft.Json;

namespace WPFWeather.Data
{
    public class Wind
    {
        [JsonProperty("speed")] public double Speed { get; set; }

        [JsonProperty("deg")] public double Deg { get; set; }
    }
}