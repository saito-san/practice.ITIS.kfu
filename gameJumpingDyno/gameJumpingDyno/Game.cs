﻿using System;
using System.Timers;

namespace gameJumpingDyno
{
    interface IGame
    {
        void Start(Player player);
        void Stop(Player player);
    }
    class Game : IGame
    {
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
            //DrawPlayer() without calling a player ref in parameters
            //DrawRocks()  without calling a player ref in parameters
        }

        // Stops a game.
        public void Stop(Player player)
        {
            Running = false;
            Console.WriteLine($"Ваш счет {player.Score}");
            Console.ReadKey();
        }
    }
}
