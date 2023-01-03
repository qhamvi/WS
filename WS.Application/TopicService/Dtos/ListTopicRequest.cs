using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Application.TopicService.Dtos
{
    public class ListTopicRequest
    {
        public int Page { get; set; }

        public int PageSize { get; set; }

        public string KeyWord { get; set; }
    }
}
