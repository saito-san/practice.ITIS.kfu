using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace integral_sinxx
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 0, b = 2, i = a, h = 1000, c = (b - a) / h;
            WriteLine("vvedite tochnost`");
            decimal n = decimal.Parse(ReadLine());
            int k = 0;
            decimal integral1 = 0, integral0 = 0;
            
            do
            {
                if ((i + c) >= b) 
                {
                    i = a;
                    h *= 10;
                    integral1 = 0;
                    c = (b - a) / h;
                }
                integral0 = integral1;
                integral1 += Convert.ToDecimal(Math.Abs(Math.Sin(Convert.ToDouble(i * i)))) * c;
                i += c;
                k++;
            }
            while ((Math.Abs(integral1 - integral0) > n) || (integral0 == 0));
            WriteLine($"\nвычисление верно в широком смысле до этого разряда\n{n}\n{integral1}\nза {k} шагов");
            ReadKey();
        }
    }
}
