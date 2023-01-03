using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Utilities.ListResponse
{
    public class ListResponse<T> where T : class 
    {
        public string Page { get; set; }

        public string PageSize { get; set; }

        public string Count { get; set; }

        public List<T> Results { get; set; }
    }
}
