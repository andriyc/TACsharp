using Newtonsoft.Json;
using System.Collections.Generic;


namespace TACsharp.API.RestAPI.Models
{
    /// <summary>
    /// ReqRes response model
    /// </summary>
    /// <typeparam name="T">The type of data container in Response</typeparam>
    public class Response<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }
        
        //Support - for further implementation if needed
    }
}
