using System.Net.Http;
using MangoApps.Client.Request.Parameters;

namespace MangoApps.Client.Request
{
    public interface IRequest<TRequest, TResponse> where TResponse : new()
    {
        HttpMethod Method { get; }
        string URL { get; }
        RequestParametersContainer<TRequest> Container { get; }
    }
}