using NUnit.Framework;
using TACsharp.API.RestAPI.Clients;
using TACsharp.API.RestAPI.Models;
using TACsharp.Framework.Core.JSON;

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

            Assert.Pass();
        }
    }
}