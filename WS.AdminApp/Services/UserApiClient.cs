using System.Net.Http;
using System.Threading.Tasks;
using WS.Application.UserService.Dtos;

namespace WS.AdminApp.Services
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public Task<string> Authenticate(LoginRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            //client.PostAsync("http://localhost:8001/api/users/authenticate", );
            client.BaseAddress = new Url("http://localhost:8001");
        }
    }
}
