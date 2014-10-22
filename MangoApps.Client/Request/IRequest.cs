using System.Net.Http;
using MangoApps.Client.Request.Parameters;

namespace MangoApps.Client.Request
{
    public interface IRequest<TRequest, TResponse> where TResponse : new()
    {
        string URL { get; }
        bool HasErrorResponse { get; }
        HttpMethod Method { get; }
        RequestParametersContainer<TRequest> Container { get; }
    }
}