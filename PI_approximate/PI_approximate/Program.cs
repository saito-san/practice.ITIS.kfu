using System;
using static System.Console;

namespace PI_approximate
{
    class Program
    { // бесполезно считать больше чем 0,0000001 :D
        static void Main(string[] args)
        {
            WriteLine("Введите точность");
            decimal PI0, PI1 = 1, 
                    i = 0, k = 1, 
                    l = 1, n = decimal.Parse(ReadLine());

            do
            {
                PI0 = PI1;
                PI1 += 4 / (l += 2) * (k *= -1);
                i++;
            }
            while ((Math.Abs(PI1 - PI0)) > n);
            WriteLine($"\nвычисление верно в широком смысле до этого разряда\n{n}\n{PI1 + 3}\nза {i} шагов\n{Math.PI}");
            ReadKey();
        }
    }
}
