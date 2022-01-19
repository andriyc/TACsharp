using NUnit.Framework;
using RestSharp;
using System.Threading.Tasks;

namespace ACLP.Tests
{
    public class TestFixture
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var response = GetResponse().Result;
            
            Assert.Pass();
        }

        private async Task<RestResponse> GetResponse()
        {
            var client = new RestClient("https://reqres.in");
            var request = new RestRequest("/api/users", Method.Get);
            var responce = await client.ExecuteAsync(request);
            return responce;
        }
    }
}