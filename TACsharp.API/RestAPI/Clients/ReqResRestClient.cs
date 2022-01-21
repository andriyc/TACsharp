using System;
using System.Threading.Tasks;
using TACsharp.Framework.Core.REST;

namespace TACsharp.API.RestAPI.Clients
{
    /// <summary>
    /// https://reqres.in/ REST client class
    /// </summary>
    public class ReqResRestClient
    {
        private const string BaseUrl = "https://reqres.in";
        private const string UserListSource = "/api/users";
        private const string ResourceListSource = "/api/unknown";

        private readonly RESTClient _client;

        private ReqResRestClient()
        {
            _client = RESTClient.NewClient(BaseUrl);
        }

        /// <summary>
        /// Creates and returns new ReqResRestClint object
        /// </summary>
        /// <returns>new ReqResRestClient object</returns>
        public static ReqResRestClient New()
        {
            return new ReqResRestClient();
        }

        /// <summary>
        /// Executes the request asynchronously and returns the Task<RESTResponse>
        /// </summary>
        private Task<RESTResponse> GetResponseAsync(RESTRequest request)
        {
            return _client.ExecuteAsync(request);
        }

        /// <summary>
        /// Gets User list via API
        /// </summary>
        public RESTResponse GetUserList()
        {
            var request = RESTRequest.GET(UserListSource);
            return GetResponseAsync(request).Result;
        }

        /// <summary>
        /// Gets User by ID via API
        /// </summary>
        public RESTResponse GetUserByID(int userID)
        {
            var request = RESTRequest.GET(UserListSource + $"/{userID}");
            return GetResponseAsync(request).Result;
        }

        /// <summary>
        /// Gets resource list via API
        /// </summary>
        public RESTResponse GetResourceList()
        {
            var request = RESTRequest.GET(ResourceListSource);
            return GetResponseAsync(request).Result;
        }

        /// <summary>
        /// Rets a resource by ID
        /// </summary>
        public object GetResourceByID(int resourceID)
        {
            var request = RESTRequest.GET(ResourceListSource + $"/{resourceID}");
            return GetResponseAsync(request).Result;
        }
    }
}
