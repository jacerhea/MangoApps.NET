using System.Net.Http;
using System.Runtime.Serialization;
using MangoApps.Client.Request.Parameters;
using MangoApps.Client.Response;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateGroupRequest : IRequest<GroupWallRequestParameters, CreateGroupResponse>
    {
        public CreateGroupRequest(GroupWallRequestParameters loginRequestParameters)
        {
            Container = new RequestParametersContainer<GroupWallRequestParameters> { Request = loginRequestParameters };
        }

        [DataMember(Name = "group")]
        public CreateGroupRequestParameters Group { get; set; }

        public HttpMethod Method { get; private set; }
        public string URL { get { return Client.URL.Groups; }  }
        public RequestParametersContainer<GroupWallRequestParameters> Container { get; private set; }
    }
}