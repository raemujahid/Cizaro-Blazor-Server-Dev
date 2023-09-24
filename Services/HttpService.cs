using Blazored.LocalStorage;
using Cizaro_Blazor_Server.Services.Interfaces;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Cizaro_Blazor_Server.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        protected readonly ILocalStorageService _localStorage;

        public HttpService(HttpClient httpClient, ILocalStorageService LocalStorage)
        {
            _httpClient = httpClient;
            _localStorage = LocalStorage;
        }

        public async Task<TResponse> GetAsync<TResponse>(string uri)
        {
            AddBearerToken();
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            return await HandleResponse<TResponse>(response);
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string uri, TRequest data)
        {
            AddBearerToken();
            HttpContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(uri, content);
            return await HandleResponse<TResponse>(response);
        }

        private async Task<T> HandleResponse<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseData);
            }
            else
            {
                throw new HttpRequestException($"HTTP request failed with status code {response.StatusCode}");
            }
        }
        private async void AddBearerToken()
        {
            var _token = await _localStorage.GetItemAsStringAsync("auth_token");
            if (!string.IsNullOrEmpty(_token) && _token.Length >= 2)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            }           
        }
    }
}