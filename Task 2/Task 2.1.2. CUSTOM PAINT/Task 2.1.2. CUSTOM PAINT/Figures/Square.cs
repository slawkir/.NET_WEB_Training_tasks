using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2._CUSTOM_PAINT
{
    class Square : Point
    {
        private double AB;
       
        public Square(double AB) 
        {
            SideAB = AB;
         
            Perimetr = 4 * AB;
            AreaSquare = Math.Pow(AB, 2);
        }

        public double SideAB
        {
            get
            {
                return AB;
            }
            set
            {
                AB = value;
            }
        }
       
        public readonly double Perimetr;
        public readonly double AreaSquare;

        public new string ShowInfFigure()
        {
            return ($"\nЭто объект класса Square:" +
                $"\nпериметр квадрата:{Perimetr}" +
                $"\nплощадь квадрата:{AreaSquare}");

        }
    }
}
