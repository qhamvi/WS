using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Data.Entities
{
    public class Comment
    {
        public string IdComment { get; set; }
        public string IdUser { get; set; }
        public User User { get; set; }
        public string IdStory { get; set; }
        public Story Story { get; set; }

        public string Content { get; set; }

        public DateTime DateCom { get; set; }

        public DateTime UpdateCom { get; set; }

    }
}
