using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WS.Data.Entities
{
    public class UserLikeStory
    {
        public Guid IdUser { get; set; }

        public User User { get; set; }

        public string IdStory { get; set; }

        public Story Story { get; set; }
    }
}