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
        /// Gets User list via API
        /// </summary>
        public RESTResponse GetUserList()
        {
            var request = RESTRequest.GET(UserListSource);
            return _client.ExecuteAsync(request).Result;
        }

        /// <summary>
        /// Gets User by ID via API
        /// </summary>
        public RESTResponse GetUserByID(int userID)
        {
            var request = RESTRequest.GET(UserListSource + $"/{userID}");
            return _client.ExecuteAsync(request).Result;
        }
    }
}
