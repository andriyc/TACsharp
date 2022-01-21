﻿using Newtonsoft.Json;

namespace TACsharp.API.RestAPI.Models
{
    public class ReqResResponse<DataType>
    {
        [JsonProperty("data")]
        public DataType Data { get; set; }

        [JsonProperty("support")]
        public ReqResSupport Support { get; set; }
    }

    public class ReqResSupport
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ReqResUser
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

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