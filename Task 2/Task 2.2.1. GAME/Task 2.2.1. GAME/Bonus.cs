using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1._GAME
{
    public class Bonus
    {
        public Bonus(Point point)
        {
            Point = point;
           // ChangeBonus();
        }

        public abstract int HelpValue { get; }
        public Point Point { get; }

    }
}
