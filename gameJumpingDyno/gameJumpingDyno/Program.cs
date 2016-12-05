using System;

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
