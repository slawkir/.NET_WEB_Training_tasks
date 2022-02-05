using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._Game_Development.Bonus
{
    public class Bonus : GameObject, IPlaceable
    {
        public Bonus() : this(Point.Zero)
        {
        }

        public Bonus(Point point) : base(point)
        {
        }
    }
}
