using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameJumpingDyno
{
    class Rock
    {
        public string picture = "O";
        private int _positionx = Console.WindowWidth - 1;
        private int _positiony = Console.WindowHeight;

        // Position.
        public int PositionX
        {
            get
            {
                return _positionx;
            }
            private set
            {
                _positionx = value;
            }
        }
        public int PositionY
        {
            get
            {
                return _positiony;
            }
            private set
            {
                _positiony = value;
            }
        }

        // Draw method.
        public void DrawRock()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(picture);
            if (PositionX == 0)
                PositionX = Console.WindowWidth - 1;
            else
                --PositionX;
        }
    }

    class DoubleRock : Rock
    {
        public DoubleRock()
        {
            picture = "OO";
        }
    }
}
