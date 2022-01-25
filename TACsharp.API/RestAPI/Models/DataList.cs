using Newtonsoft.Json;
using System.Collections.Generic;

namespace TACsharp.API.RestAPI.Models
{
    /// <summary>
    /// ReqRes Data list model
    /// </summary>
    /// <typeparam name="T">The type of list entity</typeparam>
    public class DataList<T> : Response<IList<T>>
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }
}
