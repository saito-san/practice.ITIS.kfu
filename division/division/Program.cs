using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division
{
    class division
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число в 2СС");
            string a = Console.ReadLine();
            Console.WriteLine("Введите делитель в 10СС");
            double b = double.Parse(Console.ReadLine());

            double c = 0; 
            int k = a.Length;
            for (int i = 0 ; k > 0; i++)
            {
                if (a[i] == '1')
                    c = c + Math.Pow(2, k-1);
                k--;
            }
            if (c % b == 0)
                Console.WriteLine("{0} Делится нацело  ", c);
            else
                Console.WriteLine("{0} не делится нацело ", c);
            Console.ReadKey();
        }
    }
}
