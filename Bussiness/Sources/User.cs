
using TACsharp.API.RestAPI.Interfaces;

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

        public object Create(string user, string job)
        {
            return _client.CreateUser(user, job);
        }
    }
}
