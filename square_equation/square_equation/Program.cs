using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_equation
{
    class square_equation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффециент а, уравнения вида ах^2+bx+c");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффециент b, уравнения вида ах^2+bx+c");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффециент c, уравнения вида ах^2+bx+c");
            double c = double.Parse(Console.ReadLine());
            double x1, x2;

            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Количество корней: 2    х1={0}  ; x2={1}", x1, x2);
            }
            else
            {
                if (D == 0)
                {
                    x1 = (-b) / (2 * a);
                    Console.WriteLine("Количество корней: 1    х1={0}", x1);
                }
                else
                    Console.WriteLine("-1");
            }
            Console.ReadKey();
        }
    }
}
