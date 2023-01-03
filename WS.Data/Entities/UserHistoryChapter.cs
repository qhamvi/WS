using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WS.Data.Entities
{
    public class UserHistoryChapter
    {
        public Guid IdUser { get; set; }

        public User User { get; set; }

        public Guid IdChapter { get; set; }

        public Chapter Chapter { get; set; }
    }
}