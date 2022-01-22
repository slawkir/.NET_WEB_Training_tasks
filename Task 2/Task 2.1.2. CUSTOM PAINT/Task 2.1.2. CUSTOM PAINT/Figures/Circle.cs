using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2._CUSTOM_PAINT
{
    internal class Circle : Point
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
            Diametr = Radius * 2;
            Circumference = Math.PI * 2 * Radius;
            Area = Math.PI * Math.Pow(Radius, 2);
        }
       


        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public readonly double Diametr;
        public readonly double Circumference;
        public readonly double Area;

        public new string ShowInfFigure()
        {
            return ($"\nЭто круг, объект класса CIRCLE :" +
                $"\n радиус = {Radius}" +
                $"\nдиаметр = {Diametr}" +
                $"\nдлина окружности = {Circumference}" +
                $"\nплощадь круга = {Area}");

        }

    }
}
