using NUnit.Framework;
using System.Threading.Tasks;
using TACsharp.API.RestAPI.Clients;

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

            var userIDNA = 23;
            var userNA = ReqResClient.GetUserByID(userIDNA);

            var resourceList = ReqResClient.GetResourceList();

            var resourceID2 = 2;
            var singleResourceWithID2 = ReqResClient.GetResourceByID(resourceID2);

            var resourceIDNA = 23;
            var resourceNA = ReqResClient.GetResourceByID(resourceIDNA);

            Assert.Pass();
        }
    }
}