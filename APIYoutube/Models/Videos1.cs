using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIYoutube.Models
{
    public class Videos1
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public pageInfo pageInfo { get; set; }
        public List<items> items { get; set; }
    }
}
