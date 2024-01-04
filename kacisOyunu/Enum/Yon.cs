using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kacisOyunu.Enum
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public static class DirectionExtensions
    {
        public static Direction GetDirectionFromKey(Keys keyCode)
        {
            switch (keyCode)
            {
                case Keys.Up:
                    return Direction.Up;

                case Keys.Left:
                    return Direction.Left;

                case Keys.Down:
                    return Direction.Down;

                case Keys.Right:
                    return Direction.Right;

                default:
                    return Direction.Up; // You might want to handle other keys accordingly
            }
        }
    }
}


