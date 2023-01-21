using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Application.UserService.Dtos
{
    public class ListUserRequest : RequestBase
    {
        public int Page { get; set; }

        public int PageSize { get; set; }

        public string KeyWord { get; set; }
    }
}
