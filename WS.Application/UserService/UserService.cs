using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WS.Application.UserService.Dtos;
using WS.Data.Entities;
using WS.Utilities.Exceptions;

namespace WS.Application.UserService
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        public UserService(UserManager<User> userManager, 
            SignInManager<User> signInManager,
            RoleManager<Role> roleManager,
            IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.Username);
            if (existingUser == null)
            {
                return null; 
            }
            var result = await _signInManager.PasswordSignInAsync(existingUser, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return null;
            }
            var roles = await _userManager.GetRolesAsync(existingUser);

            var claimUser = new[]
            {
                new Claim(ClaimTypes.Name, existingUser.FullName),
                new Claim(ClaimTypes.Email, existingUser.Email),
                new Claim(ClaimTypes.MobilePhone, existingUser.PhoneNumber),
                new Claim(ClaimTypes.Role, string.Join(',',roles)),

            };
            //ma hoa Claim
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claimUser,
                expires: DateTime.Now.AddDays(0.5),
                signingCredentials: creds
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var user = new User()
            {
                FullName = request.FullName,
                UserName = request.Username,
                CreateDate = DateTime.Now,
                PhotoFileName = request.PhotoFileName,
                Country = request.Country,
                PhoneNumber = request.Country,
                Email = request.Email,
                DOB = request.DayOfBirth

            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if(result.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
