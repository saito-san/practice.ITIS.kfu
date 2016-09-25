using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessboard
{
    class chessboard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите цвет вашей пешки: 1 - белый; 0 - черный");
            byte color = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите букву начального положения:");
            char character = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифру начального положения:");
            int digit = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите букву клетки, на которую хотите перейти:");
            char nextcharacter = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифру клетки, на которую хотите перейти:");
            int nextdigit = int.Parse(Console.ReadLine());

            if (color == 1)                                                                                             //проверяем для белых
            {
                if ((character == nextcharacter) && ((digit == 2 && nextdigit == 4) || (++digit == nextdigit)))         //проверяем на той же букве
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    if (((character == --nextcharacter) || (character == ++nextcharacter)) && (++digit == nextdigit))       //проверяем на соседних буквах (можем съесть)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            else
            {
                if (color == 0)
                {
                    if ((character == nextcharacter) && ((digit == 7 && nextdigit == 5) || (--digit == nextdigit)))     //проверяем на той же букве
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        if (((character == --nextcharacter) || (character == ++nextcharacter)) && (--digit == nextdigit))   //проверяем на соседних буквах (можем съесть)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неверно выбран цвет!");
                }
            }
            Console.ReadKey();
        }
    }
}
