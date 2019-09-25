using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string IPAddress { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
