using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACsharp.API.RestAPI.Models.ReqRes
{
    public class RegisterUserRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        public static RegisterUserRequest Create(string email, string password)
        {
            return new RegisterUserRequest()
            {
                Email = email,
                Password = password
            };
        }
    }
}
