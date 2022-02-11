
using TACsharp.API.RestAPI.Interfaces;
using TACsharp.API.RestAPI.Models.ReqRes;

namespace Bussiness.Sources
{
    public class User
    {
        private IRestClient _client;

        private User(IRestClient client)
        {
            _client = client;
        }

        public static User New(IRestClient client)
        {
            return new User(client);
        }

        public NewUserResponse Create(string name, string job)
        {
            return _client.CreateUser(name, job);
        }
    }
}
