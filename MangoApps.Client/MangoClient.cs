using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using MangoApps.Client.Request;
using MangoApps.Client.Request.Parameters;
using MangoApps.Client.Response;

namespace MangoApps.Client
{
    public class MangoClient
    {
        private readonly HttpClient _client;
        private readonly HttpClientHandler _httpClientHandler;
        private static readonly JsonMediaTypeFormatter _jsonFormatter = new JsonMediaTypeFormatter();

        public MangoClient(string apiURI)
        {
            _httpClientHandler = new HttpClientHandler
            {
                AllowAutoRedirect = true,
                UseCookies = true,
                CookieContainer = new CookieContainer()
            };
            _client = new HttpClient(_httpClientHandler) { BaseAddress = new Uri(apiURI) };
        }

        public async Task<TResponse> ExecutePostAsync<TRequestParameters, TResponse>(
            IRequest<TRequestParameters, TResponse> request) where TResponse : new()
        {
            HttpResponseMessage result = null;
            if (request.Method.Equals(HttpMethod.Get))
            {
                throw new NotImplementedException();
            }
            else if (request.Method.Equals(HttpMethod.Post))
            {
                result = await _client.PostAsync(request.URL + ".json", request.Container, _jsonFormatter);                
            }

            if (result.IsSuccessStatusCode)
            {
                var responseResult = await result.Content.ReadAsAsync<ResponseContainer<TResponse>>();
                return responseResult.Response;
            }
            else
            {
                try
                {
                    result.EnsureSuccessStatusCode();
                }
                catch (Exception e)
                {
                    var errorResponse = result.Content.ReadAsAsync<ErrorResponse>();
                    throw new MangoException(e.Message, e) { ErrorResponse = errorResponse.Result };
                }
                finally
                {
                    throw new Exception();
                }
            }
        }

        public async Task<SignedUpUser> Signup(string email, string firstName, string lastName, string plan = null, string partnerCode = null)
        {
            var user = new SignupUser { Email = email, FirstName = firstName, LastName = lastName, PartnerCode = partnerCode, Plan = plan };
            var result = await _client.PostAsync(URL.Login + ".json", new RequestParametersContainer<SignupUser> { Request = user }, _jsonFormatter);
            return result.Content.ReadAsAsync<ResponseContainer<SignupResponse>>().Result.Response.User;
        }

        public async Task<LoginResponse> Login(string userName, string password, string apiKey)
        {
            var encodedPassword = Encoder.ToBase64String(password);
            var parameters = new LoginRequestParameters { User = new LoginUser { UserName = userName, Password = encodedPassword, APIKey = apiKey } };
            return await ExecutePostAsync(new LoginRequest(parameters));
        }

        public async Task<InviteUserResponse> InviteUsers(IEnumerable<string> emails)
        {
            var result = await _client.PostAsync(URL.Users + ".json", new RequestParametersContainer<InviteUserRequestParameters> { Request = new InviteUserRequestParameters { User = new InviteUserRequestUser { Email = new InviteUserRequestIds { Ids = emails.ToList() } } } }, _jsonFormatter);
            return result.Content.ReadAsAsync<ResponseContainer<InviteUserResponse>>().Result.Response;
        }

        public async Task<CreateGroupResponse> CreateAGroup(string name, string description, string privacyType)
        {
            var result = await _client.PostAsync(URL.Groups + ".json", , _jsonFormatter);
            var x = result.Content.ReadAsAsync<ResponseContainer<CreateGroupResponse>>().Result.Response;
            return await ExecutePostAsync(new RequestParametersContainer<CreateGroupRequest> { Request = new CreateGroupRequest { Group = new CreateGroupRequestParameters { Name = name, Description = description, PrivacyType = privacyType } } });
        }

        //public async Task<UserWallFeedResponse> StatusUpdate(string message)
        //{
        //    var result = await _client.PostAsync(URL.Users + string.Format("/{0}/wall.json", userId),
        //                new RequestParametersContainer<UserWallRequestParameters>
        //                {
        //                    Request = new UserWallRequestParameters { Feed = new UserWallFeed { Body = body } }
        //                }, _jsonFormatter);
        //    return result.Content.ReadAsAsync<ResponseContainer<UserWallResponse>>().Result.Response.Feed;
        //}

        public async Task<GetAllUsersResponse> GetAllUsers()
        {
            var result = await _client.GetAsync(URL.Users + ".json");
            return result.Content.ReadAsAsync<ResponseContainer<GetAllUsersResponse>>().Result.Response;
        }

        public async Task<UserProfileInfo> GetUser(int userId)
        {
            var result = await _client.GetAsync(URL.Users + string.Format("/{0}.json", userId));
            return result.Content.ReadAsAsync<ResponseContainer<UserProfileInfoResponse>>().Result.Response.User;
        }

        public async Task<GetAllGroupsResponse> GetAllGroups()
        {
            var result = await _client.GetAsync(URL.Groups + ".json?all=true");
            return result.Content.ReadAsAsync<ResponseContainer<GetAllGroupsResponse>>().Result.Response;
        }

        public async Task Logout()
        {
            await _client.PostAsync(URL.Logout + ".json", new StringContent(""), _jsonFormatter);
        }

        public async Task<UserWallFeedResponse> PostToWall(int userId, string body)
        {
            var result = await
                    _client.PostAsync(URL.Users + string.Format("/{0}/wall.json", userId),
                        new RequestParametersContainer<UserWallRequestParameters>
                        {
                            Request = new UserWallRequestParameters { Feed = new UserWallFeed { Body = body } }
                        }, _jsonFormatter);
            return result.Content.ReadAsAsync<ResponseContainer<UserWallResponse>>().Result.Response.Feed;
        }
    }
}
