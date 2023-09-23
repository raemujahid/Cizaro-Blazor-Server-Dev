using Blazored.LocalStorage;


namespace Cizaro_Blazor_Server.Services
{
    public class AuthService : IAuthService
    {
        protected readonly ILocalStorageService _localStorage;
        public bool IsAuthenticated { get; private set; }

        public AuthService(ILocalStorageService LocalStorage)
        {
            _localStorage = LocalStorage;
        }
        public bool CheckAuth()
        {
            var token = _localStorage.GetItemAsStringAsync("auth_token");
            if (!string.IsNullOrEmpty(token.ToString()))
            {
                IsAuthenticated  = true; 
            }
            else
            {
                IsAuthenticated = false;
            }
            return IsAuthenticated;
        }
    }
}