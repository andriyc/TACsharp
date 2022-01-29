using RestSharp;
using System;

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

        /// <summary>
        /// Creates a POST request to a cpecified resource
        /// </summary>
        public static RESTRequest POST(string resource)
        {
            return new RESTRequest(resource, RESTMethods.Post);
        }

        /// <summary>
        /// Creates a PUT request to a cpecified resource
        /// </summary>
        public static RESTRequest PUT(string resource)
        {
            return new RESTRequest(resource, RESTMethods.Put);
        }

        /// <summary>
        /// Creates a PATCH request to a cpecified resource
        /// </summary>
        public static RESTRequest PATCH(string resource)
        {
            return new RESTRequest(resource, RESTMethods.Patch);
        }

        /// <summary>
        /// Adds body to the RESTRequest
        /// </summary>
        public RESTRequest AddBody(object body)
        {
            _request.AddBody(body);
            return this;
        }
    }

    /// <summary>
    /// API methods enum
    /// </summary>
    internal enum RESTMethods
    {
        Get = Method.Get,
        Post = Method.Post,
        Put = Method.Put,
        Patch = Method.Patch
    }
}
