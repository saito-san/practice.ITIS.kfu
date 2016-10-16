using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace division_approximate
{
    class Program
    {
        static void Main(string[] args)
        {
        // В ЗАДАНИИ ФОРМУЛА НЕ ПРАВИЛЬНАЯ
        // поэтому в ответе получается какая-то дичь:
        // не может получиться 1 / (1 + х)^2 из (-1)^n * x^n * (1 + n)
            WriteLine("Введите точность");
            decimal division0, division1 = 1, n = decimal.Parse(ReadLine());
            WriteLine("Введите x, тчо |x| < 1 ");
            decimal x = decimal.Parse(ReadLine()), x1 = x;

            int i = 0, k = 1;
            do
            {
                division0 = division1;
                division1 += Convert.ToDecimal((k *= -1) * (++i + 1)) * x1;
                x1 *= x;
                WriteLine($"{division1}");
            }
            while ((Math.Abs(division1 - division0)) > n);
            WriteLine($"\nвычисление верно в широком смысле до этого разряда\n{n}\n{division1}\nза {i} шагов");
            ReadKey();
        }
    }
}
