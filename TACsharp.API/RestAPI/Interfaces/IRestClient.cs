using TACsharp.API.RestAPI.Models;
using TACsharp.API.RestAPI.Models.ReqRes;
using TACsharp.Framework.Core.REST;

namespace TACsharp.API.RestAPI.Interfaces
{
    public interface IRestClient
    {
        NewUserResponse CreateUser(string name, string job);
        RESTResponse DeleteUser(int userID);
        ReqResResource GetResourceByID(int resourceID);
        ReqResListContainer<ReqResResource> GetResourceList(int page = 1);
        ReqResUser GetUserByID(int userID);
        ReqResListContainer<ReqResUser> GetUserList(int page = 1);
        LoggedinUserResponse LoginAsUser(string email, string password);
        UpdatedUserResponse PatchUser(int userId, string name, string job);
        RegisteredUserResponse RegisterUser(string email, string password);
        UpdatedUserResponse UpdateUser(int userId, string name, string job);
    }
}