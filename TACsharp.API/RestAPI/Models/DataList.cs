using Newtonsoft.Json;
using System.Collections.Generic;


namespace TACsharp.API.RestAPI.Models
{
    /// <summary>
    /// ReqRes response Data List
    /// </summary>
    /// <typeparam name="T">The type of data entity in the Data List</typeparam>
    public class DataList<T>
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty("data")]
        public List<T> Data { get; set; }
    }
}
