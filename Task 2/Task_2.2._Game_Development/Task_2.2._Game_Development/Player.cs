using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._Game_Development.Common;

namespace Task_2._2._Game_Development
{
    public class Player : MovableObject
    {
        public Player(Point spawnPoint) : base(spawnPoint) //конструктор принимает точку появления игрока
        {
            
        }
        public Player() : base(Point.Zero) //конструктор
        {
            
        }

        public override string ToString() // переопределение Player  к строке для вывода в Map
        {
            return $"Player, Position: {Position}";
        }


    }
}
