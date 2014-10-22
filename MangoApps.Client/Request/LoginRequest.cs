using System.Net.Http;
using MangoApps.Client.Request.Parameters;
using MangoApps.Client.Response;

namespace MangoApps.Client.Request
{
    public class LoginRequest : IRequest<LoginRequestParameters, LoginResponse>
    {
        public LoginRequest(LoginRequestParameters loginRequestParameters)
        {
            Container = new RequestParametersContainer<LoginRequestParameters> { Request = loginRequestParameters };
        }

        public string URL { get { return Client.URL.Login; } }
        public bool HasErrorResponse { get { return true; } }
        public HttpMethod Method { get { return HttpMethod.Post; } }
        public RequestParametersContainer<LoginRequestParameters> Container { get; private set; }
    }
}
