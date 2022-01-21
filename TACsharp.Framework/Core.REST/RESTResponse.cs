using RestSharp;
using System.Net;

namespace TACsharp.Framework.Core.REST
{
    /// <summary>
    /// REST response wrapper class
    /// </summary>
    public sealed class RESTResponse
    {
        private RestResponse _response;

        public string Content => _response.Content;
        public HttpStatusCode StatusCode => _response.StatusCode;

        public RESTResponse(RestResponse response)
        {
            _response = response;
        }
    }
}
