using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeZnovyALepe
{
    enum Direction
    {
        UP,DOWN,LEFT,RIGHT
    };

    class Settings
    {
        public static int Width;
        public static int Height;
        public static int direction;

        public Settings()
        {
            Width = 160;
            Height = 90;
            direction = (int)Direction.LEFT;
        }
    }
}
