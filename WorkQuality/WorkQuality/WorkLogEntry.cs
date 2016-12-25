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



        public override string ToString()
        {
            return String.Format($"\t{DateTime}\t{Responsible}\t{TimeSpent}\t{Description}");
        }
    }
}
