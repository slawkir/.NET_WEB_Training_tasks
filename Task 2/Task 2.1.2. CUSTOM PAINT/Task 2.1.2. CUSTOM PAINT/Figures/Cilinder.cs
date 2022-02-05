using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2._CUSTOM_PAINT
{
     class Cilinder : Circle
    {
        int height;
        public Cilinder(int radius, int height) : base (radius)
        {
            Height = height;
            Volume = Math.PI * Math.Pow(Radius, 2) * Height;
            Area = (2 * Math.PI * Radius * Height) + (2 * Math.PI * Math.Pow(radius, 2));
        }

        public int Height
        { 
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public readonly double Volume;
        new public readonly double Area;

        public new string ShowInfFigure()
        {
            return string.Format($"\nЭто объект класса Cilinder" +
                $"\nобъем цилиндра = {Volume}" +
                $"\nплощадь поверхности = {Area}");
        }
            
    }
}
