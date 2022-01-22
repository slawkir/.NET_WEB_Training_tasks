using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2._CUSTOM_PAINT
{
    internal class Rectangle : Square
    {
        public Rectangle(double AB, double BC) : base(AB)
        {
           
            SideBC = BC;
            Perimetr = 2 * (AB + BC);
            AreaRectangle = AB * BC;
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

        public double BC { get; private set; }

        public new readonly double Perimetr;
        public readonly double AreaRectangle;

        public new string ShowInfFigure()
        {
            return ($"\nЭто объект класса Rectangle:" +
                $"\nпериметр прямоугольника:{Perimetr}" +
                $"\nплощадь прямоугольника:{AreaRectangle}");
        }
    }
}
