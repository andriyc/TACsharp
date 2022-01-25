using Newtonsoft.Json;

namespace TACsharp.API.RestAPI.Models
{
    /// <summary>
    /// ReqRes Support object model
    /// </summary>
    public class ReqResSupport
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
