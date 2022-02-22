using Newtonsoft.Json;

namespace TACsharp.API.RestAPI.Models.ReqRes
{
    public class NewUserResponse : NewUserRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }
}
