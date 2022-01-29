using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACsharp.API.RestAPI.Models.ReqRes
{
    public class LoggedinUserResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
