using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saw_sequence
{
    class saw_sequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите элементы последовательности");
            double b, a = double.Parse(Console.ReadLine());
            char c = '-';
            int i = 0, j = 0, k = 0;
            b = a;
            do
            {
                a = b;
                b = double.Parse(Console.ReadLine());
                if (a > b)
                    i++;
                else
                    j++;

                Console.WriteLine("Хотите вводить дальше? + : да; - : нет");
                c = char.Parse(Console.ReadLine());
                if (c == '-')
                {
                    Console.WriteLine("последовательность пилообразная!");
                    Console.ReadKey();
                    break;
                }
                k++;
            }
            while (((i - j + k) <= 2) && ((j - i + k) <= 2));
            if (((i - j + k) <= 2) && ((j - i + k) <= 2))
            {
                Console.WriteLine("последовательность не пилообразная!");
                Console.ReadKey();
            }
        }
    }
}