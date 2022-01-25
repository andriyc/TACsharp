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
        public DataList<ReqResUser> GetUserList()
        {
            var request = RESTRequest.GET(UserListSource);
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<DataList<ReqResUser>>();
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
                    .ToObject<ReqResUser>();
        }

        /// <summary>
        /// Gets resource list via API
        /// </summary>
        public DataList<ReqResResource> GetResourceList()
        {
            var request = RESTRequest.GET(ResourceListSource);
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<DataList<ReqResResource>>();
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
                    .ToObject<ReqResResource>();
        }
    }
}
