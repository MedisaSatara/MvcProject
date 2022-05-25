using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class EventsVM
    {
        public int EventId { get; set; }
        public string Opponents { get; set; }
        public DateTime TimeOfEvent { get; set; }
        public string Result { get; set; }
        public string Competition { get; set; }
        public string Sport { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
