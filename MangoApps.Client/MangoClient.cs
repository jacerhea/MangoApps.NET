using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using MangoApps.Client.Request;
using MangoApps.Client.Request.Parameters;
using MangoApps.Client.Response;
using UserWallFeed = MangoApps.Client.Response.UserWallFeed;

namespace MangoApps.Client
{
    public class MangoClient
    {
        private readonly HttpClient _client;
        private readonly HttpClientHandler _httpClientHandler;

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

        public async Task<TResponse> ExecuteAsync<TRequestParameters, TResponse>(
            IRequest<TRequestParameters, TResponse> request) where TResponse : new()
        {
            HttpResponseMessage result = null;
            if (request.Method.Equals(HttpMethod.Get))
            {
                result = await _client.GetAsync(request.URL + ".json");
            }
            else if (request.Method.Equals(HttpMethod.Post))
            {
                result = await _client.PostAsync(request.URL + ".json", request.Container, new JsonMediaTypeFormatter());
            }

            if (result.IsSuccessStatusCode)
            {
                var responseResult = result.Content.ReadAsAsync<ResponseContainer<TResponse>>().Result;
                if (responseResult == null)
                {
                    return await Task.Run(() => new TResponse());
                }
                else
                {
                    return responseResult.Response;
                }
            }
            else
            {
                try
                {
                    result.EnsureSuccessStatusCode();
                }
                catch (Exception e)
                {
                    if (request.HasErrorResponse)
                    {
                        var errorResponse = result.Content.ReadAsAsync<ErrorResponse>();
                        throw new MangoException(e.Message, e) { ErrorResponse = errorResponse.Result };
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    throw new Exception();
                }
            }
        }


        public async Task<LoggedInUser> Login(string userName, string password, string apiKey)
        {
            var result = await _client.PostAsync(Client.URL.Login + ".json", new LoginRequestParameters{User = new LoginUser{}});
            return result.Content.ReadAsAsync<ResponseContainer<LoginResponse>>().Result.Response.User;            
        }

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
            
        }

        public async Task<UserWallFeed> PostToWall(int userId, string body)
        {
            var result = await
                    _client.PostAsync(URL.Users + string.Format("/{0}/wall.json", userId),
                        new RequestParametersContainer<UserWallRequestParameters>
                        {
                            Request = new UserWallRequestParameters {Feed = new Request.Parameters.UserWallFeed {Body = body}}
                        }, new JsonMediaTypeFormatter());
            return result.Content.ReadAsAsync<ResponseContainer<UserWallResponse>>().Result.Response.Feed; 
        }
    }
}
