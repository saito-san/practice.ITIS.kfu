using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameJumpingDyno
{
    class Menu
    {
        private bool opened;
        private ConsoleKeyInfo _inputKey;
        private int _cursorPositionX;
        private int _cursorPositionY;
        public static List<string> scoreboard = new List<string>();

        public bool Opened
        {
            get
            {
                return opened;
            }

            set
            {
                opened = value;
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

        public int CursorPositionX
        {
            get
            {
                return _cursorPositionX;
            }

            set
            {
                _cursorPositionX = value;
            }
        }
        public int CursorPositionY
        {
            get
            {
                return _cursorPositionY;
            }

            set
            {
                _cursorPositionY = value;
            }
        }

        // Draw method.
        public void DrawMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(3, 0);
            Console.Write("New Game");
            Console.SetCursorPosition(3, 1);
            Console.Write("Scoreboard");
            Console.SetCursorPosition(3, 2);
            Console.Write("Exit");
            Console.SetCursorPosition(CursorPositionX = 0, CursorPositionY = 0);
        }

        public void Open()
        {
            DrawMenu();
            Opened = true;

            //Switch menu positions.
            while (Opened)
            {
                if (Console.KeyAvailable)
                {
                    InputKey = Console.ReadKey(true);
                    switch (InputKey.Key)
                    {
                        
                        case ConsoleKey.UpArrow:
                            CursorPositionY -= 1;
                            Validate();
                            Console.SetCursorPosition(0, CursorPositionY);
                            break;

                        case ConsoleKey.DownArrow:
                            CursorPositionY += 1;
                            Validate();
                            Console.SetCursorPosition(0, CursorPositionY);
                            break;
                       
                        case ConsoleKey.Enter:
                            Select(CursorPositionX, CursorPositionY);
                            break;

                        case ConsoleKey.Escape:
                            DrawMenu();
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        //Select position
        public void Select(int cursorPosX, int cursorPosY)
        {
            switch (cursorPosY)
            {
                case 0:
                    Opened = false;
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать! Введите ваше имя");
                    Player player = new Player(Console.ReadLine());
                    Console.Clear();
                    Game game = new Game();
                    game.Start(player);
                    break;

                case 1:
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < scoreboard.Count; i++)
                    {
                        sb.Append($"{scoreboard[i]}\n");
                    }
                    Console.Clear();
                    Console.WriteLine(sb.ToString());
                    break;

                case 2:
                    Opened = false;
                    break;

                default:
                    break;
            }
        }

        public void Validate()
        {
            if (CursorPositionY >= 3)
                CursorPositionY = 0;
            if (CursorPositionY < 0)
                CursorPositionY = 2;
        }
    }
}
