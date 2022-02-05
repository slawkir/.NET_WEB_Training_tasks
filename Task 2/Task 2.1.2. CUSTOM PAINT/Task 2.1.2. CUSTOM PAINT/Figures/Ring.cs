using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2._CUSTOM_PAINT
{
    class Ring : Point
    {
        private double radiusExternal;
        private double radiusInternal;

        public Ring(double radiusInternal, double radiusExternal)
        {

            RadiusExternal = radiusExternal;
            RadiusInternal = radiusInternal;
            
           
            CommonCircumference = Math.PI * 2 * (RadiusInternal + RadiusExternal);
            AreaOfRing = Math.PI * Math.Pow(RadiusExternal, 2) - Math.PI*Math.Pow(RadiusInternal, 2);
        }
        public double RadiusInternal
        {
            get
            {
                return radiusInternal;
            }
            set
            {
                radiusInternal = value;
            }
        }

        public double RadiusExternal
        {
            get 
            {
                return radiusExternal;
            }
            set 
            {
                radiusExternal = value;
            }
        }
        
       
        public readonly double AreaOfRing;
        public readonly double CommonCircumference;
        
        public new string ShowInfFigure()
        {
            return string.Format($"\nЭто объекта класса Ring class:" +
                $"\nплощадь кольца = {AreaOfRing}" +
                $"\nобщая длина окружностей кольца = {CommonCircumference}");

        }

    }
}
