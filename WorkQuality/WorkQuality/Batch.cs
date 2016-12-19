using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkQuality
{
    class Batch
    {
        public int Barcode { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Product> Products = new List<Product>();
        public byte Quality { get; private set; }

        public static byte Qualify(Batch batch)
        {
            int notDefective = 0;
            int intime = 0;
            int intime5 = 0;

            for (int i = 0; i < batch.Products.Count; i++)
            {
                if (batch.Products[i].IsDefective != false)
                    ++notDefective;
                if ( batch.Products[i].TimeSpent <= batch.Products[i].Description.StandartTime)
                    ++intime;
                if ((batch.Products[i].TimeSpent >  batch.Products[i].Description.StandartTime) &&
                    (batch.Products[i].TimeSpent <= batch.Products[i].Description.StandartTime + new TimeSpan(0, 5, 0)))
                    ++intime5;
            }

            byte DefectivePercentage = Convert.ToByte(notDefective / batch.Products.Count * 100);
            byte IntimePercentage = Convert.ToByte(intime / batch.Products.Count * 100);
            byte Intime5Percentage = Convert.ToByte(intime5 / batch.Products.Count * 100);

            if ((DefectivePercentage <= 3) && (IntimePercentage >= 80) && (intime + intime5 == batch.Products.Count))
                return 1;

            if ((DefectivePercentage <= 5) && (IntimePercentage >= 75))
                return 2;

            return 3;
        }
    }
}
