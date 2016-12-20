using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkQuality
{
    class ProductDescription
    {
        public int Article { get; set; }
        public string Title { get; set; }
        public TimeSpan StandartTime { get; set; }

        public override string ToString()
        {
            return String.Format($"\t\tArticle:{Article}\tTitle:{Title}\tStandart time:{StandartTime}\n");
        }
    }
}
