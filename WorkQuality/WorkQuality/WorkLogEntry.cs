using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkQuality
{
    class WorkLogEntry
    {
        public DateTime DateTime { get; set; }
        public string Responsible { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public string Description { get; set; }
    }
}
