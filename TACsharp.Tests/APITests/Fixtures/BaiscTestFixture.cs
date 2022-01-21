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
            var response1 = ReqResClient.GetUserList();
            var response3 = ReqResClient.GetUserByID(2);

            Assert.Pass();
        }
    }
}