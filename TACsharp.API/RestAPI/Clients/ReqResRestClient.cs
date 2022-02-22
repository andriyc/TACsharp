﻿using System;
using System.Threading.Tasks;
using TACsharp.API.RestAPI.Interfaces;
using TACsharp.API.RestAPI.Models;
using TACsharp.API.RestAPI.Models.ReqRes;
using TACsharp.Framework.Core.JSON;
using TACsharp.Framework.Core.REST;

namespace TACsharp.API.RestAPI.Clients
{
    /// <summary>
    /// https://reqres.in/ REST client class
    /// </summary>
    public class ReqResRestClient : IRestClient
    {
        private const string BaseUrl = "https://reqres.in";
        private const string UserListSource = "/api/users";
        private const string ResourceListSource = "/api/unknown";
        private const string RegisterUserSource = "/api/register";
        private const string LoginUserSource = "/api/login";

        private readonly RESTClient _client;

        private ReqResRestClient()
        {
            _client = RESTClient.NewClient(BaseUrl);
        }

        /// <summary>
        /// Creates and returns new ReqResRestClint object
        /// </summary>
        /// <returns>new ReqResRestClient object</returns>
        public static ReqResRestClient New()
        {
            return new ReqResRestClient();
        }

        /// <summary>
        /// Executes the request asynchronously and returns the Task<RESTResponse>
        /// </summary>
        private Task<RESTResponse> GetResponseAsync(RESTRequest request)
        {
            return _client.ExecuteAsync(request);
        }

        /// <summary>
        /// Gets User list via API
        /// </summary>
        public ReqResListContainer<ReqResUser> GetUserList(int page = 1)
        {
            var request = RESTRequest.GET(UserListSource + $"?page={page}");
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<ReqResListContainer<ReqResUser>>();
        }

        /// <summary>
        /// Deletes User by ID via API
        /// </summary>
        public RESTResponse DeleteUser(int userID)
        {
            var request = RESTRequest.DELETE(UserListSource + $"/{userID}");
            var response = GetResponseAsync(request).Result;
            return response;
        }

        /// <summary>
        /// Gets User by ID via API
        /// </summary>
        public ReqResUser GetUserByID(int userID)
        {
            var request = RESTRequest.GET(UserListSource + $"/{userID}");
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<ReqResContainer<ReqResUser>>()
                    .Data;
        }

        /// <summary>
        /// Gets resource list via API
        /// </summary>
        public ReqResListContainer<ReqResResource> GetResourceList(int page = 1)
        {
            var request = RESTRequest.GET(ResourceListSource + $"?page={page}");
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<ReqResListContainer<ReqResResource>>();
        }

        /// <summary>
        /// Rets a resource by ID
        /// </summary>
        public ReqResResource GetResourceByID(int resourceID)
        {
            var request = RESTRequest.GET(ResourceListSource + $"/{resourceID}");
            var response = GetResponseAsync(request).Result;
            return JSONObject
                    .Parse(response.Content)
                    .ToObject<ReqResContainer<ReqResResource>>()
                    .Data;
        }

        /// <summary>
        /// Creates a new user via API
        /// </summary>
        public NewUserResponse CreateUser(string name, string job)
        {
            var request = RESTRequest
                            .POST(UserListSource)
                            .AddBody(NewUserRequest.Create(name, job));

            var response = GetResponseAsync(request).Result;
            return JSONObject
                            .Parse(response.Content)
                            .ToObject<NewUserResponse>();
        }

        /// <summary>
        /// Updates the user by ID via API (PUT)
        /// </summary>
        public UpdatedUserResponse UpdateUser(int userId, string name, string job)
        {
            var request = RESTRequest
                .PUT(UserListSource + $"/{userId}")
                .AddBody(NewUserRequest.Create(name, job));

            var response = GetResponseAsync(request).Result;
            return JSONObject
                            .Parse(response.Content)
                            .ToObject<UpdatedUserResponse>();
        }

        /// <summary>
        /// Updates the user by ID via API (PATCH)
        /// </summary>
        public UpdatedUserResponse PatchUser(int userId, string name, string job)
        {
            var request = RESTRequest
                .PATCH(UserListSource + $"/{userId}")
                .AddBody(NewUserRequest.Create(name, job));

            var response = GetResponseAsync(request).Result;
            return JSONObject
                            .Parse(response.Content)
                            .ToObject<UpdatedUserResponse>();
        }

        /// <summary>
        /// Registers new user via API (POST)
        /// </summary>
        public RegisteredUserResponse RegisterUser(string email, string password)
        {
            var request = RESTRequest
                .POST(RegisterUserSource)
                .AddBody(UserLoginRequest.Create(email, password));

            var response = GetResponseAsync(request).Result;
            return JSONObject
                .Parse(response.Content)
                .ToObject<RegisteredUserResponse>();
        }

        /// <summary>
        /// Looging in as user via API (POST)
        /// </summary>
        public LoggedinUserResponse LoginAsUser(string email, string password)
        {
            var request = RESTRequest
                .POST(LoginUserSource)
                .AddBody(UserLoginRequest.Create(email, password));

            var response = GetResponseAsync(request).Result;
            return JSONObject
                .Parse(response.Content)
                .ToObject<LoggedinUserResponse>();
        }
    }
}
