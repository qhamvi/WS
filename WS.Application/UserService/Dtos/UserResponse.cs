using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Application.UserService.Dtos
{
    public class UserResponse
    {
        public Guid IdUser { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        
    }
}
