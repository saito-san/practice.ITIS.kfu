using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameJumpingDyno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Введите ваше имя");
            Player player = new Player(Console.ReadLine());
            Console.Clear();
            Game game = new Game();
            game.Start(player);
        }
    }
}
