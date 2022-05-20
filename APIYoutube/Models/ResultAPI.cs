using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIYoutube.Models
{
    public class ResultAPI
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Channel { get; set; }
        public object Videos { get; set; }
    }
}
