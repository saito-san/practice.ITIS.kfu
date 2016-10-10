using System;
using static System.Console;

namespace e_grade_x_approximate
{
    class Program //работает для (n <= 28)&&(x <= 1), иначе - идет переполнение из-за факториала
    {
        static void Main(string[] args)
        {
            WriteLine("Введите точность - кол-во знаков после запятой");
            int n = int.Parse(ReadLine());
            WriteLine("Введите x");
            decimal e = 1, fact = 1, x = decimal.Parse(ReadLine());
            
            string result;
            int i = 1;
            do
            {
                e += x/fact;
                result = Convert.ToString(Math.Round(e, i - 1));
                i++;
                x *= x;
                fact *= i;
                WriteLine("{0}",result);
            }
            while ((result.Length - result.IndexOf('.') - 1) < n);
            WriteLine("{0:} /n {1} /n {2}", result, i, Math.Exp(Convert.ToDouble(x)));
            ReadKey();
            
        }
    }
}
