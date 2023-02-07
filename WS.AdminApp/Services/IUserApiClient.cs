using System.Threading.Tasks;
using WS.Application.UserService.Dtos;

namespace WS.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<ListUserResponse> GetListUser(ListUserRequest request);
        
        Task<bool> RegisterUser(RegisterRequest request);
    
    }
}
