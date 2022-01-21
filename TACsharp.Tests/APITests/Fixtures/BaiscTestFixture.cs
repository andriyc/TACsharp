using NUnit.Framework;
using System.Threading.Tasks;
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
            var userList = ReqResClient.GetUserList();

            var userID2 = 2;
            var userWithUserID2 = ReqResClient.GetUserByID(userID2);
            var user = JSONObject
                        .Parse(userWithUserID2.Content)
                        .ToObject<ReqResResponse<ReqResUser>>()
                        .Data;

            var userIDNA = 23;
            var userNA = ReqResClient.GetUserByID(userIDNA);

            var resourceList = ReqResClient.GetResourceList();

            var resourceID2 = 2;
            var singleResourceWithID2 = ReqResClient.GetResourceByID(resourceID2);
            var resource = JSONObject
                            .Parse(singleResourceWithID2.Content)
                            .ToObject<ReqResResponse<ReqResResource>>()
                            .Data;

            var resourceIDNA = 23;
            var resourceNA = ReqResClient.GetResourceByID(resourceIDNA);

            Assert.Pass();
        }
    }
}