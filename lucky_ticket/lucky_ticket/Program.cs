using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucky_ticket
{
    class lucky_ticket
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифры с билета последвательно по одной");
            int a, b, c, d, e, f;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());
                        
            if ((a + b + c == d + e + f + 1) || (a + b + c == d + e + f - 1))
                Console.WriteLine("Ваш билет почти счастливый!");
            else
                Console.WriteLine("Ваш билет не почти счастливый");
            Console.ReadKey();
        }
    }
}
