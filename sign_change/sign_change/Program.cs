using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sign_change
{
    class sign_change
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите элементы последовательности");
            double b, a = double.Parse(Console.ReadLine());
            char c = '-';
            int i = 0;
            b = a;
            do
            {
                a = b;
                b = double.Parse(Console.ReadLine());
                if (((a > 0) && (b < 0)) || ((a < 0) && (b > 0)))
                    i++;
                
                Console.WriteLine("Хотите вводить дальше? + : да; - : нет");
                c = char.Parse(Console.ReadLine());
                if (c == '-')
                {
                    Console.WriteLine("смена знака произошла {0} раз", i);
                    Console.ReadKey();
                    break;
                }
            }
            while (true);
        }
    }
}
