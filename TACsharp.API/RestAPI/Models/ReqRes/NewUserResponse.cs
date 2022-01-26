using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
