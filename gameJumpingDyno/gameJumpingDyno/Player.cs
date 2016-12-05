using System;

namespace gameJumpingDyno
{
    interface IPlayer
    {
        void Jump();
    }

    class Player : IPlayer
    {
        private string _name;
        private int _positionX = 0;
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
            ++Score; // Не нравится мне это.
        }

        // Jump methos.
        public void Jump()
        {
            PositionY -= 4;
        }

        // Draw method.
        public void DrawPlayer()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write("X");
            if (PositionY > 1)
                --PositionY;
        }
    }
}
