using System.Threading.Tasks;
using TACsharp.API.RestAPI.Models;
using TACsharp.Framework.Core.JSON;
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
        public ReqResListResponse<ReqResUser> GetUserList(int page = 1)
        {
            var request = RESTRequest.GET(UserListSource + $"?page={page}");
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<ReqResListResponse<ReqResUser>>();
        }

        /// <summary>
        /// Gets User by ID via API
        /// </summary>
        public ReqResUser GetUserByID(int userID)
        {
            var request = RESTRequest.GET(UserListSource + $"/{userID}");
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<ReqResResponse<ReqResUser>>()
                    .Data;
        }

        /// <summary>
        /// Gets resource list via API
        /// </summary>
        public ReqResListResponse<ReqResResource> GetResourceList(int page = 1)
        {
            var request = RESTRequest.GET(ResourceListSource + $"?page={page}");
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<ReqResListResponse<ReqResResource>>();
        }

        /// <summary>
        /// Rets a resource by ID
        /// </summary>
        public ReqResResource GetResourceByID(int resourceID)
        {
            var request = RESTRequest.GET(ResourceListSource + $"/{resourceID}");
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<ReqResResponse<ReqResResource>>()
                    .Data;
        }
    }
}
