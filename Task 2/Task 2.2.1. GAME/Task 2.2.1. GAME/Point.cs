using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1._GAME
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point()
        {
            _x = 0;
            _y = 0;
        }
        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
                if (_x > Game.Width-1)
                {
                    _x = Game.Width - 1;
                }
                if (_x < 0)
                {
                    _x = 0;
                }
            }
        }

    }
}
