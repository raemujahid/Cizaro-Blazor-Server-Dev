namespace Cizaro_Blazor_Server.Services.Interfaces
{
    public interface IAuthService
    {
        bool IsAuthenticated { get; }
        bool CheckAuth();
    }
}
