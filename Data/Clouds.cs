using System;
using Newtonsoft.Json;

namespace WPFWeather.Data
{
    public class Clouds
    {
        [JsonProperty("all")] public long All { get; set; }
    }
}