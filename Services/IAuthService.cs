namespace Cizaro_Blazor_Server.Services
{
    public interface IAuthService
    {
        bool IsAuthenticated { get; }
        bool CheckAuth();
    }
}
