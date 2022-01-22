using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2._CUSTOM_PAINT
{
    internal class Line : Point
    {
        private int x1;
        private int y1;

        private int x2;
        private int y2;

        public Line(int x1, int y1, int x2, int y2) 
        {
            X1 = x1;
            Y1 = y1;

            X2 = x2;
            Y2 = y2;

            Snippet = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2));

        }
        public Line() { } // пустой конструктор отрезка
        public int X1
        {
            get
            {
                return x1;
            }
            set
            {
                x1 = value;
            }
        }
        public int Y1
        {
            get
            {
                return y1;
            }
            set
            {
                y1 = value;
            }
        }
        public int X2
        {
            get
            {
                return x2;
            }
            set
            {
                x2 = value;
            }
        }
        public int Y2
        {
            get
            {
                return y2;
            }
            set
            {
                y2 = value;
            }
        }

        public readonly double Snippet;
        public new string ShowInfFigure()
        {
            return ($"\nЭто объект класса Line:" +
                $"\nкоординаты первой точки X1 = {x1}, Y1 = {y1}" +
                $"\nкоординаты второй точки X1 = {x2}, Y1 = {y2}" +
                $"\nрасстояние между точками равно {Snippet}");
        }
    }
}
