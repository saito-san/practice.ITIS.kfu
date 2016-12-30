using System;
using System.Timers;

namespace gameJumpingDyno
{
    interface IStartStop
    {
        void Start(Player player);
        void Stop(Player player);
    }
    class Game : IStartStop
    {
        Player player;
        
        Rock rock1 = new Rock();
        DoubleRock rock2 = new DoubleRock();

        static Timer timer = new Timer(1000);
        private bool _running = true;
        private ConsoleKeyInfo _inputKey;

        public bool Running
        {
            get
            {
                return _running;
            }
            private set
            {
                _running = value;
            }
        }

        private ConsoleKeyInfo InputKey
        {
            get
            {
                return _inputKey;
            }
            set
            {
                _inputKey = value;
            }
        }

        // Starts a game.
        public void Start(Player player)
        {
            // Game cycle.
            this.player = player;
            timer.Interval = 150;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;

            while (Running)
            {
                // Players input.
                if (Console.KeyAvailable)
                {
                    InputKey = Console.ReadKey(true);
                    switch (InputKey.Key)
                    {
                        // Exit a game.
                        case ConsoleKey.Escape:
                            Stop(player);
                            break;

                        // Jump.
                        case ConsoleKey.Spacebar:
                            player.Jump();
                            break;

                        default:
                            break;
                    }
                }

                // Death.
                if ((player.PositionX == rock1.PositionX) || (player.PositionX == rock2.PositionX))
                    if (player.PositionY == Console.WindowHeight)
                    {
                        Stop(player);
                    }

                // Score increase.
                if ((player.PositionX == rock1.PositionX) || (player.PositionX == rock2.PositionX))
                    if (player.PositionY != Console.WindowHeight)
                        player.ScoreInc();
            }
        }

        // Redraw event.
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            Redraw();
        }

        // Redraw method.
        private void Redraw()
        {
            //TODO
            player.DrawPlayer();
            rock1.DrawRock();
            if ((rock1.PositionX <= Console.WindowWidth / 2) || (rock2.PositionX != Console.WindowWidth - 1))
                rock2.DrawRock();
            Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight);
        }

        // Stops a game.
        public void Stop(Player player)
        {
            Running = false;
            timer.Stop();
            Console.Clear();
            Console.WriteLine($"Вы проиграли. Ваши очки {player.Score}");
            Menu.scoreboard.Add($"{player.Name}\t\t{player.Score}");
            Console.ReadKey();
            Menu menu = new Menu();
            menu.Open();
        }
    }
}
