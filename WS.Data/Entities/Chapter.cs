using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WS.Data.Entities
{
    public class Chapter
    {
        public Guid IdChapter { get; set; }

        public string TitleChap { get; set; }

        public string IdStory { get; set; }
        public Story Story { get; set; }

        public string Collector { get; set; }

        public DateTime CreateDate { get; set; }

        public string Content { get; set; }

        public List<UserHistoryChapter> UserHistoryChapters { get; set; }

    }
}
