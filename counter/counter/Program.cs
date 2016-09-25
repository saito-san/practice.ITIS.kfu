using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class counter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двоичное представление числа");
            string a = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == '1')
                    k++;
            Console.WriteLine("количество единиц в двоичной записи числа - {0}", k);
            Console.ReadKey();

        }
    }
}
