using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WS.Data.Entities;

namespace WS.Application.UserService.Dtos
{
    public class RegisterRequest
    {
        [Display(Name = "Tên")]
        public string FullName { get; set; }

        [Display(Name = "Tên ảnh")]
        public string PhotoFileName { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime DayOfBirth { get; set; }
        [Display(Name = "Quê quán")]
        public string Country { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Display(Name = "Tài khoản")]
        public string Username { get; set; }
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
