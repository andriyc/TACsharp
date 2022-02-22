using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACsharp.API.RestAPI.Models.ReqRes
{
    public class RegisteredUserResponse : LoggedinUserResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
