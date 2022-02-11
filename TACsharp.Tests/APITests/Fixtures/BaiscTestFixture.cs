using Bussiness.Sources;
using NUnit.Framework;
using TACsharp.API.RestAPI.Clients;
using TACsharp.API.RestAPI.Models.ReqRes;

namespace TACsharp.Tests.APITests.Fixtures
{
    public class BaiscTestFixture
    {
        private ReqResRestClient ReqResClient;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        { 
            ReqResClient = ReqResRestClient.New();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var user = User.New(ReqResClient);

            var userListResponse1 = ReqResClient.GetUserList();
            var userListResponse2 = ReqResClient.GetUserList(2);

            var userID2 = 2;
            var userWithUserID2 = ReqResClient.GetUserByID(userID2);

            var userIDNA = 7;
            var userNA = ReqResClient.GetUserByID(userIDNA);

            var resourceListResponse1 = ReqResClient.GetResourceList();
            var resourceListResponse2 = ReqResClient.GetResourceList(2);

            var resourceID2 = 2;
            var singleResourceWithID2 = ReqResClient.GetResourceByID(resourceID2);

            var resourceIDNA = 23;
            var resourceNA = ReqResClient.GetResourceByID(resourceIDNA);

            var newCreatedUser = ReqResClient.CreateUser("andrii", "boss");

            var newCreatedUserResponse = user.Create("andrii", "boss");

            var updatedUserResponse = ReqResClient.UpdateUser(newCreatedUserResponse.Id, "andrew", "super boss");
            var patchedUserResponse = ReqResClient.PatchUser(newCreatedUserResponse.Id, "ANDREW", "super mega boss");

            var deletedUserResponse = ReqResClient.DeleteUser(newCreatedUserResponse.Id);

            var registerUserResponse = ReqResClient.RegisterUser("eve.holt@reqres.in", "pwd");

            var loginUserResponse = ReqResClient.LoginAsUser("eve.holt@reqres.in", "pwd");

            Assert.Pass();
        }
    }
}