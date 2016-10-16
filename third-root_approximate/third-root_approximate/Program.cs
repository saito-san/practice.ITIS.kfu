using System;
using static System.Console;

namespace third_root_approximate
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите точность");
            decimal thirdroot0 = 0, thirdroot1,
                    n = decimal.Parse(ReadLine());
            int i = 0;
            WriteLine("Введите х");
            decimal x = decimal.Parse(ReadLine());

            if (x < 1)
                thirdroot1 = x;
            else
                thirdroot1 = x / 3;
            
            do
            {
                thirdroot0 = thirdroot1;
                thirdroot1 = thirdroot0 - (thirdroot0 - (x / thirdroot0 / thirdroot0)) / 3;
                i++;
            }
            while ((thirdroot0 - thirdroot1) > n);
            WriteLine($"\nвычисление верно в широком смысле до этого разряда\n{n}\n{thirdroot1}\nза {i} шагов\n");
            ReadKey();
        }
    }
}
