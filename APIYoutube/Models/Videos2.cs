using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIYoutube.Models
{
    public class Videos2
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public pageInfo2 pageInfo { get; set; }
        public List<items2> items { get; set; }
    }
}
