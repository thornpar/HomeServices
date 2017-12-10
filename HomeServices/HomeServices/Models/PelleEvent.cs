using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models
{
    public class PelleEvent
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public DateTime Date{get; set;}
    }
}
