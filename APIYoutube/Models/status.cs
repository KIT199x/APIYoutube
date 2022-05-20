using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIYoutube.Models
{
    public class status
    {
        public string privacyStatus { get; set; }
        public bool isLinked { get; set; }
        public string longUploadsStatus { get; set; }
        public bool madeForKids { get; set; }
    }
}
