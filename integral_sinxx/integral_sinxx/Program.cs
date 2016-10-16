using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral_sinxx
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 2, i = a;
            Console.WriteLine("vvedite tochnost`");
            decimal e = decimal.Parse(Console.ReadLine());
            decimal integral = 0, s;
            Int32 n = Int32.MaxValue / 2 + 1;
            //for (double i = 0; i < b; i += h)
            //{
                
            //}
            do
            {
                s = Convert.ToDecimal(Math.Sin(i * i) * Convert.ToDouble(n));
                integral += s;
                i = (b - a) / n;
                n /= 2;
            }
            while (Math.Abs(s) < e);
            Console.WriteLine("{0}",integral);
            Console.ReadKey();
        }
    }
}
