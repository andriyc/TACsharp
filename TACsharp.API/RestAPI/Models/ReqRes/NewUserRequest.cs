using Newtonsoft.Json;

namespace TACsharp.API.RestAPI.Models.ReqRes
{
    public class NewUserRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        public static NewUserRequest Create(string name, string job)
        {
            return new NewUserRequest()
            {
                Name = name,
                Job = job
            };
        }
    }
}
