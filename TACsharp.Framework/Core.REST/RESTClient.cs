using RestSharp;
using System.Threading.Tasks;

namespace TACsharp.Framework.Core.REST
{
    /// <summary>
    /// REST client wrapper class
    /// </summary>
    public sealed class RESTClient
    {
        private RestClient _client;

        private RESTClient(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        /// <summary>
        /// Returns new RESTClient object
        /// </summary>
        /// <param name="baseUrl">Base URL of endpoint</param>
        /// <returns>RESTClient</returns>
        public static RESTClient NewClient(string baseUrl)
        {
            return new RESTClient(baseUrl);
        }

        /// <summary>
        /// Executes the request asynchronously
        /// </summary>
        /// <param name="request">RESTRequest object</param>
        /// <returns>async Task<RESTResponse></returns>
        public async Task<RESTResponse> ExecuteAsync(RESTRequest request)
        {
            return new RESTResponse(await _client.ExecuteAsync(request._request));
        }
    }
}
