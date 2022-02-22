using Newtonsoft.Json;

namespace TACsharp.API.RestAPI.Models.ReqRes
{
    /// <summary>
    /// ReqRes Resource object model
    /// </summary>
    public class ReqResResource
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("pantone_value")]
        public string PantoneValue { get; set; }
    }
}
