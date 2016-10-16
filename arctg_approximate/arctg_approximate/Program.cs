using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace arctg_approximate
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите точность");
            decimal arctg0, arctg1, n = decimal.Parse(ReadLine());
            WriteLine("Введите x, тчо |x| > 1 ");
            decimal x = decimal.Parse(ReadLine()), x1 = x, x2 = x * x;
            arctg1 = Convert.ToDecimal(Math.PI * Math.Sqrt(Convert.ToDouble(x2))) / (2 * x);

            int l = 1, i = 0, k = 1;
            do
            {
                arctg0 = arctg1;
                arctg1 += Convert.ToDecimal((k *= -1) / (x1 * l));
                i++;
                x1 *= x2;
                l += 2;
            }
            while ((Math.Abs(arctg1 - arctg0)) > n);
            WriteLine($"\nвычисление верно в широком смысле до этого разряда\n{n}\n{arctg1}\nза {i} шагов\n{Math.Atan(Convert.ToDouble(x))}");
            ReadKey();
        }
    }
}
