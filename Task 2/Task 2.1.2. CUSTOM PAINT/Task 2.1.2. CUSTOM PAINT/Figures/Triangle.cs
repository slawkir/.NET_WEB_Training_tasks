using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2._CUSTOM_PAINT
{
    internal class Triangle : Point
    {
        private double AB;
        private double BC;
        private double AC;


        public Triangle(double AB, double BC, double AC)
        {
            SideAB = AB;
            SideBC = BC;
            SideAC = AC;
            Perimetr = (AB + BC + AC);
            AreaTriangle = Math.Sqrt(Perimetr/2 * (Perimetr/2 - AB) * (Perimetr/2 - BC) * (Perimetr/2 - AC));
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
        public double SideBC
        {
            get 
            {
                return BC;
            }
            set 
            {
                BC = value;
            }
        }
        public double SideAC
        {
            get
            {
                return AC;
            }
            set
            {
                AC = value;
            }
        }
        public readonly double Perimetr;
        public readonly double AreaTriangle;

        public new string ShowInfFigure()
        {
            return ($"\nЭто объект класса Triangle:" +
                $"\nпериметр треугольника:{Perimetr}\nплощадь треугольника:{AreaTriangle}");
        
        }

    }

   
}
