using System;
using System.Collections.Generic;

#nullable disable

namespace ApiProject.Data
{
    public partial class Event
    {
        public int Id { get; set; }
        public string Opponents { get; set; }
        public DateTime TimeOfEvent { get; set; }
        public string Result { get; set; }
        public string Competition { get; set; }
        public string Sport { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
