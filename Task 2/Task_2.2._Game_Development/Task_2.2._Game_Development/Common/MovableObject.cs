using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._Game_Development.Common
{
    public class MovableObject: GameObject, IMovable
    {
        public MovableObject() : this(Point.Zero)
        {
        }

        public MovableObject(Point point) : base(point)
        {
        }

        //метод создается 1 раз, далее передается Player и Zombie после наследования

        public void Move(Point to) //переприсвоение позиции
        {
            Position = to;
        }
    }
}
