
using TACsharp.API.RestAPI.Interfaces;
using TACsharp.API.RestAPI.Models.ReqRes;
using TACsharp.Framework.Core.REST;

namespace Bussiness.Sources
{
    public class User
    {
        private int Id;
        private string _name;
        private string _job;

        private User(string name, string job)
        {
            _name = name;
            _job = job;
        }

        public static User New(string name, string job)
        {
            return new User(name, job);
        }

        public NewUserResponse CreateOnEndPoint(IRestClient client)
        {
            return client.CreateUser(_name, _job);
        }

        public RESTResponse DeleteOnEndPoint(IRestClient client)
        {
            return client.DeleteUser(Id);
        }

        public UpdatedUserResponse UpdateOnEndPoint(IRestClient client)
        {
            return client.UpdateUser(Id, _name, _job);
        }

        public UpdatedUserResponse PatchOnEndPoint(IRestClient client)
        {
            return client.PatchUser(Id, _name, _job);
        }
    }
}
