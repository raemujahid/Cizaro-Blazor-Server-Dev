namespace Cizaro_Blazor_Server.Services.Interfaces
{
    public interface IHttpService
    {
        Task<TResponse> GetAsync<TResponse>(string uri);
        Task<TResponse> PostAsync<TRequest, TResponse>(string uri, TRequest data);
    }
}
