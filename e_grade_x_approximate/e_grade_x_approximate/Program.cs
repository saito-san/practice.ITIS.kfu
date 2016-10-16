using System;
using static System.Console;

namespace e_grade_x_approximate
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите точность");
            decimal e0, e1 = 1, n = decimal.Parse(ReadLine());
            WriteLine("Введите x");
            double fact = 1, x = double.Parse(ReadLine()), x1 = x;
            int i = 1;

            do
            {
                e0 = e1;
                e1 += Convert.ToDecimal(x1/fact);
                i++;
                x1 *= x;
                fact *= i;
            }
            while ( (e1 - e0) > n );
            WriteLine($"\nвычисление верно в широком смысле до этого разряда\n{n}\n{e1}\nза {i} шагов\n{Math.Exp(Convert.ToDouble(x))}");
            ReadKey();
        }
    }
}
