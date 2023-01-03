using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Data.Entities
{
    public class TopicInStory
    {
        public string IdTopic { get; set; }

        public Topic Topic { get; set; }

        public string IdStory { get; set; }

        public Story Story { get; set; }
    }
}
