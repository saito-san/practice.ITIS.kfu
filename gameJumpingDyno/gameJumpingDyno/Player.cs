using System;

namespace gameJumpingDyno
{
    interface IJump
    {
        void Jump();
    }

    class Player : IJump
    {
        private string _name;
        private int _positionX = 10;
        private int _positionY = Console.WindowHeight;
        private short _score = 0;

        public Player(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int PositionX
        {
            get
            {
                return _positionX;
            }
            private set
            {
                _positionX = value;
            }
        }

        public int PositionY
        {
            get
            {
                return _positionY;
            }
            private set
            {
                _positionY = value;
            }
        }

        public short Score
        {
            get
            {
                return _score;
            }

            private set
            {
                _score = value;
            }
        }

        public void ScoreInc()
        {
            Score+=1; // Не нравится мне это.
        }

        // Jump method.
        public void Jump()
        {
            if (PositionY == Console.WindowHeight)
                PositionY -= 4;
        }

        // Draw method.
        public void DrawPlayer()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write("X");
            if (PositionY < Console.WindowHeight)
                ++PositionY;
        }
    }
}
