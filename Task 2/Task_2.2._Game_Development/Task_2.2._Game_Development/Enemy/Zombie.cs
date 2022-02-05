﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._Game_Development.Common;

namespace Task_2._2._Game_Development
{
   
    public class Zombie : MovableObject
    {
        public int damage = 5;
        public Zombie() : base(Point.Zero)
        { 
        }

        public Zombie(Point point) : base(point)
        {
        }
        public Hit(int damage)
        {
            Player.Health -= damage;
        }

        public override string ToString() // переопределение Player  к строке для вывода в Map
        {
            return $"Zombie, Position: {Position}";
        }

    }
}
