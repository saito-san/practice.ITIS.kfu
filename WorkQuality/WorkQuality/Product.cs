using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkQuality
{
    class Product
    {
        public int Barcode { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public bool IsDefective { get; set; }
        public List<WorkLogEntry> WorkLogEntries = new List<WorkLogEntry>();
        public ProductDescription Description { get; set; }
        public TimeSpan TimeSpent
        {
            get
            {
                TimeSpan timespent = new TimeSpan(0, 0, 0);
                for (int i = 0; i < WorkLogEntries.Count; i++)
                    timespent += WorkLogEntries[i].TimeSpent;
                return timespent;
            }
        }
    }
}
