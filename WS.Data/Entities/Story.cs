using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Data.Entities
{
    public class Story
    {
        public string IdStory { get; set; }

        public string TitleStory { get; set; }

        public string Author { get; set; }

        public string Collector { get; set; }
        public List<Topic> ListTopic { get; set; }
        public List<Chapter> Chapters { get; set; }
        
        public List<Comment> Comments { get; set; }
        public bool IsComplete { get; set; }
        public bool IsAcept { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? PublishDate { get; set; }
        public string ImageFileName { get; set; }

        public int NumberChap { get; set; }
        public string Summary { get; set; }
    }
}
