using System;
using System.Collections.Generic;
using System.Text;
using WS.Data.Entities;

namespace WS.Application.UserService.Dtos
{
    public class RegisterRequest
    {
        public string FullName { get; set; }
        public string PhotoFileName { get; set; }
        
        public DateTime DayOfBirth { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
