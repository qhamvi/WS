using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public List<Comment> Comments { get; set; } 
        public string FullName { get; set; }
        public DateTime CreateDate { get; set; }
        public string PhotoFileName { get; set; }
        public string Country { get; set; }
        public List<UserLikeStory> UserLikeStories { get; set; }
        public List<UserHistoryChapter> UserHistoryChapters { get; set; }


       
    }
}
