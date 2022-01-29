using RestSharp;

namespace TACsharp.Framework.Core.REST
{
    /// <summary>
    /// REST request wrapper class
    /// </summary>
    public sealed class RESTRequest
    {
        internal RestRequest _request;

        private RESTRequest(string resource, RESTMethods method)
        {
            _request = new RestRequest(resource, (Method)method);     
        }

        /// <summary>
        /// Creates a GET request to a cpecified resource
        /// </summary>
        public static RESTRequest GET(string resource)
        {
            return new RESTRequest(resource, RESTMethods.Get);
        }
    }

    /// <summary>
    /// API methods enum
    /// </summary>
    internal enum RESTMethods
    {
        Get = Method.Get
    }
}
