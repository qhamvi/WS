using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WS.Application.UserService.Dtos;

namespace WS.Application.UserService
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
