using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._Game_Development
{
    public abstract class GameObject : IPlaceable
    {
        public Point Position { get; protected set; }

        public GameObject(Point point)
        {
            Position = point;
        }
        public GameObject() : this(Point.Zero) // Point.Zero статическое вычисляемое свойство, возвращает точку (0;0)
        { 
        
        }
    }
}
