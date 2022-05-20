using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIYoutube.Models
{
    public class items2
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public snippet2 snippet { get; set; }
        public contentDetails2 contentDetails { get; set; }
        public statistics2 statistics { get; set; }
        public status2 status { get; set; }
    }
}
