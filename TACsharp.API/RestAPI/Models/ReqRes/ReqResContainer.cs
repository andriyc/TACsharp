using Newtonsoft.Json;

namespace TACsharp.API.RestAPI.Models
{
    /// <summary>
    /// ReqRes response object model
    /// </summary>
    public class ReqResContainer<DataType>
    {
        [JsonProperty("data")]
        public DataType Data { get; set; }

        [JsonProperty("support")]
        public ReqResSupport Support { get; set; }
    }
}
