﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using MangoApps.Client.Request;

namespace MangoApps.Client
{
    /// <summary>
    /// Simplifies access to the complete mango api.
    /// </summary>
    public class MangoClient
    {
        private readonly HttpClient _client;
        private readonly HttpClientHandler _httpClientHandler;
        private static readonly JsonMediaTypeFormatter _jsonFormatter = new JsonMediaTypeFormatter();
        private const string JSON = ResponseTypes.JSON;

        /// <summary>
        /// Initializes a new instance of the <see cref="MangoClient"/> class.
        /// </summary>
        /// <param name="apiUri">The API URI of the Mango server.</param>
        /// <exception cref="System.ArgumentNullException">apiUri</exception>
        public MangoClient(string apiUri)
        {
            if (apiUri == null) throw new ArgumentNullException("apiUri");
            _httpClientHandler = new HttpClientHandler
            {
                AllowAutoRedirect = true,
                UseCookies = true,
                CookieContainer = new CookieContainer()
            };
            _client = new HttpClient(_httpClientHandler) { BaseAddress = new Uri(apiUri) };
        }

        /// <summary>
        /// The API signs up and creates the new domain.
        /// </summary>
        /// <param name="email">REQUIRED: Work email ID of the user (Used in domain creation)</param>
        /// <param name="firstName">REQUIRED: First name of the user</param>
        /// <param name="lastName">REQUIRED: Last name of the user</param>
        /// <param name="plan">OPTIONAL: Default is “enterprise”. Supported plans are “basic”, “premium”, and “enterprise”.</param>
        /// <param name="partnerCode">OPTIONAL: A MangoApps-Provided partner code.</param>
        /// <returns></returns>
        /// <exception cref="MangoException">The request was forbidden.</exception>
        public async Task<SignupResponse> Signup(string email, string firstName, string lastName, PlanTypes? plan = null, string partnerCode = null)
        {
            var user = new SignupUser { Email = email, FirstName = firstName, LastName = lastName, PartnerCode = partnerCode, Plan = plan };
            var result = await _client.PostAsync(URL.Login + JSON, new RequestParametersContainer<SignupUser> { Request = user }, _jsonFormatter);
            return await GetResult<SignupResponse>(result);
        }

        /// <summary>
        /// The API Logs as specified user into the domain.
        /// </summary>
        /// <param name="userName">REQUIRED: The User that be logged in this session.</param>
        /// <param name="password">REQUIRED: Base64 Encoded Password</param>
        /// <param name="apiKey">REQUIRED: The API Key from MangoApps Admin Portal.</param>
        /// <returns></returns>
        /// <exception cref="MangoException">The request was unauthrized.</exception>        
        public async Task<LoginResponse> Login(string userName, string password, string apiKey)
        {
            //var encodedPassword = Encoder.ToBase64String(password);
            var parameters = new LoginRequest { User = new LoginUser { UserName = userName, Password = password, APIKey = apiKey } };
            var result = await _client.PostAsync(URL.Login + JSON, new RequestParametersContainer<LoginRequest> { Request = parameters }, _jsonFormatter);
            return await GetResult<LoginResponse>(result);
        }

        /// <summary>
        /// The API invites a network user to the domain.
        /// </summary>
        /// <param name="emails">REQUIRED: The email of the user being invited.</param>
        /// <returns></returns>
        /// <exception cref="MangoException">The request was unauthorized.</exception>        
        public async Task<InviteUserResponse> InviteUsers(IEnumerable<string> emails)
        {
            var result = await _client.PostAsync(URL.Users + JSON, new RequestParametersContainer<InviteUserRequest> { Request = new InviteUserRequest { User = new InviteUserRequestUser { Email = new InviteUserRequestIds { Ids = emails.ToList() } } } }, _jsonFormatter);
            return result.Content.ReadAsAsync<ResponseContainer<InviteUserResponse>>().Result.Response;
        }

        /// <summary>
        /// The API creates a new group in your MangoApps domain.
        /// </summary>
        /// <param name="name">REQUIRED: The name of the new group.</param>
        /// <param name="description">REQUIRED: The description of the new group.</param>
        /// <param name="privacyType">REQUIRED: The privacy type indicator for this new group.</param>
        /// <returns></returns>
        public async Task<CreateGroupResponse> CreateGroup(string name, string description, PrivacyType privacyType)
        {
            var result = await _client.PostAsync(URL.Groups + JSON, new RequestParametersContainer<CreateGroupRequest> { Request = new CreateGroupRequest { Group = new CreateGroupRequestParameters { Name = name, Description = description, PrivacyType = privacyType } } }, _jsonFormatter);
            return await GetResult<CreateGroupResponse>(result);
        }

        /// <summary>
        /// The API creates a new group in your MangoApps domain.
        /// </summary>
        /// <param name="name">REQUIRED: The name of the new project.</param>
        /// <param name="description">REQUIRED: The description of the new project.</param>
        /// <param name="privacyType">REQUIRED: The privacy type indicator for this new project.</param>
        /// <returns></returns>
        public async Task<CreateProjectResponse> CreateProject(string name, string description, PrivacyType privacyType)
        {
            var result = await _client.PostAsync(URL.Projects + JSON, new RequestParametersContainer<CreateProjectRequest> { Request = new CreateProjectRequest { Project = new CreateGroupRequestParameters { Name = name, Description = description, PrivacyType = privacyType } } }, _jsonFormatter);
            return await GetResult<CreateProjectResponse>(result);
        }

        public async Task<CreateHuddleResponse> CreateHuddle(string huddleOrganizerEmail, IEnumerable<string> membersEmail, string userName)
        {
            var result = await _client.PostAsync(URL.Huddle + JSON, new RequestParametersContainer<CreateHuddleRequest> { Request = new CreateHuddleRequest { Huddle = new Request.Huddle { EmailId = huddleOrganizerEmail, UserName = userName, MemberList = membersEmail.ToList() } } }, _jsonFormatter);
            return await GetResult<CreateHuddleResponse>(result);
        }

        public async Task<EditSelfCreatedGroupOrProjectResponse> EditSelfCreatedGroupProject(int id, string name, string description)
        {
            var result = await _client.PutAsync(URL.Conversations + "/" + id + JSON, new RequestParametersContainer<EditSelfCreatedGroupProjectRequest> { Request = new EditSelfCreatedGroupProjectRequest { Conversation = new Request.Conversation { Name = name, Description = description } } }, _jsonFormatter);
            return await GetResult<EditSelfCreatedGroupOrProjectResponse>(result);
        }

        public async Task<AddMembersToAGroupResponse> AddMembersToGroup(int groupId, IEnumerable<string> addMemberEmails, IEnumerable<int> addMemberIds)
        {
            var result = await _client.PutAsync(URL.Groups + "/" + groupId + "/members.manage" + JSON, new RequestParametersContainer<GroupMembersSyncRequest> { Request = new GroupMembersSyncRequest { Group = new ProjectGroupSync { AddMemberEmails = addMemberEmails.ToList(), AddMemberIds = addMemberIds.ToList(), } } }, _jsonFormatter);
            return await GetResult<AddMembersToAGroupResponse>(result);
        }

        public async Task<AddMembersToAProjectResponse> AddMembersToProject(int projectId, IEnumerable<string> addMemberEmails, IEnumerable<int> addMemberIds)
        {
            var result = await _client.PutAsync(URL.Projects + "/" + projectId + "/members.manage" + JSON, new RequestParametersContainer<ProjectMembersSyncRequest> { Request = new ProjectMembersSyncRequest { Project = new ProjectGroupSync { AddMemberEmails = addMemberEmails.ToList(), AddMemberIds = addMemberIds.ToList(), } } }, _jsonFormatter);
            return await GetResult<AddMembersToAProjectResponse>(result);
        }

        public async Task LeaveProjectOrGroup(string conversationId)
        {
            var response = await _client.DeleteAsync(URL.Conversations + "/" + conversationId + "/leave");
            response.EnsureSuccessStatusCode();
        }

        public async Task<StatusUpdateResponse> StatusUpdate(string message)
        {
            var result = await _client.PostAsync(URL.Feeds + JSON,
                        new RequestParametersContainer<StatusUpdateRequest>
                        {
                            Request = new StatusUpdateRequest { Feed = new StatusUpdateFeed { Body = message, FeedType = "status" } }
                        }, _jsonFormatter);
            return await GetResult<StatusUpdateResponse>(result);
        }

        public async Task<GetAllUsersResponse> GetAllUsers()
        {
            var result = await _client.GetAsync(URL.UsersChangeState + JSON + "?limit=1000");
            return result.Content.ReadAsAsync<ResponseContainer<GetAllUsersResponse>>().Result.Response;
        }

        public async Task<GetAllUsersResponse> ActivateDeactivateUsers(IEnumerable<int> ids, UserStates state)
        {
            var result = await _client.PutAsync(URL.UsersChangeState + JSON, (string)null, _jsonFormatter);
            return result.Content.ReadAsAsync<ResponseContainer<GetAllUsersResponse>>().Result.Response;
        }

        public async Task<UserProfileInfoResponse> GetUser(int userId)
        {
            var result = await _client.GetAsync(URL.Users + string.Format("/{0}" + JSON, userId));
            return await GetResult<UserProfileInfoResponse>(result);
        }

        public async Task<GetAllGroupsResponse> GetAllGroups()
        {
            var result = await _client.GetAsync(URL.Groups + ".json?limit=true");
            return result.Content.ReadAsAsync<ResponseContainer<GetAllGroupsResponse>>().Result.Response;
        }

        public async Task<GetAllGroupsResponse> GetMyGroups()
        {
            var result = await _client.GetAsync(URL.Groups + JSON);
            return result.Content.ReadAsAsync<ResponseContainer<GetAllGroupsResponse>>().Result.Response;
        }

        public async Task<GetAllGroupsResponse> GetProjectTimesheet(int projectId)
        {
            var result = await _client.GetAsync(URL.ProjectTimeSheet.Replace("{project_id}", projectId.ToString()) + JSON);
            return await GetResult<GetAllGroupsResponse>(result);
        }

        public async Task<RemoveMembersFromAGroupResponse> RemoveMembersFromAGroup(int groupId, IEnumerable<int> memberIds)
        {
            var result = await _client.DeleteAsync(URL.Groups + "/" + groupId + "/members.manage" + JSON);
            return await GetResult<RemoveMembersFromAGroupResponse>(result);
        }

        public async Task<RemoveMembersFromAProjectResponse> RemoveMembersFromAProject(int projectId, IEnumerable<int> memberIds)
        {
            var result = await _client.DeleteAsync(URL.Projects + "/" + projectId + "/members.manage" + JSON);
            return await GetResult<RemoveMembersFromAProjectResponse>(result);
        }

        public async Task DeleteAGroup(int groupId)
        {
            var result = await _client.DeleteAsync(URL.Groups + "/" + groupId);
            result.EnsureSuccessStatusCode();
        }

        public async Task DeleteAProject(int projectId)
        {
            var result = await _client.DeleteAsync(URL.Projects + "/" + projectId);
            result.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// The API Logs the current user out of the domain.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MangoException">The request was unauthorized.</exception>
        public async Task Logout()
        {
            await _client.PostAsync(URL.Logout + JSON, (string)null, _jsonFormatter);
        }

        public async Task<UserWallFeedResponse> PostToWall(int userId, string body)
        {
            var result = await _client.PostAsync(URL.Users + string.Format("/{0}/wall.json", userId),
                        new RequestParametersContainer<UserWallRequest>
                        {
                            Request = new UserWallRequest { Feed = new UserWallFeed { Body = body } }
                        }, _jsonFormatter);
            return result.Content.ReadAsAsync<ResponseContainer<UserWallResponse>>().Result.Response.Feed;
        }

        private async Task<T> GetResult<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsAsync<ResponseContainer<T>>();
                return responseResult.Response;
            }
            else
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (Exception e)
                {
                    var errorResponse = response.Content.ReadAsAsync<ErrorResponse>();
                    throw new MangoException(e.Message, e) { ErrorResponse = errorResponse.Result };
                }
                finally
                {
                    throw new Exception();
                }
            }
        }

    }
}
