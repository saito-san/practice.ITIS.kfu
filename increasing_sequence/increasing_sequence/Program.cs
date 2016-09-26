using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increasing_sequence
{
    class increasing_sequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите элементы последовательности");
            double b, a = double.Parse(Console.ReadLine());
            char c = '-';
            b = a;
            do
            {
                a = b;
                b = double.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("последовательность не возрастающая!");
                    break;
                }
                else
                {
                    Console.WriteLine("Хотите вводить дальше? + : да; - : нет");
                    c = char.Parse(Console.ReadLine());
                    if (c == '-')
                    {
                        Console.WriteLine("последовательность возрастающая!");
                        break;
                    }
                }
            }
            while (a < b);
            Console.ReadKey();
        }
    }
}
