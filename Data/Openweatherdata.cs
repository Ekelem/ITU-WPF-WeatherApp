using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WPFWeather.Data
{
    public partial class Openweatherdata
    {
        [JsonProperty("coord")] public Coord Coord { get; set; }

        [JsonProperty("sys")] public Sys Sys { get; set; }

        [JsonProperty("weather")] public Weather[] Weather { get; set; }

        [JsonProperty("base")] public string Base { get; set; }

        [JsonProperty("main")] public Main Main { get; set; }

        [JsonProperty("wind")] public Wind Wind { get; set; }

        [JsonProperty("clouds")] public Clouds Clouds { get; set; }

        [JsonProperty("dt")] public long Dt { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("cod")] public long Cod { get; set; }
    }

    public partial class Openweatherdata
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            }
        };

        public static Openweatherdata FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Openweatherdata>(json, Settings);
        }
    }
}