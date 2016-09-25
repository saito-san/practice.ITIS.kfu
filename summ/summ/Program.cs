using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summ
{
    class summ
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string a = Console.ReadLine();
            Console.WriteLine("Введите основание системы счисления");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c += Convert.ToInt32(a[i].ToString());
            }
            Console.WriteLine("Сумма цифр числа = {0}", c);
            a = "";
            while (c >= b)
            {
                a += Convert.ToString(c % b);
                c = c / b;
            }
            a += Convert.ToString(c);
            char[] ar = a.ToCharArray();
            Array.Reverse(ar);
            a = new string(ar);

            Console.WriteLine("Сумма цифр числа в {0} системе счисления = {1}", b, a);
            Console.ReadKey(); 
        }
    }
}
