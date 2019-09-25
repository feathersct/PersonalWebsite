using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public enum EventType { Education, Work }

    public class Event
    {
        public int Id { get; set; }
        public string Header2 { get; set; }
        public string Header3 { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public EventType EventType { get; set; }


    }

}
