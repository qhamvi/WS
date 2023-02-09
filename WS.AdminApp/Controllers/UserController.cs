using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WS.AdminApp.Services;
using WS.Application.UserService.Dtos;
using WS.Utilities.Exceptions;

namespace WS.AdminApp.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;

        public UserController(IUserApiClient userApiClient, IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex, int pageSize)
        {
            var sessions = HttpContext.Session.GetString("Token");
            var request = new ListUserRequest()
            {
                BearerToken = sessions,
                KeyWord = keyword,
                Page = pageIndex,
                PageSize = pageSize
            };
            var data = await _userApiClient.GetListUser(request);
            return View(data);

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequest registerRequest)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userApiClient.RegisterUser(registerRequest);
            if(result)
            {
                return RedirectToAction("Index");
            }
            return View(registerRequest);

        }

        
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Login", "User");
        }

      
    }
}
