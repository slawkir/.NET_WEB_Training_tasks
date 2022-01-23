using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1._GAME
{
    public class Player: IMovable, IBody
    {
        public Point Point { get; private set; } = new Point();
    }
}
