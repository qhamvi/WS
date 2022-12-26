using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WS.Data.Entities
{
    public class Topic
    {
        public string IdTopic { get; set; }

        public string NameTopic { get; set; }
    }
}
