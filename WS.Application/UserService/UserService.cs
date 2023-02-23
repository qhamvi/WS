using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
        private readonly IMapper _mapper;
        public UserService(UserManager<User> userManager, 
            SignInManager<User> signInManager,
            RoleManager<Role> roleManager,
            IConfiguration config,
            IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _mapper = mapper;
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

        public async Task<ListUserResponse> GetListUser(ListUserRequest request)
        {
            var query = _userManager.Users;

            //filter
            if (!string.IsNullOrEmpty(request.KeyWord))
            {
                query = query.Where(v => v.FullName.Contains(request.KeyWord) ||
                v.PhoneNumber.Contains(request.KeyWord));
            }
            //paging
            int totalRow = await query.CountAsync();
            if (request.Page == 0)
            {
                request.Page = 1;
            }
            if (request.PageSize == 0)
            {
                request.PageSize = 10;
            }
            var data = query.Skip((request.Page - 1) * request.PageSize).Take(request.PageSize);
            //select and projection
            var pageResult = new ListUserResponse()
            {
                Count = totalRow,
                Page = request.Page,
                PageSize = request.PageSize,
                Results = data.Select(user => _mapper.Map<UserResponse>(user)).ToList()
            };
            return pageResult;
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            //var existUser = await _userManager.FindByEmailAsync(request.Email);
            //if(existUser != null)
            //{
            //    return false;
            //}
            var user = new User()
            {
                FullName = request.FullName,
                UserName = request.Username,
                CreateDate = DateTime.Now,
                PhotoFileName = request.PhotoFileName,
                Country = request.Country,
                PhoneNumber = request.PhoneNumber,
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
